namespace BasicMathOperations
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Taschenrechner = new System.Windows.Forms.Label();
            this.lbl_Zahl1 = new System.Windows.Forms.Label();
            this.lbl_Zahl2 = new System.Windows.Forms.Label();
            this.lbl_Ergebnis = new System.Windows.Forms.Label();
            this.txt_Zahl1 = new System.Windows.Forms.TextBox();
            this.txt_Zahl2 = new System.Windows.Forms.TextBox();
            this.txt_Ergebnis = new System.Windows.Forms.TextBox();
            this.btn_Summe = new System.Windows.Forms.Button();
            this.btn_Differenz = new System.Windows.Forms.Button();
            this.btn_Produkt = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exponentieren = new System.Windows.Forms.Button();
            this.btn_Wurzel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Taschenrechner
            // 
            this.lbl_Taschenrechner.AutoSize = true;
            this.lbl_Taschenrechner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Taschenrechner.Location = new System.Drawing.Point(108, 9);
            this.lbl_Taschenrechner.Name = "lbl_Taschenrechner";
            this.lbl_Taschenrechner.Size = new System.Drawing.Size(211, 31);
            this.lbl_Taschenrechner.TabIndex = 0;
            this.lbl_Taschenrechner.Text = "Taschenrechner";
            this.lbl_Taschenrechner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Zahl1
            // 
            this.lbl_Zahl1.AutoSize = true;
            this.lbl_Zahl1.Location = new System.Drawing.Point(12, 59);
            this.lbl_Zahl1.Name = "lbl_Zahl1";
            this.lbl_Zahl1.Size = new System.Drawing.Size(37, 13);
            this.lbl_Zahl1.TabIndex = 1;
            this.lbl_Zahl1.Text = "Zahl1:";
            // 
            // lbl_Zahl2
            // 
            this.lbl_Zahl2.AutoSize = true;
            this.lbl_Zahl2.Location = new System.Drawing.Point(12, 109);
            this.lbl_Zahl2.Name = "lbl_Zahl2";
            this.lbl_Zahl2.Size = new System.Drawing.Size(37, 13);
            this.lbl_Zahl2.TabIndex = 2;
            this.lbl_Zahl2.Text = "Zahl2:";
            // 
            // lbl_Ergebnis
            // 
            this.lbl_Ergebnis.AutoSize = true;
            this.lbl_Ergebnis.Location = new System.Drawing.Point(12, 159);
            this.lbl_Ergebnis.Name = "lbl_Ergebnis";
            this.lbl_Ergebnis.Size = new System.Drawing.Size(51, 13);
            this.lbl_Ergebnis.TabIndex = 3;
            this.lbl_Ergebnis.Text = "Ergebnis:";
            // 
            // txt_Zahl1
            // 
            this.txt_Zahl1.Location = new System.Drawing.Point(100, 56);
            this.txt_Zahl1.Name = "txt_Zahl1";
            this.txt_Zahl1.Size = new System.Drawing.Size(100, 20);
            this.txt_Zahl1.TabIndex = 4;
            this.txt_Zahl1.Text = "0";
            this.txt_Zahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Zahl2
            // 
            this.txt_Zahl2.Location = new System.Drawing.Point(100, 106);
            this.txt_Zahl2.Name = "txt_Zahl2";
            this.txt_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.txt_Zahl2.TabIndex = 5;
            this.txt_Zahl2.Text = "0";
            this.txt_Zahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Ergebnis
            // 
            this.txt_Ergebnis.Location = new System.Drawing.Point(100, 156);
            this.txt_Ergebnis.Name = "txt_Ergebnis";
            this.txt_Ergebnis.ReadOnly = true;
            this.txt_Ergebnis.Size = new System.Drawing.Size(100, 20);
            this.txt_Ergebnis.TabIndex = 6;
            this.txt_Ergebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Summe
            // 
            this.btn_Summe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Summe.Location = new System.Drawing.Point(256, 56);
            this.btn_Summe.Name = "btn_Summe";
            this.btn_Summe.Size = new System.Drawing.Size(50, 50);
            this.btn_Summe.TabIndex = 7;
            this.btn_Summe.Text = "+";
            this.btn_Summe.UseVisualStyleBackColor = true;
            this.btn_Summe.Click += new System.EventHandler(this.Summe_Click);
            // 
            // btn_Differenz
            // 
            this.btn_Differenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Differenz.Location = new System.Drawing.Point(256, 126);
            this.btn_Differenz.Name = "btn_Differenz";
            this.btn_Differenz.Size = new System.Drawing.Size(50, 50);
            this.btn_Differenz.TabIndex = 8;
            this.btn_Differenz.Text = "-";
            this.btn_Differenz.UseVisualStyleBackColor = true;
            this.btn_Differenz.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Produkt
            // 
            this.btn_Produkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produkt.Location = new System.Drawing.Point(321, 56);
            this.btn_Produkt.Name = "btn_Produkt";
            this.btn_Produkt.Size = new System.Drawing.Size(50, 50);
            this.btn_Produkt.TabIndex = 9;
            this.btn_Produkt.Text = "*";
            this.btn_Produkt.UseVisualStyleBackColor = true;
            this.btn_Produkt.Click += new System.EventHandler(this.btn_Produkt_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Division.Location = new System.Drawing.Point(321, 126);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(50, 50);
            this.btn_Division.TabIndex = 10;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(193, 182);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(67, 35);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exponentieren
            // 
            this.btn_Exponentieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Exponentieren.Location = new System.Drawing.Point(387, 126);
            this.btn_Exponentieren.Name = "btn_Exponentieren";
            this.btn_Exponentieren.Size = new System.Drawing.Size(50, 50);
            this.btn_Exponentieren.TabIndex = 13;
            this.btn_Exponentieren.Text = "a^b";
            this.btn_Exponentieren.UseVisualStyleBackColor = true;
            this.btn_Exponentieren.Click += new System.EventHandler(this.btn_Exponentieren_Click);
            // 
            // btn_Wurzel
            // 
            this.btn_Wurzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Wurzel.Location = new System.Drawing.Point(387, 56);
            this.btn_Wurzel.Name = "btn_Wurzel";
            this.btn_Wurzel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Wurzel.Size = new System.Drawing.Size(50, 50);
            this.btn_Wurzel.TabIndex = 12;
            this.btn_Wurzel.Text = "a√b";
            this.btn_Wurzel.UseVisualStyleBackColor = true;
            this.btn_Wurzel.Click += new System.EventHandler(this.btn_Wurzel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 223);
            this.Controls.Add(this.btn_Exponentieren);
            this.Controls.Add(this.btn_Wurzel);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Produkt);
            this.Controls.Add(this.btn_Differenz);
            this.Controls.Add(this.btn_Summe);
            this.Controls.Add(this.txt_Ergebnis);
            this.Controls.Add(this.txt_Zahl2);
            this.Controls.Add(this.txt_Zahl1);
            this.Controls.Add(this.lbl_Ergebnis);
            this.Controls.Add(this.lbl_Zahl2);
            this.Controls.Add(this.lbl_Zahl1);
            this.Controls.Add(this.lbl_Taschenrechner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Taschenrechner;
        private System.Windows.Forms.Label lbl_Zahl1;
        private System.Windows.Forms.Label lbl_Zahl2;
        private System.Windows.Forms.Label lbl_Ergebnis;
        private System.Windows.Forms.TextBox txt_Zahl1;
        private System.Windows.Forms.TextBox txt_Zahl2;
        private System.Windows.Forms.TextBox txt_Ergebnis;
        private System.Windows.Forms.Button btn_Summe;
        private System.Windows.Forms.Button btn_Differenz;
        private System.Windows.Forms.Button btn_Produkt;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exponentieren;
        private System.Windows.Forms.Button btn_Wurzel;
    }
}

