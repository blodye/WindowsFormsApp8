namespace WindowsFormsApp8
{
    partial class kalyan
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
            this.components = new System.ComponentModel.Container();
            this.red = new System.Windows.Forms.Panel();
            this.deleteprodaja = new System.Windows.Forms.Button();
            this.dobavcena = new System.Windows.Forms.TextBox();
            this.dobavnaimenovanie = new System.Windows.Forms.TextBox();
            this.dobavkalyanprodaja = new System.Windows.Forms.Button();
            this.kalyany = new System.Windows.Forms.DataGridView();
            this.idkalyanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalyanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalDataSet = new WindowsFormsApp8.kalDataSet();
            this.nazad = new System.Windows.Forms.Button();
            this.kalyanTableAdapter = new WindowsFormsApp8.kalDataSetTableAdapters.kalyanTableAdapter();
            this.poiskkalyana = new System.Windows.Forms.TextBox();
            this.poiskkalyan = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.red.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kalyany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalyanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.red.Controls.Add(this.deleteprodaja);
            this.red.Controls.Add(this.dobavcena);
            this.red.Controls.Add(this.dobavnaimenovanie);
            this.red.Controls.Add(this.dobavkalyanprodaja);
            this.red.Location = new System.Drawing.Point(3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(200, 448);
            this.red.TabIndex = 0;
            // 
            // deleteprodaja
            // 
            this.deleteprodaja.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteprodaja.Location = new System.Drawing.Point(25, 226);
            this.deleteprodaja.Name = "deleteprodaja";
            this.deleteprodaja.Size = new System.Drawing.Size(143, 47);
            this.deleteprodaja.TabIndex = 3;
            this.deleteprodaja.Text = "Убрать с продажи";
            this.deleteprodaja.UseVisualStyleBackColor = false;
            this.deleteprodaja.Click += new System.EventHandler(this.deleteprodaja_Click);
            // 
            // dobavcena
            // 
            this.dobavcena.Location = new System.Drawing.Point(5, 137);
            this.dobavcena.Name = "dobavcena";
            this.dobavcena.Size = new System.Drawing.Size(195, 20);
            this.dobavcena.TabIndex = 3;
            // 
            // dobavnaimenovanie
            // 
            this.dobavnaimenovanie.Location = new System.Drawing.Point(5, 111);
            this.dobavnaimenovanie.Name = "dobavnaimenovanie";
            this.dobavnaimenovanie.Size = new System.Drawing.Size(195, 20);
            this.dobavnaimenovanie.TabIndex = 3;
            this.dobavnaimenovanie.TextChanged += new System.EventHandler(this.dobavnaimenovanie_TextChanged);
            // 
            // dobavkalyanprodaja
            // 
            this.dobavkalyanprodaja.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavkalyanprodaja.Location = new System.Drawing.Point(25, 38);
            this.dobavkalyanprodaja.Name = "dobavkalyanprodaja";
            this.dobavkalyanprodaja.Size = new System.Drawing.Size(143, 56);
            this.dobavkalyanprodaja.TabIndex = 3;
            this.dobavkalyanprodaja.Text = "Добавить кальян на продажу";
            this.dobavkalyanprodaja.UseVisualStyleBackColor = false;
            this.dobavkalyanprodaja.Click += new System.EventHandler(this.dobavkalyanprodaja_Click);
            // 
            // kalyany
            // 
            this.kalyany.AutoGenerateColumns = false;
            this.kalyany.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kalyany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kalyany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkalyanDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.kalyany.DataSource = this.kalyanBindingSource;
            this.kalyany.Location = new System.Drawing.Point(224, 2);
            this.kalyany.Name = "kalyany";
            this.kalyany.Size = new System.Drawing.Size(346, 436);
            this.kalyany.TabIndex = 1;
            this.kalyany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kalyany_CellContentClick);
            // 
            // idkalyanDataGridViewTextBoxColumn
            // 
            this.idkalyanDataGridViewTextBoxColumn.DataPropertyName = "idkalyan";
            this.idkalyanDataGridViewTextBoxColumn.HeaderText = "idkalyan";
            this.idkalyanDataGridViewTextBoxColumn.Name = "idkalyanDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // kalyanBindingSource
            // 
            this.kalyanBindingSource.DataMember = "kalyan";
            this.kalyanBindingSource.DataSource = this.kalDataSet;
            // 
            // kalDataSet
            // 
            this.kalDataSet.DataSetName = "kalDataSet";
            this.kalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(721, 2);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(103, 43);
            this.nazad.TabIndex = 2;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // kalyanTableAdapter
            // 
            this.kalyanTableAdapter.ClearBeforeFill = true;
            // 
            // poiskkalyana
            // 
            this.poiskkalyana.Location = new System.Drawing.Point(594, 88);
            this.poiskkalyana.Name = "poiskkalyana";
            this.poiskkalyana.Size = new System.Drawing.Size(206, 20);
            this.poiskkalyana.TabIndex = 3;
            // 
            // poiskkalyan
            // 
            this.poiskkalyan.Location = new System.Drawing.Point(628, 129);
            this.poiskkalyan.Name = "poiskkalyan";
            this.poiskkalyan.Size = new System.Drawing.Size(135, 53);
            this.poiskkalyan.TabIndex = 4;
            this.poiskkalyan.Text = "Найти кальян";
            this.poiskkalyan.UseVisualStyleBackColor = false;
            this.poiskkalyan.Click += new System.EventHandler(this.poiskkalyan_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(651, 188);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(89, 54);
            this.update.TabIndex = 5;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // kalyan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.poiskkalyan);
            this.Controls.Add(this.poiskkalyana);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.kalyany);
            this.Controls.Add(this.red);
            this.Name = "kalyan";
            this.Text = "Кальяны";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.red.ResumeLayout(false);
            this.red.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kalyany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalyanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.DataGridView kalyany;
        private kalDataSet kalDataSet;
        private System.Windows.Forms.BindingSource kalyanBindingSource;
        private kalDataSetTableAdapters.kalyanTableAdapter kalyanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkalyanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.TextBox dobavcena;
        private System.Windows.Forms.TextBox dobavnaimenovanie;
        private System.Windows.Forms.Button dobavkalyanprodaja;
        private System.Windows.Forms.Button deleteprodaja;
        private System.Windows.Forms.TextBox poiskkalyana;
        private System.Windows.Forms.Button poiskkalyan;
        private System.Windows.Forms.Button update;
    }
}