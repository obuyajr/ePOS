using ePOS.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePOS.Forms
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            label1.Text = sysPublic.loggedInUserName;
             

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnFrontOffice_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            frmFrontOffice newForm = new frmFrontOffice();

            // Show the new form
            newForm.Show();
        }

        private void btnBackOffice_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            frmBackOffice newForm = new frmBackOffice();

            // Show the new form
            newForm.Show();
        }
    }
}
