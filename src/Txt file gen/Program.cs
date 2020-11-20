// Generates a text file in the C: directory

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
            try 
            {
                TextWriter tw = new StreamWriter("C:/YourNameHere.txt", true);
                tw.WriteLine("YourTextHere");
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
