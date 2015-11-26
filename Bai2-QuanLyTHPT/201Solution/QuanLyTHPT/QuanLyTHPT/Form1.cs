﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void frm_Start_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOPDATA.LOP frclass = new LOPDATA.LOP();
            frclass.ShowDialog();
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOCSINHDATA.HOCSINH frstudent = new HOCSINHDATA.HOCSINH();
            frstudent.ShowDialog();
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GIAOVIENDATA.GIAOVIEN frteacher = new GIAOVIENDATA.GIAOVIEN();
            frteacher.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HUONGDAN.HuongDan frm = new HUONGDAN.HuongDan();
            frm.ShowDialog();
            this.Close();
        }

       
    }
}
