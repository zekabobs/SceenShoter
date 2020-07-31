using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppTest
{
    public partial class MainForm : Form
    {
        SettingsForm sForm;
        InformationForm iForm;
        public MainForm()
        {   sForm = new SettingsForm();
            iForm = new InformationForm();
            this.Location = new Point(0,0);
            InitializeComponent();
        }

        private void btnCreateScreenShot_Click(object sender, EventArgs e)
        {
            string filename = Properties.Settings.Default.location == string.Empty ? GlobalProperty.savedFolder : Properties.Settings.Default.location;
            try
            {
                if (!(System.IO.Directory.Exists(filename))) System.IO.Directory.CreateDirectory(filename);
                filename += $"\\ScreenShot {DateTime.Now.ToString("d.MM.yyyy")} {DateTime.Now.ToString("HH.mm.ss")}.jpeg";
                StartScreenShot(filename);
            }
            catch
            {
                MessageBox.Show("Path error. Try to explicitly specify the path.", "Error", MessageBoxButtons.OK);
                System.Threading.Tasks.Task.Delay(100);
            }

        }
        private void StartScreenShot(string filename)
        { 
            Bitmap ps = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            if (Properties.Settings.Default.isUseEasySShot)
            {
                this.Hide();
                Graphics gr = Graphics.FromImage(ps as Image);
                gr.CopyFromScreen(0, 0, 0, 0, ps.Size);
                ps.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.Visible = true;
            }

            else
            {
                this.Hide();
                SecondaryForm sf = new SecondaryForm(ps,filename);
                sf.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                sf.ShowDialog();
                while (sf.WindowState == FormWindowState.Maximized) {   }
                sf.Dispose();
                this.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void settingsTStripMItem_Click(object sender, EventArgs e)
        {
            if (sForm != null)
            {
                sForm.Location = this.Location;
                sForm.ShowDialog();
            }
        }

        private void informationTStripMItem_Click(object sender, EventArgs e)
        {
            if (iForm != null)
            {
                iForm.Location = this.Location;
                iForm.ShowDialog();
            }
        }

        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X,e.Y);
        }
    }
}
