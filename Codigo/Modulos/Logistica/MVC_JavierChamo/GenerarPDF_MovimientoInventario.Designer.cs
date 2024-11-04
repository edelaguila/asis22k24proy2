
namespace MVC_JavierChamo
{
    partial class GenerarPDF_MovimientoInventario
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
            this.btn_generarPDFMov = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovimientoInventario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generarPDFMov
            // 
            this.btn_generarPDFMov.Location = new System.Drawing.Point(474, 37);
            this.btn_generarPDFMov.Name = "btn_generarPDFMov";
            this.btn_generarPDFMov.Size = new System.Drawing.Size(152, 23);
            this.btn_generarPDFMov.TabIndex = 12;
            this.btn_generarPDFMov.Text = "Generar PDF";
            this.btn_generarPDFMov.UseVisualStyleBackColor = true;
            this.btn_generarPDFMov.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID de la Solicitud de Movimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Generar PDF de Movimiento";
            // 
            // txtMovimientoInventario
            // 
            this.txtMovimientoInventario.Location = new System.Drawing.Point(307, 39);
            this.txtMovimientoInventario.Name = "txtMovimientoInventario";
            this.txtMovimientoInventario.Size = new System.Drawing.Size(161, 20);
            this.txtMovimientoInventario.TabIndex = 9;
            // 
            // GenerarPDF_MovimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 92);
            this.Controls.Add(this.btn_generarPDFMov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovimientoInventario);
            this.Name = "GenerarPDF_MovimientoInventario";
            this.Text = "GenerarPDF_MovimientoInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generarPDFMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovimientoInventario;
    }
}