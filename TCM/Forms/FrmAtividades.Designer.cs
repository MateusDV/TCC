namespace TCC
{
	partial class FrmAtividades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtividades));
			this.dgvAtiv = new System.Windows.Forms.DataGridView();
			this.grbPesquisar = new System.Windows.Forms.GroupBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.grbCriar = new System.Windows.Forms.GroupBox();
			this.lblCar = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.grbMod = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnMod = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).BeginInit();
			this.grbPesquisar.SuspendLayout();
			this.grbCriar.SuspendLayout();
			this.grbMod.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAtiv
			// 
			this.dgvAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtiv.Location = new System.Drawing.Point(12, 31);
			this.dgvAtiv.Name = "dgvAtiv";
			this.dgvAtiv.Size = new System.Drawing.Size(440, 462);
			this.dgvAtiv.TabIndex = 0;
			this.dgvAtiv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtiv_CellClick);
			// 
			// grbPesquisar
			// 
			this.grbPesquisar.Controls.Add(this.btnPesquisar);
			this.grbPesquisar.Controls.Add(this.label2);
			this.grbPesquisar.Controls.Add(this.txtValor);
			this.grbPesquisar.Controls.Add(this.label1);
			this.grbPesquisar.Controls.Add(this.cmbCampo);
			this.grbPesquisar.Location = new System.Drawing.Point(458, 12);
			this.grbPesquisar.Name = "grbPesquisar";
			this.grbPesquisar.Size = new System.Drawing.Size(325, 75);
			this.grbPesquisar.TabIndex = 1;
			this.grbPesquisar.TabStop = false;
			this.grbPesquisar.Text = "Pesquisar";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
			this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPesquisar.Location = new System.Drawing.Point(234, 36);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(85, 31);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(52, 47);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(121, 20);
			this.txtValor.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Campo";
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(52, 19);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(121, 21);
			this.cmbCampo.TabIndex = 0;
			this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// grbCriar
			// 
			this.grbCriar.Controls.Add(this.lblCar);
			this.grbCriar.Controls.Add(this.label5);
			this.grbCriar.Controls.Add(this.label4);
			this.grbCriar.Controls.Add(this.txtDesc);
			this.grbCriar.Controls.Add(this.label3);
			this.grbCriar.Controls.Add(this.txtNome);
			this.grbCriar.Controls.Add(this.button1);
			this.grbCriar.Location = new System.Drawing.Point(458, 93);
			this.grbCriar.Name = "grbCriar";
			this.grbCriar.Size = new System.Drawing.Size(325, 159);
			this.grbCriar.TabIndex = 2;
			this.grbCriar.TabStop = false;
			this.grbCriar.Text = "Criar";
			// 
			// lblCar
			// 
			this.lblCar.AutoSize = true;
			this.lblCar.Location = new System.Drawing.Point(179, 104);
			this.lblCar.Name = "lblCar";
			this.lblCar.Size = new System.Drawing.Size(0, 13);
			this.lblCar.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Caracteres restantes: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Descrição";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(63, 46);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(242, 55);
			this.txtDesc.TabIndex = 3;
			this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(63, 20);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(121, 20);
			this.txtNome.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::TCC.Properties.Resources.CRIAR_1;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Location = new System.Drawing.Point(234, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 31);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// grbMod
			// 
			this.grbMod.Controls.Add(this.label7);
			this.grbMod.Controls.Add(this.label8);
			this.grbMod.Controls.Add(this.label11);
			this.grbMod.Controls.Add(this.textBox1);
			this.grbMod.Controls.Add(this.label12);
			this.grbMod.Controls.Add(this.textBox2);
			this.grbMod.Controls.Add(this.label9);
			this.grbMod.Controls.Add(this.button2);
			this.grbMod.Controls.Add(this.btnMod);
			this.grbMod.Controls.Add(this.label6);
			this.grbMod.Controls.Add(this.txtID);
			this.grbMod.Location = new System.Drawing.Point(458, 258);
			this.grbMod.Name = "grbMod";
			this.grbMod.Size = new System.Drawing.Size(325, 198);
			this.grbMod.TabIndex = 3;
			this.grbMod.TabStop = false;
			this.grbMod.Text = "Modificar";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(179, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(60, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Caracteres restantes: ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(2, 78);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Descrição";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 75);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(242, 55);
			this.textBox1.TabIndex = 15;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(22, 52);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Nome";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 49);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 26);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(271, 14);
			this.label9.TabIndex = 12;
			this.label9.Text = "Por favor pesquise pelo seu registro e então clique nele.";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::TCC.Properties.Resources.EXCLUIR_1;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Location = new System.Drawing.Point(234, 161);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 31);
			this.button2.TabIndex = 11;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnMod
			// 
			this.btnMod.BackgroundImage = global::TCC.Properties.Resources.ALTERAR_1;
			this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMod.Location = new System.Drawing.Point(6, 161);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(85, 31);
			this.btnMod.TabIndex = 10;
			this.btnMod.UseVisualStyleBackColor = true;
			this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(114, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(138, 167);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(63, 20);
			this.txtID.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(196, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 17);
			this.label10.TabIndex = 10;
			this.label10.Text = "Atividades";
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
			// FrmAtividades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbMod);
			this.Controls.Add(this.grbCriar);
			this.Controls.Add(this.grbPesquisar);
			this.Controls.Add(this.dgvAtiv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAtividades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAtividades";
			this.Load += new System.EventHandler(this.FrmAtividades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).EndInit();
			this.grbPesquisar.ResumeLayout(false);
			this.grbPesquisar.PerformLayout();
			this.grbCriar.ResumeLayout(false);
			this.grbCriar.PerformLayout();
			this.grbMod.ResumeLayout(false);
			this.grbMod.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAtiv;
		private System.Windows.Forms.GroupBox grbPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.GroupBox grbCriar;
		private System.Windows.Forms.GroupBox grbMod;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label lblCar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnMod;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox2;
	}
}