using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab7
{
    public partial class Form1 : Form
    {

        public string outputfilename;
        //flag to determine outputfilename based on encrypt/decrypt
        public bool flag;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                FileBrowseTextBox.Text = filedialog.FileName;
            }

        }

        //Error checking before encrypt button is pressed 

        private bool EncryptErrorchecking()
        {
            if (KeyTextBox.Text == "")  //No key entered
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            if (FileBrowseTextBox.Text == "")   //No filename entered by the user
            {
                MessageBox.Show("Could not open source or destination file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            
           /* if (!File.Exists(FileBrowseTextBox.Text))
            {
                MessageBox.Show("Could not open source or destination file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } */


            else
                return false;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            flag = true;
           

            if (!EncryptErrorchecking())
            {
                if (!OverwriteFileCheck())
                {

                    FileStream filein = null;
                    FileStream fileout = null;

                    //source and destination paths
                    string sourcepath = Path.GetFullPath(FileBrowseTextBox.Text);
                    string destpath = string.Concat(FileBrowseTextBox.Text, ".enc");



                    try
                    {
                        using (filein = new FileStream(sourcepath, FileMode.Open, FileAccess.Read))
                        {
                            int bytesread = 0;
                            // Read the source file into a byte array.
                            byte[] bytes = new byte[filein.Length];
                            int bytestoread = (int)filein.Length;

                            while (bytestoread > 0)
                            {
                               
                                int n = filein.Read(bytes, bytesread, bytestoread);

                                if (n == 0)
                                    break;

                                bytesread += n;
                                bytestoread -= n;
                            }

                            bytestoread = bytes.Length;
                            using (fileout = new FileStream(destpath, FileMode.Create, FileAccess.Write))
                            {
                                string key = KeyTextBox.Text;
                                byte[] resultbytes = new byte[bytestoread];

                                //Bitwise XOR with wrapping

                                for (int i = 0; i < bytestoread; i++)
                                {
                                    int j = i % (key.Length);
                                    resultbytes[i] = (byte)(bytes[i] ^ key[j]);

                                }

                                fileout.Write(resultbytes, 0, bytestoread);
                                MessageBox.Show("Operation completed successfuly.");
                            }

                        }

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (filein != null)
                            filein.Close();
                        if (fileout != null)
                            fileout.Close();
                        return;
                    }


                    filein.Close();
                    fileout.Close();
                }

                else
                    return;

            }

            else
                return;

        }

            private bool DecryptErrorChecking()
        {

            if (KeyTextBox.Text == "")                  // No key entered
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


           //Not a .enc file or no filename entered 

            if ((!(FileBrowseTextBox.Text.EndsWith(".enc"))) || FileBrowseTextBox.Text == "")           
            {
                MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


           else
                return false;
        }


        public bool OverwriteFileCheck()

        {
            //remove the enc extension 
            if (!flag)
                outputfilename = FileBrowseTextBox.Text.Substring(0, FileBrowseTextBox.Text.Length - 3);
            else
                outputfilename = String.Concat(FileBrowseTextBox.Text, ".enc");

            if (File.Exists(outputfilename))
            {
              

                //Depending on whether the user chooses to overwrite or not

                if (MessageBox.Show("Output file exists. Overwrite?","File Exists",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return true;
                }

                else
                {
                    return false;
                }
                        
            }

            return false;

        }


        private void DecryptErrorButton_Click(object sender, EventArgs e)

        {

            flag = false;
            if (!DecryptErrorChecking())
            {

                if (!OverwriteFileCheck())
                {
                    FileStream fileinput = null;
                    FileStream fileoutput = null;

                    //source and destination paths

                    string sourcepath = Path.GetFullPath(FileBrowseTextBox.Text);
                    string destpath = Path.GetFullPath(outputfilename);

                    try
                    {
                        using (fileinput = new FileStream(sourcepath, FileMode.Open, FileAccess.Read))
                        {
                            int bytesread = 0;
                            // Read the source file into a byte array.
                            byte[] bytes = new byte[fileinput.Length];
                            int bytestoread = (int)fileinput.Length;

                            while (bytestoread > 0)
                            {
                               
                                int n = fileinput.Read(bytes, bytesread, bytestoread);

                                if (n == 0)
                                    break;

                                bytesread += n;
                                bytestoread -= n;
                            }

                            bytestoread = bytes.Length;
                            using (fileoutput = new FileStream(destpath, FileMode.Create, FileAccess.Write))
                            {
                                string key = KeyTextBox.Text;
                                byte[] resultbytes = new byte[bytestoread];

                                for (int i = 0; i < bytestoread; i++)
                                {
                                    int j = i % (key.Length);
                                    resultbytes[i] = (byte)(bytes[i] ^ key[j]);

                                }


                                fileoutput.Write(resultbytes, 0, bytestoread);
                                MessageBox.Show("Operation completed successfuly.");
                            }

                        }

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fileinput != null)
                            fileinput.Close();
                        if (fileoutput != null)
                            fileoutput.Close();
                        return;
                    }

                    fileinput.Close();
                    fileoutput.Close();

                }
                else
                    return;
            }

            else
                return;

        }



    }
  
}
