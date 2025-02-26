using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Login_Register_Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmLogin : BaseForm
    {
        

        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
               FrmBanks frm= new FrmBanks();
              frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Resize_Click(object sender, EventArgs e)
        {

           
            
        }
    }
}

