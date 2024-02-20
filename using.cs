using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    internal class Program
    {
        
        
         public static void Main(string[] args)
         {
            string s;
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea uno");
                w.WriteLine("Linea dos");
            }
            using (TextReader r = File.OpenText("log.txt"))
            {
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}