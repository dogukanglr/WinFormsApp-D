using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_D
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_Click_1(object sender, EventArgs e)
        {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                string connectionString = "Server=ENJ-IST-BT21;Database=BLM-5225-Project-Mark-Db-MDG;Integrated Security=True;";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Username,EncryptedPassword,UserType FROM Users WHERE Username = @username AND EncryptedPassword = @password";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); // Þifrelenmiþ parola deðeri ile karþýlaþtýrma yapýlmalý

                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                    {
                        reader.Read();
                        string userType = reader["UserType"].ToString();

                        if (userType == "Admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (userType == "User")
                        {
                            UserForm userForm = new UserForm();
                            userForm.Show();
                        }

                        this.Hide(); // Giriþ ekranýný gizle
                    }
                }
                    else
                    {
                        MessageBox.Show("Kullanýcý adý veya þifre hatalý!"); // Hatalý giriþ durumunda uyarý verilebilir
                    }
                }
            }
        }
    }
