namespace SYSGYM
{
    partial class Login
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
            this.l_login = new System.Windows.Forms.Label();
            this.l_senha = new System.Windows.Forms.Label();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_login.Location = new System.Drawing.Point(270, 182);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(57, 24);
            this.l_login.TabIndex = 0;
            this.l_login.Text = "Login";
            // 
            // l_senha
            // 
            this.l_senha.AutoSize = true;
            this.l_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_senha.Location = new System.Drawing.Point(270, 281);
            this.l_senha.Name = "l_senha";
            this.l_senha.Size = new System.Drawing.Size(65, 24);
            this.l_senha.TabIndex = 1;
            this.l_senha.Text = "Senha";
            // 
            // txb_login
            // 
            this.txb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_login.Location = new System.Drawing.Point(274, 224);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(217, 29);
            this.txb_login.TabIndex = 2;
            this.txb_login.TextChanged += new System.EventHandler(this.txb_login_TextChanged);
            // 
            // txb_senha
            // 
            this.txb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Location = new System.Drawing.Point(274, 329);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(217, 29);
            this.txb_senha.TabIndex = 3;
            this.txb_senha.TextChanged += new System.EventHandler(this.txb_senha_TextChanged);
            // 
            // btn_logar
            // 
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.Location = new System.Drawing.Point(331, 383);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(103, 34);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.l_senha);
            this.Controls.Add(this.l_login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label l_senha;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Button btn_logar;
    }
}