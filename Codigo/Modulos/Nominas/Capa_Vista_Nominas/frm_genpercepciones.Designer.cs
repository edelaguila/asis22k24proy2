
namespace Capa_Vista_Nominas
{
    partial class frm_genpercepciones
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
            this.dgv_percepciones = new System.Windows.Forms.DataGridView();
            this.btn_percepciones = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.lbl_percepciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_percepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_percepciones
            // 
            this.dgv_percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_percepciones.Location = new System.Drawing.Point(12, 177);
            this.dgv_percepciones.Name = "dgv_percepciones";
            this.dgv_percepciones.RowHeadersWidth = 51;
            this.dgv_percepciones.RowTemplate.Height = 24;
            this.dgv_percepciones.Size = new System.Drawing.Size(819, 326);
            this.dgv_percepciones.TabIndex = 0;
            // 
            // btn_percepciones
            // 
            this.btn_percepciones.Image = global::Capa_Vista_Nominas.Properties.Resources.Nuevo_V2;
            this.btn_percepciones.Location = new System.Drawing.Point(12, 85);
            this.btn_percepciones.Name = "btn_percepciones";
            this.btn_percepciones.Size = new System.Drawing.Size(83, 72);
            this.btn_percepciones.TabIndex = 1;
            this.btn_percepciones.UseVisualStyleBackColor = true;
            this.btn_percepciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Capa_Vista_Nominas.Properties.Resources.Actualizar_V2;
            this.btn_actualizar.Location = new System.Drawing.Point(111, 85);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(73, 72);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_percepciones
            // 
            this.lbl_percepciones.AutoSize = true;
            this.lbl_percepciones.Location = new System.Drawing.Point(345, 30);
            this.lbl_percepciones.Name = "lbl_percepciones";
            this.lbl_percepciones.Size = new System.Drawing.Size(91, 16);
            this.lbl_percepciones.TabIndex = 3;
            this.lbl_percepciones.Text = "Percepciones";
            // 
            // frm_genpercepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 515);
            this.Controls.Add(this.lbl_percepciones);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_percepciones);
            this.Controls.Add(this.dgv_percepciones);
            this.Name = "frm_genpercepciones";
            this.Text = "Generación Percepciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_percepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_percepciones;
        private System.Windows.Forms.Button btn_percepciones;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_percepciones;
    }
}