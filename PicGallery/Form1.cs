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

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            this.Hide();
            FormKazimir fb = new FormKazimir();
            fb.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка перехода на форму.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            this.Hide();
            FormClode fb = new FormClode();
            fb.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка перехода на форму.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            this.Hide();
            FormVincent fb = new FormVincent();
            fb.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка перехода на форму.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                afishaform af = new afishaform();
                af.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка перехода на форму.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка перехода на форму.");
            }
        }
    }
}
