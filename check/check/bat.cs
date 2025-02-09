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
using System.Diagnostics;

namespace check
{
    public partial class bat : Form
    {
        main main;
        voice voice;
        public bat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globals.batmsg = textBox1.Text;
            string msg = textBox1.Text;
            StreamWriter File = new StreamWriter(globals.folder + "/message.bat");
            File.Write("C:/Windows/Sysnative/msg.exe /server:localhost * " + globals.batmsg);
            File.Close();
            Process.Start(globals.batfile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globals.isbat = false;
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

        private void bat_closing(object sender, FormClosingEventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            globals.batmsg = textBox1.Text;
            StreamWriter File = new StreamWriter(globals.folder + "/message.bat");
            File.Write("C:/Windows/Sysnative/msg.exe /server:localhost * " + globals.batmsg);
            File.Close();
            if (voice == null)
            {
                voice = new voice();
                voice.FormClosed += voice_closed;
            }
            voice.Show(this);
            Hide();
        }

        private void voice_closed(object sender, FormClosedEventArgs e)
        {
            voice = null;
            Application.Exit();
        }

        private void bat_FormClosed(object sender, FormClosedEventArgs e)
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
                        File.Write("bat");
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
    }
}
