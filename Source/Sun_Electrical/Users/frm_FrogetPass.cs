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
    public partial class frm_FrogetPass : Form
    {
        public frm_FrogetPass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            try {
                if (txtAnswer.Text != "" && txtUserName.Text != "" && cbxSecQue.Text != "")
                {
                    SqlCommand com = new SqlCommand("SELECT password FROM tblUsers WHERE username='" + txtUserName.Text + "' AND secQu='" + cbxSecQue.Text + "' AND answer='" + txtAnswer.Text + "'", ConnectionDB.connection());
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Your password is \n \"" + dr["password"].ToString() + "\"", "PASSWORD RECOVERY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Please enter corrrect details.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show("Please enter detail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
    }
}
