using clases08._9;

namespace clases08._9
{
    abstract class Ticket
    {
        public string Destination { get; set; }
        public string PlaceOfDeparture { get; set; }

        public Ticket(string placeOfDeparture, string destination)
        {
            PlaceOfDeparture = placeOfDeparture;
            Destination = destination;
        }
        public abstract decimal GetPrice();
    }
}

    class BusTicket : Ticket {

        public int Distance { get; set; }

        public BusTicket(string placeOfDeparture, string destination, int distance)
           : base(placeOfDeparture, destination)
        {
            Distance = distance;
        }

        public override decimal GetPrice() {
            return Distance * 0.5m;
        }
    }
    class TrainTicket : Ticket {
        public int Distance { get; set; }
        public bool IsFirstClass { get; set; }

        public TrainTicket(string placeOfDeparture, string destination, int distance, bool isFirstClass)
            : base(placeOfDeparture, destination)
        {
            Distance = distance;
            IsFirstClass = isFirstClass;
        }

        public override decimal GetPrice()
        {
            return Distance * (IsFirstClass ? 2.0m : 1.0m);
        }
    }
    class FlightTicket : Ticket {
     public int BasePrice { get; set; }
        public bool IsInternational { get; set; }

        public FlightTicket(string placeOfDeparture, string destination, int basePrice, bool isInternational)
          : base(placeOfDeparture, destination)
        {
            BasePrice = basePrice;
            IsInternational = isInternational;
        }
        public override decimal GetPrice()
        {
            return BasePrice * (IsInternational ? 1.5m : 1.0m);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Ticket[] ticket = new Ticket[]
        {
                new BusTicket("Київ", "Львів", 540),
                new TrainTicket("Київ", "Одеса", 480, true),
                new FlightTicket("Київ", "Лондон", 300, true)
        };
        foreach(Ticket t in ticket) {
            Console.WriteLine($"Від {t.PlaceOfDeparture} до {t.Destination}: Ціна = {t.GetPrice()} UAH");
        }
    }
}
