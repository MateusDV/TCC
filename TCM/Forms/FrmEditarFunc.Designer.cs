namespace TCC
{
	partial class FrmEditarFunc
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
			this.label10 = new System.Windows.Forms.Label();
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.MaskedTextBox();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbCargo = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(285, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(222, 24);
			this.label10.TabIndex = 46;
			this.label10.Text = "Alteração de Funcionário";
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
			this.groupBox2.Location = new System.Drawing.Point(149, 223);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(489, 162);
			this.groupBox2.TabIndex = 45;
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
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.lblSexo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtRG);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbCargo);
			this.groupBox1.Location = new System.Drawing.Point(149, 66);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(489, 151);
			this.groupBox1.TabIndex = 44;
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
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(92, 19);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(374, 20);
			this.txtNome.TabIndex = 0;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
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
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(47, 100);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "E-Mail";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 126);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 13);
			this.label11.TabIndex = 23;
			this.label11.Text = "Cargo/Função";
			// 
			// cmbCargo
			// 
			this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCargo.FormattingEnabled = true;
			this.cmbCargo.Location = new System.Drawing.Point(92, 122);
			this.cmbCargo.Name = "cmbCargo";
			this.cmbCargo.Size = new System.Drawing.Size(158, 21);
			this.cmbCargo.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 470);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 47;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(94, 470);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 48;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(708, 470);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 49;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// FrmEditarFunc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEditarFunc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEditarFunc";
			this.Load += new System.EventHandler(this.FrmEditarFunc_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
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
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.MaskedTextBox txtRG;
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbCargo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}