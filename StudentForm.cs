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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp_D
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertStudentButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string dob = DateOfBirthPicker.Value.ToString("yyyy-MM-dd");
            string email = EmailTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TOP 1 StudentID FROM Student ORDER BY StudentID DESC";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    var result = command1.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestStudentID))
                    {
                        int newStudentID = latestStudentID + 1;

                        string query = "INSERT INTO Student (StudentID, Name, Surname, DateOfBirth, Email, PhoneNumber) " +
                                       "VALUES (@StudentID, @Name, @Surname, @DateOfBirth, @Email, @PhoneNumber)";

                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@StudentID", newStudentID);
                            command2.Parameters.AddWithValue("@Name", name);
                            command2.Parameters.AddWithValue("@Surname", surname);
                            command2.Parameters.AddWithValue("@DateOfBirth", dob);
                            command2.Parameters.AddWithValue("@Email", email);
                            command2.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Öğrenci başarıyla eklendi!");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Eklenmedi Girilen Bilgileri Kontrol Ediniz.");
                    }
                }
            }
        }
    }
}
