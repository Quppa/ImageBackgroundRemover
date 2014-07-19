using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BackgroundRemoverUI
{
    using System.Diagnostics;
    using System.Drawing.Imaging;
    using System.IO;

    using BackgroundRemover;

    public partial class MainWindow : Form
    {
        private string pathblack, pathwhite, pathtransparent;

        private Bitmap bitmapblack, bitmapwhite, bitmaptransparent;

        public MainWindow()
        {
            InitializeComponent();

            this.grpBlack.AllowDrop = true;
            this.grpWhite.AllowDrop = true;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            this.UpdateGroupBoxLayout();
            this.UpdateZoom();
        }

        private void UpdateGroupBoxLayout()
        {
            this.grpBlack.Width = (int)Math.Round((this.Width - 52) / 3.0);
            this.grpWhite.Width = (int)Math.Round((this.Width - 52) / 3.0);
            this.grpTransparent.Width = (int)Math.Round((this.Width - 52) / 3.0);

            this.grpWhite.Left = 12 + this.grpBlack.Width + 6;
            this.grpTransparent.Left = 12 + this.grpBlack.Width + 6 + this.grpWhite.Width + 6;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += (o, args) => { pbarProcess.Value = args.ProgressPercentage; };
            worker.RunWorkerCompleted += (o, args) =>
                {
                    this.pbarProcess.Value = 100;
                    bitmaptransparent = ImageOperations.Result;
                    this.LoadImage(this.picTransparent, bitmaptransparent);
                    this.Enabled = true;
                    this.btnSave.Enabled = true;
                };
            worker.DoWork += ImageOperations.RemoveBackgroundAsync;

            ImageOperations.BlackBitmap = this.bitmapblack;
            ImageOperations.WhiteBitmap = this.bitmapwhite;

            this.Enabled = false;
            worker.RunWorkerAsync();
        }

        private void BlackImageDragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            this.picBlack.BackColor = SystemColors.Control;

            e.Effect = DragDropEffects.Copy;

            string[] paths = (string[])(e.Data.GetData(DataFormats.FileDrop));

            if (paths.Length > 0)
            {
                // Code to read the contents of the text file
                if (File.Exists(paths[0]))
                {
                    try
                    {
                        this.ClearErrorMessage();
                        Bitmap bitmap = new Bitmap(paths[0]);
                        bitmapblack = bitmap;
                        pathblack = paths[0];
                        this.LoadImage(picBlack, bitmap);
                    }
                    catch (Exception)
                    {
                        this.ShowImageLoadErrorMessage();
                    }
                }
            }
        }

        private void BlackImageDragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            this.picBlack.BackColor = SystemColors.Highlight;

            e.Effect = DragDropEffects.Copy;
        }

        private void BlackImageDragLeave(object sender, EventArgs e)
        {
            this.picBlack.BackColor = SystemColors.Control;
        }

        private void WhiteImageDragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            this.picWhite.BackColor = SystemColors.Control;

            e.Effect = DragDropEffects.Copy;

            string[] paths = (string[])(e.Data.GetData(DataFormats.FileDrop));

            if (paths.Length > 0)
            {
                // Code to read the contents of the text file
                if (File.Exists(paths[0]))
                {
                    try
                    {
                        this.ClearErrorMessage();
                        Bitmap bitmap = new Bitmap(paths[0]);
                        bitmapwhite = bitmap;
                        pathwhite = paths[0];
                        this.LoadImage(picWhite, bitmap);
                    }
                    catch (Exception)
                    {
                        this.ShowImageLoadErrorMessage();
                    }
                }
            }
        }

        private void WhiteImageDragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            this.picWhite.BackColor = SystemColors.Highlight;

            e.Effect = DragDropEffects.Copy;
        }

        private void WhiteImageDragLeave(object sender, EventArgs e)
        {
            this.picWhite.BackColor = SystemColors.Control;
        }

        private void LoadImage(PictureBox picbox, Bitmap image)
        {
            picbox.SizeMode = image.Width > picbox.Width || image.Height > picbox.Height
                                  ? PictureBoxSizeMode.Zoom
                                  : PictureBoxSizeMode.Normal;

            picbox.Image = image;

            this.ValidateInput();
        }

        private void UpdateZoom()
        {
            if (this.picBlack.Image != null)
                this.picBlack.SizeMode = this.picBlack.Image.Width > this.picBlack.Width || this.picBlack.Image.Height > this.picBlack.Height
                                      ? PictureBoxSizeMode.Zoom
                                      : PictureBoxSizeMode.Normal;

            if (this.picWhite.Image != null)
                this.picWhite.SizeMode = this.picWhite.Image.Width > this.picWhite.Width || this.picWhite.Image.Height > this.picWhite.Height
                                      ? PictureBoxSizeMode.Zoom
                                      : PictureBoxSizeMode.Normal;

            if (this.picTransparent.Image != null)
                this.picTransparent.SizeMode = this.picTransparent.Image.Width > this.picTransparent.Width || this.picTransparent.Image.Height > this.picTransparent.Height
                                      ? PictureBoxSizeMode.Zoom
                                      : PictureBoxSizeMode.Normal;
        }

        private void ValidateInput()
        {
            bool imagesExist = this.picBlack.Image != null && this.picWhite.Image != null;

            bool validSizes = imagesExist
                              && this.picBlack.Image.Width == this.picWhite.Image.Width
                              && this.picBlack.Image.Height == this.picWhite.Image.Height;

            if (!imagesExist) this.ClearErrorMessage();
            else if (!validSizes) this.ShowImageSizeErrorMessage();
            else this.ClearErrorMessage();

            this.btnProcess.Enabled = validSizes;
        }

        private void ClearErrorMessage()
        {
            txtStatus.Text = string.Empty;
        }

        private void ShowImageSizeErrorMessage()
        {
            txtStatus.Text = "Image sizes don't match.";
        }

        private void ShowImageLoadErrorMessage()
        {
            txtStatus.Text = "Failed to load file as bitmap.";
        }

        private void StatusBarLinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.quppa.net");
            Process.Start(sInfo);
        }

        private void mnuClearBlackPicBox(object sender, EventArgs e)
        {
            if (this.bitmapblack != null) this.bitmapblack.Dispose();
            this.bitmapblack = null;
            this.picBlack.Image = null;
            this.ValidateInput();
        }

        private void mnuClearWhitePicBox(object sender, EventArgs e)
        {
            if (this.bitmapwhite != null) this.bitmapwhite.Dispose();
            this.bitmapwhite = null;
            this.picWhite.Image = null;
            this.ValidateInput();
        }

        private void SwitchItemsClick(object sender, EventArgs e)
        {
            Image imageblack = this.picBlack.Image;
            this.picBlack.Image = this.picWhite.Image;
            this.picWhite.Image = imageblack;

            Bitmap oldblack = this.bitmapblack;
            this.bitmapblack = this.bitmapwhite;
            this.bitmapwhite = oldblack;

            string oldblackpath = this.pathblack;
            this.pathblack = this.pathwhite;
            this.pathwhite = oldblackpath;
        }

        private void mnuClearTransparentPicBox(object sender, EventArgs e)
        {
            if (this.bitmaptransparent != null) this.bitmaptransparent.Dispose();
            this.bitmaptransparent = null;
            this.picTransparent.Image = null;
            this.btnSave.Enabled = false;
        }

        private void btnBrowseBlack_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (!string.IsNullOrWhiteSpace(this.pathblack)) dialog.FileName = this.pathblack;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.Filter = "Image Files (*.png, *.bmp, *.gif, *.tif, *.tiff, *.ico, *.dib, *.jpg, *.jpeg, *.jpe, *.jif)|*.png;*.bmp;*.gif;*.tif;*.tiff;*.ico;*.dib;*.jpg;*.jpeg;*.jpe;*.jif|All Files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.ClearErrorMessage();
                    Bitmap bitmap = new Bitmap(dialog.FileName);
                    bitmapblack = bitmap;
                    pathblack = dialog.FileName;
                    this.LoadImage(picBlack, bitmap);
                }
                catch (Exception)
                {
                    this.ShowImageLoadErrorMessage();
                }
            }
        }

        private void btnBrowseWhite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (!string.IsNullOrWhiteSpace(this.pathblack)) dialog.FileName = this.pathwhite;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.Filter = "Image Files (*.png, *.bmp, *.gif, *.tif, *.tiff, *.ico, *.dib, *.jpg, *.jpeg, *.jpe, *.jif)|*.png;*.bmp;*.gif;*.tif;*.tiff;*.ico;*.dib;*.jpg;*.jpeg;*.jpe;*.jif|All Files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.ClearErrorMessage();
                    Bitmap bitmap = new Bitmap(dialog.FileName);
                    bitmapwhite = bitmap;
                    pathwhite = dialog.FileName;
                    this.LoadImage(picWhite, bitmap);
                }
                catch (Exception)
                {
                    this.ShowImageLoadErrorMessage();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (!string.IsNullOrWhiteSpace(this.pathblack)) dialog.FileName = this.pathtransparent;
            dialog.ValidateNames = true;
            dialog.OverwritePrompt = true;
            dialog.Filter = "PNG (*.png)|*.png";
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                this.pathtransparent = dialog.FileName;
                this.bitmaptransparent.Save(this.pathtransparent, ImageFormat.Png);
            }
        }
    }
}
