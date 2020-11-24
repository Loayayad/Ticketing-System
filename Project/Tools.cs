using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Tools
    {
        //show one ticket
        public static void displayTicket(Ticket ticket)
        {
            Console.WriteLine("Ticket ID number " + ticket.TicketID);
            Console.WriteLine("Ticket recieved from " + ticket.TicketFrom);
            Console.WriteLine("Ticket Subject " + ticket.TicketSubject);
            Console.WriteLine("Ticket Staus " + ticket.TicketStatus);
            Console.WriteLine("Ticket Depatment " + ticket.DepartmentName);
            Console.WriteLine("Ticket Engineer " + ticket.EngineerName);
            Console.WriteLine("Ticket Body " + ticket.TicketBody);
            Console.WriteLine("");

        }

        //show all tickets
        public static void displayTickets(List<Ticket> tickets)
        {
            foreach (Ticket t in tickets)
            {
                Console.WriteLine("Ticket ID number " + t.TicketID);
                Console.WriteLine("Ticket recieved from " + t.TicketFrom);
                Console.WriteLine("Ticket Subject " + t.TicketSubject);
                Console.WriteLine("Ticket Staus " + t.TicketStatus);
                Console.WriteLine("Ticket Depatment " + t.DepartmentName);
                Console.WriteLine("Ticket Engineer " + t.EngineerName);
                Console.WriteLine("Ticket Body " + t.TicketBody);
                Console.WriteLine("");
            }

        }

        public static void displayTicketsID(List<Ticket> tickets)
        {
            foreach (Ticket t in tickets)
            {
                Console.WriteLine("Ticket ID number " + t.TicketID);
            }

        }

        public static void changeStatus(Ticket ticket)
        {
            Console.WriteLine("Choose the Suitable Status For this Ticket");
            int i = 0;
            foreach (TicketStatus status in Enum.GetValues(typeof(TicketStatus)))
            {
                Console.WriteLine("Enter {0} for {1}", i, status);
                i++;
            }
            byte ticketStatus = byte.Parse(Console.ReadLine());
            ticket.TicketStatus = (TicketStatus)ticketStatus;

        }

        public static void changeDepartment(Ticket ticket)
        {
            Console.WriteLine("Choose the Suitable Department For this Ticket");
            int i = 0;
            foreach (DepartmentName status in Enum.GetValues(typeof(DepartmentName)))
            {
                Console.WriteLine("Enter {0} for {1}", i, status);
                i++;
            }
            byte departmentName = byte.Parse(Console.ReadLine());
            ticket.DepartmentName = (DepartmentName)departmentName;

        }

        public static void changeEngineer(Ticket ticket)
        {
            Console.WriteLine("Choose the Suitable Engineer For this Ticket");
            int i = 0;
            foreach (EngineerName status in Enum.GetValues(typeof(EngineerName)))
            {
                Console.WriteLine("Enter {0} for {1}", i, status);
                i++;
            }
            byte engineerName = byte.Parse(Console.ReadLine());
            ticket.EngineerName = (EngineerName)engineerName;

        }

        public static void showDepartments()
        {
            int i = 0;
            foreach (DepartmentName status in Enum.GetValues(typeof(DepartmentName)))
            {
                Console.WriteLine("Enter {0} for {1}", i, status);
                i++;
            }
        }

        public static void showEngineers()
        {
            int i = 0;
            foreach (EngineerName status in Enum.GetValues(typeof(EngineerName)))
            {
                Console.WriteLine("Enter {0} for {1}", i, status);
                i++;
            }
        }




    }
}
