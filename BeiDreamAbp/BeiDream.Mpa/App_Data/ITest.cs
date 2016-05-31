using Abp.Dependency;

namespace BeiDream.Mpa.App_Data
{
    public interface ITest:ITransientDependency
    {
        string SayHello(string words);
    }
}