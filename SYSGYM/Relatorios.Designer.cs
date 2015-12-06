namespace SYSGYM
{
    partial class Relatorios
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tds_mesnsalidades = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Todos Alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tds_mesnsalidades
            // 
            this.btn_tds_mesnsalidades.Location = new System.Drawing.Point(421, 230);
            this.btn_tds_mesnsalidades.Name = "btn_tds_mesnsalidades";
            this.btn_tds_mesnsalidades.Size = new System.Drawing.Size(256, 83);
            this.btn_tds_mesnsalidades.TabIndex = 1;
            this.btn_tds_mesnsalidades.Text = "Todas Mensalides dos Alunos";
            this.btn_tds_mesnsalidades.UseVisualStyleBackColor = true;
            this.btn_tds_mesnsalidades.Click += new System.EventHandler(this.btn_tds_mesnsalidades_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(697, 526);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_tds_mesnsalidades);
            this.Controls.Add(this.button1);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tds_mesnsalidades;
        private System.Windows.Forms.Button btn_voltar;
    }
}