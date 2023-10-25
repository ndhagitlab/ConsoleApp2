using System;
using Proc_server;

namespace program_vcbs
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string username = "admin";
            string password = "password";
            Console.Write("Enter user name : ");
            string inputUsername = Console.ReadLine();
            Console.Write("Enter password :");
            string inputPasword = Console.ReadLine();

            //khai bao bien trang thai dung Class
            StatusAccessServer Access_server = new StatusAccessServer();

            if (inputUsername == username && inputPasword == password)
            {
                //Console.WriteLine("Login successful!");
                Access_server.server_Ok();
            }
            else
            {
                //Console.WriteLine("Invalid User name or Password!");
                Access_server.server_Fail();
            }

            Server VCBS_server = new Proc_server.Server();
            Console.WriteLine("Use class VCBS_Server to print list of Server");
            VCBS_server.svr_name = "Trading Core - 01";
            VCBS_server.svr_ipaddress = "192.168.1.101";
            VCBS_server.svr_type = "DELL EMC R650";
            VCBS_server.myserver();

            Thread.Sleep(5000);

        }
    }
    class StatusAccessServer
    {
        public void server_Ok()
        {
            Console.WriteLine("Login server successful!");
        }
        public void server_Fail()
        {
            Console.WriteLine("Login server Fail!");
        }
    }
}