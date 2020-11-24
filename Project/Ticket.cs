using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Ticket
    {
        public int TicketID { get; set; }
        public string TicketFrom { get; set; }
        public string TicketSubject { get; set; }
        public string TicketBody { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public DepartmentName DepartmentName { get; set; }
        public EngineerName EngineerName { get; set; }

        private static List<Ticket> listTicketsDetails = new List<Ticket>();

        public static void recieveEmails()
        {
            List<OutlookEmails> mails = OutlookEmails.ReadMailItems();

            //Console.WriteLine("mails number {0}", mails.Count);
            int i = 1;

            Ticket ticketDetails;

            foreach (var mail in mails)
            {
                //Console.WriteLine("Mails No " + i);
                //Console.WriteLine("Mail recieved from " + mail.EmailFrom);
                //Console.WriteLine("Mail Subject " + mail.EmailSubject);
                //Console.WriteLine("Mail Body " + mail.EmailBody);

                ticketDetails = new Ticket();
                ticketDetails.TicketID = GetRandomTicketNumber();
                ticketDetails.TicketFrom = mail.EmailFrom;
                ticketDetails.TicketSubject = mail.EmailSubject;
                ticketDetails.TicketBody = mail.EmailBody;
                ticketDetails.TicketStatus = TicketStatus.TicketRecieved;
                ticketDetails.DepartmentName = DepartmentName.None;
                ticketDetails.EngineerName = EngineerName.None;

                listTicketsDetails.Add(ticketDetails);

               Console.WriteLine("");

                i = i + 1;
            }

        }

        public static List<Ticket> getTickets()
        {
            recieveEmails();
            return listTicketsDetails;
        }

        private static int GetRandomTicketNumber()
        {
            Random rand = new Random();
            int result = 100 * rand.Next(10, 100);
            
            var x = listTicketsDetails.Find(item => item.TicketID == result);


            if (x is null)
            {
                return result;
            }

            return GetRandomTicketNumber();
        }

    }
}
