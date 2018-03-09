using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace Sun_Electrical
{
    public partial class uc_NewInvoice : UserControl
    {
        //uc_NewItem for Create function
        private static uc_NewInvoice NewInvo_Instance;
        public static uc_NewInvoice NInvoice
        {
            get
            {
                NewInvo_Instance = null; ;
                if (NewInvo_Instance == null)
                    NewInvo_Instance = new uc_NewInvoice();
                return NewInvo_Instance;
            }
        }
        public uc_NewInvoice()
        {
            InitializeComponent();
        }

        Invoice objInvo = new Invoice();
        string description = "", item_No;
        int iNo, noOfAllQty;
        decimal OneQtSellPrice = 0.00M, subTotPrice = 0.00M, totalPrice = 0.00M, defaultVal = 0.00M;

        /*||--------- METHOD/FUNCTION SECTION START ---------||*/

        #region Calculate subtotaltotal price
        public void subTotCal()
        {
            try {
                //calculate subtotaltotal price
                subTotPrice = 0.00M;
                decimal qtSubTot = 0.00M, noQt = 0.00M;
                for (int i = 0; i < dgvInvoiceItem.Rows.Count; ++i)
                {
                    qtSubTot = Convert.ToDecimal(dgvInvoiceItem.Rows[i].Cells["OneQtySellPrice"].Value.ToString());
                    noQt = Convert.ToDecimal(dgvInvoiceItem.Rows[i].Cells["noOfQty"].Value.ToString());
                    subTotPrice += noQt * qtSubTot;
                }
                txtSubTotal.Text = subTotPrice.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        #endregion

        #region tblInvoiceItems Datagridview refresh
        public void dgvRefresh()
        {
            try {
                //Datagridview refresh
                //SqlDataAdapter da = new SqlDataAdapter("SELECT ItmNo,itemDescrip,noOfQty,OneQtySellPrice FROM tblInvoiceItems", ConnectionDB.connection());
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //BindingSource bnsue = new BindingSource();
                //bnsue.DataSource = dt;
                //dgvInvoiceItem.DataSource = bnsue;
                //da.Update(dt);



                SqlDataAdapter da = new SqlDataAdapter("SELECT ItmNo,itemDescrip,noOfQty,OneQtySellPrice FROM tblInvoiceItems", ConnectionDB.connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInvoiceItem.DataSource = dt;


                dgvInvoiceItem.Columns["ItmNo"].HeaderText = "Item No";
                dgvInvoiceItem.Columns["itemDescrip"].HeaderText = "Descreption";
                dgvInvoiceItem.Columns["noOfQty"].HeaderText = "No. Of Quantity";
                dgvInvoiceItem.Columns["OneQtySellPrice"].HeaderText = "One Qty Sell Price";


                this.dgvInvoiceItem.Columns["ItmNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dgvInvoiceItem.Columns["itemDescrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dgvInvoiceItem.Columns["noOfQty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dgvInvoiceItem.Columns["OneQtySellPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        #endregion

        #region Total price Calculate with tax.
        public void totalPriceCalculate()
        {
            try {
                if (decimal.TryParse(txtSubTotal.Text, out defaultVal) && decimal.TryParse(txtTax.Text, out defaultVal))
                {
                    totalPrice = Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtSubTotal.Text);
                    txtTotal.Text = totalPrice.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        #endregion

        /*||--------- METHOD/FUNCTION SECTION END ----------||*/


        private void uc_NewInvoice_Load(object sender, EventArgs e)
        {
            try {
                noOfAllQty = 0;

                lblTime.Text = DateTime.Now.ToShortTimeString();
                lblSel.Text = frmLogin.userNAME;

                cbxItemNo.Focus();

                //clear table
                string sqlTrunc = "TRUNCATE TABLE " + "tblInvoiceItems";
                SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.connection());
                cmd.ExecuteNonQuery();

                //Today date display.
                lblDate.Text = DateTime.Today.ToShortDateString();

                //Item Number Auto Increese display the label.
                string rNo = objInvo.invoNo_AutoNo();
                if (rNo.Equals("") || rNo == null)
                {
                    iNo = 00001;
                }
                else
                {
                    iNo = int.Parse(rNo);
                    iNo++;
                }
                if (iNo < 10) { lblInvoiceNo.Text = "00000" + Convert.ToString(iNo); }
                else if (10 <= iNo && iNo < 100) { lblInvoiceNo.Text = "0000" + Convert.ToString(iNo); }
                else if (100 <= iNo && iNo < 1000) { lblInvoiceNo.Text = "000" + Convert.ToString(iNo); }
                else if (1000 <= iNo && iNo < 10000) { lblInvoiceNo.Text = "00" + Convert.ToString(iNo); }
                else if (10000 <= iNo && iNo < 100000) { lblInvoiceNo.Text = "0" + Convert.ToString(iNo); }
                else lblInvoiceNo.Text = Convert.ToString(iNo);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try {
                //calculate change and cash
                if (decimal.TryParse(txtCash.Text, out defaultVal) && decimal.TryParse(txtTotal.Text, out defaultVal))
                    txtChange.Text = (Convert.ToDecimal(txtCash.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            try {
                if (decimal.TryParse(txtTax.Text, out defaultVal) && decimal.TryParse(txtSubTotal.Text, out defaultVal))
                    txtTotal.Text = (Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtTax.Text)).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void cbxItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txtNoOfQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                e.Handled = true;

            ////Ensure validation for allow one "." value
            //if (!char.IsControl(e.KeyChar))
            //{
            //    int dotIndex = txtSubTotal.Text.IndexOf('.');
            //    if (char.IsDigit(e.KeyChar))
            //    {
            //        if (dotIndex != -1 && dotIndex < txtSubTotal.SelectionStart && txtSubTotal.Text.Substring(dotIndex + 1).Length >= 2)
            //        {
            //            e.Handled = true;
            //        }
            //    }
            //    else
            //        e.Handled = e.KeyChar != '.' || dotIndex != -1 || txtSubTotal.Text.Length == 0 || txtSubTotal.SelectionStart + 2 < txtSubTotal.Text.Length;
            //}
        }

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                    e.Handled = true;

                //Ensure validation for allow one "." value
                if (!char.IsControl(e.KeyChar))
                {
                    int dotIndex = txtTax.Text.IndexOf('.');
                    if (char.IsDigit(e.KeyChar))
                    {
                        if (dotIndex != -1 && dotIndex < txtTax.SelectionStart && txtTax.Text.Substring(dotIndex + 1).Length >= 2)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                        e.Handled = e.KeyChar != '.' || dotIndex != -1 || txtTax.Text.Length == 0 || txtTax.SelectionStart + 2 < txtTax.Text.Length;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                e.Handled = true;

            ////Ensure validation for allow one "." value
            //if (!char.IsControl(e.KeyChar))
            //{
            //    int dotIndex = txtTotal.Text.IndexOf('.');
            //    if (char.IsDigit(e.KeyChar))
            //    {
            //        if (dotIndex != -1 && dotIndex < txtTotal.SelectionStart && txtTotal.Text.Substring(dotIndex + 1).Length >= 2)
            //        {
            //            e.Handled = true;
            //        }
            //    }
            //    else
            //        e.Handled = e.KeyChar != '.' || dotIndex != -1 || txtTotal.Text.Length == 0 || txtTotal.SelectionStart + 2 < txtTotal.Text.Length;
            //}
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                    e.Handled = true;

                //Ensure validation for allow one "." value
                if (!char.IsControl(e.KeyChar))
                {
                    int dotIndex = txtCash.Text.IndexOf('.');
                    if (char.IsDigit(e.KeyChar))
                    {
                        if (dotIndex != -1 && dotIndex < txtCash.SelectionStart && txtCash.Text.Substring(dotIndex + 1).Length >= 2)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                        e.Handled = e.KeyChar != '.' || dotIndex != -1 || txtCash.Text.Length == 0 || txtCash.SelectionStart + 2 < txtCash.Text.Length;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void txtChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                e.Handled = true;

            ////Ensure validation for allow one "." value
            //if (!char.IsControl(e.KeyChar))
            //{
            //    int dotIndex = txtChange.Text.IndexOf('.');
            //    if (char.IsDigit(e.KeyChar))
            //    {
            //        if (dotIndex != -1 && dotIndex < txtChange.SelectionStart && txtChange.Text.Substring(dotIndex + 1).Length >= 2)
            //        {
            //            e.Handled = true;
            //        }
            //    }
            //    else
            //        e.Handled = e.KeyChar != '.' || dotIndex != -1 || txtChange.Text.Length == 0 || txtChange.SelectionStart + 2 < txtChange.Text.Length;
            //}
        }

        private void txtSubTotal_Click(object sender, EventArgs e)
        {
            txtSubTotal.SelectAll();
        }

        private void txtTax_Click(object sender, EventArgs e)
        {
            txtTax.SelectAll();
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {
            txtTotal.SelectAll();
        }

        private void txtCash_Click(object sender, EventArgs e)
        {
            txtCash.SelectAll();
        }

        private void txtChange_Click(object sender, EventArgs e)
        {
            txtChange.SelectAll();
        }

        private void txtNoOfQuantity_Click(object sender, EventArgs e)
        {
            try {
                txtNoOfQuantity.SelectAll();
                item_No = objInvo.itemMaxNo();
                if (int.Parse(cbxItemNo.Text) <= int.Parse(item_No))
                {
                    //item price and other details get
                    string OneQtSellPrice1;
                    SqlCommand cmd = new SqlCommand("SELECT description,OneQtySellPrice FROM tbl_Item WHERE itemNo='" + cbxItemNo.Text + "'", ConnectionDB.connection());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read() == true)
                    {
                        description = dr["description"].ToString();// This one can use only 0 inedex -->  dr[0].ToString()
                        OneQtSellPrice1 = dr["OneQtySellPrice"].ToString();
                        OneQtSellPrice = Convert.ToDecimal(OneQtSellPrice1);
                        txtDescription.Text = description;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("This item not exist!.", "ITEM DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                        cbxItemNo.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void cbxItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (cbxItemNo.Text != "")
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        //item description get txt box
                        item_No = objInvo.itemMaxNo();
                        if (int.Parse(cbxItemNo.Text) <= int.Parse(item_No))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT description FROM tbl_Item WHERE itemNo='" + cbxItemNo.Text + "'", ConnectionDB.connection());
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read() == true)
                            {
                                txtDescription.Text = dr["description"].ToString();
                            }
                            txtNoOfQuantity.Focus();
                            txtNoOfQuantity.SelectAll();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("This item not exist!.", "ITEM DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                                cbxItemNo.Focus();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void cbxItemNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNoOfQuantity.Clear();

                if (cbxItemNo.Text != "")
                    txtNoOfQuantity.Enabled = true;

                if (cbxItemNo.Text == "")
                    txtNoOfQuantity.Enabled = false;

                //Discription get the txt box
                string sqlQuer = "SELECT description,OneQtySellPrice FROM tbl_Item WHERE itemNo='" + cbxItemNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuer, ConnectionDB.connection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtDescription.Text = dr["description"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtNoOfQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.Focus();
        }

        private void txtTax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTotal.Focus();
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCash.Focus();
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtChange.Focus();
        }

        private void txtChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSell.Focus();
        }

        private void btnSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReset.Focus();
        }

        private void txtSubTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTax.Focus();
        }

        //BILL PRINT TABLE VVALUE ADD
        public void billPrint()
        {
            try
            {
                //clear table
                string sqlTrunc1 = "TRUNCATE TABLE " + "tblBIllPrintItem";
                SqlCommand cmd22 = new SqlCommand(sqlTrunc1, ConnectionDB.connection());
                cmd22.ExecuteNonQuery();
                //clear table
                string sqlTrunc2 = "TRUNCATE TABLE " + "tblBillPrintPrice";
                SqlCommand cmd33 = new SqlCommand(sqlTrunc2, ConnectionDB.connection());
                cmd33.ExecuteNonQuery();




                //BILL PRINT ITEM DETAIL 
                String sql = "SELECT * FROM tblInvoiceItems";
                SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.connection());
                DataTable ns = new DataTable();
                get.Fill(ns);
                for (int i = 0; i < ns.Rows.Count; i++)
                {
                    string itemNo = ns.Rows[i]["ItmNo"].ToString();
                    string itemDescrip = ns.Rows[i]["itemDescrip"].ToString();
                    int noOfQty = int.Parse(ns.Rows[i]["noOfQty"].ToString());
                    decimal OneQtySellPrice = Convert.ToDecimal(ns.Rows[i]["OneQtySellPrice"].ToString());
                    SqlCommand cmd112 = new SqlCommand(@"INSERT INTO tblBIllPrintItem VALUES('" + itemNo + "','" + itemDescrip + "','" + noOfQty + "','" + OneQtySellPrice + "')", ConnectionDB.connection());
                    cmd112.ExecuteNonQuery();

                }
                //BILL PRINT PRICE DETAIL 
                String _sq1l = "SELECT * FROM tblInvoice WHERE invoiceNo='" + lblInvoiceNo.Text + "'";
                SqlCommand cmd = new SqlCommand(_sq1l, ConnectionDB.connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    string seller = dr["seller"].ToString();//06
                    decimal subTotal = Convert.ToDecimal(dr["subTotal"].ToString());//07
                    decimal tax = Convert.ToDecimal(dr["tax"].ToString());//08
                    decimal toatal = Convert.ToDecimal(dr["toatal"].ToString());//09
                    int noOfQty = int.Parse(dr["noOfQty"].ToString());//10
                    decimal cash = Convert.ToDecimal(dr["cash"].ToString());//11
                    decimal change = decimal.Parse(dr["change"].ToString());//12

                    SqlCommand cmdo = new SqlCommand(@"INSERT INTO tblBillPrintPrice VALUES('" + lblInvoiceNo.Text + "','" + subTotal + "','" + tax + "','" + toatal + "','" + noOfQty + "','" + cash + "','" + change + "','" + seller + "')", ConnectionDB.connection());
                    cmdo.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                noOfAllQty = 0;//All Quantity Start Zero

                epCash.Clear();
                epSubTotal.Clear();
                epTotal.Clear();

                if (txtCash.Text != "0.00" && txtTotal.Text != "0.00" && txtSubTotal.Text != "0.00")
                {
                    if (decimal.Parse(txtCash.Text) >= decimal.Parse(txtTotal.Text))
                    {
                        SqlDataReader dr = objInvo.checkExistInvoice(lblInvoiceNo.Text);
                        if (!dr.Read())
                        {
                            //COPY tblInvoiceItems VALUE TO tblInvoBillItem
                            String copyData = "INSERT INTO tblInvoBillItem SELECT * FROM tblInvoiceItems";
                            SqlCommand cmd = new SqlCommand(copyData, ConnectionDB.connection());
                            cmd.ExecuteNonQuery();


                            //TOTAL ALL QUANTITY CALCULATE
                            String sql = "SELECT noOfQty FROM tblInvoiceItems";
                            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.connection());
                            DataTable ns = new DataTable();
                            get.Fill(ns);
                            for (int i = 0; i < ns.Rows.Count; i++)
                            {
                                string qty = ns.Rows[i]["noOfQty"].ToString();
                                noOfAllQty += int.Parse(qty);
                            }


                            //INSERT INVOICE DETAILS
                            objInvo.newInvoce(
                                lblInvoiceNo.Text,
                                DateTime.Today,
                                lblSel.Text,
                                decimal.Parse(txtSubTotal.Text),
                                decimal.Parse(txtTax.Text),
                                decimal.Parse(txtTotal.Text),
                                noOfAllQty,
                                decimal.Parse(txtCash.Text),
                                decimal.Parse(txtChange.Text)
                                );


                            //SELL ITEM REMOVE STOCK
                            String isql = "SELECT * FROM tblInvoiceItems";
                            SqlDataAdapter iget = new SqlDataAdapter(isql, ConnectionDB.connection());
                            DataTable idt = new DataTable();
                            iget.Fill(idt);
                            for (int i = 0; i < idt.Rows.Count; i++)
                            {
                                int nowAllQty = 0;
                                //decimal subtotal = 0.0M;

                                string item_no = idt.Rows[i]["ItmNo"].ToString();
                                int noOfQuantity = int.Parse(idt.Rows[i]["noOfQty"].ToString());

                                string csql = "SELECT * FROM tbl_Item WHERE itemNo='" + item_no + "'";
                                SqlCommand cmdi = new SqlCommand(csql, ConnectionDB.connection());
                                SqlDataReader dr1 = cmdi.ExecuteReader();
                                while (dr1.Read() == true)
                                {
                                    int stock_noOfQty = int.Parse(dr1["noOfQty"].ToString());
                                    decimal old_OneQtySellPrice = decimal.Parse(dr1["OneQtySellPrice"].ToString());

                                    //now stock item
                                    nowAllQty = stock_noOfQty - noOfQuantity;

                                    //stock update
                                    objInvo.update_Quntity(item_no, nowAllQty);

                                    //success
                                    picBxSucc.Visible = true;
                                    lblSucc.Visible = true;
                                    picBxNotSucc.Visible = false;
                                    lblNotSucc.Visible = false;

                                    //reset();
                                }
                            }

                        }
                        billPrint();
                        btnSell.Enabled = false;


                        //frmFinalBill frmBill = new frmFinalBill();
                        //frmBill.ShowDialog();


                        CrystalReport1_Bill objCrystal = new CrystalReport1_Bill();
                        objCrystal.PrintToPrinter(1, false,0,0);


                        btnSell.Enabled = true;
                        reset();

                    }
                    else { MessageBox.Show("Please fully payement!", "BILL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else
                {
                    if (txtCash.Text == "0.00") epCash.SetError(txtCash, "Can not be null.");
                    if (txtTotal.Text == "0.00") epSubTotal.SetError(txtSubTotal, "Can not be null.");
                    if (txtSubTotal.Text == "0.00") epTotal.SetError(txtTotal, "Can not be null.");
                    picBxSucc.Visible = false;
                    lblSucc.Visible = false;
                    picBxNotSucc.Visible = true;
                    lblNotSucc.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        public void reset()
        {
            try {
                //clear table
                string sqlTrunc = "TRUNCATE TABLE " + "tblInvoiceItems";
                SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.connection());
                cmd.ExecuteNonQuery();

                //Item Number Auto Increese display the label.
                string rNo = objInvo.invoNo_AutoNo();
                if (rNo.Equals("") || rNo == null)
                {
                    iNo = 00001;
                }
                else
                {
                    iNo = int.Parse(rNo);
                    iNo++;
                }
                if (iNo < 10) { lblInvoiceNo.Text = "00000" + Convert.ToString(iNo); }
                else if (10 <= iNo && iNo < 100) { lblInvoiceNo.Text = "0000" + Convert.ToString(iNo); }
                else if (100 <= iNo && iNo < 1000) { lblInvoiceNo.Text = "000" + Convert.ToString(iNo); }
                else if (1000 <= iNo && iNo < 10000) { lblInvoiceNo.Text = "00" + Convert.ToString(iNo); }
                else if (10000 <= iNo && iNo < 100000) { lblInvoiceNo.Text = "0" + Convert.ToString(iNo); }
                else lblInvoiceNo.Text = Convert.ToString(iNo);

                picBxSucc.Visible = false;
                lblSucc.Visible = false;
                picBxNotSucc.Visible = false;
                lblNotSucc.Visible = false;

                txtCash.Text = "0.00";
                txtTotal.Text = "0.00";
                txtSubTotal.Text = "0.00"; ;
                txtTax.Text = "0.00";
                txtChange.Text = "0.00";

                dgvRefresh();

                epNoOfQty.Clear();
                epItemNo.Clear();
                epCash.Clear();
                epSubTotal.Clear();
                epTotal.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            try {
                reset();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxItemNo_Click(object sender, EventArgs e)
        {
            epNoOfQty.Clear();
            epItemNo.Clear();
            cbxItemNo.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoOfQuantity.Text != "" && cbxItemNo.Text != "")
                {
                    if (int.Parse(txtNoOfQuantity.Text) != 0)
                    {
                        //ITEM LOAD GRIDVIEW START
                        txtNoOfQuantity.SelectAll();
                        item_No = objInvo.itemMaxNo();
                        if (int.Parse(cbxItemNo.Text) <= int.Parse(item_No))
                        {
                            //item price and other details get
                            string OneQtSellPrice1;
                            SqlCommand cmd = new SqlCommand("SELECT description,OneQtySellPrice FROM tbl_Item WHERE itemNo='" + cbxItemNo.Text + "'", ConnectionDB.connection());
                            SqlDataReader dr1 = cmd.ExecuteReader();
                            while (dr1.Read() == true)
                            {
                                description = dr1["description"].ToString();// This one can use only 0 inedex -->  dr[0].ToString()
                                OneQtSellPrice1 = dr1["OneQtySellPrice"].ToString();
                                OneQtSellPrice = Convert.ToDecimal(OneQtSellPrice1);
                                txtDescription.Text = description;
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("This item not exist!.", "ITEM DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                                cbxItemNo.Focus();
                        }
                        //ITEM LOAD GRIDVIEW END


                        epNoOfQty.Clear();
                        epItemNo.Clear();

                        int intVal = 0;
                        //Add item for invoice

                        //item exist checking
                        SqlDataReader dr = objInvo.checkExistItem(cbxItemNo.Text);
                        if (!dr.Read())
                        {
                            //Stock quantity check and add it for invoice table
                            SqlDataReader drm = objInvo.select_to_Qntity(cbxItemNo.Text);
                            if (drm.Read())
                            {
                                if (int.TryParse(txtNoOfQuantity.Text, out intVal))
                                {
                                    int qty = int.Parse(drm["noOfQty"].ToString());
                                    if (int.Parse(txtNoOfQuantity.Text) <= qty)
                                    {
                                        objInvo.newInvoItemAdd(lblInvoiceNo.Text, cbxItemNo.Text, description, int.Parse(txtNoOfQuantity.Text), OneQtSellPrice);
                                    }
                                    else { MessageBox.Show("Not enought Quantity in the stock!. Available Quantity are " + qty.ToString(), "STOCK LEVEL", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                                }
                            }
                            else MessageBox.Show("Does not exist this item!.", "ITEM EXIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show("This item is exist!.", "ITEM EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxItemNo.Focus();


                        //Datagridview refresh
                        dgvRefresh();

                        //calculate subtotaltotal price
                        subTotCal();

                        //Calculate total price
                        totalPriceCalculate();


                        cbxItemNo.Items.Clear();
                        cbxItemNo.Text = "";
                        txtNoOfQuantity.Clear();
                        txtDescription.Clear();
                    }
                    else epNoOfQty.SetError(txtNoOfQuantity, "Can not be Zero!");
                }
                else
                {
                    if (cbxItemNo.Text == "") epItemNo.SetError(cbxItemNo, "Enter the correct item number!");
                    if (txtNoOfQuantity.Text == "") epNoOfQty.SetError(txtNoOfQuantity, "Enter the no of quantity!");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); cbxItemNo.Focus(); }
}

        private void cbxItemNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                string OneQtSellPrice1="";
                string sqlQuer = "SELECT description,OneQtySellPrice FROM tbl_Item WHERE itemNo='" + cbxItemNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuer, ConnectionDB.connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    description = dr["description"].ToString();// This one can use only 0 inedex -->  dr[0].ToString()
                    OneQtSellPrice1 = dr["OneQtySellPrice"].ToString();
                    OneQtSellPrice = Convert.ToDecimal(OneQtSellPrice1);
                    txtDescription.Text = description;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoiceItem.Rows.Count != 0)
                {
                    //Delete item in invoice item table
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblInvoiceItems WHERE ItmNo='" + dgvInvoiceItem.CurrentRow.Cells["ItmNo"].Value.ToString() + "'", ConnectionDB.connection());
                    cmd.ExecuteNonQuery();
                }
                else { MessageBox.Show("Items are empty!. Please add items.", "SELL ITEMS DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                //Datagridview refresh
                dgvRefresh();

                //calculate subtotaltotal price
                subTotCal();

                //Calculate total price
                totalPriceCalculate();

                cbxItemNo.Items.Clear();
                cbxItemNo.Text = "";
                txtNoOfQuantity.Clear();
                txtDescription.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
