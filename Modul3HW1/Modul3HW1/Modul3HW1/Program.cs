using Microsoft.Extensions.DependencyInjection;

namespace Modul3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
