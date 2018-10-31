using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int inPut;

            inPut = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Ryan\\source\\repos\\inAndOut\\inAndOut\\log\\text.txt", true))
            {
                sw.WriteLine(inPut);
                
            }

            string outPut = File.ReadAllText("C:\\Users\\Ryan\\source\\repos\\inAndOut\\inAndOut\\log\\text.txt");
            Console.WriteLine(outPut);


            Console.ReadLine();
        }
    }
}
