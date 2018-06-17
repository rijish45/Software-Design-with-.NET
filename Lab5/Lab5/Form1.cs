using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Rijish Ganguly


namespace Lab5
{
    public partial class Form1 : Form
    {

        private int[] array;   //array acting as datasource
 
        public Form1()

        {

            InitializeComponent();
            this.ResizeRedraw = true;
            
        }

        //Function to reverse string

        public static string Reverse(string s)

        {
            char[] charArray = s.ToCharArray(); //convert string to chararray
            Array.Reverse(charArray);
            return new string(charArray);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();   //clears the list

            int i = 0;
            int j = 0;

            try
            {
                i = Convert.ToInt32(textBox1.Text);
                j = Convert.ToInt32(textBox2.Text);
            }

            catch (Exception fe)

            {
                //MessageBox.Show(fe.Message);
                label4.Text = "Please enter a positive integer within range."; //Feedback to user because of wrong input
                return;
            }

            if(i < 0 || i > 1000000000)

            {
                label4.Text = "Please enter a positive integer within range."; //Feedback to user because of wrong input
                return;
            }

            if(j <= 0 || j > 100)

            {
                label4.Text = "Please enter a positive integer within range."; //Feedback to user because of wrong input
                return;
            }

            
            label4.Text = " ";
            array = new int[j];

            int count = 0;

            while (count < j)

            { 
                
                string mystring = i.ToString();   //compare the string with its reverse
                string reverse = Reverse(mystring);
                if ((String.Equals(mystring, reverse, StringComparison.Ordinal)) && (i <= 1000000000)) //overloaded Equals function for Object type String
                {
                    array[count] = i;
                    count++;
                }

                i++;
            }

            listBox1.DataSource = array;  //binding the array to the listbox
        }

       
    }
}
