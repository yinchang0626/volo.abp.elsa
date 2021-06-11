using ELSA.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ELSA.Demo
{
    [DependsOn(
        typeof(DemoEntityFrameworkCoreTestModule)
        )]
    public class DemoDomainTestModule : AbpModule
    {

    }
}