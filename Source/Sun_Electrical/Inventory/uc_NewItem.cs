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

namespace Sun_Electrical
{
    public partial class uc_NewItem : UserControl
    {
        item objItem = new item();

        SqlDataAdapter da;

        //uc_NewItem for Create function
        private static uc_NewItem NewItem_Instance;
        public static uc_NewItem NItem
        {
            get
            {
                NewItem_Instance = null; ;
                if (NewItem_Instance == null)
                    NewItem_Instance = new uc_NewItem();
                return NewItem_Instance;
            }
        }
        public uc_NewItem()
        {
            InitializeComponent();
        }

        //DataGridView for item Data Load method.
        private void loadItemDataForDgv()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Item", ConnectionDB.connection());
            DataTable dt = new DataTable();// Datagridview  same data repeat. because Datatable object create top of this class file. therefore object create this place.
            da.Fill(dt);
            dgvItems.DataSource = dt;

            //Datagridview column headertext change.
            dgvItems.Columns[0].HeaderText = "Item No";
            dgvItems.Columns[1].HeaderText = "Description";
            dgvItems.Columns[2].HeaderText = "No of Qty";
            dgvItems.Columns[3].HeaderText = "One qty sell price";

            dgvItems.Columns[0].Width = 100;
            dgvItems.Columns[1].Width = 370;
            dgvItems.Columns[2].Width = 100;
            dgvItems.Columns[3].Width = 100;

            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige;
            dgvItems.EnableHeadersVisualStyles = false; 
        }

