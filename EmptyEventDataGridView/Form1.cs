using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyEventDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> listSinhVien;
        private void Form1_Load(object sender, EventArgs e)
        {
            listSinhVien = new List<SinhVien>();
            InitData();
        }

        private void InitData()
        {
            dgrvSinhVien.Rows.Add(1, "Tuan");
            dgrvSinhVien.Rows.Add(2, "Tuan");
            dgrvSinhVien.Rows.Add(3, "Tuan");
            dgrvSinhVien.Rows.Add(4, "Tuan");
            dgrvSinhVien.Rows.Add(5, "Tuan");
        }

        private void DgrvSinhVien_Paint(object sender, PaintEventArgs e)
        {
            if(dgrvSinhVien.RowCount == 0)
            {
                DataGridView sndr = (DataGridView)sender;

                if (sndr.Rows.Count == 0) // <-- if there are no rows in the DataGridView when it paints, then it will create your message
                {
                    using (Graphics grfx = e.Graphics)
                    {
                        grfx.DrawString("Không có dữ liệu !", new Font("Comic Sans MS", 12, FontStyle.Regular), Brushes.Red, new PointF(23, 43));
                        //grfx.DrawString()
                        var image = Properties.Resources.unnamed;

                        //dataGridView1.Size
                        var imageStartX = (0 + (dgrvSinhVien.Width / 2)) - (image.Width / 2);

                        var imageStartY = (0 + (dgrvSinhVien.Height / 2)) - (image.Height / 2) + 40;
                        //var rect = new Rectangle(imageStartX + 20, imageStartY + 40, image.Width - 40, image.Height - 40);
                        var rect = new Rectangle(imageStartX + 20, imageStartY, 160, 112);
                        grfx.DrawImage(image, rect);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dgrvSinhVien.Rows.Clear();
        }
    }
}
