namespace Library
{
    partial class frmMaintenanceBookAuthorList
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtNumOfAuthor = new System.Windows.Forms.TextBox();
            this.txtPublicationDate = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAuthor = new System.Windows.Forms.GroupBox();
            this.txtNumOfBook = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.grpAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(310, 29);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(259, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(57, 29);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(310, 21);
            this.cmbBook.TabIndex = 0;
            this.cmbBook.Tag = "Book";
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);
            this.cmbBook.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(70, 29);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(298, 21);
            this.cmbAuthor.TabIndex = 0;
            this.cmbAuthor.Tag = "Author";
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor_SelectedIndexChanged);
            this.cmbAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.Transparent;
            this.btnLast.Image = global::Library.Properties.Resources.last;
            this.btnLast.Location = new System.Drawing.Point(500, 331);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(69, 59);
            this.btnLast.TabIndex = 42;
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
            this.btnNext.Location = new System.Drawing.Point(425, 331);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 59);
            this.btnNext.TabIndex = 41;
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
            this.btnPrevious.Location = new System.Drawing.Point(350, 331);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(69, 59);
            this.btnPrevious.TabIndex = 40;
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
            this.btnFirst.Location = new System.Drawing.Point(275, 331);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(69, 59);
            this.btnFirst.TabIndex = 39;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(560, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Azure;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(435, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(307, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(184, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtNumOfAuthor);
            this.grpBook.Controls.Add(this.txtPublicationDate);
            this.grpBook.Controls.Add(this.txtPublisher);
            this.grpBook.Controls.Add(this.label6);
            this.grpBook.Controls.Add(this.label5);
            this.grpBook.Controls.Add(this.label4);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Controls.Add(this.cmbBook);
            this.grpBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBook.Location = new System.Drawing.Point(24, 75);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(384, 188);
            this.grpBook.TabIndex = 1;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // txtNumOfAuthor
            // 
            this.txtNumOfAuthor.Enabled = false;
            this.txtNumOfAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfAuthor.Location = new System.Drawing.Point(86, 141);
            this.txtNumOfAuthor.Name = "txtNumOfAuthor";
            this.txtNumOfAuthor.ReadOnly = true;
            this.txtNumOfAuthor.Size = new System.Drawing.Size(281, 21);
            this.txtNumOfAuthor.TabIndex = 7;
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Enabled = false;
            this.txtPublicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicationDate.Location = new System.Drawing.Point(113, 106);
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.ReadOnly = true;
            this.txtPublicationDate.Size = new System.Drawing.Size(254, 21);
            this.txtPublicationDate.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Enabled = false;
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(74, 74);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(293, 21);
            this.txtPublisher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Publication Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "# of authors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Publisher:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.BackColor = System.Drawing.Color.Azure;
            this.btnGetRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecords.ForeColor = System.Drawing.Color.Black;
            this.btnGetRecords.Location = new System.Drawing.Point(577, 17);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(132, 41);
            this.btnGetRecords.TabIndex = 43;
            this.btnGetRecords.Text = "Get Records";
            this.btnGetRecords.UseVisualStyleBackColor = false;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // grpAuthor
            // 
            this.grpAuthor.Controls.Add(this.txtNumOfBook);
            this.grpAuthor.Controls.Add(this.label9);
            this.grpAuthor.Controls.Add(this.txtCategory);
            this.grpAuthor.Controls.Add(this.label8);
            this.grpAuthor.Controls.Add(this.txtPhoneNumber);
            this.grpAuthor.Controls.Add(this.label7);
            this.grpAuthor.Controls.Add(this.label3);
            this.grpAuthor.Controls.Add(this.cmbAuthor);
            this.grpAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAuthor.Location = new System.Drawing.Point(433, 75);
            this.grpAuthor.Name = "grpAuthor";
            this.grpAuthor.Size = new System.Drawing.Size(384, 188);
            this.grpAuthor.TabIndex = 44;
            this.grpAuthor.TabStop = false;
            this.grpAuthor.Text = "Author";
            // 
            // txtNumOfBook
            // 
            this.txtNumOfBook.Enabled = false;
            this.txtNumOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfBook.Location = new System.Drawing.Point(79, 141);
            this.txtNumOfBook.Name = "txtNumOfBook";
            this.txtNumOfBook.ReadOnly = true;
            this.txtNumOfBook.Size = new System.Drawing.Size(289, 21);
            this.txtNumOfBook.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "# of books:";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(88, 106);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(280, 21);
            this.txtCategory.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Main Genre:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(107, 74);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(261, 21);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number:";
            // 
            // frmMaintenanceBookAuthorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(840, 413);
            this.Controls.Add(this.grpAuthor);
            this.Controls.Add(this.btnGetRecords);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBook);
            this.Name = "frmMaintenanceBookAuthorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "AuthorList";
            this.Text = "Book\'s author list";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBookAuthorList_FormClosed);
            this.Load += new System.EventHandler(this.frmBookAuthorList_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.grpAuthor.ResumeLayout(false);
            this.grpAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetRecords;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox txtNumOfAuthor;
        private System.Windows.Forms.TextBox txtPublicationDate;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpAuthor;
        private System.Windows.Forms.TextBox txtNumOfBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
    }
}