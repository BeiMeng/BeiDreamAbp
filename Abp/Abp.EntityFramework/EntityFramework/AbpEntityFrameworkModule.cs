﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using Abp.Collections.Extensions;
using Abp.Dependency;
using Abp.EntityFramework.Repositories;
using Abp.EntityFramework.Uow;
using Abp.Modules;
using Abp.Reflection;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;

namespace Abp.EntityFramework
{
    /// <summary>
    /// This module is used to implement "Data Access Layer" in EntityFramework.
    /// </summary>
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpEntityFrameworkModule : AbpModule
    {
        public ILogger Logger { get; set; }

        private readonly ITypeFinder _typeFinder;

        public AbpEntityFrameworkModule(ITypeFinder typeFinder)
        {
            _typeFinder = typeFinder;
            Logger = NullLogger.Instance;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            IocManager.IocContainer.Register(
                Component.For(typeof(IDbContextProvider<>))
                    .ImplementedBy(typeof(UnitOfWorkDbContextProvider<>))
                    .LifestyleTransient()
                );

            RegisterGenericRepositoriesAndMatchDbContexes();
        }

        private void RegisterGenericRepositoriesAndMatchDbContexes()
        {
            var dbContextTypes =
                _typeFinder.Find(type =>
                    type.IsPublic &&
                    !type.IsAbstract &&
                    type.IsClass &&
                    typeof(AbpDbContext).IsAssignableFrom(type)
                    );

            if (dbContextTypes.IsNullOrEmpty())
            {
                Logger.Warn("No class found derived from AbpDbContext.");
                return;
            }

            using (var repositoryRegistrar = IocManager.ResolveAsDisposable<EntityFrameworkGenericRepositoryRegistrar>())
            {
                foreach (var dbContextType in dbContextTypes)
                {
                    repositoryRegistrar.Object.RegisterForDbContext(dbContextType, IocManager);
                }
            }

            using (var dbContextMatcher = IocManager.ResolveAsDisposable<IDbContextTypeMatcher>())
            {
                foreach (var dbContextType in dbContextTypes)
                {
                    var types = new List<Type>();
                    AddWithBaseTypes(dbContextType, types);
                    foreach (var type in types)
                    {
                        dbContextMatcher.Object.Add(type, dbContextType);
                    }
                }
            }
        }

        private static void AddWithBaseTypes(Type dbContextType, List<Type> types)
        {
            types.Add(dbContextType);
            if (dbContextType != typeof(DbContext))
            {
                AddWithBaseTypes(dbContextType.BaseType, types);
            }
        }
    }
}
