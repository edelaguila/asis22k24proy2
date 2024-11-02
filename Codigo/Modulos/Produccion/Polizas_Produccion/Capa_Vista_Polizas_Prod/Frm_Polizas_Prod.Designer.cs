
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Polizas_Prod));
            this.lblAbono = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.gpb_movimiento = new System.Windows.Forms.GroupBox();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_detalle = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboperacion = new System.Windows.Forms.ComboBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_Cuenta = new System.Windows.Forms.Label();
            this.gpb_Encabezado = new System.Windows.Forms.GroupBox();
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
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo_saldo = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.gpb_movimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.gpb_detalle.SuspendLayout();
            this.gpb_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(262, 535);
            this.lblAbono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(34, 13);
            this.lblAbono.TabIndex = 33;
            this.lblAbono.Text = "00.00";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(109, 535);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(34, 13);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "00.00";
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Location = new System.Drawing.Point(163, 535);
            this.lbl_abono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(83, 13);
            this.lbl_abono.TabIndex = 30;
            this.lbl_abono.Text = "TOTAL ABONO";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(25, 535);
            this.lbl_cargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(83, 13);
            this.lbl_cargo.TabIndex = 29;
            this.lbl_cargo.Text = "TOTAL CARGO";
            // 
            // gpb_movimiento
            // 
            this.gpb_movimiento.Controls.Add(this.btnQuitar);
            this.gpb_movimiento.Controls.Add(this.dgvPolizas);
            this.gpb_movimiento.Location = new System.Drawing.Point(22, 271);
            this.gpb_movimiento.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_movimiento.Name = "gpb_movimiento";
            this.gpb_movimiento.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_movimiento.Size = new System.Drawing.Size(591, 247);
            this.gpb_movimiento.TabIndex = 26;
            this.gpb_movimiento.TabStop = false;
            this.gpb_movimiento.Text = "Detalle de movimiento";
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
            this.dgvPolizas.Location = new System.Drawing.Point(4, 20);
            this.dgvPolizas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.RowHeadersWidth = 51;
            this.dgvPolizas.RowTemplate.Height = 24;
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(503, 216);
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
            // gpb_detalle
            // 
            this.gpb_detalle.Controls.Add(this.label2);
            this.gpb_detalle.Controls.Add(this.label1);
            this.gpb_detalle.Controls.Add(this.btn_aceptar);
            this.gpb_detalle.Controls.Add(this.txtValor);
            this.gpb_detalle.Controls.Add(this.cboperacion);
            this.gpb_detalle.Controls.Add(this.cbCuenta);
            this.gpb_detalle.Controls.Add(this.lbl_Cuenta);
            this.gpb_detalle.Location = new System.Drawing.Point(22, 186);
            this.gpb_detalle.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_detalle.Name = "gpb_detalle";
            this.gpb_detalle.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_detalle.Size = new System.Drawing.Size(591, 76);
            this.gpb_detalle.TabIndex = 25;
            this.gpb_detalle.TabStop = false;
            this.gpb_detalle.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(386, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 31, 0);
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "             Valor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(256, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "          Cargo/Abono";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(387, 38);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(83, 20);
            this.txtValor.TabIndex = 5;
            // 
            // cboperacion
            // 
            this.cboperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.cboperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperacion.FormattingEnabled = true;
            this.cboperacion.Location = new System.Drawing.Point(256, 37);
            this.cboperacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboperacion.Name = "cboperacion";
            this.cboperacion.Size = new System.Drawing.Size(101, 21);
            this.cboperacion.TabIndex = 4;
            // 
            // cbCuenta
            // 
            this.cbCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(69, 38);
            this.cbCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(164, 21);
            this.cbCuenta.TabIndex = 3;
            // 
            // lbl_Cuenta
            // 
            this.lbl_Cuenta.AutoSize = true;
            this.lbl_Cuenta.BackColor = System.Drawing.Color.Beige;
            this.lbl_Cuenta.Location = new System.Drawing.Point(68, 19);
            this.lbl_Cuenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbl_Cuenta.Name = "lbl_Cuenta";
            this.lbl_Cuenta.Padding = new System.Windows.Forms.Padding(0, 0, 68, 0);
            this.lbl_Cuenta.Size = new System.Drawing.Size(196, 13);
            this.lbl_Cuenta.TabIndex = 0;
            this.lbl_Cuenta.Text = "                             Cuenta\r\n";
            this.lbl_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpb_Encabezado
            // 
            this.gpb_Encabezado.Controls.Add(this.txtConcepto);
            this.gpb_Encabezado.Controls.Add(this.lbl_concepto);
            this.gpb_Encabezado.Controls.Add(this.lbl_tipo_poliza);
            this.gpb_Encabezado.Controls.Add(this.dtpfecha);
            this.gpb_Encabezado.Controls.Add(this.lbl_fecha);
            this.gpb_Encabezado.Controls.Add(this.cbtipopoliza);
            this.gpb_Encabezado.Location = new System.Drawing.Point(22, 86);
            this.gpb_Encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_Encabezado.Name = "gpb_Encabezado";
            this.gpb_Encabezado.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_Encabezado.Size = new System.Drawing.Size(591, 96);
            this.gpb_Encabezado.TabIndex = 24;
            this.gpb_Encabezado.TabStop = false;
            this.gpb_Encabezado.Text = "Encabezado poliza";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(82, 62);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(505, 20);
            this.txtConcepto.TabIndex = 5;
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(28, 64);
            this.lbl_concepto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(53, 13);
            this.lbl_concepto.TabIndex = 4;
            this.lbl_concepto.Text = "Concepto";
            // 
            // lbl_tipo_poliza
            // 
            this.lbl_tipo_poliza.AutoSize = true;
            this.lbl_tipo_poliza.Location = new System.Drawing.Point(238, 32);
            this.lbl_tipo_poliza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo_poliza.Name = "lbl_tipo_poliza";
            this.lbl_tipo_poliza.Size = new System.Drawing.Size(73, 13);
            this.lbl_tipo_poliza.TabIndex = 3;
            this.lbl_tipo_poliza.Text = "Tipo de poliza";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(69, 29);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(155, 20);
            this.dtpfecha.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(28, 29);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // cbtipopoliza
            // 
            this.cbtipopoliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.cbtipopoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipopoliza.FormattingEnabled = true;
            this.cbtipopoliza.Location = new System.Drawing.Point(314, 30);
            this.cbtipopoliza.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipopoliza.Name = "cbtipopoliza";
            this.cbtipopoliza.Size = new System.Drawing.Size(143, 21);
            this.cbtipopoliza.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btnSalir.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.SALIR_V4;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(574, 30);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 41);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btnCancelar.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.CANCELAR_V4;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(145, 31);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 41);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_registar_poliza
            // 
            this.btn_registar_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_registar_poliza.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.guardar;
            this.btn_registar_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registar_poliza.Location = new System.Drawing.Point(86, 30);
            this.btn_registar_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registar_poliza.Name = "btn_registar_poliza";
            this.btn_registar_poliza.Size = new System.Drawing.Size(39, 42);
            this.btn_registar_poliza.TabIndex = 28;
            this.btn_registar_poliza.UseVisualStyleBackColor = false;
            this.btn_registar_poliza.Click += new System.EventHandler(this.btn_registar_poliza_Click);
            // 
            // btn_nueva_poliza
            // 
            this.btn_nueva_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_nueva_poliza.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.INGRESAR_V4;
            this.btn_nueva_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva_poliza.Location = new System.Drawing.Point(34, 30);
            this.btn_nueva_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nueva_poliza.Name = "btn_nueva_poliza";
            this.btn_nueva_poliza.Size = new System.Drawing.Size(39, 42);
            this.btn_nueva_poliza.TabIndex = 27;
            this.btn_nueva_poliza.UseVisualStyleBackColor = false;
            this.btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btnQuitar.BackgroundImage = global::Capa_Vista_Polizas_Prod.Properties.Resources.rechazado;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Location = new System.Drawing.Point(520, 20);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 64);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(508, 11);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(62, 62);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo_saldo
            // 
            this.lbl_titulo_saldo.AutoSize = true;
            this.lbl_titulo_saldo.Location = new System.Drawing.Point(349, 535);
            this.lbl_titulo_saldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo_saldo.Name = "lbl_titulo_saldo";
            this.lbl_titulo_saldo.Size = new System.Drawing.Size(46, 13);
            this.lbl_titulo_saldo.TabIndex = 35;
            this.lbl_titulo_saldo.Text = "SALDO:";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(428, 535);
            this.lbl_saldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_saldo.TabIndex = 36;
            this.lbl_saldo.Text = "00.00";
            // 
            // Frm_Polizas_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(631, 573);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_titulo_saldo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbl_abono);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.btn_registar_poliza);
            this.Controls.Add(this.btn_nueva_poliza);
            this.Controls.Add(this.gpb_movimiento);
            this.Controls.Add(this.gpb_detalle);
            this.Controls.Add(this.gpb_Encabezado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Polizas_Prod";
            this.Text = "Frm_Polizas_Prod";
            this.gpb_movimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.gpb_detalle.ResumeLayout(false);
            this.gpb_detalle.PerformLayout();
            this.gpb_Encabezado.ResumeLayout(false);
            this.gpb_Encabezado.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpb_movimiento;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.GroupBox gpb_detalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboperacion;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.Label lbl_Cuenta;
        private System.Windows.Forms.GroupBox gpb_Encabezado;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_tipo_poliza;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cbtipopoliza;
        private System.Windows.Forms.Label lbl_titulo_saldo;
        private System.Windows.Forms.Label lbl_saldo;
    }
}