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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp_D
{
    public partial class ExamGradeAddForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public ExamGradeAddForm()
        {
            InitializeComponent();
            this.Load += ExamGradeAddForm_Load;
        }

        private void ExamGradeAddForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID FROM Student"; // ComboBox'a aktarılacak sütun adı
                string query2 = "SELECT CourseID FROM Course"; // ComboBox'a aktarılacak sütun adı
                string query3 = "SELECT SectionID FROM Section"; // ComboBox'a aktarılacak sütun adı
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
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "CourseID";
                    comboBox2.ValueMember = "CourseID"; // ComboBox'ta görüntülenecek sütun adı
                }
                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox3.DataSource = dataTable;
                    comboBox3.DisplayMember = "SectionID"; // ComboBox'ta görüntülenecek sütun adı
                    comboBox3.ValueMember = "SectionID";
                }


            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            //int StudentID = Convert.ToInt32(SelectedRow[StudentID]);
            int StudentID = Convert.ToInt32(selectedRow["StudentID"]);

            DataRowView selectedRow2 = comboBox2.SelectedItem as DataRowView;
            //int CourseID = Convert.ToInt32(comboBox2.SelectedItem);
            int CourseID = Convert.ToInt32(selectedRow2["CourseID"]);

            DataRowView selectedRow3 = comboBox3.SelectedItem as DataRowView;
            //int SectionID = Convert.ToInt32(comboBox3.SelectedItem);
            int SectionID = Convert.ToInt32(selectedRow3["SectionID"]);

            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            float Grade = Convert.ToInt32(comboBox4.SelectedItem);
            
            //MessageBox.Show(StudentID + " " + CourseID + " " + SectionID + " " +Grade);

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TOP 1 ExamID FROM ExamGrades ORDER BY ExamID DESC";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    var result = command1.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestID))
                    {
                        int newID = latestID + 1;

                        string query = "INSERT INTO ExamGrades (ExamID, StudentID, CourseID, SectionID, ExamDate, Grade) " +
                                       "VALUES (@ExamID, @StudentID, @CourseID, @SectionID, @ExamDate, @Grade )";

                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@ExamID", newID);
                            command2.Parameters.AddWithValue("@StudentID", StudentID);
                            command2.Parameters.AddWithValue("@CourseID", CourseID);
                            command2.Parameters.AddWithValue("@SectionID", SectionID);
                            command2.Parameters.AddWithValue("@ExamDate", dob);
                            command2.Parameters.AddWithValue("@Grade", Grade);

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Not başarıyla eklendi!");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Eklenmedi Girilen Bilgileri Kontrol Ediniz.");
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
