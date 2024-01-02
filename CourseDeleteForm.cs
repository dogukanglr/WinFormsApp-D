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
    public partial class CourseDeleteForm : Form
    {
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public CourseDeleteForm()
        {
            InitializeComponent();
            this.Load += CourseDeleteForm_Load;
        }

        private void CourseDeleteForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(417, 351);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CourseID FROM Course"; // ComboBox'a aktarılacak sütun adı
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox1.DataSource = dataTable;
                    comboBox1.DisplayMember = "CourseID";
                    comboBox1.ValueMember = "CourseID"; // ComboBox'ta görüntülenecek sütun adı
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataRowView selectedRow2 = comboBox1.SelectedItem as DataRowView;
                int SelectedID = Convert.ToInt32(selectedRow2["CourseID"]);


                string query = "DELETE FROM Course WHERE CourseID = @CourseID";

                using (SqlCommand command2 = new SqlCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("@CourseID", SelectedID);

                    command2.ExecuteNonQuery();
                    MessageBox.Show("Ders başarıyla Silindi");

                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataRowView selectedRow2 = comboBox1.SelectedItem as DataRowView;
                int SelectedID = Convert.ToInt32(selectedRow2["CourseID"]);

                string query = "SELECT * FROM Course WHERE CourseID = @CourseID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseID", SelectedID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label6.Text = reader["CourseCode"].ToString();
                    label7.Text = reader["CourseName"].ToString();
                    label9.Text = reader["Description"].ToString();

                    // Diğer öğrenci bilgilerini TextBox'lara yerleştir
                }
                reader.Close();
            }
        }
    }
}
