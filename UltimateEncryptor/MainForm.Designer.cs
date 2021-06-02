
namespace UltimateEncryptor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.titlebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileselector = new System.Windows.Forms.OpenFileDialog();
            this.encryptpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.encryptwait = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.encryptfilename = new System.Windows.Forms.Label();
            this.encryptfileselector = new System.Windows.Forms.PictureBox();
            this.encryptkey = new Guna.UI2.WinForms.Guna2TextBox();
            this.filetoencryptlabel = new System.Windows.Forms.Label();
            this.encryptionkeylabel = new System.Windows.Forms.Label();
            this.encryptkeyconfirm = new Guna.UI2.WinForms.Guna2Button();
            this.encryptbtn = new Guna.UI2.WinForms.Guna2Button();
            this.decryptbtn = new Guna.UI2.WinForms.Guna2Button();
            this.decryptkeyconfirm = new Guna.UI2.WinForms.Guna2Button();
            this.decryptionkeylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptkey = new Guna.UI2.WinForms.Guna2TextBox();
            this.decryptpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.decryptwait = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.decryptfilename = new System.Windows.Forms.Label();
            this.decryptfileselector = new System.Windows.Forms.PictureBox();
            this.operationprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.folderselector = new System.Windows.Forms.FolderBrowserDialog();
            this.creditslabel = new System.Windows.Forms.Label();
            this.randomizekey = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.titlebar.SuspendLayout();
            this.encryptpanel.SuspendLayout();
            this.encryptwait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptfileselector)).BeginInit();
            this.decryptpanel.SuspendLayout();
            this.decryptwait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptfileselector)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(569, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 43;
            this.close.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(538, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 44;
            this.minimize.TabStop = false;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titlebar.Controls.Add(this.label1);
            this.titlebar.Controls.Add(this.pictureBox1);
            this.titlebar.Controls.Add(this.close);
            this.titlebar.Controls.Add(this.minimize);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(600, 30);
            this.titlebar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "UltimateEncryptor";
            // 
            // fileselector
            // 
            this.fileselector.Title = "UltimateEncryptor";
            // 
            // encryptpanel
            // 
            this.encryptpanel.BackColor = System.Drawing.Color.Transparent;
            this.encryptpanel.BorderColor = System.Drawing.Color.Black;
            this.encryptpanel.BorderRadius = 20;
            this.encryptpanel.Controls.Add(this.encryptwait);
            this.encryptpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.encryptpanel.Location = new System.Drawing.Point(44, 93);
            this.encryptpanel.Name = "encryptpanel";
            this.encryptpanel.ShadowDecoration.Parent = this.encryptpanel;
            this.encryptpanel.Size = new System.Drawing.Size(150, 150);
            this.encryptpanel.TabIndex = 5;
            this.encryptpanel.UseTransparentBackground = true;
            // 
            // encryptwait
            // 
            this.encryptwait.Animated = true;
            this.encryptwait.AnimationSpeed = 1F;
            this.encryptwait.BackColor = System.Drawing.Color.Transparent;
            this.encryptwait.Controls.Add(this.encryptfilename);
            this.encryptwait.Controls.Add(this.encryptfileselector);
            this.encryptwait.FillColor = System.Drawing.Color.Transparent;
            this.encryptwait.Location = new System.Drawing.Point(10, 10);
            this.encryptwait.Name = "encryptwait";
            this.encryptwait.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.encryptwait.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(236)))), ((int)(((byte)(130)))));
            this.encryptwait.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(236)))), ((int)(((byte)(130)))));
            this.encryptwait.ProgressThickness = 10;
            this.encryptwait.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.encryptwait.ShadowDecoration.Parent = this.encryptwait;
            this.encryptwait.Size = new System.Drawing.Size(130, 130);
            this.encryptwait.TabIndex = 12;
            this.encryptwait.UseTransparentBackground = true;
            this.encryptwait.Value = 25;
            // 
            // encryptfilename
            // 
            this.encryptfilename.AutoSize = true;
            this.encryptfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encryptfilename.ForeColor = System.Drawing.Color.White;
            this.encryptfilename.Location = new System.Drawing.Point(-4, 53);
            this.encryptfilename.Name = "encryptfilename";
            this.encryptfilename.Size = new System.Drawing.Size(67, 17);
            this.encryptfilename.TabIndex = 1;
            this.encryptfilename.Text = "FileName";
            this.encryptfilename.Visible = false;
            // 
            // encryptfileselector
            // 
            this.encryptfileselector.Image = ((System.Drawing.Image)(resources.GetObject("encryptfileselector.Image")));
            this.encryptfileselector.Location = new System.Drawing.Point(40, 40);
            this.encryptfileselector.Name = "encryptfileselector";
            this.encryptfileselector.Size = new System.Drawing.Size(50, 50);
            this.encryptfileselector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encryptfileselector.TabIndex = 0;
            this.encryptfileselector.TabStop = false;
            // 
            // encryptkey
            // 
            this.encryptkey.Animated = true;
            this.encryptkey.BackColor = System.Drawing.Color.Transparent;
            this.encryptkey.BorderRadius = 5;
            this.encryptkey.BorderThickness = 0;
            this.encryptkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.encryptkey.DefaultText = "";
            this.encryptkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.encryptkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.encryptkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.encryptkey.DisabledState.Parent = this.encryptkey;
            this.encryptkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.encryptkey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.encryptkey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.encryptkey.FocusedState.Parent = this.encryptkey;
            this.encryptkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.encryptkey.ForeColor = System.Drawing.Color.White;
            this.encryptkey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.encryptkey.HoverState.Parent = this.encryptkey;
            this.encryptkey.Location = new System.Drawing.Point(24, 292);
            this.encryptkey.Name = "encryptkey";
            this.encryptkey.PasswordChar = '\0';
            this.encryptkey.PlaceholderText = "";
            this.encryptkey.SelectedText = "";
            this.encryptkey.ShadowDecoration.Parent = this.encryptkey;
            this.encryptkey.Size = new System.Drawing.Size(180, 25);
            this.encryptkey.TabIndex = 7;
            // 
            // filetoencryptlabel
            // 
            this.filetoencryptlabel.AutoSize = true;
            this.filetoencryptlabel.BackColor = System.Drawing.Color.Transparent;
            this.filetoencryptlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.filetoencryptlabel.ForeColor = System.Drawing.Color.White;
            this.filetoencryptlabel.Location = new System.Drawing.Point(56, 57);
            this.filetoencryptlabel.Name = "filetoencryptlabel";
            this.filetoencryptlabel.Size = new System.Drawing.Size(128, 30);
            this.filetoencryptlabel.TabIndex = 8;
            this.filetoencryptlabel.Text = "Encrypt File";
            // 
            // encryptionkeylabel
            // 
            this.encryptionkeylabel.AutoSize = true;
            this.encryptionkeylabel.BackColor = System.Drawing.Color.Transparent;
            this.encryptionkeylabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.encryptionkeylabel.ForeColor = System.Drawing.Color.White;
            this.encryptionkeylabel.Location = new System.Drawing.Point(57, 264);
            this.encryptionkeylabel.Name = "encryptionkeylabel";
            this.encryptionkeylabel.Size = new System.Drawing.Size(110, 19);
            this.encryptionkeylabel.TabIndex = 9;
            this.encryptionkeylabel.Text = "Encryption Key";
            // 
            // encryptkeyconfirm
            // 
            this.encryptkeyconfirm.Animated = true;
            this.encryptkeyconfirm.BackColor = System.Drawing.Color.Transparent;
            this.encryptkeyconfirm.BorderRadius = 5;
            this.encryptkeyconfirm.CheckedState.Parent = this.encryptkeyconfirm;
            this.encryptkeyconfirm.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("encryptkeyconfirm.CustomImages.Image")));
            this.encryptkeyconfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.encryptkeyconfirm.CustomImages.Parent = this.encryptkeyconfirm;
            this.encryptkeyconfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(236)))), ((int)(((byte)(130)))));
            this.encryptkeyconfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.encryptkeyconfirm.ForeColor = System.Drawing.Color.White;
            this.encryptkeyconfirm.HoverState.Parent = this.encryptkeyconfirm;
            this.encryptkeyconfirm.ImageSize = new System.Drawing.Size(1, 19);
            this.encryptkeyconfirm.Location = new System.Drawing.Point(212, 304);
            this.encryptkeyconfirm.Name = "encryptkeyconfirm";
            this.encryptkeyconfirm.PressedColor = System.Drawing.Color.White;
            this.encryptkeyconfirm.ShadowDecoration.Parent = this.encryptkeyconfirm;
            this.encryptkeyconfirm.Size = new System.Drawing.Size(25, 25);
            this.encryptkeyconfirm.TabIndex = 11;
            this.encryptkeyconfirm.UseTransparentBackground = true;
            // 
            // encryptbtn
            // 
            this.encryptbtn.Animated = true;
            this.encryptbtn.AnimatedGIF = true;
            this.encryptbtn.BackColor = System.Drawing.Color.Transparent;
            this.encryptbtn.BorderRadius = 10;
            this.encryptbtn.CheckedState.Parent = this.encryptbtn;
            this.encryptbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("encryptbtn.CustomImages.Image")));
            this.encryptbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.encryptbtn.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.encryptbtn.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.encryptbtn.CustomImages.Parent = this.encryptbtn;
            this.encryptbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(236)))), ((int)(((byte)(130)))));
            this.encryptbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptbtn.ForeColor = System.Drawing.Color.Black;
            this.encryptbtn.HoverState.Parent = this.encryptbtn;
            this.encryptbtn.Location = new System.Drawing.Point(24, 334);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.PressedColor = System.Drawing.Color.White;
            this.encryptbtn.ShadowDecoration.Parent = this.encryptbtn;
            this.encryptbtn.Size = new System.Drawing.Size(180, 45);
            this.encryptbtn.TabIndex = 12;
            this.encryptbtn.Text = "Encrypt";
            // 
            // decryptbtn
            // 
            this.decryptbtn.Animated = true;
            this.decryptbtn.AnimatedGIF = true;
            this.decryptbtn.BackColor = System.Drawing.Color.Transparent;
            this.decryptbtn.BorderRadius = 10;
            this.decryptbtn.CheckedState.Parent = this.decryptbtn;
            this.decryptbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("decryptbtn.CustomImages.Image")));
            this.decryptbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.decryptbtn.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.decryptbtn.CustomImages.Parent = this.decryptbtn;
            this.decryptbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.decryptbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptbtn.ForeColor = System.Drawing.Color.Black;
            this.decryptbtn.HoverState.Parent = this.decryptbtn;
            this.decryptbtn.ImageSize = new System.Drawing.Size(23, 23);
            this.decryptbtn.Location = new System.Drawing.Point(378, 334);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.PressedColor = System.Drawing.Color.White;
            this.decryptbtn.ShadowDecoration.Parent = this.decryptbtn;
            this.decryptbtn.Size = new System.Drawing.Size(180, 45);
            this.decryptbtn.TabIndex = 18;
            this.decryptbtn.Text = "Decrypt";
            // 
            // decryptkeyconfirm
            // 
            this.decryptkeyconfirm.Animated = true;
            this.decryptkeyconfirm.BackColor = System.Drawing.Color.Transparent;
            this.decryptkeyconfirm.BorderRadius = 5;
            this.decryptkeyconfirm.CheckedState.Parent = this.decryptkeyconfirm;
            this.decryptkeyconfirm.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("decryptkeyconfirm.CustomImages.Image")));
            this.decryptkeyconfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.decryptkeyconfirm.CustomImages.Parent = this.decryptkeyconfirm;
            this.decryptkeyconfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.decryptkeyconfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.decryptkeyconfirm.ForeColor = System.Drawing.Color.White;
            this.decryptkeyconfirm.HoverState.Parent = this.decryptkeyconfirm;
            this.decryptkeyconfirm.ImageSize = new System.Drawing.Size(1, 19);
            this.decryptkeyconfirm.Location = new System.Drawing.Point(347, 292);
            this.decryptkeyconfirm.Name = "decryptkeyconfirm";
            this.decryptkeyconfirm.PressedColor = System.Drawing.Color.White;
            this.decryptkeyconfirm.ShadowDecoration.Parent = this.decryptkeyconfirm;
            this.decryptkeyconfirm.Size = new System.Drawing.Size(25, 25);
            this.decryptkeyconfirm.TabIndex = 17;
            this.decryptkeyconfirm.UseTransparentBackground = true;
            // 
            // decryptionkeylabel
            // 
            this.decryptionkeylabel.AutoSize = true;
            this.decryptionkeylabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptionkeylabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.decryptionkeylabel.ForeColor = System.Drawing.Color.White;
            this.decryptionkeylabel.Location = new System.Drawing.Point(398, 264);
            this.decryptionkeylabel.Name = "decryptionkeylabel";
            this.decryptionkeylabel.Size = new System.Drawing.Size(113, 19);
            this.decryptionkeylabel.TabIndex = 16;
            this.decryptionkeylabel.Text = "Decryption Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Decrypt File";
            // 
            // decryptkey
            // 
            this.decryptkey.Animated = true;
            this.decryptkey.BackColor = System.Drawing.Color.Transparent;
            this.decryptkey.BorderRadius = 5;
            this.decryptkey.BorderThickness = 0;
            this.decryptkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.decryptkey.DefaultText = "";
            this.decryptkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.decryptkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.decryptkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.decryptkey.DisabledState.Parent = this.decryptkey;
            this.decryptkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.decryptkey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.decryptkey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.decryptkey.FocusedState.Parent = this.decryptkey;
            this.decryptkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.decryptkey.ForeColor = System.Drawing.Color.White;
            this.decryptkey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.decryptkey.HoverState.Parent = this.decryptkey;
            this.decryptkey.Location = new System.Drawing.Point(378, 292);
            this.decryptkey.Name = "decryptkey";
            this.decryptkey.PasswordChar = '\0';
            this.decryptkey.PlaceholderText = "";
            this.decryptkey.SelectedText = "";
            this.decryptkey.ShadowDecoration.Parent = this.decryptkey;
            this.decryptkey.Size = new System.Drawing.Size(180, 25);
            this.decryptkey.TabIndex = 14;
            // 
            // decryptpanel
            // 
            this.decryptpanel.BackColor = System.Drawing.Color.Transparent;
            this.decryptpanel.BorderColor = System.Drawing.Color.Black;
            this.decryptpanel.BorderRadius = 20;
            this.decryptpanel.Controls.Add(this.decryptwait);
            this.decryptpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.decryptpanel.Location = new System.Drawing.Point(387, 94);
            this.decryptpanel.Name = "decryptpanel";
            this.decryptpanel.ShadowDecoration.Parent = this.decryptpanel;
            this.decryptpanel.Size = new System.Drawing.Size(150, 150);
            this.decryptpanel.TabIndex = 13;
            this.decryptpanel.UseTransparentBackground = true;
            // 
            // decryptwait
            // 
            this.decryptwait.Animated = true;
            this.decryptwait.AnimationSpeed = 1F;
            this.decryptwait.BackColor = System.Drawing.Color.Transparent;
            this.decryptwait.Controls.Add(this.decryptfilename);
            this.decryptwait.Controls.Add(this.decryptfileselector);
            this.decryptwait.FillColor = System.Drawing.Color.Transparent;
            this.decryptwait.Location = new System.Drawing.Point(10, 10);
            this.decryptwait.Name = "decryptwait";
            this.decryptwait.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.decryptwait.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.decryptwait.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.decryptwait.ProgressThickness = 10;
            this.decryptwait.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.decryptwait.ShadowDecoration.Parent = this.decryptwait;
            this.decryptwait.Size = new System.Drawing.Size(130, 130);
            this.decryptwait.TabIndex = 12;
            this.decryptwait.UseTransparentBackground = true;
            this.decryptwait.Value = 25;
            // 
            // decryptfilename
            // 
            this.decryptfilename.AutoSize = true;
            this.decryptfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decryptfilename.ForeColor = System.Drawing.Color.White;
            this.decryptfilename.Location = new System.Drawing.Point(-4, 53);
            this.decryptfilename.Name = "decryptfilename";
            this.decryptfilename.Size = new System.Drawing.Size(67, 17);
            this.decryptfilename.TabIndex = 49;
            this.decryptfilename.Text = "FileName";
            this.decryptfilename.Visible = false;
            // 
            // decryptfileselector
            // 
            this.decryptfileselector.Image = ((System.Drawing.Image)(resources.GetObject("decryptfileselector.Image")));
            this.decryptfileselector.Location = new System.Drawing.Point(40, 40);
            this.decryptfileselector.Name = "decryptfileselector";
            this.decryptfileselector.Size = new System.Drawing.Size(50, 50);
            this.decryptfileselector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decryptfileselector.TabIndex = 42;
            this.decryptfileselector.TabStop = false;
            // 
            // operationprogress
            // 
            this.operationprogress.BackColor = System.Drawing.Color.Transparent;
            this.operationprogress.FillColor = System.Drawing.Color.Transparent;
            this.operationprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationprogress.ForeColor = System.Drawing.Color.White;
            this.operationprogress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.operationprogress.Location = new System.Drawing.Point(0, 30);
            this.operationprogress.Name = "operationprogress";
            this.operationprogress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.operationprogress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.operationprogress.ShadowDecoration.Parent = this.operationprogress;
            this.operationprogress.ShowPercentage = true;
            this.operationprogress.Size = new System.Drawing.Size(600, 20);
            this.operationprogress.TabIndex = 41;
            this.operationprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.operationprogress.UseTransparentBackground = true;
            // 
            // folderselector
            // 
            this.folderselector.Description = "Output Folder";
            // 
            // creditslabel
            // 
            this.creditslabel.AutoSize = true;
            this.creditslabel.BackColor = System.Drawing.Color.Transparent;
            this.creditslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditslabel.ForeColor = System.Drawing.Color.White;
            this.creditslabel.Location = new System.Drawing.Point(270, 376);
            this.creditslabel.Name = "creditslabel";
            this.creditslabel.Size = new System.Drawing.Size(57, 17);
            this.creditslabel.TabIndex = 42;
            this.creditslabel.Text = "[Credits]";
            // 
            // randomizekey
            // 
            this.randomizekey.Animated = true;
            this.randomizekey.BackColor = System.Drawing.Color.Transparent;
            this.randomizekey.BorderRadius = 5;
            this.randomizekey.CheckedState.Parent = this.randomizekey;
            this.randomizekey.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("randomizekeyandIV.CustomImages.Image")));
            this.randomizekey.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.randomizekey.CustomImages.Parent = this.randomizekey;
            this.randomizekey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.randomizekey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.randomizekey.ForeColor = System.Drawing.Color.White;
            this.randomizekey.HoverState.Parent = this.randomizekey;
            this.randomizekey.ImageSize = new System.Drawing.Size(1, 19);
            this.randomizekey.Location = new System.Drawing.Point(212, 275);
            this.randomizekey.Name = "randomizekey";
            this.randomizekey.PressedColor = System.Drawing.Color.White;
            this.randomizekey.ShadowDecoration.Parent = this.randomizekey;
            this.randomizekey.Size = new System.Drawing.Size(25, 25);
            this.randomizekey.TabIndex = 47;
            this.randomizekey.UseTransparentBackground = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.randomizekey);
            this.Controls.Add(this.creditslabel);
            this.Controls.Add(this.decryptbtn);
            this.Controls.Add(this.decryptkeyconfirm);
            this.Controls.Add(this.decryptionkeylabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptkey);
            this.Controls.Add(this.decryptpanel);
            this.Controls.Add(this.encryptbtn);
            this.Controls.Add(this.encryptkeyconfirm);
            this.Controls.Add(this.encryptionkeylabel);
            this.Controls.Add(this.filetoencryptlabel);
            this.Controls.Add(this.encryptkey);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.operationprogress);
            this.Controls.Add(this.encryptpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "UltimateEncryptor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.encryptpanel.ResumeLayout(false);
            this.encryptwait.ResumeLayout(false);
            this.encryptwait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptfileselector)).EndInit();
            this.decryptpanel.ResumeLayout(false);
            this.decryptwait.ResumeLayout(false);
            this.decryptwait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptfileselector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Panel titlebar;
        private Guna.UI2.WinForms.Guna2Panel encryptpanel;
        private Guna.UI2.WinForms.Guna2TextBox encryptkey;
        private System.Windows.Forms.Label filetoencryptlabel;
        private System.Windows.Forms.Label encryptionkeylabel;
        internal Guna.UI2.WinForms.Guna2Button encryptkeyconfirm;
        private Guna.UI2.WinForms.Guna2Button encryptbtn;
        private Guna.UI2.WinForms.Guna2Button decryptbtn;
        internal Guna.UI2.WinForms.Guna2Button decryptkeyconfirm;
        private System.Windows.Forms.Label decryptionkeylabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox decryptkey;
        private Guna.UI2.WinForms.Guna2Panel decryptpanel;
        private Guna.UI2.WinForms.Guna2ProgressBar operationprogress;
        private System.Windows.Forms.PictureBox encryptfileselector;
        private System.Windows.Forms.PictureBox decryptfileselector;
        internal System.Windows.Forms.OpenFileDialog fileselector;
        private System.Windows.Forms.FolderBrowserDialog folderselector;
        internal Guna.UI2.WinForms.Guna2CircleProgressBar encryptwait;
        internal Guna.UI2.WinForms.Guna2CircleProgressBar decryptwait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label creditslabel;
        internal Guna.UI2.WinForms.Guna2Button randomizekey;
        private System.Windows.Forms.Label encryptfilename;
        private System.Windows.Forms.Label decryptfilename;
    }
}

