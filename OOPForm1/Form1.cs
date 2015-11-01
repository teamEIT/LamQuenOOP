using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            PhepTinh cal = new PhepTinh();

            try
            {
                cal.NumberA = Convert.ToDouble(txtNumberA.Text);
                cal.NumberB = Convert.ToDouble(txtNumberB.Text);
            }
            catch (Exception)
            {

                if (txtNumberA.Text == "")
                {
                    MessageBox.Show("Input A to calculate.");
                    txtNumberA.Focus();
                }
                else if (txtNumberB.Text == "")
                {
                    MessageBox.Show("Input B to calculate.");
                    txtNumberB.Focus();
                }
            }

            double result = cal.PhepCong();

            lblOperator.Text = "+";

            txtResultNumA.Text = txtNumberA.Text;
            txtResultNumB.Text = txtNumberB.Text;
            txtResult.Text = result.ToString();
            cal = null;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            PhepTinh cal = new PhepTinh();

            try
            {
                cal.NumberA = Convert.ToDouble(txtNumberA.Text);
                cal.NumberB = Convert.ToDouble(txtNumberB.Text);
            }
            catch (Exception)
            {

                if (txtNumberA.Text == "")
                {
                    MessageBox.Show("Input A to calculate.");
                    txtNumberA.Focus();
                }
                else if (txtNumberB.Text == "")
                {
                    MessageBox.Show("Input B to calculate.");
                    txtNumberB.Focus();
                }
            }

            double result = cal.PhepTru();

            lblOperator.Text = "-";

            txtResultNumA.Text = txtNumberA.Text;
            txtResultNumB.Text = txtNumberB.Text;
            txtResult.Text = result.ToString();
            cal = null;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PhepTinh cal = new PhepTinh();

            try
            {
                cal.NumberA = Convert.ToDouble(txtNumberA.Text);
                cal.NumberB = Convert.ToDouble(txtNumberB.Text);
            }
            catch (Exception)
            {

                if (txtNumberA.Text == "")
                {
                    MessageBox.Show("Input A to calculate.");
                    txtNumberA.Focus();
                }
                else if (txtNumberB.Text == "")
                {
                    MessageBox.Show("Input B to calculate.");
                    txtNumberB.Focus();
                }
            }

            double result = cal.PhepNhan();

            lblOperator.Text = "*";

            txtResultNumA.Text = txtNumberA.Text;
            txtResultNumB.Text = txtNumberB.Text;
            txtResult.Text = result.ToString();
            cal = null;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            PhepTinh cal = new PhepTinh();

            try
            {
                cal.NumberA = Convert.ToDouble(txtNumberA.Text);
                cal.NumberB = Convert.ToDouble(txtNumberB.Text);
            }
            catch (Exception)
            {

                if (txtNumberA.Text == "")
                {
                    MessageBox.Show("Input A to calculate.");
                    txtNumberA.Focus();
                }
                else if (txtNumberB.Text == "")
                {
                    MessageBox.Show("Input B to calculate.");
                    txtNumberB.Focus();
                }
            }

            double result = cal.PhepChia();

            lblOperator.Text = "/";

            txtResultNumA.Text = txtNumberA.Text;
            txtResultNumB.Text = txtNumberB.Text;
            txtResult.Text = result.ToString();
            cal = null;
        }

    }
}
