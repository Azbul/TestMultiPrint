using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Printing;
using System.Drawing.Printing; 

namespace TestMultiPrint
{
    class PrinterTest
    {
        public void PrNames()
        {
            PrintQueueCollection myPrintQueues = new PrintQueueCollection();
            PrintQueue pq = LocalPrintServer.GetDefaultPrintQueue();
            Console.WriteLine(pq.Name);
           /* foreach(PrintQueue pq in myPrintQueues)
            {
                Console.WriteLine(pq.Name);
            }
            */
            Console.WriteLine("This is PSetting function");

            foreach (string str in PrinterSettings.InstalledPrinters)
            {
                Console.WriteLine(str);
            }
        }
    }
}
