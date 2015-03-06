using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Gecko;
using System.Drawing;

namespace Facebook_Messenger
{
    static class Program
    {

        //private static GeckoWebBrowser browser;
        //private static Form form = new Form();
        //private static Panel splash;
        //private static ProgressBar progressBar;

        [STAThread]
        static void Main()
        {
            Xpcom.Initialize(Path.Combine(Environment.CurrentDirectory, "xulrunner"));

            //browser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            //splash = new Panel { Dock = DockStyle.Fill };

            //#region - Event Pointers -
            //browser.DocumentCompleted += browser_DocumentCompleted;
            //browser.Navigated += browser_Navigated;
            //browser.DOMContentLoaded += browser_DOMContentLoaded;
            //browser.ProgressChanged += browser_ProgressChanged;

            //splash.Click += splash_Click;
            //#endregion

            //form.Size = new Size(500, 700);
            //form.Icon = Properties.Resources.Messenger;
            //form.Text = "Facebook Messenger";

            //browser.Navigate("https://www.facebook.com/messages/");

            //#region - Splash Screen -

            //progressBar = new ProgressBar();
            //progressBar.Size = new Size(100, 20);
            //progressBar.Location = new Point(10, 10);

            //PictureBox logo = new PictureBox();
            //logo.Size = new Size(256, 256);
            //logo.SizeMode = PictureBoxSizeMode.StretchImage;
            //logo.Left = (form.ClientSize.Width - logo.Width) / 2;
            //logo.Top = ((form.ClientSize.Height - logo.Height) / 2) - 50;
            //Image img = ExtractFromIcon(Properties.Resources.Messenger);
            //logo.Image = img;

            //PictureBox sidebar = new PictureBox();
            //sidebar.Size = new Size(13, form.ClientSize.Height);
            //sidebar.BackColor = Color.FromArgb(39, 134, 235);

            //PictureBox headerButtons = new PictureBox();
            //headerButtons.Top = 19;
            //headerButtons.Left = form.ClientSize.Width - Properties.Resources.DisabledButtons.Width - 17;
            //headerButtons.Size = Properties.Resources.DisabledButtons.Size;
            //headerButtons.Image = Properties.Resources.DisabledButtons;

            //PictureBox header = new PictureBox();
            //header.Size = new Size(form.ClientSize.Width, 60);
            //header.BackColor = Color.FromArgb(242, 242, 248);

            //PictureBox headerBorder = new PictureBox();
            //headerBorder.Top = header.Height;
            //headerBorder.Size = new Size(form.ClientSize.Width, 1);
            //headerBorder.BackColor = Color.FromArgb(227, 227, 227);

            //PictureBox headerShadow = new PictureBox();
            //headerShadow.Top = header.Height + headerBorder.Height;
            //headerShadow.Size = new Size(form.ClientSize.Width, 2);
            //headerShadow.BackColor = Color.FromArgb(237, 237, 237);

            //PictureBox chatBorder = new PictureBox();
            //chatBorder.Top = form.ClientSize.Height - 153;
            //chatBorder.Size = new Size(form.ClientSize.Width, 1);
            //chatBorder.BackColor = Color.FromArgb(230, 230, 230);

            //splash.BackColor = Color.White;
            //splash.Controls.AddRange(new Control[] { sidebar,
            //                                         progressBar,
            //                                         headerButtons, header, headerBorder, headerShadow,
            //                                         chatBorder });

            //#endregion

            //form.Controls.AddRange(new Control[] { splash,
            //                                       browser });

            //logo.Anchor = (AnchorStyles.Top);
            //sidebar.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            //headerButtons.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            //header.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            //headerBorder.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            //headerShadow.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            //chatBorder.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            Application.EnableVisualStyles();
            Application.Run(new frmMain());
        }

        //static void splash_Click(object sender, EventArgs e)
        //{
        //    form.Controls.Remove(splash);
        //    //e.CurrentProgress();
        //    //e.MaximumProgress();
        //}

        //static void browser_ProgressChanged(object sender, GeckoProgressEventArgs e)
        //{
        //    progressBar.Maximum = (int)e.MaximumProgress;
        //    progressBar.Value = (int)e.CurrentProgress;
        //    if (e.CurrentProgress == e.MaximumProgress) {
        //        progressBar.Value = 0;
        //    }
        //    //e.CurrentProgress();
        //    //e.MaximumProgress();
        //}

        //static void browser_Navigated(object sender, GeckoNavigatedEventArgs e)
        //{
        //    // Show that the application is loading...
        //    // e.g. Invoke the progress bar

        //    //MessageBox.Show(String.Format("Navigated {0}", e.Uri));
        //    //form.Text = e.Uri.ToString();
        //}

        //static void browser_DocumentCompleted(object sender, EventArgs e)
        //{
        //    if (form.Controls.Contains(splash))
        //    {
        //        form.Controls.Remove(splash);
        //    }
        //    //browser.Document.Head.InnerHtml += String.Format("<style>{0}</style>", Facebook_Messenger.Properties.Resources.CSS);
        //    //MessageBox.Show("");
        //}

        //static void browser_DOMContentLoaded(object sender, EventArgs e)
        //{
        //    // Inject our custom CSS and Javascript to make the app look pretty.
        //    if (browser.Tag == null)
        //    {
        //        browser.Tag = "Modified";
        //        browser.Document.Head.InnerHtml += String.Format("<style>{0}</style>", Properties.Resources.CSS);
        //        browser.Document.Head.InnerHtml += String.Format("<script>{0}</script>", Properties.Resources.Script);
        //    }
        //}

        //#region - Helper Classes (1) -

        //static Bitmap ExtractFromIcon(Icon icoIcon)
        //{
        //    Bitmap bmpPngExtracted = null;
        //    try
        //    {
        //        byte[] srcBuf = null;
        //        using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
        //        { icoIcon.Save(stream); srcBuf = stream.ToArray(); }
        //        const int SizeICONDIR = 6;
        //        const int SizeICONDIRENTRY = 16;
        //        int iCount = BitConverter.ToInt16(srcBuf, 4);
        //        for (int iIndex = 0; iIndex < iCount; iIndex++)
        //        {
        //            int iWidth = srcBuf[SizeICONDIR + SizeICONDIRENTRY * iIndex];
        //            int iHeight = srcBuf[SizeICONDIR + SizeICONDIRENTRY * iIndex + 1];
        //            int iBitCount = BitConverter.ToInt16(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 6);
        //            if (iWidth == 0 && iHeight == 0 && iBitCount == 32)
        //            {
        //                int iImageSize = BitConverter.ToInt32(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 8);
        //                int iImageOffset = BitConverter.ToInt32(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 12);
        //                System.IO.MemoryStream destStream = new System.IO.MemoryStream();
        //                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(destStream);
        //                writer.Write(srcBuf, iImageOffset, iImageSize);
        //                destStream.Seek(0, System.IO.SeekOrigin.Begin);
        //                bmpPngExtracted = new Bitmap(destStream); // This is PNG! :)
        //                break;
        //            }
        //        }
        //    }
        //    catch { return null; }
        //    return bmpPngExtracted;
        //}
        //#endregion
    }

}
