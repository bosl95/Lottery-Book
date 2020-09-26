namespace WindowsFormsApp1
{
    partial class Form_LOGIN
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.button_join = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancle = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Arciform", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(54, 114);
            this.label_id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Arciform", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.Location = new System.Drawing.Point(45, 171);
            this.label_pwd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(41, 20);
            this.label_pwd.TabIndex = 1;
            this.label_pwd.Text = "PWD";
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(121, 109);
            this.textbox_id.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(240, 31);
            this.textbox_id.TabIndex = 2;
            this.textbox_id.Text = "hong123";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Font = new System.Drawing.Font("HY견고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_pwd.Location = new System.Drawing.Point(121, 166);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(240, 29);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.Text = "1234";
            // 
            // button_join
            // 
            this.button_join.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_join.FlatAppearance.BorderSize = 0;
            this.button_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_join.Font = new System.Drawing.Font("Arciform", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_join.Location = new System.Drawing.Point(49, 236);
            this.button_join.Margin = new System.Windows.Forms.Padding(5);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(86, 30);
            this.button_join.TabIndex = 4;
            this.button_join.Text = "JOIN";
            this.button_join.UseVisualStyleBackColor = false;
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_confirm.FlatAppearance.BorderSize = 0;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Arciform", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(170, 236);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(5);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(86, 30);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "CONFIRM";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancle
            // 
            this.button_cancle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cancle.FlatAppearance.BorderSize = 0;
            this.button_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancle.Font = new System.Drawing.Font("Arciform", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancle.Location = new System.Drawing.Point(288, 236);
            this.button_cancle.Margin = new System.Windows.Forms.Padding(5);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(86, 30);
            this.button_cancle.TabIndex = 6;
            this.button_cancle.Text = "CANCLE";
            this.button_cancle.UseVisualStyleBackColor = false;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arciform", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(102, 40);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(202, 33);
            this.label.TabIndex = 7;
            this.label.Text = "LOTTERY BOOK";
            // 
            // Form_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 314);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_join);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_id);
            this.Font = new System.Drawing.Font("Arciform", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form_LOGIN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_LOGIN_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Button button_join;
        public System.Windows.Forms.TextBox textbox_id;
        public System.Windows.Forms.TextBox textBox_pwd;
    }
}

