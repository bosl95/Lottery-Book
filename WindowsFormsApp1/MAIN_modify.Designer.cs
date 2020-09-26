namespace WindowsFormsApp1
{
    partial class MAIN_modify
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.CB_account = new System.Windows.Forms.ComboBox();
            this.label_account = new System.Windows.Forms.Label();
            this.CB_bankname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_detail = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(318, 125);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(48, 18);
            this.checkBox.TabIndex = 22;
            this.checkBox.Text = "현금";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // CB_account
            // 
            this.CB_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_account.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_account.FormattingEnabled = true;
            this.CB_account.Location = new System.Drawing.Point(132, 171);
            this.CB_account.Name = "CB_account";
            this.CB_account.Size = new System.Drawing.Size(247, 22);
            this.CB_account.TabIndex = 23;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_account.Location = new System.Drawing.Point(23, 175);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(51, 14);
            this.label_account.TabIndex = 28;
            this.label_account.Text = "계좌번호";
            // 
            // CB_bankname
            // 
            this.CB_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_bankname.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_bankname.FormattingEnabled = true;
            this.CB_bankname.Location = new System.Drawing.Point(132, 122);
            this.CB_bankname.Name = "CB_bankname";
            this.CB_bankname.Size = new System.Drawing.Size(171, 22);
            this.CB_bankname.TabIndex = 20;
            this.CB_bankname.TextChanged += new System.EventHandler(this.CB_bankname_TextChanged);
            this.CB_bankname.Click += new System.EventHandler(this.CB_bankname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "출금통장";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Enabled = false;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(132, 279);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(178, 22);
            this.comboBox_category.TabIndex = 25;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_type.Location = new System.Drawing.Point(33, 230);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 14);
            this.label_type.TabIndex = 26;
            this.label_type.Text = "구분";
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(132, 24);
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(247, 21);
            this.textBox_detail.TabIndex = 16;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(132, 73);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(247, 21);
            this.textBox_amount.TabIndex = 18;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "수입",
            "지출",
            "저축"});
            this.comboBox_type.Location = new System.Drawing.Point(132, 227);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(171, 22);
            this.comboBox_type.TabIndex = 24;
            this.comboBox_type.TextChanged += new System.EventHandler(this.comboBox_type_TextChanged);
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_detail.Location = new System.Drawing.Point(23, 27);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(51, 14);
            this.label_detail.TabIndex = 21;
            this.label_detail.Text = "사용내역";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_amount.Location = new System.Drawing.Point(33, 76);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(29, 14);
            this.label_amount.TabIndex = 19;
            this.label_amount.Text = "금액";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_category.Location = new System.Drawing.Point(26, 283);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(51, 14);
            this.label_category.TabIndex = 17;
            this.label_category.Text = "카테고리";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.Location = new System.Drawing.Point(251, 341);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 31);
            this.button_close.TabIndex = 30;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_modify
            // 
            this.button_modify.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_modify.Location = new System.Drawing.Point(104, 341);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 31);
            this.button_modify.TabIndex = 29;
            this.button_modify.Text = "수정";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // MAIN_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 401);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_modify);
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
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_category);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MAIN_modify";
            this.Text = "수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox CB_account;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.ComboBox CB_bankname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_modify;
    }
}