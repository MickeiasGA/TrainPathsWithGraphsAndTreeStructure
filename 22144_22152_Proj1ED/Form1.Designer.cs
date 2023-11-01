namespace _22144_22152_Proj1ED
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMapa = new System.Windows.Forms.TabPage();
            this.tcReader = new System.Windows.Forms.TabControl();
            this.tpCidades = new System.Windows.Forms.TabPage();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpGrafos = new System.Windows.Forms.TabPage();
            this.dgvGrafos = new System.Windows.Forms.DataGridView();
            this.columnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.la = new System.ComponentModel.BackgroundWorker();
            this.ofdCidades = new System.Windows.Forms.OpenFileDialog();
            this.tcMain.SuspendLayout();
            this.tpMapa.SuspendLayout();
            this.tcReader.SuspendLayout();
            this.tpCidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.tpGrafos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpMapa);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(0, -1);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1003, 465);
            this.tcMain.TabIndex = 0;
            // 
            // tpMapa
            // 
            this.tpMapa.Controls.Add(this.tcReader);
            this.tpMapa.Controls.Add(this.pictureBox2);
            this.tpMapa.Controls.Add(this.btnAlterar);
            this.tpMapa.Controls.Add(this.btnExcluir);
            this.tpMapa.Controls.Add(this.btnIncluir);
            this.tpMapa.Controls.Add(this.textBox1);
            this.tpMapa.Location = new System.Drawing.Point(4, 24);
            this.tpMapa.Name = "tpMapa";
            this.tpMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tpMapa.Size = new System.Drawing.Size(995, 437);
            this.tpMapa.TabIndex = 0;
            this.tpMapa.Text = "Mapa";
            this.tpMapa.UseVisualStyleBackColor = true;
            // 
            // tcReader
            // 
            this.tcReader.Controls.Add(this.tpCidades);
            this.tcReader.Controls.Add(this.tpGrafos);
            this.tcReader.Location = new System.Drawing.Point(8, 59);
            this.tcReader.Name = "tcReader";
            this.tcReader.SelectedIndex = 0;
            this.tcReader.Size = new System.Drawing.Size(454, 364);
            this.tcReader.TabIndex = 10;
            // 
            // tpCidades
            // 
            this.tpCidades.Controls.Add(this.dgvCidades);
            this.tpCidades.Location = new System.Drawing.Point(4, 24);
            this.tpCidades.Name = "tpCidades";
            this.tpCidades.Padding = new System.Windows.Forms.Padding(3);
            this.tpCidades.Size = new System.Drawing.Size(446, 336);
            this.tpCidades.TabIndex = 0;
            this.tpCidades.Text = "Cidades";
            this.tpCidades.UseVisualStyleBackColor = true;
            // 
            // dgvCidades
            // 
            this.dgvCidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNome,
            this.columnX,
            this.columnY});
            this.dgvCidades.Location = new System.Drawing.Point(3, 0);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.RowHeadersWidth = 60;
            this.dgvCidades.RowTemplate.Height = 25;
            this.dgvCidades.Size = new System.Drawing.Size(443, 336);
            this.dgvCidades.TabIndex = 0;
            // 
            // columnNome
            // 
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            // 
            // columnX
            // 
            this.columnX.HeaderText = "X";
            this.columnX.Name = "columnX";
            // 
            // columnY
            // 
            this.columnY.HeaderText = "Y";
            this.columnY.Name = "columnY";
            // 
            // tpGrafos
            // 
            this.tpGrafos.Controls.Add(this.dgvGrafos);
            this.tpGrafos.Location = new System.Drawing.Point(4, 24);
            this.tpGrafos.Name = "tpGrafos";
            this.tpGrafos.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafos.Size = new System.Drawing.Size(446, 336);
            this.tpGrafos.TabIndex = 1;
            this.tpGrafos.Text = "Caminhos";
            this.tpGrafos.UseVisualStyleBackColor = true;
            // 
            // dgvGrafos
            // 
            this.dgvGrafos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrafos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDestino,
            this.columnDistancia,
            this.columnTempo,
            this.columnCusto});
            this.dgvGrafos.Location = new System.Drawing.Point(6, 6);
            this.dgvGrafos.Name = "dgvGrafos";
            this.dgvGrafos.RowTemplate.Height = 25;
            this.dgvGrafos.Size = new System.Drawing.Size(434, 324);
            this.dgvGrafos.TabIndex = 5;
            // 
            // columnDestino
            // 
            this.columnDestino.HeaderText = "Destino";
            this.columnDestino.Name = "columnDestino";
            // 
            // columnDistancia
            // 
            this.columnDistancia.HeaderText = "Distancia";
            this.columnDistancia.Name = "columnDistancia";
            // 
            // columnTempo
            // 
            this.columnTempo.HeaderText = "Tempo";
            this.columnTempo.Name = "columnTempo";
            // 
            // columnCusto
            // 
            this.columnCusto.HeaderText = "Custo";
            this.columnCusto.Name = "columnCusto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(468, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 420);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(303, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(222, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(141, 16);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = ".";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 428);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ofdCidades
            // 
            this.ofdCidades.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 463);
            this.Controls.Add(this.tcMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpMapa.ResumeLayout(false);
            this.tpMapa.PerformLayout();
            this.tcReader.ResumeLayout(false);
            this.tpCidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.tpGrafos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private TabControl tcMain;
      private TabPage tpMapa;
      private TabPage tabPage2;
      private PictureBox pictureBox2;
      private Button btnAlterar;
      private Button btnExcluir;
      private Button btnIncluir;
      private TextBox textBox1;
      private PictureBox pictureBox1;
        private TabControl tcReader;
        private TabPage tpCidades;
        private DataGridView dgvCidades;
        private TabPage tpGrafos;
        private DataGridView dgvGrafos;
        private System.ComponentModel.BackgroundWorker la;
        private DataGridViewTextBoxColumn columnNome;
        private DataGridViewTextBoxColumn columnX;
        private DataGridViewTextBoxColumn columnY;
        private DataGridViewTextBoxColumn columnDestino;
        private DataGridViewTextBoxColumn columnDistancia;
        private DataGridViewTextBoxColumn columnTempo;
        private DataGridViewTextBoxColumn columnCusto;
        private OpenFileDialog ofdCidades;
    }
}