namespace UC11_PrimeiroProjetoGrafico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxSOBRENOME = new System.Windows.Forms.TextBox();
            this.labelNOME = new System.Windows.Forms.Label();
            this.labelSOBRENOME = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.textBox1n1 = new System.Windows.Forms.TextBox();
            this.textBoxn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.labelnumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestBoxNOME
            // 
            this.TestBoxNOME.Location = new System.Drawing.Point(150, 41);
            this.TestBoxNOME.Name = "TestBoxNOME";
            this.TestBoxNOME.Size = new System.Drawing.Size(123, 20);
            this.TestBoxNOME.TabIndex = 0;
            this.TestBoxNOME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSOBRENOME
            // 
            this.textBoxSOBRENOME.Location = new System.Drawing.Point(150, 80);
            this.textBoxSOBRENOME.Name = "textBoxSOBRENOME";
            this.textBoxSOBRENOME.Size = new System.Drawing.Size(123, 20);
            this.textBoxSOBRENOME.TabIndex = 1;
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(32, 44);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(35, 13);
            this.labelNOME.TabIndex = 2;
            this.labelNOME.Text = "Nome";
            this.labelNOME.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSOBRENOME
            // 
            this.labelSOBRENOME.AutoSize = true;
            this.labelSOBRENOME.Location = new System.Drawing.Point(12, 80);
            this.labelSOBRENOME.Name = "labelSOBRENOME";
            this.labelSOBRENOME.Size = new System.Drawing.Size(61, 13);
            this.labelSOBRENOME.TabIndex = 3;
            this.labelSOBRENOME.Text = "Sobrenome";
            this.labelSOBRENOME.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(175, 137);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 4;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(522, 158);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcular.TabIndex = 9;
            this.buttoncalcular.Text = "calcular";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // textBox1n1
            // 
            this.textBox1n1.Location = new System.Drawing.Point(613, 54);
            this.textBox1n1.Name = "textBox1n1";
            this.textBox1n1.Size = new System.Drawing.Size(100, 20);
            this.textBox1n1.TabIndex = 11;
            // 
            // textBoxn2
            // 
            this.textBoxn2.Location = new System.Drawing.Point(613, 106);
            this.textBoxn2.Name = "textBoxn2";
            this.textBoxn2.Size = new System.Drawing.Size(100, 20);
            this.textBoxn2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(451, 60);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(64, 13);
            this.labelnumero.TabIndex = 15;
            this.labelnumero.Text = "NUMERO 1";
            // 
            // labelnumero2
            // 
            this.labelnumero2.AutoSize = true;
            this.labelnumero2.Location = new System.Drawing.Point(454, 114);
            this.labelnumero2.Name = "labelnumero2";
            this.labelnumero2.Size = new System.Drawing.Size(64, 13);
            this.labelnumero2.TabIndex = 16;
            this.labelnumero2.Text = "NUMERO 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 490);
            this.Controls.Add(this.labelnumero2);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxn2);
            this.Controls.Add(this.textBox1n1);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.labelSOBRENOME);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.textBoxSOBRENOME);
            this.Controls.Add(this.TestBoxNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TestBoxNOME;
        private System.Windows.Forms.TextBox textBoxSOBRENOME;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label labelSOBRENOME;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.TextBox textBox1n1;
        private System.Windows.Forms.TextBox textBoxn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label labelnumero2;
    }
}

