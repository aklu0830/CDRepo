using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace webapp
{
    public class Program {
        public static void Main(string[] args) {
            string passcode = "";
            Random r = new Random();
            string[] possibleNums = new string[] {
                "1","2","3","4","5","6","7","8","9","0",
                "A","B","C","D","E","F","G","H","I","J","K","L",
                "M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
            };
            for (int i = 0; i < 14; i++) {
                int index = r.Next(0,possibleNums.Length);
                passcode += possibleNums[index];
            }
            Console.WriteLine("PASSCODE IS: " + passcode);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
