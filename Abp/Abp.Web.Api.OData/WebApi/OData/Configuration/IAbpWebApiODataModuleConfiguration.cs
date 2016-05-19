﻿using System.Web.OData.Builder;

namespace Abp.WebApi.OData.Configuration
{
    /// <summary>
    /// Used to configure Abp.Web.Api.OData module.
    /// </summary>
    public interface IAbpWebApiODataModuleConfiguration
    {
        /// <summary>
        /// Gets ODataConventionModelBuilder.
        /// </summary>
        ODataConventionModelBuilder ODataModelBuilder { get; }
    }
}