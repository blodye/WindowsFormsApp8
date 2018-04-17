namespace WindowsFormsApp8
{
    partial class detali
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
            this.dobavcena = new System.Windows.Forms.TextBox();
            this.dobavshlang = new System.Windows.Forms.Button();
            this.dobavitcvet = new System.Windows.Forms.TextBox();
            this.dobavitmaterial = new System.Windows.Forms.TextBox();
            this.dobavcvet = new System.Windows.Forms.TextBox();
            this.dobavmaterial = new System.Windows.Forms.TextBox();
            this.dobavitchasha = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.chashi = new System.Windows.Forms.DataGridView();
            this.idchashaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chashaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalDataSet = new WindowsFormsApp8.kalDataSet();
            this.chashaTableAdapter = new WindowsFormsApp8.kalDataSetTableAdapters.chashaTableAdapter();
            this.shlangi = new System.Windows.Forms.DataGridView();
            this.idshlangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shlangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shlangTableAdapter = new WindowsFormsApp8.kalDataSetTableAdapters.shlangTableAdapter();
            this.poiskchasha = new System.Windows.Forms.Button();
            this.naytichasha = new System.Windows.Forms.TextBox();
            this.naytishlang = new System.Windows.Forms.Button();
            this.poiskshlang = new System.Windows.Forms.TextBox();
            this.update1 = new System.Windows.Forms.Button();
            this.update2 = new System.Windows.Forms.Button();
            this.red.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chashaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shlangi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shlangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.red.Controls.Add(this.dobavcena);
            this.red.Controls.Add(this.dobavshlang);
            this.red.Controls.Add(this.dobavitcvet);
            this.red.Controls.Add(this.dobavitmaterial);
            this.red.Controls.Add(this.dobavcvet);
            this.red.Controls.Add(this.dobavmaterial);
            this.red.Controls.Add(this.dobavitchasha);
            this.red.Controls.Add(this.nazad);
            this.red.Location = new System.Drawing.Point(1, 1);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(200, 449);
            this.red.TabIndex = 0;
            // 
            // dobavcena
            // 
            this.dobavcena.Location = new System.Drawing.Point(20, 417);
            this.dobavcena.Name = "dobavcena";
            this.dobavcena.Size = new System.Drawing.Size(160, 20);
            this.dobavcena.TabIndex = 3;
            // 
            // dobavshlang
            // 
            this.dobavshlang.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavshlang.Location = new System.Drawing.Point(20, 256);
            this.dobavshlang.Name = "dobavshlang";
            this.dobavshlang.Size = new System.Drawing.Size(160, 63);
            this.dobavshlang.TabIndex = 3;
            this.dobavshlang.Text = "Добавить шланг";
            this.dobavshlang.UseVisualStyleBackColor = false;
            this.dobavshlang.Click += new System.EventHandler(this.dobavshlang_Click);
            // 
            // dobavitcvet
            // 
            this.dobavitcvet.Location = new System.Drawing.Point(20, 383);
            this.dobavitcvet.Name = "dobavitcvet";
            this.dobavitcvet.Size = new System.Drawing.Size(160, 20);
            this.dobavitcvet.TabIndex = 3;
            // 
            // dobavitmaterial
            // 
            this.dobavitmaterial.Location = new System.Drawing.Point(20, 348);
            this.dobavitmaterial.Name = "dobavitmaterial";
            this.dobavitmaterial.Size = new System.Drawing.Size(160, 20);
            this.dobavitmaterial.TabIndex = 3;
            // 
            // dobavcvet
            // 
            this.dobavcvet.Location = new System.Drawing.Point(20, 198);
            this.dobavcvet.Name = "dobavcvet";
            this.dobavcvet.Size = new System.Drawing.Size(160, 20);
            this.dobavcvet.TabIndex = 3;
            // 
            // dobavmaterial
            // 
            this.dobavmaterial.Location = new System.Drawing.Point(20, 162);
            this.dobavmaterial.Name = "dobavmaterial";
            this.dobavmaterial.Size = new System.Drawing.Size(160, 20);
            this.dobavmaterial.TabIndex = 3;
            // 
            // dobavitchasha
            // 
            this.dobavitchasha.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavitchasha.Location = new System.Drawing.Point(20, 73);
            this.dobavitchasha.Name = "dobavitchasha";
            this.dobavitchasha.Size = new System.Drawing.Size(160, 60);
            this.dobavitchasha.TabIndex = 3;
            this.dobavitchasha.Text = "Добавить чаши";
            this.dobavitchasha.UseVisualStyleBackColor = false;
            this.dobavitchasha.Click += new System.EventHandler(this.dobavitchasha_Click);
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(11, 11);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(97, 41);
            this.nazad.TabIndex = 3;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // chashi
            // 
            this.chashi.AutoGenerateColumns = false;
            this.chashi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chashi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idchashaDataGridViewTextBoxColumn,
            this.materDataGridViewTextBoxColumn,
            this.cvetDataGridViewTextBoxColumn});
            this.chashi.DataSource = this.chashaBindingSource;
            this.chashi.Location = new System.Drawing.Point(207, 1);
            this.chashi.Name = "chashi";
            this.chashi.Size = new System.Drawing.Size(345, 182);
            this.chashi.TabIndex = 1;
            this.chashi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chashi_CellContentClick);
            // 
            // idchashaDataGridViewTextBoxColumn
            // 
            this.idchashaDataGridViewTextBoxColumn.DataPropertyName = "idchasha";
            this.idchashaDataGridViewTextBoxColumn.HeaderText = "idchasha";
            this.idchashaDataGridViewTextBoxColumn.Name = "idchashaDataGridViewTextBoxColumn";
            // 
            // materDataGridViewTextBoxColumn
            // 
            this.materDataGridViewTextBoxColumn.DataPropertyName = "mater";
            this.materDataGridViewTextBoxColumn.HeaderText = "mater";
            this.materDataGridViewTextBoxColumn.Name = "materDataGridViewTextBoxColumn";
            // 
            // cvetDataGridViewTextBoxColumn
            // 
            this.cvetDataGridViewTextBoxColumn.DataPropertyName = "cvet";
            this.cvetDataGridViewTextBoxColumn.HeaderText = "cvet";
            this.cvetDataGridViewTextBoxColumn.Name = "cvetDataGridViewTextBoxColumn";
            // 
            // chashaBindingSource
            // 
            this.chashaBindingSource.DataMember = "chasha";
            this.chashaBindingSource.DataSource = this.kalDataSet;
            // 
            // kalDataSet
            // 
            this.kalDataSet.DataSetName = "kalDataSet";
            this.kalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chashaTableAdapter
            // 
            this.chashaTableAdapter.ClearBeforeFill = true;
            // 
            // shlangi
            // 
            this.shlangi.AutoGenerateColumns = false;
            this.shlangi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shlangi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idshlangDataGridViewTextBoxColumn,
            this.materDataGridViewTextBoxColumn1,
            this.cvetDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn});
            this.shlangi.DataSource = this.shlangBindingSource;
            this.shlangi.Location = new System.Drawing.Point(208, 257);
            this.shlangi.Name = "shlangi";
            this.shlangi.Size = new System.Drawing.Size(443, 181);
            this.shlangi.TabIndex = 2;
            // 
            // idshlangDataGridViewTextBoxColumn
            // 
            this.idshlangDataGridViewTextBoxColumn.DataPropertyName = "idshlang";
            this.idshlangDataGridViewTextBoxColumn.HeaderText = "idshlang";
            this.idshlangDataGridViewTextBoxColumn.Name = "idshlangDataGridViewTextBoxColumn";
            // 
            // materDataGridViewTextBoxColumn1
            // 
            this.materDataGridViewTextBoxColumn1.DataPropertyName = "mater";
            this.materDataGridViewTextBoxColumn1.HeaderText = "mater";
            this.materDataGridViewTextBoxColumn1.Name = "materDataGridViewTextBoxColumn1";
            // 
            // cvetDataGridViewTextBoxColumn1
            // 
            this.cvetDataGridViewTextBoxColumn1.DataPropertyName = "cvet";
            this.cvetDataGridViewTextBoxColumn1.HeaderText = "cvet";
            this.cvetDataGridViewTextBoxColumn1.Name = "cvetDataGridViewTextBoxColumn1";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // shlangBindingSource
            // 
            this.shlangBindingSource.DataMember = "shlang";
            this.shlangBindingSource.DataSource = this.kalDataSet;
            // 
            // shlangTableAdapter
            // 
            this.shlangTableAdapter.ClearBeforeFill = true;
            // 
            // poiskchasha
            // 
            this.poiskchasha.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poiskchasha.Location = new System.Drawing.Point(620, 25);
            this.poiskchasha.Name = "poiskchasha";
            this.poiskchasha.Size = new System.Drawing.Size(132, 52);
            this.poiskchasha.TabIndex = 3;
            this.poiskchasha.Text = "Найти чашу";
            this.poiskchasha.UseVisualStyleBackColor = false;
            this.poiskchasha.Click += new System.EventHandler(this.poiskchasha_Click);
            // 
            // naytichasha
            // 
            this.naytichasha.Location = new System.Drawing.Point(591, 95);
            this.naytichasha.Name = "naytichasha";
            this.naytichasha.Size = new System.Drawing.Size(179, 20);
            this.naytichasha.TabIndex = 4;
            // 
            // naytishlang
            // 
            this.naytishlang.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naytishlang.Location = new System.Drawing.Point(657, 307);
            this.naytishlang.Name = "naytishlang";
            this.naytishlang.Size = new System.Drawing.Size(131, 62);
            this.naytishlang.TabIndex = 5;
            this.naytishlang.Text = "Найти шланг";
            this.naytishlang.UseVisualStyleBackColor = false;
            this.naytishlang.Click += new System.EventHandler(this.naytishlang_Click);
            // 
            // poiskshlang
            // 
            this.poiskshlang.Location = new System.Drawing.Point(657, 384);
            this.poiskshlang.Name = "poiskshlang";
            this.poiskshlang.Size = new System.Drawing.Size(141, 20);
            this.poiskshlang.TabIndex = 6;
            // 
            // update1
            // 
            this.update1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update1.Location = new System.Drawing.Point(631, 121);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(121, 52);
            this.update1.TabIndex = 7;
            this.update1.Text = "Обновить";
            this.update1.UseVisualStyleBackColor = false;
            this.update1.Click += new System.EventHandler(this.update1_Click);
            // 
            // update2
            // 
            this.update2.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update2.Location = new System.Drawing.Point(657, 249);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(131, 52);
            this.update2.TabIndex = 8;
            this.update2.Text = "Обновить";
            this.update2.UseVisualStyleBackColor = false;
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // detali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.update1);
            this.Controls.Add(this.poiskshlang);
            this.Controls.Add(this.naytishlang);
            this.Controls.Add(this.naytichasha);
            this.Controls.Add(this.poiskchasha);
            this.Controls.Add(this.shlangi);
            this.Controls.Add(this.chashi);
            this.Controls.Add(this.red);
            this.Name = "detali";
            this.Text = "Детали";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.red.ResumeLayout(false);
            this.red.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chashaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shlangi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shlangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.DataGridView chashi;
        private kalDataSet kalDataSet;
        private System.Windows.Forms.BindingSource chashaBindingSource;
        private kalDataSetTableAdapters.chashaTableAdapter chashaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchashaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView shlangi;
        private System.Windows.Forms.BindingSource shlangBindingSource;
        private kalDataSetTableAdapters.shlangTableAdapter shlangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshlangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.TextBox dobavcvet;
        private System.Windows.Forms.TextBox dobavmaterial;
        private System.Windows.Forms.Button dobavitchasha;
        private System.Windows.Forms.Button dobavshlang;
        private System.Windows.Forms.TextBox dobavitcvet;
        private System.Windows.Forms.TextBox dobavitmaterial;
        private System.Windows.Forms.TextBox dobavcena;
        private System.Windows.Forms.Button poiskchasha;
        private System.Windows.Forms.TextBox naytichasha;
        private System.Windows.Forms.Button naytishlang;
        private System.Windows.Forms.TextBox poiskshlang;
        private System.Windows.Forms.Button update1;
        private System.Windows.Forms.Button update2;
    }
}