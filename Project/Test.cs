using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Test
    {
        public static void Run()
        {
            Console.WriteLine("<----- Welocme to Ticketing system ----->\n");
            //Console.WriteLine("To make this program work chnage the outlook email in the outlookemail class");

            Admin admin = Admin.getAdminInstance();

            Console.WriteLine("Shown below are the available tickets \n");
            admin.showTickets();

            Console.WriteLine("Choose a ticket id to initialize and assign it's status,department and engineer");

            //Case One take a ticket and change it's assign it ti department and engineer
            //Console.WriteLine("Choose A Ticket To work on it");
            Ticket choosenTicket = admin.showATicket(int.Parse(Console.ReadLine()));

            Console.WriteLine("Now we will show Status to choose from for the ticket");
            admin.ChangeTicketStatus(choosenTicket);

            Console.WriteLine("Now we will show Departments to choose from for the ticket");
            admin.ShowAndChooseDepartments(choosenTicket);

            Console.WriteLine("Now we will show Engineers from the departmentt to choose from for the ticket");
            admin.ShowAndChooseEngineer(choosenTicket);

            while (true)
            {
                Console.WriteLine("Do you want to do something else " +
                    "enter 1 to choose , 0 to terminate ");

                int input1 = int.Parse(Console.ReadLine());

                if (input1 != 1)
                {
                    return;
                }
                Console.WriteLine("if you want to change a status press 1 \n" +
                    "if you want to change a department of a ticket press 2 \n" +
                    "if you want to change engineer of a ticket press 3");

                int input2 = int.Parse(Console.ReadLine());

                switch (input2)
                {
                    case 1:
                        admin.showTickets();

                        Console.WriteLine("Change the status of a ticket");
                        admin.ChangeTicketStatus();
                        break;
                    case 2:
                        admin.showTickets();

                        Console.WriteLine("Change the Department of a ticket");
                        admin.ChangeTicketDepartment();
                        break;
                    case 3:
                        admin.showTickets();

                        Console.WriteLine("Change the Department of a ticket");
                        admin.ChangeTicketEngineer();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
