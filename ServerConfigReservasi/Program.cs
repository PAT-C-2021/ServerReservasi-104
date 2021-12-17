using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceReservasi;

namespace ServerConfigReservasi
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = null;
            try {
                serviceHost = new ServiceHost(typeof(Service1));
                serviceHost.Open();
                Console.WriteLine("Server is Ready !!!");
                Console.ReadLine();
                serviceHost.Close();
            }
            catch(Exception e) { 
                serviceHost = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
