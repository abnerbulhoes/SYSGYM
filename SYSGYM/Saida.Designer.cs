namespace SYSGYM
{
    partial class Saida
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
            this.l_volteSempre = new System.Windows.Forms.Label();
            this.l_nome = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_volteSempre
            // 
            this.l_volteSempre.AutoSize = true;
            this.l_volteSempre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_volteSempre.Location = new System.Drawing.Point(43, 42);
            this.l_volteSempre.Name = "l_volteSempre";
            this.l_volteSempre.Size = new System.Drawing.Size(262, 46);
            this.l_volteSempre.TabIndex = 0;
            this.l_volteSempre.Text = "Volte Sempre";
            // 
            // l_nome
            // 
            this.l_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(45, 260);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(0, 31);
            this.l_nome.TabIndex = 99;
            this.l_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(669, 495);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(103, 54);
            this.btn_inicio.TabIndex = 100;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.l_nome);
            this.Controls.Add(this.l_volteSempre);
            this.Name = "Saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_volteSempre;
        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.Button btn_inicio;
    }
}