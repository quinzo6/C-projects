using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_File_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                TextWriter tw = new StreamWriter("C:/FuckMyAsshole.txt", true);
                tw.WriteLine("Fuck Me In The Asshole");
                tw.Close();
                Console.WriteLine("File Made!");
            }catch(Exception e)
            {
                Console.Write(e);
            }
            Console.Read();
        }
    }
}
