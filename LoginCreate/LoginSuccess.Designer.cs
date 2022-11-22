namespace LoginCreate
{
    partial class LoginSuccessForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAbstract = new System.Windows.Forms.TextBox();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.lblInstruments = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblMajorSector = new System.Windows.Forms.Label();
            this.cboMajorSector = new System.Windows.Forms.ComboBox();
            this.cboMinorSector = new System.Windows.Forms.ComboBox();
            this.lblMinorSector = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRiskRating = new System.Windows.Forms.Label();
            this.cboRiskRating = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBrowsIdea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1324, 446);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(239, 82);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(148, 183);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(257, 178);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(270, 35);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtAbstract
            // 
            this.txtAbstract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbstract.Location = new System.Drawing.Point(257, 254);
            this.txtAbstract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAbstract.MaxLength = 30;
            this.txtAbstract.Name = "txtAbstract";
            this.txtAbstract.Size = new System.Drawing.Size(270, 35);
            this.txtAbstract.TabIndex = 1;
            this.txtAbstract.TextChanged += new System.EventHandler(this.txtAbstract_TextChanged);
            // 
            // lblAbstract
            // 
            this.lblAbstract.AutoSize = true;
            this.lblAbstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstract.Location = new System.Drawing.Point(103, 258);
            this.lblAbstract.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Size = new System.Drawing.Size(99, 29);
            this.lblAbstract.TabIndex = 3;
            this.lblAbstract.Text = "Abstract";
            this.lblAbstract.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishDate.Location = new System.Drawing.Point(58, 337);
            this.lblPublishDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(149, 29);
            this.lblPublishDate.TabIndex = 5;
            this.lblPublishDate.Text = "Publish Date";
            this.lblPublishDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 331);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 35);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(257, 410);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(271, 35);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(71, 410);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(135, 29);
            this.lblExpiryDate.TabIndex = 7;
            this.lblExpiryDate.Text = "Expiry Date";
            this.lblExpiryDate.Click += new System.EventHandler(this.lblExpiryDate_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(257, 492);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAuthor.MaxLength = 30;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(270, 35);
            this.txtAuthor.TabIndex = 4;
            this.txtAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(115, 492);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 29);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(103, 722);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(96, 29);
            this.lblContent.TabIndex = 13;
            this.lblContent.Text = "Content";
            this.lblContent.Click += new System.EventHandler(this.lblContent_Click);
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(257, 720);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(970, 191);
            this.txtContent.TabIndex = 13;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(753, 178);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(157, 29);
            this.lblProductType.TabIndex = 15;
            this.lblProductType.Text = "Product Type";
            this.lblProductType.Click += new System.EventHandler(this.lblProductType_Click);
            // 
            // txtProductType
            // 
            this.txtProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType.Location = new System.Drawing.Point(957, 172);
            this.txtProductType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductType.MaxLength = 30;
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(270, 35);
            this.txtProductType.TabIndex = 6;
            // 
            // txtInstruments
            // 
            this.txtInstruments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruments.Location = new System.Drawing.Point(957, 254);
            this.txtInstruments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInstruments.MaxLength = 30;
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(270, 35);
            this.txtInstruments.TabIndex = 7;
            // 
            // lblInstruments
            // 
            this.lblInstruments.AutoSize = true;
            this.lblInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruments.Location = new System.Drawing.Point(770, 258);
            this.lblInstruments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruments.Name = "lblInstruments";
            this.lblInstruments.Size = new System.Drawing.Size(136, 29);
            this.lblInstruments.TabIndex = 17;
            this.lblInstruments.Text = "Instruments";
            this.lblInstruments.Click += new System.EventHandler(this.lblInstruments_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.Location = new System.Drawing.Point(957, 335);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrency.MaxLength = 30;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(270, 35);
            this.txtCurrency.TabIndex = 8;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(799, 336);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(109, 29);
            this.lblCurrency.TabIndex = 19;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.Click += new System.EventHandler(this.lblCurrency_Click);
            // 
            // lblMajorSector
            // 
            this.lblMajorSector.AutoSize = true;
            this.lblMajorSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorSector.Location = new System.Drawing.Point(760, 410);
            this.lblMajorSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajorSector.Name = "lblMajorSector";
            this.lblMajorSector.Size = new System.Drawing.Size(150, 29);
            this.lblMajorSector.TabIndex = 21;
            this.lblMajorSector.Text = "Major Sector";
            this.lblMajorSector.Click += new System.EventHandler(this.lblMAjorSector_Click);
            // 
            // cboMajorSector
            // 
            this.cboMajorSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMajorSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMajorSector.FormattingEnabled = true;
            this.cboMajorSector.Location = new System.Drawing.Point(957, 410);
            this.cboMajorSector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMajorSector.Name = "cboMajorSector";
            this.cboMajorSector.Size = new System.Drawing.Size(271, 37);
            this.cboMajorSector.TabIndex = 9;
            this.cboMajorSector.SelectedIndexChanged += new System.EventHandler(this.cboMajorSector_SelectedIndexChanged);
            // 
            // cboMinorSector
            // 
            this.cboMinorSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinorSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMinorSector.FormattingEnabled = true;
            this.cboMinorSector.Location = new System.Drawing.Point(957, 492);
            this.cboMinorSector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMinorSector.Name = "cboMinorSector";
            this.cboMinorSector.Size = new System.Drawing.Size(271, 37);
            this.cboMinorSector.TabIndex = 10;
            this.cboMinorSector.SelectedIndexChanged += new System.EventHandler(this.cboMinorSector_SelectedIndexChanged);
            // 
            // lblMinorSector
            // 
            this.lblMinorSector.AutoSize = true;
            this.lblMinorSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinorSector.Location = new System.Drawing.Point(760, 492);
            this.lblMinorSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinorSector.Name = "lblMinorSector";
            this.lblMinorSector.Size = new System.Drawing.Size(150, 29);
            this.lblMinorSector.TabIndex = 23;
            this.lblMinorSector.Text = "Minor Sector";
            this.lblMinorSector.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtRegion
            // 
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(957, 562);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegion.MaxLength = 30;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(270, 35);
            this.txtRegion.TabIndex = 11;
            this.txtRegion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(802, 562);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(91, 29);
            this.lblRegion.TabIndex = 26;
            this.lblRegion.Text = "Region";
            this.lblRegion.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(957, 639);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountry.MaxLength = 30;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(270, 35);
            this.txtCountry.TabIndex = 12;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(802, 639);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(95, 29);
            this.lblCountry.TabIndex = 28;
            this.lblCountry.Text = "Country";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(208, 34);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(188, 46);
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblRiskRating
            // 
            this.lblRiskRating.AutoSize = true;
            this.lblRiskRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskRating.Location = new System.Drawing.Point(69, 567);
            this.lblRiskRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiskRating.Name = "lblRiskRating";
            this.lblRiskRating.Size = new System.Drawing.Size(135, 29);
            this.lblRiskRating.TabIndex = 31;
            this.lblRiskRating.Text = "Risk Rating";
            this.lblRiskRating.Click += new System.EventHandler(this.lblRiskRating_Click);
            // 
            // cboRiskRating
            // 
            this.cboRiskRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRiskRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRiskRating.FormattingEnabled = true;
            this.cboRiskRating.Location = new System.Drawing.Point(257, 572);
            this.cboRiskRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRiskRating.Name = "cboRiskRating";
            this.cboRiskRating.Size = new System.Drawing.Size(457, 37);
            this.cboRiskRating.TabIndex = 5;
            this.cboRiskRating.SelectedIndexChanged += new System.EventHandler(this.cboRiskRating_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1319, 172);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 84);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit Your Idea";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // btnBrowsIdea
            // 
            this.btnBrowsIdea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsIdea.Location = new System.Drawing.Point(1324, 307);
            this.btnBrowsIdea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowsIdea.Name = "btnBrowsIdea";
            this.btnBrowsIdea.Size = new System.Drawing.Size(239, 83);
            this.btnBrowsIdea.TabIndex = 34;
            this.btnBrowsIdea.Text = "Browse Ideas";
            this.btnBrowsIdea.UseVisualStyleBackColor = true;
            this.btnBrowsIdea.Click += new System.EventHandler(this.btnBrowsIdea_Click);
            // 
            // LoginSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1636, 1083);
            this.Controls.Add(this.btnBrowsIdea);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboRiskRating);
            this.Controls.Add(this.lblRiskRating);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboMinorSector);
            this.Controls.Add(this.lblMinorSector);
            this.Controls.Add(this.cboMajorSector);
            this.Controls.Add(this.lblMajorSector);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.txtInstruments);
            this.Controls.Add(this.lblInstruments);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPublishDate);
            this.Controls.Add(this.txtAbstract);
            this.Controls.Add(this.lblAbstract);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginSuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Success Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginSuccessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAbstract;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtInstruments;
        private System.Windows.Forms.Label lblInstruments;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblMajorSector;
        private System.Windows.Forms.ComboBox cboMajorSector;
        private System.Windows.Forms.ComboBox cboMinorSector;
        private System.Windows.Forms.Label lblMinorSector;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRiskRating;
        private System.Windows.Forms.ComboBox cboRiskRating;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBrowsIdea;
    }
}