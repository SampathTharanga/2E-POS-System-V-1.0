namespace Sun_Electrical
{
    partial class uc_NewInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxItemNo = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNoOfQuantity = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInvoiceItem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotSucc = new System.Windows.Forms.Label();
            this.lblSucc = new System.Windows.Forms.Label();
            this.picBxNotSucc = new System.Windows.Forms.PictureBox();
            this.picBxSucc = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.epItemNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNoOfQty = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSubTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCash = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNotSucc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSucc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epItemNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(335, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW INVOICE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSel);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 66);
            this.panel1.TabIndex = 1;
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSel.Location = new System.Drawing.Point(377, 37);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(0, 17);
            this.lblSel.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.ForestGreen;
            this.label26.Location = new System.Drawing.Point(165, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "EPPAWALA";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTime.Location = new System.Drawing.Point(638, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 31);
            this.lblTime.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Source Code Pro Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Crimson;
            this.label24.Location = new System.Drawing.Point(4, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(239, 34);
            this.label24.TabIndex = 6;
            this.label24.Text = "SUN ELECTRICAL";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(561, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            this.lblDate.TabIndex = 4;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.BackColor = System.Drawing.Color.White;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(377, 7);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(0, 17);
            this.lblInvoiceNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seller :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cbxItemNo);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtNoOfQuantity);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvInvoiceItem);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(16, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 268);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // cbxItemNo
            // 
            this.cbxItemNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxItemNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItemNo.FormattingEnabled = true;
            this.cbxItemNo.Location = new System.Drawing.Point(86, 24);
            this.cbxItemNo.MaxLength = 5;
            this.cbxItemNo.Name = "cbxItemNo";
            this.cbxItemNo.Size = new System.Drawing.Size(109, 21);
            this.cbxItemNo.TabIndex = 0;
            this.cbxItemNo.SelectedIndexChanged += new System.EventHandler(this.cbxItemNo_SelectedIndexChanged);
            this.cbxItemNo.TextChanged += new System.EventHandler(this.cbxItemNo_TextChanged);
            this.cbxItemNo.Click += new System.EventHandler(this.cbxItemNo_Click);
            this.cbxItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxItemNo_KeyDown);
            this.cbxItemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxItemNo_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Image = global::Sun_Electrical.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(664, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(280, 23);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 56);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtNoOfQuantity
            // 
            this.txtNoOfQuantity.Enabled = false;
            this.txtNoOfQuantity.Location = new System.Drawing.Point(547, 23);
            this.txtNoOfQuantity.MaxLength = 4;
            this.txtNoOfQuantity.Name = "txtNoOfQuantity";
            this.txtNoOfQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfQuantity.TabIndex = 1;
            this.txtNoOfQuantity.Click += new System.EventHandler(this.txtNoOfQuantity_Click);
            this.txtNoOfQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoOfQuantity_KeyDown);
            this.txtNoOfQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfQuantity_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = global::Sun_Electrical.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(664, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(461, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "No of Quantity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(213, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Item No :";
            // 
            // dgvInvoiceItem
            // 
            this.dgvInvoiceItem.AllowUserToAddRows = false;
            this.dgvInvoiceItem.AllowUserToDeleteRows = false;
            this.dgvInvoiceItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvInvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItem.Location = new System.Drawing.Point(13, 89);
            this.dgvInvoiceItem.Name = "dgvInvoiceItem";
            this.dgvInvoiceItem.ReadOnly = true;
            this.dgvInvoiceItem.Size = new System.Drawing.Size(762, 162);
            this.dgvInvoiceItem.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblNotSucc);
            this.groupBox1.Controls.Add(this.lblSucc);
            this.groupBox1.Controls.Add(this.picBxNotSucc);
            this.groupBox1.Controls.Add(this.picBxSucc);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtChange);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTax);
            this.groupBox1.Controls.Add(this.txtCash);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // lblNotSucc
            // 
            this.lblNotSucc.AutoSize = true;
            this.lblNotSucc.BackColor = System.Drawing.Color.White;
            this.lblNotSucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotSucc.ForeColor = System.Drawing.Color.Red;
            this.lblNotSucc.Location = new System.Drawing.Point(602, 95);
            this.lblNotSucc.Name = "lblNotSucc";
            this.lblNotSucc.Size = new System.Drawing.Size(159, 22);
            this.lblNotSucc.TabIndex = 19;
            this.lblNotSucc.Text = "Not Successfully";
            this.lblNotSucc.Visible = false;
            // 
            // lblSucc
            // 
            this.lblSucc.AutoSize = true;
            this.lblSucc.BackColor = System.Drawing.Color.White;
            this.lblSucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSucc.Location = new System.Drawing.Point(617, 94);
            this.lblSucc.Name = "lblSucc";
            this.lblSucc.Size = new System.Drawing.Size(122, 22);
            this.lblSucc.TabIndex = 18;
            this.lblSucc.Text = "Successfully";
            this.lblSucc.Visible = false;
            // 
            // picBxNotSucc
            // 
            this.picBxNotSucc.Image = global::Sun_Electrical.Properties.Resources.not_successfully;
            this.picBxNotSucc.Location = new System.Drawing.Point(657, 19);
            this.picBxNotSucc.Name = "picBxNotSucc";
            this.picBxNotSucc.Size = new System.Drawing.Size(50, 56);
            this.picBxNotSucc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBxNotSucc.TabIndex = 17;
            this.picBxNotSucc.TabStop = false;
            this.picBxNotSucc.Visible = false;
            // 
            // picBxSucc
            // 
            this.picBxSucc.Image = global::Sun_Electrical.Properties.Resources.successfully;
            this.picBxSucc.Location = new System.Drawing.Point(657, 24);
            this.picBxSucc.Name = "picBxSucc";
            this.picBxSucc.Size = new System.Drawing.Size(50, 45);
            this.picBxSucc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBxSucc.TabIndex = 16;
            this.picBxSucc.TabStop = false;
            this.picBxSucc.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(405, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Rs";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(405, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Rs";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(124, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Rs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(124, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Rs";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(124, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Rs";
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.DeepPink;
            this.txtBalance.Location = new System.Drawing.Point(428, 33);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(62, 13);
            this.txtBalance.TabIndex = 9;
            this.txtBalance.Text = "Cash only";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Red;
            this.txtChange.Location = new System.Drawing.Point(431, 96);
            this.txtChange.MaxLength = 10;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(147, 20);
            this.txtChange.TabIndex = 8;
            this.txtChange.Text = "0.00";
            this.txtChange.Click += new System.EventHandler(this.txtChange_Click);
            this.txtChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChange_KeyDown);
            this.txtChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChange_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTotal.Location = new System.Drawing.Point(150, 99);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(147, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0.00";
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(150, 61);
            this.txtTax.MaxLength = 10;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(147, 20);
            this.txtTax.TabIndex = 5;
            this.txtTax.Text = "0.00";
            this.txtTax.Click += new System.EventHandler(this.txtTax_Click);
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTax_KeyDown);
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCash.Location = new System.Drawing.Point(431, 61);
            this.txtCash.MaxLength = 15;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(147, 20);
            this.txtCash.TabIndex = 7;
            this.txtCash.Text = "0.00";
            this.txtCash.Click += new System.EventHandler(this.txtCash_Click);
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyDown);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Green;
            this.txtSubTotal.Location = new System.Drawing.Point(150, 26);
            this.txtSubTotal.MaxLength = 10;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(147, 20);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.Click += new System.EventHandler(this.txtSubTotal_Click);
            this.txtSubTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubTotal_KeyDown);
            this.txtSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubTotal_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(332, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Payment method :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(332, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Cash :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(58, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Inc :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(332, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Change :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(58, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tax :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sub total :";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Sun_Electrical.Properties.Resources.refresh_17x17;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(729, 552);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSell
            // 
            this.btnSell.Image = global::Sun_Electrical.Properties.Resources.sell_item;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(637, 552);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 9;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            this.btnSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSell_KeyDown);
            // 
            // epItemNo
            // 
            this.epItemNo.ContainerControl = this;
            // 
            // epNoOfQty
            // 
            this.epNoOfQty.ContainerControl = this;
            // 
            // epSubTotal
            // 
            this.epSubTotal.ContainerControl = this;
            // 
            // epTotal
            // 
            this.epTotal.ContainerControl = this;
            // 
            // epCash
            // 
            this.epCash.ContainerControl = this;
            // 
            // uc_NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Sun_Electrical.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(819, 593);
            this.MinimumSize = new System.Drawing.Size(819, 593);
            this.Name = "uc_NewInvoice";
            this.Size = new System.Drawing.Size(817, 591);
            this.Load += new System.EventHandler(this.uc_NewInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNotSucc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSucc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epItemNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNoOfQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInvoiceItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBxNotSucc;
        private System.Windows.Forms.PictureBox picBxSucc;
        private System.Windows.Forms.Label lblSucc;
        private System.Windows.Forms.Label lblNotSucc;
        private System.Windows.Forms.ComboBox cbxItemNo;
        private System.Windows.Forms.ErrorProvider epItemNo;
        private System.Windows.Forms.ErrorProvider epNoOfQty;
        private System.Windows.Forms.ErrorProvider epSubTotal;
        private System.Windows.Forms.ErrorProvider epTotal;
        private System.Windows.Forms.ErrorProvider epCash;
        private System.Windows.Forms.Label lblSel;
    }
}
