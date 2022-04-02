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
    public partial class Lab04 : Form
    {
        public Lab04()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBox1.Text = "Quản lý";
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "ToRight!");
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(button2, "ToLeft!");
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(button3, "ToRightAll!");
            toolTip4.ShowAlways = true;
            toolTip4.SetToolTip(button4, "ToLeftAll!");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập dữ liệu!", "Hệ Thống", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Bạn có muốn thêm hay không!", "Hệ Thống", MessageBoxButtons.OKCancel);
                if(result==DialogResult.OK)
                {
                    if (comboBox1.Text == "Quản lý")
                    {
                        if (listBPQL.Items.IndexOf(txtHoTen.Text) > -1)
                        {
                            listBPQL.SelectedIndex = listBPQL.Items.IndexOf(txtHoTen.Text);
                        }
                        else
                        {
                            listBPQL.Items.Add(txtHoTen.Text);
                            listBPQL.SelectedIndex = listBPQL.Items.IndexOf(txtHoTen.Text);
                        }
                    }
                    else if (comboBox1.Text == "Nghiên cứu")
                    {
                        
                        if (listBPNC.Items.IndexOf(txtHoTen.Text) > -1)
                        {
                            listBPNC.SelectedIndex = listBPNC.Items.IndexOf(txtHoTen.Text);
                        }
                        else
                        {
                            listBPNC.Items.Add(txtHoTen.Text);
                            listBPNC.SelectedIndex = listBPNC.Items.IndexOf(txtHoTen.Text);
                        }
                    }
                }   
                    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát chương trình!", "Hệ Thống", MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                Close();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn Xóa hay không!", "Hệ Thống", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (listBPNC.SelectedIndex >= 0)
                {
                    listBPNC.Items.RemoveAt(listBPNC.SelectedIndex);
                }
                else
                {
                    if (listBPQL.SelectedIndex >= 0)
                    {
                        listBPQL.Items.RemoveAt(listBPQL.SelectedIndex);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBPNC.SelectedIndex >= 0)
            {
                listBPQL.Items.Add(listBPNC.SelectedItem.ToString());
                listBPNC.Items.RemoveAt(listBPNC.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBPQL.SelectedIndex >= 0)
            {
                listBPNC.Items.Add(listBPQL.SelectedItem.ToString());
                listBPQL.Items.RemoveAt(listBPQL.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBPNC.Items.Count==0)
            {
                return;
            }
            else
            {
                for(int i=0;i<listBPNC.Items.Count;i++)
                {
                    listBPQL.Items.Add(listBPNC.Items[i]);
                }
                listBPNC.Items.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBPQL.Items.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < listBPQL.Items.Count; i++)
                {
                    listBPNC.Items.Add(listBPQL.Items[i]);
                }
                listBPQL.Items.Clear();
            }   
        }
    }
}
