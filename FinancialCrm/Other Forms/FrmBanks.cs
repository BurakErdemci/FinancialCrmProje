using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using FinancialCrm.Login_Register_Forms;
using FinancialCrm.Models;
using FinancialCrm.Other_Forms;


namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var isBankasıBalance = db.Banks.Where(x => x.BankTittle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var ziraatBankBalance=db.Banks.Where(x=>x.BankTittle=="Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance=db.Banks.Where(x=>x.BankTittle=="VakıfBank").Select(y=>y.BankBalance).FirstOrDefault();
           
            lblİsBankasıBalance.Text=isBankasıBalance.ToString()+ "₺";
            lblVakıfbankBalance.Text=vakifBankBalance.ToString() + "₺";
            lblZiraatBankBalance.Text=ziraatBankBalance.ToString() + "₺";

            var bankProcess1=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " , " + bankProcess1.Amount + " ₺ , " + bankProcess1.ProcessDate;
           
            var bankProcess2= db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " , " + bankProcess2.Amount + " ₺ , " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " , " + bankProcess3.Amount + " ₺ , " + bankProcess3.ProcessDate;
          
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " , " + bankProcess4.Amount + " ₺ , " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " , " + bankProcess5.Amount + " ₺ , " + bankProcess5.ProcessDate;

            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSpendings frm= new FrmSpendings();
            frm.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDashBoard frm = new FrmDashBoard();
            frm.ShowDialog();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBills frm = new FrmBills();
            frm.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBankProcess frm = new FrmBankProcess();
            frm.ShowDialog();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
