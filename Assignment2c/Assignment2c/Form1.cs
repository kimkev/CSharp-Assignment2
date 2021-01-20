/* Assignment 2 Task 3: Book search form
 * Kevin Kim 
 * 991 456 570
 * June 13, 2018
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment2c
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
            this.Text = "Book Search";

            connectionString = "Data Source=DESKTOP-4P2PB1M\\SQLEXPRESS;" +
                              "Initial Catalog = MegaBookDB;" +
                              "Integrated Security = SSPI; " +
                              "Persist Security Info = false";

            cnn = new SqlConnection(connectionString);
        }

        // event handler for search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // empty out the 
                this.lstBooks.Items.Clear();

                cnn.Open();
                
                // search condition using provided input
                if (String.IsNullOrEmpty(this.txtBookId.Text) && String.IsNullOrEmpty(this.txtBookName.Text) &&
                    String.IsNullOrEmpty(this.txtReviewerName.Text))
                {
                    // alert for empty input
                    MessageBox.Show("Enter at least one search criteria");
                }
                else
                {
                    
                    command = new SqlCommand("SELECT * FROM dbo.BOOKS, dbo.REVIEWS " +
                                            "WHERE dbo.books.id = dbo.reviews.bookid " +
                                            "AND dbo.books.id = @bookid " +
                                            "OR dbo.books.name = @bookname " +
                                            "OR dbo.reviews.reviewer = @reviewername", cnn);

                    command.Parameters.AddWithValue("@bookid", this.txtBookId.Text);
                    command.Parameters.AddWithValue("@bookname", this.txtBookName.Text);
                    command.Parameters.AddWithValue("@reviewername", this.txtReviewerName.Text);


                    SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            this.lstBooks.Items.Add(
                                "BookID: " + reader["BookID"].ToString() + "  " +
                                "Book: " + reader["Name"].ToString() + "  " +
                                "Reviewer: " + reader["Reviewer"].ToString() + "  " +
                                "Rating: " + reader["Rating"].ToString() + Environment.NewLine + Environment.NewLine);
                        }
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

        // event handler for clear button
        private void button1_Click(object sender, EventArgs e)
        {
            this.txtBookId.Clear();
            this.txtBookName.Clear();
            this.txtReviewerName.Clear();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
