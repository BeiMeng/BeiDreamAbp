using Abp.Application.Services;
using Abp.Dependency;

namespace BeiDream.Application.Test
{
    /// <summary>
    /// 测试类
    /// </summary>
    public interface ITest: IApplicationService
    {
        /// <summary>
        /// 测试的应用服务层SayHello方法
        /// </summary>
        /// <param name="words">关键字</param>
        /// <returns></returns>
        string SayHello(string words);
    }
}