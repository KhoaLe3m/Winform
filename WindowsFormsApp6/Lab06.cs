using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Lab06 : Form
    {
        public Lab06()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            rdbtnNam.Checked = true;
            cbTrangthai.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtTaiKhoan.Text;
            item.SubItems.Add(txtHoTen.Text);
            if (rdbtnNam.Checked == true)
            {
                item.SubItems.Add("Nam");
            }
            else
            {
                item.SubItems.Add("Nữ");
            }
            item.SubItems.Add(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
            if (cbTrangthai.Checked == true)
            {
                item.SubItems.Add("Hoạt động");
            }
            else
            {
                item.SubItems.Add("Không hoạt động");
            }
            listView1.Items.Add(item);
            
        }

        private void Lab06_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                dtpNgaySinh.Value = DateTime.ParseExact(
                    listView1.SelectedItems[0].SubItems[3].Text, "dd/MM/yyyy",CultureInfo.InvariantCulture);
                txtHoTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtTaiKhoan.Text = listView1.SelectedItems[0].SubItems[0].Text;
                if(listView1.SelectedItems[0].SubItems[2].Text=="Nam")
                {
                    rdbtnNam.Checked = true;
                }
                else
                {
                    rdbtnNu.Checked = true;
                }
                if(listView1.SelectedItems[0].SubItems[4].Text=="Hoạt động")
                {
                    cbTrangthai.Checked = true;
                }
                else
                {
                    cbTrangthai.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rdbtnNam.Checked==true)
            {
                listView1.SelectedItems[0].SubItems[2].Text = "Nam";
            }
            else
            {
                listView1.SelectedItems[0].SubItems[2].Text = "Nữ";
            }
            listView1.SelectedItems[0].SubItems[0].Text = txtTaiKhoan.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
            if (cbTrangthai.Checked == true)
            {               
                listView1.SelectedItems[0].SubItems[4].Text = "Hoạt động";
            }
            else
            {
                listView1.SelectedItems[0].SubItems[4].Text = "Không Hoạt động";
            }
            listView1.SelectedItems[0].SubItems[3].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index=0;
            if(listView1.Items.Count>0)
            {
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                listView1.Items.RemoveAt(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtTaiKhoan.Text = "";
            rdbtnNam.Checked = true;
            cbTrangthai.Checked = true;
            DateTimePicker x = new DateTimePicker();
            dtpNgaySinh.Value = x.Value;
        }

        private void Lab06_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Bạn có muốn thoát chương trình", "Hệ Thống", MessageBoxButtons.OKCancel);
            if(x==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }
    }
}
