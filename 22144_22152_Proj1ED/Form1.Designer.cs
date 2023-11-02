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
            tcMain = new TabControl();
            tabMapa = new TabPage();
            btnExibir = new Button();
            tcReader = new TabControl();
            tpCidades = new TabPage();
            dgvCidades = new DataGridView();
            columnNome = new DataGridViewTextBoxColumn();
            columnX = new DataGridViewTextBoxColumn();
            columnY = new DataGridViewTextBoxColumn();
            tpGrafos = new TabPage();
            dgvGrafos = new DataGridView();
            columnDestino = new DataGridViewTextBoxColumn();
            columnDistancia = new DataGridViewTextBoxColumn();
            columnTempo = new DataGridViewTextBoxColumn();
            columnCusto = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnIncluir = new Button();
            txtNome = new TextBox();
            tabArvore = new TabPage();
            pictureBox1 = new PictureBox();
            la = new System.ComponentModel.BackgroundWorker();
            ofdCidades = new OpenFileDialog();
            tcMain.SuspendLayout();
            tabMapa.SuspendLayout();
            tcReader.SuspendLayout();
            tpCidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCidades).BeginInit();
            tpGrafos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrafos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabArvore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcMain.Controls.Add(tabMapa);
            tcMain.Controls.Add(tabArvore);
            tcMain.Location = new Point(0, -1);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(1003, 465);
            tcMain.TabIndex = 0;
            // 
            // tabMapa
            // 
            tabMapa.Controls.Add(btnExibir);
            tabMapa.Controls.Add(tcReader);
            tabMapa.Controls.Add(pictureBox2);
            tabMapa.Controls.Add(btnAlterar);
            tabMapa.Controls.Add(btnExcluir);
            tabMapa.Controls.Add(btnIncluir);
            tabMapa.Controls.Add(txtNome);
            tabMapa.Location = new Point(4, 24);
            tabMapa.Name = "tabMapa";
            tabMapa.Padding = new Padding(3);
            tabMapa.Size = new Size(995, 437);
            tabMapa.TabIndex = 0;
            tabMapa.Text = "Mapa";
            tabMapa.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(383, 16);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(75, 23);
            btnExibir.TabIndex = 11;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // tcReader
            // 
            tcReader.Controls.Add(tpCidades);
            tcReader.Controls.Add(tpGrafos);
            tcReader.Location = new Point(8, 59);
            tcReader.Name = "tcReader";
            tcReader.SelectedIndex = 0;
            tcReader.Size = new Size(454, 364);
            tcReader.TabIndex = 10;
            // 
            // tpCidades
            // 
            tpCidades.Controls.Add(dgvCidades);
            tpCidades.Location = new Point(4, 24);
            tpCidades.Name = "tpCidades";
            tpCidades.Padding = new Padding(3);
            tpCidades.Size = new Size(446, 336);
            tpCidades.TabIndex = 0;
            tpCidades.Text = "Cidades";
            tpCidades.UseVisualStyleBackColor = true;
            // 
            // dgvCidades
            // 
            dgvCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCidades.Columns.AddRange(new DataGridViewColumn[] { columnNome, columnX, columnY });
            dgvCidades.Location = new Point(3, 0);
            dgvCidades.Name = "dgvCidades";
            dgvCidades.RowHeadersWidth = 60;
            dgvCidades.RowTemplate.Height = 25;
            dgvCidades.Size = new Size(443, 336);
            dgvCidades.TabIndex = 0;
            // 
            // columnNome
            // 
            columnNome.HeaderText = "Nome";
            columnNome.Name = "columnNome";
            // 
            // columnX
            // 
            columnX.HeaderText = "X";
            columnX.Name = "columnX";
            // 
            // columnY
            // 
            columnY.HeaderText = "Y";
            columnY.Name = "columnY";
            // 
            // tpGrafos
            // 
            tpGrafos.Controls.Add(dgvGrafos);
            tpGrafos.Location = new Point(4, 24);
            tpGrafos.Name = "tpGrafos";
            tpGrafos.Padding = new Padding(3);
            tpGrafos.Size = new Size(446, 336);
            tpGrafos.TabIndex = 1;
            tpGrafos.Text = "Caminhos";
            tpGrafos.UseVisualStyleBackColor = true;
            // 
            // dgvGrafos
            // 
            dgvGrafos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrafos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrafos.Columns.AddRange(new DataGridViewColumn[] { columnDestino, columnDistancia, columnTempo, columnCusto });
            dgvGrafos.Location = new Point(6, 6);
            dgvGrafos.Name = "dgvGrafos";
            dgvGrafos.RowTemplate.Height = 25;
            dgvGrafos.Size = new Size(434, 324);
            dgvGrafos.TabIndex = 5;
            // 
            // columnDestino
            // 
            columnDestino.HeaderText = "Destino";
            columnDestino.Name = "columnDestino";
            // 
            // columnDistancia
            // 
            columnDistancia.HeaderText = "Distancia";
            columnDistancia.Name = "columnDistancia";
            // 
            // columnTempo
            // 
            columnTempo.HeaderText = "Tempo";
            columnTempo.Name = "columnTempo";
            // 
            // columnCusto
            // 
            columnCusto.HeaderText = "Custo";
            columnCusto.Name = "columnCusto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(521, 420);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.Paint += pictureBox2_Paint;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(303, 16);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(222, 16);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(141, 16);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 6;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // tabArvore
            // 
            tabArvore.Controls.Add(pictureBox1);
            tabArvore.Location = new Point(4, 24);
            tabArvore.Name = "tabArvore";
            tabArvore.Padding = new Padding(3);
            tabArvore.Size = new Size(995, 437);
            tabArvore.TabIndex = 1;
            tabArvore.Text = "Arvore";
            tabArvore.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(995, 428);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // ofdCidades
            // 
            ofdCidades.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 463);
            Controls.Add(tcMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tcMain.ResumeLayout(false);
            tabMapa.ResumeLayout(false);
            tabMapa.PerformLayout();
            tcReader.ResumeLayout(false);
            tpCidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCidades).EndInit();
            tpGrafos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrafos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabArvore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tabMapa;
        private TabPage tabArvore;
        private PictureBox pictureBox2;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnIncluir;
        private TextBox txtNome;
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
        private Button btnExibir;
    }
}