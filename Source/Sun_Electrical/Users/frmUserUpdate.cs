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
    public partial class frmUserUpdate : Form
    {
        public frmUserUpdate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        user ObjUser = new user();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserNam.Text != "" && txtPassw.Text != "" && txtConfirmPas.Text != "" && cbxSecQues.Text != "" && txtAnsw.Text != "")
                {
                    SqlCommand com = new SqlCommand("SELECT username FROM tblUsers WHERE username='" + txtUserNam.Text + "'", ConnectionDB.connection());
                    SqlDataReader dr = com.ExecuteReader();
                    if (!dr.Read() == true)
                    {
                        if (txtPassw.Text == txtConfirmPas.Text)
                        {
                            ObjUser.userRegister(txtUserNam.Text, txtPassw.Text, cbxSecQues.Text, txtAnsw.Text);
                            MessageBox.Show("User register successfully.", "REGISTER SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else { MessageBox.Show("Please enter same password!.", "PASSWORD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("This user exisiting!. Please change Username", "PASSWORD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); txtUserNam.Clear(); }

                }
                else { MessageBox.Show("Can not be empty!.", "DETAILS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
