using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class Settings : Form
    {
        Form1 Form1;
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1 == null)
            {
                Form1 = new Form1();   //Create form if not created
                Form1.FormClosed += Form1_closed;  //Add eventhandler to cleanup after form closes
            }

            Form1.Show(this);  //Show Form assigning this form as the forms owner
            Hide();

            try
            {
                if (checkBox1.Checked == true)
                {
                    globals.autosave = true;
                    StreamWriter File = new StreamWriter(globals.folder + "/Settings.msgmaker");
                    File.Write("Autosave = True");
                    File.Close();
                    File.Dispose();
                }
                else
                {
                    globals.autosave = false;
                    StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", false);
                    File.Write("");
                    File.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bruh which app is using a .msgmaker file rn");
            }
        }

        private void Form1_closed(object sender, FormClosedEventArgs e)
        {
            Form1 = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (globals.autosave == true)
                {
                    System.IO.File.Delete(globals.folder + "/Settings.msgmaker");
                    StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", true);
                    for (int i = 1; i < 2; i++)
                    {
                        File.Write("Autosave = True\r\n");
                        File.Write("Settings");
                    }
                    File.Close();
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            StreamReader check = new StreamReader(globals.folder + "/Settings.msgmaker");
            string result = check.ReadLine();
            if (result == "Autosave = True")
            {
                globals.autosave = true;
                checkBox1.Checked = true;
                check.Close();
            }
            else
            {
                globals.autosave = false;
                check.Close();
            }
        }
    }
}
