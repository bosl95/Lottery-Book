namespace WindowsFormsApp1
{
    partial class Main_ADD
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_detail = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_bankname = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.CB_account = new System.Windows.Forms.ComboBox();
            this.label_account = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_date.Location = new System.Drawing.Point(31, 43);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(29, 14);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "날짜";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_category.Location = new System.Drawing.Point(24, 301);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(51, 14);
            this.label_category.TabIndex = 1;
            this.label_category.Text = "카테고리";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_amount.Location = new System.Drawing.Point(31, 124);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(29, 14);
            this.label_amount.TabIndex = 2;
            this.label_amount.Text = "금액";
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_detail.Location = new System.Drawing.Point(21, 82);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(51, 14);
            this.label_detail.TabIndex = 3;
            this.label_detail.Text = "사용내역";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(130, 36);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(114, 21);
            this.dateTimePicker.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_add.Location = new System.Drawing.Point(96, 345);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 27);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.Location = new System.Drawing.Point(243, 345);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 27);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(130, 121);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(247, 21);
            this.textBox_amount.TabIndex = 2;
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(130, 79);
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(247, 21);
            this.textBox_detail.TabIndex = 1;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Enabled = false;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(130, 298);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(178, 22);
            this.comboBox_category.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "출금통장";
            // 
            // CB_bankname
            // 
            this.CB_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_bankname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_bankname.FormattingEnabled = true;
            this.CB_bankname.Location = new System.Drawing.Point(130, 163);
            this.CB_bankname.Name = "CB_bankname";
            this.CB_bankname.Size = new System.Drawing.Size(171, 22);
            this.CB_bankname.TabIndex = 3;
            this.CB_bankname.TextChanged += new System.EventHandler(this.CB_bankname_TextChanged);
            this.CB_bankname.Click += new System.EventHandler(this.CB_bankname_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "수입",
            "지출",
            "저축"});
            this.comboBox_type.Location = new System.Drawing.Point(130, 253);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(171, 22);
            this.comboBox_type.TabIndex = 6;
            this.comboBox_type.TextChanged += new System.EventHandler(this.comboBox_type_TextChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_type.Location = new System.Drawing.Point(31, 256);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 14);
            this.label_type.TabIndex = 9;
            this.label_type.Text = "구분";
            // 
            // CB_account
            // 
            this.CB_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_account.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_account.FormattingEnabled = true;
            this.CB_account.Location = new System.Drawing.Point(130, 205);
            this.CB_account.Name = "CB_account";
            this.CB_account.Size = new System.Drawing.Size(247, 22);
            this.CB_account.TabIndex = 5;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_account.Location = new System.Drawing.Point(21, 209);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(51, 14);
            this.label_account.TabIndex = 13;
            this.label_account.Text = "계좌번호";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(316, 166);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(48, 18);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "현금";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_time.Location = new System.Drawing.Point(263, 36);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker_time.TabIndex = 14;
            // 
            // Main_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 397);
            this.Controls.Add(this.dateTimePicker_time);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.CB_account);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.CB_bankname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.textBox_detail);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_date);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Main_ADD";
            this.Text = "추가";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_ADD_FormClosed);
            this.Load += new System.EventHandler(this.Main_ADD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_ADD_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_bankname;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox CB_account;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
    }
}