﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanhtrenlop
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Luong' table. You can move, or remove it, as needed.
            this.LuongTableAdapter.Fill(this.DataSet1.Luong, 2017);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LuongTableAdapter.Fill(this.DataSet1.Luong, (int)mumthongke.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
