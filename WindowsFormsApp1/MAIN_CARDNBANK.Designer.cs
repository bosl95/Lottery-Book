namespace WindowsFormsApp1
{
    partial class MAIN_CARDNBANK
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
            this.comboBox_attribute = new System.Windows.Forms.ComboBox();
            this.textBox_bankname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rB_bank = new System.Windows.Forms.RadioButton();
            this.rB_card = new System.Windows.Forms.RadioButton();
            this.textBox_accountnubmer = new System.Windows.Forms.TextBox();
            this.label_cardcompany = new System.Windows.Forms.Label();
            this.label_cardname = new System.Windows.Forms.Label();
            this.label_accountnumber = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBox_cardname = new System.Windows.Forms.TextBox();
            this.CB_cardcompany = new System.Windows.Forms.ComboBox();
            this.CB_bankname = new System.Windows.Forms.ComboBox();
            this.CB_duedate = new System.Windows.Forms.ComboBox();
            this.panel_card = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_card = new System.Windows.Forms.ListView();
            this.cardcompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_bankname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duedate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_bank = new System.Windows.Forms.ListView();
            this.bankname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_cardlist = new System.Windows.Forms.Panel();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.panel_card.SuspendLayout();
            this.panel_cardlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_attribute
            // 
            this.comboBox_attribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_attribute.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_attribute.FormattingEnabled = true;
            this.comboBox_attribute.Items.AddRange(new object[] {
            "현금",
            "자유입출금",
            "예금",
            "적금",
            "보험"});
            this.comboBox_attribute.Location = new System.Drawing.Point(258, 122);
            this.comboBox_attribute.Name = "comboBox_attribute";
            this.comboBox_attribute.Size = new System.Drawing.Size(171, 22);
            this.comboBox_attribute.TabIndex = 3;
            // 
            // textBox_bankname
            // 
            this.textBox_bankname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_bankname.Location = new System.Drawing.Point(258, 44);
            this.textBox_bankname.Name = "textBox_bankname";
            this.textBox_bankname.Size = new System.Drawing.Size(171, 21);
            this.textBox_bankname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(192, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "계좌번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(203, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "잔액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(192, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "자산속성";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(203, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "통장명";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rB_bank);
            this.groupBox.Controls.Add(this.rB_card);
            this.groupBox.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox.Location = new System.Drawing.Point(25, 28);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(141, 47);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "분류";
            // 
            // rB_bank
            // 
            this.rB_bank.AutoSize = true;
            this.rB_bank.Checked = true;
            this.rB_bank.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rB_bank.Location = new System.Drawing.Point(16, 17);
            this.rB_bank.Name = "rB_bank";
            this.rB_bank.Size = new System.Drawing.Size(47, 18);
            this.rB_bank.TabIndex = 0;
            this.rB_bank.TabStop = true;
            this.rB_bank.Text = "통장";
            this.rB_bank.UseVisualStyleBackColor = true;
            this.rB_bank.Click += new System.EventHandler(this.rB_bank_Click);
            // 
            // rB_card
            // 
            this.rB_card.AutoSize = true;
            this.rB_card.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rB_card.Location = new System.Drawing.Point(83, 17);
            this.rB_card.Name = "rB_card";
            this.rB_card.Size = new System.Drawing.Size(47, 18);
            this.rB_card.TabIndex = 1;
            this.rB_card.Text = "카드";
            this.rB_card.UseVisualStyleBackColor = true;
            this.rB_card.Click += new System.EventHandler(this.rB_card_Click);
            // 
            // textBox_accountnubmer
            // 
            this.textBox_accountnubmer.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_accountnubmer.Location = new System.Drawing.Point(258, 82);
            this.textBox_accountnubmer.Name = "textBox_accountnubmer";
            this.textBox_accountnubmer.Size = new System.Drawing.Size(171, 21);
            this.textBox_accountnubmer.TabIndex = 2;
            // 
            // label_cardcompany
            // 
            this.label_cardcompany.AutoSize = true;
            this.label_cardcompany.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_cardcompany.Location = new System.Drawing.Point(27, 22);
            this.label_cardcompany.Name = "label_cardcompany";
            this.label_cardcompany.Size = new System.Drawing.Size(40, 14);
            this.label_cardcompany.TabIndex = 29;
            this.label_cardcompany.Text = "카드사";
            // 
            // label_cardname
            // 
            this.label_cardname.AutoSize = true;
            this.label_cardname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_cardname.Location = new System.Drawing.Point(25, 60);
            this.label_cardname.Name = "label_cardname";
            this.label_cardname.Size = new System.Drawing.Size(40, 14);
            this.label_cardname.TabIndex = 30;
            this.label_cardname.Text = "카드명";
            // 
            // label_accountnumber
            // 
            this.label_accountnumber.AutoSize = true;
            this.label_accountnumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_accountnumber.Location = new System.Drawing.Point(15, 101);
            this.label_accountnumber.Name = "label_accountnumber";
            this.label_accountnumber.Size = new System.Drawing.Size(51, 14);
            this.label_accountnumber.TabIndex = 31;
            this.label_accountnumber.Text = "연계통장";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_.Location = new System.Drawing.Point(25, 136);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(40, 14);
            this.label_.TabIndex = 32;
            this.label_.Text = "결제일";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox.Location = new System.Drawing.Point(218, 59);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(70, 18);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "체크카드";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // textBox_cardname
            // 
            this.textBox_cardname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_cardname.Location = new System.Drawing.Point(81, 57);
            this.textBox_cardname.Name = "textBox_cardname";
            this.textBox_cardname.Size = new System.Drawing.Size(121, 21);
            this.textBox_cardname.TabIndex = 1;
            // 
            // CB_cardcompany
            // 
            this.CB_cardcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cardcompany.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_cardcompany.FormattingEnabled = true;
            this.CB_cardcompany.Items.AddRange(new object[] {
            "국민은행",
            "기업은행",
            "농협은행",
            "롯데은행",
            "비씨은행",
            "신한은행",
            "씨티은행",
            "외환은행",
            "우리은행",
            "하나은행",
            "현대은행",
            "기타"});
            this.CB_cardcompany.Location = new System.Drawing.Point(81, 18);
            this.CB_cardcompany.Name = "CB_cardcompany";
            this.CB_cardcompany.Size = new System.Drawing.Size(121, 22);
            this.CB_cardcompany.TabIndex = 0;
            // 
            // CB_bankname
            // 
            this.CB_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_bankname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_bankname.FormattingEnabled = true;
            this.CB_bankname.Location = new System.Drawing.Point(81, 98);
            this.CB_bankname.Name = "CB_bankname";
            this.CB_bankname.Size = new System.Drawing.Size(171, 22);
            this.CB_bankname.TabIndex = 3;
            this.CB_bankname.Click += new System.EventHandler(this.CB_bankname_Click);
            // 
            // CB_duedate
            // 
            this.CB_duedate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_duedate.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_duedate.FormattingEnabled = true;
            this.CB_duedate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.CB_duedate.Location = new System.Drawing.Point(81, 133);
            this.CB_duedate.Name = "CB_duedate";
            this.CB_duedate.Size = new System.Drawing.Size(58, 22);
            this.CB_duedate.TabIndex = 4;
            // 
            // panel_card
            // 
            this.panel_card.Controls.Add(this.label5);
            this.panel_card.Controls.Add(this.CB_duedate);
            this.panel_card.Controls.Add(this.CB_bankname);
            this.panel_card.Controls.Add(this.CB_cardcompany);
            this.panel_card.Controls.Add(this.textBox_cardname);
            this.panel_card.Controls.Add(this.checkBox);
            this.panel_card.Controls.Add(this.label_);
            this.panel_card.Controls.Add(this.label_accountnumber);
            this.panel_card.Controls.Add(this.label_cardname);
            this.panel_card.Controls.Add(this.label_cardcompany);
            this.panel_card.Location = new System.Drawing.Point(172, 28);
            this.panel_card.Name = "panel_card";
            this.panel_card.Size = new System.Drawing.Size(302, 179);
            this.panel_card.TabIndex = 0;
            this.panel_card.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 14);
            this.label5.TabIndex = 33;
            this.label5.Text = "일";
            // 
            // listView_card
            // 
            this.listView_card.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cardcompany,
            this.cardname,
            this.c_bankname,
            this.duedate});
            this.listView_card.Location = new System.Drawing.Point(0, 0);
            this.listView_card.Name = "listView_card";
            this.listView_card.Size = new System.Drawing.Size(518, 295);
            this.listView_card.TabIndex = 34;
            this.listView_card.UseCompatibleStateImageBehavior = false;
            this.listView_card.View = System.Windows.Forms.View.Details;
            // 
            // cardcompany
            // 
            this.cardcompany.Text = "카드사";
            this.cardcompany.Width = 110;
            // 
            // cardname
            // 
            this.cardname.Text = "카드명";
            this.cardname.Width = 130;
            // 
            // c_bankname
            // 
            this.c_bankname.Text = "연계통장";
            this.c_bankname.Width = 170;
            // 
            // duedate
            // 
            this.duedate.Text = "결제일";
            this.duedate.Width = 70;
            // 
            // listView_bank
            // 
            this.listView_bank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bankname,
            this.B_account,
            this.attribute,
            this.sum});
            this.listView_bank.Location = new System.Drawing.Point(25, 236);
            this.listView_bank.Name = "listView_bank";
            this.listView_bank.Size = new System.Drawing.Size(518, 295);
            this.listView_bank.TabIndex = 35;
            this.listView_bank.UseCompatibleStateImageBehavior = false;
            this.listView_bank.View = System.Windows.Forms.View.Details;
            // 
            // bankname
            // 
            this.bankname.Text = "통장명";
            this.bankname.Width = 120;
            // 
            // B_account
            // 
            this.B_account.Text = "계좌번호";
            this.B_account.Width = 150;
            // 
            // attribute
            // 
            this.attribute.Text = "자산속성";
            this.attribute.Width = 90;
            // 
            // sum
            // 
            this.sum.Text = "잔액";
            this.sum.Width = 150;
            // 
            // panel_cardlist
            // 
            this.panel_cardlist.Controls.Add(this.listView_card);
            this.panel_cardlist.Location = new System.Drawing.Point(25, 236);
            this.panel_cardlist.Name = "panel_cardlist";
            this.panel_cardlist.Size = new System.Drawing.Size(518, 295);
            this.panel_cardlist.TabIndex = 40;
            this.panel_cardlist.Visible = false;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_sum.Location = new System.Drawing.Point(258, 158);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(171, 21);
            this.textBox_sum.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(493, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(493, 184);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(45, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // MAIN_CARDNBANK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 574);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.panel_cardlist);
            this.Controls.Add(this.listView_bank);
            this.Controls.Add(this.comboBox_attribute);
            this.Controls.Add(this.textBox_bankname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBox_accountnubmer);
            this.Controls.Add(this.textBox_sum);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MAIN_CARDNBANK";
            this.Text = "카드/통장관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_CARDNBANK_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.panel_cardlist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_bankname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rB_bank;
        private System.Windows.Forms.RadioButton rB_card;
        private System.Windows.Forms.TextBox textBox_accountnubmer;
        private System.Windows.Forms.Label label_cardcompany;
        private System.Windows.Forms.Label label_cardname;
        private System.Windows.Forms.Label label_accountnumber;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBox_cardname;
        private System.Windows.Forms.ComboBox CB_cardcompany;
        private System.Windows.Forms.ComboBox CB_bankname;
        private System.Windows.Forms.ComboBox CB_duedate;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.ListView listView_card;
        private System.Windows.Forms.ColumnHeader cardcompany;
        private System.Windows.Forms.ColumnHeader cardname;
        private System.Windows.Forms.ColumnHeader c_bankname;
        private System.Windows.Forms.ColumnHeader duedate;
        private System.Windows.Forms.ListView listView_bank;
        private System.Windows.Forms.ColumnHeader bankname;
        private System.Windows.Forms.ColumnHeader B_account;
        private System.Windows.Forms.ColumnHeader attribute;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.Panel panel_cardlist;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox comboBox_attribute;
        private System.Windows.Forms.Label label5;
    }
}