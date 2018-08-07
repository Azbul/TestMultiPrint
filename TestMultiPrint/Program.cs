using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMultiPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PrinterTest pt = new PrinterTest();
            pt.PrNames();
            Console.ReadKey();*/

            try

            {
                RawPrinterHelper.SendFileToPrinter(@"C:\Users\Adam\Documents\toDo.pdf");
                Console.ReadKey();
            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }
        }
    }
}
