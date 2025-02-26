using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Login_Register_Forms;
using FinancialCrm.Models;
using FinancialCrm.Other_Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : BaseForm
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values=db.Spendings.ToList();
            dgSp1.DataSource = values;
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSpAdd_Click(object sender, EventArgs e)
        {
            string title=txtSpName.Text;
            decimal amount=decimal.Parse(txtSpBalance.Text);
            DateTime date=DateTime.Now;
            Spendings spendings=new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dgSp1.DataSource = values;
        }

        private void btnSpDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtSpId.Text);
            var removeValues = db.Spendings.Find(id);
            db.Spendings.Remove(removeValues);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dgSp1.DataSource = values;
        }

        private void btnSpUpdate_Click(object sender, EventArgs e)
        {
            string title = txtSpName.Text;
            decimal amount = decimal.Parse(txtSpBalance.Text);
            DateTime date = DateTime.Now;
            int id = int.Parse(txtSpId.Text);
            var values = db.Spendings.Find(id);
            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = date;
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2= db.Spendings.ToList();
            dgSp1.DataSource = values2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm= new FrmBanks();   
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBills frm= new FrmBills();
            frm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard frm= new FrmDashBoard();
            frm.ShowDialog();
            this.Close();    
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBankProcess frm= new FrmBankProcess();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
        }
    }
}
