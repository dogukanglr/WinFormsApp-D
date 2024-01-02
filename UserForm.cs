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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";

        // Veri tabloları ve DataGridView'ler
        DataTable studentTable = new DataTable();
        DataTable courseTable = new DataTable();
        DataTable ExamGradesTable = new DataTable();
        DataTable SectionTable = new DataTable();
        DataTable TeachersTable = new DataTable();

        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        DataGridView dataGridView3 = new DataGridView();
        DataGridView dataGridView4 = new DataGridView();
        DataGridView dataGridView5 = new DataGridView();

        private void UserForm_Load(object sender, EventArgs e)
        {


            // DataGridView'lerin bulunduğu sekmeler
            TabPage tabPage1 = new TabPage("Students");
            tabPage1.Controls.Add(dataGridView1);
            tabControl1.TabPages.Add(tabPage1);

            TabPage tabPage2 = new TabPage("Teachers");
            tabPage2.Controls.Add(dataGridView4);
            tabControl1.TabPages.Add(tabPage2);

            TabPage tabPage3 = new TabPage("Courses");
            tabPage3.Controls.Add(dataGridView2);
            tabControl1.TabPages.Add(tabPage3);

            TabPage tabPage4 = new TabPage("ExamGrades");
            tabPage4.Controls.Add(dataGridView3);
            tabControl1.TabPages.Add(tabPage4);

            TabPage tabPage5 = new TabPage("Section");
            tabPage5.Controls.Add(dataGridView5);
            tabControl1.TabPages.Add(tabPage5);

            // Veri tablolarını doldurma işlemi
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Öğrenci tablosunu doldurma
                string studentQuery = "SELECT * FROM Student";
                SqlDataAdapter studentAdapter = new SqlDataAdapter(studentQuery, conn);
                studentAdapter.Fill(studentTable);
                // DataGridView1'e öğrenci tablosunu bağlama
                dataGridView1.DataSource = studentTable;
                dataGridView1.ScrollBars = ScrollBars.Both;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSize = true; // DataGridView'in boyutunu otomatik olarak ayarlar

                // Teachers tablosunu doldurma
                string TeachersQuery = "SELECT * FROM Teachers";
                SqlDataAdapter TeachersAdapter = new SqlDataAdapter(TeachersQuery, conn);
                TeachersAdapter.Fill(TeachersTable);
                // DataGridView1'e Teachers tablosunu bağlama
                dataGridView4.DataSource = TeachersTable;
                dataGridView4.ScrollBars = ScrollBars.Both;
                dataGridView4.ReadOnly = true;
                dataGridView4.AutoSize = true; // DataGridView'in boyutunu otomatik olarak ayarlar

                // Kurs tablosunu doldurma
                string courseQuery = "SELECT * FROM Course";
                SqlDataAdapter courseAdapter = new SqlDataAdapter(courseQuery, conn);
                courseAdapter.Fill(courseTable);
                // DataGridView2'e kurs tablosunu bağlama
                dataGridView2.DataSource = courseTable;
                dataGridView2.ScrollBars = ScrollBars.Both;
                dataGridView2.ReadOnly = true;
                dataGridView2.AutoSize = true; // DataGridView'in boyutunu otomatik olarak ayarlar

                // ExamGrades tablosunu doldurma
                string ExamGradesQuery = "SELECT * FROM ExamGrades";
                SqlDataAdapter ExamGradesAdapter = new SqlDataAdapter(ExamGradesQuery, conn);
                ExamGradesAdapter.Fill(ExamGradesTable);
                // DataGridView2'e kurs tablosunu bağlama
                dataGridView3.DataSource = ExamGradesTable;
                dataGridView3.ScrollBars = ScrollBars.Both;
                dataGridView3.ReadOnly = true;
                dataGridView3.AutoSize = true; // DataGridView'in boyutunu otomatik olarak ayarlar

                // ExamGrades tablosunu doldurma
                string SectionQuery = "SELECT * FROM Section";
                SqlDataAdapter SectionAdapter = new SqlDataAdapter(SectionQuery, conn);
                SectionAdapter.Fill(SectionTable);
                // DataGridView2'e Section tablosunu bağlama
                dataGridView5.DataSource = SectionTable;
                dataGridView5.ScrollBars = ScrollBars.Both;
                dataGridView5.ReadOnly = true;
                dataGridView5.AutoSize = true; // DataGridView'in boyutunu otomatik olarak ayarlar


            }
            tabPage1.AutoScroll = true;
            tabPage1.HorizontalScroll.Enabled = true;
            tabPage1.HorizontalScroll.Visible = true;
            tabPage1.VerticalScroll.Enabled = true;
            tabPage1.VerticalScroll.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void view1Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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

        private void btnOpenStudentForm_Click(object sender, EventArgs e)
        {
            // Student formunu oluşturup gösterme
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog(); // Student formunu modüler olarak gösterme

        }

        private void btnOpenTeacherForm_Click(object sender, EventArgs e)
        {
            // Student formunu oluşturup gösterme
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

        private void label10_Click(object sender, EventArgs e)
        {

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
            TeacherUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            GradeUpdateForm GradeUpdateForm = new GradeUpdateForm();
            GradeUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ExamGradeAddForm formunu oluşturup gösterme
            CourseUpdateForm CourseUpdateForm = new CourseUpdateForm();
            CourseUpdateForm.ShowDialog(); // ExamGradeAddForm formunu modüler olarak gösterme
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

        private void button12_Click(object sender, EventArgs e)
        {
            // Önceki formu oluşturup gösterme
            Form1 form1 = new Form1();
            form1.Show();

            // Mevcut formu kapatma
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayfa Güncellenmektedir.");
        }
    }
}
