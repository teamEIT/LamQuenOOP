using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtForm
{
    public partial class FormEquation : Form
    {
        double a, b, c, delta, x1, x2;
        string s;
        PhuongTrinhB1 pTB1 = new PhuongTrinhB1();
        PhuongTrinhB2 pTB2 = new PhuongTrinhB2();

        private void radioButtonPtb2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxC.Enabled = true;
            this.textBoxA.ResetText();
            this.textBoxB.ResetText();
            this.textBoxC.ResetText();
            this.textBoxResult.ResetText();
        }

        private void radioButtonPtb1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxC.Enabled = false;
            this.textBoxA.ResetText();
            this.textBoxB.ResetText();
            this.textBoxC.ResetText();
            this.textBoxResult.ResetText();
        }

        public FormEquation()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonCalc_Click(object sender, EventArgs e)
        {
            #region GiaiPTB1
            if (radioButtonPtb1.Checked == true)
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                s = pTB1.GiaiPTB1(a, b);
                textBoxResult.Text = s;
            }
            #endregion

            #region GiaiPTB2
            if(radioButtonPtb2.Checked == true)
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
                s = pTB2.GiaiPTB2(a, b, c);
                textBoxResult.Text = s;
            }
            #endregion
        }
    }
}
