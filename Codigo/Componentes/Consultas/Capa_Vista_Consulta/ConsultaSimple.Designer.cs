﻿
namespace Capa_Vista_Consulta
{
    partial class ConsultaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSimple));
            this.dgvConsultar2 = new System.Windows.Forms.DataGridView();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultar2
            // 
            this.dgvConsultar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar2.Location = new System.Drawing.Point(28, 117);
            this.dgvConsultar2.Name = "dgvConsultar2";
            this.dgvConsultar2.RowHeadersWidth = 51;
            this.dgvConsultar2.RowTemplate.Height = 24;
            this.dgvConsultar2.Size = new System.Drawing.Size(866, 247);
            this.dgvConsultar2.TabIndex = 35;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar2.Image")));
            this.btnCancelar2.Location = new System.Drawing.Point(746, 19);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(96, 79);
            this.btnCancelar2.TabIndex = 38;
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click_1);
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.FlatAppearance.BorderSize = 0;
            this.btnConsultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar2.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar2.Image")));
            this.btnConsultar2.Location = new System.Drawing.Point(609, 19);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(105, 79);
            this.btnConsultar2.TabIndex = 36;
            this.btnConsultar2.UseVisualStyleBackColor = true;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Operación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(366, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(190, 26);
            this.txtValor.TabIndex = 42;
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(28, 69);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(163, 27);
            this.cboCampo.TabIndex = 43;
            // 
            // cboOperador
            // 
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Location = new System.Drawing.Point(232, 69);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(79, 27);
            this.cboOperador.TabIndex = 44;
            // 
            // ConsultaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 384);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultar2);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnConsultar2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConsultaSimple";
            this.Text = "ConsultaSimple";
            this.Load += new System.EventHandler(this.ConsultaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultar2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboOperador;
    }
}