using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook_Messenger
{
    public partial class frmMain : Form
    {
        private int rotation = 0;

        public frmMain()
        {
            InitializeComponent();
            browser.Navigate("https://www.facebook.com/messages/");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (var control in GetAllControls(this, new List<Control>()))
            {
                control.Click += splash_Click;
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void splash_Click(object sender, EventArgs e)
        {
            spinner.Enabled = false;
            Controls.Remove(splash);
            //e.CurrentProgress();
            //e.MaximumProgress();
        }

        private void browser_ProgressChanged(object sender, Gecko.GeckoProgressEventArgs e)
        {
            //progressBar.Maximum = (int)e.MaximumProgress;
            //Text = e.CurrentProgress.ToString();
            //if (e.CurrentProgress == e.MaximumProgress)
            //{
            //    progressBar.Value = 0;
            //}
            //e.CurrentProgress();
            //e.MaximumProgress();
        }

        private void browser_Navigated(object sender, Gecko.GeckoNavigatedEventArgs e)
        {
            // Show that the application is loading...
            // e.g. Invoke the progress bar

            //Text = e.Uri.ToString();
        }

        private void browser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (Controls.Contains(splash))
            {
                spinner.Enabled = false;
                Controls.Remove(splash);
            }
        }

        private void browser_DOMContentLoaded(object sender, Gecko.DomEventArgs e)
        {
            // Inject our custom CSS and Javascript to make the app look pretty.
            if (browser.Tag == null)
            {
                browser.Tag = "Modified";
                browser.Document.Head.InnerHtml += String.Format("<style>{0}</style>", Properties.Resources.CSS);
                browser.Document.Head.InnerHtml += String.Format("<script>{0}</script>", Properties.Resources.Script);
            }
        }

        #region - Helper Methods (1) -
        /// <summary>
        /// Extract the largest image from an ICO file
        /// </summary>
        /// <param name="icoIcon">the icon to be used</param>
        /// <returns>the extracted image</returns>
        static Bitmap ExtractFromIcon(Icon icoIcon)
        {
            Bitmap bmpPngExtracted = null;
            try
            {
                byte[] srcBuf = null;
                using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
                { icoIcon.Save(stream); srcBuf = stream.ToArray(); }
                const int SizeICONDIR = 6;
                const int SizeICONDIRENTRY = 16;
                int iCount = BitConverter.ToInt16(srcBuf, 4);
                for (int iIndex = 0; iIndex < iCount; iIndex++)
                {
                    int iWidth = srcBuf[SizeICONDIR + SizeICONDIRENTRY * iIndex];
                    int iHeight = srcBuf[SizeICONDIR + SizeICONDIRENTRY * iIndex + 1];
                    int iBitCount = BitConverter.ToInt16(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 6);
                    if (iWidth == 0 && iHeight == 0 && iBitCount == 32)
                    {
                        int iImageSize = BitConverter.ToInt32(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 8);
                        int iImageOffset = BitConverter.ToInt32(srcBuf, SizeICONDIR + SizeICONDIRENTRY * iIndex + 12);
                        System.IO.MemoryStream destStream = new System.IO.MemoryStream();
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(destStream);
                        writer.Write(srcBuf, iImageOffset, iImageSize);
                        destStream.Seek(0, System.IO.SeekOrigin.Begin);
                        bmpPngExtracted = new Bitmap(destStream); // This is PNG! :)
                        break;
                    }
                }
            }
            catch { return null; }
            return bmpPngExtracted;
        }

        /// <summary>
        /// Rotate an image either clockwise or counter-clockwise
        /// </summary>
        /// <param name="img">the image to be rotated</param>
        /// <param name="rotationAngle">the angle (in degrees).
        /// NOTE: 
        /// Positive values will rotate clockwise
        /// negative values will rotate counter-clockwise
        /// </param>
        /// <returns>the rotated image</returns>
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            //gfx.InterpolationMode = InterpolationMode.HighdQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        /// <summary>
        /// Gets a list of all controls of the provided parent
        /// </summary>
        /// <param name="container">the parent control</param>
        /// <param name="list">the (new) list of controls</param>
        /// <returns>a list of controls</returns>
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                //add the parent to the list
                list.Add(c);

                //call the function again if it contains controls
                if (c.HasChildren)
                    list = GetAllControls(c, list);
            }

            return list;
        }
        #endregion

        private void spinner_Tick(object sender, EventArgs e)
        {
            if (rotation < 360)
            {
                rotation += 10;
            }
            else
            {
                rotation = 0;
            }
            logo_spin.BackgroundImage = RotateImage(Properties.Resources.Inner, rotation);
        }
    }

}
