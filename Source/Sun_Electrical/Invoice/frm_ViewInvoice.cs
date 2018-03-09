using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sun_Electrical
{
    public partial class frm_ViewInvoice : Form
    {
        public frm_ViewInvoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ViewInvoice_Load(object sender, EventArgs e)
        {
            try {
                txtInvoNo.Focus();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblInvoice", ConnectionDB.connection());
                DataTable dt = new DataTable();// Datagridview  same data repeat. because Datatable object create top of this class file. therefore object create this place.
                da.Fill(dt);
                dgvInvoiceView.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void txtInvoNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txtInvoNo.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblInvoice", ConnectionDB.connection());
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = dtbl;
                    dgvInvoiceView.DataSource = bnsue;
                    da.Update(dtbl);

                    DataView dv = new DataView(dtbl);
                    dv.RowFilter = "invoiceNo like '%" + txtInvoNo.Text + "%' ";
                    dgvInvoiceView.DataSource = dv;
                }
                //else { MessageBox.Show("Enter the item no.", "ITEM FIND", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void txtInvoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }
    }
}
