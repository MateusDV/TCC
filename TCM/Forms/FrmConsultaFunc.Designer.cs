﻿namespace TCC
{
	partial class FrmConsultaFunc
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
			this.label7 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			this.grbPesquisa = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.grbExibir = new System.Windows.Forms.GroupBox();
			this.btnExibir = new System.Windows.Forms.Button();
			this.rdbEnd = new System.Windows.Forms.RadioButton();
			this.rdbContato = new System.Windows.Forms.RadioButton();
			this.rdbPessoais = new System.Windows.Forms.RadioButton();
			this.dgvFunc = new System.Windows.Forms.DataGridView();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.grbPesquisa.SuspendLayout();
			this.grbExibir.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(431, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Consulta de Funcionários";
			// 
			// btnFechar
			// 
			this.btnFechar.BackgroundImage = global::TCC.Properties.Resources.FECHAR_1;
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFechar.Location = new System.Drawing.Point(12, 462);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(85, 31);
			this.btnFechar.TabIndex = 15;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// grbPesquisa
			// 
			this.grbPesquisa.Controls.Add(this.label3);
			this.grbPesquisa.Controls.Add(this.label2);
			this.grbPesquisa.Controls.Add(this.btnPesquisa);
			this.grbPesquisa.Controls.Add(this.txtPesquisa);
			this.grbPesquisa.Controls.Add(this.cmbCampo);
			this.grbPesquisa.Location = new System.Drawing.Point(12, 158);
			this.grbPesquisa.Name = "grbPesquisa";
			this.grbPesquisa.Size = new System.Drawing.Size(177, 110);
			this.grbPesquisa.TabIndex = 14;
			this.grbPesquisa.TabStop = false;
			this.grbPesquisa.Text = "Pesquisa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Coluna";
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.BackgroundImage = global::TCC.Properties.Resources.PESQUISAR_1;
			this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPesquisa.Location = new System.Drawing.Point(6, 73);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(85, 31);
			this.btnPesquisa.TabIndex = 3;
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(54, 47);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(116, 20);
			this.txtPesquisa.TabIndex = 2;
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(54, 19);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(116, 21);
			this.cmbCampo.TabIndex = 1;
			// 
			// grbExibir
			// 
			this.grbExibir.Controls.Add(this.btnExibir);
			this.grbExibir.Controls.Add(this.rdbEnd);
			this.grbExibir.Controls.Add(this.rdbContato);
			this.grbExibir.Controls.Add(this.rdbPessoais);
			this.grbExibir.Location = new System.Drawing.Point(12, 22);
			this.grbExibir.Name = "grbExibir";
			this.grbExibir.Size = new System.Drawing.Size(177, 130);
			this.grbExibir.TabIndex = 13;
			this.grbExibir.TabStop = false;
			this.grbExibir.Text = "Modo de exibção";
			// 
			// btnExibir
			// 
			this.btnExibir.BackgroundImage = global::TCC.Properties.Resources.EXIBIR_1;
			this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExibir.Location = new System.Drawing.Point(7, 89);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(84, 33);
			this.btnExibir.TabIndex = 3;
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
			// 
			// rdbEnd
			// 
			this.rdbEnd.AutoSize = true;
			this.rdbEnd.Location = new System.Drawing.Point(7, 66);
			this.rdbEnd.Name = "rdbEnd";
			this.rdbEnd.Size = new System.Drawing.Size(71, 17);
			this.rdbEnd.TabIndex = 2;
			this.rdbEnd.TabStop = true;
			this.rdbEnd.Tag = "3";
			this.rdbEnd.Text = "Endereço";
			this.rdbEnd.UseVisualStyleBackColor = true;
			// 
			// rdbContato
			// 
			this.rdbContato.AutoSize = true;
			this.rdbContato.Location = new System.Drawing.Point(7, 43);
			this.rdbContato.Name = "rdbContato";
			this.rdbContato.Size = new System.Drawing.Size(62, 17);
			this.rdbContato.TabIndex = 1;
			this.rdbContato.TabStop = true;
			this.rdbContato.Tag = "2";
			this.rdbContato.Text = "Contato";
			this.rdbContato.UseVisualStyleBackColor = true;
			// 
			// rdbPessoais
			// 
			this.rdbPessoais.AutoSize = true;
			this.rdbPessoais.Location = new System.Drawing.Point(7, 20);
			this.rdbPessoais.Name = "rdbPessoais";
			this.rdbPessoais.Size = new System.Drawing.Size(67, 17);
			this.rdbPessoais.TabIndex = 0;
			this.rdbPessoais.TabStop = true;
			this.rdbPessoais.Tag = "1";
			this.rdbPessoais.Text = "Pessoais";
			this.rdbPessoais.UseVisualStyleBackColor = true;
			// 
			// dgvFunc
			// 
			this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFunc.Location = new System.Drawing.Point(195, 22);
			this.dgvFunc.Name = "dgvFunc";
			this.dgvFunc.Size = new System.Drawing.Size(588, 471);
			this.dgvFunc.TabIndex = 11;
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = global::TCC.Properties.Resources.ALTERAR_1;
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAlterar.Location = new System.Drawing.Point(18, 274);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(85, 31);
			this.btnAlterar.TabIndex = 12;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// FrmConsultaFunc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbPesquisa);
			this.Controls.Add(this.grbExibir);
			this.Controls.Add(this.dgvFunc);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmConsultaFunc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmConsultaAluno";
			this.Load += new System.EventHandler(this.FrmConsultaFunc_Load);
			this.grbPesquisa.ResumeLayout(false);
			this.grbPesquisa.PerformLayout();
			this.grbExibir.ResumeLayout(false);
			this.grbExibir.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.GroupBox grbPesquisa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.GroupBox grbExibir;
		private System.Windows.Forms.Button btnExibir;
		private System.Windows.Forms.RadioButton rdbEnd;
		private System.Windows.Forms.RadioButton rdbContato;
		private System.Windows.Forms.RadioButton rdbPessoais;
		private System.Windows.Forms.DataGridView dgvFunc;
		private System.Windows.Forms.Button btnAlterar;
	}
}