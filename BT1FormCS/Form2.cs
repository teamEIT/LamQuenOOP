using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1FormCS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string str;
        // Hàm load là hàm chạy đầu tiên khi form chạy
        private void Form2_Load(object sender, EventArgs e)
        {
            labelChao.Text = "Chào bạn " + str;
        }
    }
}
