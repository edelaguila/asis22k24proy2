
namespace Capa_Vista_Banco
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipo_Cambio = new System.Windows.Forms.Button();
            this.mov_Bancario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navegador1 = new Capa_Vista_Navegador.Navegador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODULO BANCOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tipo_Cambio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mov_Bancario);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 755);
            this.panel1.TabIndex = 3;
            // 
            // tipo_Cambio
            // 
            this.tipo_Cambio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_Cambio.Location = new System.Drawing.Point(15, 111);
            this.tipo_Cambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipo_Cambio.Name = "tipo_Cambio";
            this.tipo_Cambio.Size = new System.Drawing.Size(232, 53);
            this.tipo_Cambio.TabIndex = 1;
            this.tipo_Cambio.Text = "Tipo De Cambio";
            this.tipo_Cambio.UseVisualStyleBackColor = true;
            this.tipo_Cambio.Click += new System.EventHandler(this.tipo_Cambio_Click);
            // 
            // mov_Bancario
            // 
            this.mov_Bancario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_Bancario.Location = new System.Drawing.Point(15, 50);
            this.mov_Bancario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mov_Bancario.Name = "mov_Bancario";
            this.mov_Bancario.Size = new System.Drawing.Size(232, 53);
            this.mov_Bancario.TabIndex = 0;
            this.mov_Bancario.Text = "Movimientos Bancarios";
            this.mov_Bancario.UseVisualStyleBackColor = true;
            this.mov_Bancario.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.navegador1);
            this.panel2.Location = new System.Drawing.Point(263, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 755);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Banco.Properties.Resources._40707911_f9d4_4dc7_a749_147547a6a776;
            this.pictureBox1.Location = new System.Drawing.Point(25, 603);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1110, 755);
            this.navegador1.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tipo_Cambio;
        private System.Windows.Forms.Button mov_Bancario;
        private System.Windows.Forms.Panel panel2;
        private Capa_Vista_Navegador.Navegador navegador1;
    }
}