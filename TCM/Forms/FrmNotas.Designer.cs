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
			this.dgvAlunos = new System.Windows.Forms.DataGridView();
			this.grbPesquisar = new System.Windows.Forms.GroupBox();
			this.cmbTurma = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbCurso = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbPeriodo = new System.Windows.Forms.ComboBox();
			this.dgvAluno = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvAtiv = new System.Windows.Forms.DataGridView();
			this.grbAdicionar = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtPerf = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtSpeaking = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtReading = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtListening = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
			this.grbPesquisar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).BeginInit();
			this.grbAdicionar.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAlunos
			// 
			this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlunos.Location = new System.Drawing.Point(13, 141);
			this.dgvAlunos.Name = "dgvAlunos";
			this.dgvAlunos.Size = new System.Drawing.Size(222, 352);
			this.dgvAlunos.TabIndex = 0;
			this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
			// 
			// grbPesquisar
			// 
			this.grbPesquisar.Controls.Add(this.cmbTurma);
			this.grbPesquisar.Controls.Add(this.label10);
			this.grbPesquisar.Controls.Add(this.cmbCurso);
			this.grbPesquisar.Controls.Add(this.label2);
			this.grbPesquisar.Controls.Add(this.label1);
			this.grbPesquisar.Controls.Add(this.cmbPeriodo);
			this.grbPesquisar.Location = new System.Drawing.Point(13, 12);
			this.grbPesquisar.Name = "grbPesquisar";
			this.grbPesquisar.Size = new System.Drawing.Size(222, 110);
			this.grbPesquisar.TabIndex = 2;
			this.grbPesquisar.TabStop = false;
			this.grbPesquisar.Text = "Pesquisar";
			// 
			// cmbTurma
			// 
			this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurma.FormattingEnabled = true;
			this.cmbTurma.Location = new System.Drawing.Point(63, 73);
			this.cmbTurma.Name = "cmbTurma";
			this.cmbTurma.Size = new System.Drawing.Size(140, 21);
			this.cmbTurma.TabIndex = 7;
			this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbTurma_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(23, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Curso";
			// 
			// cmbCurso
			// 
			this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCurso.FormattingEnabled = true;
			this.cmbCurso.Location = new System.Drawing.Point(63, 19);
			this.cmbCurso.Name = "cmbCurso";
			this.cmbCurso.Size = new System.Drawing.Size(140, 21);
			this.cmbCurso.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Turma";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Período";
			// 
			// cmbPeriodo
			// 
			this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPeriodo.FormattingEnabled = true;
			this.cmbPeriodo.Location = new System.Drawing.Point(63, 46);
			this.cmbPeriodo.Name = "cmbPeriodo";
			this.cmbPeriodo.Size = new System.Drawing.Size(140, 21);
			this.cmbPeriodo.TabIndex = 0;
			this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
			// 
			// dgvAluno
			// 
			this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAluno.Location = new System.Drawing.Point(241, 195);
			this.dgvAluno.Name = "dgvAluno";
			this.dgvAluno.Size = new System.Drawing.Size(313, 298);
			this.dgvAluno.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Alunos da turma";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(560, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Atividades disponíveis";
			// 
			// dgvAtiv
			// 
			this.dgvAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtiv.Location = new System.Drawing.Point(560, 25);
			this.dgvAtiv.Name = "dgvAtiv";
			this.dgvAtiv.Size = new System.Drawing.Size(223, 237);
			this.dgvAtiv.TabIndex = 5;
			this.dgvAtiv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtiv_CellClick);
			// 
			// grbAdicionar
			// 
			this.grbAdicionar.Controls.Add(this.label20);
			this.grbAdicionar.Controls.Add(this.label13);
			this.grbAdicionar.Controls.Add(this.txtPerf);
			this.grbAdicionar.Controls.Add(this.label12);
			this.grbAdicionar.Controls.Add(this.txtSpeaking);
			this.grbAdicionar.Controls.Add(this.label7);
			this.grbAdicionar.Controls.Add(this.txtReading);
			this.grbAdicionar.Controls.Add(this.label6);
			this.grbAdicionar.Controls.Add(this.txtListening);
			this.grbAdicionar.Controls.Add(this.label11);
			this.grbAdicionar.Controls.Add(this.btnAdicionar);
			this.grbAdicionar.Controls.Add(this.label9);
			this.grbAdicionar.Controls.Add(this.label8);
			this.grbAdicionar.Location = new System.Drawing.Point(560, 268);
			this.grbAdicionar.Name = "grbAdicionar";
			this.grbAdicionar.Size = new System.Drawing.Size(223, 188);
			this.grbAdicionar.TabIndex = 7;
			this.grbAdicionar.TabStop = false;
			this.grbAdicionar.Text = "Atribuir";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(70, 41);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(88, 13);
			this.label20.TabIndex = 19;
			this.label20.Text = "[Nome Atividade]";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(10, 41);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(54, 13);
			this.label13.TabIndex = 18;
			this.label13.Text = "Atividade:";
			// 
			// txtPerf
			// 
			this.txtPerf.Location = new System.Drawing.Point(83, 137);
			this.txtPerf.Name = "txtPerf";
			this.txtPerf.Size = new System.Drawing.Size(29, 20);
			this.txtPerf.TabIndex = 17;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 140);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "Performance";
			// 
			// txtSpeaking
			// 
			this.txtSpeaking.Location = new System.Drawing.Point(83, 111);
			this.txtSpeaking.Name = "txtSpeaking";
			this.txtSpeaking.Size = new System.Drawing.Size(29, 20);
			this.txtSpeaking.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Speaking";
			// 
			// txtReading
			// 
			this.txtReading.Location = new System.Drawing.Point(83, 88);
			this.txtReading.Name = "txtReading";
			this.txtReading.Size = new System.Drawing.Size(29, 20);
			this.txtReading.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Reading";
			// 
			// txtListening
			// 
			this.txtListening.Location = new System.Drawing.Point(83, 62);
			this.txtListening.Name = "txtListening";
			this.txtListening.Size = new System.Drawing.Size(29, 20);
			this.txtListening.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(30, 162);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Formato:      00";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackgroundImage = global::TCC.Properties.Resources.ADICIONAR_1;
			this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAdicionar.Location = new System.Drawing.Point(132, 151);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(85, 31);
			this.btnAdicionar.TabIndex = 8;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(204, 18);
			this.label9.TabIndex = 7;
			this.label9.Text = "Por favor selecione a atividade desejada.\r\n";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Listening";
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Location = new System.Drawing.Point(241, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(313, 151);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detalhes aluno";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(85, 124);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(220, 13);
			this.label25.TabIndex = 9;
			this.label25.Text = "[Selecione um aluno da turma para visualizar]";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(85, 98);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(220, 13);
			this.label24.TabIndex = 8;
			this.label24.Text = "[Selecione um aluno da turma para visualizar]";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(85, 72);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(220, 13);
			this.label23.TabIndex = 7;
			this.label23.Text = "[Selecione um aluno da turma para visualizar]";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(85, 46);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(220, 13);
			this.label22.TabIndex = 6;
			this.label22.Text = "[Selecione um aluno da turma para visualizar]";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(85, 20);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(220, 13);
			this.label21.TabIndex = 5;
			this.label21.Text = "[Selecione um aluno da turma para visualizar]";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(19, 124);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(57, 13);
			this.label19.TabIndex = 4;
			this.label19.Text = "Frequêcia:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(38, 98);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 13);
			this.label18.TabIndex = 3;
			this.label18.Text = "Faltas:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(8, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(71, 13);
			this.label17.TabIndex = 2;
			this.label17.Text = "Aulas dadas: ";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(38, 46);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 13);
			this.label16.TabIndex = 1;
			this.label16.Text = "Nome: ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(7, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 13);
			this.label15.TabIndex = 0;
			this.label15.Text = "N° matrícula: ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(241, 179);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 13);
			this.label14.TabIndex = 11;
			this.label14.Text = "Atividades já atribuídas";
			// 
			// FrmNotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbAdicionar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvAtiv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvAluno);
			this.Controls.Add(this.grbPesquisar);
			this.Controls.Add(this.dgvAlunos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmNotas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNotas";
			this.Load += new System.EventHandler(this.FrmNotas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
			this.grbPesquisar.ResumeLayout(false);
			this.grbPesquisar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).EndInit();
			this.grbAdicionar.ResumeLayout(false);
			this.grbAdicionar.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAlunos;
		private System.Windows.Forms.GroupBox grbPesquisar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbPeriodo;
		private System.Windows.Forms.DataGridView dgvAluno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvAtiv;
		private System.Windows.Forms.GroupBox grbAdicionar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbCurso;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtListening;
		private System.Windows.Forms.ComboBox cmbTurma;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtPerf;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtSpeaking;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtReading;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
	}
}