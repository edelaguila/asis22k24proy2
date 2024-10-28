
namespace Capa_Vista_Polizas_Prod
{
    partial class Frm_Polizas_Prod
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
            this.lblAbono = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboperacion = new System.Windows.Forms.ComboBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_Cuenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.lbl_tipo_poliza = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cbtipopoliza = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_registar_poliza = new System.Windows.Forms.Button();
            this.btn_nueva_poliza = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(705, 663);
            this.lblAbono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(44, 17);
            this.lblAbono.TabIndex = 33;
            this.lblAbono.Text = "00.00";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(534, 663);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 17);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "00.00";
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Location = new System.Drawing.Point(573, 663);
            this.lbl_abono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(108, 17);
            this.lbl_abono.TabIndex = 30;
            this.lbl_abono.Text = "TOTAL ABONO";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(422, 663);
            this.lbl_cargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(108, 17);
            this.lbl_cargo.TabIndex = 29;
            this.lbl_cargo.Text = "TOTAL CARGO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.dgvPolizas);
            this.groupBox3.Location = new System.Drawing.Point(30, 333);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(788, 304);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de movimiento";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Location = new System.Drawing.Point(694, 25);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 79);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Cargo,
            this.Abono});
            this.dgvPolizas.Location = new System.Drawing.Point(5, 25);
            this.dgvPolizas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.RowHeadersWidth = 51;
            this.dgvPolizas.RowTemplate.Height = 24;
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(671, 266);
            this.dgvPolizas.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.MinimumWidth = 6;
            this.Abono.Name = "Abono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.cboperacion);
            this.groupBox2.Controls.Add(this.cbCuenta);
            this.groupBox2.Controls.Add(this.lbl_Cuenta);
            this.groupBox2.Location = new System.Drawing.Point(30, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(788, 93);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(514, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 41, 0);
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "             Valor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(341, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 34, 0);
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "          Cargo/Abono";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(678, 13);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(82, 76);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(516, 47);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 22);
            this.txtValor.TabIndex = 5;
            // 
            // cboperacion
            // 
            this.cboperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperacion.FormattingEnabled = true;
            this.cboperacion.Location = new System.Drawing.Point(341, 46);
            this.cboperacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboperacion.Name = "cboperacion";
            this.cboperacion.Size = new System.Drawing.Size(133, 24);
            this.cboperacion.TabIndex = 4;
            // 
            // cbCuenta
            // 
            this.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(92, 47);
            this.cbCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(217, 24);
            this.cbCuenta.TabIndex = 3;
            // 
            // lbl_Cuenta
            // 
            this.lbl_Cuenta.AutoSize = true;
            this.lbl_Cuenta.BackColor = System.Drawing.Color.Beige;
            this.lbl_Cuenta.Location = new System.Drawing.Point(90, 23);
            this.lbl_Cuenta.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_Cuenta.Name = "lbl_Cuenta";
            this.lbl_Cuenta.Padding = new System.Windows.Forms.Padding(0, 0, 90, 0);
            this.lbl_Cuenta.Size = new System.Drawing.Size(259, 17);
            this.lbl_Cuenta.TabIndex = 0;
            this.lbl_Cuenta.Text = "                             Cuenta\r\n";
            this.lbl_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.lbl_concepto);
            this.groupBox1.Controls.Add(this.lbl_tipo_poliza);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.cbtipopoliza);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(788, 118);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado poliza";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(109, 76);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(672, 22);
            this.txtConcepto.TabIndex = 5;
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(37, 79);
            this.lbl_concepto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(68, 17);
            this.lbl_concepto.TabIndex = 4;
            this.lbl_concepto.Text = "Concepto";
            // 
            // lbl_tipo_poliza
            // 
            this.lbl_tipo_poliza.AutoSize = true;
            this.lbl_tipo_poliza.Location = new System.Drawing.Point(317, 40);
            this.lbl_tipo_poliza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo_poliza.Name = "lbl_tipo_poliza";
            this.lbl_tipo_poliza.Size = new System.Drawing.Size(97, 17);
            this.lbl_tipo_poliza.TabIndex = 3;
            this.lbl_tipo_poliza.Text = "Tipo de poliza";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(92, 36);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(205, 22);
            this.dtpfecha.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(37, 36);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // cbtipopoliza
            // 
            this.cbtipopoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipopoliza.FormattingEnabled = true;
            this.cbtipopoliza.Location = new System.Drawing.Point(418, 37);
            this.cbtipopoliza.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipopoliza.Name = "cbtipopoliza";
            this.cbtipopoliza.Size = new System.Drawing.Size(189, 24);
            this.cbtipopoliza.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.SALIR_V4;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(765, 37);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 50);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.CANCELAR_V4;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(260, 37);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 50);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_registar_poliza
            // 
            this.btn_registar_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_registar_poliza.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.guardar;
            this.btn_registar_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registar_poliza.Location = new System.Drawing.Point(114, 37);
            this.btn_registar_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registar_poliza.Name = "btn_registar_poliza";
            this.btn_registar_poliza.Size = new System.Drawing.Size(52, 52);
            this.btn_registar_poliza.TabIndex = 28;
            this.btn_registar_poliza.UseVisualStyleBackColor = false;
            this.btn_registar_poliza.Click += new System.EventHandler(this.btn_registar_poliza_Click);
            // 
            // btn_nueva_poliza
            // 
            this.btn_nueva_poliza.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.INGRESAR_V4;
            this.btn_nueva_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva_poliza.Location = new System.Drawing.Point(45, 37);
            this.btn_nueva_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nueva_poliza.Name = "btn_nueva_poliza";
            this.btn_nueva_poliza.Size = new System.Drawing.Size(52, 52);
            this.btn_nueva_poliza.TabIndex = 27;
            this.btn_nueva_poliza.UseVisualStyleBackColor = true;
            this.btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // Frm_Polizas_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 705);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbl_abono);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.btn_registar_poliza);
            this.Controls.Add(this.btn_nueva_poliza);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Polizas_Prod";
            this.Text = "Frm_Polizas_Prod";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Button btn_registar_poliza;
        private System.Windows.Forms.Button btn_nueva_poliza;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboperacion;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.Label lbl_Cuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_tipo_poliza;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cbtipopoliza;
    }
}