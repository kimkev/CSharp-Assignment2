/* Assignment 2 Task 1: Books form
 * Kevin Kim 
 * 991 456 570
 * June 13, 2018
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment2a
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlConnection cnn;
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Books";
            connectionString = "Data Source=DESKTOP-4P2PB1M\\SQLEXPRESS;" +
                              "Initial Catalog = MegaBookDB;" +
                              "Integrated Security = SSPI; " +
                              "Persist Security Info = false";

            cnn = new SqlConnection(connectionString);
        }

        // event handler for add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("Insert into dbo.BOOKS values(@bookname, @author," +
                                         "@publishdate, @ISBN)", cnn);

                command.Parameters.AddWithValue("@bookname", this.txtName.Text);
                command.Parameters.AddWithValue("@author", this.txtAuthor.Text);
                command.Parameters.AddWithValue("@publishdate", this.txtDate.Text);
                command.Parameters.AddWithValue("@ISBN", this.txtISBN.Text);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book record added");

                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        // event handler for view button
        private void btnView_Click(object sender, EventArgs e)
        {
            string queryString = "select * from dbo.BOOKS";

            try
            {

                // empty out the listbox first
                this.lstBook.Items.Clear();

                cnn.Open();
                command = new SqlCommand(queryString, cnn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    this.lstBook.Items.Add(
                        "Id: " + reader["Id"].ToString() + "  " +
                        "Name: " + reader["Name"].ToString() + "  " +
                        "Author: " + reader["Author"].ToString() + "  " +
                        "Published Date: " + reader["PublishDate"].ToString().Substring(0, 10) + "  " +
                        "ISBN: " + reader["ISBN"].ToString());
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        // event handler for edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("update dbo.BOOKS set Name = @bookname, Author = @author," +
                                         "PublishDate = @publishdate, ISBN = @ISBN " +
                                         "where id = @id", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                string bookid = str.Substring(4, str.IndexOf(" ") - 1);

                command.Parameters.AddWithValue("@bookname", this.txtName.Text);
                command.Parameters.AddWithValue("@author", this.txtAuthor.Text);
                command.Parameters.AddWithValue("@publishdate", this.txtDate.Text);
                command.Parameters.AddWithValue("@ISBN", this.txtISBN.Text);
                command.Parameters.AddWithValue("@id", bookid);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book record updated");

                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        // event handler for delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("delete from dbo.BOOKS where id = @id", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                string bookid = str.Substring(4, str.IndexOf(" ") -1);

                command.Parameters.AddWithValue("@id", bookid);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book record deleted");

                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
