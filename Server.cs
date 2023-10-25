using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_server
{
    public class Server
    {
        public string svr_name { get; set; }
        public string svr_ipaddress { get; set; }
        public string svr_type { get; set; }
        //public Server(string svr_name, string svr_ipaddress, string svr_type)
        //{
        //    this.svr_name = svr_name;
        //    this.svr_ipaddress = svr_ipaddress;
        //    this.svr_type = svr_type;
        //}
        public void myserver()
        {
            Console.WriteLine("VCBS: " + svr_name + " - IP address :" + svr_ipaddress + " - Type Server :" + svr_type);
        }
    }
}
