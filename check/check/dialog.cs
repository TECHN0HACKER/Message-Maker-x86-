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
using System.Threading;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace check
{
    public partial class dialog : Form
    {
        main main;
        public dialog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string combo = comboBox1.SelectedItem.ToString();
            string combo1 = comboBox2.SelectedItem.ToString();
            string title = textBox1.Text;
            string message = textBox2.Text;
            if (combo == "Error")
            {
                globals.notifiswin = false;
                globals.notifisshield = false;
                globals.notifiserror = true;
                globals.notifisinfo = false;
                globals.notifisquestion = false;
                globals.notifiswarn = false;
            }
            if (combo == "Information")
            {
                globals.notifiswin = false;
                globals.notifisshield = false;
                globals.notifiserror = false;
                globals.notifisinfo = true;
                globals.notifisquestion = false;
                globals.notifiswarn = false;
            }
            if (combo == "Question")
            {
                globals.notifiswin = false;
                globals.notifisshield = false;
                globals.notifiserror = false;
                globals.notifisinfo = false;
                globals.notifisquestion = true;
                globals.notifiswarn = false;
            }
            if (combo == "Warning")
            {
                globals.notifiswin = false;
                globals.notifisshield = false;
                globals.notifiserror = false;
                globals.notifisinfo = false;
                globals.notifisquestion = false;
                globals.notifiswarn = true;
            }
            if (combo == "Shield")
            {
                globals.notifiswin = false;
                globals.notifisshield = true;
                globals.notifiserror = false;
                globals.notifisinfo = false;
                globals.notifisquestion = false;
                globals.notifiswarn = false;
            }
            if (combo == "Application")
            {
                globals.notifiswin = true;
                globals.notifisshield = false;
                globals.notifiserror = false;
                globals.notifisinfo = false;
                globals.notifisquestion = false;
                globals.notifiswarn = false;
            }
            if (combo1 == "Error")
            {
                globals.notifiserror1 = true;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "None")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = true;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "Information")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = true;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "Warning")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = true;
            }
            if (globals.notifiserror == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiserror == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisinfo == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisquestion == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Question;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswarn == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisinfo == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisquestion == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Question;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswarn == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiserror == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisinfo == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisquestion == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Question;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswarn == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiserror == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisinfo == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisquestion == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Question;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswarn == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswin == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisshield == true && globals.notifiserror1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Shield;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswin == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisshield == true && globals.notifisquestion1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Shield;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswin == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisshield == true && globals.notifisinfo1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Shield;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifiswin == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (globals.notifisshield == true && globals.notifiswarn1 == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Shield;
                notifyIcon1.Text = title;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main == null)
            {
                main = new main();   //Create form if not created
                main.FormClosed += main_closed;  //Add eventhandler to cleanup after form closes
            }

            main.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void main_closed(object sender, FormClosedEventArgs e)
        {
            main = null;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(788, 552);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string title = textBox1.Text;
                string message = textBox2.Text;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images (*.BMP,*.JPG,*.JPEG,*.ICO,*.PNG)|*.BMP;*.JPG;*.JPEG;*.ICO;*.PNG|" + "All files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    globals.filetype = Path.GetExtension(dialog.FileName);
                    if (globals.filetype == ".png" || globals.filetype == ".PNG")
                    {
                        globals.ispng = true;
                        Image image = Image.FromStream(File.OpenRead(dialog.FileName));
                        var rectangle = new Rectangle(0, 0, 320, 320);
                        var result = new Bitmap(320, 320);

                        result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                        using (var graphix = Graphics.FromImage(result))
                        {
                            graphix.CompositingMode = CompositingMode.SourceCopy;
                            graphix.CompositingQuality = CompositingQuality.HighQuality;
                            graphix.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphix.SmoothingMode = SmoothingMode.HighQuality;
                            graphix.PixelOffsetMode = PixelOffsetMode.HighQuality;

                            using (var wrap = new ImageAttributes())
                            {
                                wrap.SetWrapMode(WrapMode.TileFlipXY);
                                graphix.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap);
                            }
                        }
                        image.Dispose();
                        result.Save(globals.images);
                        PngIconConverter.Convert(globals.images, globals.image, 320);
                    }
                    if (globals.filetype == ".jpg" || globals.filetype == ".JPG")
                    {
                        globals.isjpg = true;
                        Image image = Image.FromStream(File.OpenRead(dialog.FileName));
                        var rectangle = new Rectangle(0, 0, 320, 320);
                        var result = new Bitmap(320, 320);

                        result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                        using (var graphix = Graphics.FromImage(result))
                        {
                            graphix.CompositingMode = CompositingMode.SourceCopy;
                            graphix.CompositingQuality = CompositingQuality.HighQuality;
                            graphix.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphix.SmoothingMode = SmoothingMode.HighQuality;
                            graphix.PixelOffsetMode = PixelOffsetMode.HighQuality;

                            using (var wrap = new ImageAttributes())
                            {
                                wrap.SetWrapMode(WrapMode.TileFlipXY);
                                graphix.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap);
                            }
                        }
                        image.Dispose();
                        result.Save(globals.jpg);
                        PngIconConverter.Convert(globals.jpg, globals.image, 320);
                    }
                    if (globals.filetype == ".jpeg" || globals.filetype == ".JPEG")
                    {
                        globals.isjpeg = true;
                        Image image = Image.FromStream(File.OpenRead(dialog.FileName));
                        var rectangle = new Rectangle(0, 0, 320, 320);
                        var result = new Bitmap(320, 320);

                        result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                        using (var graphix = Graphics.FromImage(result))
                        {
                            graphix.CompositingMode = CompositingMode.SourceCopy;
                            graphix.CompositingQuality = CompositingQuality.HighQuality;
                            graphix.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphix.SmoothingMode = SmoothingMode.HighQuality;
                            graphix.PixelOffsetMode = PixelOffsetMode.HighQuality;

                            using (var wrap = new ImageAttributes())
                            {
                                wrap.SetWrapMode(WrapMode.TileFlipXY);
                                graphix.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap);
                            }
                        }
                        image.Dispose();
                        result.Save(globals.jpeg);
                        PngIconConverter.Convert(globals.jpeg, globals.image, 320);
                    }
                    if (globals.filetype == ".bmp" || globals.filetype == ".BMP")
                    {
                        globals.isbmp = true;
                        Image image = Image.FromStream(File.OpenRead(dialog.FileName));
                        var rectangle = new Rectangle(0, 0, 320, 320);
                        var result = new Bitmap(320, 320);

                        result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                        using (var graphix = Graphics.FromImage(result))
                        {
                            graphix.CompositingMode = CompositingMode.SourceCopy;
                            graphix.CompositingQuality = CompositingQuality.HighQuality;
                            graphix.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphix.SmoothingMode = SmoothingMode.HighQuality;
                            graphix.PixelOffsetMode = PixelOffsetMode.HighQuality;

                            using (var wrap = new ImageAttributes())
                            {
                                wrap.SetWrapMode(WrapMode.TileFlipXY);
                                graphix.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap);
                            }
                        }
                        image.Dispose();
                        result.Save(globals.bmp);
                        PngIconConverter.Convert(globals.bmp, globals.image, 320);
                    }
                    globals.location = dialog.FileName;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string combo1 = comboBox2.SelectedItem.ToString();
            if (combo1 == "Error")
            {
                globals.notifiserror1 = true;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "None")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = true;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "Information")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = true;
                globals.notifiswarn1 = false;
            }
            if (combo1 == "Warning")
            {
                globals.notifiserror1 = false;
                globals.notifisquestion1 = false;
                globals.notifisinfo1 = false;
                globals.notifiswarn1 = true;
            }
            string title = textBox1.Text;
            string message = textBox2.Text;
            try
            {
                if (globals.ispng == true || globals.isjpg == true || globals.isjpeg == true || globals.isbmp == true)
                {
                    if (globals.notifiserror1 == true)
                    {
                        notifyIcon1.Visible = true;
                        notifyIcon1.Icon = new Icon(globals.image);
                        notifyIcon1.Text = title;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        notifyIcon1.BalloonTipText = message;
                        notifyIcon1.BalloonTipTitle = title;
                        notifyIcon1.ShowBalloonTip(1000);
                        //Force garbage collection.
                        GC.Collect();

                        // Wait for all finalizers to complete before continuing.
                        GC.WaitForPendingFinalizers();
                    }
                    if (globals.notifiswarn1 == true)
                    {
                        notifyIcon1.Visible = true;
                        notifyIcon1.Icon = new Icon(globals.image);
                        notifyIcon1.Text = title;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                        notifyIcon1.BalloonTipText = message;
                        notifyIcon1.BalloonTipTitle = title;
                        notifyIcon1.ShowBalloonTip(1000);
                        //Force garbage collection.
                        GC.Collect();

                        // Wait for all finalizers to complete before continuing.
                        GC.WaitForPendingFinalizers();
                    }
                    if (globals.notifisquestion1 == true)
                    {
                        notifyIcon1.Visible = true;
                        notifyIcon1.Icon = new Icon(globals.image);
                        notifyIcon1.Text = title;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                        notifyIcon1.BalloonTipText = message;
                        notifyIcon1.BalloonTipTitle = title;
                        notifyIcon1.ShowBalloonTip(1000);
                        //Force garbage collection.
                        GC.Collect();

                        // Wait for all finalizers to complete before continuing.
                        GC.WaitForPendingFinalizers();
                    }
                    if (globals.notifisinfo1 == true)
                    {
                        notifyIcon1.Visible = true;
                        notifyIcon1.Icon = new Icon(globals.image);
                        notifyIcon1.Text = title;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipText = message;
                        notifyIcon1.BalloonTipTitle = title;
                        notifyIcon1.ShowBalloonTip(1000);
                        //Force garbage collection.
                        GC.Collect();

                        // Wait for all finalizers to complete before continuing.
                        GC.WaitForPendingFinalizers();
                    }
                }
                if (globals.notifiswarn1 == true)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = new Icon(globals.location);
                    notifyIcon1.Text = title;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.BalloonTipText = message;
                    notifyIcon1.BalloonTipTitle = title;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                if (globals.notifiserror1 == true)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = new Icon(globals.location);
                    notifyIcon1.Text = title;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.BalloonTipText = message;
                    notifyIcon1.BalloonTipTitle = title;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                if (globals.notifisquestion1 == true)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = new Icon(globals.location);
                    notifyIcon1.Text = title;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                    notifyIcon1.BalloonTipText = message;
                    notifyIcon1.BalloonTipTitle = title;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                if (globals.notifisinfo1 == true)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = new Icon(globals.location);
                    notifyIcon1.Text = title;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = message;
                    notifyIcon1.BalloonTipTitle = title;
                    notifyIcon1.ShowBalloonTip(1000);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dialog_FormClosed(object sender, FormClosedEventArgs e)
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
                        File.Write("dialog");
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
