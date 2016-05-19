﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Abp.Collections;
using Abp.Modules;
using Abp.TestBase.SampleApplication.ContacLists;
using Abp.TestBase.SampleApplication.Crm;
using Abp.TestBase.SampleApplication.EntityFramework;
using Abp.TestBase.SampleApplication.People;
using Castle.MicroKernel.Registration;
using EntityFramework.DynamicFilters;

namespace Abp.TestBase.SampleApplication.Tests
{
    public abstract class SampleApplicationTestBase : AbpIntegratedTestBase
    {
        protected SampleApplicationTestBase()
        {
            //Fake DbConnection using Effort!
            LocalIocManager.IocContainer.Register(
                Component.For<DbConnection>()
                    .UsingFactoryMethod(Effort.DbConnectionFactory.CreateTransient)
                    .LifestyleSingleton()
                );

            CreateInitialData();
        }

        private void CreateInitialData()
        {
            UsingDbContext(
                context =>
                {
                    context.ContactLists.Add(
                        new ContactList
                        {
                            TenantId = 1,
                            Name = "List of Tenant-1",
                            People = new List<Person>
                                     {
                                         new Person {Name = "halil"},
                                         new Person {Name = "emre", IsDeleted = true}
                                     }
                        });

                    context.ContactLists.Add(
                        new ContactList
                        {
                            TenantId = 2,
                            Name = "List of Tenant-2",
                            People = new List<Person>
                                     {
                                         new Person {Name = "asimov"},
                                     }
                        });
                });

            UsingDbContext(
                context =>
                {
                    context.Messages.Add(
                        new Message
                        {
                            TenantId = null,
                            Text = "host-message-1"
                        });

                    context.Messages.Add(
                        new Message
                        {
                            TenantId = 1,
                            Text = "tenant-1-message-1"
                        });

                    context.Messages.Add(
                        new Message
                        {
                            TenantId = 1,
                            Text = "tenant-1-message-2"
                        });
                });

            UsingDbContext(
              context =>
              {
                  AddCompany(context, 
                      "Volosoft",
                      "Turkey",
                      "Istanbul", 
                      "Denizkoskler Mah. Avcilar", 
                      "Halil",
                      "Gumuspala Mah. Avcilar",
                      "Ismail", 
                      "Headquarter", 
                      "Europe Headquarter");

                  AddCompany(context,
                      "Microsoft",
                      "USA",
                      "New York",
                      "Herkimer St, Brooklyn, NY",
                      "Neal",
                      "Vinegar Hill, Brooklyn, NY",
                      "Peter",
                      "Main Office",
                      "IT Office");
              });
        }

        private void AddCompany(SampleApplicationDbContext context,string name,string country, string city, string address1, string modifier1, string address2, string modifier2, string branchName1, string branchName2)
        {
            context.Companies.Add(new Company
            {
                Name = name,
                CreationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Utc),
                BillingAddress = new Address
                {
                    Country = country,
                    City = city,
                    FullAddress = address1,
                    CreationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Local),
                    LastModifier = new Modifier
                    {
                        Name = modifier1,
                        ModificationTime = new DateTime(2016, 03, 16, 0, 0, 0, DateTimeKind.Local)
                    }
                },
                ShippingAddress = new Address
                {
                    Country = country,
                    City = city,
                    FullAddress = address2,
                    CreationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Utc),
                    LastModifier = new Modifier
                    {
                        Name = modifier2,
                        ModificationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Utc)
                    }
                },
                Branches = new List<Branch>
                      {
                          new Branch
                          {
                              Name = branchName1,
                              CreationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Local),
                          },
                          new Branch()
                          {
                              Name = branchName2,
                              CreationTime = new DateTime(2017, 03, 16, 0, 0, 0, DateTimeKind.Utc)
                          }
                      }
            });
        }

        protected override void AddModules(ITypeList<AbpModule> modules)
        {
            base.AddModules(modules);
            modules.Add<SampleApplicationTestModule>();
        }

        public void UsingDbContext(Action<SampleApplicationDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<SampleApplicationDbContext>())
            {
                context.DisableAllFilters();
                action(context);
                context.SaveChanges();
            }
        }

        public T UsingDbContext<T>(Func<SampleApplicationDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SampleApplicationDbContext>())
            {
                context.DisableAllFilters();
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        public async Task<T> UsingDbContextAsync<T>(Func<SampleApplicationDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SampleApplicationDbContext>())
            {
                context.DisableAllFilters();
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}