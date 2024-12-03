using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(txtMa.Text);
            item1.SubItems.Add(txtTen.Text);
            item1.SubItems.Add(txtGia.Text);
            LvSanPham.Items.Add(item1);

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            while (LvSanPham.SelectedItems.Count > 0)
            {
                Console.WriteLine(LvSanPham.SelectedItems[0].Index);
                LvSanPham.Items.RemoveAt(LvSanPham.SelectedItems[0].Index);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (LvSanPham.SelectedItems.Count >0);
            {
                ListViewItem item1 = LvSanPham.SelectedItems[0];
                item1.SubItems[0].Text = txtMa.Text;
                item1.SubItems[1].Text = txtTen.Text;
                item1.SubItems[2].Text = txtGia.Text;
            }
        }
    }
}
