namespace Otel2
{
    partial class FormKategori
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriidlbl = new System.Windows.Forms.Label();
            this.kategoriidtxt = new System.Windows.Forms.TextBox();
            this.listelebtn = new System.Windows.Forms.Button();
            this.kategoriadtxt = new System.Windows.Forms.TextBox();
            this.kategoriadlbl = new System.Windows.Forms.Label();
            this.eklebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.arabtn = new System.Windows.Forms.Button();
            this.musteribtn = new System.Windows.Forms.Button();
            this.odabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(549, 244);
            this.dataGridView1.TabIndex = 10;
            // 
            // kategoriidlbl
            // 
            this.kategoriidlbl.AutoSize = true;
            this.kategoriidlbl.ForeColor = System.Drawing.Color.Transparent;
            this.kategoriidlbl.Location = new System.Drawing.Point(593, 19);
            this.kategoriidlbl.Name = "kategoriidlbl";
            this.kategoriidlbl.Size = new System.Drawing.Size(93, 20);
            this.kategoriidlbl.TabIndex = 1;
            this.kategoriidlbl.Text = "Kategori ID:";
            // 
            // kategoriidtxt
            // 
            this.kategoriidtxt.BackColor = System.Drawing.Color.Purple;
            this.kategoriidtxt.ForeColor = System.Drawing.Color.White;
            this.kategoriidtxt.Location = new System.Drawing.Point(702, 12);
            this.kategoriidtxt.Name = "kategoriidtxt";
            this.kategoriidtxt.Size = new System.Drawing.Size(140, 27);
            this.kategoriidtxt.TabIndex = 2;
            // 
            // listelebtn
            // 
            this.listelebtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.listelebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listelebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.ForeColor = System.Drawing.Color.White;
            this.listelebtn.Location = new System.Drawing.Point(702, 78);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(141, 29);
            this.listelebtn.TabIndex = 3;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = false;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // kategoriadtxt
            // 
            this.kategoriadtxt.BackColor = System.Drawing.Color.Purple;
            this.kategoriadtxt.ForeColor = System.Drawing.Color.White;
            this.kategoriadtxt.Location = new System.Drawing.Point(702, 45);
            this.kategoriadtxt.Name = "kategoriadtxt";
            this.kategoriadtxt.Size = new System.Drawing.Size(140, 27);
            this.kategoriadtxt.TabIndex = 5;
            // 
            // kategoriadlbl
            // 
            this.kategoriadlbl.AutoSize = true;
            this.kategoriadlbl.ForeColor = System.Drawing.Color.White;
            this.kategoriadlbl.Location = new System.Drawing.Point(584, 52);
            this.kategoriadlbl.Name = "kategoriadlbl";
            this.kategoriadlbl.Size = new System.Drawing.Size(101, 20);
            this.kategoriadlbl.TabIndex = 4;
            this.kategoriadlbl.Text = "Kategori Adı:";
            // 
            // eklebtn
            // 
            this.eklebtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.eklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eklebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eklebtn.ForeColor = System.Drawing.Color.White;
            this.eklebtn.Location = new System.Drawing.Point(702, 113);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(141, 29);
            this.eklebtn.TabIndex = 6;
            this.eklebtn.Text = "Ekle";
            this.eklebtn.UseVisualStyleBackColor = false;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.guncellebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncellebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guncellebtn.ForeColor = System.Drawing.Color.White;
            this.guncellebtn.Location = new System.Drawing.Point(702, 183);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(141, 29);
            this.guncellebtn.TabIndex = 7;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.silbtn.ForeColor = System.Drawing.Color.White;
            this.silbtn.Location = new System.Drawing.Point(702, 148);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(141, 29);
            this.silbtn.TabIndex = 8;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // arabtn
            // 
            this.arabtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.arabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arabtn.ForeColor = System.Drawing.Color.White;
            this.arabtn.Location = new System.Drawing.Point(702, 218);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(141, 29);
            this.arabtn.TabIndex = 9;
            this.arabtn.Text = "Ara";
            this.arabtn.UseVisualStyleBackColor = false;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // musteribtn
            // 
            this.musteribtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.musteribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteribtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteribtn.ForeColor = System.Drawing.Color.White;
            this.musteribtn.Location = new System.Drawing.Point(583, 148);
            this.musteribtn.Name = "musteribtn";
            this.musteribtn.Size = new System.Drawing.Size(102, 29);
            this.musteribtn.TabIndex = 11;
            this.musteribtn.Text = "Müşteriler";
            this.musteribtn.UseVisualStyleBackColor = false;
            this.musteribtn.Click += new System.EventHandler(this.musteribtn_Click);
            // 
            // odabtn
            // 
            this.odabtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.odabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.odabtn.ForeColor = System.Drawing.Color.White;
            this.odabtn.Location = new System.Drawing.Point(583, 113);
            this.odabtn.Name = "odabtn";
            this.odabtn.Size = new System.Drawing.Size(103, 29);
            this.odabtn.TabIndex = 12;
            this.odabtn.Text = "Odalar";
            this.odabtn.UseVisualStyleBackColor = false;
            this.odabtn.Click += new System.EventHandler(this.odabtn_Click);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(856, 268);
            this.Controls.Add(this.odabtn);
            this.Controls.Add(this.musteribtn);
            this.Controls.Add(this.arabtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.kategoriadtxt);
            this.Controls.Add(this.kategoriadlbl);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kategoriidtxt);
            this.Controls.Add(this.kategoriidlbl);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label kategoriidlbl;
        private TextBox kategoriidtxt;
        private Button listelebtn;
        private TextBox kategoriadtxt;
        private Label kategoriadlbl;
        private Button eklebtn;
        private Button guncellebtn;
        private Button silbtn;
        private Button arabtn;
        private Button musteribtn;
        private Button odabtn;
    }
}