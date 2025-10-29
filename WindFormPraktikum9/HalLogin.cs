using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormPraktikum9
{
    public partial class HalLogin : Form
    {
        List<User> users;
        public HalLogin(List<User> user)
        {
            InitializeComponent();
            users = user;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TBUsernameLog.Text;
            string password = TBPasswordLog.Text;

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    MessageBox.Show("Login Berhasil");
                    return;
                }
                else
                {
                    MessageBox.Show("Maaf Akun Tidak Ditemukan");
                }
            }
        }
    }
}
