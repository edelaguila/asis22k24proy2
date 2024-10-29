
namespace Capa_Vista_PercepcionesDeducciones
{
    partial class frm_generaciondeducciones
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
            this.Dgv_gendeducciones = new System.Windows.Forms.DataGridView();
            this.Lbl_deducciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gendeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_gendeducciones
            // 
            this.Dgv_gendeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_gendeducciones.Location = new System.Drawing.Point(34, 106);
            this.Dgv_gendeducciones.Name = "Dgv_gendeducciones";
            this.Dgv_gendeducciones.RowHeadersWidth = 51;
            this.Dgv_gendeducciones.RowTemplate.Height = 24;
            this.Dgv_gendeducciones.Size = new System.Drawing.Size(1128, 411);
            this.Dgv_gendeducciones.TabIndex = 3;
            // 
            // Lbl_deducciones
            // 
            this.Lbl_deducciones.AutoSize = true;
            this.Lbl_deducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deducciones.Location = new System.Drawing.Point(384, 39);
            this.Lbl_deducciones.Name = "Lbl_deducciones";
            this.Lbl_deducciones.Size = new System.Drawing.Size(357, 32);
            this.Lbl_deducciones.TabIndex = 4;
            this.Lbl_deducciones.Text = "Generación Deducciones";
            // 
            // frm_generaciondeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.Lbl_deducciones);
            this.Controls.Add(this.Dgv_gendeducciones);
            this.Name = "frm_generaciondeducciones";
            this.Text = "frm_generaciondeducciones";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gendeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_gendeducciones;
        private System.Windows.Forms.Label Lbl_deducciones;
    }
}