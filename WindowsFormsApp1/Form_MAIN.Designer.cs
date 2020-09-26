namespace WindowsFormsApp1
{
    partial class Form_MAIN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MAIN));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.breakdown = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.column_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_log = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_card = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_bank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statistics = new System.Windows.Forms.TabPage();
            this.listView_chart = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart_date = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.카드통장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_date = new System.Windows.Forms.Label();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_readdata = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.breakdown.SuspendLayout();
            this.statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_date)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.breakdown);
            this.tabControl.Controls.Add(this.statistics);
            this.tabControl.Location = new System.Drawing.Point(12, 114);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(990, 404);
            this.tabControl.TabIndex = 4;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // breakdown
            // 
            this.breakdown.AllowDrop = true;
            this.breakdown.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breakdown.Controls.Add(this.listView);
            this.breakdown.Location = new System.Drawing.Point(4, 23);
            this.breakdown.Name = "breakdown";
            this.breakdown.Padding = new System.Windows.Forms.Padding(3);
            this.breakdown.Size = new System.Drawing.Size(982, 377);
            this.breakdown.TabIndex = 0;
            this.breakdown.Text = "내역";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_date,
            this.column_log,
            this.Column_cash,
            this.column_card,
            this.column_bank,
            this.column_account,
            this.column_type,
            this.column_category});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(984, 377);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column_date
            // 
            this.column_date.Text = "날짜";
            this.column_date.Width = 160;
            // 
            // column_log
            // 
            this.column_log.Text = "사용내역";
            this.column_log.Width = 150;
            // 
            // Column_cash
            // 
            this.Column_cash.Text = "현금";
            this.Column_cash.Width = 140;
            // 
            // column_card
            // 
            this.column_card.Text = "카드";
            this.column_card.Width = 140;
            // 
            // column_bank
            // 
            this.column_bank.Text = "출금통장";
            this.column_bank.Width = 90;
            // 
            // column_account
            // 
            this.column_account.Text = "계좌번호";
            this.column_account.Width = 130;
            // 
            // column_type
            // 
            this.column_type.Text = "구분";
            // 
            // column_category
            // 
            this.column_category.Text = "카테고리";
            this.column_category.Width = 100;
            // 
            // statistics
            // 
            this.statistics.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statistics.Controls.Add(this.listView_chart);
            this.statistics.Controls.Add(this.chart_date);
            this.statistics.Location = new System.Drawing.Point(4, 23);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(982, 377);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "지출 분석";
            // 
            // listView_chart
            // 
            this.listView_chart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.amount,
            this.percentage});
            this.listView_chart.FullRowSelect = true;
            this.listView_chart.Location = new System.Drawing.Point(51, 44);
            this.listView_chart.Name = "listView_chart";
            this.listView_chart.Size = new System.Drawing.Size(419, 275);
            this.listView_chart.TabIndex = 1;
            this.listView_chart.UseCompatibleStateImageBehavior = false;
            this.listView_chart.View = System.Windows.Forms.View.Details;
            this.listView_chart.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_chart_ColumnClick);
            // 
            // category
            // 
            this.category.Text = "카테고리";
            this.category.Width = 100;
            // 
            // amount
            // 
            this.amount.Text = "총 금액";
            this.amount.Width = 200;
            // 
            // percentage
            // 
            this.percentage.Tag = "Numeric";
            this.percentage.Text = "";
            // 
            // chart_date
            // 
            this.chart_date.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart_date.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_date.Legends.Add(legend3);
            this.chart_date.Location = new System.Drawing.Point(551, 0);
            this.chart_date.Name = "chart_date";
            this.chart_date.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("나눔바른고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "chart_pie";
            dataPoint3.Label = "";
            series3.Points.Add(dataPoint3);
            this.chart_date.Series.Add(series3);
            this.chart_date.Size = new System.Drawing.Size(431, 374);
            this.chart_date.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_add.Location = new System.Drawing.Point(705, 543);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(72, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_delete.Location = new System.Drawing.Point(886, 543);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(64, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.카드통장ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 카드통장ToolStripMenuItem
            // 
            this.카드통장ToolStripMenuItem.Name = "카드통장ToolStripMenuItem";
            this.카드통장ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.카드통장ToolStripMenuItem.Text = "카드/통장";
            this.카드통장ToolStripMenuItem.Click += new System.EventHandler(this.카드통장ToolStripMenuItem_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_date.Location = new System.Drawing.Point(874, 97);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(41, 14);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "label1";
            this.label_date.TextChanged += new System.EventHandler(this.label_date_TextChanged);
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_left.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_left.Location = new System.Drawing.Point(813, 93);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(37, 23);
            this.button_left.TabIndex = 1;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_right.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_right.Location = new System.Drawing.Point(951, 93);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(37, 23);
            this.button_right.TabIndex = 3;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_modify
            // 
            this.button_modify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_modify.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_modify.FlatAppearance.BorderSize = 0;
            this.button_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_modify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_modify.Location = new System.Drawing.Point(800, 543);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(68, 23);
            this.button_modify.TabIndex = 6;
            this.button_modify.Text = "수정";
            this.button_modify.UseVisualStyleBackColor = false;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_readdata
            // 
            this.button_readdata.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_readdata.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button_readdata.FlatAppearance.BorderSize = 0;
            this.button_readdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_readdata.Image = ((System.Drawing.Image)(resources.GetObject("button_readdata.Image")));
            this.button_readdata.Location = new System.Drawing.Point(734, 72);
            this.button_readdata.Name = "button_readdata";
            this.button_readdata.Size = new System.Drawing.Size(56, 51);
            this.button_readdata.TabIndex = 1;
            this.button_readdata.UseVisualStyleBackColor = false;
            this.button_readdata.Click += new System.EventHandler(this.button_readdata_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(938, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "전체삭제";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_readdata);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MAIN";
            this.Text = "LOTTERY BOOK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MAIN_FormClosed);
            this.Load += new System.EventHandler(this.Form_MAIN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_MAIN_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.breakdown.ResumeLayout(false);
            this.statistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_date)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage breakdown;
        private System.Windows.Forms.TabPage statistics;
        private System.Windows.Forms.ColumnHeader column_date;
        private System.Windows.Forms.ColumnHeader column_log;
        private System.Windows.Forms.ColumnHeader column_card;
        private System.Windows.Forms.ColumnHeader column_bank;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ColumnHeader Column_cash;
        private System.Windows.Forms.ColumnHeader column_category;
        private System.Windows.Forms.ColumnHeader column_type;
        private System.Windows.Forms.ColumnHeader column_account;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_date;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카드통장ToolStripMenuItem;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.ListView listView_chart;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader percentage;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_readdata;
        public System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button2;
    }
}