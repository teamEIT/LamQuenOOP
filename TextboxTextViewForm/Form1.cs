using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxTextViewForm
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = textBoxName.Text + "\r\n" + comboBoxDay.Text + "/" + comboBoxMonth.Text + "/" + comboBoxYear.Text + "\r\n" + textBoxFavor.Text;
        }
    }
}
