namespace LibrarySystem
{
    partial class frmBooks2
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
            this.lblAccessionNo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDatePublish = new System.Windows.Forms.Label();
            this.txtAccessionNo = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.dtpDatePublish = new System.Windows.Forms.DateTimePicker();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDeweyDecimal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtDeweyDecimal = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccessionNo
            // 
            this.lblAccessionNo.AutoSize = true;
            this.lblAccessionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessionNo.Location = new System.Drawing.Point(27, 20);
            this.lblAccessionNo.Name = "lblAccessionNo";
            this.lblAccessionNo.Size = new System.Drawing.Size(122, 20);
            this.lblAccessionNo.TabIndex = 0;
            this.lblAccessionNo.Text = "Accession No.:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(49, 86);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(86, 119);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 20);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            // 
            // lblDatePublish
            // 
            this.lblDatePublish.AutoSize = true;
            this.lblDatePublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePublish.Location = new System.Drawing.Point(21, 154);
            this.lblDatePublish.Name = "lblDatePublish";
            this.lblDatePublish.Size = new System.Drawing.Size(128, 20);
            this.lblDatePublish.TabIndex = 4;
            this.lblDatePublish.Text = "Date Published:";
            // 
            // txtAccessionNo
            // 
            this.txtAccessionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessionNo.Location = new System.Drawing.Point(155, 17);
            this.txtAccessionNo.Name = "txtAccessionNo";
            this.txtAccessionNo.Size = new System.Drawing.Size(337, 27);
            this.txtAccessionNo.TabIndex = 5;
            this.txtAccessionNo.TextChanged += new System.EventHandler(this.txtAccessionNo_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(155, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(337, 27);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(155, 83);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(337, 27);
            this.txtDesc.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(155, 116);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(337, 27);
            this.txtAuthor.TabIndex = 8;
            // 
            // dtpDatePublish
            // 
            this.dtpDatePublish.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatePublish.CustomFormat = "yyyy-MM-dd";
            this.dtpDatePublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatePublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePublish.Location = new System.Drawing.Point(155, 149);
            this.dtpDatePublish.Name = "dtpDatePublish";
            this.dtpDatePublish.Size = new System.Drawing.Size(200, 27);
            this.dtpDatePublish.TabIndex = 9;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(612, 20);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(84, 20);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(615, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Category:";
            // 
            // lblDeweyDecimal
            // 
            this.lblDeweyDecimal.AutoSize = true;
            this.lblDeweyDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeweyDecimal.Location = new System.Drawing.Point(564, 86);
            this.lblDeweyDecimal.Name = "lblDeweyDecimal";
            this.lblDeweyDecimal.Size = new System.Drawing.Size(132, 20);
            this.lblDeweyDecimal.TabIndex = 12;
            this.lblDeweyDecimal.Text = "Dewey Decimal:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(646, 119);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(702, 17);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(337, 27);
            this.txtPublisher.TabIndex = 14;
            // 
            // txtDeweyDecimal
            // 
            this.txtDeweyDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeweyDecimal.Location = new System.Drawing.Point(702, 83);
            this.txtDeweyDecimal.Name = "txtDeweyDecimal";
            this.txtDeweyDecimal.Size = new System.Drawing.Size(337, 27);
            this.txtDeweyDecimal.TabIndex = 15;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(702, 50);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(337, 28);
            this.cboCategory.TabIndex = 16;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Unknown",
            "Fiction",
            "Non-Fiction"});
            this.cboType.Location = new System.Drawing.Point(702, 115);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(337, 28);
            this.cboType.TabIndex = 17;
            this.cboType.Text = "Unknown";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(41, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(137, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 38);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(233, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 38);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(329, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(425, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(12, 256);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.RowHeadersWidth = 51;
            this.dtgList.RowTemplate.Height = 24;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(1086, 333);
            this.dtgList.TabIndex = 23;
            this.dtgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(688, 221);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 20);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(761, 218);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 27);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmBooks2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 601);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtDeweyDecimal);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDeweyDecimal);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.dtpDatePublish);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAccessionNo);
            this.Controls.Add(this.lblDatePublish);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAccessionNo);
            this.Name = "frmBooks2";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessionNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDatePublish;
        private System.Windows.Forms.TextBox txtAccessionNo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DateTimePicker dtpDatePublish;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDeweyDecimal;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtDeweyDecimal;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}