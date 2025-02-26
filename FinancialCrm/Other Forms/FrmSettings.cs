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

namespace FinancialCrm.Other_Forms
{
    public partial class FrmSettings : BaseForm
    {
        private float orijinalGenislik;
        private float orijinalYukseklik;
        private Dictionary<Control, Rectangle> kontrolOrijinalBoyutlar = new Dictionary<Control, Rectangle>();
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            orijinalGenislik = this.Width;
            orijinalYukseklik = this.Height;

          
            foreach (Control kontrol in this.Controls)
            {
                kontrolOrijinalBoyutlar[kontrol] = new Rectangle(kontrol.Location, kontrol.Size);
            }
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBanks frm= new FrmBanks();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBills frm= new FrmBills();
            frm.ShowDialog();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSpendings frm= new FrmSpendings();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBankProcess frm= new FrmBankProcess();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDashBoard frm= new FrmDashBoard();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            float genislikOrani = this.Width / orijinalGenislik;
            float yukseklikOrani = this.Height / orijinalYukseklik;

            foreach (Control kontrol in this.Controls)
            {
                Rectangle orijinal = kontrolOrijinalBoyutlar[kontrol];


                int yeniX = (int)(orijinal.X * genislikOrani);
                int yeniY = (int)(orijinal.Y * yukseklikOrani);
                int yeniGenislik = (int)(orijinal.Width * genislikOrani);
                int yeniYukseklik = (int)(orijinal.Height * yukseklikOrani);

                kontrol.SetBounds(yeniX, yeniY, yeniGenislik, yeniYukseklik);


                if (GlobalSettings.IsFullScreen)
                {

                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                    GlobalSettings.IsFullScreen = false;
                }
                else
                {

                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    GlobalSettings.IsFullScreen = true;
                }
            }
        }

        private void btnAccountChange_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
        }
    }
}
