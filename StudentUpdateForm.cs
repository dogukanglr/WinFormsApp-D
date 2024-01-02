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

namespace WinFormsApp_D
{
    public partial class StudentUpdateForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public StudentUpdateForm()
        {
            InitializeComponent();
            this.Load += StudentUpdateForm_Load;
        }
        private void StudentUpdateForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID FROM Student"; // ComboBox'a aktarılacak sütun adı
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox1.DataSource = dataTable;
                    comboBox1.DisplayMember = "StudentID";
                    comboBox1.ValueMember = "StudentID"; // ComboBox'ta görüntülenecek sütun adı
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataRowView selectedRow2 = comboBox1.SelectedItem as DataRowView;
                int SelectedStudentID = Convert.ToInt32(selectedRow2["StudentID"]);

                string query = "SELECT * FROM Student WHERE StudentID = @StudentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", SelectedStudentID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NameTextBox.Text = reader["Name"].ToString();
                    SurnameTextBox.Text = reader["Surname"].ToString();
                    EmailTextBox.Text = reader["Email"].ToString();
                    PhoneNumberTextBox.Text = reader["PhoneNumber"].ToString();
                    DateOfBirthPicker.Value = (DateTime)reader["DateOfBirth"];

                    // Diğer öğrenci bilgilerini TextBox'lara yerleştir
                }

                reader.Close();
            }

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
                DataRowView selectedRow2 = comboBox1.SelectedItem as DataRowView;
                int SelectedStudentID = Convert.ToInt32(selectedRow2["StudentID"]);

                 string query = "UPDATE Student SET Name = @Name, Surname = @Surname, DateOfBirth = @DateOfBirth, Email = @Email, PhoneNumber = @PhoneNumber " +
                                 "WHERE StudentID = @StudentID";

                  using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@StudentID", SelectedStudentID);
                            command2.Parameters.AddWithValue("@Name", name);
                            command2.Parameters.AddWithValue("@Surname", surname);
                            command2.Parameters.AddWithValue("@DateOfBirth", dob);
                            command2.Parameters.AddWithValue("@Email", email);
                            command2.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Öğrenci başarıyla Güncellendi!");

                            this.Close();
                        }
                    
                
            }
        }
    }
}
