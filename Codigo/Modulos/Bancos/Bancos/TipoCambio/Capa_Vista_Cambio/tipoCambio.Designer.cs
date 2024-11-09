
namespace Capa_Vista_Cambio
{
    partial class tipoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipoCambio));
            this.cboMonedas = new System.Windows.Forms.ComboBox();
            this.dgvTipoCambio = new System.Windows.Forms.DataGridView();
            this.txt_seleccionar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMonedas
            // 
            this.cboMonedas.FormattingEnabled = true;
            this.cboMonedas.Location = new System.Drawing.Point(333, 173);
            this.cboMonedas.Name = "cboMonedas";
            this.cboMonedas.Size = new System.Drawing.Size(139, 23);
            this.cboMonedas.TabIndex = 10;
            // 
            // dgvTipoCambio
            // 
            this.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCambio.Location = new System.Drawing.Point(24, 22);
            this.dgvTipoCambio.Name = "dgvTipoCambio";
            this.dgvTipoCambio.RowHeadersWidth = 51;
            this.dgvTipoCambio.RowTemplate.Height = 24;
            this.dgvTipoCambio.Size = new System.Drawing.Size(278, 288);
            this.dgvTipoCambio.TabIndex = 9;
            // 
            // txt_seleccionar
            // 
            this.txt_seleccionar.AutoSize = true;
            this.txt_seleccionar.Location = new System.Drawing.Point(331, 147);
            this.txt_seleccionar.Name = "txt_seleccionar";
            this.txt_seleccionar.Size = new System.Drawing.Size(144, 16);
            this.txt_seleccionar.TabIndex = 8;
            this.txt_seleccionar.Text = "Seleecionar una moneda";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(432, 220);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(40, 40);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(333, 218);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 42);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.AutoSize = true;
            this.txt_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(330, 59);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(142, 23);
            this.txt_titulo.TabIndex = 11;
            this.txt_titulo.Text = "Tipo de Cambio";
            // 
            // tipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(180)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.cboMonedas);
            this.Controls.Add(this.dgvTipoCambio);
            this.Controls.Add(this.txt_seleccionar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "tipoCambio";
            this.Text = "tipoCambio";
            this.Load += new System.EventHandler(this.tipoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMonedas;
        private System.Windows.Forms.DataGridView dgvTipoCambio;
        private System.Windows.Forms.Label txt_seleccionar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label txt_titulo;
    }
}