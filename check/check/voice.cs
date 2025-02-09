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
using System.Speech;
using System.Speech.Synthesis;

namespace check
{
    public partial class voice : Form
    {
        submain submain;
        bat bat;
        Random random = new Random();
        public voice()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string check = listBox1.SelectedItem.ToString();
                button4.Text = check;
                if (button4.Text == "0")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 0;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 0;
                        speakers.SpeakAsync(globals.title);
                        speakers.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-1")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -1;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -1;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-2")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -2;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -2;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-3")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -3;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -3;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-4")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -4;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -4;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-5")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -5;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -5;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-6")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -6;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -6;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-7")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -7;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -7;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-8")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -8;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -8;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-9")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -9;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -9;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "-10")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -10;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -10;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "1")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 1;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 1;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "2")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 2;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 2;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "3")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 3;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 3;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "4")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 4;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 4;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "5")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 5;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 5;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "6")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 6;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 6;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "7")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 7;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 7;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "8")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 8;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 8;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "9")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 9;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 9;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button4.Text == "10")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 10;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 10;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
            }
            catch(Exception)
            {
                if (button9.Text == "0")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 0;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 0;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "1")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -1;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -1;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "2")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -2;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -2;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "3")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -3;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -3;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "4")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -4;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -4;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "5")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -5;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -5;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "6")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -6;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -6;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "7")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -7;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -7;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "8")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -8;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -8;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "9")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -9;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -9;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "10")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = -10;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = -10;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "11")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 1;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 1;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "12")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 2;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 2;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "13")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 3;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 3;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "14")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 4;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 4;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "15")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 5;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 5;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "16")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 6;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 6;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "17")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 7;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 7;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "18")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 8;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 8;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "19")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 9;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 9;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
                if (button9.Text == "20")
                {
                    if (globals.isbat == true)
                    {
                        Process.Start(globals.batfile);
                        SpeechSynthesizer speakers = new SpeechSynthesizer();
                        speakers.SelectVoiceByHints(VoiceGender.Male);
                        speakers.Rate = 10;
                        speakers.SpeakAsync(globals.batmsg);
                    }
                    else
                    {
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 10;
                        speaker.SelectVoiceByHints(VoiceGender.Male);
                        speaker.SpeakAsync(globals.title);
                        speaker.SpeakAsync(globals.msg);
                    }
                }
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (submain == null)
            {
                submain = new submain();   //Create form if not created
                submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
            }

            submain.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
            if (globals.isbat == true)
            {
                submain.Hide();
                if (bat == null)
                {
                    bat = new bat();   //Create form if not created
                    bat.FormClosed += bat_closed;  //Add eventhandler to cleanup after form closes
                }

                bat.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
                globals.batmsg = "";
            }
            else
            {
                globals.isbat = false;
            }
        }

        private void bat_closed(object sender, FormClosedEventArgs e)
        {
            bat = null;
            Application.Exit();
        }

        void submain_closed(object sender, FormClosedEventArgs e)
        {
            submain = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            for (int a = 0; a < 20; a++)
            {
                button9.Text = random.Next(0, 21).ToString();
            }
        }

        private void voice_FormClosed(object sender, FormClosedEventArgs e)
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
                        File.Write("voice");
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
