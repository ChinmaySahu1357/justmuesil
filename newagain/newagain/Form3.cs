using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newagain
{
    public partial class frmDataCollection : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=customerDetail;Integrated Security=True");
        public frmDataCollection()
        {
            InitializeComponent();
        }

       

        

        private void frmDataCollection_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from bae";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
