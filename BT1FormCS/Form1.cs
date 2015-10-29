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
    public partial class Form1 : Form
    {
        double so1 = 0, so2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoichao_Click(object sender, EventArgs e)
        {
            labelLoiChao.Text = "Chào bạn " + textBoxTen.Text; 
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            try
            {
                so1 = double.Parse(textBoxSoMot.Text);
                so2 = double.Parse(textBoxSoHai.Text);
                double tong = so1 + so2;

                textBoxKetQua.Text = "Tổng = " + tong.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kiểu dữ liệu.");
                textBoxSoMot.Text = "";
                textBoxSoHai.Text = "";
                textBoxSoMot.Focus(); // Đưa con trỏ về control
            }
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            try
            {
                so1 = double.Parse(textBoxSoMot.Text);
                so2 = double.Parse(textBoxSoHai.Text);
                double hieu = so1 - so2;

                textBoxKetQua.Text = "Hiệu = " + hieu.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kiểu dữ liệu.");
                textBoxSoMot.Text = "";
                textBoxSoHai.Text = "";
                textBoxSoMot.Focus();
            }
            
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            try
            {
                so1 = double.Parse(textBoxSoMot.Text);
                so2 = double.Parse(textBoxSoHai.Text);
                double tich = so1 * so2;

                textBoxKetQua.Text = "Tích = " + tich.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kiểu dữ liệu.");
                textBoxSoMot.Text = "";
                textBoxSoHai.Text = "";
                textBoxSoMot.Focus();
            }

            
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(textBoxSoMot.Text);
                double so2 = double.Parse(textBoxSoHai.Text);
                double thuong = 0;
                if (so2 != 0)
                {
                    thuong = so1 / so2;
                    textBoxKetQua.Text = "Thương = " + thuong.ToString();
                }
                else
                {
                    textBoxKetQua.Text = "N/A";
                    MessageBox.Show("Lỗi chia cho 0.");
                    textBoxSoHai.Text = "";
                    textBoxSoHai.Focus();
                } 
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kiểu dữ liệu.");
                textBoxSoMot.Text = "";
                textBoxSoHai.Text = "";
                textBoxSoMot.Focus();
            }
           
        }

        private void buttonMoForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // truyền dữ liệu trước khi show
            form2.str = textBoxTen.Text;
            //form2.Show(); // Cho phép mở nhiều form
            form2.ShowDialog(); // Chỉ cho phép mở 1.
        }
    }
}
