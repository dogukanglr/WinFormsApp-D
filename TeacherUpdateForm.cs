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
    public partial class TeacherUpdateForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public TeacherUpdateForm()
        {
            InitializeComponent();
            this.Load += TeacherUpdateForm_Load;
            //this.Size = (407, 415);
        }

        private void TeacherUpdateForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TeacherID FROM Teachers"; // ComboBox'a aktarılacak sütun adı
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "TeacherID";
                    comboBox2.ValueMember = "TeacherID"; // ComboBox'ta görüntülenecek sütun adı
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataRowView selectedRow2 = comboBox2.SelectedItem as DataRowView;
                int SelectedID = Convert.ToInt32(selectedRow2["TeacherID"]);

                string query = "SELECT * FROM Teachers WHERE TeacherID = @TeacherID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", SelectedID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NameTextBox.Text = reader["FirstName"].ToString();
                    SurnameTextBox.Text = reader["LastName"].ToString();
                    EmailTextBox.Text = reader["Email"].ToString();


                    // Diğer öğrenci bilgilerini TextBox'lara yerleştir
                }

                reader.Close();
            }
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

                DataRowView selectedRow2 = comboBox2.SelectedItem as DataRowView;
                int SelectedID = Convert.ToInt32(selectedRow2["TeacherID"]);


                string query = "UPDATE Teachers SET Firstname = @Name, Lastname = @Surname, Email = @Email, Department = @Department " +
               "WHERE TeacherID = @TeacherID";

                using (SqlCommand command2 = new SqlCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("@TeacherID", SelectedID);
                    command2.Parameters.AddWithValue("@Name", name);
                    command2.Parameters.AddWithValue("@Surname", surname);
                    command2.Parameters.AddWithValue("@Email", email);
                    command2.Parameters.AddWithValue("@Department", department);

                    command2.ExecuteNonQuery();

                    MessageBox.Show("Öğretmen başarıyla Güncellendi!");

                    this.Close();
                }


            }
        }
    }
}
