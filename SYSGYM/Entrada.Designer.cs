namespace SYSGYM
{
    partial class Entrada
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
            this.l_bemVindo = new System.Windows.Forms.Label();
            this.l_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_bemVindo
            // 
            this.l_bemVindo.AutoSize = true;
            this.l_bemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bemVindo.Location = new System.Drawing.Point(48, 35);
            this.l_bemVindo.Name = "l_bemVindo";
            this.l_bemVindo.Size = new System.Drawing.Size(240, 46);
            this.l_bemVindo.TabIndex = 1;
            this.l_bemVindo.Text = "Bem - Vindo";
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(53, 245);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(0, 31);
            this.l_nome.TabIndex = 85;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.l_nome);
            this.Controls.Add(this.l_bemVindo);
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_bemVindo;
        private System.Windows.Forms.Label l_nome;
    }
}