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
    public partial class FormActivity : Form
    {

        public FormActivity()
        {
            InitializeComponent();
        }

        private void FormActivity_Load(object sender, EventArgs e)
        {
            //Them color
            Load_Them();
            Load_Data();
        }

        private void Load_Data()
        { //Load data
            lstViewData.View = View.Details;
            lstViewData.SmallImageList = imgLstSer;

            //coloumn
            lstViewData.Columns.Add("ID", 100);
            lstViewData.Columns.Add("Tên dịch vụ", 100);
            lstViewData.Columns.Add("Địa chỉ", 300);
            lstViewData.Columns.Add("Thanh toán", 100);
            List<int> intLC = DataFrame.Location;
            lbNumSer.Text = "Số lượng dịch vụ: " + DataFrame.Index.ToString();
            for (int idx = 0; idx < DataFrame.Index; idx++)
            {
                string s = "ID='" + idx.ToString() + "'";
                DataRow row;
                switch (intLC[idx])
                {
                    case 0:
                        row = DataFrame.Clean.Select(s)[0];
                        break;
                    case 1:
                        row = DataFrame.DeepClean.Select(s)[0];
                        break;
                    case 2:
                        row = DataFrame.Gorgeries.Select(s)[0];
                        break;
                    case 3:
                        row = DataFrame.AirC.Select(s)[0];
                        break;
                    case 4:
                        row = DataFrame.Bacterick.Select(s)[0];
                        break;
                    case 5:
                        row = DataFrame.Cooking.Select(s)[0];
                        break;
                    default://case 6
                        row = DataFrame.Washing.Select(s)[0];
                        break;
                }
                string adress = row["Adress"].ToString();
                decimal money = Convert.ToDecimal(row["Price"]);
                Add_Data(idx, intLC[idx], adress, money);
            }

        }

        public void Load_Them()
        {
            foreach (Control ctrl in this.Controls)
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
            foreach (Control _ctrl in pnlSerInf.Controls)
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

        private void Add_Data(int ID, int idx, string adress, decimal money)
        {
            List<string> name = new List<string>
            {"Dọn dẹp", "Tổng vệ sinh", "Đi chợ", "Vệ sinh máy lạnh", "Khử khuẩn", "Nấu ăn", "Giặt ủi"};
            ListViewItem temp = new ListViewItem(ID.ToString(), idx);
            temp.SubItems.Add(name[idx]);
            temp.SubItems.Add(adress);
            temp.SubItems.Add(string.Format("{0:N}", money).Replace(".00", ""));
            lstViewData.Items.Add(temp);
        }

        //Thao tác sau khi đặt dịch vụ
        private void lstViewData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                List<string> name = new List<string>
            {"Dọn dẹp", "Tổng vệ sinh", "Đi chợ", "Vệ sinh máy lạnh", "Khử khuẩn", "Nấu ăn", "Giặt ủi"};
                string sel = lstViewData.SelectedItems[0].SubItems[1].Text;
                ListViewItem item = lstViewData.SelectedItems[0];
                string s = "ID='" + item.Text + "'";
                DataRow row;
                if (sel == name[0])
                {
                    row = DataFrame.Clean.Select(s)[0];
                }
                else
                {
                    if (sel == name[1])
                    {
                        row = DataFrame.DeepClean.Select(s)[0];
                    }
                    else
                    {
                        if (sel == name[2])
                        {
                            row = DataFrame.Gorgeries.Select(s)[0];
                        }
                        else
                        {
                            if (sel == name[3])
                            {
                                row = DataFrame.AirC.Select(s)[0];
                            }
                            else
                            {
                                if (sel == name[4])
                                {
                                    row = DataFrame.Bacterick.Select(s)[0];
                                }
                                else
                                {
                                    if (sel == name[5])
                                    {
                                        row = DataFrame.Cooking.Select(s)[0];
                                    }
                                    else
                                    {
                                        row = DataFrame.Washing.Select(s)[0];
                                    }
                                }
                            }
                        }
                    }
                }
                txtBill.Text = item.SubItems[3].Text;
                txtPay.Text = txtBill.Text;
                DateTime day = (DateTime)row["Time"];
                DateTime time = (DateTime)row["Clock"];
                string ddmmyy = day.Day.ToString() + "/" + day.Month.ToString() + "/" + day.Year.ToString();
                string HHMM = time.Hour.ToString() + ":" + time.Minute.ToString();
                txtTime.Text = ddmmyy;
                txtHour.Text = HHMM;
            }
            catch { /*MessageBox.Show("Nhấn OK");*/ }
        }

        private void delete_Data()
        {

            string sel = lstViewData.SelectedItems[0].SubItems[1].Text;
            ListViewItem item = lstViewData.SelectedItems[0];
            List<string> name = new List<string>
            {"Dọn dẹp", "Tổng vệ sinh", "Đi chợ", "Vệ sinh máy lạnh", "Khử khuẩn", "Nấu ăn", "Giặt ủi"};
            string s = "ID='" + item.Text + "'";
            DataRow row;
            if (sel == name[0])
            {
                row = DataFrame.Clean.Select(s)[0];
                row.Delete();
                DataFrame.Clean.AcceptChanges();
            }
            else
            {
                if (sel == name[1])
                {
                    row = DataFrame.DeepClean.Select(s)[0];
                    row.Delete();
                    DataFrame.DeepClean.AcceptChanges();
                }
                else
                {
                    if (sel == name[2])
                    {
                        row = DataFrame.Gorgeries.Select(s)[0];
                        row.Delete();
                        DataFrame.Gorgeries.AcceptChanges();
                    }
                    else
                    {
                        if (sel == name[3])
                        {
                            row = DataFrame.AirC.Select(s)[0];
                            row.Delete();
                            DataFrame.AirC.AcceptChanges();
                        }
                        else
                        {
                            if (sel == name[4])
                            {
                                row = DataFrame.Bacterick.Select(s)[0];
                                row.Delete();
                                DataFrame.Bacterick.AcceptChanges();
                            }
                            else
                            {
                                if (sel == name[5])
                                {
                                    row = DataFrame.Cooking.Select(s)[0];
                                    row.Delete();
                                    DataFrame.Cooking.AcceptChanges();
                                }
                                else
                                {
                                    row = DataFrame.Washing.Select(s)[0];
                                    row.Delete();
                                    DataFrame.Washing.AcceptChanges();
                                }
                            }
                        }
                    }
                }
            }
            int indexDelete = Convert.ToInt32(item.Text);
            List<int> intLC = DataFrame.Location;
            for (int idx = indexDelete + 1; idx < DataFrame.Index; idx++)
            {
                string st = "ID='" + idx.ToString() + "'";
                DataRow rowt;
                switch (intLC[idx])
                {
                    case 0:
                        rowt = DataFrame.Clean.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.Clean.AcceptChanges();
                        break;
                    case 1:
                        rowt = DataFrame.DeepClean.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.DeepClean.AcceptChanges();
                        break;
                    case 2:
                        rowt = DataFrame.Gorgeries.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.Gorgeries.AcceptChanges();
                        break;
                    case 3:
                        rowt = DataFrame.AirC.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.AirC.AcceptChanges();
                        break;
                    case 4:
                        rowt = DataFrame.Bacterick.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.Bacterick.AcceptChanges();
                        break;
                    case 5:
                        rowt = DataFrame.Cooking.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.Cooking.AcceptChanges();
                        break;
                    default://case 6
                        rowt = DataFrame.Washing.Select(st)[0];
                        rowt["ID"] = ((int)rowt["ID"] - 1);
                        DataFrame.Washing.AcceptChanges();
                        break;
                }
            }

            DataFrame.Location.RemoveAt(indexDelete);
            DataFrame.Index = DataFrame.Index - 1;
            lstViewData.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            delete_Data();
            Load_Data();
            //lstViewData.SelectedItems[0].Remove();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string s = "Thanh toán bằng tiền mặt.\n Số tiền: " + txtPay.Text + "VNĐ";
            delete_Data();
            MessageBox.Show(s);
            Load_Data();
        }

        //Khuyến mãi - mã khuyến mãi
        public static List<string> code50 = new List<string>
        { "THUGSTOOLS", "PROFESSIONALTOOLS", "NUTTERTOOLS", "ASPIRINE", "GESUNDHEIT", "IFIWEREARICHMAN", "PRECIOUSPROTECTION", "GUNSGUNSGUNS", "FANNYMAGNET", "YOUWONTTAKEMEALIVE", "LEAVEMEALONE", "CANTTAKEITANYMORE"};
        public static List<string> code25 = new List<string>
        { "DEEPFRIEDMARSBARS", "PROGRAMMER", "STILLLIKEDRESSINGUP", "CERTAINDEATH", "HOPINGIRL", "CHEATSHAVEBEENCRACKED", "LOOKLIKELANCE", "MYSONISALAWYER", "LOOKLIKEHILARY", "ROCKANDROLLMAN ", "WELOVEOURDICK", "ONEARMEDBANDIT", "IDONTHAVETHEMONEYSONNY", "FOXYLITTLETHING"};
        public static List<string> code10 = new List<string>
        { "PANZER", "GIVEUSATANK", "TRAVELINSTYLE", "GETTHEREQUICKLY", "GETTHEREFAST", "GETTHEREVERYFASTINDEED", "GETTHEREAMAZINGLYFAST", "THELASTRIDE", "ROCKANDROLLCAR", "RUBBISHCAR", "BETTERTHANWALKING", "LOADSOFLITTLETHINGS", "AIRSHIP", "BIGBANG", "MIAMITRAFFIC", "AHAIRDRESSERSCAR", "IWANTITPAINTEDBLACK"};
        private int Sale_Ser(string code)
        {
            int Sale = 100;
            if (code50.Contains(code))
            {
                Sale = 50;
            }
            if (code25.Contains(code))
            {
                Sale = 75;
            }
            if (code10.Contains(code))
            {
                Sale = 90;
            }
            return Sale;
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Sale = Sale_Ser(txtSale.Text);
            int money = Convert.ToInt32(txtBill.Text.Replace(",", ""));
            int pay = money * Sale / 100;
            txtPay.Text = string.Format("{0:N}", pay).Replace(".00", "");
        }
    }
}
