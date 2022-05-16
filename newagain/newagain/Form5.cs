using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newagain
{
    public partial class frmMyMuesilMixes : Form
    {
        public frmMyMuesilMixes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMyMuesilMixes f = new frmMyMuesilMixes();
            f.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnBTM_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
        }
    }
}
