
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WizardSpellsAPI.Models;
using WizardSpellsAPI.Utils;



namespace WizardSpellsAPI
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Utilities.CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
                var canContinue = await Utilities.WaitForMigrations(host, context);

                if (!canContinue)
                {
                    return;
                }
            }

            var task = host.RunAsync();

            Utilities.Notify("WizardSpellAPI Running!");

            WebHostExtensions.WaitForShutdown(host);
        }
    }
}


