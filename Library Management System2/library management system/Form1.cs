using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database_library.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private string getUserName()
        {
            string userName = string.Empty;

            try
            {
                con.Open();
                string syntax = "SELECT Value FROM systemTable WHERE property= 'USERNAME'";
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    userName = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Username property not found in systemTable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching username: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return userName;
        }
        private string getPassword()
        {
            string password = string.Empty;

            try
            {
                con.Open();
                string syntax = "SELECT Value FROM systemTable WHERE property= 'Password'";
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    password = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Password property not found in systemTable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching password: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return password;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Li_Click(object sender, EventArgs e)
        {

        }

        private void eafd_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string uname = getUserName(),upassword= getPassword();
            string name, password;
            name = textBox2.Text;
            password = textBox1.Text;
            if (name.Equals(uname)&& upassword.Equals(password))
            {
                lab3.Visible = false;
                MessageBox.Show("Log In Success");
                AppBody appBody = new AppBody();
                this.Hide();
                appBody.Show();
            }
            else
            {
                lab3.Show();
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
