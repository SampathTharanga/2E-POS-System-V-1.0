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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.BackgroundImage = Properties.Resources.invoice_hover;//Enter invoice
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.BackgroundImage = Properties.Resources.invoice;//Leave invoice
        }

        private void flowLayoutPanel2_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel2.BackgroundImage = Properties.Resources.inventory_hover;//Enter inventory
        }

        private void flowLayoutPanel2_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel2.BackgroundImage = Properties.Resources.inventory;//Leave inventory
        }

        private void flowLayoutPanel3_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel3.BackgroundImage = Properties.Resources.return_hover;//Enter return
        }

        private void flowLayoutPanel3_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel3.BackgroundImage = Properties.Resources._return;//Leave return
        }

        private void flowLayoutPanel4_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel4.BackgroundImage = Properties.Resources.users_hover;//Enter users
        }

        private void flowLayoutPanel4_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel4.BackgroundImage = Properties.Resources.Users;//Leave users
        }

        private void flowLayoutPanel5_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel5.BackgroundImage = Properties.Resources.report_hover;//Enter report
        }

        private void flowLayoutPanel5_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel5.BackgroundImage = Properties.Resources.report;//Leave report
        }

        private void flowLayoutPanel6_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel6.BackgroundImage = Properties.Resources.help_hover;//Enter help
        }

        private void flowLayoutPanel6_MouseLeave(object sender, EventArgs e)
        {
            this.flowLayoutPanel6.BackgroundImage = Properties.Resources.HELP;//Leave help
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel1.BackgroundImage = Properties.Resources.invoice_click;//Click invoice
        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel2.BackgroundImage = Properties.Resources.inventory_click;//click inventory
        }

        private void flowLayoutPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel3.BackgroundImage = Properties.Resources.return_click;//click return
        }

        private void flowLayoutPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel4.BackgroundImage = Properties.Resources.users_click;//click user
        }

        private void flowLayoutPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel5.BackgroundImage = Properties.Resources.report_click;//click report
        }

        private void flowLayoutPanel6_MouseClick(object sender, MouseEventArgs e)
        {
            this.flowLayoutPanel6.BackgroundImage = Properties.Resources.hel_click;//click help
        }
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            //New Invoice (uc_NewInvoice) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_NewInvoice.NInvoice))
            {
                pnlMain.Controls.Add(uc_NewInvoice.NInvoice);
                uc_NewInvoice.NInvoice.Dock = DockStyle.Fill;
                uc_NewInvoice.NInvoice.BringToFront();
            }
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            //New Item (uc_NewItem) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_NewItem.NItem))
            {
                pnlMain.Controls.Add(uc_NewItem.NItem);
                uc_NewItem.NItem.Dock = DockStyle.Fill;
                uc_NewItem.NItem.BringToFront();
            }
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            //New Return (uc_NewReturn) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_NewReturn.NReturn))
            {
                pnlMain.Controls.Add(uc_NewReturn.NReturn);
                uc_NewReturn.NReturn.Dock = DockStyle.Fill;
                uc_NewReturn.NReturn.BringToFront();
            }
        }

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            //New Users (uc_Users) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_Users.NUser))
            {
                pnlMain.Controls.Add(uc_Users.NUser);
                uc_Users.NUser.Dock = DockStyle.Fill;
                uc_Users.NUser.BringToFront();
            }
        }

        private void flowLayoutPanel5_Click(object sender, EventArgs e)
        {
            //New Report (uc_Report) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_Report.NReport))
            {
                pnlMain.Controls.Add(uc_Report.NReport);
                uc_Report.NReport.Dock = DockStyle.Fill;
                uc_Report.NReport.BringToFront();
            }
        }

        private void flowLayoutPanel6_Click(object sender, EventArgs e)
        {
            //Help (uc_Help) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_Help.hlp))
            {
                pnlMain.Controls.Add(uc_Help.hlp);
                uc_Help.hlp.Dock = DockStyle.Fill;
                uc_Help.hlp.BringToFront();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try {
                flowLayoutPanel4.Enabled = true;
                flowLayoutPanel5.Enabled = true;
                flowLayoutPanel3.Enabled = true;
                flowLayoutPanel6.Enabled = true;
                usersToolStripMenuItem.Enabled = true;

                //New Invoice (uc_NewInvoice) form load
                pnlMain.Controls.Clear();
                if (!pnlMain.Controls.Contains(uc_NewInvoice.NInvoice))
                {
                    pnlMain.Controls.Add(uc_NewInvoice.NInvoice);
                    uc_NewInvoice.NInvoice.Dock = DockStyle.Fill;
                    uc_NewInvoice.NInvoice.BringToFront();
                }

                //USERS CONTROL
                SqlCommand cmd = new SqlCommand("SELECT username FROM tblUsers WHERE username='" + frmLogin.userNAME + "'", ConnectionDB.connection());
                SqlDataReader dr = cmd.ExecuteReader();
                if ((frmLogin.userNAME).ToLower() == "sun")
                {
                    flowLayoutPanel4.Enabled = true;//users
                    flowLayoutPanel5.Enabled = false;//report
                    flowLayoutPanel3.Enabled = false;//return
                    flowLayoutPanel6.Enabled = false;//help
                    usersToolStripMenuItem.Enabled = true;//User view
                }
                else
                {
                    flowLayoutPanel4.Enabled = false;//users
                    flowLayoutPanel5.Enabled = false;//report
                    flowLayoutPanel3.Enabled = false;//return
                    flowLayoutPanel6.Enabled = false;//help
                    usersToolStripMenuItem.Enabled = false;//Userview
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void viewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewInvoice frminvoView = new frm_ViewInvoice();
            frminvoView.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Invoice (uc_NewInvoice) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_NewInvoice.NInvoice))
            {
                pnlMain.Controls.Add(uc_NewInvoice.NInvoice);
                uc_NewInvoice.NInvoice.Dock = DockStyle.Fill;
                uc_NewInvoice.NInvoice.BringToFront();
            }
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserUpdate frmUserOp = new frmUserUpdate();
            frmUserOp.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Users (uc_Users) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_Users.NUser))
            {
                pnlMain.Controls.Add(uc_Users.NUser);
                uc_Users.NUser.Dock = DockStyle.Fill;
                uc_Users.NUser.BringToFront();
            }
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Item (uc_NewItem) form load
            pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(uc_NewItem.NItem))
            {
                pnlMain.Controls.Add(uc_NewItem.NItem);
                uc_NewItem.NItem.Dock = DockStyle.Fill;
                uc_NewItem.NItem.BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
