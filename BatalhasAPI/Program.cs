using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatalhasAPI
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            Carros c1 = new Carros();
            c1.Ano = 2021;
        }

        
        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class Carros
    {
        public int Ano { get; set; }
    }
}
