using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace eCommerce
{
    class Program
    {
        //Creating instance of Multicell buffer accessible over all classes to set and get buffer cell value.
        public static MultiCellBuffer mcb = new MultiCellBuffer();
        public static ChickenFarm chicken = new ChickenFarm();
        static void Main(string[] args)
        {
            //Creating instance of ChickenFarm and invoking farmerFunc as start of farmer thread.
            
            Thread farmer = new Thread(new ThreadStart(chicken.farmerFunc));
            farmer.Start();         // Start one farmer thread

            Retailer[] chickenstore = new Retailer[5];
   
            for(int i=0;i<5; i++)
            {
                chickenstore[i] = new Retailer(i);
                ChickenFarm.priceCut += new priceCutEvent(chickenstore[i].chickenOnSale);
            }
            //Price cut event calling the event handlers in the Retailer if there is a price cut.
            Thread orderProcessing = new Thread(new ThreadStart(chicken.orderProcessing));
            orderProcessing.Start();
            
            
          /*  Thread[] retailers = new Thread[5];
            for (int i = 0; i < 5; i++)
            {   // Start N retailer threads
                retailers[i] = new Thread(new ThreadStart(chickenstore.retailerFunc));
                retailers[i].Name = (i + 1).ToString();
                retailers[i].Start();
            }*/

            //Subscribe the function orderConfirmation of Retialer class for orderConfirmEvent.
            for (int i = 0; i < 5; i++)
            {
                ChickenFarm.orderConfirm += new orderConfirmEvent(chickenstore[i].orderConfirmation);
            }
            
            //Wait for all threads to finish before completing program.
            farmer.Join();
          orderProcessing.Join();
            
            
            Console.WriteLine("Press Any Key to Exit.");
            Console.ReadKey();
        }   
    }
}
