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

namespace FinancialCrm.Other_Forms
{
    public partial class FrmCategories :BaseForm
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values= db.Categories.ToList();
            dataGridView1.DataSource = values;
            if (GlobalSettings.IsFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCategoriesAdd_Click(object sender, EventArgs e)
        {
            string title= txtCategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = title;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategoriesDel_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtCategoryId.Text);
            var removedValues = db.Categories.Find(id);
            db.Categories.Remove(removedValues);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoriesUpdate_Click(object sender, EventArgs e)
        {
            string title = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);
            var values= db.Categories.Find(id);
            values.CategoryName = title;
            values.CategoryId = id;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
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

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSettings frm= new FrmSettings();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
