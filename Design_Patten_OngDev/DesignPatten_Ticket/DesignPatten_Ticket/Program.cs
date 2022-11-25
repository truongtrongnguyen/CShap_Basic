using System;
using Ticket_StrategyDesignPatten.Base;

namespace DesignPatten_Ticket
{
    internal class Program
    {
        // Strategy DesignPatten là định nghĩa những thuật toán có liên quan với nhau
        // Truy cập Diagram: https://app.diagrams.net/#G1l6gynijtEvJ2D0qoyv6DmOZLrlwKabGN

        static void Main(string[] args)
        {
            Console.WriteLine("Start getting Ticket");
            var random = new Random();
            for(int i=1;i<=5;i++)
            {

                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(50d * i);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

            }
            Console.ReadKey();
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine(
                "Promote price of " +
                ticket.GetName() +
                " is " +
                ticket.GetPromotedPrice() +
                " " +
                ticket.GetPromoteStrategy().GetType().Name);
            Console.WriteLine();
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 4);
            switch (strategyIndex)
            {
                case 0:
                    ticket.SetPromoteStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                    break;
                case 2:
                    ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                    break;
                default:
                    ticket.SetPromoteStrategy(new EightyDiscountStrategy());
                    break;
            }
            Console.WriteLine(strategyIndex);
        }
    }
}
