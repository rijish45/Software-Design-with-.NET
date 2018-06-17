using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab6
{
    class ObjectDraw
    {
        protected Color pencolor;
        protected int penwidth;

        //Draw function which is virtual
        public virtual void Draw(Graphics g)

        {
            return;
        }


        public ObjectDraw(int pencol, int penwid)

        {
            pencolor = Colorconvert(pencol);
            penwidth = penwid;
        }

        //Chooses the color

        protected Color Colorconvert(int inputid)
        {
            Color mycolor;

            switch (inputid)

            {
                case 1:
                    mycolor = Color.FromName("Red");
                    break;

                case 2:
                    mycolor = Color.FromName("Blue");
                    break;

                case 3:
                    mycolor = Color.FromName("Green");
                    break;

                default:
                    mycolor = Color.FromName("Black");
                    break;
            }

            return mycolor;
        }

        //Choosing the fillcolor

        protected Color Fillconvert(int inputid)

        {
            Color mycolor;

            switch (inputid)

            {
                case 1:
                    mycolor = Color.FromName("Black");
                    break;

                case 2:
                    mycolor = Color.FromName("Red");
                    break;

                case 3:
                    mycolor = Color.FromName("Blue");
                    break;

                case 4:
                    mycolor = Color.FromName("Green");
                    break;

                default:
                    mycolor = Color.FromName("White");
                    break;
            }

            return mycolor;
        }
    }


    //Derived class line from ObjectDraw

    class Line : ObjectDraw
    {
        private Point p1, p2;   //depends on the two points clicked by the mouse

        public Line(Point inp1, Point inp2, int pencol, int penwid): base(pencol, penwid)

        {
            p1 = inp1;
            p2 = inp2;
        }

        //overriden draw function, works due to polymorphism

        public override void Draw(Graphics g)
        {
            Pen mypen = new Pen(pencolor, penwidth);
            g.DrawLine(mypen, p1, p2);
        
        } 
    }


    //Derived rectangle class from ObjectDraw

    class Rectangle : ObjectDraw

    {
        private Color FillColor;
        private int x, y, Width, Height;


        bool isfill, isoutline;   //Boolean flags for outline/fill

        public Rectangle(Point inp1, Point inp2, int pencol, int penwid, int infillcolor, bool inisfill, bool inisoutline)
            : base(pencol, penwid)
        {
            if (inp1.X <= inp2.X)
                x = inp1.X;
            else
                x = inp2.X;

            if (inp1.Y <= inp2.Y)
                y = inp1.Y;
            else
                y = inp2.Y;


            //Width and Height attributes

            Width = Math.Abs(inp1.X - inp2.X);
            Height = Math.Abs(inp1.Y - inp2.Y);


            //Other properties depending upon setting dialog

            isoutline = inisoutline;
            isfill = inisfill;
            FillColor = Fillconvert(infillcolor);
            


        }


        //Overriden draw function for rectangle class

        public override void Draw(Graphics g)

        {
            Pen myOutlinepen = new Pen(pencolor, penwidth);
            Brush myFillbrush = new SolidBrush(FillColor);

            if (isfill)
                g.FillRectangle(myFillbrush, x, y, Width, Height);

            if (isoutline)
                g.DrawRectangle(myOutlinepen, x, y, Width, Height);
            return;
        }
    }


    //Derived rectangle class from ObjectDraw

    class Ellipse : ObjectDraw
    {
        private int x, y;
        private int Height, Width;
        private Color FillColor;

        bool isFill;
        bool isoutline;

        public Ellipse(Point inp1, Point inp2, int inpencolor, int inpenwidth, int infillcolor, bool inisfill, bool inisoutline)
        : base(inpencolor, inpenwidth)

        {
            if (inp1.X <= inp2.X)
                x = inp1.X;
            else
                x = inp2.X;

            if (inp1.Y <= inp2.Y)
                y = inp1.Y;
            else
                y = inp2.Y;

            Width = Math.Abs(inp1.X - inp2.X);
            Height = Math.Abs(inp1.Y - inp2.Y);

            FillColor = Fillconvert(infillcolor);
            isoutline = inisoutline;
            isFill = inisfill;
            
        }

        // Overriden draw function for rectangle class
        
        public override void Draw(Graphics g)

        {
            Brush fillbrush = new SolidBrush(FillColor);
            Pen outlinepen = new Pen(pencolor, penwidth);
            

            if (isFill)
                g.FillEllipse(fillbrush, x, y, Width, Height);
            if (isoutline)
                g.DrawEllipse(outlinepen, x, y, Width, Height);

        }
    }

}
