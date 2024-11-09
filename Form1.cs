using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btDichVuKhamBenh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txbnam.Text);
            if (a < 1900 || a > 2050)
            {
                MessageBox.Show("NĂM ko tồn tại!");
                txbnam.Clear();
            }




            DisplayResult();
        }

        private void DisplayResult()
        {
            string name = txbhoten.Text;
            string day = txbngay.Text;
            string month = txbthang.Text;
            string year = txbnam.Text;

            // Get selected services
            var selectedServices = string.Join(", ", lsbdanhsach.Items.Cast<string>());

            // Display the result in the label or TextBox
            rtbthongtin.Text = $"Họ tên: {name}\n" +
                               $"Ngày Sinh: {day}/{month}/{year}\n" +
                               $"Dịch vụ đã chọn: {selectedServices}";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txbhoten.Clear();
            lsbdanhsach.Items.Clear();
            rtbthongtin.Clear();
            txbngay.Clear();
            txbthang.Clear();
            txbngay.Clear();
        }

        private void lsbdichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbdanhsach.Items.Add(lsbdichvu.SelectedItems[0]);
        }

        private void txbngay_TextChanged(object sender, EventArgs e)
        {
        
                int a;
                if (!int.TryParse(txbngay.Text, out a))
                {
                    MessageBox.Show("Ko nhap chu");

                    return;

                }
                if (a < 1 || a > 31)
                {
                    MessageBox.Show("Ko tồn tại!");
                    txbngay.Clear();
                }
            }

        private void txbthang_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txbthang.Text);
            if (a < 1 || a > 12)
            {
                MessageBox.Show("Ko tồn tại!");
                txbthang.Clear();
            }
        }

        private void txbnam_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
