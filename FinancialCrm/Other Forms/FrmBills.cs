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
using FinancialCrm.Other_Forms;

namespace FinancialCrm
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        private void FrmBills_Load(object sender, EventArgs e)
        {
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title=txtBillTitle.Text;
            decimal amount=decimal.Parse(txtBillAmount.Text);
            string period=txtBillPeriod.Text;
            Bills bills= new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;  
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi","Ödeme & Faturalar",MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtBillId.Text);
            var removeValue=db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id=int.Parse(txtBillId.Text);
            var values=db.Bills.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
       
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBanks frm = new FrmBanks();
            frm.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDashBoard frm = new FrmDashBoard();
            frm.Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
         {
            Hide();
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
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
