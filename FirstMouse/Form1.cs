using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FirstMouse
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            First();
        }

        async void First()
        {
            int value_x1;
            int value_x2;
            pictureBox1.Location = new Point(12, 72);
            pictureBox2.Location = new Point(12, 146);
            while (pictureBox1.Location.X <= 700 && pictureBox2.Location.X <= 700)
            {
                value_x1 = random.Next(0, 5);
                value_x2 = random.Next(0, 5);
                pictureBox1.Location = new Point(pictureBox1.Location.X + value_x1, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + value_x2, pictureBox2.Location.Y);
                await Task.Delay(Convert.ToInt32(textBox1.Text));
            }
            if (pictureBox1.Location.X > pictureBox2.Location.X)
            {
                label2.Text = "Победила первая мышь!";
                label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
            }
            else
            {
                label2.Text = "Победила вторая мышь!";
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
        }

        async void Second()
        {
            int value_x;
            int value_y;
            while (pictureBox2.Location.X < 700)
            {
                value_x = random.Next(0, 5);
                value_y = random.Next(0, 5);
                pictureBox2.Location = new Point(pictureBox2.Location.X + value_x, pictureBox2.Location.Y);
                await Task.Delay(10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 72);
            pictureBox2.Location = new Point(12, 146);
            label2.Text = "";
            label4.Text = "0";
            label5.Text = "0";
        }
    }
}
