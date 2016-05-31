namespace BeiDream.Application.Test
{
    public class Test:ITest
    {
        public string SayHello(string words)
        {
            return "this is My:" + words;
        }
    }
}