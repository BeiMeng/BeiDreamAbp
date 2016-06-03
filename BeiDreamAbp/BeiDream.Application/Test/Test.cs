namespace BeiDream.Application.Test
{
    public class Test:ITest
    {
        public string SayHello(string words)
        {
            return "BeiDream创建的:" + words;
        }
    }
}