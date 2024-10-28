
namespace Capa_Vista_OrdenCompra
{
    partial class frm_OrdenCompra
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
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgv_aplicaciones_asignados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones_asignados)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Orden de Compras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Btn_Ayuda.Location = new System.Drawing.Point(590, 86);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(96, 43);
            this.Btn_Ayuda.TabIndex = 30;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(11, 86);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(86, 43);
            this.Btn_agregar.TabIndex = 24;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Btn_reporte.Location = new System.Drawing.Point(326, 86);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(96, 43);
            this.Btn_reporte.TabIndex = 27;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(224, 86);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(87, 43);
            this.btn_borrar.TabIndex = 26;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(116, 86);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(102, 43);
            this.Btn_actualizar.TabIndex = 25;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Dgv_aplicaciones_asignados
            // 
            this.Dgv_aplicaciones_asignados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Dgv_aplicaciones_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aplicaciones_asignados.Location = new System.Drawing.Point(24, 208);
            this.Dgv_aplicaciones_asignados.Name = "Dgv_aplicaciones_asignados";
            this.Dgv_aplicaciones_asignados.RowHeadersWidth = 62;
            this.Dgv_aplicaciones_asignados.RowTemplate.Height = 28;
            this.Dgv_aplicaciones_asignados.Size = new System.Drawing.Size(805, 364);
            this.Dgv_aplicaciones_asignados.TabIndex = 31;
            // 
            // frm_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(841, 666);
            this.Controls.Add(this.Dgv_aplicaciones_asignados);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_agregar);
            this.Name = "frm_OrdenCompra";
            this.Text = "frm_OrdenCompra";
            this.Load += new System.EventHandler(this.frm_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones_asignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.DataGridView Dgv_aplicaciones_asignados;
    }
}