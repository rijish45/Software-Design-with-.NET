using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int Queens;   //Number of Queens

        private bool[,] spots = new bool[8, 8]; //2D array for the board
        private Brush[] color = new Brush[3];

        public Form1()
        {
            InitializeComponent();
            this.Text = "Eight Queens by Rijish Ganguly";
            this.ResizeRedraw = true;
        }


        private bool CorrectMove(int x, int y)

        {
            //For the diagonals there would be four different cases to handle


            //For the diagonal branch top right of the Queen spot

            int diag1 = x;
            for (int m = y; m < 8; m++)
            {
                if (diag1 >= 0)
                {
                    if (spots[diag1, m])
                        return false;
                }

                diag1--;

            }


            //For the diagonal branch top left of the Queen Spot

            int diag2 = x;
            for (int l = y; l >= 0; l--)
            {
                if (diag2 >= 0)
                {
                    if (spots[diag2, l])
                        return false;
                }

                diag2--;
            }

            //For the diagonal branch bottom left 

            int diag3 = x;
            for (int n = y; n >= 0; n--)

            {
                if (diag3 < 8)
                {
                    if (spots[diag3, n])
                        return false;
                }

                diag3++;
            }

            // For the diagonal branch bottom right 

            int diag4 = x;

            for (int p = y; p < 8; p++)
            {
                if (diag4 < 8)

                {
                    if (spots[diag4, p])
                        return false;
                }

                diag4++;
            }



            for (int i = 0; i < 8; i++)  //going along the column, no spot should be safe

            {
                if (spots[i, y])
                return false;
               
            }


            for (int k = 0; k < 8; k++)  //going along the row, no spot should be safe


            {
                if (spots[x, k])
                return false;
  
            }

            //if nothing else
            return true;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)

        {

            int value; //Depending upon this value, assign color
            Graphics g = e.Graphics;

            //The three colors needed to build the board
            color[0] = Brushes.White;
            color[1] = Brushes.Black;
            color[2] = Brushes.Red;

            //iterating over the 2D array

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)

                {

                    bool num1 = ((i + j) % 2 == 0);
                    //bool num2 = ((i + j) % 2 == 1);


                    if (!CorrectMove(i, j) && checkBox1.Checked)

                    {
                        value = 2; //red color when hint button is on
                    }

                   

                    else if (num1)

                    {
                        value = 0; //White
                    }

                    else 

                    {
                        value = 1; //Black
                    }

                    System.Drawing.Pen myPen;
                    myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                    myPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Outset;


                    g.FillRectangle(color[value], 100 + (i * 50), 100 + (j * 50), 50, 50); //Drawing the individual boxes
                    g.DrawRectangle(myPen, 100 + (i * 50), 100 + (j * 50), 50, 50);  //Drawing the board


                    if (spots[i, j] == true)  //If the boolean value of the spot is not set to false

                    {
                        //Drawing the Q
                        Font drawing = new Font("Arial", 30f, FontStyle.Bold); //A new Font Object
                        StringFormat center = new StringFormat(); //String format object
                        center.Alignment = StringAlignment.Center;

                        int num3 = ((value + 1) % 2); //determines the color
                        RectangleF rect = new RectangleF(100 + i * 50, 100 + j*50, (float)(50.00), (float)(50.00)); //rectangle for Q
                        g.DrawString("Q", drawing, color[num3], rect, center);  //Draw the Q

                    }


                }
            }
        }

      
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)

        {
            this.Invalidate();

        }



        private void label1_Click(object sender, EventArgs e)

        {
            label1.Text = "You have " + Queens + " queens on the board.";

        }

        private void button1_Click(object sender, EventArgs e)

        {
            for (int g = 0; g < 8; g++)  
            {
                for (int h = 0; h < 8; h++)
                {
                    spots[g, h] = false;
                }
            }

            Queens = 0;     //reset the Queens number
            label1_Click(sender, e);
            this.Invalidate();

        }


        public void Congratulations ()

        {
       
          MessageBox.Show(" You did it! "); //Congratulations message

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X; //get the clicked coordinates
            int y = e.Y;

            if (((x >= 100) && (x <= 500)) && ((y >= 100) && (y <= 500)))    //check whether click is within the grid

            {
                x = x - 100; //offset adjustment
                x = x / 50;  //get the row number


                y = y - 100; //Offset adjustment
                y = y / 50;  //get the column number

                if (e.Button == MouseButtons.Left)

                {

                    if (CorrectMove(x, y))

                    {
                        spots[x, y] = true;  //set the boolean value of the spot to be true;
                        Queens++;
                        label1_Click(sender, e);

                        if(Queens == 8)

                        {
                            Congratulations();
                        }

                        this.Invalidate();
                    }

                    else
                    {
                        System.Media.SystemSounds.Beep.Play();   //beeping noise
                    }
                }

                else if ((e.Button == MouseButtons.Right) && spots[x, y])

                {
                    
                    spots[x, y] = false;  //Set the boolean value to be false
                    Queens--;  //Remove the Queen on right click
                    label1_Click(sender, e);
                    this.Invalidate();

                }
            }
        }

        
    }
  
}
