namespace Library
{
    partial class frmMaintenanceAuthor
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
            this.grpAuthorInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoNonBinary = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpCareer = new System.Windows.Forms.GroupBox();
            this.grpPublishedWork = new System.Windows.Forms.GroupBox();
            this.txtPublicateDate = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumOfBooks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAward = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAuthorInfo.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpCareer.SuspendLayout();
            this.grpPublishedWork.SuspendLayout();
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
            this.btnLast.Location = new System.Drawing.Point(416, 634);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(69, 59);
            this.btnLast.TabIndex = 34;
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
            this.btnNext.Location = new System.Drawing.Point(341, 634);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 59);
            this.btnNext.TabIndex = 33;
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
            this.btnPrevious.Location = new System.Drawing.Point(266, 634);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(69, 59);
            this.btnPrevious.TabIndex = 32;
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
            this.btnFirst.Location = new System.Drawing.Point(191, 634);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(69, 59);
            this.btnFirst.TabIndex = 31;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors";
            // 
            // grpAuthorInfo
            // 
            this.grpAuthorInfo.Controls.Add(this.label4);
            this.grpAuthorInfo.Controls.Add(this.txtContactNumber);
            this.grpAuthorInfo.Controls.Add(this.grpGender);
            this.grpAuthorInfo.Controls.Add(this.label3);
            this.grpAuthorInfo.Controls.Add(this.txtMiddleName);
            this.grpAuthorInfo.Controls.Add(this.label2);
            this.grpAuthorInfo.Controls.Add(this.txtLastName);
            this.grpAuthorInfo.Controls.Add(this.label8);
            this.grpAuthorInfo.Controls.Add(this.txtFirstName);
            this.grpAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAuthorInfo.Location = new System.Drawing.Point(11, 60);
            this.grpAuthorInfo.Name = "grpAuthorInfo";
            this.grpAuthorInfo.Size = new System.Drawing.Size(665, 184);
            this.grpAuthorInfo.TabIndex = 2;
            this.grpAuthorInfo.TabStop = false;
            this.grpAuthorInfo.Text = "Personal Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Contact Number:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(150, 140);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(277, 20);
            this.txtContactNumber.TabIndex = 27;
            this.txtContactNumber.Tag = "Contact number";
            this.txtContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoNonBinary);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(462, 26);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(179, 134);
            this.grpGender.TabIndex = 25;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoNonBinary
            // 
            this.rdoNonBinary.AutoSize = true;
            this.rdoNonBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonBinary.Location = new System.Drawing.Point(36, 92);
            this.rdoNonBinary.Name = "rdoNonBinary";
            this.rdoNonBinary.Size = new System.Drawing.Size(99, 22);
            this.rdoNonBinary.TabIndex = 2;
            this.rdoNonBinary.TabStop = true;
            this.rdoNonBinary.Text = "Non Binary";
            this.rdoNonBinary.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(36, 64);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(75, 22);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(36, 36);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 22);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(150, 71);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(277, 20);
            this.txtMiddleName.TabIndex = 23;
            this.txtMiddleName.Tag = "Middle name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(150, 105);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(277, 20);
            this.txtLastName.TabIndex = 21;
            this.txtLastName.Tag = "Last name";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(150, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(277, 20);
            this.txtFirstName.TabIndex = 19;
            this.txtFirstName.Tag = "First name";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // grpCareer
            // 
            this.grpCareer.Controls.Add(this.grpPublishedWork);
            this.grpCareer.Controls.Add(this.cmbMainCategory);
            this.grpCareer.Controls.Add(this.label7);
            this.grpCareer.Controls.Add(this.txtNumOfBooks);
            this.grpCareer.Controls.Add(this.label6);
            this.grpCareer.Controls.Add(this.txtAward);
            this.grpCareer.Controls.Add(this.label5);
            this.grpCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCareer.Location = new System.Drawing.Point(11, 250);
            this.grpCareer.Name = "grpCareer";
            this.grpCareer.Size = new System.Drawing.Size(665, 317);
            this.grpCareer.TabIndex = 4;
            this.grpCareer.TabStop = false;
            this.grpCareer.Text = "Career";
            // 
            // grpPublishedWork
            // 
            this.grpPublishedWork.Controls.Add(this.txtPublicateDate);
            this.grpPublishedWork.Controls.Add(this.txtCategory);
            this.grpPublishedWork.Controls.Add(this.label11);
            this.grpPublishedWork.Controls.Add(this.label10);
            this.grpPublishedWork.Controls.Add(this.label9);
            this.grpPublishedWork.Controls.Add(this.txtTitle);
            this.grpPublishedWork.Location = new System.Drawing.Point(12, 160);
            this.grpPublishedWork.Name = "grpPublishedWork";
            this.grpPublishedWork.Size = new System.Drawing.Size(629, 151);
            this.grpPublishedWork.TabIndex = 26;
            this.grpPublishedWork.TabStop = false;
            this.grpPublishedWork.Text = "Latest published works";
            // 
            // txtPublicateDate
            // 
            this.txtPublicateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicateDate.Location = new System.Drawing.Point(181, 76);
            this.txtPublicateDate.Name = "txtPublicateDate";
            this.txtPublicateDate.ReadOnly = true;
            this.txtPublicateDate.Size = new System.Drawing.Size(358, 20);
            this.txtPublicateDate.TabIndex = 20;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(181, 114);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(358, 20);
            this.txtCategory.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Publicate Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Book Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(181, 39);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(358, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // cmbMainCategory
            // 
            this.cmbMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainCategory.FormattingEnabled = true;
            this.cmbMainCategory.Location = new System.Drawing.Point(150, 70);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(224, 23);
            this.cmbMainCategory.TabIndex = 24;
            this.cmbMainCategory.Tag = "Main category";
            this.cmbMainCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Main Category:";
            // 
            // txtNumOfBooks
            // 
            this.txtNumOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfBooks.Location = new System.Drawing.Point(150, 36);
            this.txtNumOfBooks.Name = "txtNumOfBooks";
            this.txtNumOfBooks.Size = new System.Drawing.Size(150, 20);
            this.txtNumOfBooks.TabIndex = 22;
            this.txtNumOfBooks.Tag = "Number of books";
            this.txtNumOfBooks.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Number of books:";
            // 
            // txtAward
            // 
            this.txtAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAward.Location = new System.Drawing.Point(150, 109);
            this.txtAward.Name = "txtAward";
            this.txtAward.Size = new System.Drawing.Size(491, 20);
            this.txtAward.TabIndex = 20;
            this.txtAward.Tag = "Award";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Award:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(489, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 30;
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
            this.btnUpdate.Location = new System.Drawing.Point(362, 586);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 29;
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
            this.btnDelete.Location = new System.Drawing.Point(229, 586);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 28;
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
            this.btnAdd.Location = new System.Drawing.Point(100, 586);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmMaintenanceAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(691, 697);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCareer);
            this.Controls.Add(this.grpAuthorInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmMaintenanceAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Author";
            this.Text = "Maintenance Author";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMaintenanceAuthor_FormClosed);
            this.Load += new System.EventHandler(this.frmMaintenanceAuthor_Load);
            this.grpAuthorInfo.ResumeLayout(false);
            this.grpAuthorInfo.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpCareer.ResumeLayout(false);
            this.grpCareer.PerformLayout();
            this.grpPublishedWork.ResumeLayout(false);
            this.grpPublishedWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAuthorInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoNonBinary;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpCareer;
        private System.Windows.Forms.GroupBox grpPublishedWork;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumOfBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPublicateDate;
    }
}