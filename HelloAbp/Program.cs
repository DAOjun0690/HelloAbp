using HelloAbp;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

var application = AbpApplicationFactory.Create<AppModule>(option => { 

});
// 初始化
application.Initialize();

//var service = application.ServiceProvider.GetService<HelloWorldService>()!;

//service.Run();