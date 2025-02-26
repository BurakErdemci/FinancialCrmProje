using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Login_Register_Forms;
using FinancialCrm.Models;
using System.Data.Entity;

namespace FinancialCrm.Other_Forms
{
    public partial class FrmBankProcess : BaseForm
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                LoadBanksToComboBox();
                LoadBankProcesses();
            }
        }


        private void LoadBanksToComboBox()
        {
            using (var context = new FinancialCrmDbEntities()) 
            {
                var banks = context.Banks.Select(x => new { x.BankId, x.BankTittle }).ToList();
                cbBank.DataSource = banks;
                db.SaveChanges();

               
            }
        }

        private void LoadBankProcesses()
        {
            using (var context = new FinancialCrmDbEntities())
            {
                var bankProcesses = context.BankProcesses
                    .Include(x => x.Banks) 
                    .Select(y => new
                    {
                        y.ProcessDate,
                        y.ProcessType,
                        y.Amount,
                        BankName = y.Banks.BankTittle 
                    }).ToList();

               dataGridView1.DataSource = bankProcesses;
            }
        }

        private void btnBpAdd_Click(object sender, EventArgs e)
        {
            string title = txtBpBalance.Text;
            DateTime date = DateTime.Now;
            string type = txtBpType.Text;
            string exp = txtBpExp.Text;
            decimal balance = decimal.Parse(txtBpBalance.Text);
            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.Description = txtBpExp.Text;
            bankProcesses.ProcessDate = date;
            bankProcesses.ProcessType = type;
            bankProcesses.Amount = balance;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("Banka İşlemi Başarılı Bir Şekilde Sisteme Eklendi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBpDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBpId.Text);
            var removedValues = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removedValues);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBpUpdate_Click(object sender, EventArgs e)
        {

            string title = txtBpBalance.Text;
            DateTime date = DateTime.Now;
            string type = txtBpType.Text;
            string exp = txtBpExp.Text;
            decimal balance = decimal.Parse(txtBpBalance.Text);
            int id = int.Parse(txtBpId.Text);
            var values = db.BankProcesses.Find(id);
            values.Description = txtBpExp.Text;
            values.ProcessDate = date;
            values.ProcessType = type;
            values.Amount = balance;
            db.SaveChanges();
            MessageBox.Show("Banka İşlemi Başarılı Bir Şekilde Güncellendi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.BankProcesses.ToList();
            dataGridView1.DataSource = values2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBanks frm = new FrmBanks();
            frm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBills frm = new FrmBills();
            frm.ShowDialog();
           
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSpendings frm = new FrmSpendings();
            frm.ShowDialog();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDashBoard frm = new FrmDashBoard();
            frm.ShowDialog();
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
        }
    }
}
