using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UltimateEncryptor
{
    public partial class Credits : Form
    {

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

        public Credits()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            maindragpanel.MouseUp += maindragpanel_MouseUp;
            maindragpanel.MouseMove += maindragpanel_MouseMove;
            maindragpanel.MouseDown += maindragpanel_MouseDown;
            youtube.Click += youtube_Click;
            github.Click += github_Click;
            discord.Click += discord_Click;
            steam.Click += steam_Click;
            website.Click += website_Click;
            quicksense.Click += quicksense_Click;
            youtube.MouseEnter += youtube_MouseEnter;
            youtube.MouseLeave += youtube_MouseLeave;
            github.MouseEnter += github_MouseEnter;
            github.MouseLeave += github_MouseLeave;
            discord.MouseEnter += discord_MouseEnter;
            discord.MouseLeave += discord_MouseLeave;
            steam.MouseEnter += steam_MouseEnter;
            steam.MouseLeave += steam_MouseLeave;
            website.MouseEnter += website_MouseEnter;
            website.MouseLeave += website_MouseLeave;
            quicksense.MouseEnter += quicksense_MouseEnter;
            quicksense.MouseLeave += quicksense_MouseLeave;
            closebtn.Click += closebtn_Click;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void maindragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void maindragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void maindragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        internal Size defaultsize = new Size(50, 50);
        internal Size hoversize = new Size(55, 55);
        internal Point youtubelocation = new Point(15, 243);
        internal Point youtubelocationhover = new Point(13, 241);
        internal Point githublocation = new Point(123, 243);
        internal Point githublocationhover = new Point(121, 241);
        internal Point discordlocation = new Point(235, 243);
        internal Point discordlocationhover = new Point(233, 241);
        internal Point steamlocation = new Point(15, 305);
        internal Point steamlocationhover = new Point(13, 302);
        internal Point websitelocation = new Point(123, 305);
        internal Point websitelocationhover = new Point(121, 302);
        internal Point quicksenselocation = new Point(235, 305);
        internal Point quicksenselocationhover = new Point(233, 302);

        private void youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/iQuickGaming/featured");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/iQuickGaming");
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/eNDZrQZ");
        }

        private void steam_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/iQuickGaming/");
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("https://iquickgaming.weebly.com");
        }

        private void quicksense_Click(object sender, EventArgs e)
        {
            Process.Start("https://quicksense.xyz");
        }

        // YouTube animation

        private void youtube_MouseEnter(object sender, EventArgs e)
        {
            youtube.Location = youtubelocationhover;
            youtube.Size = hoversize;
        }

        private void youtube_MouseLeave(object sender, EventArgs e)
        {
            youtube.Location = youtubelocation;
            youtube.Size = defaultsize;
        }

        // GitHub animation

        private void github_MouseEnter(object sender, EventArgs e)
        {
            github.Location = githublocationhover;
            github.Size = hoversize;
        }
        private void github_MouseLeave(object sender, EventArgs e)
        {
            github.Location = githublocation;
            github.Size = defaultsize;
        }

        // Discord animation

        private void discord_MouseEnter(object sender, EventArgs e)
        {
            discord.Location = discordlocationhover;
            discord.Size = hoversize;
        }
        private void discord_MouseLeave(object sender, EventArgs e)
        {
            discord.Location = discordlocation;
            discord.Size = defaultsize;
        }

        // Steam animation

        private void steam_MouseEnter(object sender, EventArgs e)
        {
            steam.Location = steamlocationhover;
            steam.Size = hoversize;
        }
        private void steam_MouseLeave(object sender, EventArgs e)
        {
            steam.Location = steamlocation;
            steam.Size = defaultsize;
        }

        // Website animation

        private void website_MouseEnter(object sender, EventArgs e)
        {
            website.Location = websitelocationhover;
            website.Size = hoversize;
        }
        private void website_MouseLeave(object sender, EventArgs e)
        {
            website.Location = websitelocation;
            website.Size = defaultsize;
        }

        // QuickSense animation

        private void quicksense_MouseEnter(object sender, EventArgs e)
        {
            quicksense.Location = quicksenselocationhover;
            quicksense.Size = hoversize;
        }
        private void quicksense_MouseLeave(object sender, EventArgs e)
        {
            quicksense.Location = quicksenselocation;
            quicksense.Size = defaultsize;
        }
    }
}
