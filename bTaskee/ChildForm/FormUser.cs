using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bTaskee.ChildForm
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Load_Them();
            Load_User();
        }

        public void Load_User()
        {
            lbName.Text = DataFrame.NameUser;
            lbAdress.Text = DataFrame.AdressUser;
            lbPhone.Text = DataFrame.SDTUser;
            lbMail.Text = DataFrame.MailUser;
            pctAvatar_Inf.BackgroundImage = DataFrame.Avatar;
            pnlUser.BackColor = Color.White;
        }

        public void Load_Them()
        {
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Panel))
                {
                    foreach (Control _ctrl in ctrl.Controls)
                    {
                        if (_ctrl.GetType() == typeof(Label) || _ctrl.GetType() == typeof(TextBox))
                            _ctrl.ForeColor = ThemeColor.PrimaryColor;
                        if (_ctrl.GetType() == typeof(Button))
                        {
                            _ctrl.ForeColor = Color.White;
                            _ctrl.BackColor = ThemeColor.PrimaryColor;
                        }
                    }
                }
                if (ctrl.GetType() == typeof(Label) || ctrl.GetType() == typeof(TextBox))
                {
                    ctrl.ForeColor = ThemeColor.SecondaryColor;
                }
                if (ctrl.GetType() == typeof(Button) && ctrl.Name != "btnAvatar")
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = ThemeColor.PrimaryColor;
                }

            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            TextBox txtPrice = (TextBox)sender;
            if (txtPrice.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            string sFileName = "";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
            }
            try
            {
                Image image = Image.FromFile(sFileName);
                pctAvatar.BackgroundImage = image;
            }
            catch { MessageBox.Show("Vui lòng chọn file ảnh có định dạng .png, .jpg, .jfif, ..."); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("Vui lòng bạn nhập tên!");
            if (txtAdress.Text == "")
                MessageBox.Show("Vui lòng bạn nhập địa chỉ!");
            if (txtSDT.Text == "")
                MessageBox.Show("Vui lòng bạn nhập số điện thoại!");
            if (txtName.Text != "" && txtAdress.Text != "" && txtSDT.Text != "")
            {
                lbName.Text = txtName.Text;
                lbAdress.Text = txtAdress.Text;
                lbPhone.Text = txtSDT.Text;
                if (txtMail.Text != "")
                    lbMail.Text = txtMail.Text;
                pctAvatar_Inf.BackgroundImage = pctAvatar.BackgroundImage;

                //Save infor
                DataFrame.NameUser = lbName.Text;
                DataFrame.AdressUser = lbAdress.Text;
                DataFrame.SDTUser = lbPhone.Text;
                DataFrame.MailUser = lbMail.Text;
                DataFrame.Avatar = pctAvatar_Inf.BackgroundImage;
            }

        }
    }
}
