using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_server
{
    public class Server
    {
        public string Svr_name { get; set; } = string.Empty;
        public string Svr_ipaddress { get; set; } = string.Empty;
        public string Svr_type { get; set; }
        public Server(string svrname, string svripaddress, string svrtype)
        {
            Svr_name = svrname;
            Svr_ipaddress = svripaddress;
            Svr_type = svrtype;
        }
        public Server() : this("DELL", "192.168.1.1","R650") { }
        public void Myserver()
        {
            Console.WriteLine("VCBS: " + Svr_name + " - IP address :" + Svr_ipaddress + " - Type Server :" + Svr_type);
        }
    }
}
