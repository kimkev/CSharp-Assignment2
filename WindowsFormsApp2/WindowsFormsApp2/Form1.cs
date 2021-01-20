/* Assignment 2 Task 2: Reviews form
 * Kevin Kim 
 * 991 456 570
 * June 13, 2018
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment2b
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlConnection cnn;
        SqlCommand command;
        int counter;  // number of reviews added in this session

        public Form1()
        {
            InitializeComponent();
        }

        // establish connection during load, to show the list of books on file
        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;
            this.Text = "Reviews";
            connectionString = "Data Source=DESKTOP-4P2PB1M\\SQLEXPRESS;" +
                              "Initial Catalog = MegaBookDB;" +
                              "Integrated Security = SSPI; " +
                              "Persist Security Info = false";

            cnn = new SqlConnection(connectionString);



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


        //event handler for add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("Insert into dbo.REVIEWS values(@reviewer, @review," +
                                         "@date, @rating, @bookid)", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                string bookid = str.Substring(4, str.IndexOf(" ") - 1);

                command.Parameters.AddWithValue("@reviewer", this.txtReviewer.Text);
                command.Parameters.AddWithValue("@review", this.txtReview.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@rating", this.txtRating.Text);
                command.Parameters.AddWithValue("@bookid", bookid);
                

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book review added");

                this.txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                this.txtBookId.Text = bookid;



                // display review id upon addition of a review
                SqlCommand command2 = new SqlCommand("select * from dbo.REVIEWS where bookid = @id", cnn);

                string str2 = this.lstBook.SelectedItem.ToString();
                command2.Parameters.AddWithValue("@id", str.Substring(4, str.IndexOf(" ") - 1));

                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    this.txtId.Text = reader["Id"].ToString();
                }
                counter++;
                this.lblNumber.Text = "Number of reviews added this session: " + counter.ToString();
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
            try
            {

                // empty out the review box first
                this.txtReviews.Clear();



                cnn.Open();
                command = new SqlCommand("select * from dbo.REVIEWS where bookid = @id", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                command.Parameters.AddWithValue("@id", str.Substring(4, str.IndexOf(" ") - 1));

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    this.txtReviews.AppendText(
                        "Reviewer: " + reader["Reviewer"].ToString() + Environment.NewLine +
                        "Review: " + reader["Review"].ToString() + Environment.NewLine +
                        "Id: " + reader["Id"].ToString() + Environment.NewLine +
                        "Date: " + reader["Date"].ToString().Substring(0, 10) + Environment.NewLine +
                        "Rating: " + reader["Rating"].ToString() + Environment.NewLine +
                        "BookID: " + reader["BookID"].ToString() + Environment.NewLine + Environment.NewLine);
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

        //event handler for edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("update dbo.REVIEWS set Reviewer = @reviewer, Review = @review," +
                                         "Id = @id, Date = @date, Rating = @rating, BookID = @bookid", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                string bookid = str.Substring(4, str.IndexOf(" ") - 1);


                command.Parameters.AddWithValue("@reviewer", this.txtReviewer.Text);
                command.Parameters.AddWithValue("@review", this.txtReview.Text);
                command.Parameters.AddWithValue("@id", this.txtId.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@rating", this.txtRating.Text);
                command.Parameters.AddWithValue("@bookid", bookid);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book review updated");

                this.txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                this.txtBookId.Text = bookid;

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

        //event handler for delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                command = new SqlCommand("delete from dbo.REVIEWS where bookid = @id", cnn);

                string str = this.lstBook.SelectedItem.ToString();
                string bookid = str.Substring(4, str.IndexOf(" ") -1) ;

                command.Parameters.AddWithValue("@id", bookid);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Book review deleted");

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
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
