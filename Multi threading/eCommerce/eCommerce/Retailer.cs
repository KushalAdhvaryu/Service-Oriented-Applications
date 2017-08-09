using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace eCommerce
{
    class Retailer
    {
        private string senderId;
        private int amount;
        private int cardNo;
        public string encodedInput;
        private static int orderId = 0;

        public Retailer(int i)
        {
            senderId = "Retailer "+ (i+1).ToString();
        }

       
        public static Random random = new Random();
        public void retailerFunc(Int32 p)
        {
            //Generating random number between 5000- 7000 as Card Number.
            cardNo = random.Next(5000, 7000);

            //Generating the random quantity of chicken.
            amount = random.Next(1, 5);

            //Recording datatime to calculate difference when order is processed.
            DateTime currentTime = DateTime.Now;

            //Setting order member variables values using order constructor.
            Order order = new Order(senderId, amount, cardNo, p, currentTime, ++orderId);

            //Sending order object to Encoder to convert Object to String.
            encodedInput = Converter.Encoder(order);

            //Setting the encoded string to a cell in mutlicell buffer.
            Program.mcb.setOneCell(encodedInput);


        }


        public void chickenOnSale(Int32 p)
        {  // Event handler
            Console.WriteLine("Store{0} chickens are on sale: as low as ${1} each", Thread.CurrentThread.Name, p);
            
            Thread retailerThread = new Thread(() => this.retailerFunc(p));
            retailerThread.Name = senderId;
            retailerThread.Start();

        }

        //Order Confirm callback function when order is confirmed.
        public void orderConfirmation(string sender, int orderId, DateTime timeStamp, TimeSpan totalTime)
        {
            if (this.senderId == sender)
            {
                string temp = (Convert.ToString(totalTime)).Split(':')[2];
                string display = "Order Place By " +
                            sender + " Confirmed at " +
                            timeStamp + ".\n Time taken to process order." +
                            temp + " seconds.\n Order Id is :" +
                            orderId + "\n\n\n";
                Console.WriteLine(display);
            }
           
        }

    }
}
