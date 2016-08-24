namespace TCC
{
	partial class FrmCadastroProf
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
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCel = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFone = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtCEP = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.MaskedTextBox();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(288, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(195, 24);
			this.label16.TabIndex = 72;
			this.label16.Text = "Cadastro de Professor";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtCidade);
			this.groupBox2.Controls.Add(this.txtRua);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtCel);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtFone);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtNum);
			this.groupBox2.Controls.Add(this.txtEstado);
			this.groupBox2.Controls.Add(this.txtCEP);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtBairro);
			this.groupBox2.Location = new System.Drawing.Point(141, 221);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(489, 162);
			this.groupBox2.TabIndex = 77;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Endereço";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(204, 76);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(262, 20);
			this.txtCidade.TabIndex = 8;
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(92, 22);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(374, 20);
			this.txtRua.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Rua";
			// 
			// txtCel
			// 
			this.txtCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCel.Location = new System.Drawing.Point(222, 127);
			this.txtCel.Mask = "(99) 99999-9999";
			this.txtCel.Name = "txtCel";
			this.txtCel.Size = new System.Drawing.Size(86, 20);
			this.txtCel.TabIndex = 35;
			this.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(164, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Bairro";
			// 
			// txtFone
			// 
			this.txtFone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtFone.Location = new System.Drawing.Point(92, 127);
			this.txtFone.Mask = "(99) 9999-9999";
			this.txtFone.Name = "txtFone";
			this.txtFone.Size = new System.Drawing.Size(79, 20);
			this.txtFone.TabIndex = 34;
			this.txtFone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "CEP";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(64, 53);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(19, 13);
			this.label15.TabIndex = 33;
			this.label15.Text = "N°";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(158, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Cidade";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(92, 50);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(57, 20);
			this.txtNum.TabIndex = 32;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(92, 102);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(57, 20);
			this.txtEstado.TabIndex = 10;
			// 
			// txtCEP
			// 
			this.txtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCEP.Location = new System.Drawing.Point(92, 76);
			this.txtCEP.Mask = "99999-999";
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(57, 20);
			this.txtCEP.TabIndex = 25;
			this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(43, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Estado";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Telefone";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(177, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Celular";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(204, 50);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(262, 20);
			this.txtBairro.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.txtSenha);
			this.groupBox1.Controls.Add(this.lblSexo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtRG);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Location = new System.Drawing.Point(141, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(489, 148);
			this.groupBox1.TabIndex = 76;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Pessoais";
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Location = new System.Drawing.Point(92, 43);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(158, 21);
			this.cmbSexo.TabIndex = 40;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 38;
			this.label1.Text = "Senha";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(92, 19);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(374, 20);
			this.txtNome.TabIndex = 0;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(92, 122);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(374, 20);
			this.txtSenha.TabIndex = 37;
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(52, 48);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(31, 13);
			this.lblSexo.TabIndex = 39;
			this.lblSexo.Text = "Sexo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(48, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Nome";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(60, 74);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "RG";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(183, 74);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 13);
			this.label14.TabIndex = 29;
			this.label14.Text = "CPF";
			// 
			// txtRG
			// 
			this.txtRG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtRG.Location = new System.Drawing.Point(92, 70);
			this.txtRG.Mask = "99.999.999-9";
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(70, 20);
			this.txtRG.TabIndex = 30;
			this.txtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtCPF
			// 
			this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCPF.Location = new System.Drawing.Point(219, 70);
			this.txtCPF.Mask = "999.999.999-99";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(81, 20);
			this.txtCPF.TabIndex = 31;
			this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(92, 96);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(374, 20);
			this.txtEmail.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(47, 100);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(36, 13);
			this.label10.TabIndex = 17;
			this.label10.Text = "E-Mail";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackgroundImage = global::TCC.Properties.Resources.CANCELAR_1;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCancelar.Location = new System.Drawing.Point(676, 454);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(107, 39);
			this.btnCancelar.TabIndex = 75;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.LIMPAR_1;
			this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLimpar.Location = new System.Drawing.Point(125, 454);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(107, 39);
			this.btnLimpar.TabIndex = 74;
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackgroundImage = global::TCC.Properties.Resources.CADASTRAR_1;
			this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCadastrar.Location = new System.Drawing.Point(12, 454);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(107, 39);
			this.btnCadastrar.TabIndex = 73;
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(239, 443);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 78;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// FrmCadastroProf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label16);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCadastroProf";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCadastroProf";
			this.Load += new System.EventHandler(this.FrmCadastroProf_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtCel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtFone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.MaskedTextBox txtCEP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.MaskedTextBox txtRG;
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}