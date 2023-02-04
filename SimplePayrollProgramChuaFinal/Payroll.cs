using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePayrollProgramChuaFinal
{
   public class Payroll
    {
        public decimal regSalary;
        public decimal OTSalary;

        public Payroll(decimal basicPay, int workingDays, decimal otSalary, int otWorkingDays)
        {
            this.regSalary = basicPay * workingDays;
            this.OTSalary = OTSalary * otWorkingDays;
        }

        public decimal showRegSal()
        {
            return regSalary;
        }

        public decimal showOtSal()
        {
            return OTSalary;
        }
    }

    public class Salary : Payroll
    {
        public decimal overallSalary;

        public Salary(decimal basicPay, int workingDays, decimal otSalary, int otWorkingDays) : base(basicPay, workingDays, otSalary, otWorkingDays)
        {
            this.overallSalary = regSalary + OTSalary;
        }

        public decimal showTotalSal()
        {
            base.showRegSal();
            base.showOtSal();
            return overallSalary;
        }
    }
}
