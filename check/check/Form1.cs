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

namespace check
{
    public partial class Form1 : Form
    {
        main main;
        Settings Settings;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (main == null)
            {
                main = new main();   //Create form if not created
                main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
            }

            main.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        void main_closed(object sender, FormClosedEventArgs e)
        {
            main = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
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
                        File.Write("Form1");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Settings == null)
            {
                Settings = new Settings();   //Create form if not created
                Settings.FormClosed += Setting_closed;  //Add eventhandler to cleanup after form closes
            }

            Settings.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void Setting_closed(object sender, FormClosedEventArgs e)
        {
            Settings = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }
    }
}
