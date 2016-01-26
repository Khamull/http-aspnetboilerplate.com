using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace sample
{
    [DependsOn(typeof(sampleCoreModule), typeof(AbpAutoMapperModule))]
    public class sampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
