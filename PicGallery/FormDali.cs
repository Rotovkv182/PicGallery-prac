﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicGallery
{
    public partial class FormDali : Form
    {
        public FormDali()
        {
            InitializeComponent();
        }
        private bool isSmall = true;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int halfAdd = 20; // половина от того на сколько изображение увеличится
            if (isSmall)
            {
                // Location меняем чтобы пикча росла не только влево и вниз, а во все стороны
                pictureBox1.Location = new Point(pictureBox1.Location.X - halfAdd, pictureBox1.Location.Y - halfAdd);
                pictureBox1.Height += 10 * halfAdd;
                pictureBox1.Width += 10 * halfAdd;
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + halfAdd, pictureBox1.Location.Y + halfAdd);
                pictureBox1.Height -= 10 * halfAdd;
                pictureBox1.Width -= 10 * halfAdd;
            }
            isSmall = !isSmall;
            pictureBox1.BringToFront(); // передний план
        }
    }
}