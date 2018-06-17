using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Settings : Form
    {

        //Properties for the dialog

        private bool isfill;
        private bool isoutline;

        private int penwidth;
        private int pencolor;


        private int fillcolor;

        
        public Settings()

        {
            InitializeComponent();
        }

        //constructor

        public Settings(bool inputfill, bool inputoutline, int inputpencolor, int infillcolor, int inputpenwidth)

        {

            InitializeComponent();

            penwidth = inputpenwidth;
            WPMeasure.SelectedIndex = inputpenwidth;

            PColor.SelectedIndex = inputpencolor;

            isoutline = inputoutline;
            pencolor = inputpencolor;
            OutlineBox.Checked = inputoutline;

            isfill = inputfill;
            FillBox.Checked = inputfill;

            fillcolor = infillcolor;
            FColor.SelectedIndex = infillcolor;

        }

        //Getter functions for the attributes

        public int Getpenwidth()

        {

            return penwidth;
        }

        public int Getpencolor()

        {
            return pencolor;
        }

        public int Getfillcolor()

        {
            return fillcolor;
        }
       

        public bool Getisfill()

        {
            return isfill;

        }

        public bool Getisoutline()

        {
            return isoutline;
        }

        //Okay button function, sets the attributes to following

        private void OkayButton_Click1(object sender, EventArgs e)


        {
            isfill =    FillBox.Checked;
            fillcolor = FColor.SelectedIndex;
            penwidth  = WPMeasure.SelectedIndex;
            isoutline = OutlineBox.Checked;
            pencolor  = PColor.SelectedIndex;

        }
    }
}
