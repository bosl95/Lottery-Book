namespace WindowsFormsApp1
{
    partial class Form_JOIN
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.label_check = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_cash = new System.Windows.Forms.Label();
            this.textBox_cash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(20, 142);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(31, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "이름";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_id.Location = new System.Drawing.Point(29, 44);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 15);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_pwd.Location = new System.Drawing.Point(20, 92);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(37, 15);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "PWD";
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_signup.FlatAppearance.BorderSize = 0;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_signup.Location = new System.Drawing.Point(93, 247);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(85, 28);
            this.button_signup.TabIndex = 8;
            this.button_signup.Text = "확인";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(208, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_check.Location = new System.Drawing.Point(321, 39);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 10;
            this.button_check.Text = "중복확인";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_check.Location = new System.Drawing.Point(355, 142);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(0, 15);
            this.label_check.TabIndex = 11;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_id.Location = new System.Drawing.Point(93, 40);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(211, 22);
            this.textBox_id.TabIndex = 12;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_pwd.Location = new System.Drawing.Point(93, 89);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(211, 22);
            this.textBox_pwd.TabIndex = 13;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_name.Location = new System.Drawing.Point(93, 139);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(211, 22);
            this.textBox_name.TabIndex = 14;
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_cash.Location = new System.Drawing.Point(20, 192);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(31, 15);
            this.label_cash.TabIndex = 15;
            this.label_cash.Text = "현금";
            // 
            // textBox_cash
            // 
            this.textBox_cash.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_cash.Location = new System.Drawing.Point(93, 189);
            this.textBox_cash.Name = "textBox_cash";
            this.textBox_cash.Size = new System.Drawing.Size(211, 22);
            this.textBox_cash.TabIndex = 16;
            this.textBox_cash.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "원";
            // 
            // Form_JOIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cash);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_check);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_name);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_JOIN";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_check;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.TextBox textBox_cash;
        private System.Windows.Forms.Label label1;
    }
}