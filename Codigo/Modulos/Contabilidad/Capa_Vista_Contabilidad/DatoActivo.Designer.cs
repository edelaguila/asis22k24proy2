﻿
namespace Capa_Vista_Contabilidad
{
    partial class DatoActivo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndepreci = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 482);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btndepreci
            // 
            this.btndepreci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndepreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndepreci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndepreci.Image = global::Capa_Vista_Contabilidad.Properties.Resources.FULL_DERECHA_V4;
            this.btndepreci.Location = new System.Drawing.Point(630, 36);
            this.btndepreci.Name = "btndepreci";
            this.btndepreci.Size = new System.Drawing.Size(109, 107);
            this.btndepreci.TabIndex = 9;
            this.btndepreci.Text = "Depreciacion";
            this.btndepreci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndepreci.UseVisualStyleBackColor = true;
            this.btndepreci.Click += new System.EventHandler(this.btndepreci_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimprimir.Image = global::Capa_Vista_Contabilidad.Properties.Resources.impresora;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprimir.Location = new System.Drawing.Point(521, 36);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(82, 107);
            this.btnimprimir.TabIndex = 8;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Capa_Vista_Contabilidad.Properties.Resources.EDITAR_V4;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(422, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 107);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Image = global::Capa_Vista_Contabilidad.Properties.Resources.agregar_archivo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(313, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 107);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // DatoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 694);
            this.Controls.Add(this.btndepreci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "DatoActivo";
            this.Text = "DatoActivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndepreci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
    }
}