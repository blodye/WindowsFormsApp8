namespace WindowsFormsApp8
{
    partial class auto
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
            this.Vhod = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.parol = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.Panel();
            this.red.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vhod
            // 
            this.Vhod.Location = new System.Drawing.Point(133, 3);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(162, 87);
            this.Vhod.TabIndex = 0;
            this.Vhod.Text = "Войти";
            this.Vhod.UseVisualStyleBackColor = true;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.login.Location = new System.Drawing.Point(109, 39);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(223, 33);
            this.login.TabIndex = 1;
            this.login.Text = "Логин:";
            // 
            // parol
            // 
            this.parol.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parol.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.parol.Location = new System.Drawing.Point(109, 122);
            this.parol.Name = "parol";
            this.parol.PasswordChar = '*';
            this.parol.Size = new System.Drawing.Size(223, 33);
            this.parol.TabIndex = 2;
            this.parol.Text = "Пароль:";
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.red.Controls.Add(this.Vhod);
            this.red.Location = new System.Drawing.Point(2, 198);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(409, 100);
            this.red.TabIndex = 3;
            // 
            // auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(412, 336);
            this.Controls.Add(this.red);
            this.Controls.Add(this.parol);
            this.Controls.Add(this.login);
            this.Name = "auto";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.red.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox parol;
        private System.Windows.Forms.Panel red;
    }
}