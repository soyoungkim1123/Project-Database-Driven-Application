namespace Library
{
    partial class mdiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalBooks = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalAuthors = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrowseAuthors = new Library.CircularButton();
            this.btnBrowseBooks = new Library.CircularButton();
            this.btnMaintenanceBookAuthorList = new Library.CircularButton();
            this.btnMaintenanceAuthor = new Library.CircularButton();
            this.btnMaintenanceBook = new Library.CircularButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.dataGridViewToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // dataGridViewToolStripMenuItem
            // 
            this.dataGridViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.dataGridViewToolStripMenuItem.Name = "dataGridViewToolStripMenuItem";
            this.dataGridViewToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.dataGridViewToolStripMenuItem.Text = "&Maintenance";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.simpleToolStripMenuItem.Tag = "Book";
            this.simpleToolStripMenuItem.Text = "&Book";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.eventsToolStripMenuItem.Tag = "Author";
            this.eventsToolStripMenuItem.Text = "&Author";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.controlsToolStripMenuItem.Tag = "AuthorList";
            this.controlsToolStripMenuItem.Text = "Author &List";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.authorSearchToolStripMenuItem});
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.browseToolStripMenuItem.Text = "&Browse";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookToolStripMenuItem.Tag = "BrowseBooks";
            this.bookToolStripMenuItem.Text = "Browse &Books";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // authorSearchToolStripMenuItem
            // 
            this.authorSearchToolStripMenuItem.Name = "authorSearchToolStripMenuItem";
            this.authorSearchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.authorSearchToolStripMenuItem.Tag = "BrowseAuthors";
            this.authorSearchToolStripMenuItem.Text = "Browse &Author";
            this.authorSearchToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Tag = "About";
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 819);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(161, 823);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(100, 16);
            this.prgBar.TabIndex = 6;
            this.prgBar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Location = new System.Drawing.Point(47, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 118);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(94, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Books";
            // 
            // lbTotalBooks
            // 
            this.lbTotalBooks.BackColor = System.Drawing.Color.PaleGreen;
            this.lbTotalBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalBooks.Location = new System.Drawing.Point(50, 166);
            this.lbTotalBooks.Name = "lbTotalBooks";
            this.lbTotalBooks.Size = new System.Drawing.Size(194, 46);
            this.lbTotalBooks.TabIndex = 16;
            this.lbTotalBooks.Text = "12";
            this.lbTotalBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Location = new System.Drawing.Point(291, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 118);
            this.panel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(331, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Authors";
            // 
            // lbTotalAuthors
            // 
            this.lbTotalAuthors.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbTotalAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAuthors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalAuthors.Location = new System.Drawing.Point(294, 166);
            this.lbTotalAuthors.Name = "lbTotalAuthors";
            this.lbTotalAuthors.Size = new System.Drawing.Size(194, 46);
            this.lbTotalAuthors.TabIndex = 17;
            this.lbTotalAuthors.Text = "10";
            this.lbTotalAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Pink;
            this.panel4.Location = new System.Drawing.Point(793, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 118);
            this.panel4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(824, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Book Cost";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.BackColor = System.Drawing.Color.Pink;
            this.lbTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalPrice.Location = new System.Drawing.Point(796, 171);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(194, 31);
            this.lbTotalPrice.TabIndex = 18;
            this.lbTotalPrice.Text = "$150.00";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnMaintenanceBookAuthorList);
            this.panel5.Controls.Add(this.btnMaintenanceAuthor);
            this.panel5.Controls.Add(this.btnMaintenanceBook);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(25, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 237);
            this.panel5.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(710, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Book\'s author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Authors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Books";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Maintenance Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Overview";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.btnBrowseAuthors);
            this.panel6.Controls.Add(this.btnBrowseBooks);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(25, 521);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 237);
            this.panel6.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Browse Authors";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Browse Books";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 31);
            this.label17.TabIndex = 25;
            this.label17.Text = "Browse Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Library Management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.lbAvailable);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbTotalAuthors);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbTotalBooks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 774);
            this.panel1.TabIndex = 20;
            // 
            // lbAvailable
            // 
            this.lbAvailable.BackColor = System.Drawing.Color.LightGray;
            this.lbAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAvailable.Location = new System.Drawing.Point(546, 166);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(194, 46);
            this.lbAvailable.TabIndex = 37;
            this.lbAvailable.Text = "10";
            this.lbAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(543, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 118);
            this.panel7.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(33, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Available Books";
            // 
            // btnBrowseAuthors
            // 
            this.btnBrowseAuthors.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBrowseAuthors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowseAuthors.FlatAppearance.BorderSize = 0;
            this.btnBrowseAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseAuthors.Image = global::Library.Properties.Resources.browseauthor;
            this.btnBrowseAuthors.Location = new System.Drawing.Point(581, 63);
            this.btnBrowseAuthors.Name = "btnBrowseAuthors";
            this.btnBrowseAuthors.Size = new System.Drawing.Size(100, 100);
            this.btnBrowseAuthors.TabIndex = 29;
            this.btnBrowseAuthors.Tag = "BrowseAuthors";
            this.btnBrowseAuthors.UseVisualStyleBackColor = false;
            this.btnBrowseAuthors.Click += new System.EventHandler(this.ShowNewFormByBtn);
            // 
            // btnBrowseBooks
            // 
            this.btnBrowseBooks.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowseBooks.FlatAppearance.BorderSize = 0;
            this.btnBrowseBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBooks.Image = global::Library.Properties.Resources.browsebook;
            this.btnBrowseBooks.Location = new System.Drawing.Point(306, 63);
            this.btnBrowseBooks.Name = "btnBrowseBooks";
            this.btnBrowseBooks.Size = new System.Drawing.Size(100, 100);
            this.btnBrowseBooks.TabIndex = 28;
            this.btnBrowseBooks.Tag = "BrowseBooks";
            this.btnBrowseBooks.UseVisualStyleBackColor = false;
            this.btnBrowseBooks.Click += new System.EventHandler(this.ShowNewFormByBtn);
            // 
            // btnMaintenanceBookAuthorList
            // 
            this.btnMaintenanceBookAuthorList.BackColor = System.Drawing.Color.Orange;
            this.btnMaintenanceBookAuthorList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaintenanceBookAuthorList.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceBookAuthorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceBookAuthorList.Image = global::Library.Properties.Resources.list;
            this.btnMaintenanceBookAuthorList.Location = new System.Drawing.Point(704, 66);
            this.btnMaintenanceBookAuthorList.Name = "btnMaintenanceBookAuthorList";
            this.btnMaintenanceBookAuthorList.Size = new System.Drawing.Size(100, 100);
            this.btnMaintenanceBookAuthorList.TabIndex = 27;
            this.btnMaintenanceBookAuthorList.Tag = "AuthorList";
            this.btnMaintenanceBookAuthorList.UseVisualStyleBackColor = false;
            this.btnMaintenanceBookAuthorList.Click += new System.EventHandler(this.ShowNewFormByBtn);
            // 
            // btnMaintenanceAuthor
            // 
            this.btnMaintenanceAuthor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaintenanceAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaintenanceAuthor.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceAuthor.Image = global::Library.Properties.Resources.author;
            this.btnMaintenanceAuthor.Location = new System.Drawing.Point(421, 66);
            this.btnMaintenanceAuthor.Name = "btnMaintenanceAuthor";
            this.btnMaintenanceAuthor.Size = new System.Drawing.Size(100, 100);
            this.btnMaintenanceAuthor.TabIndex = 26;
            this.btnMaintenanceAuthor.Tag = "Author";
            this.btnMaintenanceAuthor.UseVisualStyleBackColor = false;
            this.btnMaintenanceAuthor.Click += new System.EventHandler(this.ShowNewFormByBtn);
            // 
            // btnMaintenanceBook
            // 
            this.btnMaintenanceBook.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMaintenanceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaintenanceBook.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceBook.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintenanceBook.Image")));
            this.btnMaintenanceBook.Location = new System.Drawing.Point(139, 66);
            this.btnMaintenanceBook.Name = "btnMaintenanceBook";
            this.btnMaintenanceBook.Size = new System.Drawing.Size(100, 100);
            this.btnMaintenanceBook.TabIndex = 22;
            this.btnMaintenanceBook.Tag = "Book";
            this.btnMaintenanceBook.UseVisualStyleBackColor = false;
            this.btnMaintenanceBook.Click += new System.EventHandler(this.ShowNewFormByBtn);
            // 
            // mdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1073, 841);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "mdiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management Menu";
            this.Load += new System.EventHandler(this.mdiForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem dataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorSearchToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalBooks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalAuthors;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CircularButton btnMaintenanceBookAuthorList;
        private CircularButton btnMaintenanceAuthor;
        private CircularButton btnMaintenanceBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CircularButton btnBrowseAuthors;
        private CircularButton btnBrowseBooks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
    }
}



