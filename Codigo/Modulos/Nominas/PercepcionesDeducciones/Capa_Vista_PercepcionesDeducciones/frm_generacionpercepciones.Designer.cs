
namespace Capa_Vista_PercepcionesDeducciones
{
    partial class frm_generacionpercepciones
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
            this.Lbl_percepciones = new System.Windows.Forms.Label();
            this.Dgv_genpercepciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_genpercepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_percepciones
            // 
            this.Lbl_percepciones.AutoSize = true;
            this.Lbl_percepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_percepciones.Location = new System.Drawing.Point(388, 28);
            this.Lbl_percepciones.Name = "Lbl_percepciones";
            this.Lbl_percepciones.Size = new System.Drawing.Size(366, 32);
            this.Lbl_percepciones.TabIndex = 0;
            this.Lbl_percepciones.Text = "Generación Percepciones";
            // 
            // Dgv_genpercepciones
            // 
            this.Dgv_genpercepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_genpercepciones.Location = new System.Drawing.Point(24, 104);
            this.Dgv_genpercepciones.Name = "Dgv_genpercepciones";
            this.Dgv_genpercepciones.RowHeadersWidth = 51;
            this.Dgv_genpercepciones.RowTemplate.Height = 24;
            this.Dgv_genpercepciones.Size = new System.Drawing.Size(1128, 411);
            this.Dgv_genpercepciones.TabIndex = 1;
            // 
            // frm_generacionpercepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.Dgv_genpercepciones);
            this.Controls.Add(this.Lbl_percepciones);
            this.Name = "frm_generacionpercepciones";
            this.Text = "frm_generacionpercepciones";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_genpercepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_percepciones;
        private System.Windows.Forms.DataGridView Dgv_genpercepciones;
    }
}