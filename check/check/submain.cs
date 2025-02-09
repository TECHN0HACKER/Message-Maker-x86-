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
using System.Threading;

namespace check
{
    public partial class submain : Form
    {
        main main;
        voice voice;
        public submain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            globals.msg = textBox1.Text;
            globals.title = textBox2.Text;
            if (globals.isnormalok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK);
            }
            if (globals.isnormaloc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel);
            }
            if (globals.isnormalari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore);
            }
            if (globals.isnormalync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel);
            }
            if (globals.isnormalrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel);
            }
            if (globals.isnormalyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo);
            }
            if (globals.iserrorok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (globals.iserroroc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (globals.iserrorari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            if (globals.iserrorync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
            if (globals.iserroryn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            if (globals.iserrorrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (globals.isinfook == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (globals.isinfooc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            if (globals.isinfoari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }
            if (globals.isinfoync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            if (globals.isinfoyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if (globals.isinforc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            if (globals.isquestionok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (globals.isquestionoc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            if (globals.isquestionari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            }
            if (globals.isquestionync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            if (globals.isquestionyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (globals.isquestionrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
            if (globals.iswarnok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (globals.iswarnoc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (globals.iswarnari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            if (globals.iswarnync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            if (globals.iswarnyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (globals.iswarnrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            if (globals.isicon == true)
            {
                StreamWriter File = new StreamWriter(globals.folder + "/message.vbs");
                File.Write("x = msgbox(" + "\"" + globals.msg + "\"" + ",4096," + "\"" + globals.title + "\"" + ")");
                File.Close();
                Process.Start(globals.vbsfile);
            }
            if (globals.isinputbox == true)
            {
                StreamWriter File = new StreamWriter(globals.folder + "/inputbox.vbs");
                File.Write("x = InputBox(" + "\"" + globals.msg + "\"" + "," + "\"" + globals.title + "\"" + ")");
                File.Close();
                Process.Start(globals.inputfile);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void submain_closing(object sender, FormClosingEventArgs e)
        {
        }

        private void submain_Load(object sender, EventArgs e)
        {

        }

        private void submain_closed(object sender, FormClosedEventArgs e)
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
                        File.Write("submain");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            globals.isnormal = false;
            globals.iserror = false;
            globals.isquestion = false;
            globals.isinfo = false;
            globals.iswarn = false;
            globals.isicon = false;
            globals.isinputbox = false;
            globals.isnormalok = false;
            globals.isnormaloc = false;
            globals.isnormalari = false;
            globals.isnormalync = false;
            globals.isnormalyn = false;
            globals.isnormalrc = false;
            globals.iserrorok = false;
            globals.iserroroc = false;
            globals.iserrorari = false;
            globals.iserrorync = false;
            globals.iserroryn = false;
            globals.iserrorrc = false;
            globals.isinfook = false;
            globals.isinfooc = false;
            globals.isinfoari = false;
            globals.isinfoync = false;
            globals.isinfoyn = false;
            globals.isinforc = false;
            globals.isquestionok = false;
            globals.isquestionoc = false;
            globals.isquestionari = false;
            globals.isquestionync = false;
            globals.isquestionyn = false;
            globals.isquestionrc = false;
            globals.iswarnok = false;
            globals.iswarnoc = false;
            globals.iswarnari = false;
            globals.iswarnync = false;
            globals.iswarnyn = false;
            globals.iswarnrc = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            globals.msg = textBox1.Text;
            globals.title = textBox2.Text;
                if (voice == null)
                {
                    voice = new voice();   //Create form if not created
                    voice.FormClosed += voice_closed;  //Add eventhandler to cleanup after form closes
                }

                voice.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
        }
        void voice_closed(object sender, FormClosedEventArgs e)
        {
            voice = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void submain_Move(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void messageMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
