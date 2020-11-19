using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Password_Cracker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"                     _             ");
            Console.WriteLine(@"                    | |            ");
            Console.WriteLine(@"  ___ _ __ __ _  ___| | _____ _ __ ");
            Console.WriteLine(@" / __| '__/ _` |/ __| |/ / _ \ '__|");
            Console.WriteLine(@"| (__| | | (_| | (__|   <  __/  |   ");
            Console.WriteLine(@" \___|_|  \__,_|\___|_|\ _\___|_|   ");

            Stopwatch stopwatch = new Stopwatch();
            string Hash = "";
            Console.WriteLine("Enter your md5 Hash: ");
            Hash = Console.ReadLine().ToUpper();
            stopwatch.Start();


            string pass = "";
            int Count = 0;
            bool closeLoop = true;

            StreamReader file = new StreamReader(@"rockyou.txt");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attempting to crack hash...");

            while(closeLoop == true && (pass = file.ReadLine()) != null)
            {
                if(MD5Hash(pass) == Hash)
                {
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    string elapsedtime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(pass);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cracked Hash = " + pass + "\n\r" + MD5Hash(pass));
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("Time elapsed till hash was cracked: " + elapsedtime);

                    Console.ResetColor();
                    Console.ReadKey();
                    
                    closeLoop = false;
                    file.Close(); //Closes the file stream reader
                }
                Count++;
                Console.Title = "Current non succesful password crack count: " + Count.ToString();
                Thread.Sleep(1);
            }
            file.Close();
            Console.ReadKey();
        }
        public static string MD5Hash(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();
            byte[] bytes = MD5provider.ComputeHash(new UTF8Encoding().GetBytes(inputString));

            for(int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
