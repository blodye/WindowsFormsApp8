namespace WindowsFormsApp8
{
    partial class VIbor
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
            this.red = new System.Windows.Forms.Panel();
            this.dobavitdetali = new System.Windows.Forms.Button();
            this.dobavitkalyan = new System.Windows.Forms.Button();
            this.red.SuspendLayout();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.red.Controls.Add(this.dobavitdetali);
            this.red.Controls.Add(this.dobavitkalyan);
            this.red.Location = new System.Drawing.Point(2, 1);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(181, 449);
            this.red.TabIndex = 0;
            // 
            // dobavitdetali
            // 
            this.dobavitdetali.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavitdetali.Location = new System.Drawing.Point(3, 265);
            this.dobavitdetali.Name = "dobavitdetali";
            this.dobavitdetali.Size = new System.Drawing.Size(175, 181);
            this.dobavitdetali.TabIndex = 1;
            this.dobavitdetali.Text = "Добавить детали";
            this.dobavitdetali.UseVisualStyleBackColor = true;
            this.dobavitdetali.Click += new System.EventHandler(this.dobavitdetali_Click);
            // 
            // dobavitkalyan
            // 
            this.dobavitkalyan.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavitkalyan.Location = new System.Drawing.Point(3, 3);
            this.dobavitkalyan.Name = "dobavitkalyan";
            this.dobavitkalyan.Size = new System.Drawing.Size(175, 200);
            this.dobavitkalyan.TabIndex = 1;
            this.dobavitkalyan.Text = "Добавить кальян";
            this.dobavitkalyan.UseVisualStyleBackColor = true;
            this.dobavitkalyan.Click += new System.EventHandler(this.dobavitkalyan_Click);
            // 
            // VIbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.red);
            this.Name = "VIbor";
            this.Text = "Выбор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.red.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Button dobavitkalyan;
        private System.Windows.Forms.Button dobavitdetali;
    }
}