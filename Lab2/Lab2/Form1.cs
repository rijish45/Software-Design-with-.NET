using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System;
using System.Data;
using System.Collections;
using System.ComponentModel;


namespace Lab2
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                this.coordinates.Add(p);
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                this.coordinates.Clear();
                this.Invalidate();

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            const int WIDTH = 20;
            const int HEIGHT = 20;
            

            foreach (Point p in this.coordinates)
            {
                g.FillEllipse(Brushes.Red,p.X - WIDTH / 2, p.Y - WIDTH / 2, WIDTH, HEIGHT);
                string coords;
                coords = "(" + p.X.ToString() + " , " + p.Y.ToString() + ")";
                g.DrawString(coords, Font, Brushes.Black, p.X + 10 , p.Y - 7);

                
            }


        }

       

        private void Menu(object sender, ToolStripItemEventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

        private void clear_button(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }
    }
}
