
namespace Capa_Vista_Nominas
{
    partial class frm_gendeducciones
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
            this.dgv_deducciones = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_deducciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_deducciones
            // 
            this.dgv_deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deducciones.Location = new System.Drawing.Point(12, 182);
            this.dgv_deducciones.Name = "dgv_deducciones";
            this.dgv_deducciones.RowHeadersWidth = 51;
            this.dgv_deducciones.RowTemplate.Height = 24;
            this.dgv_deducciones.Size = new System.Drawing.Size(812, 300);
            this.dgv_deducciones.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Capa_Vista_Nominas.Properties.Resources.Actualizar_V2;
            this.btn_actualizar.Location = new System.Drawing.Point(90, 96);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 69);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_deducciones
            // 
            this.btn_deducciones.Image = global::Capa_Vista_Nominas.Properties.Resources.Nuevo_V2;
            this.btn_deducciones.Location = new System.Drawing.Point(12, 96);
            this.btn_deducciones.Name = "btn_deducciones";
            this.btn_deducciones.Size = new System.Drawing.Size(72, 69);
            this.btn_deducciones.TabIndex = 1;
            this.btn_deducciones.UseVisualStyleBackColor = true;
            this.btn_deducciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deducciones";
            // 
            // frm_gendeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_deducciones);
            this.Controls.Add(this.dgv_deducciones);
            this.Name = "frm_gendeducciones";
            this.Text = "Generación Deducciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_deducciones;
        private System.Windows.Forms.Button btn_deducciones;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label1;
    }
}