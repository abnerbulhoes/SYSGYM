﻿namespace SYSGYM
{
    partial class Aluno_Cadastrar
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
            this.l_nome = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.l_cpf = new System.Windows.Forms.Label();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tbx_matricula = new System.Windows.Forms.TextBox();
            this.l_matricula = new System.Windows.Forms.Label();
            this.l_endereco = new System.Windows.Forms.Label();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.txb_telefone = new System.Windows.Forms.TextBox();
            this.l_telefone = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.l_dataNascimento = new System.Windows.Forms.Label();
            this.ckb_masculino = new System.Windows.Forms.CheckBox();
            this.ckb_feminino = new System.Windows.Forms.CheckBox();
            this.l_sexo = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.dataCadastro = new System.Windows.Forms.DateTimePicker();
            this.l_dataCadastro = new System.Windows.Forms.Label();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(45, 171);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(45, 17);
            this.l_nome.TabIndex = 0;
            this.l_nome.Text = "Nome";
            // 
            // txb_nome
            // 
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(48, 198);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(457, 23);
            this.txb_nome.TabIndex = 1;
            // 
            // l_cpf
            // 
            this.l_cpf.AutoSize = true;
            this.l_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cpf.Location = new System.Drawing.Point(45, 264);
            this.l_cpf.Name = "l_cpf";
            this.l_cpf.Size = new System.Drawing.Size(34, 17);
            this.l_cpf.TabIndex = 2;
            this.l_cpf.Text = "CPF";
            // 
            // txb_cpf
            // 
            this.txb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cpf.Location = new System.Drawing.Point(48, 293);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(179, 23);
            this.txb_cpf.TabIndex = 3;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(697, 526);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tbx_matricula
            // 
            this.tbx_matricula.Enabled = false;
            this.tbx_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_matricula.Location = new System.Drawing.Point(220, 87);
            this.tbx_matricula.Name = "tbx_matricula";
            this.tbx_matricula.Size = new System.Drawing.Size(100, 23);
            this.tbx_matricula.TabIndex = 5;
            this.tbx_matricula.TextChanged += new System.EventHandler(this.tbx_matricula_TextChanged);
            // 
            // l_matricula
            // 
            this.l_matricula.AutoSize = true;
            this.l_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_matricula.Location = new System.Drawing.Point(217, 53);
            this.l_matricula.Name = "l_matricula";
            this.l_matricula.Size = new System.Drawing.Size(65, 17);
            this.l_matricula.TabIndex = 6;
            this.l_matricula.Text = "Matrícula";
            // 
            // l_endereco
            // 
            this.l_endereco.AutoSize = true;
            this.l_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_endereco.Location = new System.Drawing.Point(45, 343);
            this.l_endereco.Name = "l_endereco";
            this.l_endereco.Size = new System.Drawing.Size(69, 17);
            this.l_endereco.TabIndex = 7;
            this.l_endereco.Text = "Endereço";
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_endereco.Location = new System.Drawing.Point(48, 373);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(486, 23);
            this.tbx_endereco.TabIndex = 8;
            // 
            // txb_telefone
            // 
            this.txb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefone.Location = new System.Drawing.Point(48, 465);
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.Size = new System.Drawing.Size(159, 23);
            this.txb_telefone.TabIndex = 9;
            // 
            // l_telefone
            // 
            this.l_telefone.AutoSize = true;
            this.l_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_telefone.Location = new System.Drawing.Point(45, 436);
            this.l_telefone.Name = "l_telefone";
            this.l_telefone.Size = new System.Drawing.Size(64, 17);
            this.l_telefone.TabIndex = 10;
            this.l_telefone.Text = "Telefone";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimento.Location = new System.Drawing.Point(421, 293);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(294, 23);
            this.dataNascimento.TabIndex = 11;
            // 
            // l_dataNascimento
            // 
            this.l_dataNascimento.AutoSize = true;
            this.l_dataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dataNascimento.Location = new System.Drawing.Point(418, 264);
            this.l_dataNascimento.Name = "l_dataNascimento";
            this.l_dataNascimento.Size = new System.Drawing.Size(116, 17);
            this.l_dataNascimento.TabIndex = 12;
            this.l_dataNascimento.Text = "Data Nascimento";
            // 
            // ckb_masculino
            // 
            this.ckb_masculino.AutoSize = true;
            this.ckb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_masculino.Location = new System.Drawing.Point(534, 200);
            this.ckb_masculino.Name = "ckb_masculino";
            this.ckb_masculino.Size = new System.Drawing.Size(90, 21);
            this.ckb_masculino.TabIndex = 13;
            this.ckb_masculino.Text = "Masculino";
            this.ckb_masculino.UseVisualStyleBackColor = true;
            this.ckb_masculino.CheckedChanged += new System.EventHandler(this.ckb_masculino_CheckedChanged);
            // 
            // ckb_feminino
            // 
            this.ckb_feminino.AutoSize = true;
            this.ckb_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_feminino.Location = new System.Drawing.Point(631, 200);
            this.ckb_feminino.Name = "ckb_feminino";
            this.ckb_feminino.Size = new System.Drawing.Size(84, 21);
            this.ckb_feminino.TabIndex = 14;
            this.ckb_feminino.Text = "Feminino";
            this.ckb_feminino.UseVisualStyleBackColor = true;
            this.ckb_feminino.CheckedChanged += new System.EventHandler(this.ckb_feminino_CheckedChanged);
            // 
            // l_sexo
            // 
            this.l_sexo.AutoSize = true;
            this.l_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_sexo.Location = new System.Drawing.Point(597, 171);
            this.l_sexo.Name = "l_sexo";
            this.l_sexo.Size = new System.Drawing.Size(39, 17);
            this.l_sexo.TabIndex = 15;
            this.l_sexo.Text = "Sexo";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.Location = new System.Drawing.Point(333, 436);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(42, 17);
            this.l_email.TabIndex = 16;
            this.l_email.Text = "Email";
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(336, 465);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(363, 23);
            this.txb_email.TabIndex = 17;
            // 
            // dataCadastro
            // 
            this.dataCadastro.Enabled = false;
            this.dataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCadastro.Location = new System.Drawing.Point(427, 87);
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.Size = new System.Drawing.Size(294, 23);
            this.dataCadastro.TabIndex = 18;
            this.dataCadastro.Value = new System.DateTime(2015, 11, 17, 17, 29, 25, 0);
            // 
            // l_dataCadastro
            // 
            this.l_dataCadastro.AutoSize = true;
            this.l_dataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dataCadastro.Location = new System.Drawing.Point(418, 53);
            this.l_dataCadastro.Name = "l_dataCadastro";
            this.l_dataCadastro.Size = new System.Drawing.Size(99, 17);
            this.l_dataCadastro.TabIndex = 19;
            this.l_dataCadastro.Text = "Data Cadastro";
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto.Location = new System.Drawing.Point(48, 28);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(88, 101);
            this.pic_foto.TabIndex = 20;
            this.pic_foto.TabStop = false;
            this.pic_foto.Click += new System.EventHandler(this.pic_foto_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(318, 526);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 23);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "Salvar!";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // Aluno_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.l_dataCadastro);
            this.Controls.Add(this.dataCadastro);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_sexo);
            this.Controls.Add(this.ckb_feminino);
            this.Controls.Add(this.ckb_masculino);
            this.Controls.Add(this.l_dataNascimento);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.l_telefone);
            this.Controls.Add(this.txb_telefone);
            this.Controls.Add(this.tbx_endereco);
            this.Controls.Add(this.l_endereco);
            this.Controls.Add(this.l_matricula);
            this.Controls.Add(this.tbx_matricula);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.l_cpf);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.l_nome);
            this.Name = "Aluno_Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label l_cpf;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox tbx_matricula;
        private System.Windows.Forms.Label l_matricula;
        private System.Windows.Forms.Label l_endereco;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.TextBox txb_telefone;
        private System.Windows.Forms.Label l_telefone;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label l_dataNascimento;
        private System.Windows.Forms.CheckBox ckb_masculino;
        private System.Windows.Forms.CheckBox ckb_feminino;
        private System.Windows.Forms.Label l_sexo;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.DateTimePicker dataCadastro;
        private System.Windows.Forms.Label l_dataCadastro;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Button btn_salvar;
    }
}