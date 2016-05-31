using System.Collections.Generic;
using Abp.WebApi.Controllers;
using BeiDream.Application.Test;

namespace BeiDream.WebApi
{
    public class TestApiController : AbpApiController
    {
        private readonly ITest _test;
        public TestApiController(ITest test)
        {
            _test = test;
        }

        // GET api/TestApi
        public string Get()
        {
            return _test.SayHello("Api 啊 哈哈哈！");
        }
    }
}