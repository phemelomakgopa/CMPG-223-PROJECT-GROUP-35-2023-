using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG_223_PROJECT_GROUP35
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=.\SQLEXPRESS01;Initial Catalog=LEHLABILE HOTEL DB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("With great power comes great resposibility. I am also batman");

        }
    }
}
