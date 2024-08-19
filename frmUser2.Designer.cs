namespace LibrarySystem
{
    partial class frmUser2
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.dtg_listUser = new System.Windows.Forms.DataGridView();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(190, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 23);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "id";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(194, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(365, 30);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(194, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(365, 30);
            this.txt_username.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(194, 107);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(365, 30);
            this.txt_password.TabIndex = 7;
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Librarian",
            "Assistant"});
            this.cbo_type.Location = new System.Drawing.Point(194, 143);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(365, 31);
            this.cbo_type.TabIndex = 8;
            // 
            // dtg_listUser
            // 
            this.dtg_listUser.AllowUserToAddRows = false;
            this.dtg_listUser.AllowUserToDeleteRows = false;
            this.dtg_listUser.AllowUserToResizeColumns = false;
            this.dtg_listUser.AllowUserToResizeRows = false;
            this.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listUser.Location = new System.Drawing.Point(23, 180);
            this.dtg_listUser.Name = "dtg_listUser";
            this.dtg_listUser.RowHeadersVisible = false;
            this.dtg_listUser.RowHeadersWidth = 51;
            this.dtg_listUser.RowTemplate.Height = 24;
            this.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listUser.Size = new System.Drawing.Size(796, 360);
            this.dtg_listUser.TabIndex = 9;
            this.dtg_listUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listUser_CellContentClick);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.Location = new System.Drawing.Point(23, 546);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(106, 42);
            this.btn_saveuser.TabIndex = 10;
            this.btn_saveuser.Text = "Save";
            this.btn_saveuser.UseVisualStyleBackColor = true;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(135, 546);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(106, 42);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(247, 546);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 42);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(359, 546);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(106, 42);
            this.btn_New.TabIndex = 13;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(471, 546);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 42);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmUser2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 600);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.dtg_listUser);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_id);
            this.Name = "frmUser2";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DataGridView dtg_listUser;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.TextBox txt_password;
        internal System.Windows.Forms.ComboBox cbo_type;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Button btn_close;
    }
}