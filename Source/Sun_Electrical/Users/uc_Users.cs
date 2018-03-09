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
    public partial class uc_Users : UserControl
    {
        //uc_Users for Create function
        private static uc_Users User_Instance;
        public static uc_Users NUser
        {
            get
            {
                User_Instance = null; ;
                if (User_Instance == null)
                    User_Instance = new uc_Users();
                return User_Instance;
            }
        }
        public uc_Users()
        {
            InitializeComponent();
        }

        public void reSizeDgvColumnAndTitle()
        {
            try {
                dgvUser.Columns[0].HeaderText = "User Name";
                dgvUser.Columns[1].HeaderText = "Password";
                dgvUser.Columns[2].HeaderText = "Security Question";
                dgvUser.Columns[3].HeaderText = "Answer";


                this.dgvUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dgvUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dgvUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dgvUser.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void uc_Users_Load(object sender, EventArgs e)
        {
            try {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblUsers", ConnectionDB.connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUser.DataSource = dt;
                reSizeDgvColumnAndTitle();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUser.CurrentRow.Index != -1)
                {
                    txtUsername.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                    txtPassword.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                    cbxSecQue.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                    txtAnswer.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserUpdate frmOb = new frmUserUpdate();
            frmOb.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAnswer.Text != "" && txtPassword.Text != "" && cbxSecQue.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tblUsers SET password='" + txtPassword.Text + "', secQu='" + cbxSecQue.Text + "', answer='" + txtAnswer.Text + "' WHERE username='" + txtUsername.Text + "'", ConnectionDB.connection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update completed!", "USER UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblUsers", ConnectionDB.connection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUser.DataSource = dt;

                    txtAnswer.Clear();
                    txtPassword.Clear();
                    txtUsername.Clear();
                    cbxSecQue.Text = "";
                }
                else { MessageBox.Show("Please enter details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblUsers", ConnectionDB.connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUser.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
