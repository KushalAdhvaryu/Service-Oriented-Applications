using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Order
    {
        private string senderId;
        private int cardNo;
        private int amount;
        public DateTime orderTime;
        public int price;
        private int orderId;

        //Constructor to set member variables of order.
        public Order(string sender, int amt, int card, int cost, DateTime timer, int id)
        {
            senderId = sender;
            amount = amt;
            cardNo = card;
            price = cost;
            orderTime = timer;
            orderId = id;

        }

        //Getter to read CardNo value.
        public int getcardNo()
        {
            return cardNo;
        }

        //Getter to read Amount value.
        public int getAmount()
        {
            return amount;
        }

        //Getter to read Sender value.
        public string getSenderId()
        {
            return senderId;
        }

        //Getter to read orderId.
        public int getOrderid()
        {
            return orderId;
        }


        //Getter to recieve order as string.
        public string getOrder()
        {
            return senderId + "," + amount + "," + cardNo + "," + price + "," + orderTime + "," + orderId;
        }
    }
}
