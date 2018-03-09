namespace Sun_Electrical
{
    partial class uc_NewItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_NewItem));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNotSucc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBxNotSucc = new System.Windows.Forms.PictureBox();
            this.txt1QtySellPrice = new System.Windows.Forms.TextBox();
            this.lblSucc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picBxSucc = new System.Windows.Forms.PictureBox();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNoOfQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.epDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep1QtySellPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNoOfQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_NoOfQuantity = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_1QtySellPrice = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindItemNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNotSucc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSucc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1QtySellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(352, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW ITEM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblNotSucc);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.picBxNotSucc);
            this.groupBox1.Controls.Add(this.txt1QtySellPrice);
            this.groupBox1.Controls.Add(this.lblSucc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.picBxSucc);
            this.groupBox1.Controls.Add(this.lblItemNo);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtNoOfQuantity);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(584, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Rs";
            // 
            // lblNotSucc
            // 
            this.lblNotSucc.AutoSize = true;
            this.lblNotSucc.BackColor = System.Drawing.Color.Transparent;
            this.lblNotSucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotSucc.ForeColor = System.Drawing.Color.Crimson;
            this.lblNotSucc.Location = new System.Drawing.Point(280, 123);
            this.lblNotSucc.Name = "lblNotSucc";
            this.lblNotSucc.Size = new System.Drawing.Size(260, 22);
            this.lblNotSucc.TabIndex = 10;
            this.lblNotSucc.Text = "Item added not Successfully";
            this.lblNotSucc.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(385, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 100);
            this.panel1.TabIndex = 14;
            // 
            // picBxNotSucc
            // 
            this.picBxNotSucc.Image = ((System.Drawing.Image)(resources.GetObject("picBxNotSucc.Image")));
            this.picBxNotSucc.Location = new System.Drawing.Point(246, 119);
            this.picBxNotSucc.Name = "picBxNotSucc";
            this.picBxNotSucc.Size = new System.Drawing.Size(30, 30);
            this.picBxNotSucc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxNotSucc.TabIndex = 9;
            this.picBxNotSucc.TabStop = false;
            this.picBxNotSucc.Visible = false;
            // 
            // txt1QtySellPrice
            // 
            this.txt1QtySellPrice.Location = new System.Drawing.Point(606, 62);
            this.txt1QtySellPrice.MaxLength = 10;
            this.txt1QtySellPrice.Name = "txt1QtySellPrice";
            this.txt1QtySellPrice.Size = new System.Drawing.Size(123, 20);
            this.txt1QtySellPrice.TabIndex = 2;
            this.txt1QtySellPrice.Click += new System.EventHandler(this.txt1QtySellPrice_Click);
            this.txt1QtySellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1QtySellPrice_KeyPress);
            // 
            // lblSucc
            // 
            this.lblSucc.AutoSize = true;
            this.lblSucc.BackColor = System.Drawing.Color.Transparent;
            this.lblSucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSucc.Location = new System.Drawing.Point(281, 120);
            this.lblSucc.Name = "lblSucc";
            this.lblSucc.Size = new System.Drawing.Size(226, 22);
            this.lblSucc.TabIndex = 8;
            this.lblSucc.Text = "Item added Successfully";
            this.lblSucc.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(441, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "One Qantity Sales Price :";
            // 
            // picBxSucc
            // 
            this.picBxSucc.Image = ((System.Drawing.Image)(resources.GetObject("picBxSucc.Image")));
            this.picBxSucc.Location = new System.Drawing.Point(245, 120);
            this.picBxSucc.Name = "picBxSucc";
            this.picBxSucc.Size = new System.Drawing.Size(30, 30);
            this.picBxSucc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxSucc.TabIndex = 7;
            this.picBxSucc.TabStop = false;
            this.picBxSucc.Visible = false;
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.BackColor = System.Drawing.Color.White;
            this.lblItemNo.Location = new System.Drawing.Point(145, 30);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(0, 13);
            this.lblItemNo.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Sun_Electrical.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(560, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Sun_Electrical.Properties.Resources.refresh_17x17;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(654, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNoOfQuantity
            // 
            this.txtNoOfQuantity.Location = new System.Drawing.Point(587, 26);
            this.txtNoOfQuantity.MaxLength = 5;
            this.txtNoOfQuantity.Name = "txtNoOfQuantity";
            this.txtNoOfQuantity.Size = new System.Drawing.Size(142, 20);
            this.txtNoOfQuantity.TabIndex = 1;
            this.txtNoOfQuantity.Click += new System.EventHandler(this.txtNoOfItem_Click);
            this.txtNoOfQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfItem_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 58);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 48);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "No of Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item No :";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(15, 19);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(751, 287);
            this.dgvItems.TabIndex = 3;
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvItems);
            this.groupBox3.Location = new System.Drawing.Point(18, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 325);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // epDescription
            // 
            this.epDescription.ContainerControl = this;
            // 
            // ep1QtySellPrice
            // 
            this.ep1QtySellPrice.ContainerControl = this;
            // 
            // epNoOfQuantity
            // 
            this.epNoOfQuantity.ContainerControl = this;
            // 
            // toolTip_NoOfQuantity
            // 
            this.toolTip_NoOfQuantity.IsBalloon = true;
            this.toolTip_NoOfQuantity.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_NoOfQuantity.ToolTipTitle = "No of item error";
            // 
            // toolTip_1QtySellPrice
            // 
            this.toolTip_1QtySellPrice.IsBalloon = true;
            this.toolTip_1QtySellPrice.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_1QtySellPrice.ToolTipTitle = "One qty sell price error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(21, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search Item No :";
            // 
            // txtFindItemNo
            // 
            this.txtFindItemNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFindItemNo.Location = new System.Drawing.Point(114, 216);
            this.txtFindItemNo.MaxLength = 6;
            this.txtFindItemNo.Name = "txtFindItemNo";
            this.txtFindItemNo.Size = new System.Drawing.Size(100, 20);
            this.txtFindItemNo.TabIndex = 1;
            this.txtFindItemNo.TextChanged += new System.EventHandler(this.txtFindItemNo_TextChanged);
            this.txtFindItemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemNo_KeyPress);
            // 
            // uc_NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sun_Electrical.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFindItemNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(819, 593);
            this.MinimumSize = new System.Drawing.Size(819, 593);
            this.Name = "uc_NewItem";
            this.Size = new System.Drawing.Size(817, 591);
            this.Load += new System.EventHandler(this.uc_NewItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNotSucc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSucc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1QtySellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoOfQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1QtySellPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBxSucc;
        private System.Windows.Forms.Label lblSucc;
        private System.Windows.Forms.Label lblNotSucc;
        private System.Windows.Forms.PictureBox picBxNotSucc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider epDescription;
        private System.Windows.Forms.ErrorProvider ep1QtySellPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider epNoOfQuantity;
        private System.Windows.Forms.ToolTip toolTip_NoOfQuantity;
        private System.Windows.Forms.ToolTip toolTip_1QtySellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFindItemNo;
    }
}
