using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfMangler
{
    class Program
    {

        static void Main(string[] args)
        {
            string str_filepath = "C:\\Temp\\test.ini";
            string str_currentline = "";
            int i = 0;
            //Console.WriteLine(str_filepath);
            
            string[] lines = System.IO.File.ReadAllLines(str_filepath);

            //lines[17] = "OpenSource=false";

            foreach (string line in lines)
            {
                str_currentline = line;
                if (line == "OpenSource=true")
                {
                    lines[i] = "OpenSource=false";
                    Console.WriteLine("Success!");
                }

                i++;
            }

            System.IO.File.WriteAllLines(str_filepath, lines);

            Console.ReadLine();
        }
    }
}
