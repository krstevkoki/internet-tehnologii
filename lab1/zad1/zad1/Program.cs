using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        private static void Run()
        {
            Agency agency = new Agency("FINKI-IT");
            while (true)
            {
                Console.WriteLine("******* " + agency.Name + " *******");
                Console.WriteLine("Избери броj: ");
                Console.WriteLine("1. Услужи го клиентот\n" +
                                  "2. Продадени карти на шалтерот\n" +
                                  "3. Вкупен промет на шалтерот\n" +
                                  "4. Сите продадени карти на агенциjата, организирани по шалтер\n" +
                                  "5. Вкупен промет на агенциjата\n" +
                                  "6. Успешност на агенциjата\n" +
                                  "7. Излез\n");

                var choice = Convert.ToInt32(Console.ReadLine());
                int cashierNumber;
                switch (choice)
                {
                    case 1:
                        ++agency.NumberOfVisitors;
                        Console.WriteLine("Vnesete go vaseto ime, prezime, godini, destinacijata i shalterot");
                        string[] lineParts = Console.ReadLine().Split(" ".ToCharArray());

                        if (lineParts.Length == 5)
                        {
                            string firstName = lineParts[0];
                            string lastName = lineParts[1];
                            int age = Convert.ToInt32(lineParts[2]);
                            string destination = lineParts[3];
                            cashierNumber = Convert.ToInt32(lineParts[4]);

                            if (!agency.IsValidCashierNumber(cashierNumber))
                            {
                                Console.WriteLine("\n*** Nevaliden broj na shalter ***\n");
                                break;
                            }

                            Destination d;
                            if ((d = Agency.GetDestination(destination)) == null)
                            {
                                Console.WriteLine("\n*** Karti za baranata destinacija ne se prodavaat ***\n");
                                break;
                            }

                            agency.Cashiers[cashierNumber]
                                .AddTicket(
                                    new Ticket(firstName, lastName, age, d)
                                );
                            ++agency.NumberOfServedClients;

                            Console.WriteLine("\n<<< Uspesno rezerviranje >>>\n");
                        }
                        else
                            Console.WriteLine("\n<<< NEUSPESNA REZERVACIJA >>>\n");

                        break;

                    case 2:
                        Console.WriteLine("Vnesete broj na shalter");

                        cashierNumber = Convert.ToInt32(Console.ReadLine());
                        if (!agency.IsValidCashierNumber(cashierNumber))
                        {
                            Console.WriteLine("\n*** Nevaliden broj na shalter ***\n");
                            break;
                        }

                        Console.WriteLine("\n{0}\n",
                            agency.Cashiers[cashierNumber]
                                .TotalSoldTicketsInTimeSpan(
                                    DateTime.Now.AddHours(-2),
                                    DateTime.Now.AddHours(2))
                        );
                        break;

                    case 3:
                        Console.WriteLine("Vnesete broj na shalter");

                        cashierNumber = Convert.ToInt32(Console.ReadLine());
                        if (!agency.IsValidCashierNumber(cashierNumber))
                        {
                            Console.WriteLine("\n*** Nevaliden broj na shalter ***\n");
                            break;
                        }

                        Console.WriteLine("\n{0}den.\n",
                            agency.Cashiers[cashierNumber]
                                .TotalProfitFromTicketsInTimeSpan(
                                    DateTime.Now.AddHours(-2),
                                    DateTime.Now.AddHours(2)
                                ));
                        break;

                    case 4:
                        Console.WriteLine("\n{0}\n",
                            agency
                                .NumberOfTicketsSoldByCashiers(
                                    DateTime.Now.AddHours(-2),
                                    DateTime.Now.AddHours(2)
                                ));
                        break;

                    case 5:
                        Console.WriteLine("\n{0}den.\n", agency.TotalProfit());
                        break;

                    case 6:
                        try
                        {
                            Console.WriteLine("\n{0:0.00}%\n", agency.AgencySuccess() * 100);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("\nNo visitors in the agency, 0.00%\n");
                        }

                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("\n*** NEVALIDEN VLEZ ***\n");
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            Run();
        }
    }

    class Destination
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        private static readonly int MultiplicationFactor = 2000;

        public Destination(string name)
        {
            this.Name = name;
            this.Price = ComputePrice(this.Name);
        }

        private static int ComputePrice(string name)
        {
            return name.Length * MultiplicationFactor;
        }
    }

    class Ticket
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public Destination Destination { get; private set; }
        public int TicketPrice { get; private set; }
        public DateTime TimeOfSale { get; private set; }

        public Ticket(string firstName, string lastName, int age, Destination destination)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Destination = destination;
            TimeOfSale = DateTime.Now;
            TicketPrice = destination.Price;
        }
    }

    class Cashier
    {
        public int CashierNumber { get; private set; }
        public List<Ticket> Tickets { get; private set; }

        public Cashier(int cashierNumber)
        {
            CashierNumber = cashierNumber;
            Tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket t)
        {
            Tickets.Add(t);
        }

        public int TotalSoldTickets()
        {
            return Tickets.Count;
        }

        public int TotalSoldTicketsInTimeSpan(DateTime start, DateTime end)
        {
            int counter = 0;
            Tickets.ForEach(ticket =>
            {
                if (ticket.TimeOfSale >= start && ticket.TimeOfSale <= end)
                    ++counter;
            });
            return counter;
        }

        public int TotalProfitFromAllTickets()
        {
            int profit = 0;
            Tickets.ForEach(ticket => profit += ticket.TicketPrice);
            return profit;
        }

        public int TotalProfitFromTicketsInTimeSpan(DateTime start, DateTime end)
        {
            int profit = 0;
            Tickets.ForEach(ticket =>
            {
                if (ticket.TimeOfSale >= start && ticket.TimeOfSale <= end)
                    profit += ticket.TicketPrice;
            });
            return profit;
        }
    }

    class Agency
    {
        public string Name { get; private set; }
        public List<Cashier> Cashiers { get; private set; }
        public int NumberOfVisitors { get; set; }
        public int NumberOfServedClients { get; set; }

        private static Destination[] AvailableDestinations = new Destination[]
        {
            new Destination("Rim"),
            new Destination("London"),
            new Destination("Tokio"),
            new Destination("Sofija"),
            new Destination("Istanbul"),
            new Destination("Toronto"),
            new Destination("Majami"),
            new Destination("Zagreb"),
            new Destination("Belgrad"),
            new Destination("Moskva")
        };

        public Agency(string name)
        {
            Name = name;
            NumberOfServedClients = 0;
            NumberOfVisitors = 0;
            Cashiers = new List<Cashier>();
            for (int i = 0; i < 5; ++i)
                Cashiers.Add(new Cashier(i));
        }

        public decimal AgencySuccess()
        {
            if (NumberOfVisitors == 0)
                throw new DivideByZeroException("Number of visitors is zero");
            return NumberOfServedClients / (decimal) NumberOfVisitors;
        }

        public int TotalProfit()
        {
            int profit = 0;
            Cashiers.ForEach(cashier => profit += cashier.TotalProfitFromAllTickets());
            return profit;
        }

        public string NumberOfTicketsSoldByCashiers(DateTime start, DateTime end)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var cashier in Cashiers)
                sb.Append("Cashier " + cashier.CashierNumber + ": " + cashier.TotalSoldTickets() + "\n");
            return sb.ToString();
        }

        public static Destination GetDestination(string destination)
        {
            foreach (var dest in AvailableDestinations)
                if (dest.Name.ToLower() == destination.ToLower())
                    return dest;
            return null;
        }
        
        public bool IsValidCashierNumber(int number)
        {
            return number >= 0 && number < Cashiers.Count;
        }
    }
}