﻿using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.Modularity;

namespace YingHua.Abp.Components.Web.BasicTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebThemingModule)
        )]
    public class AbpAspNetCoreComponentsWebBasicThemeModule : AbpModule
    {
        
    }
}