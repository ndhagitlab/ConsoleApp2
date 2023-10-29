using System;
using Proc_server;

namespace program_vcbs
{
    class Program
    {
        static void Main(string[] agrs)
        {
            if (agrs is null)
            {
                throw new ArgumentNullException(nameof(agrs));
            }

            string username = "admin";
            string password = "password";
            Console.Write("Enter user name : ");
            string ? inputUsername = Console.ReadLine();

            Console.Write("Enter password :");
            string ? inputPasword = Console.ReadLine();

            //khai bao bien trang thai dung Class

            if (inputUsername == username && inputPasword == password)
            {
                //Console.WriteLine("Login successful!");
                StatusAccessServer.Server_Ok();
            }
            else
            {
                StatusAccessServer.Server_Fail();
            }

            Server VCBS_server = new();

            Console.WriteLine("Use class VCBS_Server to print list of Server");
            VCBS_server.Svr_name = "Trading Core - 01";
            VCBS_server.Svr_ipaddress = "192.168.1.101";
            VCBS_server.Svr_type = "DELL EMC R650";
            VCBS_server.Myserver();

            Thread.Sleep(5000);

        }
    }
    class StatusAccessServer
    {
        public static void Server_Ok()
        {
            Console.WriteLine("Login server successful!");
        }
        public static void Server_Fail()
        {
            Console.WriteLine("Login server Fail!");
        }
    }
}