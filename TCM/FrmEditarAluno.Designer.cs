namespace TCC
{
	partial class FrmEditarAluno
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
			if(disposing && (components != null))
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCEP = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.grbCurso = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.rdbIntermediario = new System.Windows.Forms.RadioButton();
			this.rdbBasico = new System.Windows.Forms.RadioButton();
			this.rdbE = new System.Windows.Forms.RadioButton();
			this.grbPeriodo = new System.Windows.Forms.GroupBox();
			this.rdbT = new System.Windows.Forms.RadioButton();
			this.rdbM = new System.Windows.Forms.RadioButton();
			this.rdbN = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.grbCurso.SuspendLayout();
			this.grbPeriodo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtRua);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtCEP);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtNum);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtTelefone);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtCidade);
			this.groupBox2.Controls.Add(this.txtEstado);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(107, 233);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(401, 151);
			this.groupBox2.TabIndex = 46;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Endereço";
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(59, 19);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(285, 20);
			this.txtRua.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Rua";
			// 
			// txtCEP
			// 
			this.txtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtCEP.Location = new System.Drawing.Point(152, 45);
			this.txtCEP.Mask = "00000-000";
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(62, 20);
			this.txtCEP.TabIndex = 6;
			this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "N°";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(59, 45);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(53, 20);
			this.txtNum.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(118, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "CEP";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Telefone";
			// 
			// txtTelefone
			// 
			this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtTelefone.Location = new System.Drawing.Point(59, 122);
			this.txtTelefone.Mask = "(00) 0000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(84, 20);
			this.txtTelefone.TabIndex = 9;
			this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Cidade";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(59, 70);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(211, 20);
			this.txtCidade.TabIndex = 7;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(59, 96);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(100, 20);
			this.txtEstado.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Estado";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.txtSenha);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Location = new System.Drawing.Point(107, 97);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(401, 131);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Pessoais";
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Location = new System.Drawing.Point(56, 47);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(121, 21);
			this.cmbSexo.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(56, 100);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(288, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(15, 103);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 40;
			this.label13.Text = "Senha";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(56, 21);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(288, 20);
			this.txtNome.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "E-Mail";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(56, 74);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(288, 20);
			this.txtEmail.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(22, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 13);
			this.label12.TabIndex = 38;
			this.label12.Text = "Sexo";
			// 
			// grbCurso
			// 
			this.grbCurso.Controls.Add(this.radioButton1);
			this.grbCurso.Controls.Add(this.rdbIntermediario);
			this.grbCurso.Controls.Add(this.rdbBasico);
			this.grbCurso.Controls.Add(this.rdbE);
			this.grbCurso.Location = new System.Drawing.Point(514, 97);
			this.grbCurso.Name = "grbCurso";
			this.grbCurso.Size = new System.Drawing.Size(158, 131);
			this.grbCurso.TabIndex = 43;
			this.grbCurso.TabStop = false;
			this.grbCurso.Text = "Curso";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 91);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(68, 17);
			this.radioButton1.TabIndex = 30;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = "4";
			this.radioButton1.Text = "Expresso";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// rdbIntermediario
			// 
			this.rdbIntermediario.AutoSize = true;
			this.rdbIntermediario.Location = new System.Drawing.Point(7, 45);
			this.rdbIntermediario.Name = "rdbIntermediario";
			this.rdbIntermediario.Size = new System.Drawing.Size(85, 17);
			this.rdbIntermediario.TabIndex = 28;
			this.rdbIntermediario.TabStop = true;
			this.rdbIntermediario.Tag = "2";
			this.rdbIntermediario.Text = "Intermediário";
			this.rdbIntermediario.UseVisualStyleBackColor = true;
			// 
			// rdbBasico
			// 
			this.rdbBasico.AutoSize = true;
			this.rdbBasico.Location = new System.Drawing.Point(7, 22);
			this.rdbBasico.Name = "rdbBasico";
			this.rdbBasico.Size = new System.Drawing.Size(57, 17);
			this.rdbBasico.TabIndex = 27;
			this.rdbBasico.TabStop = true;
			this.rdbBasico.Tag = "1";
			this.rdbBasico.Text = "Básico";
			this.rdbBasico.UseVisualStyleBackColor = true;
			// 
			// rdbE
			// 
			this.rdbE.AutoSize = true;
			this.rdbE.Location = new System.Drawing.Point(7, 68);
			this.rdbE.Name = "rdbE";
			this.rdbE.Size = new System.Drawing.Size(74, 17);
			this.rdbE.TabIndex = 29;
			this.rdbE.TabStop = true;
			this.rdbE.Tag = "3";
			this.rdbE.Text = "Avançado";
			this.rdbE.UseVisualStyleBackColor = true;
			// 
			// grbPeriodo
			// 
			this.grbPeriodo.Controls.Add(this.rdbT);
			this.grbPeriodo.Controls.Add(this.rdbM);
			this.grbPeriodo.Controls.Add(this.rdbN);
			this.grbPeriodo.Location = new System.Drawing.Point(514, 233);
			this.grbPeriodo.Name = "grbPeriodo";
			this.grbPeriodo.Size = new System.Drawing.Size(158, 90);
			this.grbPeriodo.TabIndex = 44;
			this.grbPeriodo.TabStop = false;
			this.grbPeriodo.Text = "Período";
			// 
			// rdbT
			// 
			this.rdbT.AutoSize = true;
			this.rdbT.Location = new System.Drawing.Point(6, 42);
			this.rdbT.Name = "rdbT";
			this.rdbT.Size = new System.Drawing.Size(53, 17);
			this.rdbT.TabIndex = 32;
			this.rdbT.TabStop = true;
			this.rdbT.Tag = "2";
			this.rdbT.Text = "Tarde";
			this.rdbT.UseVisualStyleBackColor = true;
			// 
			// rdbM
			// 
			this.rdbM.AutoSize = true;
			this.rdbM.Location = new System.Drawing.Point(6, 19);
			this.rdbM.Name = "rdbM";
			this.rdbM.Size = new System.Drawing.Size(58, 17);
			this.rdbM.TabIndex = 31;
			this.rdbM.TabStop = true;
			this.rdbM.Tag = "1";
			this.rdbM.Text = "Manhã";
			this.rdbM.UseVisualStyleBackColor = true;
			// 
			// rdbN
			// 
			this.rdbN.AutoSize = true;
			this.rdbN.Location = new System.Drawing.Point(6, 65);
			this.rdbN.Name = "rdbN";
			this.rdbN.Size = new System.Drawing.Size(50, 17);
			this.rdbN.TabIndex = 33;
			this.rdbN.TabStop = true;
			this.rdbN.Tag = "3";
			this.rdbN.Text = "Noite";
			this.rdbN.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(323, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 24);
			this.label11.TabIndex = 47;
			this.label11.Text = "Editar Aluno";
			// 
			// FrmEditarAluno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbCurso);
			this.Controls.Add(this.grbPeriodo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEditarAluno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEditarAluno";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbCurso.ResumeLayout(false);
			this.grbCurso.PerformLayout();
			this.grbPeriodo.ResumeLayout(false);
			this.grbPeriodo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtCEP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox grbCurso;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rdbIntermediario;
		private System.Windows.Forms.RadioButton rdbBasico;
		private System.Windows.Forms.RadioButton rdbE;
		private System.Windows.Forms.GroupBox grbPeriodo;
		private System.Windows.Forms.RadioButton rdbT;
		private System.Windows.Forms.RadioButton rdbM;
		private System.Windows.Forms.RadioButton rdbN;
		private System.Windows.Forms.Label label11;
	}
}