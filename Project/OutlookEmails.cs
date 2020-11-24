using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;

namespace Project
{
    class OutlookEmails
    {
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }

        public static List<OutlookEmails> ReadMailItems()
        {
            Application outlookApplication = null;
            NameSpace outlookNamespace = null;
            MAPIFolder inboxFolder = null;

            Items mailItems = null;
            List<OutlookEmails> listEmailDetails = new List<OutlookEmails>();
            OutlookEmails emailDetails;


            try
            {
                outlookApplication = new Application();
                outlookNamespace = outlookApplication.GetNamespace("MAPI");
                outlookNamespace.Logon("iti.front@outlook.com", System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                inboxFolder = outlookNamespace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
                mailItems = inboxFolder.Items;
                //Console.WriteLine("mails itmes {0}", mailItems.Count);

                foreach (MailItem item in mailItems)
                {
                    emailDetails = new OutlookEmails();
                    emailDetails.EmailFrom = item.SenderEmailAddress;
                    emailDetails.EmailSubject = item.Subject;
                    emailDetails.EmailBody = item.Body;

                    listEmailDetails.Add(emailDetails);
                    RelaseComObject(item);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                RelaseComObject(mailItems);
                RelaseComObject(inboxFolder);
                RelaseComObject(outlookNamespace);
                RelaseComObject(outlookApplication);
            }

            return listEmailDetails;

        }
        public static void RelaseComObject(object obj)
        {
            if (obj != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
        }
    }
}
