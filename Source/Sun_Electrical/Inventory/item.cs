using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sun_Electrical
{
    class item
    {
        //Item Number Auto increese for function.
        string Item_No;

        public string Item_AutoNo()
        {
            //string sql = "SELECT MAX(itemNo) AS itemNo FROM tbl_Item";
            SqlCommand com = new SqlCommand("SELECT MAX(itemNo) FROM tbl_Item", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                Item_No = dr[0].ToString();// This one can use only 0 inedex -->  dr[0].ToString()
            }
            return Item_No;
        }

        //New Item add method.
        public void newItemAdd(string _itemNo, string descrip, int _noOfQty, decimal _1QtySellPrice)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tbl_Item VALUES('" + _itemNo + "','" + descrip + "','" + _noOfQty + "','" + _1QtySellPrice + "')", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }

        //item update
        public void updateItem(string _itemNo, string _descrip, int _noOfItem,  decimal _1QtySellPri)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Item SET description='" + _descrip + "', noOfQty='" + _noOfItem + "', oneQtySellPrice='" + _1QtySellPri + "' WHERE itemNo='" + _itemNo + "'", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }
    }
}
