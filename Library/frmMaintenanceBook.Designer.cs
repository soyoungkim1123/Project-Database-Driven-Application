namespace Library
{
    partial class frmMaintenanceBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPublicateDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.Transparent;
            this.btnLast.Image = global::Library.Properties.Resources.last;
            this.btnLast.Location = new System.Drawing.Point(366, 550);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(69, 59);
            this.btnLast.TabIndex = 26;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = global::Library.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(291, 550);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 59);
            this.btnNext.TabIndex = 25;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Image = global::Library.Properties.Resources.previous;
            this.btnPrevious.Location = new System.Drawing.Point(216, 550);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(69, 59);
            this.btnPrevious.TabIndex = 24;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirst.Image = global::Library.Properties.Resources.first;
            this.btnFirst.Location = new System.Drawing.Point(141, 550);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(69, 59);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // dtpPublicateDate
            // 
            this.dtpPublicateDate.Location = new System.Drawing.Point(141, 252);
            this.dtpPublicateDate.Name = "dtpPublicateDate";
            this.dtpPublicateDate.Size = new System.Drawing.Size(356, 20);
            this.dtpPublicateDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Publicate Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Avaliable:";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(141, 331);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 8;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "ISBN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Publisher:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(139, 367);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(358, 21);
            this.cmbCategory.TabIndex = 12;
            this.cmbCategory.Tag = "Category";
            this.cmbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(142, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(358, 20);
            this.txtTitle.TabIndex = 13;
            this.txtTitle.Tag = "Title";
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(142, 97);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(358, 91);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Tag = "Description";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(142, 211);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(358, 20);
            this.txtEdition.TabIndex = 15;
            this.txtEdition.Tag = "Edition";
            this.txtEdition.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 290);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(358, 20);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.Tag = "Price";
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(142, 24);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(358, 20);
            this.txtISBN.TabIndex = 17;
            this.txtISBN.Tag = "ISBN";
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(139, 408);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(358, 20);
            this.txtPublisher.TabIndex = 18;
            this.txtPublisher.Tag = "Publisher";
            this.txtPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(50, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(179, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Azure;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(312, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(439, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.txtPublisher);
            this.grpBookInfo.Controls.Add(this.label2);
            this.grpBookInfo.Controls.Add(this.label3);
            this.grpBookInfo.Controls.Add(this.label4);
            this.grpBookInfo.Controls.Add(this.label5);
            this.grpBookInfo.Controls.Add(this.dtpPublicateDate);
            this.grpBookInfo.Controls.Add(this.label6);
            this.grpBookInfo.Controls.Add(this.label7);
            this.grpBookInfo.Controls.Add(this.chkAvailable);
            this.grpBookInfo.Controls.Add(this.label8);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.label9);
            this.grpBookInfo.Controls.Add(this.txtPrice);
            this.grpBookInfo.Controls.Add(this.label10);
            this.grpBookInfo.Controls.Add(this.txtEdition);
            this.grpBookInfo.Controls.Add(this.cmbCategory);
            this.grpBookInfo.Controls.Add(this.txtDescription);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Location = new System.Drawing.Point(32, 51);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(524, 445);
            this.grpBookInfo.TabIndex = 27;
            this.grpBookInfo.TabStop = false;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmMaintenanceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(599, 623);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "frmMaintenanceBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMaintenanceBook_FormClosed);
            this.Load += new System.EventHandler(this.frmMaintenanceBook_Load);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPublicateDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
    }
}