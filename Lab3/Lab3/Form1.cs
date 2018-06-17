using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3
{

    public partial class Form1 : Form
    {
        public List<PointClass> coordinates = new List<PointClass>();  //Create a list of the modified PointClass objects

        public Form1()

        {
            InitializeComponent();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                Point p = new Point(e.X, e.Y);

                Boolean element = false;
                PointClass point = new PointClass(p, element);

                this.coordinates.Add(point);  //Add the object to the list
                this.Invalidate();

            }

            else if (e.Button == MouseButtons.Right)

            {
                for (int i = this.coordinates.Count - 1; i >= 0; i--)
                {
                    Point clicked = new Point(e.X, e.Y);   //clicked position of the mouse
                    Point current = this.coordinates[i].p; //coordinates of the PoinClass object stored in list

                    if ((clicked.X <= (current.X + 20)) && (clicked.X >= (current.X - 20)))
                    {
                        if ((clicked.Y <= (current.Y + 20)) && (clicked.Y >= (current.Y - 20)))

                        {

                            if (this.coordinates[i].color == true)

                                this.coordinates.RemoveAt(i);

                            else
                                this.coordinates[i].color = true;
                        }
                    }


                }

                this.Invalidate();

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            const int HEIGHT = 20;
            const int WIDTH = 20;



            foreach (PointClass point in this.coordinates)
            {
                if (point.color == false)

                    g.FillEllipse(Brushes.Black, point.p.X - WIDTH / 2, point.p.Y - HEIGHT / 2, WIDTH, HEIGHT);

                else if (point.color)
                {
                    g.FillEllipse(Brushes.Red, point.p.X - WIDTH / 2, point.p.Y - HEIGHT / 2, WIDTH, HEIGHT);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }
    }
}

        
