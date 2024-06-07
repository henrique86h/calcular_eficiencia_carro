namespace calcular_eficiencia_carro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de Viagem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade Média:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eficiência do Carro:";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(129, 40);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 20);
            this.textBoxV.TabIndex = 3;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(129, 100);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 4;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(129, 168);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eficiência por KM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(51, 287);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 13);
            this.lblE.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblE;
    }
}

