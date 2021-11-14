using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace bTaskee
{
    class DataFrame
    {
        public static DataTable Clean { get; set; }
        public static DataTable DeepClean { get; set; }
        public static DataTable Gorgeries { get; set; }
        public static DataTable AirC { get; set; }
        public static DataTable Bacterick { get; set; }
        public static DataTable Cooking { get; set; }
        public static DataTable Washing { get; set; }
        public static int Index { get; set; }
        public static List<int> Location { get; set; }

        //Thêm côt cho data
        public static void Column_Add()
        {
            Location = new List<int>();
            Index = 0;
            //DtClear
            DataTable tempClr = new DataTable();
            tempClr.Columns.Add("ID", typeof(int));
            tempClr.Columns.Add("Hours", typeof(int));
            tempClr.Columns.Add("Price", typeof(decimal));
            tempClr.Columns.Add("Clock", typeof(DateTime));
            tempClr.Columns.Add("Adress", typeof(string));
            tempClr.Columns.Add("Time", typeof(DateTime));
            Clean = tempClr;
            //DtDeep
            DataTable tempDeep = new DataTable();
            tempDeep.Columns.Add("ID", typeof(int));
            tempDeep.Columns.Add("Area", typeof(int));
            tempDeep.Columns.Add("Price", typeof(decimal));
            tempDeep.Columns.Add("Clock", typeof(DateTime));
            tempDeep.Columns.Add("Adress", typeof(string));
            tempDeep.Columns.Add("Time", typeof(DateTime));
            DeepClean = tempDeep;
            //DtGorgeries
            DataTable tempGorgeries = new DataTable();
            tempGorgeries.Columns.Add("ID", typeof(int));
            tempGorgeries.Columns.Add("ListItem", typeof(string));
            tempGorgeries.Columns.Add("MoneyMarket", typeof(decimal));
            tempGorgeries.Columns.Add("Price", typeof(decimal));
            tempGorgeries.Columns.Add("Clock", typeof(DateTime));
            tempGorgeries.Columns.Add("Adress", typeof(string));
            tempGorgeries.Columns.Add("AdressMarket", typeof(string));
            tempGorgeries.Columns.Add("Time", typeof(DateTime));
            Gorgeries = tempGorgeries;
            //DtAC
            DataTable tempAC = new DataTable();
            tempAC.Columns.Add("ID", typeof(int));
            tempAC.Columns.Add("Type", typeof(int)); //0 = Treo tường, 1 == tủ đứng, 2 == âm trần
            tempAC.Columns.Add("Lower", typeof(decimal)); //số lượng máy dưới 2HP hoặc 3HP, nếu là tủ đứng thì Lower == Higher == số lượng máy
            tempAC.Columns.Add("Higher", typeof(decimal)); ////số lượng máy trên 2HP hoặc 3HP, nếu là tủ đứng thì Lower == Higher == số lượng máy
            tempAC.Columns.Add("Price", typeof(decimal));
            tempAC.Columns.Add("Clock", typeof(DateTime));
            tempAC.Columns.Add("Adress", typeof(string));
            tempAC.Columns.Add("Time", typeof(DateTime));
            AirC = tempAC;
            //DtBacterick
            DataTable tempBacterick = new DataTable();
            tempBacterick.Columns.Add("ID", typeof(int));
            tempBacterick.Columns.Add("Name", typeof(string));
            tempBacterick.Columns.Add("SDT", typeof(string));
            tempBacterick.Columns.Add("City", typeof(string));
            tempBacterick.Columns.Add("Area", typeof(string));
            tempBacterick.Columns.Add("Price", typeof(decimal));
            tempBacterick.Columns.Add("Adress", typeof(string));
            tempBacterick.Columns.Add("Time", typeof(DateTime));
            Bacterick = tempBacterick;
            //DtCook
            DataTable tempCook = new DataTable();
            tempCook.Columns.Add("ID", typeof(int));
            tempCook.Columns.Add("NumOfPeople", typeof(decimal));
            tempCook.Columns.Add("Mon1", typeof(string));
            tempCook.Columns.Add("Mon2", typeof(string));
            tempCook.Columns.Add("Mon3", typeof(string));
            tempCook.Columns.Add("Mon4", typeof(string));
            tempCook.Columns.Add("KhauVi", typeof(int));//0=Bắc, 1=Trung, 2=Nam
            tempCook.Columns.Add("Price", typeof(decimal));
            tempCook.Columns.Add("Clock", typeof(DateTime));
            tempCook.Columns.Add("Adress", typeof(string));
            tempCook.Columns.Add("Time", typeof(DateTime));
            Cooking = tempCook;
            //DtWash
            DataTable tempWash = new DataTable();
            tempWash.Columns.Add("ID", typeof(int));
            tempWash.Columns.Add("KG", typeof(decimal));
            tempWash.Columns.Add("Type", typeof(int)); // None, Đồ bộ, quần, áo, váy, váy cưới = 0,1,2,3,4,5
            tempWash.Columns.Add("Number", typeof(decimal));
            tempWash.Columns.Add("Price", typeof(decimal));
            tempWash.Columns.Add("Clock", typeof(DateTime));
            tempWash.Columns.Add("Adress", typeof(string));
            tempWash.Columns.Add("Time", typeof(DateTime));
            Washing = tempWash;
        }

        //Thông tin cá nhân
        public static string NameUser;
        public static string AdressUser;
        public static string SDTUser;
        public static string MailUser;
        public static Image Avatar;
    }
}
