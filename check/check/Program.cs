using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace check
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Directory.Exists(globals.folder))
            {
                if (File.Exists(globals.folder + "/Settings.msgmaker"))
                {
                    StreamReader check = new StreamReader(globals.folder + "/Settings.msgmaker");
                    for (int i = 0; i < 1; i++)
                    {
                        string result = check.ReadLine();
                        if (result == "Autosave = True")
                        {
                            globals.autosave = true;
                            for (int a = 1; a < 2; a++)
                            {
                                string second = check.ReadLine();
                                if (second == "Settings")
                                {
                                    check.Close();
                                    Application.Run(new Settings());
                                }
                                else
                                if (second == "Main")
                                {
                                    check.Close();
                                    Application.Run(new main());
                                }
                                else
                                if (second == null)
                                {
                                    check.Close();
                                    Application.Run(new Form1());
                                }
                                else
                                if (second == "Form1")
                                {
                                    check.Close();
                                    Application.Run(new Form1());
                                }
                                else
                                if (second == "voice")
                                {
                                    check.Close();
                                    Application.Run(new voice());
                                }
                                else
                                if (second == "bat")
                                {
                                    check.Close();
                                    Application.Run(new bat());
                                }
                                else
                                if (second == "menu")
                                {
                                    check.Close();
                                    Application.Run(new normal());
                                }
                                else
                                if (second == "submain")
                                {
                                    check.Close();
                                    Application.Run(new submain());
                                }
                                else
                                if (second == "dialog")
                                {
                                    check.Close();
                                    Application.Run(new dialog());
                                }
                                else
                                if (second == "client")
                                {
                                    check.Close();
                                    Application.Run(new Client());
                                }
                                else
                                if (second == "chat")
                                {
                                    check.Close();
                                    Application.Run(new chat());
                                }
                            }
                        }
                        else
                        {
                            globals.autosave = false;
                            check.Dispose();
                            check.Close();
                            Application.Run(new Form1());
                        }
                    }
                }
                else
                {
                    globals.autosave = false;
                    StreamWriter File = new StreamWriter(globals.folder + "/Settings.msgmaker");
                    File.Close();
                    Application.Run(new Form1());
                }
            }
            else
            {
                Directory.CreateDirectory(globals.folder);
                globals.autosave = false;
                StreamWriter File = new StreamWriter(globals.folder + "/Settings.msgmaker");
                File.Close();
                Application.Run(new Form1());
            }
            if (File.Exists(globals.batfile))
            {
                File.Delete(globals.batfile);
            }
            if (File.Exists(globals.vbsfile))
            {
                File.Delete(globals.vbsfile);
            }
            if (File.Exists(globals.voicefile))
            {
                File.Delete(globals.voicefile);
            }
            if (File.Exists(globals.inputfile))
            {
                File.Delete(globals.inputfile);
            }
            if (File.Exists(globals.image))
            {
                File.Delete(globals.image);
            }
            if (File.Exists(globals.images))
            {
                File.Delete(globals.images);
            }
            if (File.Exists(globals.jpg))
            {
                File.Delete(globals.jpg);
            }
            if (File.Exists(globals.jpeg))
            {
                File.Delete(globals.jpeg);
            }
            if (File.Exists(globals.bmp))
            {
                File.Delete(globals.bmp);
            }
        }
    }
}
