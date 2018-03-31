using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using TicTacToe.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TicTacToe
{
    //This class mainly handles everything around the hosting enviroment 
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .UseStartup("TicTacToe")
                .PreferHostingUrls(true) //Læs op på (side 103)
                .UseUrls("http://localhost:5000") //Læs op på (side 103)
                .UseApplicationInsights() //Læs op på (side 103)
                .ConfigureLogging((hostingcontext, logging) =>
                {
                    logging.AddLoggingConfiguration(
                    hostingcontext.Configuration);
                })
                .Build();
    }
}
