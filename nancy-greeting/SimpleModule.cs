using Nancy;

namespace nancy_greeting
{
    public class SimpleModule : NancyModule
    {
        public SimpleModule()
        {
            Get("/", parameters => "Hello World!");
        }
    }
}