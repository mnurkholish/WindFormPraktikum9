using Npgsql;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindFormPraktikum9
{
    public partial class Form1 : Form
    {
        //List<User> users = new List<User>();

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

            //users.Add(new User { Username = username, Password = password });

            try
            {
                Database db = new Database();
                var regis = db.Register(username, password);

                if (regis == 1)
                {
                    MessageBox.Show("Berhasil Registrasi");
                }
                else
                {
                    MessageBox.Show("Gagal Registrasi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            HalLogin HalLogin = new HalLogin();
            this.Hide();
            HalLogin.Show();
        }
    }
}



public class Database
{
    NpgsqlConnection conn;

    public Database()
    {
        //DotEnv.Read();
        //string env = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        string env = "Host=localhost;Port=5432;Database=praktikum-pbo;Username=postgres;Password=12345";
        conn = new NpgsqlConnection(env);
        conn.Open();
    }

    public int Register(string username, string password)
    {
        string query = "INSERT INTO users(username, password) VALUES(@username, @password)";
        NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        var register = cmd.ExecuteNonQuery();
        return register;
    }
}
