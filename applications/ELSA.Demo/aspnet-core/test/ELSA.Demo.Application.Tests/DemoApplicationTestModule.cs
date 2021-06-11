using Volo.Abp.Modularity;

namespace ELSA.Demo
{
    [DependsOn(
        typeof(DemoApplicationModule),
        typeof(DemoDomainTestModule)
        )]
    public class DemoApplicationTestModule : AbpModule
    {

    }
}