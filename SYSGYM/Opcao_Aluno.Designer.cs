namespace SYSGYM
{
    partial class Opcao_Aluno
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
            this.btn_entrada = new System.Windows.Forms.Button();
            this.btn_saida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_entrada
            // 
            this.btn_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.Location = new System.Drawing.Point(203, 244);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(75, 23);
            this.btn_entrada.TabIndex = 0;
            this.btn_entrada.Text = "Entrada";
            this.btn_entrada.UseVisualStyleBackColor = true;
            this.btn_entrada.Click += new System.EventHandler(this.btn_entrada_Click);
            // 
            // btn_saida
            // 
            this.btn_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saida.Location = new System.Drawing.Point(487, 244);
            this.btn_saida.Name = "btn_saida";
            this.btn_saida.Size = new System.Drawing.Size(75, 23);
            this.btn_saida.TabIndex = 1;
            this.btn_saida.Text = "Saída";
            this.btn_saida.UseVisualStyleBackColor = true;
            this.btn_saida.Click += new System.EventHandler(this.btn_saida_Click);
            // 
            // Opcao_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_saida);
            this.Controls.Add(this.btn_entrada);
            this.Name = "Opcao_Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcao_Aluno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.Button btn_saida;
    }
}