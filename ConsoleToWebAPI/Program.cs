using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    class Program
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Hello world");
            }

            public static IHostBuilder CreateHostBuilder()
            {
            Host.CreateDefaultBuilder();
            }
       

        }
    }

