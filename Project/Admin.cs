using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Admin
    {
        // Singeleton Pattern
        private static Admin admin;

        // List of Tickets that Admin Recieved

        public List<Ticket> adminTicketList;
        private Admin()
        {
            adminTicketList = new List<Ticket>();
            adminTicketList = Ticket.getTickets();
        }

        // get Admin instance
        public static Admin getAdminInstance()
        {
            if (admin != null) return admin;
            else
            {
                admin = new Admin();
                return admin;
            }
        }

        public void showTickets()
        {
            Tools.displayTickets(adminTicketList);

        }

        public Ticket showATicket(int id)
        {
            Ticket choosenTicket = adminTicketList.Find(ticket => ticket.TicketID == id);
            Tools.displayTicket(choosenTicket);
            return choosenTicket;
        }

        //function to chnage ticket status 
        public void ChangeTicketStatus()
        {
            Console.WriteLine("Choose a ticket ID");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = adminTicketList.Find(item => item.TicketID == id);
            Tools.changeStatus(ticket);
            Tools.displayTicket(ticket);
        }

        public void ChangeTicketStatus(Ticket ticket)
        {
            Tools.changeStatus(ticket);
            Tools.displayTicket(ticket);
        }

        //function to chnage ticket depratment
        public void ChangeTicketDepartment()
        {
            Console.WriteLine("Choose a ticket ID");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = adminTicketList.Find(item => item.TicketID == id);
            Tools.changeDepartment(ticket);
            Tools.displayTicket(ticket);
        }

        public void ChangeTicketEngineer()
        {
            Console.WriteLine("Choose a ticket ID");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = adminTicketList.Find(item => item.TicketID == id);
            Tools.changeEngineer(ticket);
            Tools.displayTicket(ticket);
        }

        public void ShowAndChooseDepartments(Ticket ticket)
        {
            Department.CreateDepartment();
            Tools.changeDepartment(ticket);

            Department choosenDepartment = Department.departmentList.Find(item=>item.departmentName == ticket.DepartmentName);
            choosenDepartment.AddTicketToDepartment(ticket);
            choosenDepartment.DisplayTicketsInDepartment();
        }

        public void ShowAndChooseEngineer(Ticket ticket)
        {
            Engineer.CreateEngineers();
            //hna
            Tools.changeEngineer(ticket);
            Engineer choosenEngineer = Engineer.engineerList.Find(item => item.engineerName == ticket.EngineerName);
            choosenEngineer.AddTicketToEngineer(ticket);
            choosenEngineer.displayTicketForEngineer();
            
        }

    }
}
