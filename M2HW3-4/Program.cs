using M2HW3_4.Configs;
using Autofac;

namespace M2HW3_4
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}
