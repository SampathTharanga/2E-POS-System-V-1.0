using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sun_Electrical
{
    class Invoice
    {
        string tblInvo, itemNo;

        public string invoNo_AutoNo()
        {
            SqlCommand com = new SqlCommand("SELECT MAX(invoiceNo) FROM tblInvoice", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                tblInvo = dr[0].ToString();
            }
            return tblInvo;
        }

        public void newInvoItemAdd(string _invoNo, string _itemNo, string descrip, int _noOfQty, decimal _1QtySellPrice)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblInvoiceItems VALUES('" + _invoNo + "','" + _itemNo + "','" + descrip + "','" + _noOfQty + "','" + _1QtySellPrice + "')", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }


        public string itemMaxNo()
        {
            SqlCommand com = new SqlCommand("SELECT MAX(itemNo) FROM tbl_Item", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                itemNo = dr[0].ToString();
            }
            return itemNo;
        }


        public SqlDataReader select_to_Qntity(string _itemNo)
        {
            SqlCommand com = new SqlCommand("SELECT noOfQty FROM tbl_Item WHERE itemNo='" + _itemNo + "'", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public SqlDataReader checkExistItem(string itemNo)
        {
            SqlCommand com = new SqlCommand("SELECT ItmNo FROM tblInvoiceItems WHERE ItmNo='" + itemNo + "'", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public void newInvoce(string _invoNo, DateTime _date, string _seller, decimal _subTotal, decimal tax, decimal _total, int _noOfQty, decimal _cash, decimal _change)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblInvoice VALUES('" + _invoNo + "','" + _date + "','" + _seller + "','" + _subTotal + "','" + tax + "','" + _total + "','" + _noOfQty + "','" + _cash + "','" + _change + "')", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader checkExistInvoice(string invoiceNo)
        {
            SqlCommand com = new SqlCommand("SELECT invoiceNo FROM tblInvoice WHERE invoiceNo='" + invoiceNo + "'", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public void update_Quntity(string _itemNo, int _qty)
        {
            string sql = "UPDATE tbl_Item SET noOfQty='" + _qty + "' WHERE itemNo='" + _itemNo + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.connection());
            com.ExecuteNonQuery();
        }
    }
}
