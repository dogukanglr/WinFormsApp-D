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
    public partial class GradeUpdateForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public GradeUpdateForm()
        {
            InitializeComponent();
            this.Load += GradeUpdateForm_Load;
        }

        private void GradeUpdateForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ExamID FROM ExamGrades"; // ComboBox'a aktarılacak sütun adı
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox5.DataSource = dataTable;
                    comboBox5.DisplayMember = "ExamID";
                    comboBox5.ValueMember = "ExamID"; // ComboBox'ta görüntülenecek sütun adı
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataRowView selectedRow2 = comboBox5.SelectedItem as DataRowView;
                int SelectedStudentID = Convert.ToInt32(selectedRow2["ExamID"]);

                string query = "SELECT * FROM ExamGrades WHERE ExamID = @ExamID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExamID", SelectedStudentID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label9.Text = reader["StudentID"].ToString();
                    label10.Text = reader["CourseID"].ToString();
                    label11.Text = reader["SectionID"].ToString();
                    dateTimePicker1.Value = (DateTime)reader["ExamDate"];


                    // Diğer öğrenci bilgilerini TextBox'lara yerleştir
                }

                reader.Close();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            int StudentID = Convert.ToInt32(label9.Text);
            int CourseID = Convert.ToInt32(label10.Text);
            int SectionID = Convert.ToInt32(label11.Text);
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            float Grade = Convert.ToInt32(comboBox4.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataRowView selectedRow2 = comboBox5.SelectedItem as DataRowView;
                int SelectedID = Convert.ToInt32(selectedRow2["ExamID"]);

                string query = "UPDATE ExamGrades SET StudentID = @StudentID, CourseID = @CourseID, SectionID = @SectionID, ExamDate = @ExamDate, Grade = @Grade " +
                               "WHERE ExamID = @ExamID";

                using (SqlCommand command2 = new SqlCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("@ExamID", SelectedID);
                    command2.Parameters.AddWithValue("@StudentID", StudentID); // Burada StudentID, CourseID, SectionID değerlerini nereden aldığınızı kontrol etmelisiniz.
                    command2.Parameters.AddWithValue("@CourseID", CourseID);
                    command2.Parameters.AddWithValue("@SectionID", SectionID);
                    command2.Parameters.AddWithValue("@ExamDate", dob);
                    command2.Parameters.AddWithValue("@Grade", Grade);

                    command2.ExecuteNonQuery();
                    MessageBox.Show("Not başarıyla Güncellendi!");

                    this.Close();
                }
            }
        }
    }
}

