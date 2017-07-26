﻿using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Fiver.Security.AuthServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Auth Server (IdentityServer4)";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5000")
                .Build();

            host.Run();
        }
    }
}