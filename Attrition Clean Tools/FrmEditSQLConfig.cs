using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;

namespace Attrition_Clean_Tools
{
    public partial class FrmEditSQLConfig : Form
    {
        public FrmEditSQLConfig()
        {
            InitializeComponent();
        }
        private AttritionService objAttritionService = new AttritionService();
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists("SQLConfig.txt"))
            {
                FileStream fs = new FileStream("SQLConfig.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string allinfo = sr.ReadToEnd();
                if (allinfo.Length == 0)
                {
                    MessageBox.Show("无内容");
                    sr.Close();
                    fs.Close();
                    return;
                }
                else 
                {
                    string[] SQLinfo = allinfo.Split(Convert.ToChar('\n'));
                    this.txtSQLServerName.Text = SQLinfo[0];
                    this.txtSQLServerUid.Text = SQLinfo[1];
                    this.txtSQLServerPwd.Text = SQLinfo[2];
                    sr.Close();
                    fs.Close();
                }

            }
            else
            {
                MessageBox.Show("配置文件不存在，请检查");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (this.txtSQLServerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            if (this.txtSQLServerUid.Text.Trim().Length == 0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            if (this.txtSQLServerPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            FileStream fs = new FileStream("SQLConfig.txt",FileMode.Create );
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(this.txtSQLServerName .Text.Trim () );
            sw.WriteLine(this.txtSQLServerUid.Text.Trim());
            sw.WriteLine(this.txtSQLServerPwd.Text.Trim());
            sw.Close();
            fs.Close();
            MessageBox.Show("修改成功");
            foreach (Control  item in Controls)
            {
                if (item is TextBox )
                {
                    Control txt = (TextBox)item;
                    txt.Text = "";
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (this.txtSQLServerName.Text.Trim ().Length ==0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            if (this.txtSQLServerUid.Text.Trim().Length == 0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            if (this.txtSQLServerPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("未配置连接信息");
                return;
            }
            string SQLServerName = this.txtSQLServerName.Text.Trim();
            string SQLServerUid = this.txtSQLServerUid.Text.Trim();
            string SQLServerPwd = this.txtSQLServerPwd.Text.Trim();
            bool result = objAttritionService.TestConnect(SQLServerName, SQLServerUid, SQLServerPwd);
            if (result == true )
            {
                MessageBox.Show("测试连接成功");
            }
        }

        private void FrmEditSQLConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmEditSQLConfig = null;
        }
    }
}
