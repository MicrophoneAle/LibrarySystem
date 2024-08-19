using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmLogin2 : Form
    {
        Form1 frm;
        public frmLogin2(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbluser WHERE User_name= '" + UsernameTextBox.Text + "' and Pass = '" + PasswordTextBox.Text + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome to Library System");
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist. Please contact administrator.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
