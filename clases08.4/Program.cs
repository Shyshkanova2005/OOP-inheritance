using System;

namespace clases08._4
{
    class Order
    {
        public double total;

        public Order(double total)
        {
            this.total = total;
        }
        public virtual double CalculateTotal()
        {
            return total;
        }
    }
    class OnlineOrder : Order
    {
        public double Discount { get; set; }
        public OnlineOrder(double total, double discount)
           : base(total)
        {
            Discount = discount;
        }

        public override double CalculateTotal()
        {
            double discountamount = total * (Discount / 100);
            return total - discountamount;
        }
    }

    class InStoreOrder : Order
    {
        public double Nalog { get; set; }

        public InStoreOrder (double total, double nalog)
            :base(total)
        {
            Nalog = nalog;
        }
        public override double CalculateTotal()
        {
            double discountamount = total * (Nalog / 100);
            return total + Nalog;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OnlineOrder onlineorder = new OnlineOrder(100, 10);
            Console.WriteLine($"Online order {onlineorder.CalculateTotal()}");

            InStoreOrder instoreorder = new InStoreOrder(100, 3);
            Console.WriteLine($"In Store Order {instoreorder.CalculateTotal()}");
    }
    }
}
