namespace TCC
{
	partial class FrmConsultaAluno
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
			this.dgvAluno = new System.Windows.Forms.DataGridView();
			this.grbExibir = new System.Windows.Forms.GroupBox();
			this.btnExibir = new System.Windows.Forms.Button();
			this.rdbEnd = new System.Windows.Forms.RadioButton();
			this.rdbContato = new System.Windows.Forms.RadioButton();
			this.rdbPessoais = new System.Windows.Forms.RadioButton();
			this.grbPesquisa = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.cmbExibe = new System.Windows.Forms.ComboBox();
			this.grbModificar = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAlt = new System.Windows.Forms.TextBox();
			this.cmbAltCampo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
			this.grbExibir.SuspendLayout();
			this.grbPesquisa.SuspendLayout();
			this.grbModificar.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAluno
			// 
			this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAluno.Location = new System.Drawing.Point(12, 25);
			this.dgvAluno.Name = "dgvAluno";
			this.dgvAluno.Size = new System.Drawing.Size(771, 314);
			this.dgvAluno.TabIndex = 0;
			// 
			// grbExibir
			// 
			this.grbExibir.Controls.Add(this.btnExibir);
			this.grbExibir.Controls.Add(this.rdbEnd);
			this.grbExibir.Controls.Add(this.rdbContato);
			this.grbExibir.Controls.Add(this.rdbPessoais);
			this.grbExibir.Location = new System.Drawing.Point(13, 345);
			this.grbExibir.Name = "grbExibir";
			this.grbExibir.Size = new System.Drawing.Size(97, 148);
			this.grbExibir.TabIndex = 1;
			this.grbExibir.TabStop = false;
			this.grbExibir.Text = "Informações";
			// 
			// btnExibir
			// 
			this.btnExibir.BackgroundImage = global::TCC.Properties.Resources.EXIBIR_1;
			this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExibir.Location = new System.Drawing.Point(7, 111);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(85, 31);
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
			// grbPesquisa
			// 
			this.grbPesquisa.Controls.Add(this.label3);
			this.grbPesquisa.Controls.Add(this.label2);
			this.grbPesquisa.Controls.Add(this.label1);
			this.grbPesquisa.Controls.Add(this.btnPesquisa);
			this.grbPesquisa.Controls.Add(this.txtPesquisa);
			this.grbPesquisa.Controls.Add(this.cmbCampo);
			this.grbPesquisa.Controls.Add(this.cmbExibe);
			this.grbPesquisa.Location = new System.Drawing.Point(116, 345);
			this.grbPesquisa.Name = "grbPesquisa";
			this.grbPesquisa.Size = new System.Drawing.Size(190, 148);
			this.grbPesquisa.TabIndex = 2;
			this.grbPesquisa.TabStop = false;
			this.grbPesquisa.Text = "Pesquisa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Coluna";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Exibição";
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.BackgroundImage = global::TCC.Properties.Resources.PESQUISAR_1;
			this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPesquisa.Location = new System.Drawing.Point(6, 111);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(85, 31);
			this.btnPesquisa.TabIndex = 3;
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(59, 75);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(121, 20);
			this.txtPesquisa.TabIndex = 2;
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(59, 47);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(121, 21);
			this.cmbCampo.TabIndex = 1;
			// 
			// cmbExibe
			// 
			this.cmbExibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExibe.FormattingEnabled = true;
			this.cmbExibe.Location = new System.Drawing.Point(59, 20);
			this.cmbExibe.Name = "cmbExibe";
			this.cmbExibe.Size = new System.Drawing.Size(121, 21);
			this.cmbExibe.TabIndex = 0;
			this.cmbExibe.SelectedIndexChanged += new System.EventHandler(this.cmbExibe_SelectedIndexChanged);
			// 
			// grbModificar
			// 
			this.grbModificar.Controls.Add(this.label6);
			this.grbModificar.Controls.Add(this.txtAlt);
			this.grbModificar.Controls.Add(this.cmbAltCampo);
			this.grbModificar.Controls.Add(this.label5);
			this.grbModificar.Controls.Add(this.label4);
			this.grbModificar.Controls.Add(this.txtID);
			this.grbModificar.Controls.Add(this.btnExcluir);
			this.grbModificar.Controls.Add(this.btnAlterar);
			this.grbModificar.Location = new System.Drawing.Point(313, 345);
			this.grbModificar.Name = "grbModificar";
			this.grbModificar.Size = new System.Drawing.Size(379, 148);
			this.grbModificar.TabIndex = 3;
			this.grbModificar.TabStop = false;
			this.grbModificar.Text = "Modificar";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Valor";
			// 
			// txtAlt
			// 
			this.txtAlt.Location = new System.Drawing.Point(52, 74);
			this.txtAlt.Name = "txtAlt";
			this.txtAlt.Size = new System.Drawing.Size(181, 20);
			this.txtAlt.TabIndex = 6;
			// 
			// cmbAltCampo
			// 
			this.cmbAltCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAltCampo.FormattingEnabled = true;
			this.cmbAltCampo.Location = new System.Drawing.Point(52, 47);
			this.cmbAltCampo.Name = "cmbAltCampo";
			this.cmbAltCampo.Size = new System.Drawing.Size(181, 21);
			this.cmbAltCampo.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Campo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(52, 21);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(90, 20);
			this.txtID.TabIndex = 2;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = global::TCC.Properties.Resources.EXCLUIR_1;
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExcluir.Location = new System.Drawing.Point(148, 13);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnExcluir.Size = new System.Drawing.Size(85, 31);
			this.btnExcluir.TabIndex = 1;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = global::TCC.Properties.Resources.ALTERAR_1;
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAlterar.Location = new System.Drawing.Point(6, 111);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(85, 31);
			this.btnAlterar.TabIndex = 0;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(319, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Consulta de Alunos";
			// 
			// btnFechar
			// 
			this.btnFechar.BackgroundImage = global::TCC.Properties.Resources.FECHAR_1;
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFechar.Location = new System.Drawing.Point(698, 462);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(85, 31);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// FrmConsultaAluno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbModificar);
			this.Controls.Add(this.grbPesquisa);
			this.Controls.Add(this.grbExibir);
			this.Controls.Add(this.dgvAluno);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmConsultaAluno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmConsultaAluno";
			this.Load += new System.EventHandler(this.FrmConsultaAluno_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
			this.grbExibir.ResumeLayout(false);
			this.grbExibir.PerformLayout();
			this.grbPesquisa.ResumeLayout(false);
			this.grbPesquisa.PerformLayout();
			this.grbModificar.ResumeLayout(false);
			this.grbModificar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAluno;
		private System.Windows.Forms.GroupBox grbExibir;
		private System.Windows.Forms.Button btnExibir;
		private System.Windows.Forms.RadioButton rdbEnd;
		private System.Windows.Forms.RadioButton rdbContato;
		private System.Windows.Forms.RadioButton rdbPessoais;
		private System.Windows.Forms.GroupBox grbPesquisa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.ComboBox cmbExibe;
		private System.Windows.Forms.GroupBox grbModificar;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAlt;
		private System.Windows.Forms.ComboBox cmbAltCampo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Label label7;
	}
}