namespace ProjetoAtleta
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
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btnIMC = new System.Windows.Forms.Button();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(34, 41);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(91, 13);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "--- Insira o peso ---";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(34, 58);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 1;
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(34, 151);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(97, 23);
            this.btnIMC.TabIndex = 2;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(34, 94);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(97, 13);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "--- Insira a altura  ---";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(34, 111);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 4;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(54, 193);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 279);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblresultado;
    }
}

