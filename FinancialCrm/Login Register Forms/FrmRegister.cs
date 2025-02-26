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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancialCrm
{
    public partial class FrmRegister : BaseForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm= new FrmLogin();
            frm.ShowDialog();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var db = new FinancialCrmDbEntities())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                var existingUser = db.Users.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newUser = new Users
                {
                    Username = username,
                    Password = password 
                };

                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
