﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace eCommerce
{
    public delegate void priceCutEvent(Int32 pr); 	// Define delegate
    public delegate void orderConfirmEvent(string sender, int orderId, DateTime timestamp, TimeSpan totalTime);
    //Server side class.
    class ChickenFarm
    {

        static Random rng = new Random();
        public static event priceCutEvent priceCut; // Define event
        public static event orderConfirmEvent orderConfirm;
        private static Int32 chickenPrice = 10;
        private static Int32 totalAmount = 500;
        private static int pricecutCounter = 0;
        private static Boolean flag = true;
        // Getter for chickenPrice.
        public Int32 getPrice() { return chickenPrice; }
        public static void changePrice(Int32 price)
        {
            if (price < chickenPrice && totalAmount > 0)
            { // a price cut 
                
                if (priceCut != null)   // there is at least a subscriber
                {
                    pricecutCounter++;
                    Console.WriteLine("+++++++++++++++++++++++++++++Price cut count {0}+++++++++++++++++++++++++++++", pricecutCounter);
                    priceCut(price); 	// emit event to subscribers
                }
                    
            }
            chickenPrice = price;
        }
        // Uses pricing model to determine the chicken prices generated by random number. Referred from Lecture 8 Slide. 
        public void farmerFunc()
        {
            for (Int32 i = 0; i < 50; i++)
            {
               // Console.WriteLine("***********************Farmer function {0}**********************************", i);
                Thread.Sleep(500);
                // Take the order from the queue of the orders;
                // Decide the price based on the orders
                Int32 p = rng.Next(5, 8); // Generate a random price
               // Console.WriteLine("New Price is {0}", p);
                ChickenFarm.changePrice(p);
                if (i == 50)
                {
                    flag = false;          
                }
            }
        }

        
        private int count = 0;
        // Order processing function which will be invoked by order processing thread.
        public void orderProcessing()
        {
             for(int i=0; i<80; i++)
            {
                string input = Program.mcb.getOneCell();
                Order order = Converter.Decoder(input);
                Thread calculateOrder = new Thread(() => Program.chicken.calculateOrder(order));
                calculateOrder.Name = "Order Processing Thread " + order.getOrderid().ToString();
               // Console.WriteLine("***********************Starting thread for Order processing {0}**********************************", calculateOrder.Name);
                calculateOrder.Start();
           
            }
        }

        public void calculateOrder(Order order)
        {
            if (totalAmount > 0 && order.getcardNo() >= 5000 && order.getcardNo() <= 7000)
            {
                totalAmount = totalAmount - order.getAmount();
                double total = order.getAmount() * order.price;
                double tax = (total * 8) / 100;
                double shipping = (total * 10) / 100;
                double finalamount = total + tax + shipping;
                DateTime orderTime = order.orderTime;
                DateTime timeStamp = DateTime.Now;
                TimeSpan totalTime = timeStamp.Subtract(orderTime);

                string display = "\t\t\t Order Confirmed:" +
                                    " \n 1. Order ID: " + (order.getOrderid()) +
                                    " \n 2. Sender ID:" + (order.getSenderId()) +
                                    " \n 3. Number of Chicken:" + (order.getAmount()) +
                                    "\n 4. Card Number: " + (order.getcardNo()) +
                                    "\n 5. Price per Chicken: " + (order.price) +
                                    "\n 6. Total amount paid : " + (finalamount) +
                                   /* "\n 7. Number of Chicken Left in Farm : " + (totalAmount) +*/ "\n";
                Console.WriteLine(display);
                count++;
                // Callback to orderConfirm.
                if (orderConfirm != null)
                {
                    orderConfirm(order.getSenderId(), order.getOrderid(), timeStamp, totalTime);
                }
            }
            else // Validation if Card Number is valid it is possible chicken is out of stock.
            {
                string display2 = "\n\n\n\t\t\t\t\t\t Error occured:" +
                                " \n Chicken Out of Stock" +
                                 "\n\n\n\n";
                Console.WriteLine(display2);
            }
        }

    }
}
