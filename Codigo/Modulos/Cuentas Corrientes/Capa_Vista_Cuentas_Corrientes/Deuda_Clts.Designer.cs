
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Deuda_Clts
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
            this.Txt_id_pago_deuda = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_id_pago_deuda = new System.Windows.Forms.Label();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Txt_id_cobrador_deuda = new System.Windows.Forms.TextBox();
            this.Txt_id_clt_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_cobra_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_clt_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_id_pago_deuda
            // 
            this.Txt_id_pago_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_pago_deuda.Location = new System.Drawing.Point(264, 223);
            this.Txt_id_pago_deuda.Name = "Txt_id_pago_deuda";
            this.Txt_id_pago_deuda.Size = new System.Drawing.Size(279, 26);
            this.Txt_id_pago_deuda.TabIndex = 57;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(265, 255);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(279, 26);
            this.Txt_direccion.TabIndex = 56;
            // 
            // Lbl_id_pago_deuda
            // 
            this.Lbl_id_pago_deuda.AutoSize = true;
            this.Lbl_id_pago_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_pago_deuda.Location = new System.Drawing.Point(74, 221);
            this.Lbl_id_pago_deuda.Name = "Lbl_id_pago_deuda";
            this.Lbl_id_pago_deuda.Size = new System.Drawing.Size(55, 18);
            this.Lbl_id_pago_deuda.TabIndex = 55;
            this.Lbl_id_pago_deuda.Text = "Id Pago:";
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(74, 257);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(108, 18);
            this.Lbl_monto_dueda.TabIndex = 54;
            this.Lbl_monto_dueda.Text = "Monto de Deuda:";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.Location = new System.Drawing.Point(265, 383);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 21);
            this.Cbo_estado.TabIndex = 53;
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(265, 118);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(202, 26);
            this.Txt_id_deuda.TabIndex = 52;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(74, 122);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(64, 18);
            this.Lbl_id_deuda.TabIndex = 51;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(74, 292);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(122, 18);
            this.Lbl_inicio_deuda.TabIndex = 49;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Txt_id_cobrador_deuda
            // 
            this.Txt_id_cobrador_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_cobrador_deuda.Location = new System.Drawing.Point(265, 191);
            this.Txt_id_cobrador_deuda.Name = "Txt_id_cobrador_deuda";
            this.Txt_id_cobrador_deuda.Size = new System.Drawing.Size(279, 26);
            this.Txt_id_cobrador_deuda.TabIndex = 48;
            // 
            // Txt_id_clt_deuda
            // 
            this.Txt_id_clt_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_clt_deuda.Location = new System.Drawing.Point(265, 154);
            this.Txt_id_clt_deuda.Name = "Txt_id_clt_deuda";
            this.Txt_id_clt_deuda.Size = new System.Drawing.Size(279, 26);
            this.Txt_id_clt_deuda.TabIndex = 47;
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(74, 323);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(164, 18);
            this.Lbl_vencimiento_deuda.TabIndex = 46;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_cobra_deuda
            // 
            this.Lbl_id_cobra_deuda.AutoSize = true;
            this.Lbl_id_cobra_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_cobra_deuda.Location = new System.Drawing.Point(74, 191);
            this.Lbl_id_cobra_deuda.Name = "Lbl_id_cobra_deuda";
            this.Lbl_id_cobra_deuda.Size = new System.Drawing.Size(84, 18);
            this.Lbl_id_cobra_deuda.TabIndex = 45;
            this.Lbl_id_cobra_deuda.Text = "Id Cobrador:";
            // 
            // Lbl_id_clt_deuda
            // 
            this.Lbl_id_clt_deuda.AutoSize = true;
            this.Lbl_id_clt_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_deuda.Location = new System.Drawing.Point(74, 154);
            this.Lbl_id_clt_deuda.Name = "Lbl_id_clt_deuda";
            this.Lbl_id_clt_deuda.Size = new System.Drawing.Size(71, 18);
            this.Lbl_id_clt_deuda.TabIndex = 44;
            this.Lbl_id_clt_deuda.Text = "Id Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "DEUDAS - CLIENTES -\r\n";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(74, 386);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(123, 18);
            this.Lbl_estado_deuda.TabIndex = 61;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(74, 355);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(153, 18);
            this.Lbl_descrip_deuda.TabIndex = 62;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 289);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 323);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(279, 20);
            this.dateTimePicker2.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 26);
            this.textBox1.TabIndex = 65;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(340, 461);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 75;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(84, 461);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 74;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(472, 461);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(113, 35);
            this.Btn_eliminar.TabIndex = 73;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(212, 461);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 71;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Deuda_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Lbl_descrip_deuda);
            this.Controls.Add(this.Lbl_estado_deuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_id_pago_deuda);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.Lbl_id_pago_deuda);
            this.Controls.Add(this.Lbl_monto_dueda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_deuda);
            this.Controls.Add(this.Lbl_id_deuda);
            this.Controls.Add(this.Lbl_inicio_deuda);
            this.Controls.Add(this.Txt_id_cobrador_deuda);
            this.Controls.Add(this.Txt_id_clt_deuda);
            this.Controls.Add(this.Lbl_vencimiento_deuda);
            this.Controls.Add(this.Lbl_id_cobra_deuda);
            this.Controls.Add(this.Lbl_id_clt_deuda);
            this.Name = "Deuda_Clts";
            this.Text = "Deuda_Clts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_id_pago_deuda;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Lbl_id_pago_deuda;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.TextBox Txt_id_cobrador_deuda;
        private System.Windows.Forms.TextBox Txt_id_clt_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_cobra_deuda;
        private System.Windows.Forms.Label Lbl_id_clt_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
    }
}