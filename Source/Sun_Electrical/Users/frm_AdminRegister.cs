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
    public partial class frm_AdminRegister : Form
    {
        public frm_AdminRegister()
        {
            InitializeComponent();
        }
        user ObjUser = new user();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPass.Text != "" && txtConfirmPass.Text != "" && cbxSecQue.Text != "" && txtAns.Text != "")
                {
      
                        if (txtPass.Text == txtConfirmPass.Text)
                        {
                            ObjUser.userRegister(txtUserName.Text, txtPass.Text, cbxSecQue.Text, txtAns.Text);
                            MessageBox.Show("User register successfully.", "REGISTER SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                        else { MessageBox.Show("Please enter same password!.", "PASSWORD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Can not be empty!.", "DETAILS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
