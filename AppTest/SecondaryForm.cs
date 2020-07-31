using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class SecondaryForm : Form
    {

        private Bitmap bm;
        private Graphics gr;
        string filename;
        private bool flag;
        public SecondaryForm(Bitmap ss,string filename)
        {

            this.filename = filename;
            bm = ss;
            
            gr = Graphics.FromImage(bm as Image);
            gr.CopyFromScreen(0, 0, 0, 0,bm.Size);

            flag = false;
            InitializeComponent();

            this.Location = new Point(0, 0);
        }

        private void SecondaryForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = bm;
        }


        //МНОГОКРАТНОЕ НАЖАТИЕ - КРАШ ПРОГРАММЫ
        private void btnSave_Click(object sender, EventArgs e)
        {
            bm.Save(filename,System.Drawing.Imaging.ImageFormat.Jpeg);
            flag = true;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save as";

            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;
            sfd.InitialDirectory = GlobalProperty.savedFolder;
            sfd.Filter = "JPEG|*.jpeg|BMP|*.bmp|PNG|*.png|GIF|*.gif|All files(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(sfd.FileName))
                {
                    case ".bmp":
                        bm.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".jpeg":
                        bm.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".png":
                        bm.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".gif":
                        bm.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    default:
                        bm.Save(sfd.FileName.Replace(Path.GetExtension(sfd.FileName),".jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                flag = true;
            }
            sfd.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    bm.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Process.Start("mspaint.exe", $"\"{filename}\"");
                }
                catch {
                    MessageBox.Show("Paint is not found! ");
                }
            });
            flag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Changies are not saved. Continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    this.Dispose();
                    this.Close();
                }
            }
        }


        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(pictureBox.Image);
        }

        private void btns_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Thistle;
        }

        private void btns_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Lavender;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
