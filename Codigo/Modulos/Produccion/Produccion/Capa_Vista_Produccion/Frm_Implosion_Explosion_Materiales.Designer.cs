﻿
namespace Capa_Vista_Produccion
{
    partial class Frm_Implosion_Explosion_Materiales
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
            this.Btn_Implosion = new System.Windows.Forms.Button();
            this.Btn_Explosion = new System.Windows.Forms.Button();
            this.cmb_implosion = new System.Windows.Forms.ComboBox();
            this.cmb_explosion = new System.Windows.Forms.ComboBox();
            this.txt_cantidad_ex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_implosion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Implosion
            // 
            this.Btn_Implosion.Location = new System.Drawing.Point(19, 55);
            this.Btn_Implosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Implosion.Name = "Btn_Implosion";
            this.Btn_Implosion.Size = new System.Drawing.Size(67, 32);
            this.Btn_Implosion.TabIndex = 0;
            this.Btn_Implosion.Text = "Implosion";
            this.Btn_Implosion.UseVisualStyleBackColor = true;
            this.Btn_Implosion.Click += new System.EventHandler(this.Btn_Implosion_Click);
            // 
            // Btn_Explosion
            // 
            this.Btn_Explosion.Location = new System.Drawing.Point(202, 55);
            this.Btn_Explosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Explosion.Name = "Btn_Explosion";
            this.Btn_Explosion.Size = new System.Drawing.Size(67, 32);
            this.Btn_Explosion.TabIndex = 1;
            this.Btn_Explosion.Text = "Explosion";
            this.Btn_Explosion.UseVisualStyleBackColor = true;
            this.Btn_Explosion.Click += new System.EventHandler(this.Btn_Explosion_Click);
            // 
            // cmb_implosion
            // 
            this.cmb_implosion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_implosion.FormattingEnabled = true;
            this.cmb_implosion.Location = new System.Drawing.Point(19, 135);
            this.cmb_implosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_implosion.Name = "cmb_implosion";
            this.cmb_implosion.Size = new System.Drawing.Size(132, 21);
            this.cmb_implosion.TabIndex = 2;
            // 
            // cmb_explosion
            // 
            this.cmb_explosion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_explosion.FormattingEnabled = true;
            this.cmb_explosion.Location = new System.Drawing.Point(202, 135);
            this.cmb_explosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_explosion.Name = "cmb_explosion";
            this.cmb_explosion.Size = new System.Drawing.Size(132, 21);
            this.cmb_explosion.TabIndex = 3;
            // 
            // txt_cantidad_ex
            // 
            this.txt_cantidad_ex.Location = new System.Drawing.Point(202, 183);
            this.txt_cantidad_ex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cantidad_ex.Name = "txt_cantidad_ex";
            this.txt_cantidad_ex.Size = new System.Drawing.Size(132, 20);
            this.txt_cantidad_ex.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Materia Prima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto Terminado";
            // 
            // txt_cantidad_implosion
            // 
            this.txt_cantidad_implosion.Location = new System.Drawing.Point(19, 183);
            this.txt_cantidad_implosion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad_implosion.Name = "txt_cantidad_implosion";
            this.txt_cantidad_implosion.Size = new System.Drawing.Size(132, 20);
            this.txt_cantidad_implosion.TabIndex = 10;
            // 
            // Frm_Implosion_Explosion_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 226);
            this.Controls.Add(this.txt_cantidad_implosion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad_ex);
            this.Controls.Add(this.cmb_explosion);
            this.Controls.Add(this.cmb_implosion);
            this.Controls.Add(this.Btn_Explosion);
            this.Controls.Add(this.Btn_Implosion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Implosion_Explosion_Materiales";
            this.Text = "Frm_Implosion_Explosion_Materiales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Implosion;
        private System.Windows.Forms.Button Btn_Explosion;
        private System.Windows.Forms.ComboBox cmb_implosion;
        private System.Windows.Forms.ComboBox cmb_explosion;
        private System.Windows.Forms.TextBox txt_cantidad_ex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantidad_implosion;
    }
}