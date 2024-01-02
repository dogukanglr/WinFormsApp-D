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
    public partial class TeacherForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string email = EmailTextBox.Text;
            string department = comboBox1.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TOP 1 TeacherID FROM Teachers ORDER BY TeacherID DESC";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    var result = command1.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestTeacherID))
                    {
                        int newTeacherID = latestTeacherID + 1;

                        string query = "INSERT INTO Teachers (TeacherID, Firstname, Lastname, Email, Department) " +
                                       "VALUES (@TeacherID, @Name, @Surname, @Email, @department)";

                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@TeacherID", newTeacherID);
                            command2.Parameters.AddWithValue("@Name", name);
                            command2.Parameters.AddWithValue("@Surname", surname);
                            command2.Parameters.AddWithValue("@Email", email);
                            command2.Parameters.AddWithValue("@department", department);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Öğretmen başarıyla eklendi!");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen Eklenmedi Girilen Bilgileri Kontrol Ediniz.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
