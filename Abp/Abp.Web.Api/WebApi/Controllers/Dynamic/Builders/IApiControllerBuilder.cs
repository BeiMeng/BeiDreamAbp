using System;
using System.Web.Http.Filters;
using Abp.Web;

namespace Abp.WebApi.Controllers.Dynamic.Builders
{
    /// <summary>
    /// This interface is used to define a dynamic api controller.
    /// </summary>
    /// <typeparam name="T">Type of the proxied object</typeparam>
    public interface IApiControllerBuilder<T>
    {
        /// <summary>
        /// Name of the controller.
        /// </summary>
        string ServiceName { get; }

        /// <summary>
        /// Gets type of the service interface for this dynamic controller.
        /// It's typeof(T).
        /// </summary>
        Type ServiceInterfaceType { get; }

        /// <summary>
        /// Action Filters to apply to this dynamic controller.
        /// </summary>
        IFilter[] Filters { get; }

        /// <summary>
        /// True, if using conventional verbs for this dynamic controller.
        /// </summary>
        bool ConventionalVerbs { get; }

        /// <summary>
        /// To add Action filters for the Dynamic Controller.
        /// </summary>
        /// <param name="filters"> The filters. </param>
        /// <returns>The current Controller Builder </returns>
        IApiControllerBuilder<T> WithFilters(params IFilter[] filters);

        /// <summary>
        /// Used to specify a method definition.
        /// </summary>
        /// <param name="methodName">Name of the method in proxied type</param>
        /// <returns>Action builder</returns>
        IApiControllerActionBuilder<T> ForMethod(string methodName);

        /// <summary>
        /// Used to perform actions for each method.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>The current Controller Builder</returns>
        IApiControllerBuilder<T> ForMethods(Action<IApiControllerActionBuilder> action);

        /// <summary>
        /// Use conventional Http Verbs by method names.
        /// By default, it uses <see cref="HttpVerb.Post"/> for all actions.
        /// </summary>
        /// <returns>The current Controller Builder</returns>
        IApiControllerBuilder<T> WithConventionalVerbs();

        /// <summary>
        /// Builds the controller.
        /// This method must be called at last of the build operation.
        /// </summary>
        void Build();
    }
}