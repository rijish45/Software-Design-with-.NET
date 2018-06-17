using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab6
{
    public partial class Form1 : Form
    {
        //Form properties

        private int pencolor;
        private int penwidth;
        private int fillcolor;
        

        private Point prepoint;
        private bool flag;
        private bool fill;
        private bool outline;


        //Array list keeping track of objects

        private ArrayList Objects = new ArrayList();
       

        //constructor for the form setting up different fields

        public Form1()

        {
            InitializeComponent();

            fill = false;
            outline = true;
            this.LineButton.Checked = true;

            fillcolor = 0;
            penwidth = 0;
            pencolor = 0;



        
            flag = false;
        }

        //Clear button on the menu, clears the items from the list and the screen gets refreshed

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Objects.Clear();
            this.Refresh();
        }

        //Exit button for the menu option exit, closes the form

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)

        {
            this.Close();
        }

       //Removes the last object from the list and clears it from the form

       private void UndoToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (Objects.Count != 0)
            {
                Objects.RemoveAt(Objects.Count - 1);  //remove the last element
            }
            this.Refresh();
        }



        //Drawing the objects in panel 2

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

            Font myfont = new Font("Arial", 30, FontStyle.Bold);

            Graphics g = FillPanel.CreateGraphics();

            //Looping the objects stored and drawing them

            foreach (ObjectDraw currentobject in Objects)

            {
                currentobject.Draw(g);
            }


        }

        private void Button1_Click(object sender, EventArgs e)

        {
            Settings settings = new Settings(fill, outline, pencolor, fillcolor, penwidth); //new settings dialog
            settings.StartPosition = FormStartPosition.CenterParent;

            //Set the attributes

            if (settings.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {
                fillcolor = settings.Getfillcolor();  //Getting the options from the setting dialog

                penwidth = settings.Getpenwidth();
                pencolor = settings.Getpencolor();

                outline = settings.Getisoutline();
                fill = settings.Getisfill();
            }


            this.Refresh();

        }
        
        
        

        private void Form1_Paint(object sender, PaintEventArgs e)

        {
            Panel2_Paint(sender, e);
        }

        //Mouseclick option for panel 2

        private void Panel2_MouseClick(object sender, MouseEventArgs e)

        {
            Point current = new Point(e.X, e.Y);

            //Flag is necessary to determine whether its the first or second click
            if (flag == false)

            {
                prepoint = current;
                flag = true;
                return;
            }


            else
            {//Ellipse is to be drawn
                if (EllipseButton.Checked)

                {
                    if (outline == false && fill == false)
                    {
                        MessageBox.Show("Fill and or outline must be checked");
                    }

                    Ellipse elliptical = new Ellipse(prepoint, current, pencolor, penwidth + 1, fillcolor, fill, outline);

                    Objects.Add(elliptical); //ellipse object is added
                }

                

                else if (RectangleButton.Checked) //Rectangle is to be drawn

                {
                    if (outline == false && fill == false) //error checking
                    {
                        MessageBox.Show("Fill and or outline must be checked");

                    }

                    Rectangle rect = new Rectangle(prepoint, current, pencolor, penwidth + 1, fillcolor, fill, outline);

                    Objects.Add(rect); //rectangle object is added
                }

                else 
                 
                { //Line is default option
                    Line newline = new Line(prepoint, current, pencolor, penwidth + 1);
                    Objects.Add(newline); //line object is added
                }

                flag = false;
                this.Refresh();
                return;
            }
        }
    }
}
