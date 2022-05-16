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
    public partial class frmEditCustomerDetail : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=customerDetail;Integrated Security=True");
        public frmEditCustomerDetail()
        {
            InitializeComponent();
        }

        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void frmEditCustomerDetail_Load(object sender, EventArgs e)
        {
            string sql = "select * from Country";
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            cbCountry.DataSource = dt;
            cbCountry.DisplayMember = "Country";
            cbCountry.ValueMember = "id";

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [dbo].[bae]([name],[Adress],[zip],[city],[country],[phone],[email])VALUES('" + txtName.Text + "','" + txtAdress.Text + "','" + txtZip.Text + "','" + txtCity.Text + "','" + cbCountry.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved in Database");
            con.Close();
        }
        private void btBackToMenu_Click(object sender,EventArgs e)
        {
            frmDataCollection dtm = new frmDataCollection();
            dtm.Show();
        }
    }
}
