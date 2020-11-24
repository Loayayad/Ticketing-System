using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Department
    {
        public DepartmentName departmentName { get; set; } 
        public List<Ticket> departmentTicketList;
        public static List<Department> departmentList;
        public List<Engineer> departmentEngineerList;

        public Department(DepartmentName _depPerm)
        {
            departmentName = _depPerm;
            departmentList = new List<Department>();
            departmentTicketList = new List<Ticket>();
            departmentEngineerList = new List<Engineer>();
        }



        public static void CreateDepartment()
        {
            Department d1 = new Department(DepartmentName.Communication);
            Department d2 = new Department(DepartmentName.Computer);
            departmentList.Add(d1);
            departmentList.Add(d2);
        }

        public void AddTicketToDepartment(Ticket ticket)
        {
            this.departmentTicketList.Add(ticket);
        }

        public void DisplayTicketsInDepartment()
        {
            Tools.displayTickets(this.departmentTicketList);
        }


    }
}
