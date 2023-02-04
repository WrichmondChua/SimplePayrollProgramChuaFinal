using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePayrollProgramChuaFinal
{
    public partial class Payslip : Form
    {
        public Payslip()
        {
            InitializeComponent();
        }

        private void Payslip_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = Form1._employeeName.ToString();
            lblAddress.Text = Form1._employeeAddress.ToString();
            lblEmployeeID.Text = Form1._employeeID.ToString();
            lblDate.Text = Form1._date.ToString();
            lblSex.Text = Form1._gender.ToString();
            lblDepartment.Text = Form1._department.ToString();
            lblJobTitle.Text = Form1._jobtitle.ToString();
            lblJobTitle.Text = Form1._jobtitle.ToString();
            lblRegPayment.Text = Form1._regularPayment.ToString("C");
            lblOvertimePayment.Text = Form1._otPayment.ToString("C");
            lblSalaryWithoutTax.Text = Form1._paymentWithoutTax.ToString("C");
            lblTax.Text = Form1._tax.ToString("C");
            lblSalary.Text = Form1._paymentWithTax.ToString("C");
        }
    }
}
