using Security;
using System.Linq.Expressions;

namespace UX
{
    public class HomeScreen
    {
        public static void Main(string[] args)
        {
            var screen = new HomeScreen();
            Console.WriteLine("Input your system type");
            Console.WriteLine("Home");
            Console.WriteLine("Org");
            /// Console.WriteLine("1. Filesystem");
            /// Console.WriteLine("2. Account");
            /// Console.WriteLine("3. Firewall");
            /// Console.WriteLine("4. App & Browser");
            /// Console.WriteLine("5. Device");

            String c = Console.ReadLine().ToLower();
            list<ISecurityProvider> provider = ProviderFactory(c);
            provider.scan();
        }

        List<IServiceProvider> ProviderFactory(string c)
        {
            List<IServiceProvider> serviceProviders = new List<IServiceProvider>();

            if (c == "home")
            {
                serviceProviders.Add(new AntiVirusServiceProvider());
                serviceProviders.Add(new AccountServiceProvider());
                serviceProviders.Add(new AppBrowserServiceProvider());
                serviceProviders.Add(new DeviceServiceProvider());
            }
            else if (c == "org")
            {
                serviceProviders.Add(new AntiVirusServiceProvider());
                serviceProviders.Add(new AccountServiceProvider());
                serviceProviders.Add(new FirewallServiceProvider());
                serviceProviders.Add(new AppBrowserServiceProvider());
                serviceProviders.Add(new DeviceServiceProvider());
            }
            else
            {
                throw new InvalidOperationException("Invalid input");
            }
            return serviceProviders;
        }
    }
}
