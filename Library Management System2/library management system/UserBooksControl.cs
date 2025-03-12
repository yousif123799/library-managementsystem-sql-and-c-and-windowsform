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
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library_management_system
{
    public partial class UserBooksControl : UserControl
    {
        private static UserBooksControl _instance;

        public static UserBooksControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserBooksControl();
                }
                return _instance;
            }
        }
        public UserBooksControl()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_library.mdf;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {
            string accNo = panel1.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("SearchBook_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", accNo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   <<<<Invalid SQL Operation>>>> : \n" + ex);
                }
                conn.Close();
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_sp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", panel2.Text);
            cmd.Parameters.AddWithValue("@author", panel6.Text);
            cmd.Parameters.AddWithValue("@publisher", panel5.Text);
            cmd.Parameters.AddWithValue("@isbn", panel4.Text);
            cmd.Parameters.AddWithValue("@name", panel3.Text);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("   <<<<Invalid SQL Operation>>>>" + ex);
            }
            conn.Close();
            refresh_datagrid_view();
        }

        private void UserBooksControl_Load(object sender, EventArgs e)
        {
            refresh_datagrid_view();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void refresh_datagrid_view()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showallboxdata_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   <<<<Invalid SQL Operation>>>> : \n" + ex);
                }
                conn.Close();
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;





            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", panel2.Text);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   <<<<Invalid SQL Operation>>>> : \n" + ex);
                }
                conn.Close();
                refresh_datagrid_view();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Text = "";
            panel2.Text = "";
            panel3.Text = "";
            panel4.Text = "";
            panel5.Text = "";
            panel6.Text = "";
            refresh_datagrid_view();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
