namespace ProjetoBenner4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtPrato = new System.Windows.Forms.TextBox();
            this.lbInstrucao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRapido = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCozinhar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProgramaNovo = new System.Windows.Forms.Button();
            this.txtProgramaTempo = new System.Windows.Forms.DateTimePicker();
            this.txtProgramaChar = new System.Windows.Forms.TextBox();
            this.txtProgramaInstrucao = new System.Windows.Forms.TextBox();
            this.txtProgramaNome = new System.Windows.Forms.TextBox();
            this.txtProgramaPotencia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgProgramas = new System.Windows.Forms.DataGridView();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnRetomar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProgramaPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 379);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.txtPrato);
            this.tabPage1.Controls.Add(this.lbInstrucao);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbLista);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTempo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPotencia);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAviso);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnRapido);
            this.tabPage1.Controls.Add(this.txtResultado);
            this.tabPage1.Controls.Add(this.btnCozinhar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Painel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArquivo);
            this.groupBox2.Controls.Add(this.btnArquivo);
            this.groupBox2.Location = new System.Drawing.Point(268, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 47);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adiconar arquivo";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(6, 19);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(137, 20);
            this.txtArquivo.TabIndex = 23;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(149, 17);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(86, 23);
            this.btnArquivo.TabIndex = 22;
            this.btnArquivo.Text = "Adicionar";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // txtPrato
            // 
            this.txtPrato.Location = new System.Drawing.Point(6, 74);
            this.txtPrato.Name = "txtPrato";
            this.txtPrato.Size = new System.Drawing.Size(248, 20);
            this.txtPrato.TabIndex = 3;
            // 
            // lbInstrucao
            // 
            this.lbInstrucao.AutoSize = true;
            this.lbInstrucao.Location = new System.Drawing.Point(5, 168);
            this.lbInstrucao.Name = "lbInstrucao";
            this.lbInstrucao.Size = new System.Drawing.Size(91, 13);
            this.lbInstrucao.TabIndex = 21;
            this.lbInstrucao.Text = "Instruções de uso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prato";
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(5, 140);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(250, 21);
            this.cbLista.TabIndex = 4;
            this.cbLista.SelectedIndexChanged += new System.EventHandler(this.cbLista_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Programa";
            // 
            // txtTempo
            // 
            this.txtTempo.CustomFormat = "mm:ss";
            this.txtTempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTempo.Location = new System.Drawing.Point(5, 29);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTempo.ShowUpDown = true;
            this.txtTempo.Size = new System.Drawing.Size(249, 20);
            this.txtTempo.TabIndex = 1;
            this.txtTempo.Value = new System.DateTime(2018, 5, 30, 0, 0, 30, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Andamento";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(268, 29);
            this.txtPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(241, 20);
            this.txtPotencia.TabIndex = 2;
            this.txtPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Potencia";
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(5, 320);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.ReadOnly = true;
            this.txtAviso.Size = new System.Drawing.Size(504, 29);
            this.txtAviso.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tempo";
            // 
            // btnRapido
            // 
            this.btnRapido.Location = new System.Drawing.Point(322, 170);
            this.btnRapido.Name = "btnRapido";
            this.btnRapido.Size = new System.Drawing.Size(75, 38);
            this.btnRapido.TabIndex = 12;
            this.btnRapido.Text = "Inicio rapido";
            this.btnRapido.UseVisualStyleBackColor = true;
            this.btnRapido.Click += new System.EventHandler(this.btnRapido_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 214);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(503, 99);
            this.txtResultado.TabIndex = 18;
            // 
            // btnCozinhar
            // 
            this.btnCozinhar.Location = new System.Drawing.Point(434, 170);
            this.btnCozinhar.Name = "btnCozinhar";
            this.btnCozinhar.Size = new System.Drawing.Size(75, 38);
            this.btnCozinhar.TabIndex = 13;
            this.btnCozinhar.Text = "Cozinhar";
            this.btnCozinhar.UseVisualStyleBackColor = true;
            this.btnCozinhar.Click += new System.EventHandler(this.btnCozinhar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgProgramas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 165);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir Selecionados";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProgramaNovo);
            this.groupBox1.Controls.Add(this.txtProgramaTempo);
            this.groupBox1.Controls.Add(this.txtProgramaChar);
            this.groupBox1.Controls.Add(this.txtProgramaInstrucao);
            this.groupBox1.Controls.Add(this.txtProgramaNome);
            this.groupBox1.Controls.Add(this.txtProgramaPotencia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo programa";
            // 
            // btnProgramaNovo
            // 
            this.btnProgramaNovo.Location = new System.Drawing.Point(421, 74);
            this.btnProgramaNovo.Name = "btnProgramaNovo";
            this.btnProgramaNovo.Size = new System.Drawing.Size(75, 23);
            this.btnProgramaNovo.TabIndex = 15;
            this.btnProgramaNovo.Text = "Salvar";
            this.btnProgramaNovo.UseVisualStyleBackColor = true;
            this.btnProgramaNovo.Click += new System.EventHandler(this.btnProgramaNovo_Click);
            // 
            // txtProgramaTempo
            // 
            this.txtProgramaTempo.CustomFormat = "mm:ss";
            this.txtProgramaTempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtProgramaTempo.Location = new System.Drawing.Point(6, 77);
            this.txtProgramaTempo.Name = "txtProgramaTempo";
            this.txtProgramaTempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProgramaTempo.ShowUpDown = true;
            this.txtProgramaTempo.Size = new System.Drawing.Size(112, 20);
            this.txtProgramaTempo.TabIndex = 13;
            this.txtProgramaTempo.Value = new System.DateTime(2018, 5, 30, 0, 0, 30, 0);
            // 
            // txtProgramaChar
            // 
            this.txtProgramaChar.Location = new System.Drawing.Point(254, 77);
            this.txtProgramaChar.Name = "txtProgramaChar";
            this.txtProgramaChar.Size = new System.Drawing.Size(105, 20);
            this.txtProgramaChar.TabIndex = 15;
            // 
            // txtProgramaInstrucao
            // 
            this.txtProgramaInstrucao.Location = new System.Drawing.Point(254, 32);
            this.txtProgramaInstrucao.Name = "txtProgramaInstrucao";
            this.txtProgramaInstrucao.Size = new System.Drawing.Size(242, 20);
            this.txtProgramaInstrucao.TabIndex = 12;
            // 
            // txtProgramaNome
            // 
            this.txtProgramaNome.Location = new System.Drawing.Point(6, 32);
            this.txtProgramaNome.Name = "txtProgramaNome";
            this.txtProgramaNome.Size = new System.Drawing.Size(242, 20);
            this.txtProgramaNome.TabIndex = 11;
            // 
            // txtProgramaPotencia
            // 
            this.txtProgramaPotencia.Location = new System.Drawing.Point(124, 77);
            this.txtProgramaPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtProgramaPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtProgramaPotencia.Name = "txtProgramaPotencia";
            this.txtProgramaPotencia.Size = new System.Drawing.Size(124, 20);
            this.txtProgramaPotencia.TabIndex = 14;
            this.txtProgramaPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Instrução de uso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Potencia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Caractere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tempo";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(7, 134);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(242, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pesquisar programa";
            // 
            // dgProgramas
            // 
            this.dgProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramas.Location = new System.Drawing.Point(6, 194);
            this.dgProgramas.Name = "dgProgramas";
            this.dgProgramas.ReadOnly = true;
            this.dgProgramas.Size = new System.Drawing.Size(503, 153);
            this.dgProgramas.TabIndex = 0;
            // 
            // opFile
            // 
            this.opFile.FileName = "openFileDialog1";
            this.opFile.Filter = "*.txt|";
            this.opFile.ReadOnlyChecked = true;
            this.opFile.RestoreDirectory = true;
            this.opFile.ShowReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRetomar);
            this.groupBox3.Controls.Add(this.btnParar);
            this.groupBox3.Controls.Add(this.btnPausar);
            this.groupBox3.Location = new System.Drawing.Point(268, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 55);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(6, 26);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(60, 23);
            this.btnPausar.TabIndex = 0;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(175, 26);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(60, 23);
            this.btnParar.TabIndex = 0;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnRetomar
            // 
            this.btnRetomar.Location = new System.Drawing.Point(90, 26);
            this.btnRetomar.Name = "btnRetomar";
            this.btnRetomar.Size = new System.Drawing.Size(60, 23);
            this.btnRetomar.TabIndex = 0;
            this.btnRetomar.Text = "Retomar";
            this.btnRetomar.UseVisualStyleBackColor = true;
            this.btnRetomar.Click += new System.EventHandler(this.btnRetomar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProgramaPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPrato;
        private System.Windows.Forms.Label lbInstrucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPotencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRapido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCozinhar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProgramaNovo;
        private System.Windows.Forms.DateTimePicker txtProgramaTempo;
        private System.Windows.Forms.TextBox txtProgramaChar;
        private System.Windows.Forms.TextBox txtProgramaInstrucao;
        private System.Windows.Forms.TextBox txtProgramaNome;
        private System.Windows.Forms.NumericUpDown txtProgramaPotencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgProgramas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRetomar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
    }
}

