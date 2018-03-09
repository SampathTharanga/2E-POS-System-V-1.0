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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        user ObjUser = new user();
        public static string userNAME;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                SqlDataReader drm = ObjUser.userLogin(txtLogin.Text, txtPass.Text);
                if (drm.Read())
                {
                    userNAME = txtLogin.Text;
                    frm_Main frmMain = new frm_Main();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter correct details", "USER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtPass.Clear();
                    txtLogin.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llblAdminReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_AdminRegister frmAre = new frm_AdminRegister();
            frmAre.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try {
                String sql = "SELECT username FROM tblUsers";
                SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.connection());
                DataTable ns = new DataTable();
                get.Fill(ns);
                if (!(ns.Rows.Count > 0))
                {
                    llblAdminReg.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_FrogetPass fmFro = new frm_FrogetPass();
            fmFro.ShowDialog();
        }
    }
}
