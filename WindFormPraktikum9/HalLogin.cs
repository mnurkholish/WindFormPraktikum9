using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindFormPraktikum9.Models;

namespace WindFormPraktikum9
{
    public partial class HalLogin : Form
    {
        private readonly LoginContext loginContext = new LoginContext();

        public HalLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TBUsernameLog.Text;
            string password = TBPasswordLog.Text;

            try
            {
                var auth = loginContext.Login(username, password);
                if (auth)
                {
                    MessageBox.Show("Anda Berhasil Login", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Login {ex}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //foreach (User user in users)
            //{
            //    if (user.Username == username && user.Password == password)
            //    {
            //        MessageBox.Show("Login Berhasil");
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Maaf Akun Tidak Ditemukan");
            //    }
            //}

            //if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            //{
            //    MessageBox.Show("Username atau password harus diisi!", "Tidak Valid",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error
            //    );
            //    return;
            //}

            //try
            //{
            //    DatabaseLogin db = new DatabaseLogin();
            //    var userExist = db.Login(username, password);

            //    if (userExist)
            //    {
            //        MessageBox.Show("Selamat anda berhasil Login anjayy");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Anda gagal login");
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show($"{err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

public class DatabaseLogin
{
    NpgsqlConnection conn;

    public DatabaseLogin()
    {
        //string env = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        string env = "Host=localhost;Port=5432;Database=praktikum-pbo;Username=postgres;Password=Kholish8306!";
        conn = new NpgsqlConnection(env);
        conn.Open();
    }

    public bool Login(string username, string password)
    {
        string query = "SELECT * FROM users WHERE username=@username AND password=@password";
        NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        var reader = cmd.ExecuteReader();
        var userExist = reader.Read();

        reader.Close();
        cmd.Dispose();

        return userExist;
    }
}
