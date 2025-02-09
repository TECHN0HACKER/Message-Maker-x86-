using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace check
{
    public partial class normal : Form
    {
        submain submain;
        main main;
        public normal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormalok = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserrorok = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinfook = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionok = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnok = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        private void main_closed(object sender, FormClosedEventArgs e)
        {
            main = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormaloc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserroroc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinfooc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionoc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnoc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormalari = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserrorari = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinfoari = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionari = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnari = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormalync = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserrorync = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinfoync = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionync = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnync = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormalyn = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserroryn = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinfoyn = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionyn = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnyn = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (globals.isnormal == true)
            {
                globals.isnormalrc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iserror == true)
            {
                globals.iserrorrc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isinfo == true)
            {
                globals.isinforc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.isquestion == true)
            {
                globals.isquestionrc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            if (globals.iswarn == true)
            {
                globals.iswarnrc = true;
                if (submain == null)
                {
                    submain = new submain();   //Create form if not created
                    submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
                }

                submain.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else if (globals.isnormal == false && globals.iswarn == false && globals.iserror == false && globals.isinfo == false && globals.isquestion == false)
            {
                if (main == null)
                {
                    main = new main();   //Create form if not created
                    main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
                }

                main.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
        }

        void submain_closed(object sender, FormClosedEventArgs e)
        {
            submain = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void normal_closing(object sender, FormClosingEventArgs e)
        {
        }

        private void normal_FormClosed(object sender, FormClosedEventArgs e)
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
                        File.Write("menu");
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