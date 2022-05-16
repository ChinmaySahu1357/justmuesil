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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdEnglish_CheckedChanged(object sender, EventArgs e)
        {
            btEditCoustemerDetail.Text = "Edit Muesils mixes";
            btMyMuesilsMix.Text = "My muesils mixes";
            btMix.Text = "mix";
            btOrder.Text = "Order";
            btExit.Text = "Exit";

        }

        private void rdHindi_CheckedChanged(object sender, EventArgs e)
        {
            btEditCoustemerDetail.Text = "ग्राहक विवरण संपादित करें";
            btMyMuesilsMix.Text = "माई मूसली मिक्स्ड";
            btMix.Text = "मिक्स";
            btOrder.Text = "आदेश";
            btExit.Text = "बाहर जाएं";
        }

        private void btEditCoustemerDetail_Click(object sender, EventArgs e)
        {
            frmEditCustomerDetail fr = new frmEditCustomerDetail();
            fr.Show();
        }

        private void btMix_Click(object sender, EventArgs e)
        {
            frmMixes f1 = new frmMixes();
            f1.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btMyMuesilsMix_Click(object sender, EventArgs e)
        {
            frmMyMuesilMixes f = new frmMyMuesilMixes();
            f.Show();
            
        }
    }
}
