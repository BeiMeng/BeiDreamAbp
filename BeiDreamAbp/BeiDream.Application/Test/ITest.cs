using Abp.Dependency;

namespace BeiDream.Application.Test
{
    public interface ITest:ITransientDependency
    {
        string SayHello(string words);
    }
}