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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.button3 = new System.Windows.Forms.Button();
         this.btnExcluir = new System.Windows.Forms.Button();
         this.btnIncluir = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(0, -1);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(1003, 465);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.pictureBox2);
         this.tabPage1.Controls.Add(this.button3);
         this.tabPage1.Controls.Add(this.btnExcluir);
         this.tabPage1.Controls.Add(this.btnIncluir);
         this.tabPage1.Controls.Add(this.textBox1);
         this.tabPage1.Controls.Add(this.dataGridView1);
         this.tabPage1.Location = new System.Drawing.Point(4, 24);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(995, 437);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
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
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(303, 16);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 8;
         this.button3.Text = "Alterar";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // btnExcluir
         // 
         this.btnExcluir.Location = new System.Drawing.Point(222, 16);
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(75, 23);
         this.btnExcluir.TabIndex = 7;
         this.btnExcluir.Text = "Excluir";
         this.btnExcluir.UseVisualStyleBackColor = true;
         // 
         // btnIncluir
         // 
         this.btnIncluir.Location = new System.Drawing.Point(141, 16);
         this.btnIncluir.Name = "btnIncluir";
         this.btnIncluir.Size = new System.Drawing.Size(75, 23);
         this.btnIncluir.TabIndex = 6;
         this.btnIncluir.Text = "Incluir";
         this.btnIncluir.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(8, 17);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 23);
         this.textBox1.TabIndex = 5;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
         this.dataGridView1.Location = new System.Drawing.Point(8, 64);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 25;
         this.dataGridView1.Size = new System.Drawing.Size(445, 353);
         this.dataGridView1.TabIndex = 4;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Destino";
         this.Column1.Name = "Column1";
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Distancia";
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Tempo";
         this.Column3.Name = "Column3";
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Custo";
         this.Column4.Name = "Column4";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.pictureBox1);
         this.tabPage2.Location = new System.Drawing.Point(4, 24);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(1188, 646);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(793, 424);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1002, 463);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private TabControl tabControl1;
      private TabPage tabPage1;
      private TabPage tabPage2;
      private PictureBox pictureBox2;
      private Button button3;
      private Button btnExcluir;
      private Button btnIncluir;
      private TextBox textBox1;
      private DataGridView dataGridView1;
      private DataGridViewTextBoxColumn Column1;
      private DataGridViewTextBoxColumn Column2;
      private DataGridViewTextBoxColumn Column3;
      private DataGridViewTextBoxColumn Column4;
      private PictureBox pictureBox1;
   }
}