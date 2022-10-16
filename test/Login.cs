using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;


namespace test
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Login()

        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (keyBox.Text == "ZAID" || keyBox.Text == "Zaid" || keyBox.Text == "zaid")
            {
                MessageBox.Show("Correct key");
                new afterlogin().Show();
                   this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong key");
                keyBox.Clear();
                keyBox.Focus();
            }
        }




        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p  = PointToScreen(e.Location);
                Location = new Point(p.X-this.startPoint.X, p.Y-this.startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
    }
}
