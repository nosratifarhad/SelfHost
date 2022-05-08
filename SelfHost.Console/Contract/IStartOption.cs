using Owin;

namespace SelfHost.Console.Contract
{
    public interface IStartOption
    {
        void Configuration(IAppBuilder app);
    }
}
