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
    public partial class main : Form
    {
        normal normal;
        bat bat;
        submain submain;
        dialog dialog;
        Form1 Form1;
        public main()
        {
            InitializeComponent();
        }

        private void main_closing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globals.isnormal = true;
            if (normal == null)
            {
                normal = new normal();   //Create form if not created
                normal.FormClosed += normal_closed;  //Add eventhandler to cleanup after form closes
            }

            normal.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        void normal_closed(object sender, FormClosedEventArgs e)
        {
            normal = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        void dialog_closed(object sender, FormClosedEventArgs e)
        {
            dialog = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        void bat_closed(object sender, FormClosedEventArgs e)
        {
            bat = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        void submain_closed(object sender, FormClosedEventArgs e)
        {
            submain = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globals.iserror = true;
            if (normal == null)
            {
                normal = new normal();   //Create form if not created
                normal.FormClosed += normal_closed;  //Add eventhandler to cleanup after form closes
            }

            normal.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            globals.isinfo = true;
            if (normal == null)
            {
                normal = new normal();   //Create form if not created
                normal.FormClosed += normal_closed;  //Add eventhandler to cleanup after form closes
            }

            normal.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globals.isquestion = true;
            if (normal == null)
            {
                normal = new normal();   //Create form if not created
                normal.FormClosed += normal_closed;  //Add eventhandler to cleanup after form closes
            }

            normal.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            globals.iswarn = true;
            if (normal == null)
            {
                normal = new normal();   //Create form if not created
                normal.FormClosed += normal_closed;  //Add eventhandler to cleanup after form closes
            }

            normal.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            globals.isbat = true;
            if (bat == null)
            {
                bat = new bat();   //Create form if not created
                bat.FormClosed += bat_closed;  //Add eventhandler to cleanup after form closes
            }

            bat.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            globals.isicon = true;
            if (submain == null)
            {
                submain = new submain();   //Create form if not created
                submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
            }

            submain.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            globals.isinputbox = true;
            if (submain == null)
            {
                submain = new submain();   //Create form if not created
                submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
            }

            submain.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void main_closed(object sender, FormClosedEventArgs e)
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
                        File.Write("Main");
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

        private void button8_Click(object sender, EventArgs e)
        {
            if (dialog == null)
            {
                dialog = new dialog();   //Create form if not created
                dialog.FormClosed += dialog_closed;  //Add eventhandler to cleanup after form closes
            }

            dialog.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Form1 == null)
            {
                Form1 = new Form1();   //Create form if not created
                Form1.FormClosed += Form1_closed;  //Add eventhandler to cleanup after form closes
            }

            Form1.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void Form1_closed(object sender, FormClosedEventArgs e)
        {
            Form1 = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            select.Show();
            this.Hide();
        }
    }
}

public static class globals
{
    public static bool isnormal = false;
    public static bool iserror = false;
    public static bool isquestion = false;
    public static bool isinfo = false;
    public static bool iswarn = false;
    public static bool isicon = false;
    public static bool isbat = false;
    public static bool isinputbox = false;
    public static bool isnormalok = false;
    public static bool isnormaloc = false;
    public static bool isnormalari = false;
    public static bool isnormalync = false;
    public static bool isnormalyn = false;
    public static bool isnormalrc = false;
    public static bool iserrorok = false;
    public static bool iserroroc = false;
    public static bool iserrorari = false;
    public static bool iserrorync = false;
    public static bool iserroryn = false;
    public static bool iserrorrc = false;
    public static bool isinfook = false;
    public static bool isinfooc = false;
    public static bool isinfoari = false;
    public static bool isinfoync = false;
    public static bool isinfoyn = false;
    public static bool isinforc = false;
    public static bool isquestionok = false;
    public static bool isquestionoc = false;
    public static bool isquestionari = false;
    public static bool isquestionync = false;
    public static bool isquestionyn = false;
    public static bool isquestionrc = false;
    public static bool iswarnok = false;
    public static bool iswarnoc = false;
    public static bool iswarnari = false;
    public static bool iswarnync = false;
    public static bool iswarnyn = false;
    public static bool iswarnrc = false;
    public static bool notifiserror = false;
    public static bool notifiserror1 = false;
    public static bool notifisquestion = false;
    public static bool notifisquestion1 = false;
    public static bool notifisinfo = false;
    public static bool notifisinfo1 = false;
    public static bool notifiswarn = false;
    public static bool notifiswarn1 = false;
    public static bool notifiswin = false;
    public static bool notifisshield = false;
    public static string usersname = Environment.UserName;
    public static string folder = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER";
    public static string batfile = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/message.bat";
    public static string vbsfile = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/message.vbs";
    public static string inputfile = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/inputbox.vbs";
    public static string voicefile = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/voice.vbs";
    public static string images = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/image.png";
    public static string bmp = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/image.bmp";
    public static string jpg = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/image.jpg";
    public static string jpeg = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/image.jpeg";
    public static string image = "C:/Users/" + globals.usersname + "/AppData/Local/MESSAGE MAKER/image.ico";
    public static string msg = "idk";
    public static string title = "idk";
    public static string location = "";
    public static string filetype = "";
    public static string filename = "";
    public static string batmsg = "";
    public static bool ispng = false;
    public static bool isjpg = false;
    public static bool isjpeg = false;
    public static bool isbmp = false;
    public static bool autosave = false;
    public static string ipaddress = "";
}

public static class PngIconConverter
{
    /* input image with width = height is suggested to get the best result */
    /* png support in icon was introduced in Windows Vista */
    public static bool Convert(System.IO.Stream input_stream, System.IO.Stream output_stream, int size, bool keep_aspect_ratio = false)
    {
        System.Drawing.Bitmap input_bit = (System.Drawing.Bitmap)System.Drawing.Bitmap.FromStream(input_stream);
        if (input_bit != null)
        {
            int width, height;
            if (keep_aspect_ratio)
            {
                width = size;
                height = input_bit.Height / input_bit.Width * size;
            }
            else
            {
                width = height = size;
            }
            System.Drawing.Bitmap new_bit = new System.Drawing.Bitmap(input_bit, new System.Drawing.Size(width, height));
            if (new_bit != null)
            {
                // save the resized png into a memory stream for future use
                System.IO.MemoryStream mem_data = new System.IO.MemoryStream();
                new_bit.Save(mem_data, System.Drawing.Imaging.ImageFormat.Png);

                System.IO.BinaryWriter icon_writer = new System.IO.BinaryWriter(output_stream);
                if (output_stream != null && icon_writer != null)
                {
                    // 0-1 reserved, 0
                    icon_writer.Write((byte)0);
                    icon_writer.Write((byte)0);

                    // 2-3 image type, 1 = icon, 2 = cursor
                    icon_writer.Write((short)1);

                    // 4-5 number of images
                    icon_writer.Write((short)1);

                    // image entry 1
                    // 0 image width
                    icon_writer.Write((byte)width);
                    // 1 image height
                    icon_writer.Write((byte)height);

                    // 2 number of colors
                    icon_writer.Write((byte)0);

                    // 3 reserved
                    icon_writer.Write((byte)0);

                    // 4-5 color planes
                    icon_writer.Write((short)0);

                    // 6-7 bits per pixel
                    icon_writer.Write((short)32);

                    // 8-11 size of image data
                    icon_writer.Write((int)mem_data.Length);

                    // 12-15 offset of image data
                    icon_writer.Write((int)(6 + 16));

                    // write image data
                    // png data must contain the whole png data file
                    icon_writer.Write(mem_data.ToArray());

                    icon_writer.Flush();

                    return true;
                }
            }
            return false;
        }
        return false;
    }

    public static bool Convert(string input_image, string output_icon, int size, bool keep_aspect_ratio = false)
    {
        System.IO.FileStream input_stream = new System.IO.FileStream(input_image, System.IO.FileMode.Open);
        System.IO.FileStream output_stream = new System.IO.FileStream(output_icon, System.IO.FileMode.OpenOrCreate);

        bool result = Convert(input_stream, output_stream, size, keep_aspect_ratio);

        input_stream.Close();
        output_stream.Close();

        return result;
    }
}