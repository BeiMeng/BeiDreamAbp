using System.Collections.Generic;
using Abp.WebApi.Controllers;
using BeiDream.Application.Test;

namespace BeiDream.WebApi
{
    /// <summary>
    /// 测试WebApi
    /// </summary>
    public class TestApiController : AbpApiController
    {
        private readonly ITest _test;
        /// <summary>
        /// 测试WebApi构造函数
        /// </summary>
        /// <param name="test"></param>
        public TestApiController(ITest test)
        {
            _test = test;
        }

        // GET api/TestApi
        /// <summary>
        /// 测试获取所有数据
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return _test.SayHello("Api 啊 哈哈哈！");
        }
    }
}