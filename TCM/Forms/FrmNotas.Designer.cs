namespace TCC
{
	partial class FrmNotas
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
			this.dgvNotas = new System.Windows.Forms.DataGridView();
			this.grbPesquisar = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbTabela = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.dgvAluno = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvAtiv = new System.Windows.Forms.DataGridView();
			this.grbAdicionar = new System.Windows.Forms.GroupBox();
			this.txtNota = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIDAtiv = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIDAluno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
			this.grbPesquisar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).BeginInit();
			this.grbAdicionar.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvNotas
			// 
			this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotas.Location = new System.Drawing.Point(13, 31);
			this.dgvNotas.Name = "dgvNotas";
			this.dgvNotas.Size = new System.Drawing.Size(308, 462);
			this.dgvNotas.TabIndex = 0;
			// 
			// grbPesquisar
			// 
			this.grbPesquisar.Controls.Add(this.label10);
			this.grbPesquisar.Controls.Add(this.cmbTabela);
			this.grbPesquisar.Controls.Add(this.btnPesquisar);
			this.grbPesquisar.Controls.Add(this.label2);
			this.grbPesquisar.Controls.Add(this.txtValor);
			this.grbPesquisar.Controls.Add(this.label1);
			this.grbPesquisar.Controls.Add(this.cmbCampo);
			this.grbPesquisar.Location = new System.Drawing.Point(327, 31);
			this.grbPesquisar.Name = "grbPesquisar";
			this.grbPesquisar.Size = new System.Drawing.Size(188, 139);
			this.grbPesquisar.TabIndex = 2;
			this.grbPesquisar.TabStop = false;
			this.grbPesquisar.Text = "Pesquisar";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Tabela";
			// 
			// cmbTabela
			// 
			this.cmbTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTabela.FormattingEnabled = true;
			this.cmbTabela.Location = new System.Drawing.Point(52, 19);
			this.cmbTabela.Name = "cmbTabela";
			this.cmbTabela.Size = new System.Drawing.Size(121, 21);
			this.cmbTabela.TabIndex = 5;
			this.cmbTabela.SelectedIndexChanged += new System.EventHandler(this.cmbTabela_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(52, 75);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(121, 20);
			this.txtValor.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Campo";
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(52, 47);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(121, 21);
			this.cmbCampo.TabIndex = 0;
			// 
			// dgvAluno
			// 
			this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAluno.Location = new System.Drawing.Point(327, 189);
			this.dgvAluno.Name = "dgvAluno";
			this.dgvAluno.Size = new System.Drawing.Size(188, 304);
			this.dgvAluno.TabIndex = 3;
			this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(327, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Alunos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(521, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Atividades";
			// 
			// dgvAtiv
			// 
			this.dgvAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtiv.Location = new System.Drawing.Point(521, 50);
			this.dgvAtiv.Name = "dgvAtiv";
			this.dgvAtiv.Size = new System.Drawing.Size(262, 175);
			this.dgvAtiv.TabIndex = 5;
			this.dgvAtiv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtiv_CellClick);
			// 
			// grbAdicionar
			// 
			this.grbAdicionar.Controls.Add(this.txtNota);
			this.grbAdicionar.Controls.Add(this.label11);
			this.grbAdicionar.Controls.Add(this.btnAdicionar);
			this.grbAdicionar.Controls.Add(this.label9);
			this.grbAdicionar.Controls.Add(this.label8);
			this.grbAdicionar.Controls.Add(this.label7);
			this.grbAdicionar.Controls.Add(this.txtIDAtiv);
			this.grbAdicionar.Controls.Add(this.label6);
			this.grbAdicionar.Controls.Add(this.txtIDAluno);
			this.grbAdicionar.Location = new System.Drawing.Point(521, 232);
			this.grbAdicionar.Name = "grbAdicionar";
			this.grbAdicionar.Size = new System.Drawing.Size(262, 224);
			this.grbAdicionar.TabIndex = 7;
			this.grbAdicionar.TabStop = false;
			this.grbAdicionar.Text = "Atribuir";
			// 
			// txtNota
			// 
			this.txtNota.Location = new System.Drawing.Point(76, 108);
			this.txtNota.Name = "txtNota";
			this.txtNota.Size = new System.Drawing.Size(29, 20);
			this.txtNota.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(24, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Formato:    00";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(249, 30);
			this.label9.TabIndex = 7;
			this.label9.Text = "Por favor selecione o aluno e a atividade desejada em suas respectivas listas";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Nota";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "ID Atividade";
			// 
			// txtIDAtiv
			// 
			this.txtIDAtiv.Location = new System.Drawing.Point(76, 82);
			this.txtIDAtiv.Name = "txtIDAtiv";
			this.txtIDAtiv.Size = new System.Drawing.Size(135, 20);
			this.txtIDAtiv.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "ID Aluno";
			// 
			// txtIDAluno
			// 
			this.txtIDAluno.Location = new System.Drawing.Point(76, 56);
			this.txtIDAluno.Name = "txtIDAluno";
			this.txtIDAluno.Size = new System.Drawing.Size(135, 20);
			this.txtIDAluno.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(376, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Notas";
			// 
			// btnFechar
			// 
			this.btnFechar.BackgroundImage = global::TCC.Properties.Resources.FECHAR_1;
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFechar.Location = new System.Drawing.Point(698, 462);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(85, 31);
			this.btnFechar.TabIndex = 8;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackgroundImage = global::TCC.Properties.Resources.ADICIONAR_1;
			this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAdicionar.Location = new System.Drawing.Point(6, 187);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(85, 31);
			this.btnAdicionar.TabIndex = 8;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackgroundImage = global::TCC.Properties.Resources.PESQUISAR_1;
			this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPesquisar.Location = new System.Drawing.Point(6, 102);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(85, 31);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// FrmNotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbAdicionar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvAtiv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvAluno);
			this.Controls.Add(this.grbPesquisar);
			this.Controls.Add(this.dgvNotas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmNotas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNotas";
			this.Load += new System.EventHandler(this.FrmNotas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
			this.grbPesquisar.ResumeLayout(false);
			this.grbPesquisar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).EndInit();
			this.grbAdicionar.ResumeLayout(false);
			this.grbAdicionar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvNotas;
		private System.Windows.Forms.GroupBox grbPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.DataGridView dgvAluno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvAtiv;
		private System.Windows.Forms.GroupBox grbAdicionar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtIDAtiv;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIDAluno;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbTabela;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNota;
	}
}