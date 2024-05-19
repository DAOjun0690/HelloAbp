using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace HelloAbp
{
    public class AppModule : AbpModule
    {
        /// <summary>
        /// 在下面的 ConfigureServices 之前執行
        /// </summary>
        /// <param name="context"></param>
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            base.PreConfigureServices(context);
        }

        /// <summary>
        /// 注入Service
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //base.ConfigureServices(context);
            context.Services.AddTransient<HelloWorldService>();
        }

        /// <summary>
        /// 在上面的 ConfigureServices 之後執行
        /// </summary>
        /// <param name="context"></param>
        public override void PostConfigureServices(ServiceConfigurationContext context)
        {
            base.PostConfigureServices(context);
        }

        public override void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnPreApplicationInitialization(context);
        }

        /// <summary>
        /// 初始化啟動時執行，初始化服務
        /// </summary>
        /// <param name="context"></param>
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            //base.OnApplicationInitialization(context);
            var service = context.ServiceProvider.GetService<HelloWorldService>()!;
            service.Run();
        }

        public override void OnPostApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnPostApplicationInitialization(context);
        }
    }
}
