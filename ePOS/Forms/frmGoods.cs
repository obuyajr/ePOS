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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace ePOS.Forms
{
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            // Define the insert query with parameters
            StrCmd = "INSERT INTO goods (, Age) VALUES (@Name, @Age)";
            

                // Create a SqlCommand object
                using (cmd = new SqlCommand(insertQuery, ))
{
                // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", );
                    cmd.Parameters.AddWithValue("@Age", age);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Show success message (optional)
                    MessageBox.Show("Data inserted successfully!");
                }
            }
    }
}
