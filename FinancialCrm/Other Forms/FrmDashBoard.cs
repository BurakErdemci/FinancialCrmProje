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
    public partial class FrmDashBoard : BaseForm
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "₺";
            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";
            //chart1 kodları:
            var bankData = db.Banks.Select(x => new 
            {
                x.BankTittle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTittle, item.BankBalance);
            }
            //chart2 kodları:
            var billData=db.Bills.Select(x=> new
            {
                x.BillTitle,
                x.BillAmount

            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }


            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count%4==1)
            {
                var elektrikFaturası = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturası.ToString() + "₺";
            }
            if (count % 4 == 2)
            {
                var dogalgazFaturası = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazFaturası.ToString() + "₺";

            }
            if (count % 4 == 3)
            {
                var suFaturası = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturası.ToString() + "₺";
            }
            if (count % 4 == 0)
            {
                var benzinFaturası = db.Bills.Where(x => x.BillTitle == "Benzin Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Benzin Faturası";
                lblBillAmount.Text = benzinFaturası.ToString() + "₺";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBills frm= new FrmBills();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBanks frm=new FrmBanks();
            frm.ShowDialog();
            
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSpendings frm= new FrmSpendings();
            frm.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBankProcess frm= new FrmBankProcess();
            frm.ShowDialog();
        }

        private void FrmDashBoard_Resize(object sender, EventArgs e)
        {
            float oran = this.Width / 1920f;  
            lblTotalBalance.Font = new Font(lblTotalBalance.Font.FontFamily, 14f * oran);
            lblBillAmount.Font = new Font(lblBillAmount.Font.FontFamily, 14f * oran);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
            FrmCategories frm= new FrmCategories();
            frm.ShowDialog();
        }
    }
}
