using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum TicketStatus
    {
        None,TicketRecieved,TicketOnHold,TicketInProcess,TicketFinished
    }

    public enum DepartmentName
    {
        None,Computer,Communication
    }

    public enum EngineerName
    {
        None,Nourhan,Loay
    }

    public enum Permission
    {
        None,Admin,EngineerLevel1,EngineerLevel2
    }
}
