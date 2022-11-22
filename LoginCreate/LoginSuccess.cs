using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginCreate
{
    public partial class LoginSuccessForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public LoginSuccessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm1 = new LoginForm();
            frm1.ShowDialog();
        }

        private void LoginSuccessForm_Load(object sender, EventArgs e)
        {
            
            lblWelcome.Text = "Welcome : ";

            cboRiskRating.Items.Add("1 - Suitable for very conservative investors");
            cboRiskRating.Items.Add("2 - Suitable for conservative investors");
            cboRiskRating.Items.Add("3 - Suitable for moderate investors");
            cboRiskRating.Items.Add("4 - Suitable for aggressive investors");
            cboRiskRating.Items.Add("5 - Suitable for very aggressive investors");

            cboMajorSector.Items.Add("1-Technology");
            cboMajorSector.Items.Add("2-Healthcare");
            cboMajorSector.Items.Add("3-Financial");
            cboMajorSector.Items.Add("4-Energy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO loginform.idea(`Title`,`Abstract`,`PublishDate`) VALUES ('" + txtTitle.Text + "','" + txtAbstract.Text + "', '" + dateTimePicker1 + "' )";
            connection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(insertQuery, connection);
               
                try
                { 
                     if (commandDatabase.ExecuteNonQuery() == 1)
                     {
                         MessageBox.Show("Investemtn Idea Successfully Created!");
                     }
                     else
                     {
                         MessageBox.Show("Data not Inserted");   
                     }
                }          
                                
               
                catch (Exception ex)
                {
                  
                    MessageBox.Show(ex.Message);
                }                        
                          

                 connection.Close();

            }

        private void btnBrowsIdea_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblExpiryDate_Click(object sender, EventArgs e)
        {

        }

        private void lblRiskRating_Click(object sender, EventArgs e)
        {

        }

        private void lblProductType_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruments_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void lblMAjorSector_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void cboRiskRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMajorSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMinorSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAbstract_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
