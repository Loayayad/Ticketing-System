using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Engineer
    {
        public int engineerID { get; set; }
        public EngineerName engineerName { get; set; }
        public Permission engineerPermission { get; set; }
        public List<Ticket> engineerTicketList = new List<Ticket>();
        public static List<Engineer> engineerList = new List<Engineer>();


        public Engineer(int _EngId,EngineerName _EngName)
        {
            engineerID = _EngId;
            engineerName = _EngName;
            engineerPermission = Permission.EngineerLevel1;
        }
        public Engineer(int _EngId,EngineerName _EngName, Permission _PermissionLevel)
        {
            engineerID = _EngId;
            engineerName = _EngName;
            engineerPermission = _PermissionLevel;
        }

        public static void CreateEngineers()
        {
            Engineer e1 = new Engineer(1, EngineerName.Loay);
            Engineer e2 = new Engineer(2, EngineerName.Nourhan);
            engineerList.Add(e1);
            engineerList.Add(e2);
        }


        public void AddTicketToEngineer(Ticket ticket)
        {
            engineerTicketList.Add(ticket);
        }

        public void ChangeTicketStatus()
        {
            if (this.engineerPermission == Permission.EngineerLevel2)
            {
                Console.WriteLine("Choose a ticket ID");
                int id = int.Parse(Console.ReadLine());
                Tools.changeStatus(engineerTicketList.Find(item => item.TicketID == id));
            }
            else
            {
                Console.WriteLine("You Are not Allowed to Change Ticket");
            }
        }

        public void displayTicketForEngineer()
        {
            Tools.displayTickets(this.engineerTicketList);
        }

        public string toString()
        {

            return string.Format(
                "Engineer ID {0}" +
                "Engineer Name {1}"+
                "Engineer Permission {2}",
                engineerID,engineerName,engineerPermission);
        }


    }
}
