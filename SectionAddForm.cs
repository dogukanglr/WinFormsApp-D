using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_D
{
    public partial class SectionAddForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public SectionAddForm()
        {
            InitializeComponent();
            this.Load += SectionAddForm_Load;
        }

        private void SectionAddForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CourseID FROM Course"; // ComboBox'a aktarılacak sütun adı
                string query2 = "SELECT TeacherID, FirstName , LastName FROM Teachers"; // ComboBox'a aktarılacak sütun adı
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "CourseID";
                    comboBox2.ValueMember = "CourseID"; // ComboBox'ta görüntülenecek sütun adı
                }
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    List<object> items = new List<object>();

                    while (reader.Read())
                    {
                        string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                        items.Add(new { DisplayName = fullName, Value = reader["TeacherID"] });
                    }

                    comboBox1.DataSource = items;
                    comboBox1.DisplayMember = "DisplayName";
                    comboBox1.ValueMember = "Value";
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Elle yazmayı engelle
                }

            }
        }

        private void InsertStudentButton_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow2 = comboBox2.SelectedItem as DataRowView;
            int CourseID = Convert.ToInt32(selectedRow2["CourseID"]);
            string name = NameTextBox.Text;
            string Date = DateOfBirthPicker.Value.ToString("yyyy-MM-dd");
            var selectedValue = comboBox1.SelectedItem as dynamic;
            int studentID = Convert.ToInt32(selectedValue.Value);
            string fullName = selectedValue.DisplayName;

            //MessageBox.Show(CourseID + " " + name + " " + fullName);
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TOP 1 SectionID FROM Section ORDER BY SectionID DESC";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    var result = command1.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestID))
                    {
                        int newID = latestID + 1;

                        string query = "INSERT INTO Section (SectionID, CourseID, SectionNumber, Date, Teacher) " +
                                       "VALUES (@SectionID, @CourseID, @SectionNumber, @Date, @Teacher )";

                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@SectionID", newID);
                            command2.Parameters.AddWithValue("@CourseID", CourseID);
                            command2.Parameters.AddWithValue("@SectionNumber", name);
                            command2.Parameters.AddWithValue("@Date", Date);
                            command2.Parameters.AddWithValue("@Teacher", fullName);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Section başarıyla eklendi!");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Section Eklenmedi Girilen Bilgileri Kontrol Ediniz.");
                    }
                }

            }
        }
    }
}
