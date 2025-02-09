//using check.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace check
{
    public partial class chat : Form
    {
        main main;
        voice voice;
        TcpListener server;
        TcpClient client;
        private bool isrunning = false;

        public chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (server == null)
            {
                MessageBox.Show("Please start the server first.");
                return;
            }

            // Get the message to be sent from the textBox1 control
            string messageToSend = textBox1.Text;
            string title = textBox2.Text;
            string username = txtUsername.Text;

            // Start a new thread to send the message to the server
            Thread clientThread = new Thread(() => SendMessageToServer(messageToSend, title, username));
            clientThread.IsBackground = true;
            clientThread.Start();

            // Clear the input textBox controls and set focus
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox2.Focus();
        }


        private void SendMessageToServer(string message, string title, string username)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Not connected to the server.");
                    return;
                }

                string realmsg;
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
        }


        public void button4_Click(object sender, EventArgs e)
        {
            if (isrunning)
            {
                server.Stop();
                isrunning = false;
                button4.Text = "Start";
            }
            else
            {
                server = new TcpListener(IPAddress.Parse(textBox3.Text), int.Parse(textBox4.Text));
                server.Start(); // Start listening for incoming connections
                Thread serverThread = new Thread(ServerThreadProc);
                serverThread.IsBackground = true;
                serverThread.Start();
                isrunning = true;
                button4.Text = "Stop";
            }
        }

        private void ServerThreadProc()
        {
            while (isrunning)
            {
                client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                while (client.Connected && isrunning)
                {
                    byte[] data = new byte[1024];
                    int bytesRead = 0;
                    try
                    {
                        bytesRead = stream.Read(data, 0, data.Length);
                    }
                    catch (IOException ex)
                    {
                        // An IOException is thrown when the client disconnects.
                        // Handle the disconnection and exit the loop.
                        MessageBox.Show("Client disconnected.");
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        // Client disconnected gracefully.
                        MessageBox.Show("Client disconnected.");
                        break;
                    }

                    string fullmessage = Encoding.ASCII.GetString(data, 0, bytesRead);
                    string[] msgparts = fullmessage.Split(new string[] { "98482#!" }, StringSplitOptions.None);
                    string title = msgparts[0];
                    string realmessage = msgparts[1];
                    MessageBox.Show(realmessage, title);
                }

                // Close the client connection
                stream.Close();
                client.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void chat_closed(object sender, FormClosedEventArgs e)
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
                            File.Write("chat");
                        }
                        File.Close();
                        //stream.Close();
                        //title.Close();
                        //listener.Stop();
                        //socket.Close();
                        Application.Exit();
                    }
                    catch (Exception)
                    {
                        System.IO.File.Delete(globals.folder + "/Settings.msgmaker");
                        StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", true);
                        for (int i = 1; i < 2; i++)
                        {
                            File.Write("Autosave = True\r\n");
                            File.Write("chat");
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
                        //listener.Stop();
                        //socket.Close();
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
                    //listener.Stop();
                    //socket.Close();
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
                server.Stop();
                isrunning = false;
                button4.Text = "Start";
                //stream.Close();
                //title.Close();
                //listener.Stop();
                //socket.Close();
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

        private void chat_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    globals.ipaddress = ip.ToString();
                }
            }
            textBox3.Text = globals.ipaddress;
        }

        private void chat_closing(object sender, FormClosingEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chat_Move(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}