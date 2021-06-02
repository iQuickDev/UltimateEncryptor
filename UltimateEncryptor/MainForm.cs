using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.Threading;

namespace UltimateEncryptor
{
    public partial class MainForm : Form
    {
        internal Form Credits = new Credits();
        internal string outputFolder, encryptKeyString, decryptKeyString, encryptFile, decryptFile, encryptFileName, decryptFileName, encryptFileWPath, decryptFileWPath;

        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            titlebar.MouseDown += panel1_MouseDown;
            titlebar.MouseMove += panel1_MouseMove;
            titlebar.MouseUp += panel1_MouseUp;
            close.Click += close_Click;
            minimize.Click += minimize_Click;
            encryptfileselector.Click += encryptfilesselector_Click;
            decryptfileselector.Click += decryptfilesselector_Click;
            encryptbtn.Click += Encrypt;
            decryptbtn.Click += Decrypt;
            encryptkeyconfirm.Click += encryptkeyconfirm_Click;
            decryptkeyconfirm.Click += decryptkeyconfirm_Click;
            creditslabel.Click += creditslabel_Click;
            randomizekey.Click += randomizekey_Click;
        }

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        private void FileEncrypt(string encryptFile, string encryptKeyString)
        {
            new Thread(() =>
            {
                operationprogress.Value = 20;

                byte[] salt = GenerateRandomSalt();

                FileStream fsCrypt = new FileStream(encryptFile, FileMode.Create);

                byte[] passwordBytes = Encoding.UTF8.GetBytes(encryptKeyString);

                operationprogress.Value = 30;

                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CFB;

                operationprogress.Value = 50;

                fsCrypt.Write(salt, 0, salt.Length);

                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
                FileStream fsIn = new FileStream(encryptFileWPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

                operationprogress.Value = 70;

                byte[] buffer = new byte[1048576];
                int read;

                try
                {
                    while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Application.DoEvents();
                        cs.Write(buffer, 0, read);
                    }

                    fsIn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    cs.Close();
                    fsCrypt.Close();
                }

                operationprogress.Value = 100;

            }).Start();
        }

        private void FileDecrypt(string encryptFile, string decryptFile, string decryptKeyString)
        {
            new Thread(() =>
            {
                operationprogress.Value = 20;

                byte[] passwordBytes = Encoding.UTF8.GetBytes(decryptKeyString);
                byte[] salt = new byte[32];

                operationprogress.Value = 30;

                FileStream fsCrypt = new FileStream(decryptFileWPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                fsCrypt.Read(salt, 0, salt.Length);
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.PKCS7;
                AES.Mode = CipherMode.CFB;

                operationprogress.Value = 50;

                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(decryptFileWPath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);

                operationprogress.Value = 80;

                int read;
                byte[] buffer = new byte[1048576];

                try
                {
                    while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Application.DoEvents();
                        fsOut.Write(buffer, 0, read);
                    }
                }
                catch (CryptographicException ex_CryptographicException)
                {
                    Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                operationprogress.Value = 90;

                try
                {
                    cs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
                }
                finally
                {
                    fsOut.Close();
                    fsCrypt.Close();
                }

                operationprogress.Value = 100;

            }).Start();
        }


        internal void randomizekey_Click(object sender, EventArgs e)
        {
            using (var rijndael = Rijndael.Create())
            {
                rijndael.GenerateKey();
                var rndKey = Convert.ToBase64String(rijndael.Key);
                if (rndKey.Length > 32)
                    rndKey = rndKey.Remove(0, rndKey.Length - 32);
                encryptkey.Text = rndKey;
            }
        }

        internal void creditslabel_Click(object sender, EventArgs e)
        {
            Credits.Show();
        }

        internal void decryptkeyconfirm_Click(object sender, EventArgs e)
        {
            decryptKeyString = encryptkey.Text;
        }

        internal void encryptkeyconfirm_Click(object sender, EventArgs e)
        {
            encryptKeyString = decryptkey.Text;
        }

        internal void decryptfilesselector_Click(object sender, EventArgs e)
        {
            fileselector.ShowDialog();
            if (fileselector.FileName == "")
                return;
            decryptFile = fileselector.FileName;
            decryptFileWPath = decryptFile;
            decryptFileName = Path.GetFileName(decryptFile);
            decryptfilename.Text = decryptFileName;
            decryptwait.ProgressColor = ColorTranslator.FromHtml("#00000000");
            decryptwait.ProgressColor2 = ColorTranslator.FromHtml("#00000000");
            decryptfileselector.Visible = false;
            decryptfilename.Visible = true;
        }

        internal void encryptfilesselector_Click(object sender, EventArgs e)
        {
            fileselector.ShowDialog();
            if (fileselector.FileName == "")
                return;
            encryptFile = fileselector.FileName;
            encryptFileWPath = encryptFile;
            encryptFileName = Path.GetFileName(encryptFile);
            encryptfilename.Text = encryptFileName;
            encryptwait.ProgressColor = ColorTranslator.FromHtml("#00000000");
            encryptwait.ProgressColor2 = ColorTranslator.FromHtml("#00000000");
            encryptfileselector.Visible = false;
            encryptfilename.Visible = true;
        }


        internal void Decrypt(object sender, EventArgs e)
        {
            operationprogress.ProgressColor = ColorTranslator.FromHtml("#ff0055");
            operationprogress.ProgressColor2 = ColorTranslator.FromHtml("#ff0055");
            GCHandle gch = GCHandle.Alloc(decryptKeyString, GCHandleType.Pinned);
            FileDecrypt(decryptFileName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), decryptKeyString);
            gch.Free();
        }

        internal void Encrypt(object sender, EventArgs e)
        {
            operationprogress.ProgressColor = ColorTranslator.FromHtml("#13ec82");
            operationprogress.ProgressColor2 = ColorTranslator.FromHtml("#13ec82");
            GCHandle gch = GCHandle.Alloc(encryptKeyString, GCHandleType.Pinned);
            FileEncrypt(encryptFileName, encryptKeyString);
            gch.Free();
        }

        internal void foldericon_Click(object sender, EventArgs e)
        {
            folderselector.ShowDialog();
            outputFolder = folderselector.SelectedPath;
        }

        internal void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        internal void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
