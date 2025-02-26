using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.Login_Register_Forms
{
    public class BaseForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
