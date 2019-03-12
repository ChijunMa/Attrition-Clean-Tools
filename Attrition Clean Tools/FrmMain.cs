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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private AttritionService objAttritionService = new AttritionService();
        private void btn_Search_Click(object sender, EventArgs e)
        {

            bool result = DateTimeVail();
            if (result == false)
            {
                MessageBox.Show(" 查询结束时间必须大于查询开始时间 \r\n 查询结束时间和查询开始时间必须间隔5分钟 \r\n 查询开始时间不能和现在时间相同", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime TimeFrom = Convert.ToDateTime(this.dtp_TimeFrom.Text.ToString());
                DateTime TimeEnd = Convert.ToDateTime(this.dtp_TimeEnd.Text.ToString());
                this.lbl_AllPicked.Text = objAttritionService.GetAllPicked(TimeFrom, TimeEnd).ToString();
                this.lbl_PlaceMent.Text = objAttritionService.GetAllPlaceMent(TimeFrom, TimeEnd).ToString();
                this.lbl_AllReject.Text = objAttritionService.GetAllReject(TimeFrom, TimeEnd).ToString();
                this.lbl_AllIdent.Text = objAttritionService.GetAllIdent(TimeFrom, TimeEnd).ToString();
                this.lbl_AllVacuum.Text = objAttritionService.GetAllVacuum(TimeFrom, TimeEnd).ToString();
                this.lbl_AllFeeder.Text = objAttritionService.GetAllFeeder(TimeFrom, TimeEnd).ToString();
            }
        }
        public bool DateTimeVail()
        {
            if (DateTime.Compare(this.dtp_TimeFrom.Value, this.dtp_TimeEnd.Value) >= 0) return false;

            //MessageBox.Show("查询结束时间必须大于查询开始时间","时间设置错误",MessageBoxButtons .OKCancel ,MessageBoxIcon.Warning  );


            if (this.dtp_TimeEnd.Value < this.dtp_TimeFrom.Value) return false;

            //MessageBox.Show("查询结束时间和查询开始时间必须间隔5分钟", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (this.dtp_TimeFrom.Value > DateTime.Now) return false;

                //MessageBox.Show("查询开始时间不能和现在时间相同", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            else return true;




        }

        private void btn_DelVacuum_Click(object sender, EventArgs e)
        {
            bool result = DateTimeVail();
            if (result == false)
            {
                MessageBox.Show(" 查询结束时间必须大于查询开始时间 \r\n 查询结束时间和查询开始时间必须间隔5分钟 \r\n 查询开始时间不能和现在时间相同", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime TimeFrom = Convert.ToDateTime(this.dtp_TimeFrom.Text.ToString());
                DateTime TimeEnd = Convert.ToDateTime(this.dtp_TimeEnd.Text.ToString());
                int placementRowCount = objAttritionService.CleanVacuumPickupQTY(TimeFrom, TimeEnd);
                int EditRowCount = objAttritionService.EditVacuumQTY(TimeFrom, TimeEnd);
                string info = "重置{0}条记录，清除{1}抛料记录";
                info = string.Format(info, placementRowCount, EditRowCount);
                MessageBox.Show(info, "New Information");
                btn_Search_Click(null, null);
            }
        }

        private void btn_DelIdent_Click(object sender, EventArgs e)
        {
            bool result = DateTimeVail();
            if (result == false)
            {
                MessageBox.Show(" 查询结束时间必须大于查询开始时间 \r\n 查询结束时间和查询开始时间必须间隔5分钟 \r\n 查询开始时间不能和现在时间相同", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime TimeFrom = Convert.ToDateTime(this.dtp_TimeFrom.Text.ToString());
                DateTime TimeEnd = Convert.ToDateTime(this.dtp_TimeEnd.Text.ToString());
                int placementRowCount = objAttritionService.CleanIdentPickupQTY(TimeFrom, TimeEnd);
                int EditRowCount = objAttritionService.EditIdentQTY(TimeFrom, TimeEnd);
                string info = "重置{0}条记录，清除{1}抛料记录";
                info = string.Format(info, placementRowCount, EditRowCount);
                MessageBox.Show(info, "New Information");
                btn_Search_Click(null, null);
            }
        }

        private void btn_DelFeeder_Click(object sender, EventArgs e)
        {

            bool result = DateTimeVail();
            if (result == false)
            {
                MessageBox.Show(" 查询结束时间必须大于查询开始时间 \r\n 查询结束时间和查询开始时间必须间隔5分钟 \r\n 查询开始时间不能和现在时间相同", "时间设置错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime TimeFrom = Convert.ToDateTime(this.dtp_TimeFrom.Text.ToString());
                DateTime TimeEnd = Convert.ToDateTime(this.dtp_TimeEnd.Text.ToString());
                int placementRowCount = objAttritionService.CleanFeederPickupQTY(TimeFrom, TimeEnd);
                int EditRowCount = objAttritionService.EditFeederQTY(TimeFrom, TimeEnd);
                string info = "重置{0}条记录，清除{1}抛料记录";
                info = string.Format(info, placementRowCount, EditRowCount);
                MessageBox.Show(info, "New Information");
                btn_Search_Click(null, null);
            }
        }

        private void 使用前阅读ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件不含任何植入木马，病毒程序等破坏计算机系统安全功能\r\n本软件不对相应操作的数据负责，抛料数据一经删除，再无恢复可能！\r\n请谨慎使用该软件，使用本软件后造成的后果本软件开发者不承担任何责任", "慎重提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.检查SQLServer连接状况,配置SQLServer2.设置查询时间\r\n3.点击Clean按键，即可清除相应抛料内容", "帮助提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未经许可，禁止传播，反向编译等。\r\n解释权归开发者所有", "版权信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }


        public  static  FrmEditSQLConfig objFrmEditSQLConfig = null;
        private void 配置SQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmEditSQLConfig == null)
            {
                objFrmEditSQLConfig = new FrmEditSQLConfig ();
                objFrmEditSQLConfig.Show();
            }
            else
            {
                objFrmEditSQLConfig.WindowState = FormWindowState.Normal;
                objFrmEditSQLConfig.Activate();
            }
        }
    }
}
