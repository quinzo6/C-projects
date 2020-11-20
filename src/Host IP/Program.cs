// Gets IP of host provider
// Kinda works but not reall, will improve in future

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ipGoBrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Google IP:" + GetIPAddress("google.com"));
            Console.ReadLine();
        }

            // static IEnumerable<string> GetAddresses()
            // {
            //     var host = Dns.GetHostEntry(Dns.GetHostName());
            //     return (from ip in host.AddressList where ip.AddressFamily == AddressFamily.InterNetwork select ip.ToString()).ToList();
            // }

            // Gets IP of the hostname
            static IPAddress GetIPAddress(string hostName)
            {
                Ping ping = new Ping();
                var replay = ping.Send(hostName);

                if (replay.Status == IPStatus.Success)
                {
                    return replay.Address;
                }
                return null;
            }
        }
        
    }
