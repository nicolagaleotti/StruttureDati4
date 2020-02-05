using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dati_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "test.txt";
            Console.WriteLine("Inserisci il valore da cercare: ");
            string v = Console.ReadLine();
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader r = new StreamReader(file))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            if (line.Contains(v))
                            {
                                Console.WriteLine($"Il file contiene il valore {v}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
