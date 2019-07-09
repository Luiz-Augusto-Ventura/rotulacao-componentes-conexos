namespace TrabalhoRuidos
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnRotulacao = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.labelresultado = new System.Windows.Forms.Label();
            this.btnPeB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioWhite = new System.Windows.Forms.RadioButton();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(21, 25);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(360, 379);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxResultado.Location = new System.Drawing.Point(567, 25);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(360, 379);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResultado.TabIndex = 1;
            this.pictureBoxResultado.TabStop = false;
            // 
            // btnMediana
            // 
            this.btnMediana.Enabled = false;
            this.btnMediana.Location = new System.Drawing.Point(437, 128);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 23);
            this.btnMediana.TabIndex = 2;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnRotulacao
            // 
            this.btnRotulacao.Enabled = false;
            this.btnRotulacao.Location = new System.Drawing.Point(437, 381);
            this.btnRotulacao.Name = "btnRotulacao";
            this.btnRotulacao.Size = new System.Drawing.Size(75, 23);
            this.btnRotulacao.TabIndex = 3;
            this.btnRotulacao.Text = "Rotulação";
            this.btnRotulacao.UseVisualStyleBackColor = true;
            this.btnRotulacao.Click += new System.EventHandler(this.btnRotulacao_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(437, 25);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.Location = new System.Drawing.Point(564, 419);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(81, 16);
            this.labelresultado.TabIndex = 5;
            this.labelresultado.Text = "Quantidade:";
            // 
            // btnPeB
            // 
            this.btnPeB.Enabled = false;
            this.btnPeB.Location = new System.Drawing.Point(426, 77);
            this.btnPeB.Name = "btnPeB";
            this.btnPeB.Size = new System.Drawing.Size(97, 23);
            this.btnPeB.TabIndex = 6;
            this.btnPeB.Text = "Preto e Branco";
            this.btnPeB.UseVisualStyleBackColor = true;
            this.btnPeB.Click += new System.EventHandler(this.btnPeB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.radioWhite);
            this.groupBox1.Controls.Add(this.radioBlack);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(401, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor do objeto";
            // 
            // radioWhite
            // 
            this.radioWhite.AutoSize = true;
            this.radioWhite.Location = new System.Drawing.Point(24, 66);
            this.radioWhite.Name = "radioWhite";
            this.radioWhite.Size = new System.Drawing.Size(64, 19);
            this.radioWhite.TabIndex = 1;
            this.radioWhite.Text = "Branco";
            this.radioWhite.UseVisualStyleBackColor = true;
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.Checked = true;
            this.radioBlack.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBlack.Location = new System.Drawing.Point(24, 28);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(54, 19);
            this.radioBlack.TabIndex = 0;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "Preto";
            this.radioBlack.UseVisualStyleBackColor = true;
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.LargeChange = 25;
            this.trackBarThreshold.Location = new System.Drawing.Point(6, 29);
            this.trackBarThreshold.Maximum = 500;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(133, 45);
            this.trackBarThreshold.SmallChange = 5;
            this.trackBarThreshold.TabIndex = 8;
            this.trackBarThreshold.Scroll += new System.EventHandler(this.trackBarThreshold_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.lblThreshold);
            this.groupBox2.Controls.Add(this.trackBarThreshold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(401, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanho mínimo ";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(65, 77);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(0, 16);
            this.lblThreshold.TabIndex = 9;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargura.Location = new System.Drawing.Point(30, 407);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(0, 15);
            this.lblLargura.TabIndex = 10;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(30, 428);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 15);
            this.lblAltura.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(387, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 420);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPeB);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnRotulacao);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Rotulação de Componentes Conexos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Button btnRotulacao;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label labelresultado;
        private System.Windows.Forms.Button btnPeB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioWhite;
        private System.Windows.Forms.RadioButton radioBlack;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

