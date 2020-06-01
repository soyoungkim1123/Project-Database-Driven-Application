namespace Library
{
    partial class frmBrowseAuthors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lbContactNumber = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAward = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.lbNumOfBook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.grpProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 16;
            this.lstCategory.Location = new System.Drawing.Point(12, 72);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(174, 452);
            this.lstCategory.TabIndex = 49;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lbContactNumber
            // 
            this.lbContactNumber.AutoSize = true;
            this.lbContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactNumber.Location = new System.Drawing.Point(134, 38);
            this.lbContactNumber.Name = "lbContactNumber";
            this.lbContactNumber.Size = new System.Drawing.Size(0, 17);
            this.lbContactNumber.TabIndex = 41;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(134, 14);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(0, 17);
            this.lbFullName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Full Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Contact Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbContactNumber);
            this.panel1.Controls.Add(this.lbFullName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbAward);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(192, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 90);
            this.panel1.TabIndex = 48;
            // 
            // lbAward
            // 
            this.lbAward.AutoSize = true;
            this.lbAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAward.Location = new System.Drawing.Point(134, 61);
            this.lbAward.Name = "lbAward";
            this.lbAward.Size = new System.Drawing.Size(0, 17);
            this.lbAward.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Award:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 39);
            this.label4.TabIndex = 47;
            this.label4.Text = "Browse Authors";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(192, 266);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(640, 260);
            this.dgvBooks.TabIndex = 45;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(72, 29);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(395, 21);
            this.cmbAuthor.TabIndex = 17;
            this.cmbAuthor.Tag = "BrowseAuthors";
            this.cmbAuthor.Text = "Browse Authors";
            this.cmbAuthor.SelectionChangeCommitted += new System.EventHandler(this.cmbAuthor_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.cmbAuthor);
            this.grpProductDetails.Controls.Add(this.label1);
            this.grpProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductDetails.Location = new System.Drawing.Point(192, 63);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(640, 68);
            this.grpProductDetails.TabIndex = 46;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Choose an author";
            // 
            // lbNumOfBook
            // 
            this.lbNumOfBook.AutoSize = true;
            this.lbNumOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfBook.Location = new System.Drawing.Point(192, 246);
            this.lbNumOfBook.Name = "lbNumOfBook";
            this.lbNumOfBook.Size = new System.Drawing.Size(0, 17);
            this.lbNumOfBook.TabIndex = 50;
            // 
            // frmBrowseAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 539);
            this.Controls.Add(this.lbNumOfBook);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.grpProductDetails);
            this.Name = "frmBrowseAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "BrowseAuthors";
            this.Text = "Browse Authors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBrowseAuthors_FormClosed);
            this.Load += new System.EventHandler(this.frmBrowseAuthors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.grpProductDetails.ResumeLayout(false);
            this.grpProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lbContactNumber;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAward;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.Label lbNumOfBook;
    }
}