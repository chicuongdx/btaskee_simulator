using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace bTaskee
{
    public partial class bTaskee : Form
    {
        private Random random;
        private int curIdx;
        private Button curBtn;
        private Form activeForm;

        public bTaskee()
        {
            InitializeComponent();
            random = new Random();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            DataFrame.Column_Add();
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Size original;

        private void pnlTileBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
                if (this.Location.Y <= 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.Size = original;
                }

                // Drag to side to split screen
                if (this.Location.X <= 0)
                {
                    this.Location = new Point(0, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else if (this.Location.X >= SystemInformation.WorkingArea.Width / 2)
                {
                    this.Location = new Point(SystemInformation.WorkingArea.Width / 2, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else
                {
                    this.Size = original;
                }
            }
        }
        private void bTaskee_Load(object sender, EventArgs e)
        {
            original = this.Size;
            timer.Start();
        }

        //design form

        private Color SelectColor()
        {
            int idx = random.Next(ThemeColor.ColorList.Count);
            while (curIdx == idx)
            {
                idx = random.Next(ThemeColor.ColorList.Count);
            }
            curIdx = idx;
            string color = ThemeColor.ColorList[idx];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (curBtn != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectColor();
                    curBtn = (Button)btnSender;
                    curBtn.BackColor = color;
                    curBtn.ForeColor = Color.White;
                    curBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTileBar.BackColor = color;
                    pnlIcon.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control btn in pnlMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(50, 50, 73);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTile.Text = childForm.Text;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.FormServices(), sender);
        }

        private void btnActivty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.FormActivity(), sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.FormUser(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZoomIO_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctIcon_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                DisableButton();
            }
            lbTile.Text = "HOME";
            pnlTileBar.BackColor = Color.FromArgb(0, 150, 136);
            pnlIcon.BackColor = Color.FromArgb(39, 39, 58);
            curBtn = null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbSecond.Text = DateTime.Now.ToString("ss");
            lbDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbDay.Text = DateTime.Now.ToString("dddd");
            lbSecond.Location = new Point(lbTime.Location.X + lbTime.Width - 5, lbSecond.Location.Y);
        }
    }
}