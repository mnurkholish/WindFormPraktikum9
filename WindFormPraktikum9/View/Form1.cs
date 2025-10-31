using Npgsql;
using System.Security.Cryptography.X509Certificates;
using WindFormPraktikum9.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindFormPraktikum9
{
    public partial class Form1 : Form
    {
        private readonly RegisterContext registerContext = new RegisterContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = TBUsername.Text;
            user.Password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username atau Password harus diisi", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBUsername.Clear();
                TBPassword.Clear();
                return;
            }

            try
            {
                var auth = registerContext.Register(user);
                if (auth)
                {
                    MessageBox.Show("Anda Berhasil Register", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Login {ex}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ////users.Add(new User { Username = username, Password = password });

            //try
            //{
            //    Database db = new Database();
            //    var regis = db.Register(username, password);

            //    if (regis == 1)
            //    {
            //        MessageBox.Show("Berhasil Registrasi");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Gagal Registrasi");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            HalLogin HalLogin = new HalLogin();
            this.Hide();
            HalLogin.ShowDialog();
            //HalLogin.Close();
            this.Show();
        }
    }
}