        int iNo;
        private void uc_NewItem_Load(object sender, EventArgs e)
        {
            try {
                //Item Number Auto Increese display the label.
                string rNo = objItem.Item_AutoNo().ToString();
                if (rNo.Equals("") || rNo == null)
                {
                    iNo = 00001;
                }
                else
                {
                    iNo = int.Parse(rNo);
                    iNo++;
                }
                if (iNo < 10) { lblItemNo.Text = "0000" + Convert.ToString(iNo); }
                else if (10 <= iNo && iNo < 100) { lblItemNo.Text = "000" + Convert.ToString(iNo); }
                else if (100 <= iNo && iNo < 1000) { lblItemNo.Text = "00" + Convert.ToString(iNo); }
                else if (1000 <= iNo && iNo < 10000) { lblItemNo.Text = "0" + Convert.ToString(iNo); }
                else lblItemNo.Text = Convert.ToString(iNo);


                //Datagridview for items load method call.
                loadItemDataForDgv();

                // to focus curser
                txtDescription.Focus();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Error provider set default point.
        public void errorProviderSetClear()
        {
            epDescription.Clear();
            epNoOfQuantity.Clear();
            ep1QtySellPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region New item add code section
            try
            {
                //++++++++++++++++ New Item Add  ++++++++++++++++
                //Error provider set default point.
                errorProviderSetClear();

            if (txtDescription.Text == "" || txtNoOfQuantity.Text == ""  || txt1QtySellPrice.Text == "" || txt1QtySellPrice.Text == "")
            {
                if (txtDescription.Text == "") { epDescription.SetError(txtDescription, "Please enter item description."); }
                if (txtNoOfQuantity.Text == "") { epNoOfQuantity.SetError(txtNoOfQuantity, "Please enter no of Quantity."); }
                if (txt1QtySellPrice.Text == "") { ep1QtySellPrice.SetError(txt1QtySellPrice, "Please enter one quantity sales price."); }

                lblNotSucc.Visible = true;
                picBxNotSucc.Visible = true;
                //MessageBox.Show("Item added not successfuly!.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if ((int.Parse(txtNoOfQuantity.Text) != 0) && (decimal.Parse(txt1QtySellPrice.Text) != 0.00M))
                {
                        if (btnAdd.Text == "Add")
                        {
                            objItem.newItemAdd(lblItemNo.Text, txtDescription.Text, int.Parse(txtNoOfQuantity.Text), decimal.Parse(txt1QtySellPrice.Text));//Here update method call, but date patameter for database item table date column datatype not use "datetime". Therefore we can use "date" datatype.
                            lblSucc.Visible = true;
                            picBxSucc.Visible = true;
                            DialogResult result = MessageBox.Show("Item added successfuly!.", "COMPLETE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                lblNotSucc.Visible = false;
                                picBxNotSucc.Visible = false;

                                lblSucc.Visible = false;
                                picBxSucc.Visible = false;

                                //Datagridview for items load method call.
                                loadItemDataForDgv();
                                //allways display datagridview last row.
                                dgvItems.CurrentCell = dgvItems.Rows[dgvItems.RowCount - 1].Cells[0];

                                //Clear all textbox function call.
                                ClearAllText(this);

                                //Item Number Auto Increese display the label.
                                string rNo = objItem.Item_AutoNo().ToString();
                                if (rNo.Equals("") || rNo == null)
                                {
                                    iNo = 00001;
                                }
                                else
                                {
                                    iNo = int.Parse(rNo);
                                    iNo++;
                                }
                                if (iNo < 10) { lblItemNo.Text = "0000" + Convert.ToString(iNo); }
                                else if (10 <= iNo && iNo < 100) { lblItemNo.Text = "000" + Convert.ToString(iNo); }
                                else if (100 <= iNo && iNo < 1000) { lblItemNo.Text = "00" + Convert.ToString(iNo); }
                                else if (1000 <= iNo && iNo < 10000) { lblItemNo.Text = "0" + Convert.ToString(iNo); }
                                else lblItemNo.Text = Convert.ToString(iNo);

                                //error provider set default.
                                errorProviderSetClear();

                                // to focus curser
                                txtDescription.Focus();
                            }

                        }
                        else if (btnAdd.Text == "Update")
                        {
                            //UPDATE ITEM LEVEL
                            int oldQty = 0;
                            SqlCommand com = new SqlCommand("SELECT noOfQty FROM tbl_Item WHERE itemNo='" + lblItemNo.Text + "'", ConnectionDB.connection());
                            SqlDataReader dr = com.ExecuteReader();
                            if (dr.Read() == true)
                            {
                                oldQty = int.Parse(dr["noOfQty"].ToString());
                                oldQty += int.Parse(txtNoOfQuantity.Text);
                            }

                            objItem.updateItem(lblItemNo.Text, txtDescription.Text, oldQty, Convert.ToDecimal(txt1QtySellPrice.Text));
                            lblSucc.Visible = true;
                            lblSucc.Text = "Item updated successfully";
                            lblSucc.ForeColor = Color.LimeGreen;
                            picBxSucc.Visible = true;
                            DialogResult result = MessageBox.Show("Item updated successfuly!.", "UPDATE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                lblNotSucc.Visible = false;
                                picBxNotSucc.Visible = false;

                                lblSucc.Visible = false;
                                picBxSucc.Visible = false;

                                //Datagridview for items load method call.
                                loadItemDataForDgv();

                                //Clear all textbox function call.
                                ClearAllText(this);

                                //Item Number Auto Increese display the label.
                                string rNo = objItem.Item_AutoNo().ToString();
                                if (rNo.Equals("") || rNo == null)
                                {
                                    iNo = 00001;
                                }
                                else
                                {
                                    iNo = int.Parse(rNo);
                                    iNo++;
                                }
                                if (iNo < 10) { lblItemNo.Text = "0000" + Convert.ToString(iNo); }
                                else if (10 <= iNo && iNo < 100) { lblItemNo.Text = "000" + Convert.ToString(iNo); }
                                else if (100 <= iNo && iNo < 1000) { lblItemNo.Text = "00" + Convert.ToString(iNo); }
                                else if (1000 <= iNo && iNo < 10000) { lblItemNo.Text = "0" + Convert.ToString(iNo); }
                                else lblItemNo.Text = Convert.ToString(iNo);

                                //Reset Add button
                                btnAdd.Text = "Add";
                                btnAdd.TextAlign = ContentAlignment.MiddleCenter;
                                btnAdd.Image = Properties.Resources.add;

                                //error provider set default.
                                errorProviderSetClear();

                                // to focus curser
                                txtDescription.Focus();
                            }
                        }
                        else { MessageBox.Show("Error"); }
                }
                else
                {
                    if (int.Parse(txtNoOfQuantity.Text) == 0) toolTip_NoOfQuantity.Show("Can not be zero.", txtNoOfQuantity, 0, -75, 2500);
                    if (decimal.Parse(txt1QtySellPrice.Text) == 0) toolTip_1QtySellPrice.Show("Can not be zero.", txt1QtySellPrice, 0, -75, 2500);
                }

            }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            #endregion
        }

        //Clear all textbox function.
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try {
                //Clear all textbox function call.
                ClearAllText(this);
                //Error provider set default point.
                errorProviderSetClear();
                //label successfully hide.
                lblSucc.Visible = false;
                picBxSucc.Visible = false;
                //label not successfully hide.
                lblNotSucc.Visible = false;
                picBxNotSucc.Visible = false;
                //Reset Add button
                btnAdd.Text = "Add";
                btnAdd.TextAlign = ContentAlignment.MiddleCenter;
                btnAdd.Image = Properties.Resources.add;
                //Reset item number for current no.
                //Item Number Auto Increese display the label.
                string rNo = objItem.Item_AutoNo().ToString();
                if (rNo.Equals("") || rNo == null)
                {
                    iNo = 00001;
                }
                else
                {
                    iNo = int.Parse(rNo);
                    iNo++;
                }
                if (iNo < 10) { lblItemNo.Text = "0000" + Convert.ToString(iNo); }
                else if (10 <= iNo && iNo < 100) { lblItemNo.Text = "000" + Convert.ToString(iNo); }
                else if (100 <= iNo && iNo < 1000) { lblItemNo.Text = "00" + Convert.ToString(iNo); }
                else if (1000 <= iNo && iNo < 10000) { lblItemNo.Text = "0" + Convert.ToString(iNo); }
                else lblItemNo.Text = Convert.ToString(iNo);

                //focus description
                txtDescription.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


        private void txtNoOfItem_Click(object sender, EventArgs e)
        {
            //select all text.
            txtNoOfQuantity.SelectAll();
        }

        private void txtNoOfItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=127)
                e.Handled = true;
        }

        private void txt1Item4PerQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txt1QtySellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 46)
                e.Handled = true;

            //Ensure validation for allow one "." value
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txt1QtySellPrice.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 && dotIndex < txt1QtySellPrice.SelectionStart && txt1QtySellPrice.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' || dotIndex != -1 || txt1QtySellPrice.Text.Length == 0 || txt1QtySellPrice.SelectionStart + 2 < txt1QtySellPrice.Text.Length;
            }
        }


        private void txt1QtySellPrice_Click(object sender, EventArgs e)
        {
            txt1QtySellPrice.SelectAll();
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            try {
                //Update item data
                if (dgvItems.CurrentRow.Index != -1)
                {
                    lblItemNo.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
                    txtDescription.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
                    txtNoOfQuantity.Text = dgvItems.CurrentRow.Cells[2].Value.ToString();
                    txt1QtySellPrice.Text = dgvItems.CurrentRow.Cells[3].Value.ToString();

                    btnAdd.Text = "Update";
                    btnAdd.TextAlign = ContentAlignment.MiddleRight;
                    btnAdd.Image = Properties.Resources.edit;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtFindItemNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //item nuber search
                string item_Filter = "SELECT * FROM tbl_Item";
                SqlDataAdapter da = new SqlDataAdapter(item_Filter, ConnectionDB.connection());
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgvItems.DataSource = bnsue;
                da.Update(dtbl);


                DataView dv = new DataView(dtbl);
                dv.RowFilter = "itemNo LIKE '%" + txtFindItemNo.Text + "%' ";
                dgvItems.DataSource = dv;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void txtFindItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) e.Handled = true;
        }
    }
}