namespace library
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearchDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchReleaseYear = new System.Windows.Forms.TextBox();
            this.lblSearchReleaseYear = new System.Windows.Forms.Label();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.lblSearchSubject = new System.Windows.Forms.Label();
            this.txtSearchAuthorName = new System.Windows.Forms.TextBox();
            this.lblSearchAuthorName = new System.Windows.Forms.Label();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.lblSearchBookName = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdoSearchReleaseYear = new System.Windows.Forms.RadioButton();
            this.rdoSearchSubject = new System.Windows.Forms.RadioButton();
            this.rdoSearchAuthorName = new System.Windows.Forms.RadioButton();
            this.rdoSearchBookName = new System.Windows.Forms.RadioButton();
            this.btnSearchLoginAdmin = new System.Windows.Forms.Button();
            this.lblSearchUsername = new System.Windows.Forms.Label();
            this.lblSearchUserField = new System.Windows.Forms.Label();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.lblMembersCharCountTel = new System.Windows.Forms.Label();
            this.lblMembersCharCountNationalCode = new System.Windows.Forms.Label();
            this.lblMembersCharCountRegistrationCode = new System.Windows.Forms.Label();
            this.picMembersUser = new System.Windows.Forms.PictureBox();
            this.btnMembersNewForm = new System.Windows.Forms.Button();
            this.btnMembersSubmitForm = new System.Windows.Forms.Button();
            this.btnMembersImportPic = new System.Windows.Forms.Button();
            this.txtMembersTel = new System.Windows.Forms.TextBox();
            this.txtMembersNationalCode = new System.Windows.Forms.TextBox();
            this.txtMembersLastName = new System.Windows.Forms.TextBox();
            this.txtMembersFirstName = new System.Windows.Forms.TextBox();
            this.txtMembersRegistrationCode = new System.Windows.Forms.TextBox();
            this.lblMembersLastName = new System.Windows.Forms.Label();
            this.lblMembersTel = new System.Windows.Forms.Label();
            this.lblMembersAddress = new System.Windows.Forms.Label();
            this.lblMembersFirstName = new System.Windows.Forms.Label();
            this.lblMembersNationalCode = new System.Windows.Forms.Label();
            this.lblMembersRegistrationCode = new System.Windows.Forms.Label();
            this.rtbMembersAddress = new System.Windows.Forms.RichTextBox();
            this.pnlMembersRTBBorder = new System.Windows.Forms.Panel();
            this.lblMenuSearch = new System.Windows.Forms.Label();
            this.lblMenuMembers = new System.Windows.Forms.Label();
            this.lblMenuBooks = new System.Windows.Forms.Label();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.tipImportPic = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBooks = new System.Windows.Forms.Panel();
            this.cboBooksSubject = new System.Windows.Forms.ComboBox();
            this.picBooks = new System.Windows.Forms.PictureBox();
            this.txtBooksISBN = new System.Windows.Forms.TextBox();
            this.lblBooksISBN = new System.Windows.Forms.Label();
            this.btnBooksNewForm = new System.Windows.Forms.Button();
            this.btnBooksSubmitForm = new System.Windows.Forms.Button();
            this.lblBooksName = new System.Windows.Forms.Label();
            this.btnBooksImportPic = new System.Windows.Forms.Button();
            this.lblBooksPublisher = new System.Windows.Forms.Label();
            this.txtBooksReleaseYear = new System.Windows.Forms.TextBox();
            this.lblBooksAuthor = new System.Windows.Forms.Label();
            this.txtBooksPublisher = new System.Windows.Forms.TextBox();
            this.lblBooksSubject = new System.Windows.Forms.Label();
            this.txtBooksTranslator = new System.Windows.Forms.TextBox();
            this.lblBooksReleaseYear = new System.Windows.Forms.Label();
            this.txtBooksAuthor = new System.Windows.Forms.TextBox();
            this.lblBooksTranslator = new System.Windows.Forms.Label();
            this.txtBooksName = new System.Windows.Forms.TextBox();
            this.pnlBooksCBOBorder = new System.Windows.Forms.Panel();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.pnlMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMembersUser)).BeginInit();
            this.pnlBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(800, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(13, 5);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(20, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 5;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlSearch.Controls.Add(this.btnSearchDel);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchReleaseYear);
            this.pnlSearch.Controls.Add(this.lblSearchReleaseYear);
            this.pnlSearch.Controls.Add(this.txtSearchSubject);
            this.pnlSearch.Controls.Add(this.lblSearchSubject);
            this.pnlSearch.Controls.Add(this.txtSearchAuthorName);
            this.pnlSearch.Controls.Add(this.lblSearchAuthorName);
            this.pnlSearch.Controls.Add(this.txtSearchBookName);
            this.pnlSearch.Controls.Add(this.lblSearchBookName);
            this.pnlSearch.Controls.Add(this.grpSearch);
            this.pnlSearch.Controls.Add(this.btnSearchLoginAdmin);
            this.pnlSearch.Controls.Add(this.lblSearchUsername);
            this.pnlSearch.Controls.Add(this.lblSearchUserField);
            this.pnlSearch.Location = new System.Drawing.Point(5, 65);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(790, 381);
            this.pnlSearch.TabIndex = 6;
            this.pnlSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Other_MouseClick);
            // 
            // btnSearchDel
            // 
            this.btnSearchDel.Enabled = false;
            this.btnSearchDel.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDel.Location = new System.Drawing.Point(131, 316);
            this.btnSearchDel.Name = "btnSearchDel";
            this.btnSearchDel.Size = new System.Drawing.Size(114, 32);
            this.btnSearchDel.TabIndex = 21;
            this.btnSearchDel.Text = "پاک";
            this.btnSearchDel.UseVisualStyleBackColor = true;
            this.btnSearchDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(258, 316);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 32);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "جستجو کن";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchReleaseYear
            // 
            this.txtSearchReleaseYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchReleaseYear.BackColor = System.Drawing.Color.White;
            this.txtSearchReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReleaseYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchReleaseYear.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReleaseYear.Location = new System.Drawing.Point(414, 316);
            this.txtSearchReleaseYear.MaxLength = 4;
            this.txtSearchReleaseYear.Name = "txtSearchReleaseYear";
            this.txtSearchReleaseYear.ShortcutsEnabled = false;
            this.txtSearchReleaseYear.Size = new System.Drawing.Size(154, 32);
            this.txtSearchReleaseYear.TabIndex = 19;
            this.txtSearchReleaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchReleaseYear.Visible = false;
            this.txtSearchReleaseYear.WordWrap = false;
            this.txtSearchReleaseYear.TextChanged += new System.EventHandler(this.txtReleaseDate_TextChanged);
            this.txtSearchReleaseYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            // 
            // lblSearchReleaseYear
            // 
            this.lblSearchReleaseYear.AutoSize = true;
            this.lblSearchReleaseYear.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F);
            this.lblSearchReleaseYear.Location = new System.Drawing.Point(574, 319);
            this.lblSearchReleaseYear.Name = "lblSearchReleaseYear";
            this.lblSearchReleaseYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchReleaseYear.Size = new System.Drawing.Size(79, 27);
            this.lblSearchReleaseYear.TabIndex = 18;
            this.lblSearchReleaseYear.Text = "سال چاپ :";
            this.lblSearchReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearchReleaseYear.Visible = false;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchSubject.BackColor = System.Drawing.Color.White;
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSubject.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSubject.Location = new System.Drawing.Point(258, 265);
            this.txtSearchSubject.MaxLength = 21;
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchSubject.Size = new System.Drawing.Size(310, 32);
            this.txtSearchSubject.TabIndex = 17;
            this.txtSearchSubject.Text = "          ";
            this.txtSearchSubject.Visible = false;
            this.txtSearchSubject.WordWrap = false;
            this.txtSearchSubject.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtSearchSubject.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtSearchSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtSearchSubject.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblSearchSubject
            // 
            this.lblSearchSubject.AutoSize = true;
            this.lblSearchSubject.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F);
            this.lblSearchSubject.Location = new System.Drawing.Point(574, 268);
            this.lblSearchSubject.Name = "lblSearchSubject";
            this.lblSearchSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchSubject.Size = new System.Drawing.Size(69, 27);
            this.lblSearchSubject.TabIndex = 16;
            this.lblSearchSubject.Text = "موضوع :";
            this.lblSearchSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearchSubject.Visible = false;
            // 
            // txtSearchAuthorName
            // 
            this.txtSearchAuthorName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchAuthorName.BackColor = System.Drawing.Color.White;
            this.txtSearchAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAuthorName.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAuthorName.Location = new System.Drawing.Point(143, 214);
            this.txtSearchAuthorName.MaxLength = 30;
            this.txtSearchAuthorName.Name = "txtSearchAuthorName";
            this.txtSearchAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchAuthorName.Size = new System.Drawing.Size(425, 32);
            this.txtSearchAuthorName.TabIndex = 15;
            this.txtSearchAuthorName.Text = "          ";
            this.txtSearchAuthorName.Visible = false;
            this.txtSearchAuthorName.WordWrap = false;
            this.txtSearchAuthorName.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtSearchAuthorName.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtSearchAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtSearchAuthorName.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblSearchAuthorName
            // 
            this.lblSearchAuthorName.AutoSize = true;
            this.lblSearchAuthorName.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F);
            this.lblSearchAuthorName.Location = new System.Drawing.Point(574, 217);
            this.lblSearchAuthorName.Name = "lblSearchAuthorName";
            this.lblSearchAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchAuthorName.Size = new System.Drawing.Size(98, 27);
            this.lblSearchAuthorName.TabIndex = 14;
            this.lblSearchAuthorName.Text = "نام نویسنده :";
            this.lblSearchAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearchAuthorName.Visible = false;
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.BackColor = System.Drawing.Color.White;
            this.txtSearchBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBookName.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookName.Location = new System.Drawing.Point(143, 163);
            this.txtSearchBookName.MaxLength = 30;
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchBookName.Size = new System.Drawing.Size(425, 32);
            this.txtSearchBookName.TabIndex = 13;
            this.txtSearchBookName.Text = "          ";
            this.txtSearchBookName.Visible = false;
            this.txtSearchBookName.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtSearchBookName.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtSearchBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWordNumber_KeyPress);
            this.txtSearchBookName.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblSearchBookName
            // 
            this.lblSearchBookName.AutoSize = true;
            this.lblSearchBookName.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F);
            this.lblSearchBookName.Location = new System.Drawing.Point(574, 166);
            this.lblSearchBookName.Name = "lblSearchBookName";
            this.lblSearchBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchBookName.Size = new System.Drawing.Size(74, 27);
            this.lblSearchBookName.TabIndex = 12;
            this.lblSearchBookName.Text = "نام کتاب :";
            this.lblSearchBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearchBookName.Visible = false;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.rdoSearchReleaseYear);
            this.grpSearch.Controls.Add(this.rdoSearchSubject);
            this.grpSearch.Controls.Add(this.rdoSearchAuthorName);
            this.grpSearch.Controls.Add(this.rdoSearchBookName);
            this.grpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSearch.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F);
            this.grpSearch.Location = new System.Drawing.Point(70, 59);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSearch.Size = new System.Drawing.Size(650, 72);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "جستجو بر اساس";
            // 
            // rdoSearchReleaseYear
            // 
            this.rdoSearchReleaseYear.AutoSize = true;
            this.rdoSearchReleaseYear.Location = new System.Drawing.Point(105, 29);
            this.rdoSearchReleaseYear.Name = "rdoSearchReleaseYear";
            this.rdoSearchReleaseYear.Size = new System.Drawing.Size(82, 28);
            this.rdoSearchReleaseYear.TabIndex = 4;
            this.rdoSearchReleaseYear.Text = "سال چاپ";
            this.rdoSearchReleaseYear.UseVisualStyleBackColor = true;
            this.rdoSearchReleaseYear.CheckedChanged += new System.EventHandler(this.GetCheckedrdo_CheckedChanged);
            // 
            // rdoSearchSubject
            // 
            this.rdoSearchSubject.AutoSize = true;
            this.rdoSearchSubject.Location = new System.Drawing.Point(230, 29);
            this.rdoSearchSubject.Name = "rdoSearchSubject";
            this.rdoSearchSubject.Size = new System.Drawing.Size(72, 28);
            this.rdoSearchSubject.TabIndex = 3;
            this.rdoSearchSubject.Text = "موضوع";
            this.rdoSearchSubject.UseVisualStyleBackColor = true;
            this.rdoSearchSubject.CheckedChanged += new System.EventHandler(this.GetCheckedrdo_CheckedChanged);
            // 
            // rdoSearchAuthorName
            // 
            this.rdoSearchAuthorName.AutoSize = true;
            this.rdoSearchAuthorName.Location = new System.Drawing.Point(344, 29);
            this.rdoSearchAuthorName.Name = "rdoSearchAuthorName";
            this.rdoSearchAuthorName.Size = new System.Drawing.Size(99, 28);
            this.rdoSearchAuthorName.TabIndex = 2;
            this.rdoSearchAuthorName.Text = "نام نویسنده";
            this.rdoSearchAuthorName.UseVisualStyleBackColor = true;
            this.rdoSearchAuthorName.CheckedChanged += new System.EventHandler(this.GetCheckedrdo_CheckedChanged);
            // 
            // rdoSearchBookName
            // 
            this.rdoSearchBookName.AutoSize = true;
            this.rdoSearchBookName.Location = new System.Drawing.Point(469, 29);
            this.rdoSearchBookName.Name = "rdoSearchBookName";
            this.rdoSearchBookName.Size = new System.Drawing.Size(77, 28);
            this.rdoSearchBookName.TabIndex = 1;
            this.rdoSearchBookName.Text = "نام کتاب";
            this.rdoSearchBookName.UseVisualStyleBackColor = true;
            this.rdoSearchBookName.CheckedChanged += new System.EventHandler(this.GetCheckedrdo_CheckedChanged);
            // 
            // btnSearchLoginAdmin
            // 
            this.btnSearchLoginAdmin.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLoginAdmin.Location = new System.Drawing.Point(17, 9);
            this.btnSearchLoginAdmin.Name = "btnSearchLoginAdmin";
            this.btnSearchLoginAdmin.Size = new System.Drawing.Size(126, 37);
            this.btnSearchLoginAdmin.TabIndex = 10;
            this.btnSearchLoginAdmin.Text = "ورود مدیر";
            this.btnSearchLoginAdmin.UseVisualStyleBackColor = true;
            this.btnSearchLoginAdmin.Click += new System.EventHandler(this.btnSearchLoginAdmin_Click);
            // 
            // lblSearchUsername
            // 
            this.lblSearchUsername.AutoSize = true;
            this.lblSearchUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchUsername.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchUsername.Location = new System.Drawing.Point(630, 15);
            this.lblSearchUsername.Name = "lblSearchUsername";
            this.lblSearchUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchUsername.Size = new System.Drawing.Size(49, 24);
            this.lblSearchUsername.TabIndex = 8;
            this.lblSearchUsername.Text = "مهمان";
            this.lblSearchUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchUserField
            // 
            this.lblSearchUserField.AutoSize = true;
            this.lblSearchUserField.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchUserField.Font = new System.Drawing.Font("Yekan Bakh Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUserField.Location = new System.Drawing.Point(696, 13);
            this.lblSearchUserField.Name = "lblSearchUserField";
            this.lblSearchUserField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchUserField.Size = new System.Drawing.Size(72, 27);
            this.lblSearchUserField.TabIndex = 7;
            this.lblSearchUserField.Text = "نام کاربر :";
            this.lblSearchUserField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMembers
            // 
            this.pnlMembers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMembers.Controls.Add(this.lblMembersCharCountTel);
            this.pnlMembers.Controls.Add(this.lblMembersCharCountNationalCode);
            this.pnlMembers.Controls.Add(this.lblMembersCharCountRegistrationCode);
            this.pnlMembers.Controls.Add(this.picMembersUser);
            this.pnlMembers.Controls.Add(this.btnMembersNewForm);
            this.pnlMembers.Controls.Add(this.btnMembersSubmitForm);
            this.pnlMembers.Controls.Add(this.btnMembersImportPic);
            this.pnlMembers.Controls.Add(this.txtMembersTel);
            this.pnlMembers.Controls.Add(this.txtMembersNationalCode);
            this.pnlMembers.Controls.Add(this.txtMembersLastName);
            this.pnlMembers.Controls.Add(this.txtMembersFirstName);
            this.pnlMembers.Controls.Add(this.txtMembersRegistrationCode);
            this.pnlMembers.Controls.Add(this.lblMembersLastName);
            this.pnlMembers.Controls.Add(this.lblMembersTel);
            this.pnlMembers.Controls.Add(this.lblMembersAddress);
            this.pnlMembers.Controls.Add(this.lblMembersFirstName);
            this.pnlMembers.Controls.Add(this.lblMembersNationalCode);
            this.pnlMembers.Controls.Add(this.lblMembersRegistrationCode);
            this.pnlMembers.Controls.Add(this.rtbMembersAddress);
            this.pnlMembers.Controls.Add(this.pnlMembersRTBBorder);
            this.pnlMembers.Location = new System.Drawing.Point(5, 65);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(790, 381);
            this.pnlMembers.TabIndex = 22;
            this.pnlMembers.Visible = false;
            this.pnlMembers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Other_MouseClick);
            // 
            // lblMembersCharCountTel
            // 
            this.lblMembersCharCountTel.AutoSize = true;
            this.lblMembersCharCountTel.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersCharCountTel.Font = new System.Drawing.Font("Yekan Bakh Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersCharCountTel.Location = new System.Drawing.Point(357, 178);
            this.lblMembersCharCountTel.Name = "lblMembersCharCountTel";
            this.lblMembersCharCountTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersCharCountTel.Size = new System.Drawing.Size(31, 22);
            this.lblMembersCharCountTel.TabIndex = 36;
            this.lblMembersCharCountTel.Text = "0/11";
            this.lblMembersCharCountTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersCharCountNationalCode
            // 
            this.lblMembersCharCountNationalCode.AutoSize = true;
            this.lblMembersCharCountNationalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersCharCountNationalCode.Font = new System.Drawing.Font("Yekan Bakh Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersCharCountNationalCode.Location = new System.Drawing.Point(357, 137);
            this.lblMembersCharCountNationalCode.Name = "lblMembersCharCountNationalCode";
            this.lblMembersCharCountNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersCharCountNationalCode.Size = new System.Drawing.Size(35, 22);
            this.lblMembersCharCountNationalCode.TabIndex = 35;
            this.lblMembersCharCountNationalCode.Text = "0/10";
            this.lblMembersCharCountNationalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersCharCountRegistrationCode
            // 
            this.lblMembersCharCountRegistrationCode.AutoSize = true;
            this.lblMembersCharCountRegistrationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersCharCountRegistrationCode.Font = new System.Drawing.Font("Yekan Bakh Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersCharCountRegistrationCode.Location = new System.Drawing.Point(358, 21);
            this.lblMembersCharCountRegistrationCode.Name = "lblMembersCharCountRegistrationCode";
            this.lblMembersCharCountRegistrationCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersCharCountRegistrationCode.Size = new System.Drawing.Size(34, 22);
            this.lblMembersCharCountRegistrationCode.TabIndex = 34;
            this.lblMembersCharCountRegistrationCode.Text = "0/5";
            this.lblMembersCharCountRegistrationCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picMembersUser
            // 
            this.picMembersUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMembersUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMembersUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMembersUser.Location = new System.Drawing.Point(129, 35);
            this.picMembersUser.Name = "picMembersUser";
            this.picMembersUser.Size = new System.Drawing.Size(112, 136);
            this.picMembersUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMembersUser.TabIndex = 32;
            this.picMembersUser.TabStop = false;
            this.picMembersUser.Click += new System.EventHandler(this.btnImportPic_Click);
            this.picMembersUser.MouseHover += new System.EventHandler(this.btnImportPic_MouseHover);
            // 
            // btnMembersNewForm
            // 
            this.btnMembersNewForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnMembersNewForm.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersNewForm.Location = new System.Drawing.Point(86, 315);
            this.btnMembersNewForm.Name = "btnMembersNewForm";
            this.btnMembersNewForm.Size = new System.Drawing.Size(198, 28);
            this.btnMembersNewForm.TabIndex = 31;
            this.btnMembersNewForm.Text = "جدید";
            this.btnMembersNewForm.UseVisualStyleBackColor = false;
            this.btnMembersNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // btnMembersSubmitForm
            // 
            this.btnMembersSubmitForm.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMembersSubmitForm.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersSubmitForm.Location = new System.Drawing.Point(86, 271);
            this.btnMembersSubmitForm.Name = "btnMembersSubmitForm";
            this.btnMembersSubmitForm.Size = new System.Drawing.Size(198, 28);
            this.btnMembersSubmitForm.TabIndex = 30;
            this.btnMembersSubmitForm.Text = "ثبت";
            this.btnMembersSubmitForm.UseVisualStyleBackColor = false;
            this.btnMembersSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            // 
            // btnMembersImportPic
            // 
            this.btnMembersImportPic.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMembersImportPic.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersImportPic.Location = new System.Drawing.Point(86, 225);
            this.btnMembersImportPic.Name = "btnMembersImportPic";
            this.btnMembersImportPic.Size = new System.Drawing.Size(198, 28);
            this.btnMembersImportPic.TabIndex = 29;
            this.btnMembersImportPic.Text = "درج تصویر";
            this.btnMembersImportPic.UseVisualStyleBackColor = false;
            this.btnMembersImportPic.Click += new System.EventHandler(this.btnImportPic_Click);
            this.btnMembersImportPic.MouseHover += new System.EventHandler(this.btnImportPic_MouseHover);
            // 
            // txtMembersTel
            // 
            this.txtMembersTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembersTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMembersTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembersTel.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersTel.Location = new System.Drawing.Point(396, 174);
            this.txtMembersTel.MaxLength = 11;
            this.txtMembersTel.Name = "txtMembersTel";
            this.txtMembersTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMembersTel.ShortcutsEnabled = false;
            this.txtMembersTel.Size = new System.Drawing.Size(193, 30);
            this.txtMembersTel.TabIndex = 27;
            this.txtMembersTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMembersTel.TextChanged += new System.EventHandler(this.CharCounter_TextChanged);
            this.txtMembersTel.Enter += new System.EventHandler(this.CharCounter_Enter);
            this.txtMembersTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            // 
            // txtMembersNationalCode
            // 
            this.txtMembersNationalCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembersNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMembersNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembersNationalCode.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersNationalCode.Location = new System.Drawing.Point(396, 134);
            this.txtMembersNationalCode.MaxLength = 10;
            this.txtMembersNationalCode.Name = "txtMembersNationalCode";
            this.txtMembersNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMembersNationalCode.ShortcutsEnabled = false;
            this.txtMembersNationalCode.Size = new System.Drawing.Size(193, 30);
            this.txtMembersNationalCode.TabIndex = 26;
            this.txtMembersNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMembersNationalCode.TextChanged += new System.EventHandler(this.CharCounter_TextChanged);
            this.txtMembersNationalCode.Enter += new System.EventHandler(this.CharCounter_Enter);
            this.txtMembersNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            // 
            // txtMembersLastName
            // 
            this.txtMembersLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembersLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMembersLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembersLastName.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersLastName.Location = new System.Drawing.Point(338, 95);
            this.txtMembersLastName.MaxLength = 30;
            this.txtMembersLastName.Name = "txtMembersLastName";
            this.txtMembersLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMembersLastName.Size = new System.Drawing.Size(251, 30);
            this.txtMembersLastName.TabIndex = 25;
            this.txtMembersLastName.Text = "          ";
            this.txtMembersLastName.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtMembersLastName.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtMembersLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtMembersLastName.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // txtMembersFirstName
            // 
            this.txtMembersFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembersFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMembersFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembersFirstName.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersFirstName.Location = new System.Drawing.Point(338, 56);
            this.txtMembersFirstName.MaxLength = 20;
            this.txtMembersFirstName.Name = "txtMembersFirstName";
            this.txtMembersFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMembersFirstName.Size = new System.Drawing.Size(251, 30);
            this.txtMembersFirstName.TabIndex = 24;
            this.txtMembersFirstName.Text = "          ";
            this.txtMembersFirstName.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtMembersFirstName.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtMembersFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtMembersFirstName.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // txtMembersRegistrationCode
            // 
            this.txtMembersRegistrationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMembersRegistrationCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembersRegistrationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMembersRegistrationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembersRegistrationCode.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F);
            this.txtMembersRegistrationCode.Location = new System.Drawing.Point(396, 16);
            this.txtMembersRegistrationCode.MaxLength = 5;
            this.txtMembersRegistrationCode.Name = "txtMembersRegistrationCode";
            this.txtMembersRegistrationCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMembersRegistrationCode.ShortcutsEnabled = false;
            this.txtMembersRegistrationCode.Size = new System.Drawing.Size(193, 30);
            this.txtMembersRegistrationCode.TabIndex = 23;
            this.txtMembersRegistrationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMembersRegistrationCode.TextChanged += new System.EventHandler(this.CharCounter_TextChanged);
            this.txtMembersRegistrationCode.Enter += new System.EventHandler(this.CharCounter_Enter);
            this.txtMembersRegistrationCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            // 
            // lblMembersLastName
            // 
            this.lblMembersLastName.AutoSize = true;
            this.lblMembersLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersLastName.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersLastName.Location = new System.Drawing.Point(609, 94);
            this.lblMembersLastName.Name = "lblMembersLastName";
            this.lblMembersLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersLastName.Size = new System.Drawing.Size(96, 29);
            this.lblMembersLastName.TabIndex = 22;
            this.lblMembersLastName.Text = "نام خانوادگی :";
            this.lblMembersLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersTel
            // 
            this.lblMembersTel.AutoSize = true;
            this.lblMembersTel.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersTel.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersTel.Location = new System.Drawing.Point(609, 173);
            this.lblMembersTel.Name = "lblMembersTel";
            this.lblMembersTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersTel.Size = new System.Drawing.Size(50, 29);
            this.lblMembersTel.TabIndex = 21;
            this.lblMembersTel.Text = "تلفن :";
            this.lblMembersTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersAddress
            // 
            this.lblMembersAddress.AutoSize = true;
            this.lblMembersAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersAddress.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersAddress.Location = new System.Drawing.Point(609, 221);
            this.lblMembersAddress.Name = "lblMembersAddress";
            this.lblMembersAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersAddress.Size = new System.Drawing.Size(57, 29);
            this.lblMembersAddress.TabIndex = 20;
            this.lblMembersAddress.Text = "نشانی :";
            this.lblMembersAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersFirstName
            // 
            this.lblMembersFirstName.AutoSize = true;
            this.lblMembersFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersFirstName.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersFirstName.Location = new System.Drawing.Point(609, 55);
            this.lblMembersFirstName.Name = "lblMembersFirstName";
            this.lblMembersFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersFirstName.Size = new System.Drawing.Size(39, 29);
            this.lblMembersFirstName.TabIndex = 19;
            this.lblMembersFirstName.Text = "نام :";
            this.lblMembersFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersNationalCode
            // 
            this.lblMembersNationalCode.AutoSize = true;
            this.lblMembersNationalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersNationalCode.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersNationalCode.Location = new System.Drawing.Point(609, 132);
            this.lblMembersNationalCode.Name = "lblMembersNationalCode";
            this.lblMembersNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersNationalCode.Size = new System.Drawing.Size(60, 29);
            this.lblMembersNationalCode.TabIndex = 18;
            this.lblMembersNationalCode.Text = "کدملی :";
            this.lblMembersNationalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembersRegistrationCode
            // 
            this.lblMembersRegistrationCode.AutoSize = true;
            this.lblMembersRegistrationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersRegistrationCode.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersRegistrationCode.Location = new System.Drawing.Point(609, 16);
            this.lblMembersRegistrationCode.Name = "lblMembersRegistrationCode";
            this.lblMembersRegistrationCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMembersRegistrationCode.Size = new System.Drawing.Size(84, 29);
            this.lblMembersRegistrationCode.TabIndex = 17;
            this.lblMembersRegistrationCode.Text = "کد عضویت :";
            this.lblMembersRegistrationCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbMembersAddress
            // 
            this.rtbMembersAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbMembersAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMembersAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbMembersAddress.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F);
            this.rtbMembersAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbMembersAddress.HideSelection = false;
            this.rtbMembersAddress.Location = new System.Drawing.Point(339, 225);
            this.rtbMembersAddress.MaxLength = 200;
            this.rtbMembersAddress.Name = "rtbMembersAddress";
            this.rtbMembersAddress.RightMargin = 232;
            this.rtbMembersAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbMembersAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMembersAddress.ShortcutsEnabled = false;
            this.rtbMembersAddress.Size = new System.Drawing.Size(249, 138);
            this.rtbMembersAddress.TabIndex = 28;
            this.rtbMembersAddress.Text = "";
            this.rtbMembersAddress.TextChanged += new System.EventHandler(this.rtbMembersAddress_TextChanged);
            this.rtbMembersAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWordNumber_KeyPress);
            // 
            // pnlMembersRTBBorder
            // 
            this.pnlMembersRTBBorder.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMembersRTBBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMembersRTBBorder.Location = new System.Drawing.Point(338, 221);
            this.pnlMembersRTBBorder.Name = "pnlMembersRTBBorder";
            this.pnlMembersRTBBorder.Size = new System.Drawing.Size(251, 143);
            this.pnlMembersRTBBorder.TabIndex = 33;
            // 
            // lblMenuSearch
            // 
            this.lblMenuSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblMenuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenuSearch.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F);
            this.lblMenuSearch.Location = new System.Drawing.Point(713, 31);
            this.lblMenuSearch.Name = "lblMenuSearch";
            this.lblMenuSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMenuSearch.Size = new System.Drawing.Size(82, 34);
            this.lblMenuSearch.TabIndex = 8;
            this.lblMenuSearch.Text = "جستجو";
            this.lblMenuSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuSearch.Click += new System.EventHandler(this.Menu_Click);
            // 
            // lblMenuMembers
            // 
            this.lblMenuMembers.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuMembers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenuMembers.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F);
            this.lblMenuMembers.Location = new System.Drawing.Point(628, 31);
            this.lblMenuMembers.Name = "lblMenuMembers";
            this.lblMenuMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMenuMembers.Size = new System.Drawing.Size(82, 34);
            this.lblMenuMembers.TabIndex = 9;
            this.lblMenuMembers.Text = "اعضا";
            this.lblMenuMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuMembers.Click += new System.EventHandler(this.Menu_Click);
            // 
            // lblMenuBooks
            // 
            this.lblMenuBooks.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenuBooks.Font = new System.Drawing.Font("Yekan Bakh Medium", 12F);
            this.lblMenuBooks.Location = new System.Drawing.Point(542, 31);
            this.lblMenuBooks.Name = "lblMenuBooks";
            this.lblMenuBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMenuBooks.Size = new System.Drawing.Size(82, 34);
            this.lblMenuBooks.TabIndex = 10;
            this.lblMenuBooks.Text = "کتاب";
            this.lblMenuBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuBooks.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ofdPic
            // 
            this.ofdPic.Filter = "Image Files(*.  jpg;*.png)|*.  jpg;*.png";
            this.ofdPic.InitialDirectory = "shell:MyComputerFolder";
            this.ofdPic.RestoreDirectory = true;
            this.ofdPic.Title = "Choose an image";
            // 
            // pnlBooks
            // 
            this.pnlBooks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlBooks.Controls.Add(this.cboBooksSubject);
            this.pnlBooks.Controls.Add(this.picBooks);
            this.pnlBooks.Controls.Add(this.txtBooksISBN);
            this.pnlBooks.Controls.Add(this.lblBooksISBN);
            this.pnlBooks.Controls.Add(this.btnBooksNewForm);
            this.pnlBooks.Controls.Add(this.btnBooksSubmitForm);
            this.pnlBooks.Controls.Add(this.lblBooksName);
            this.pnlBooks.Controls.Add(this.btnBooksImportPic);
            this.pnlBooks.Controls.Add(this.lblBooksPublisher);
            this.pnlBooks.Controls.Add(this.txtBooksReleaseYear);
            this.pnlBooks.Controls.Add(this.lblBooksAuthor);
            this.pnlBooks.Controls.Add(this.txtBooksPublisher);
            this.pnlBooks.Controls.Add(this.lblBooksSubject);
            this.pnlBooks.Controls.Add(this.txtBooksTranslator);
            this.pnlBooks.Controls.Add(this.lblBooksReleaseYear);
            this.pnlBooks.Controls.Add(this.txtBooksAuthor);
            this.pnlBooks.Controls.Add(this.lblBooksTranslator);
            this.pnlBooks.Controls.Add(this.txtBooksName);
            this.pnlBooks.Controls.Add(this.pnlBooksCBOBorder);
            this.pnlBooks.Location = new System.Drawing.Point(5, 65);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(790, 381);
            this.pnlBooks.TabIndex = 37;
            this.pnlBooks.Visible = false;
            this.pnlBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Other_MouseClick);
            // 
            // cboBooksSubject
            // 
            this.cboBooksSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboBooksSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBooksSubject.DropDownWidth = 147;
            this.cboBooksSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBooksSubject.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F);
            this.cboBooksSubject.FormattingEnabled = true;
            this.cboBooksSubject.Items.AddRange(new object[] {
            "داستان کوتاه",
            "فلسفی",
            "سیاسی",
            "تجارت",
            "کمدی",
            "روانشناسی"});
            this.cboBooksSubject.Location = new System.Drawing.Point(443, 255);
            this.cboBooksSubject.Name = "cboBooksSubject";
            this.cboBooksSubject.Size = new System.Drawing.Size(126, 30);
            this.cboBooksSubject.TabIndex = 51;
            this.cboBooksSubject.Text = "انتخاب کنید";
            this.cboBooksSubject.SelectedIndexChanged += new System.EventHandler(this.cboBooksSubject_SelectedIndexChanged);
            this.cboBooksSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboBooksSubject_KeyDown);
            this.cboBooksSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboBooksSubject_MouseClick);
            // 
            // picBooks
            // 
            this.picBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBooks.Location = new System.Drawing.Point(129, 35);
            this.picBooks.Name = "picBooks";
            this.picBooks.Size = new System.Drawing.Size(112, 136);
            this.picBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBooks.TabIndex = 50;
            this.picBooks.TabStop = false;
            this.picBooks.Click += new System.EventHandler(this.btnImportPic_Click);
            // 
            // txtBooksISBN
            // 
            this.txtBooksISBN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksISBN.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksISBN.Location = new System.Drawing.Point(442, 295);
            this.txtBooksISBN.MaxLength = 13;
            this.txtBooksISBN.Name = "txtBooksISBN";
            this.txtBooksISBN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksISBN.Size = new System.Drawing.Size(147, 30);
            this.txtBooksISBN.TabIndex = 49;
            this.txtBooksISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBooksISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            this.txtBooksISBN.Leave += new System.EventHandler(this.txtBooksISBN_Leave);
            // 
            // lblBooksISBN
            // 
            this.lblBooksISBN.AutoSize = true;
            this.lblBooksISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksISBN.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksISBN.Location = new System.Drawing.Point(612, 293);
            this.lblBooksISBN.Name = "lblBooksISBN";
            this.lblBooksISBN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksISBN.Size = new System.Drawing.Size(55, 29);
            this.lblBooksISBN.TabIndex = 47;
            this.lblBooksISBN.Text = "شابک :";
            this.lblBooksISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBooksNewForm
            // 
            this.btnBooksNewForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnBooksNewForm.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksNewForm.Location = new System.Drawing.Point(86, 315);
            this.btnBooksNewForm.Name = "btnBooksNewForm";
            this.btnBooksNewForm.Size = new System.Drawing.Size(198, 28);
            this.btnBooksNewForm.TabIndex = 46;
            this.btnBooksNewForm.Text = "جدید";
            this.btnBooksNewForm.UseVisualStyleBackColor = false;
            this.btnBooksNewForm.Click += new System.EventHandler(this.btnBooksNewForm_Click);
            // 
            // btnBooksSubmitForm
            // 
            this.btnBooksSubmitForm.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBooksSubmitForm.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksSubmitForm.Location = new System.Drawing.Point(86, 271);
            this.btnBooksSubmitForm.Name = "btnBooksSubmitForm";
            this.btnBooksSubmitForm.Size = new System.Drawing.Size(198, 28);
            this.btnBooksSubmitForm.TabIndex = 45;
            this.btnBooksSubmitForm.Text = "ثبت";
            this.btnBooksSubmitForm.UseVisualStyleBackColor = false;
            this.btnBooksSubmitForm.Click += new System.EventHandler(this.btnBooksSubmitForm_Click);
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksName.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksName.Location = new System.Drawing.Point(609, 53);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksName.Size = new System.Drawing.Size(71, 29);
            this.lblBooksName.TabIndex = 32;
            this.lblBooksName.Text = "نام کتاب :";
            this.lblBooksName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBooksImportPic
            // 
            this.btnBooksImportPic.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBooksImportPic.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksImportPic.Location = new System.Drawing.Point(86, 225);
            this.btnBooksImportPic.Name = "btnBooksImportPic";
            this.btnBooksImportPic.Size = new System.Drawing.Size(198, 28);
            this.btnBooksImportPic.TabIndex = 44;
            this.btnBooksImportPic.Text = "درج تصویر";
            this.btnBooksImportPic.UseVisualStyleBackColor = false;
            this.btnBooksImportPic.Click += new System.EventHandler(this.btnImportPic_Click);
            // 
            // lblBooksPublisher
            // 
            this.lblBooksPublisher.AutoSize = true;
            this.lblBooksPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksPublisher.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksPublisher.Location = new System.Drawing.Point(609, 173);
            this.lblBooksPublisher.Name = "lblBooksPublisher";
            this.lblBooksPublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksPublisher.Size = new System.Drawing.Size(77, 29);
            this.lblBooksPublisher.TabIndex = 33;
            this.lblBooksPublisher.Text = "انتشارات :";
            this.lblBooksPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBooksReleaseYear
            // 
            this.txtBooksReleaseYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksReleaseYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksReleaseYear.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksReleaseYear.Location = new System.Drawing.Point(442, 215);
            this.txtBooksReleaseYear.MaxLength = 4;
            this.txtBooksReleaseYear.Name = "txtBooksReleaseYear";
            this.txtBooksReleaseYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksReleaseYear.Size = new System.Drawing.Size(147, 30);
            this.txtBooksReleaseYear.TabIndex = 42;
            this.txtBooksReleaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBooksReleaseYear.TextChanged += new System.EventHandler(this.txtBooksReleaseYear_TextChanged);
            this.txtBooksReleaseYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldNumber_KeyPress);
            // 
            // lblBooksAuthor
            // 
            this.lblBooksAuthor.AutoSize = true;
            this.lblBooksAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksAuthor.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksAuthor.Location = new System.Drawing.Point(609, 93);
            this.lblBooksAuthor.Name = "lblBooksAuthor";
            this.lblBooksAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksAuthor.Size = new System.Drawing.Size(52, 29);
            this.lblBooksAuthor.TabIndex = 34;
            this.lblBooksAuthor.Text = "مولف :";
            this.lblBooksAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBooksPublisher
            // 
            this.txtBooksPublisher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksPublisher.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksPublisher.Location = new System.Drawing.Point(396, 175);
            this.txtBooksPublisher.MaxLength = 20;
            this.txtBooksPublisher.Name = "txtBooksPublisher";
            this.txtBooksPublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksPublisher.Size = new System.Drawing.Size(193, 30);
            this.txtBooksPublisher.TabIndex = 41;
            this.txtBooksPublisher.Text = "          ";
            this.txtBooksPublisher.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtBooksPublisher.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtBooksPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtBooksPublisher.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblBooksSubject
            // 
            this.lblBooksSubject.AutoSize = true;
            this.lblBooksSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksSubject.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksSubject.Location = new System.Drawing.Point(609, 253);
            this.lblBooksSubject.Name = "lblBooksSubject";
            this.lblBooksSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksSubject.Size = new System.Drawing.Size(62, 29);
            this.lblBooksSubject.TabIndex = 35;
            this.lblBooksSubject.Text = "موضوع :";
            this.lblBooksSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBooksTranslator
            // 
            this.txtBooksTranslator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksTranslator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksTranslator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksTranslator.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksTranslator.Location = new System.Drawing.Point(338, 135);
            this.txtBooksTranslator.MaxLength = 30;
            this.txtBooksTranslator.Name = "txtBooksTranslator";
            this.txtBooksTranslator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksTranslator.Size = new System.Drawing.Size(251, 30);
            this.txtBooksTranslator.TabIndex = 40;
            this.txtBooksTranslator.Text = "          ";
            this.txtBooksTranslator.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtBooksTranslator.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtBooksTranslator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtBooksTranslator.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblBooksReleaseYear
            // 
            this.lblBooksReleaseYear.AutoSize = true;
            this.lblBooksReleaseYear.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksReleaseYear.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksReleaseYear.Location = new System.Drawing.Point(609, 213);
            this.lblBooksReleaseYear.Name = "lblBooksReleaseYear";
            this.lblBooksReleaseYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksReleaseYear.Size = new System.Drawing.Size(74, 29);
            this.lblBooksReleaseYear.TabIndex = 36;
            this.lblBooksReleaseYear.Text = "سال چاپ :";
            this.lblBooksReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBooksAuthor
            // 
            this.txtBooksAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksAuthor.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksAuthor.Location = new System.Drawing.Point(338, 95);
            this.txtBooksAuthor.MaxLength = 30;
            this.txtBooksAuthor.Name = "txtBooksAuthor";
            this.txtBooksAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksAuthor.Size = new System.Drawing.Size(251, 30);
            this.txtBooksAuthor.TabIndex = 39;
            this.txtBooksAuthor.Text = "          ";
            this.txtBooksAuthor.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtBooksAuthor.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtBooksAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWord_KeyPress);
            this.txtBooksAuthor.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // lblBooksTranslator
            // 
            this.lblBooksTranslator.AutoSize = true;
            this.lblBooksTranslator.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksTranslator.Font = new System.Drawing.Font("Yekan B++", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksTranslator.Location = new System.Drawing.Point(609, 133);
            this.lblBooksTranslator.Name = "lblBooksTranslator";
            this.lblBooksTranslator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooksTranslator.Size = new System.Drawing.Size(58, 29);
            this.lblBooksTranslator.TabIndex = 37;
            this.lblBooksTranslator.Text = "مترجم :";
            this.lblBooksTranslator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBooksName
            // 
            this.txtBooksName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBooksName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBooksName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBooksName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksName.Font = new System.Drawing.Font("Yekan Bakh Medium", 11F);
            this.txtBooksName.Location = new System.Drawing.Point(338, 55);
            this.txtBooksName.MaxLength = 50;
            this.txtBooksName.Name = "txtBooksName";
            this.txtBooksName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooksName.Size = new System.Drawing.Size(251, 30);
            this.txtBooksName.TabIndex = 38;
            this.txtBooksName.Text = "          ";
            this.txtBooksName.TextChanged += new System.EventHandler(this.TXTField_TextChanged);
            this.txtBooksName.Enter += new System.EventHandler(this.TXTField_Enter);
            this.txtBooksName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFieldWordNumber_KeyPress);
            this.txtBooksName.Leave += new System.EventHandler(this.TXTField_Leave);
            // 
            // pnlBooksCBOBorder
            // 
            this.pnlBooksCBOBorder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBooksCBOBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBooksCBOBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBooksCBOBorder.Location = new System.Drawing.Point(442, 254);
            this.pnlBooksCBOBorder.Name = "pnlBooksCBOBorder";
            this.pnlBooksCBOBorder.Size = new System.Drawing.Size(147, 32);
            this.pnlBooksCBOBorder.TabIndex = 52;
            this.pnlBooksCBOBorder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboBooksSubject_MouseClick);
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Interval = 1000;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenuBooks);
            this.Controls.Add(this.lblMenuMembers);
            this.Controls.Add(this.lblMenuSearch);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlBooks);
            this.Controls.Add(this.pnlMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه کتابخانه";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Other_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.pnlMembers.ResumeLayout(false);
            this.pnlMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMembersUser)).EndInit();
            this.pnlBooks.ResumeLayout(false);
            this.pnlBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchUserField;
        private System.Windows.Forms.Label lblSearchUsername;
        private System.Windows.Forms.Button btnSearchLoginAdmin;
        private System.Windows.Forms.Label lblMenuSearch;
        private System.Windows.Forms.Label lblMenuMembers;
        private System.Windows.Forms.Label lblMenuBooks;
        private System.Windows.Forms.RadioButton rdoSearchBookName;
        private System.Windows.Forms.RadioButton rdoSearchReleaseYear;
        private System.Windows.Forms.RadioButton rdoSearchSubject;
        private System.Windows.Forms.RadioButton rdoSearchAuthorName;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Label lblSearchBookName;
        private System.Windows.Forms.TextBox txtSearchAuthorName;
        private System.Windows.Forms.Label lblSearchAuthorName;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.Label lblSearchSubject;
        private System.Windows.Forms.TextBox txtSearchReleaseYear;
        private System.Windows.Forms.Label lblSearchReleaseYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchDel;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Panel pnlMembers;
        private System.Windows.Forms.PictureBox picMembersUser;
        private System.Windows.Forms.Button btnMembersNewForm;
        private System.Windows.Forms.Button btnMembersSubmitForm;
        private System.Windows.Forms.Button btnMembersImportPic;
        private System.Windows.Forms.TextBox txtMembersTel;
        private System.Windows.Forms.TextBox txtMembersNationalCode;
        private System.Windows.Forms.TextBox txtMembersLastName;
        private System.Windows.Forms.TextBox txtMembersFirstName;
        private System.Windows.Forms.TextBox txtMembersRegistrationCode;
        private System.Windows.Forms.Label lblMembersLastName;
        private System.Windows.Forms.Label lblMembersTel;
        private System.Windows.Forms.Label lblMembersAddress;
        private System.Windows.Forms.Label lblMembersFirstName;
        private System.Windows.Forms.Label lblMembersNationalCode;
        private System.Windows.Forms.Label lblMembersRegistrationCode;
        private System.Windows.Forms.RichTextBox rtbMembersAddress;
        private System.Windows.Forms.Panel pnlMembersRTBBorder;
        private System.Windows.Forms.Label lblMembersCharCountRegistrationCode;
        private System.Windows.Forms.Label lblMembersCharCountTel;
        private System.Windows.Forms.Label lblMembersCharCountNationalCode;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private System.Windows.Forms.ToolTip tipImportPic;
        private System.Windows.Forms.Panel pnlBooks;
        private System.Windows.Forms.Button btnBooksNewForm;
        private System.Windows.Forms.Button btnBooksSubmitForm;
        private System.Windows.Forms.Button btnBooksImportPic;
        private System.Windows.Forms.TextBox txtBooksReleaseYear;
        private System.Windows.Forms.TextBox txtBooksPublisher;
        private System.Windows.Forms.TextBox txtBooksTranslator;
        private System.Windows.Forms.TextBox txtBooksAuthor;
        private System.Windows.Forms.TextBox txtBooksName;
        private System.Windows.Forms.Label lblBooksTranslator;
        private System.Windows.Forms.Label lblBooksReleaseYear;
        private System.Windows.Forms.Label lblBooksSubject;
        private System.Windows.Forms.Label lblBooksAuthor;
        private System.Windows.Forms.Label lblBooksPublisher;
        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.Label lblBooksISBN;
        private System.Windows.Forms.TextBox txtBooksISBN;
        private System.Windows.Forms.PictureBox picBooks;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.ComboBox cboBooksSubject;
        private System.Windows.Forms.Panel pnlBooksCBOBorder;
    }
}

