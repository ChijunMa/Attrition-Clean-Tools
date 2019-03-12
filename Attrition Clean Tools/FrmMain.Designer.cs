namespace Attrition_Clean_Tools
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_PlaceMent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gp = new System.Windows.Forms.GroupBox();
            this.lbl_AllVacuum = new System.Windows.Forms.Label();
            this.btn_DelFeeder = new System.Windows.Forms.Button();
            this.btn_DelIdent = new System.Windows.Forms.Button();
            this.btn_DelVacuum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_AllFeeder = new System.Windows.Forms.Label();
            this.lbl_AllIdent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_TimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AllPicked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_AllReject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.特别说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用前阅读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置SQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PlaceMent
            // 
            this.lbl_PlaceMent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PlaceMent.Location = new System.Drawing.Point(149, 509);
            this.lbl_PlaceMent.Name = "lbl_PlaceMent";
            this.lbl_PlaceMent.Size = new System.Drawing.Size(100, 23);
            this.lbl_PlaceMent.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "All Placement";
            // 
            // Gp
            // 
            this.Gp.Controls.Add(this.lbl_AllVacuum);
            this.Gp.Controls.Add(this.btn_DelFeeder);
            this.Gp.Controls.Add(this.btn_DelIdent);
            this.Gp.Controls.Add(this.btn_DelVacuum);
            this.Gp.Controls.Add(this.label9);
            this.Gp.Controls.Add(this.label3);
            this.Gp.Controls.Add(this.lbl_AllFeeder);
            this.Gp.Controls.Add(this.lbl_AllIdent);
            this.Gp.Controls.Add(this.label7);
            this.Gp.Location = new System.Drawing.Point(28, 165);
            this.Gp.Name = "Gp";
            this.Gp.Size = new System.Drawing.Size(334, 262);
            this.Gp.TabIndex = 32;
            this.Gp.TabStop = false;
            this.Gp.Text = "Attrition Data";
            // 
            // lbl_AllVacuum
            // 
            this.lbl_AllVacuum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AllVacuum.Location = new System.Drawing.Point(10, 66);
            this.lbl_AllVacuum.Name = "lbl_AllVacuum";
            this.lbl_AllVacuum.Size = new System.Drawing.Size(100, 23);
            this.lbl_AllVacuum.TabIndex = 13;
            // 
            // btn_DelFeeder
            // 
            this.btn_DelFeeder.BackColor = System.Drawing.Color.White;
            this.btn_DelFeeder.ForeColor = System.Drawing.Color.Black;
            this.btn_DelFeeder.Location = new System.Drawing.Point(172, 220);
            this.btn_DelFeeder.Name = "btn_DelFeeder";
            this.btn_DelFeeder.Size = new System.Drawing.Size(67, 34);
            this.btn_DelFeeder.TabIndex = 9;
            this.btn_DelFeeder.Text = "Clean";
            this.btn_DelFeeder.UseVisualStyleBackColor = false;
            this.btn_DelFeeder.Click += new System.EventHandler(this.btn_DelFeeder_Click);
            // 
            // btn_DelIdent
            // 
            this.btn_DelIdent.BackColor = System.Drawing.Color.White;
            this.btn_DelIdent.ForeColor = System.Drawing.Color.Black;
            this.btn_DelIdent.Location = new System.Drawing.Point(172, 140);
            this.btn_DelIdent.Name = "btn_DelIdent";
            this.btn_DelIdent.Size = new System.Drawing.Size(67, 34);
            this.btn_DelIdent.TabIndex = 9;
            this.btn_DelIdent.Text = "Clean";
            this.btn_DelIdent.UseVisualStyleBackColor = false;
            this.btn_DelIdent.Click += new System.EventHandler(this.btn_DelIdent_Click);
            // 
            // btn_DelVacuum
            // 
            this.btn_DelVacuum.BackColor = System.Drawing.Color.White;
            this.btn_DelVacuum.ForeColor = System.Drawing.Color.Black;
            this.btn_DelVacuum.Location = new System.Drawing.Point(172, 60);
            this.btn_DelVacuum.Name = "btn_DelVacuum";
            this.btn_DelVacuum.Size = new System.Drawing.Size(67, 34);
            this.btn_DelVacuum.TabIndex = 9;
            this.btn_DelVacuum.Text = "Clean";
            this.btn_DelVacuum.UseVisualStyleBackColor = false;
            this.btn_DelVacuum.Click += new System.EventHandler(this.btn_DelVacuum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Feeder Reject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vacuum Reject";
            // 
            // lbl_AllFeeder
            // 
            this.lbl_AllFeeder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AllFeeder.Location = new System.Drawing.Point(10, 226);
            this.lbl_AllFeeder.Name = "lbl_AllFeeder";
            this.lbl_AllFeeder.Size = new System.Drawing.Size(100, 23);
            this.lbl_AllFeeder.TabIndex = 22;
            // 
            // lbl_AllIdent
            // 
            this.lbl_AllIdent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AllIdent.Location = new System.Drawing.Point(10, 146);
            this.lbl_AllIdent.Name = "lbl_AllIdent";
            this.lbl_AllIdent.Size = new System.Drawing.Size(100, 23);
            this.lbl_AllIdent.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ident Reject";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_TimeEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_TimeFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(28, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 86);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Setting";
            // 
            // dtp_TimeEnd
            // 
            this.dtp_TimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimeEnd.Location = new System.Drawing.Point(68, 48);
            this.dtp_TimeEnd.Name = "dtp_TimeEnd";
            this.dtp_TimeEnd.Size = new System.Drawing.Size(142, 20);
            this.dtp_TimeEnd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // dtp_TimeFrom
            // 
            this.dtp_TimeFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_TimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimeFrom.Location = new System.Drawing.Point(68, 21);
            this.dtp_TimeFrom.Name = "dtp_TimeFrom";
            this.dtp_TimeFrom.Size = new System.Drawing.Size(142, 20);
            this.dtp_TimeFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(232, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 47);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Refresh";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "All Reject";
            // 
            // lbl_AllPicked
            // 
            this.lbl_AllPicked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AllPicked.Location = new System.Drawing.Point(149, 475);
            this.lbl_AllPicked.Name = "lbl_AllPicked";
            this.lbl_AllPicked.Size = new System.Drawing.Size(100, 23);
            this.lbl_AllPicked.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "All Picked";
            // 
            // lbl_AllReject
            // 
            this.lbl_AllReject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AllReject.Location = new System.Drawing.Point(149, 440);
            this.lbl_AllReject.Name = "lbl_AllReject";
            this.lbl_AllReject.Size = new System.Drawing.Size(100, 23);
            this.lbl_AllReject.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.特别说明ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.配置信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 特别说明ToolStripMenuItem
            // 
            this.特别说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用前阅读ToolStripMenuItem});
            this.特别说明ToolStripMenuItem.Name = "特别说明ToolStripMenuItem";
            this.特别说明ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.特别说明ToolStripMenuItem.Text = "特别说明";
            // 
            // 使用前阅读ToolStripMenuItem
            // 
            this.使用前阅读ToolStripMenuItem.Name = "使用前阅读ToolStripMenuItem";
            this.使用前阅读ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.使用前阅读ToolStripMenuItem.Text = "使用前阅读";
            this.使用前阅读ToolStripMenuItem.Click += new System.EventHandler(this.使用前阅读ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // 配置信息ToolStripMenuItem
            // 
            this.配置信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置SQLServerToolStripMenuItem});
            this.配置信息ToolStripMenuItem.Name = "配置信息ToolStripMenuItem";
            this.配置信息ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.配置信息ToolStripMenuItem.Text = "配置信息";
            // 
            // 配置SQLServerToolStripMenuItem
            // 
            this.配置SQLServerToolStripMenuItem.Name = "配置SQLServerToolStripMenuItem";
            this.配置SQLServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置SQLServerToolStripMenuItem.Text = "配置SQLServer";
            this.配置SQLServerToolStripMenuItem.Click += new System.EventHandler(this.配置SQLServerToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 556);
            this.Controls.Add(this.lbl_PlaceMent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_AllPicked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_AllReject);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attrition Clean Tools";
            this.Gp.ResumeLayout(false);
            this.Gp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PlaceMent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gp;
        private System.Windows.Forms.Label lbl_AllVacuum;
        private System.Windows.Forms.Button btn_DelFeeder;
        private System.Windows.Forms.Button btn_DelIdent;
        private System.Windows.Forms.Button btn_DelVacuum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_AllFeeder;
        private System.Windows.Forms.Label lbl_AllIdent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_TimeEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_TimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AllPicked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_AllReject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 特别说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用前阅读ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置SQLServerToolStripMenuItem;
    }
}

