using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePayrollProgramChuaFinal
{
    public class Person
    {
        public string employeeName;
        public string address;

        public Person(string Name, string Address)
        {
            this.employeeName = Name;
            this.address = Address;
        }

        public string displayName()
        {
            return employeeName;
        }

        public string displayAddress()
        {
            return address;
        }
    }

    public class Employee : Person
    {
        private double employeeID;

        public Employee(string name, string addr, double employeeID) : base(name, addr)
        {
            this.employeeID = employeeID;
        }

        public string displayInfo()
        {
            base.displayName();
            base.displayAddress();
            return Convert.ToString(employeeID);
        }
    }
}
