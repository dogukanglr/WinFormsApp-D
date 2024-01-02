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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private const string V = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        string conn = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";

        private void view1Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(V))
            {
                conn.Open();
                string viewName = "CourseStatistics"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + " Statistics"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void view2Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "StudentCourseStats"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + " Student Course Stats"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void view3Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "StudentGrades"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + " Student Grades"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void view4Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "TeacherCourseCount"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Teacher CourseCount"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void view5Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "TopStudents"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Top Students"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Course"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Course"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Student"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Student"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Teachers"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Teachers"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "ExamGrades"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "ExamGrades"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Section"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Section"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Users"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Users"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "UserPermissions"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "UserPermissions"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string viewName = "Permissions"; // İlgili view'in adını buraya girin
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Pop-up form oluştur
                    Form statisticsForm = new Form();
                    statisticsForm.Text = viewName + "Permissions"; // Form başlığı

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = dataTable;
                    dgv.Dock = DockStyle.Fill; // DataGridView'in form ile büyümesi
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // İçeriğe uygun boyutlandırma
                    dgv.ReadOnly = true; // Okunabilir modda ayarlama

                    statisticsForm.Controls.Add(dgv);
                    statisticsForm.AutoSize = true; // Formun içeriğe göre boyutlanması


                    statisticsForm.ShowDialog(); // Pop-up formu göster
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Önceki formu oluşturup gösterme
            Form1 form1 = new Form1();
            form1.Show();

            // Mevcut formu kapatma
            this.Close();
        }

        private void btnOpenStudentForm_Click(object sender, EventArgs e)
        {
            // Student formunu oluşturup gösterme
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog(); // Student formunu modüler olarak gösterme
        }

        private void btnOpenTeacherForm_Click(object sender, EventArgs e)
        {
            TeacherForm TeacherForm = new TeacherForm();
            TeacherForm.ShowDialog(); // Student formunu modüler olarak gösterme
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            ExamGradeAddForm examGradeAddForm = new ExamGradeAddForm();
            examGradeAddForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            CourseAddForm CourseAddForm = new CourseAddForm();
            CourseAddForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            SectionAddForm SectionAddForm = new SectionAddForm();
            SectionAddForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            StudentUpdateForm StudentUpdateForm = new StudentUpdateForm();
            StudentUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            TeacherUpdateForm TeacherUpdateForm = new TeacherUpdateForm();
            TeacherUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterm
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            TeacherUpdateForm TeacherUpdateForm = new TeacherUpdateForm();
            TeacherUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterm
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            CourseUpdateForm CourseUpdateForm = new CourseUpdateForm();
            CourseUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GradesDeleteForm GradesDeleteForm = new GradesDeleteForm();
            GradesDeleteForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CourseDeleteForm CourseDeleteForm = new CourseDeleteForm();
            CourseDeleteForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }
    }
}
