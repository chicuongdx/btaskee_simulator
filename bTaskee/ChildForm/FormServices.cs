using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bTaskee.ChildForm
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (TabPage page in tbControlSer.TabPages)
            {
                foreach (Control pnl in page.Controls)
                {
                    if (pnl.GetType() == typeof(Panel))
                    {
                        foreach (Control ctrl in pnl.Controls)
                        {
                            if (ctrl.GetType() == typeof(RadioButton) || ctrl.GetType() == typeof(Label) || ctrl.GetType() == typeof(TextBox))
                            {
                                ctrl.ForeColor = ThemeColor.PrimaryColor;
                            }
                            if (ctrl.GetType() == typeof(Button))
                            {
                                ctrl.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                                ctrl.ForeColor = Color.White;
                            }
                            if (ctrl.GetType() == typeof(ComboBox))
                            {
                                ctrl.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                            }
                        }
                    }
                }
                foreach (Control ctrl in page.Controls)
                {
                    if (ctrl.GetType() == typeof(RadioButton) || ctrl.GetType() == typeof(Label) || ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(CheckBox))
                    {
                        ctrl.ForeColor = ThemeColor.PrimaryColor;
                    }
                    if (ctrl.GetType() == typeof(Button))
                    {
                        ctrl.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                        ctrl.ForeColor = Color.White;
                    }
                    if (ctrl.GetType() == typeof(ComboBox))
                    {
                        ctrl.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                    }
                    if (ctrl.GetType() == typeof(TabControl))
                    {
                        foreach (TabPage childPage in ctrl.Controls)
                        {
                            foreach (Control chileCtrl in childPage.Controls)
                            {
                                if (chileCtrl.GetType() == typeof(RadioButton) || chileCtrl.GetType() == typeof(Label) || chileCtrl.GetType() == typeof(TextBox) || chileCtrl.GetType() == typeof(CheckBox))
                                {
                                    chileCtrl.ForeColor = ThemeColor.PrimaryColor;
                                }
                                if (chileCtrl.GetType() == typeof(Button))
                                {
                                    chileCtrl.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                                    chileCtrl.ForeColor = Color.White;
                                }
                                if (chileCtrl.GetType() == typeof(ComboBox))
                                {
                                    chileCtrl.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void tbControlSer_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;


            Brush _textBrush;
            // Get the item from the collection.

            TabPage _tabPage = tbControlSer.TabPages[e.Index];
            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = tbControlSer.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);

            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);

                e.DrawBackground();

            }
            // Use our own font.

            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);
            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.FillRectangle(new SolidBrush(ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.4)), _tabBounds);
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, new PointF(_tabBounds.X+120, _tabBounds.Y+30), new StringFormat(_stringFlags));
            g.DrawIcon(Icon.FromHandle(((Bitmap)imgIstSer.Images[e.Index]).GetHicon()), _tabBounds.X+5, _tabBounds.Y+10);
        }

        
        //Dịch vụ dọn nhà cửa
        private void rdBtn2Hour_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtClrMoney.Text = "144.000";
            }
        }

        private void rdBtn3Hour_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtClrMoney.Text = "180.000";
            }
        }

        private void rdBtn4Hour_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtClrMoney.Text = "228.000";
            }
        }


        //Dịch vụ tổng dọn vệ sinh
        private void rdBtn80_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtDeepMoney.Text = "720.000";
            }
        }

        private void rdBtn100_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtDeepMoney.Text = "810.000";
            }
        }

        private void rdBtn150_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                txtDeepMoney.Text = "1.080.000";
            }
        }

        //Dịch vụ đi chợ
        private void txtMarketPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtPrice.Text.Length >= 8)
            {
                e.Handled = true;
            }
        }

        private void txtMarketMoney_TextChanged(object sender, EventArgs e)
        {
            TextBox txtPrice = (TextBox)sender;
            if (txtPrice.Text != "")
            {
               int money = Int32.Parse(txtMarketPrice.Text.Replace(".", "")) + 295000;
               txtMarketMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        // Dịch vụ vệ sinh điều hòa
        private void rdBtnTreo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                pnlTreo.Visible = true;
                pnlDung.Visible = false;
                pnlAm.Visible = false;
            }
        }

        private void rdBtnDung_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                pnlTreo.Visible = false;
                pnlDung.Visible = true;
                pnlAm.Visible = false;
            }
        }

        private void rdBtnAm_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                pnlTreo.Visible = false;
                pnlDung.Visible = false;
                pnlAm.Visible = true;
            }
        }
        private void numUDDung_ValueChanged(object sender, EventArgs e)
        {
            if (rdBtnDung.Checked == true)
            {
                if (numUDDung.Value != 0)
                {
                    decimal money = 300000 + (numUDDung.Value - 1) * 250000;
                    txtACMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
                }
                else
                {
                    txtACMoney.Text = "0";
                }
            }
        }

        public static decimal Price_AC_Am_Uper { get; set; }
        public static decimal Price_AC_Am_High { get; set; }

        private void numUDAmUper_ValueChanged(object sender, EventArgs e)
        {
            if (rdBtnAm.Checked == true && checkBoxAmUper.Checked == true)
            {
                decimal money = numUDAmUper.Value * 400000;
                decimal totalPrice = money + Price_AC_Am_High;
                txtACMoney.Text = string.Format("{0:N}", totalPrice).Replace(".00", "");
                Price_AC_Am_Uper = money;
            }
        }

        private void numUPAmHigh_ValueChanged(object sender, EventArgs e)
        {
            if (rdBtnAm.Checked == true && checkBoxAmHigh.Checked == true)
            {
                decimal money = numUDAmHigh.Value * 550000;
                decimal totalPrice = money + Price_AC_Am_Uper;
                txtACMoney.Text = string.Format("{0:N}", totalPrice).Replace(".00", "");
                Price_AC_Am_High = money;
            }
        }

        private void checkBoxAmUper_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
            if (chBox.Checked == false)
            {
                numUDAmUper.Value = 0;
                money = money - Price_AC_Am_Uper;
                txtACMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
                if (checkBoxAmHigh.Checked == false)
                {
                    txtACMoney.Text = "0";
                }
                Price_AC_Am_Uper = 0;
            }
        }

        private void checkBoxAmHigh_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
            if (chBox.Checked == false)
            {
                numUDAmHigh.Value = 0;
                money = money - Price_AC_Am_High;
                txtACMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
                if (checkBoxAmUper.Checked == false)
                {
                    txtACMoney.Text = "0";
                }
                Price_AC_Am_High = 0;
            }
        }

        public static decimal Price_AC_Treo_Uper { get; set; }
        public static decimal Price_AC_Treo_High { get; set; }

        private void numUDUper_ValueChanged(object sender, EventArgs e)
        {
            if (rdBtnTreo.Checked == true && checkBoxTreoSmall.Checked == true)
            {
                decimal money = numUDUper.Value * 500000;
                decimal totalPrice = money + Price_AC_Treo_High;
                txtACMoney.Text = string.Format("{0:N}", totalPrice).Replace(".00", "");
                Price_AC_Treo_Uper = money;
            }
        }

        private void numUDHigh_ValueChanged(object sender, EventArgs e)
        {
            if (rdBtnTreo.Checked == true && checkBoxTreoLarge.Checked == true)
            {
                decimal money = numUDHigh.Value * 600000;
                decimal totalPrice = money + Price_AC_Treo_Uper;
                txtACMoney.Text = string.Format("{0:N}", totalPrice).Replace(".00", "");
                Price_AC_Treo_High = money;
            }
        }

        private void checkBoxTreoSmall_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
            if (chBox.Checked == false)
            {
                numUDUper.Value = 0;
                money = money - Price_AC_Treo_Uper;
                txtACMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
                if (checkBoxTreoLarge.Checked == false)
                {
                    txtACMoney.Text = "0";
                }
                Price_AC_Treo_Uper = 0;
            }
        }

        private void checkBoxTreoLarge_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
            if (chBox.Checked == false)
            {
                numUDHigh.Value = 0;
                money = money - Price_AC_Treo_High;
                txtACMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
                if (checkBoxTreoSmall.Checked == false)
                {
                    txtACMoney.Text = "0";
                }
                Price_AC_Treo_High = 0;
            }
        }

        //Khử khuẩn
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

        //Dịch vụ nấu ăn
        private void txtMon1_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
            {
                txtCookMoney.Text = string.Format("{0:N}", 120000).Replace(".00", "");
                txtMon2.ReadOnly = false;
            }
            else
            {
                txtMon2.ReadOnly = true;
                txtMon2.Text = "";
                txtCookMoney.Text = "0";
            }
        }

        private void txtMon2_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
            {
                txtCookMoney.Text = string.Format("{0:N}", 140000).Replace(".00", "");
                txtMon3.ReadOnly = false;
            }
            else
            {
                txtMon3.ReadOnly = true;
                txtMon4.ReadOnly = true;
                txtMon3.Text = "";
            }
        }

        private void txtMon3_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
            {
                txtCookMoney.Text = string.Format("{0:N}", 160000).Replace(".00", "");
                txtMon4.ReadOnly = false;
            }
            else
            {
                txtMon4.ReadOnly = true;
                txtMon4.Text = "";
            }
        }

        private void txtMon4_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
                txtCookMoney.Text = string.Format("{0:N}", 180000).Replace(".00", "");
        }

        private void numUDPeople_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numUD = (NumericUpDown)sender;
            if (numUD.Value > 4)
            {
                decimal money = Convert.ToDecimal(txtCookMoney.Text.Replace(",", "")) + 30000;
                txtCookMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        //Dịch vụ giặt ủi
        public static decimal KgPrice_Wash { get; set; }
        public static decimal GiatKho { get; set; }
        private void numUDKg_ValueChanged(object sender, EventArgs e)
        {//15k/1kg
            NumericUpDown numeric = (NumericUpDown)sender;
            KgPrice_Wash = numeric.Value * 15000;
            decimal money = KgPrice_Wash + GiatKho;
            txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
        }

        private void numOfDoBo_ValueChanged(object sender, EventArgs e)
        {//75k/bo
            if (rdBtnDoBo.Checked)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                GiatKho = numeric.Value * 75000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void numOfQuan_ValueChanged(object sender, EventArgs e)
        {//40k/bo
            if (rdBtnQuan.Checked)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                GiatKho = numeric.Value * 40000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void numOfAo_ValueChanged(object sender, EventArgs e)
        {//45/bo
            if (rdBtnAo.Checked)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                GiatKho = numeric.Value * 45000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void numOfVay_ValueChanged(object sender, EventArgs e)
        {//55k/bo
            if (rdBtnVay.Checked)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                GiatKho = numeric.Value * 55000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void numOfVayCuoi_ValueChanged(object sender, EventArgs e)
        {//179k/bo
            if (rdBtnVayCuoi.Checked)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                GiatKho = numeric.Value * 170000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void rdBtnNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnNone.Checked)
            {
                GiatKho = 0;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
        }

        private void rdBtnDoBo_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)numOfDoBo;
            if (rdBtnDoBo.Checked)
            {
                GiatKho = numeric.Value * 75000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
            else
            {
                numeric.Value = 0;
            }
        }

        private void rdBtnQuan_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)numOfQuan;
            if (rdBtnQuan.Checked)
            {
                GiatKho = numeric.Value * 40000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
            else
            {
                numeric.Value = 0;
            }
        }

        private void rdBtnAo_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)numOfAo;
            if (rdBtnAo.Checked)
            {
                GiatKho = numeric.Value * 45000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
            else
            {
                numeric.Value = 0;
            }
        }

        private void rdBtnVay_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)numOfVay;
            if (rdBtnVay.Checked)
            {
                GiatKho = numeric.Value * 55000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
            else
            {
                numeric.Value = 0;
            }
        }

        private void rdBtnVayCuoi_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)numOfVayCuoi;
            if (rdBtnVayCuoi.Checked)
            {
                GiatKho = numeric.Value * 170000;
                decimal money = KgPrice_Wash + GiatKho;
                txtWashMoney.Text = string.Format("{0:N}", money).Replace(".00", "");
            }
            else
            {
                numeric.Value = 0;
            }
        }

        //Thao tác dữ liệu
        //Button click event
        private void btnClrChse_Click(object sender, EventArgs e)
        {
            int hours = 0;
            if (rdBtn2Hour.Checked)
                hours = 2;
            if (rdBtn3Hour.Checked)
                hours = 3;
            if (rdBtn4Hour.Checked)
                hours = 4;
            if (txtClrAdress.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập địa chỉ");
            }
            else
            {
                DataFrame.Clean.Rows.Add(DataFrame.Index, hours, Convert.ToDecimal(txtClrMoney.Text.Replace(".", "")), timeClr.Value, txtClrAdress.Text, dateTimePickerClr.Value);
                DataFrame.Index = DataFrame.Index + 1;
                DataFrame.Location.Add(0);
                MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
            }
        }
        //
        private void btnDeepChse_Click(object sender, EventArgs e)
        {
            int area = 0;
            if (rdBtn80.Checked)
                area = 80;
            if (rdBtn100.Checked)
                area = 100;
            if (rdBtn150.Checked)
                area = 150;
            if (txtDeepAdress.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập địa chỉ");
            }
            else
            {
                DataFrame.DeepClean.Rows.Add(DataFrame.Index, area, Convert.ToDecimal(txtDeepMoney.Text.Replace(".", "")), timeDeep.Value, txtDeepAdress.Text, dateTimePickerDeep.Value);
                DataFrame.Index = DataFrame.Index + 1;
                DataFrame.Location.Add(1);
                MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
            }
        }

        //
        private void btnMarketChse_Click(object sender, EventArgs e)
        {
            string lstItem = richTxtItem.Text;
            if (lstItem == "")
            {
                MessageBox.Show("Bạn vui ghi rõ danh sách đồ cần mua!");
            }
            else
            {
                if (txtGorgerisesAdress.Text == "" || txtMarketAdress.Text == "")
                {
                    MessageBox.Show("Bạn vui lòng nhập địa chỉ");
                }
                else
                {
                    int price = Convert.ToInt32(txtMarketPrice.Text);
                    if (price < 100000 || price > 2000000)
                        MessageBox.Show("Số tiền đi chợ vui lòng nằm trong khoảng 100k-2000k");
                    else
                    {
                        decimal money = Convert.ToDecimal(txtMarketMoney.Text.Replace(".", ""));
                        DataFrame.Gorgeries.Rows.Add(DataFrame.Index, lstItem, price, money, timeGor.Value, txtGorgerisesAdress.Text, txtMarketAdress.Text);
                        DataFrame.Index = DataFrame.Index + 1;
                        DataFrame.Location.Add(2);
                        MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
                    }
                }
            }
        }

        //
        private void btnACChse_Click(object sender, EventArgs e)
        {
            if (txtACAdress.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập địa chỉ");
            }
            else
            {
                if (txtACMoney.Text == "0" || txtACMoney.Text == "")
                    MessageBox.Show("Bạn chưa đặt dịch vụ nào cả!");
                else
                {
                    if (rdBtnTreo.Checked)
                    {
                        decimal lower = 0, higher = 0;
                        if (checkBoxTreoSmall.Checked == true)
                        {
                            lower = numUDUper.Value;
                        }
                        if (checkBoxTreoLarge.Checked == true)
                        {
                            higher = numUDHigh.Value;
                        }
                        decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
                        DataFrame.AirC.Rows.Add(DataFrame.Index, 0, lower, higher, money, timeAC.Value, txtACAdress.Text, dateTimePickerAC.Value);
                        DataFrame.Index = DataFrame.Index + 1;
                        DataFrame.Location.Add(3);
                    }
                    else
                    {
                        if (rdBtnDung.Checked)
                        {
                            decimal numOf = 0;
                            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
                            DataFrame.AirC.Rows.Add(DataFrame.Index, 1, numOf, numOf, money, timeAC.Value, txtACAdress.Text, dateTimePickerAC.Value);
                            DataFrame.Index = DataFrame.Index + 1;
                            DataFrame.Location.Add(3);
                        }
                        else
                        {
                            decimal lower = 0, higher = 0;
                            if (checkBoxTreoSmall.Checked == true)
                            {
                                lower = numUDUper.Value;
                            }
                            if (checkBoxTreoLarge.Checked == true)
                            {
                                higher = numUDHigh.Value;
                            }
                            decimal money = Convert.ToDecimal(txtACMoney.Text.Replace(".", ""));
                            DataFrame.AirC.Rows.Add(DataFrame.Index, 2, lower, higher, money, timeAC.Value, txtACAdress.Text, dateTimePickerAC.Value);
                            DataFrame.Index = DataFrame.Index + 1;
                            DataFrame.Location.Add(3);
                        }

                    }
                    MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
                }
            }
        }

        //
        private void btnKKChse_Click(object sender, EventArgs e)
        {
            if (txtKKAdress.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập địa chỉ");
            }
            else
            {
                DataFrame.Bacterick.Rows.Add(DataFrame.Index, txtName.Text, txtSDT.Text, comBoxCity.SelectedItem, comBoxArea.SelectedItem, 0, txtKKAdress.Text, dateTimePickerKK.Value);
                DataFrame.Index = DataFrame.Index + 1;
                DataFrame.Location.Add(4);
                MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
            }
        }

        //
        private void btnCookChse_Click(object sender, EventArgs e)
        {
            if (numUDPeople.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số người ăn phù hợp");
            }
            else
            {
                if (txtCookAdress.Text == "")
                    MessageBox.Show("Bạn vui lòng nhập địa chỉ");
                else
                {
                    if (txtCookMoney.Text == "0" || txtCookMoney.Text == "")
                    {
                        MessageBox.Show("Bạn chưa đặt dịch vụ nào cả!");
                    }
                    else
                    {
                        decimal money = Convert.ToDecimal(txtCookMoney.Text.Replace(".", ""));
                        int khauvi = 0;
                        if (rdBtnBac.Checked)
                            khauvi = 0;
                        if (rdBtnTrung.Checked)
                            khauvi = 1;
                        if (rdBtnNam.Checked)
                            khauvi = 2;
                        DataFrame.Cooking.Rows.Add(DataFrame.Index, numUDPeople.Value, txtMon1.Text, txtMon2.Text, txtMon3.Text, txtMon4.Text, khauvi, txtCookMoney.Text, timeCook.Value, txtCookAdress.Text, dateTimePickerCook.Value);
                        DataFrame.Index = DataFrame.Index + 1;
                        DataFrame.Location.Add(5);
                        MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
                    }
                }
            }
        }

        private void btnWashChse_Click(object sender, EventArgs e)
        {
            if (txtWashAdress.Text == "")
                MessageBox.Show("Bạn vui lòng nhập địa chỉ");
            else
            {
                if (txtWashMoney.Text == "0")
                {
                    MessageBox.Show("Bạn chưa đặt dịch vụ nào cả!");
                }
                else
                {
                    int type = 0;
                    decimal number = 0;
                    if (rdBtnDoBo.Checked)
                    {
                        type = 0;
                        number = 0;
                    }
                    if (rdBtnDoBo.Checked)
                    {
                        type = 1;
                        number = numOfDoBo.Value;
                    }
                    if (rdBtnQuan.Checked)
                    {
                        type = 2;
                        number = numOfQuan.Value;
                    }
                    if (rdBtnAo.Checked)
                    {
                        type = 3;
                        number = numOfAo.Value;
                    }
                    if (rdBtnVay.Checked)
                    {
                        type = 4;
                        number = numOfVay.Value;
                    }
                    if (rdBtnVayCuoi.Checked)
                    {
                        type = 5;
                        number = numOfVayCuoi.Value;
                    }
                    decimal kg = numUDKg.Value;
                    decimal money = Convert.ToDecimal(txtWashMoney.Text.Replace(".", ""));
                    DataFrame.Washing.Rows.Add(DataFrame.Index, kg, type, number, money, timeWash.Value, txtWashAdress.Text, dateTimePickerWash.Value);
                    DataFrame.Index = DataFrame.Index + 1;
                    DataFrame.Location.Add(6);
                    MessageBox.Show("Đặt việc thành công, bạn có thể qua mục hoạt động xem thông tin và hoàn tất thanh toán!");
                }
            }
        }
    }
}