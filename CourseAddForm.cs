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

namespace WinFormsApp_D
{
    public partial class CourseAddForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public CourseAddForm()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string CourseCode = TextBox.Text;
            string CourseName = textBox1.Text;
            string Description = textBox2.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TOP 1 CourseID FROM Course ORDER BY CourseID DESC";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    var result = command1.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestID))
                    {
                        int newID = latestID + 1;

                        string query = "INSERT INTO Course (CourseID, CourseCode, CourseName, Description) " +
                                       "VALUES (@CourseID, @CourseCode, @CourseName, @Description)";

                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@CourseID", newID);
                            command2.Parameters.AddWithValue("@CourseCode", CourseCode);
                            command2.Parameters.AddWithValue("@CourseName", CourseName);
                            command2.Parameters.AddWithValue("@Description", Description);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Ders başarıyla eklendi!");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ders Eklenmedi Girilen Bilgileri Kontrol Ediniz.");
                    }
                }
            }
        }

        private void CourseAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
