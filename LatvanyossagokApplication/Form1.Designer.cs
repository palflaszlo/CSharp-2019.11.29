namespace LatvanyossagokApplication
{
    partial class Form1
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
            this.varosNev = new System.Windows.Forms.Label();
            this.lakossagSzam = new System.Windows.Forms.Label();
            this.inputVarosNev = new System.Windows.Forms.TextBox();
            this.inputLakossagSzam = new System.Windows.Forms.NumericUpDown();
            this.varosKuldes = new System.Windows.Forms.Button();
            this.inputLatvanyossagNeve = new System.Windows.Forms.TextBox();
            this.inputLatvanyossagAra = new System.Windows.Forms.NumericUpDown();
            this.latvanyossagKuldes = new System.Windows.Forms.Button();
            this.latvanyossagNev = new System.Windows.Forms.Label();
            this.latvanyossagLeiras = new System.Windows.Forms.Label();
            this.latvanyossagAr = new System.Windows.Forms.Label();
            this.melyikVaros = new System.Windows.Forms.Label();
            this.inputLatvagyossagLeirasa = new System.Windows.Forms.TextBox();
            this.listBoxfelvettVarosok = new System.Windows.Forms.ListBox();
            this.varosTorles = new System.Windows.Forms.Button();
            this.kivalaszthatoVarosTorlese = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.varosLatvanyossaga = new System.Windows.Forms.ListBox();
            this.comboBoxValaszthatoVarosok = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputLakossagSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLatvanyossagAra)).BeginInit();
            this.SuspendLayout();
            // 
            // varosNev
            // 
            this.varosNev.AutoSize = true;
            this.varosNev.Location = new System.Drawing.Point(12, 9);
            this.varosNev.Name = "varosNev";
            this.varosNev.Size = new System.Drawing.Size(61, 13);
            this.varosNev.TabIndex = 0;
            this.varosNev.Text = "Város neve";
            // 
            // lakossagSzam
            // 
            this.lakossagSzam.AutoSize = true;
            this.lakossagSzam.Location = new System.Drawing.Point(12, 40);
            this.lakossagSzam.Name = "lakossagSzam";
            this.lakossagSzam.Size = new System.Drawing.Size(86, 13);
            this.lakossagSzam.TabIndex = 1;
            this.lakossagSzam.Text = "Lakosság száma";
            // 
            // inputVarosNev
            // 
            this.inputVarosNev.Location = new System.Drawing.Point(116, 12);
            this.inputVarosNev.Name = "inputVarosNev";
            this.inputVarosNev.Size = new System.Drawing.Size(120, 20);
            this.inputVarosNev.TabIndex = 2;
            // 
            // inputLakossagSzam
            // 
            this.inputLakossagSzam.Location = new System.Drawing.Point(116, 38);
            this.inputLakossagSzam.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.inputLakossagSzam.Name = "inputLakossagSzam";
            this.inputLakossagSzam.Size = new System.Drawing.Size(120, 20);
            this.inputLakossagSzam.TabIndex = 3;
            // 
            // varosKuldes
            // 
            this.varosKuldes.Location = new System.Drawing.Point(15, 59);
            this.varosKuldes.Name = "varosKuldes";
            this.varosKuldes.Size = new System.Drawing.Size(86, 23);
            this.varosKuldes.TabIndex = 4;
            this.varosKuldes.Text = "Küldés";
            this.varosKuldes.UseVisualStyleBackColor = true;
            this.varosKuldes.Click += new System.EventHandler(this.varosKuldes_Click);
            // 
            // inputLatvanyossagNeve
            // 
            this.inputLatvanyossagNeve.Location = new System.Drawing.Point(422, 9);
            this.inputLatvanyossagNeve.Name = "inputLatvanyossagNeve";
            this.inputLatvanyossagNeve.Size = new System.Drawing.Size(120, 20);
            this.inputLatvanyossagNeve.TabIndex = 5;
            // 
            // inputLatvanyossagAra
            // 
            this.inputLatvanyossagAra.Location = new System.Drawing.Point(422, 62);
            this.inputLatvanyossagAra.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.inputLatvanyossagAra.Name = "inputLatvanyossagAra";
            this.inputLatvanyossagAra.Size = new System.Drawing.Size(120, 20);
            this.inputLatvanyossagAra.TabIndex = 6;
            // 
            // latvanyossagKuldes
            // 
            this.latvanyossagKuldes.Location = new System.Drawing.Point(296, 126);
            this.latvanyossagKuldes.Name = "latvanyossagKuldes";
            this.latvanyossagKuldes.Size = new System.Drawing.Size(97, 23);
            this.latvanyossagKuldes.TabIndex = 7;
            this.latvanyossagKuldes.Text = "Küldés";
            this.latvanyossagKuldes.UseVisualStyleBackColor = true;
            this.latvanyossagKuldes.Click += new System.EventHandler(this.latvanyossagKuldes_Click);
            // 
            // latvanyossagNev
            // 
            this.latvanyossagNev.AutoSize = true;
            this.latvanyossagNev.Location = new System.Drawing.Point(293, 9);
            this.latvanyossagNev.Name = "latvanyossagNev";
            this.latvanyossagNev.Size = new System.Drawing.Size(100, 13);
            this.latvanyossagNev.TabIndex = 9;
            this.latvanyossagNev.Text = "Látványosság neve";
            // 
            // latvanyossagLeiras
            // 
            this.latvanyossagLeiras.AutoSize = true;
            this.latvanyossagLeiras.Location = new System.Drawing.Point(293, 38);
            this.latvanyossagLeiras.Name = "latvanyossagLeiras";
            this.latvanyossagLeiras.Size = new System.Drawing.Size(43, 13);
            this.latvanyossagLeiras.TabIndex = 10;
            this.latvanyossagLeiras.Text = "Leírása";
            // 
            // latvanyossagAr
            // 
            this.latvanyossagAr.AutoSize = true;
            this.latvanyossagAr.Location = new System.Drawing.Point(293, 64);
            this.latvanyossagAr.Name = "latvanyossagAr";
            this.latvanyossagAr.Size = new System.Drawing.Size(23, 13);
            this.latvanyossagAr.TabIndex = 11;
            this.latvanyossagAr.Text = "Ára";
            // 
            // melyikVaros
            // 
            this.melyikVaros.AutoSize = true;
            this.melyikVaros.Location = new System.Drawing.Point(293, 86);
            this.melyikVaros.Name = "melyikVaros";
            this.melyikVaros.Size = new System.Drawing.Size(34, 13);
            this.melyikVaros.TabIndex = 12;
            this.melyikVaros.Text = "Város";
            // 
            // inputLatvagyossagLeirasa
            // 
            this.inputLatvagyossagLeirasa.Location = new System.Drawing.Point(422, 37);
            this.inputLatvagyossagLeirasa.Name = "inputLatvagyossagLeirasa";
            this.inputLatvagyossagLeirasa.Size = new System.Drawing.Size(120, 20);
            this.inputLatvagyossagLeirasa.TabIndex = 13;
            // 
            // listBoxfelvettVarosok
            // 
            this.listBoxfelvettVarosok.FormattingEnabled = true;
            this.listBoxfelvettVarosok.Location = new System.Drawing.Point(15, 88);
            this.listBoxfelvettVarosok.Name = "listBoxfelvettVarosok";
            this.listBoxfelvettVarosok.Size = new System.Drawing.Size(221, 95);
            this.listBoxfelvettVarosok.TabIndex = 14;
            // 
            // varosTorles
            // 
            this.varosTorles.Location = new System.Drawing.Point(15, 189);
            this.varosTorles.Name = "varosTorles";
            this.varosTorles.Size = new System.Drawing.Size(86, 23);
            this.varosTorles.TabIndex = 15;
            this.varosTorles.Text = "Törlés";
            this.varosTorles.UseVisualStyleBackColor = true;
            this.varosTorles.Click += new System.EventHandler(this.varosTorles_Click);
            // 
            // kivalaszthatoVarosTorlese
            // 
            this.kivalaszthatoVarosTorlese.Location = new System.Drawing.Point(296, 160);
            this.kivalaszthatoVarosTorlese.Name = "kivalaszthatoVarosTorlese";
            this.kivalaszthatoVarosTorlese.Size = new System.Drawing.Size(97, 23);
            this.kivalaszthatoVarosTorlese.TabIndex = 16;
            this.kivalaszthatoVarosTorlese.Text = "Törlés";
            this.kivalaszthatoVarosTorlese.UseVisualStyleBackColor = true;
            this.kivalaszthatoVarosTorlese.Click += new System.EventHandler(this.kivalaszthatoVarosTorlese_Click);
            // 
            // modositas
            // 
            this.modositas.Location = new System.Drawing.Point(254, 382);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(82, 23);
            this.modositas.TabIndex = 17;
            this.modositas.Text = "Módosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // varosLatvanyossaga
            // 
            this.varosLatvanyossaga.FormattingEnabled = true;
            this.varosLatvanyossaga.Location = new System.Drawing.Point(13, 219);
            this.varosLatvanyossaga.Name = "varosLatvanyossaga";
            this.varosLatvanyossaga.Size = new System.Drawing.Size(223, 186);
            this.varosLatvanyossaga.TabIndex = 18;
            // 
            // comboBoxValaszthatoVarosok
            // 
            this.comboBoxValaszthatoVarosok.FormattingEnabled = true;
            this.comboBoxValaszthatoVarosok.Location = new System.Drawing.Point(421, 88);
            this.comboBoxValaszthatoVarosok.Name = "comboBoxValaszthatoVarosok";
            this.comboBoxValaszthatoVarosok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxValaszthatoVarosok.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 456);
            this.Controls.Add(this.comboBoxValaszthatoVarosok);
            this.Controls.Add(this.varosLatvanyossaga);
            this.Controls.Add(this.modositas);
            this.Controls.Add(this.kivalaszthatoVarosTorlese);
            this.Controls.Add(this.varosTorles);
            this.Controls.Add(this.listBoxfelvettVarosok);
            this.Controls.Add(this.inputLatvagyossagLeirasa);
            this.Controls.Add(this.melyikVaros);
            this.Controls.Add(this.latvanyossagAr);
            this.Controls.Add(this.latvanyossagLeiras);
            this.Controls.Add(this.latvanyossagNev);
            this.Controls.Add(this.latvanyossagKuldes);
            this.Controls.Add(this.inputLatvanyossagAra);
            this.Controls.Add(this.inputLatvanyossagNeve);
            this.Controls.Add(this.varosKuldes);
            this.Controls.Add(this.inputLakossagSzam);
            this.Controls.Add(this.inputVarosNev);
            this.Controls.Add(this.lakossagSzam);
            this.Controls.Add(this.varosNev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputLakossagSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLatvanyossagAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label varosNev;
        private System.Windows.Forms.Label lakossagSzam;
        private System.Windows.Forms.TextBox inputVarosNev;
        private System.Windows.Forms.NumericUpDown inputLakossagSzam;
        private System.Windows.Forms.Button varosKuldes;
        private System.Windows.Forms.TextBox inputLatvanyossagNeve;
        private System.Windows.Forms.NumericUpDown inputLatvanyossagAra;
        private System.Windows.Forms.Button latvanyossagKuldes;
        private System.Windows.Forms.Label latvanyossagNev;
        private System.Windows.Forms.Label latvanyossagLeiras;
        private System.Windows.Forms.Label latvanyossagAr;
        private System.Windows.Forms.Label melyikVaros;
        private System.Windows.Forms.TextBox inputLatvagyossagLeirasa;
        private System.Windows.Forms.ListBox listBoxfelvettVarosok;
        private System.Windows.Forms.Button varosTorles;
        private System.Windows.Forms.Button kivalaszthatoVarosTorlese;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.ListBox varosLatvanyossaga;
        private System.Windows.Forms.ComboBox comboBoxValaszthatoVarosok;
    }
}

