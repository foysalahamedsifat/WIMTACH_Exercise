﻿using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using MyCollegeV1.Authorization.Roles;
using MyCollegeV1.Authorization.Users;
using MyCollegeV1.Configuration;
using MyCollegeV1.Localization;
using MyCollegeV1.MultiTenancy;
using MyCollegeV1.Timing;

namespace MyCollegeV1
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MyCollegeV1CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MyCollegeV1LocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = MyCollegeV1Consts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
                        
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MyCollegeV1Consts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = MyCollegeV1Consts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCollegeV1CoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
