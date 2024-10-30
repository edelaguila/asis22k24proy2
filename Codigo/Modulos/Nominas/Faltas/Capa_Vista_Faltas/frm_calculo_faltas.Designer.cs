
namespace Capa_Vista_Faltas
{
    partial class frm_calculo_faltas
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
            this.Btn_Calculo_Falta = new System.Windows.Forms.Button();
            this.Cbo_Empleados = new System.Windows.Forms.ComboBox();
            this.Dgv_Faltas = new System.Windows.Forms.DataGridView();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Faltas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Calculo_Falta
            // 
            this.Btn_Calculo_Falta.Location = new System.Drawing.Point(81, 170);
            this.Btn_Calculo_Falta.Name = "Btn_Calculo_Falta";
            this.Btn_Calculo_Falta.Size = new System.Drawing.Size(190, 23);
            this.Btn_Calculo_Falta.TabIndex = 0;
            this.Btn_Calculo_Falta.Text = "Calcular faltas";
            this.Btn_Calculo_Falta.UseVisualStyleBackColor = true;
            this.Btn_Calculo_Falta.Click += new System.EventHandler(this.Btn_Calculo_Falta_Click_1);
            // 
            // Cbo_Empleados
            // 
            this.Cbo_Empleados.FormattingEnabled = true;
            this.Cbo_Empleados.Location = new System.Drawing.Point(95, 51);
            this.Cbo_Empleados.Name = "Cbo_Empleados";
            this.Cbo_Empleados.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Empleados.TabIndex = 1;
            this.Cbo_Empleados.SelectedIndexChanged += new System.EventHandler(this.Cbo_Empleados_SelectedIndexChanged);
            // 
            // Dgv_Faltas
            // 
            this.Dgv_Faltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Faltas.Location = new System.Drawing.Point(12, 241);
            this.Dgv_Faltas.Name = "Dgv_Faltas";
            this.Dgv_Faltas.RowHeadersWidth = 51;
            this.Dgv_Faltas.RowTemplate.Height = 24;
            this.Dgv_Faltas.Size = new System.Drawing.Size(1076, 197);
            this.Dgv_Faltas.TabIndex = 2;
            this.Dgv_Faltas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Faltas_CellContentClick);
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Location = new System.Drawing.Point(267, 49);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Mes.TabIndex = 3;
            // 
            // frm_calculo_faltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.Cbo_Mes);
            this.Controls.Add(this.Dgv_Faltas);
            this.Controls.Add(this.Cbo_Empleados);
            this.Controls.Add(this.Btn_Calculo_Falta);
            this.Name = "frm_calculo_faltas";
            this.Text = "frm_calculo_faltas";
            this.Load += new System.EventHandler(this.frm_calculo_faltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Faltas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calculo_Falta;
        private System.Windows.Forms.ComboBox Cbo_Empleados;
        private System.Windows.Forms.DataGridView Dgv_Faltas;
        private System.Windows.Forms.ComboBox Cbo_Mes;
    }
}