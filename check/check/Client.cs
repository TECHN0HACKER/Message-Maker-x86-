//using check.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace check
{
    public partial class Client : Form
    {
        main main;
        voice voice;
        TcpClient client = new TcpClient();
        //        TcpClient client;
        //        NetworkStream stream;
        //        NetworkStream title;
        //        BinaryFormatter binaryFormatter = new BinaryFormatter();
        //        ChatMessage chat = new ChatMessage();
        //        Title vartitle = new Title();
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(ClientThreadProc);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void ClientThreadProc()
        {
            try
            {
                int port = int.Parse(textBox3.Text);
                client.Connect(textBox6.Text, port);
                NetworkStream clientStream = client.GetStream();

                while (true)
                {
                    byte[] message = new byte[1024];
                    int bytesRead = clientStream.Read(message, 0, 1024);
                    if (bytesRead == 0)
                    {
                        // Server disconnected
                        break;
                    }

                    string serverMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                    string secret = "98482#!";
                    string[] msgparts = serverMessage.Split(new string[] { secret }, StringSplitOptions.None);
                    string title = msgparts[0];
                    string realmessage = msgparts[1];
                    MessageBox.Show(realmessage, title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            try
            {
                string realmsg;
                string message = textBox1.Text;
                string title = textBox2.Text;
                string username = txtUsername.Text;
                if (username.Length > 0)
                {
                    realmsg = username + ": " + message;
                }
                else
                {
                    realmsg = message;
                }
                string fullmsg = title + "98482#!" + realmsg;
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(fullmsg);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            textBox2.Clear();
            textBox2.Focus();
            textBox1.Clear();
            textBox1.Focus();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void client_closed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (globals.autosave == true)
                {
                    try
                    {
                        System.IO.File.Delete(globals.folder + "/Settings.msgmaker");
                        StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", true);
                        for (int i = 1; i < 2; i++)
                        {
                            File.Write("Autosave = True\r\n");
                            File.Write("client");
                        }
                        File.Close();
                        //stream.Close();
                        //title.Close();
                        client.Close();
                        Application.Exit();
                    }
                    catch (Exception)
                    {
                        System.IO.File.Delete(globals.folder + "/Settings.msgmaker");
                        StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", true);
                        for (int i = 1; i < 2; i++)
                        {
                            File.Write("Autosave = True\r\n");
                            File.Write("client");
                        }
                        File.Close();
                        Application.Exit();
                    }
                }
                else
                {
                    try
                    {
                        //stream.Close();
                        //title.Close();
                        client.Close();
                        Application.Exit();
                    }
                    catch (Exception)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                try
                {
                    //stream.Close();
                    //title.Close();
                    client.Close();
                    Application.Exit();
                }
                catch (Exception)
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //stream.Close();
                //title.Close();
                client.Close();
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
            catch (Exception)
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
                voice.FormClosed += voice_closed;  //Add eventhandler to cleansup after form closes
            }

            voice.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }
        void voice_closed(object sender, FormClosedEventArgs e)
        {
            voice = null;  //If form is closed make sure reference is set to null
            Application.Exit();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void client_closing(object sender, FormClosingEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void client_Move(object sender, EventArgs e)
        {

        }
    }
}