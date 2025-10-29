using dotenv.net;
using Npgsql;
using System.Security.Cryptography.X509Certificates;

namespace WindFormPraktikum9
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            string password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username atau Password harus diisi", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBUsername.Clear();
                TBPassword.Clear();
                return;
            }

            users.Add(new User { Username = username, Password = password });
            MessageBox.Show("Berhasil Registrasi");

            HalLogin HalLogin = new HalLogin(users);
            this.Hide();
            HalLogin.Show();
        }
    }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class Database
{
    NpgsqlConnection conn;

    public Database()
    {
        string env = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        conn = new NpgsqlConnection(env);
        conn.Open();
    }

    public bool Register(string username, string password)
    {
        string query = "INSERT INTO users VALUES(username, password)";
        NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
        cmd.add
    }
}
