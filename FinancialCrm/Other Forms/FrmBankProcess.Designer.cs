namespace FinancialCrm.Other_Forms
{
    partial class FrmBankProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBpId = new System.Windows.Forms.TextBox();
            this.txtBpExp = new System.Windows.Forms.TextBox();
            this.txtBpType = new System.Windows.Forms.TextBox();
            this.txtBpBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBpAdd = new System.Windows.Forms.Button();
            this.btnBpDelete = new System.Windows.Forms.Button();
            this.btnBpUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(239, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 222);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banka Hareketleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(391, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banka Hareketi Id:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Banka Hareketi Açıklama:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(365, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Banka Hareketi Türü:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(353, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Banka Hareketi Miktar:";
            // 
            // txtBpId
            // 
            this.txtBpId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBpId.Location = new System.Drawing.Point(620, 259);
            this.txtBpId.Name = "txtBpId";
            this.txtBpId.Size = new System.Drawing.Size(167, 22);
            this.txtBpId.TabIndex = 6;
            // 
            // txtBpExp
            // 
            this.txtBpExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBpExp.Location = new System.Drawing.Point(620, 301);
            this.txtBpExp.Multiline = true;
            this.txtBpExp.Name = "txtBpExp";
            this.txtBpExp.Size = new System.Drawing.Size(167, 36);
            this.txtBpExp.TabIndex = 7;
            // 
            // txtBpType
            // 
            this.txtBpType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBpType.Location = new System.Drawing.Point(620, 358);
            this.txtBpType.Name = "txtBpType";
            this.txtBpType.Size = new System.Drawing.Size(167, 22);
            this.txtBpType.TabIndex = 8;
            // 
            // txtBpBalance
            // 
            this.txtBpBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBpBalance.Location = new System.Drawing.Point(620, 407);
            this.txtBpBalance.Name = "txtBpBalance";
            this.txtBpBalance.Size = new System.Drawing.Size(167, 22);
            this.txtBpBalance.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(494, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Banka:";
            // 
            // cbBank
            // 
            this.cbBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Location = new System.Drawing.Point(620, 455);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(167, 24);
            this.cbBank.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnBillForm);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 575);
            this.panel2.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(26, 480);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 41);
            this.button8.TabIndex = 8;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(26, 417);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(26, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(26, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBillForm
            // 
            this.btnBillForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillForm.Location = new System.Drawing.Point(26, 227);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(172, 41);
            this.btnBillForm.TabIndex = 4;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = true;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(26, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(26, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bankalar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(26, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Katerogiler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBpAdd
            // 
            this.btnBpAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBpAdd.Location = new System.Drawing.Point(462, 506);
            this.btnBpAdd.Name = "btnBpAdd";
            this.btnBpAdd.Size = new System.Drawing.Size(104, 40);
            this.btnBpAdd.TabIndex = 13;
            this.btnBpAdd.Text = "Ekle";
            this.btnBpAdd.UseVisualStyleBackColor = true;
            this.btnBpAdd.Click += new System.EventHandler(this.btnBpAdd_Click);
            // 
            // btnBpDelete
            // 
            this.btnBpDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBpDelete.Location = new System.Drawing.Point(620, 506);
            this.btnBpDelete.Name = "btnBpDelete";
            this.btnBpDelete.Size = new System.Drawing.Size(104, 40);
            this.btnBpDelete.TabIndex = 14;
            this.btnBpDelete.Text = "Sil";
            this.btnBpDelete.UseVisualStyleBackColor = true;
            this.btnBpDelete.Click += new System.EventHandler(this.btnBpDelete_Click);
            // 
            // btnBpUpdate
            // 
            this.btnBpUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBpUpdate.Location = new System.Drawing.Point(787, 506);
            this.btnBpUpdate.Name = "btnBpUpdate";
            this.btnBpUpdate.Size = new System.Drawing.Size(104, 40);
            this.btnBpUpdate.TabIndex = 15;
            this.btnBpUpdate.Text = "Güncelle";
            this.btnBpUpdate.UseVisualStyleBackColor = true;
            this.btnBpUpdate.Click += new System.EventHandler(this.btnBpUpdate_Click);
            // 
            // FrmBankProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1027, 575);
            this.Controls.Add(this.btnBpUpdate);
            this.Controls.Add(this.btnBpDelete);
            this.Controls.Add(this.btnBpAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBpBalance);
            this.Controls.Add(this.txtBpType);
            this.Controls.Add(this.txtBpExp);
            this.Controls.Add(this.txtBpId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankProcess";
            this.Load += new System.EventHandler(this.FrmBankProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBpId;
        private System.Windows.Forms.TextBox txtBpExp;
        private System.Windows.Forms.TextBox txtBpType;
        private System.Windows.Forms.TextBox txtBpBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBpAdd;
        private System.Windows.Forms.Button btnBpDelete;
        private System.Windows.Forms.Button btnBpUpdate;
    }
}