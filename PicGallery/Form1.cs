using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDali FD = new FormDali();
            FD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPablo fb = new FormPablo();
            fb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdward fb = new FormEdward();
            fb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKazimir fb = new FormKazimir();
            fb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClode fb = new FormClode();
            fb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVincent fb = new FormVincent();
            fb.Show();
        }
    }
}
