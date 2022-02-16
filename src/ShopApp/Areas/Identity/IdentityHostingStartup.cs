using Microsoft.AspNetCore.Hosting;
using ShopApp.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]
namespace ShopApp.Areas.Identity
{
    using Microsoft.AspNetCore.Hosting;

    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}