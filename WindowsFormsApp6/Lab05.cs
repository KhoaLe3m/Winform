using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Lab05 : Form
    {
        public Lab05()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cbbDantoc.Text = "Kinh";
            rdbtnNam.Checked = true;
            rdbtnDocThan.Checked = true;
            txtkynang.ReadOnly = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clbkynanglaptrinh.Items.Add(txtKynanglaptrinh.Text);
            bool x = true;
            clbkynanglaptrinh.SetItemChecked(clbkynanglaptrinh.Items.IndexOf(txtKynanglaptrinh.Text), x);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Tên không được để trống", "Hệ Thống", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                MessageBox.Show("Ngày Sinh Không Được Để Trống", "Hệ Thống", MessageBoxButtons.OK);

            }
            else
            {


                tabControl1.SelectTab(1);
                lblTen.Text = txtHoTen.Text;
                lblNgaysinh.Text = txtNgaySinh.Text;
                if (rdbtnNam.Checked == true)
                {
                    lblGioiTinh.Text = "Nam";
                }
                else
                {
                    lblGioiTinh.Text = "Nữ";
                }
                lblDanToc.Text = cbbDantoc.Text;
                if (rdbtnKetHon.Checked == true)
                {
                    lbltthonnhan.Text = "Kết Hôn";
                }
                else if (rdbtnLyHon.Checked == true)
                {
                    lbltthonnhan.Text = "Ly Hôn";
                }
                else
                {
                    lbltthonnhan.Text = "Độc Thân";
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    lblNgoaiNgu.Text = "Anh,Pháp,Hoa";
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    lblNgoaiNgu.Text = "Anh,Pháp";
                }
                else if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    lblNgoaiNgu.Text = "Anh,Hoa";
                }
                else if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    lblNgoaiNgu.Text = "Pháp,Hoa";
                }
                else if (checkBox1.Checked == true)
                {
                    lblNgoaiNgu.Text = "Anh";
                }
                else if (checkBox2.Checked == true)
                {
                    lblNgoaiNgu.Text = "Pháp";
                }
                else if (checkBox1.Checked == true)
                {
                    lblNgoaiNgu.Text = "Hoa";
                }
                if (clbkynanglaptrinh.CheckedItems.Count > 0)
                {
                    txtkynang.Text = "";
                    for (int i = 0; i < clbkynanglaptrinh.CheckedItems.Count - 1; i++)
                    {
                        txtkynang.Text += clbkynanglaptrinh.CheckedItems[i].ToString() + ",";
                    }
                    txtkynang.Text += clbkynanglaptrinh.CheckedItems[clbkynanglaptrinh.CheckedItems.Count - 1].ToString();
                }
                else
                {
                    txtkynang.Text = "Không!";
                }
            }
        }

        private void Lab05_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Hệ Thống", MessageBoxButtons.OKCancel);
            if(result==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }
    }
}
