using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator_Main : Form
    {
        public Calculator_Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double tax, salary, psalary;
            salary = Convert.ToDouble(txteenteryoursalary.Text);
            if (salary < 500000)
                tax = 0;
            else if (salary < 1000000)
                tax = 5 * salary / 100;
            else if (salary < 2000000)
                tax = 15 * salary / 100;
            else
                tax = 20 * salary / 100;
            psalary = salary - tax;
            lblresult.Text = txtenteryourname.Text + " your tax is : " + tax.ToString() + "T" + "\n your pur salary is " + psalary.ToString() + "T";
            string s;
            s = txtenteryourname.Text + " your tax is : " + tax.ToString() + "T" + "\n your pur salary is " + psalary.ToString() + "T";
            MessageBox.Show(s);
            txtenteryourname.Focus();
            txtenteryourname.SelectAll();
        }

        private void btnexit_Click(object sender, EventArgs e)
        { 
            DialogResult x;
            x=MessageBox.Show("مایلید خارج شوید ؟ " , "خداوکیلی نیااااا" , MessageBoxButtons.YesNo );
            if(x==DialogResult.Yes)
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtenteryourname.Text = "";
            txteenteryoursalary.Text = "";
            lblresult.Text = "";
            txtenteryourname.Focus();
        }
    }
}
