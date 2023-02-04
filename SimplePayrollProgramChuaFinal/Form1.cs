using SimplePayrollProgramChuaFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePayrollProgramChuaFinal
{
    public partial class Form1 : Form
    {
        public static string _employeeName, _employeeAddress, _date, _department, _jobtitle, _gender;
        public static double _employeeID;
        public static decimal _basicPay, _otPay;
        public static int _workingDays, _otWorkingDays;
        public static decimal _paymentWithoutTax, _regularPayment, _otPayment, _paymentWithTax;
        public static decimal _tax;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] department =
            {
                "Men's Department",
                "Women's Department",
                "Children's Department",


            };
            foreach (string dept in department)
            {
                cbDepartment.Items.Add(dept);
            }

            string[] jobTitle =
            {
                "Cashier",
                "Baggers",
                "Salesman",
                "Saleslady",
                "Security Guard",
                "Manager",

            };
            foreach (string job in jobTitle)
            {
                cbJobTitle.Items.Add(job);
            }
            string[] sex =
            {
                "Male",
                "Female",
            };
            foreach (string s in sex)
            {
                cbSex.Items.Add(s);
            };

            txtboxDeductions.Text = "10%";
        }



        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAddress.Clear();
            txtboxBasicPay.Clear();
            txtboxDeductions.Clear();
            txtboxEmployeeID.Clear();
            txtboxName.Clear();
            txtboxOvertimePay.Clear();
            txtboxWorkingDays.Clear();
            cbDepartment.SelectedIndex = -1;
            cbJobTitle.SelectedIndex = -1;
            cbSex.SelectedIndex = -1;
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            Payslip PaySlip = new Payslip();
            Employee PerSon = new Employee
                (_employeeName = txtboxName.Text,
                _employeeAddress = txtboxAddress.Text,
                _employeeID = Convert.ToInt64(txtboxEmployeeID.Text));
            PerSon.displayInfo();

            Salary SaLary = new Salary
                (
                _basicPay = Convert.ToDecimal(txtboxBasicPay.Text),
                _workingDays = Convert.ToInt32(txtboxWorkingDays.Text),
                _otPay = Convert.ToDecimal(txtboxOvertimePay.Text),
                _otWorkingDays = Convert.ToInt32(txtboxWorkingDays.Text)
                );
            _regularPayment = SaLary.showRegSal();
            _otPayment = SaLary.showOtSal();
            _paymentWithoutTax = SaLary.showTotalSal();
            _date = dtpDate.Value.ToString("MM-dd-yyyy");
            _department = cbDepartment.SelectedItem.ToString();
            _jobtitle = cbJobTitle.SelectedItem.ToString();
            _gender = cbSex.SelectedItem.ToString();
            SetTax();

            PaySlip.Show();
        }
        private decimal SetTax()
        {
            _tax = 0.05m * _paymentWithoutTax;
            _paymentWithTax = _paymentWithoutTax - _tax;
            return _paymentWithTax;
        }




    }
}
