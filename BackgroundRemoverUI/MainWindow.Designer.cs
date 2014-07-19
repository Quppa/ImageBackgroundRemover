namespace BackgroundRemoverUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.grpBlack = new System.Windows.Forms.GroupBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.menuBlackPicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrowseBlack = new System.Windows.Forms.Button();
            this.grpWhite = new System.Windows.Forms.GroupBox();
            this.picWhite = new System.Windows.Forms.PictureBox();
            this.menuWhitePicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrowseWhite = new System.Windows.Forms.Button();
            this.grpTransparent = new System.Windows.Forms.GroupBox();
            this.picTransparent = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pbarProcess = new System.Windows.Forms.ProgressBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.switchImagesToolStripMenuItemBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.switchImagesToolStripMenuItemWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransparentPicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBlack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            this.menuBlackPicBox.SuspendLayout();
            this.grpWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).BeginInit();
            this.menuWhitePicBox.SuspendLayout();
            this.grpTransparent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTransparent)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuTransparentPicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBlack
            // 
            this.grpBlack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBlack.Controls.Add(this.picBlack);
            this.grpBlack.Controls.Add(this.btnBrowseBlack);
            this.grpBlack.Location = new System.Drawing.Point(12, 12);
            this.grpBlack.Name = "grpBlack";
            this.grpBlack.Size = new System.Drawing.Size(201, 236);
            this.grpBlack.TabIndex = 0;
            this.grpBlack.TabStop = false;
            this.grpBlack.Text = "Black Background";
            this.grpBlack.DragDrop += new System.Windows.Forms.DragEventHandler(this.BlackImageDragDrop);
            this.grpBlack.DragEnter += new System.Windows.Forms.DragEventHandler(this.BlackImageDragEnter);
            this.grpBlack.DragLeave += new System.EventHandler(this.BlackImageDragLeave);
            // 
            // picBlack
            // 
            this.picBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBlack.ContextMenuStrip = this.menuBlackPicBox;
            this.picBlack.Location = new System.Drawing.Point(7, 20);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(188, 183);
            this.picBlack.TabIndex = 2;
            this.picBlack.TabStop = false;
            // 
            // menuBlackPicBox
            // 
            this.menuBlackPicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.switchImagesToolStripMenuItemBlack});
            this.menuBlackPicBox.Name = "menuBlackPicBox";
            this.menuBlackPicBox.Size = new System.Drawing.Size(151, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.mnuClearBlackPicBox);
            // 
            // btnBrowseBlack
            // 
            this.btnBrowseBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseBlack.Location = new System.Drawing.Point(120, 207);
            this.btnBrowseBlack.Name = "btnBrowseBlack";
            this.btnBrowseBlack.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseBlack.TabIndex = 0;
            this.btnBrowseBlack.Text = "Browse";
            this.btnBrowseBlack.UseVisualStyleBackColor = true;
            this.btnBrowseBlack.Click += new System.EventHandler(this.btnBrowseBlack_Click);
            // 
            // grpWhite
            // 
            this.grpWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpWhite.Controls.Add(this.picWhite);
            this.grpWhite.Controls.Add(this.btnBrowseWhite);
            this.grpWhite.Location = new System.Drawing.Point(219, 12);
            this.grpWhite.Name = "grpWhite";
            this.grpWhite.Size = new System.Drawing.Size(201, 236);
            this.grpWhite.TabIndex = 1;
            this.grpWhite.TabStop = false;
            this.grpWhite.Text = "White Background";
            this.grpWhite.DragDrop += new System.Windows.Forms.DragEventHandler(this.WhiteImageDragDrop);
            this.grpWhite.DragEnter += new System.Windows.Forms.DragEventHandler(this.WhiteImageDragEnter);
            this.grpWhite.DragLeave += new System.EventHandler(this.WhiteImageDragLeave);
            // 
            // picWhite
            // 
            this.picWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWhite.ContextMenuStrip = this.menuWhitePicBox;
            this.picWhite.Location = new System.Drawing.Point(7, 20);
            this.picWhite.Name = "picWhite";
            this.picWhite.Size = new System.Drawing.Size(188, 183);
            this.picWhite.TabIndex = 2;
            this.picWhite.TabStop = false;
            // 
            // menuWhitePicBox
            // 
            this.menuWhitePicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.switchImagesToolStripMenuItemWhite});
            this.menuWhitePicBox.Name = "menuWhitePicBox";
            this.menuWhitePicBox.Size = new System.Drawing.Size(151, 48);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.mnuClearWhitePicBox);
            // 
            // btnBrowseWhite
            // 
            this.btnBrowseWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseWhite.Location = new System.Drawing.Point(120, 207);
            this.btnBrowseWhite.Name = "btnBrowseWhite";
            this.btnBrowseWhite.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWhite.TabIndex = 0;
            this.btnBrowseWhite.Text = "Browse";
            this.btnBrowseWhite.UseVisualStyleBackColor = true;
            this.btnBrowseWhite.Click += new System.EventHandler(this.btnBrowseWhite_Click);
            // 
            // grpTransparent
            // 
            this.grpTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTransparent.Controls.Add(this.picTransparent);
            this.grpTransparent.Controls.Add(this.btnSave);
            this.grpTransparent.Location = new System.Drawing.Point(426, 12);
            this.grpTransparent.Name = "grpTransparent";
            this.grpTransparent.Size = new System.Drawing.Size(201, 236);
            this.grpTransparent.TabIndex = 2;
            this.grpTransparent.TabStop = false;
            this.grpTransparent.Text = "Transparent Background";
            // 
            // picTransparent
            // 
            this.picTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTransparent.ContextMenuStrip = this.menuTransparentPicBox;
            this.picTransparent.Location = new System.Drawing.Point(7, 20);
            this.picTransparent.Name = "picTransparent";
            this.picTransparent.Size = new System.Drawing.Size(188, 183);
            this.picTransparent.TabIndex = 2;
            this.picTransparent.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(120, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.AllowDrop = true;
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(12, 254);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pbarProcess
            // 
            this.pbarProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarProcess.Location = new System.Drawing.Point(93, 254);
            this.pbarProcess.Name = "pbarProcess";
            this.pbarProcess.Size = new System.Drawing.Size(534, 23);
            this.pbarProcess.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 282);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(639, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.ForeColor = System.Drawing.Color.Red;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(561, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel2.Text = "Quppa.net";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.ToolTipText = "Visit Quppa.net";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.StatusBarLinkClicked);
            // 
            // switchImagesToolStripMenuItemBlack
            // 
            this.switchImagesToolStripMenuItemBlack.Name = "switchImagesToolStripMenuItemBlack";
            this.switchImagesToolStripMenuItemBlack.Size = new System.Drawing.Size(150, 22);
            this.switchImagesToolStripMenuItemBlack.Text = "Switch images";
            this.switchImagesToolStripMenuItemBlack.Click += new System.EventHandler(this.SwitchItemsClick);
            // 
            // switchImagesToolStripMenuItemWhite
            // 
            this.switchImagesToolStripMenuItemWhite.Name = "switchImagesToolStripMenuItemWhite";
            this.switchImagesToolStripMenuItemWhite.Size = new System.Drawing.Size(150, 22);
            this.switchImagesToolStripMenuItemWhite.Text = "Switch images";
            this.switchImagesToolStripMenuItemWhite.Click += new System.EventHandler(this.SwitchItemsClick);
            // 
            // menuTransparentPicBox
            // 
            this.menuTransparentPicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem2});
            this.menuTransparentPicBox.Name = "menuTransparentPicBox";
            this.menuTransparentPicBox.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem2
            // 
            this.clearToolStripMenuItem2.Name = "clearToolStripMenuItem2";
            this.clearToolStripMenuItem2.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem2.Text = "Clear";
            this.clearToolStripMenuItem2.Click += new System.EventHandler(this.mnuClearTransparentPicBox);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(639, 304);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pbarProcess);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpTransparent);
            this.Controls.Add(this.grpWhite);
            this.Controls.Add(this.grpBlack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Background Remover";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.grpBlack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            this.menuBlackPicBox.ResumeLayout(false);
            this.grpWhite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).EndInit();
            this.menuWhitePicBox.ResumeLayout(false);
            this.grpTransparent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTransparent)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuTransparentPicBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBlack;
        private System.Windows.Forms.GroupBox grpWhite;
        private System.Windows.Forms.GroupBox grpTransparent;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ProgressBar pbarProcess;
        private System.Windows.Forms.Button btnBrowseBlack;
        private System.Windows.Forms.Button btnBrowseWhite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.PictureBox picWhite;
        private System.Windows.Forms.PictureBox picTransparent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip menuWhitePicBox;
        private System.Windows.Forms.ContextMenuStrip menuBlackPicBox;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchImagesToolStripMenuItemBlack;
        private System.Windows.Forms.ToolStripMenuItem switchImagesToolStripMenuItemWhite;
        private System.Windows.Forms.ContextMenuStrip menuTransparentPicBox;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem2;
    }
}

