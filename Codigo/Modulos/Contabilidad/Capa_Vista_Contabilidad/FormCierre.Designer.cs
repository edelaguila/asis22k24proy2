﻿
namespace Capa_Vista_Contabilidad
{
    partial class FormCierre
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
            this.cierre1 = new Capa_Vista_CierreContable.Cierre();
            this.SuspendLayout();
            // 
            // cierre1
            // 
            this.cierre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cierre1.Location = new System.Drawing.Point(0, 0);
            this.cierre1.Name = "cierre1";
            this.cierre1.Size = new System.Drawing.Size(1079, 610);
            this.cierre1.TabIndex = 0;
            this.cierre1.Load += new System.EventHandler(this.cierre1_Load);
            // 
            // FormCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 610);
            this.Controls.Add(this.cierre1);
            this.Name = "FormCierre";
            this.Text = "FormCierre";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_CierreContable.Cierre cierre1;
    }
}