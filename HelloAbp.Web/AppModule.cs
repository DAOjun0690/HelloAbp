using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace HelloAbp.Web
{
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]
    public class AppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context) 
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                // 註冊開發頁面
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseConfiguredEndpoints();
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            base.OnApplicationShutdown(context);
        }
    }
}
