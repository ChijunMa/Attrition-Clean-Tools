using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Attrition_Clean_Tools
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
            string txt = "声明 ：\r\n1.   本软件不含任何植入木马，病毒程序等破坏计算机系统安全功能\r\n2.   本软件不对相应操作的数据负责，抛料数据一经删除，再无恢复可能！\r\n3.   请谨慎使用该软件，使用本软件后造成的后果本软件开发者不承担任何责任";
            this.label3.Text = txt;
        }
        private AdminService objAdminService = new AdminService();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.txt_LoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input LoginId");
                return;
            }
            if (this.txt_LoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input PassWord");
                return;
            }
            
            string loginid =this.txt_LoginId .Text.Trim () ;
            string loginpwd = this.txt_LoginPwd .Text.Trim ();
            
            string AdminName = objAdminService.GetAdmins(loginid, loginpwd);
            if (AdminName != string.Empty)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong LoginPwd or LoginId ");
            }

        }

        private void btn_Canel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_LoginId_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (this.txt_LoginId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please input LoginId");
                    return;
                }
                else
                {
                    this.txt_LoginPwd.Focus();
                }
            }

        }

        private void txt_LoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txt_LoginPwd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please input PassWord");
                    return;
                }
                else
                {
                    btn_Login_Click(null, null);
                }

            }
        }
    }
}
