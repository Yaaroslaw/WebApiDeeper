﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;


namespace WebAPISelfHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8999");
            var server = new HttpSelfHostServer(config);
            config.Routes.MapHttpRoute("default", "api/{controller}/{id}", new { id = System.Web.Http.RouteParameter.Optional });
            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Server is up and runnig...");
            Console.ReadLine();
        }
    }
}
