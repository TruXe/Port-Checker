using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Port_Checker
{
    internal class Program
    {
        public static string IP;
        public static string PORT;
        static void Main(string[] args)
        {
            string IP;
            string PORT;
            

            Console.WriteLine("IP: ");
            IP = Console.ReadLine();
            Console.WriteLine("PORT: ");
            PORT = Console.ReadLine();

            Console.WriteLine("Press any key to check if port is open.");

            WebClient wb = new WebClient();


            string res = wb.DownloadString("http://{YOUR:IP:ADRESS/DOMAIN.COM}/port.php?ip=" + IP +"&port=" + PORT);

            Console.WriteLine("\n\n" + res);

            Console.ReadKey();

            return;

        }
    }
}
