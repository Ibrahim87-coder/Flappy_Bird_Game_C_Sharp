﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        
           
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Flappy_Bird p = new Flappy_Bird();
            p.Show();
            this.Close();


        }
      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Class1.Exit = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
    }
}
