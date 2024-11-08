
namespace Capa_Vista_Factura
{
    partial class Frm_Factura
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
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rdb_Manual = new System.Windows.Forms.RadioButton();
            this.Rdb_Pedido = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_PedidoBUS = new System.Windows.Forms.TextBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Dgv_Fcatura = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_subtotall = new System.Windows.Forms.Label();
            this.Txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Txt_IVAl = new System.Windows.Forms.Label();
            this.Txt_precion = new System.Windows.Forms.Label();
            this.Txt_IVA = new System.Windows.Forms.TextBox();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Txt_cantidadn = new System.Windows.Forms.Label();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_producton = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_totaln = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_pedidos = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Txt_ClienteBus = new System.Windows.Forms.TextBox();
            this.Txt_VendedorBus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_fechaC = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_nuevoCE = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Dtp_fechaV = new System.Windows.Forms.DateTimePicker();
            this.Txt_idE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Txt_tipCliente = new System.Windows.Forms.Label();
            this.Txt_ClienteB = new System.Windows.Forms.TextBox();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Txt_pagom = new System.Windows.Forms.TextBox();
            this.Cbo_metodoP = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Fcatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_reporte.FlatAppearance.BorderSize = 0;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.Image = global::Capa_Vista_Factura.Properties.Resources.REPO;
            this.Btn_reporte.Location = new System.Drawing.Point(799, 2);
            this.Btn_reporte.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(43, 44);
            this.Btn_reporte.TabIndex = 335;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Factura.Properties.Resources.AYUDA;
            this.Btn_ayuda.Location = new System.Drawing.Point(700, 5);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(42, 39);
            this.Btn_ayuda.TabIndex = 334;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox3.Controls.Add(this.Rdb_Manual);
            this.groupBox3.Controls.Add(this.Rdb_Pedido);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 58);
            this.groupBox3.TabIndex = 333;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear Factura";
            // 
            // Rdb_Manual
            // 
            this.Rdb_Manual.AutoSize = true;
            this.Rdb_Manual.Location = new System.Drawing.Point(645, 25);
            this.Rdb_Manual.Name = "Rdb_Manual";
            this.Rdb_Manual.Size = new System.Drawing.Size(72, 23);
            this.Rdb_Manual.TabIndex = 324;
            this.Rdb_Manual.TabStop = true;
            this.Rdb_Manual.Text = "Manual";
            this.Rdb_Manual.UseVisualStyleBackColor = true;
            this.Rdb_Manual.CheckedChanged += new System.EventHandler(this.Rdb_Manual_CheckedChanged);
            // 
            // Rdb_Pedido
            // 
            this.Rdb_Pedido.AutoSize = true;
            this.Rdb_Pedido.Location = new System.Drawing.Point(212, 25);
            this.Rdb_Pedido.Name = "Rdb_Pedido";
            this.Rdb_Pedido.Size = new System.Drawing.Size(96, 23);
            this.Rdb_Pedido.TabIndex = 323;
            this.Rdb_Pedido.TabStop = true;
            this.Rdb_Pedido.Text = "Por Pedido";
            this.Rdb_Pedido.UseVisualStyleBackColor = true;
            this.Rdb_Pedido.CheckedChanged += new System.EventHandler(this.Rdb_Pedido_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox2.Controls.Add(this.Btn_agregar);
            this.groupBox2.Controls.Add(this.Btn_borrar);
            this.groupBox2.Controls.Add(this.Txt_subtotal);
            this.groupBox2.Controls.Add(this.Dgv_Fcatura);
            this.groupBox2.Controls.Add(this.Txt_subtotall);
            this.groupBox2.Controls.Add(this.Txt_cantidad);
            this.groupBox2.Controls.Add(this.Txt_IVAl);
            this.groupBox2.Controls.Add(this.Txt_precion);
            this.groupBox2.Controls.Add(this.Txt_IVA);
            this.groupBox2.Controls.Add(this.Txt_precio);
            this.groupBox2.Controls.Add(this.Txt_cantidadn);
            this.groupBox2.Controls.Add(this.Cbo_producto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_producton);
            this.groupBox2.Controls.Add(this.Txt_total);
            this.groupBox2.Controls.Add(this.Txt_totaln);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 317);
            this.groupBox2.TabIndex = 332;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Txt_PedidoBUS
            // 
            this.Txt_PedidoBUS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PedidoBUS.Location = new System.Drawing.Point(359, 29);
            this.Txt_PedidoBUS.Name = "Txt_PedidoBUS";
            this.Txt_PedidoBUS.Size = new System.Drawing.Size(121, 22);
            this.Txt_PedidoBUS.TabIndex = 329;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = global::Capa_Vista_Factura.Properties.Resources.A11;
            this.Btn_agregar.Location = new System.Drawing.Point(548, 112);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(61, 53);
            this.Btn_agregar.TabIndex = 324;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = global::Capa_Vista_Factura.Properties.Resources.D1;
            this.Btn_borrar.Location = new System.Drawing.Point(724, 112);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(61, 53);
            this.Btn_borrar.TabIndex = 315;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(648, 197);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_subtotal.TabIndex = 320;
            // 
            // Dgv_Fcatura
            // 
            this.Dgv_Fcatura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_Fcatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Fcatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.Dgv_Fcatura.Location = new System.Drawing.Point(43, 80);
            this.Dgv_Fcatura.Name = "Dgv_Fcatura";
            this.Dgv_Fcatura.Size = new System.Drawing.Size(456, 216);
            this.Dgv_Fcatura.TabIndex = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // Txt_subtotall
            // 
            this.Txt_subtotall.AutoSize = true;
            this.Txt_subtotall.Location = new System.Drawing.Point(544, 200);
            this.Txt_subtotall.Name = "Txt_subtotall";
            this.Txt_subtotall.Size = new System.Drawing.Size(59, 19);
            this.Txt_subtotall.TabIndex = 319;
            this.Txt_subtotall.Text = "Subtotal";
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(648, 21);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(76, 26);
            this.Txt_cantidad.TabIndex = 11;
            // 
            // Txt_IVAl
            // 
            this.Txt_IVAl.AutoSize = true;
            this.Txt_IVAl.Location = new System.Drawing.Point(544, 231);
            this.Txt_IVAl.Name = "Txt_IVAl";
            this.Txt_IVAl.Size = new System.Drawing.Size(34, 19);
            this.Txt_IVAl.TabIndex = 318;
            this.Txt_IVAl.Text = "IVA";
            // 
            // Txt_precion
            // 
            this.Txt_precion.AutoSize = true;
            this.Txt_precion.Location = new System.Drawing.Point(330, 28);
            this.Txt_precion.Name = "Txt_precion";
            this.Txt_precion.Size = new System.Drawing.Size(48, 19);
            this.Txt_precion.TabIndex = 31;
            this.Txt_precion.Text = "Precio";
            // 
            // Txt_IVA
            // 
            this.Txt_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IVA.Location = new System.Drawing.Point(648, 228);
            this.Txt_IVA.Name = "Txt_IVA";
            this.Txt_IVA.Size = new System.Drawing.Size(121, 22);
            this.Txt_IVA.TabIndex = 317;
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(402, 25);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(121, 22);
            this.Txt_precio.TabIndex = 30;
            // 
            // Txt_cantidadn
            // 
            this.Txt_cantidadn.AutoSize = true;
            this.Txt_cantidadn.Location = new System.Drawing.Point(572, 26);
            this.Txt_cantidadn.Name = "Txt_cantidadn";
            this.Txt_cantidadn.Size = new System.Drawing.Size(64, 19);
            this.Txt_cantidadn.TabIndex = 29;
            this.Txt_cantidadn.Text = "Cantidad";
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(79, 28);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(230, 23);
            this.Cbo_producto.TabIndex = 10;
            this.Cbo_producto.SelectedIndexChanged += new System.EventHandler(this.Cbo_producto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 10;
            // 
            // Txt_producton
            // 
            this.Txt_producton.AutoSize = true;
            this.Txt_producton.Location = new System.Drawing.Point(8, 31);
            this.Txt_producton.Name = "Txt_producton";
            this.Txt_producton.Size = new System.Drawing.Size(65, 19);
            this.Txt_producton.TabIndex = 9;
            this.Txt_producton.Text = "Producto";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(647, 257);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(121, 22);
            this.Txt_total.TabIndex = 26;
            // 
            // Txt_totaln
            // 
            this.Txt_totaln.AutoSize = true;
            this.Txt_totaln.Location = new System.Drawing.Point(544, 260);
            this.Txt_totaln.Name = "Txt_totaln";
            this.Txt_totaln.Size = new System.Drawing.Size(39, 19);
            this.Txt_totaln.TabIndex = 27;
            this.Txt_totaln.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox1.Controls.Add(this.Cbo_metodoP);
            this.groupBox1.Controls.Add(this.Txt_pagom);
            this.groupBox1.Controls.Add(this.Cbo_pedidos);
            this.groupBox1.Controls.Add(this.Txt_PedidoBUS);
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Cbo_cliente);
            this.groupBox1.Controls.Add(this.Txt_ClienteBus);
            this.groupBox1.Controls.Add(this.Txt_VendedorBus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Dtp_fechaC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_nuevoCE);
            this.groupBox1.Controls.Add(this.Btn_cancelar);
            this.groupBox1.Controls.Add(this.Dtp_fechaV);
            this.groupBox1.Controls.Add(this.Txt_idE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_idEncezado);
            this.groupBox1.Controls.Add(this.Txt_tipCliente);
            this.groupBox1.Controls.Add(this.Txt_ClienteB);
            this.groupBox1.Controls.Add(this.Txt_Clienten);
            this.groupBox1.Controls.Add(this.Txt_Vendedorn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 140);
            this.groupBox1.TabIndex = 331;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // Cbo_pedidos
            // 
            this.Cbo_pedidos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_pedidos.FormattingEnabled = true;
            this.Cbo_pedidos.Location = new System.Drawing.Point(359, 28);
            this.Cbo_pedidos.Name = "Cbo_pedidos";
            this.Cbo_pedidos.Size = new System.Drawing.Size(121, 23);
            this.Cbo_pedidos.TabIndex = 328;
            this.Cbo_pedidos.SelectedIndexChanged += new System.EventHandler(this.Cbo_pedidos_SelectedIndexChanged_1);
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(504, 68);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(121, 23);
            this.Cbo_vendedor.TabIndex = 326;
            this.Cbo_vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_vendedor_SelectedIndexChanged);
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(98, 67);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(121, 23);
            this.Cbo_cliente.TabIndex = 325;
            this.Cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged_1);
            // 
            // Txt_ClienteBus
            // 
            this.Txt_ClienteBus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteBus.Location = new System.Drawing.Point(98, 67);
            this.Txt_ClienteBus.Name = "Txt_ClienteBus";
            this.Txt_ClienteBus.Size = new System.Drawing.Size(121, 22);
            this.Txt_ClienteBus.TabIndex = 324;
            this.Txt_ClienteBus.TextChanged += new System.EventHandler(this.Txt_ClienteBus_TextChanged);
            // 
            // Txt_VendedorBus
            // 
            this.Txt_VendedorBus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_VendedorBus.Location = new System.Drawing.Point(504, 67);
            this.Txt_VendedorBus.Name = "Txt_VendedorBus";
            this.Txt_VendedorBus.Size = new System.Drawing.Size(121, 22);
            this.Txt_VendedorBus.TabIndex = 323;
            this.Txt_VendedorBus.TextChanged += new System.EventHandler(this.Txt_VendedorBus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 321;
            this.label4.Text = "Forma de Pago";
            // 
            // Dtp_fechaC
            // 
            this.Dtp_fechaC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaC.Location = new System.Drawing.Point(585, 25);
            this.Dtp_fechaC.Name = "Dtp_fechaC";
            this.Dtp_fechaC.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechaC.TabIndex = 314;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 315;
            this.label3.Text = "Pedido ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 313;
            this.label1.Text = "Fecha ";
            // 
            // Btn_nuevoCE
            // 
            this.Btn_nuevoCE.BackColor = System.Drawing.Color.Transparent;
            this.Btn_nuevoCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevoCE.FlatAppearance.BorderSize = 0;
            this.Btn_nuevoCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevoCE.Image = global::Capa_Vista_Factura.Properties.Resources.G1;
            this.Btn_nuevoCE.Location = new System.Drawing.Point(656, 67);
            this.Btn_nuevoCE.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_nuevoCE.Name = "Btn_nuevoCE";
            this.Btn_nuevoCE.Size = new System.Drawing.Size(61, 53);
            this.Btn_nuevoCE.TabIndex = 311;
            this.Btn_nuevoCE.UseVisualStyleBackColor = false;
            this.Btn_nuevoCE.Click += new System.EventHandler(this.Btn_nuevoCE_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Factura.Properties.Resources.C1;
            this.Btn_cancelar.Location = new System.Drawing.Point(724, 67);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(61, 53);
            this.Btn_cancelar.TabIndex = 312;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Dtp_fechaV
            // 
            this.Dtp_fechaV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaV.Location = new System.Drawing.Point(145, 107);
            this.Dtp_fechaV.Name = "Dtp_fechaV";
            this.Dtp_fechaV.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechaV.TabIndex = 31;
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(18, 29);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(25, 19);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(58, 28);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_idEncezado.TabIndex = 9;
            // 
            // Txt_tipCliente
            // 
            this.Txt_tipCliente.AutoSize = true;
            this.Txt_tipCliente.Location = new System.Drawing.Point(253, 67);
            this.Txt_tipCliente.Name = "Txt_tipCliente";
            this.Txt_tipCliente.Size = new System.Drawing.Size(36, 19);
            this.Txt_tipCliente.TabIndex = 29;
            this.Txt_tipCliente.Text = "Tipo";
            // 
            // Txt_ClienteB
            // 
            this.Txt_ClienteB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteB.Location = new System.Drawing.Point(302, 68);
            this.Txt_ClienteB.Name = "Txt_ClienteB";
            this.Txt_ClienteB.Size = new System.Drawing.Size(85, 22);
            this.Txt_ClienteB.TabIndex = 29;
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(12, 67);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(51, 19);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(421, 71);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(68, 19);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F);
            this.Txt_titulo.Location = new System.Drawing.Point(411, 5);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(137, 37);
            this.Txt_titulo.TabIndex = 330;
            this.Txt_titulo.Text = "F a c t u r a";
            // 
            // Txt_pagom
            // 
            this.Txt_pagom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pagom.Location = new System.Drawing.Point(484, 111);
            this.Txt_pagom.Name = "Txt_pagom";
            this.Txt_pagom.Size = new System.Drawing.Size(141, 22);
            this.Txt_pagom.TabIndex = 330;
            this.Txt_pagom.TextChanged += new System.EventHandler(this.Txt_pagom_TextChanged);
            // 
            // Cbo_metodoP
            // 
            this.Cbo_metodoP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_metodoP.FormattingEnabled = true;
            this.Cbo_metodoP.Items.AddRange(new object[] {
            "al contado",
            "al crédito"});
            this.Cbo_metodoP.Location = new System.Drawing.Point(484, 110);
            this.Cbo_metodoP.Name = "Cbo_metodoP";
            this.Cbo_metodoP.Size = new System.Drawing.Size(152, 23);
            this.Cbo_metodoP.TabIndex = 331;
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(880, 596);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_titulo);
            this.Name = "Frm_Factura";
            this.Text = "Frm_Factura";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Fcatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rdb_Manual;
        private System.Windows.Forms.RadioButton Rdb_Pedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.DataGridView Dgv_Fcatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label Txt_subtotall;
        private System.Windows.Forms.NumericUpDown Txt_cantidad;
        private System.Windows.Forms.Label Txt_IVAl;
        private System.Windows.Forms.Label Txt_precion;
        private System.Windows.Forms.TextBox Txt_IVA;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Txt_cantidadn;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txt_producton;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label Txt_totaln;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.TextBox Txt_ClienteBus;
        private System.Windows.Forms.TextBox Txt_VendedorBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_fechaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_nuevoCE;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.DateTimePicker Dtp_fechaV;
        private System.Windows.Forms.Label Txt_idE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.Label Txt_tipCliente;
        private System.Windows.Forms.TextBox Txt_ClienteB;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.ComboBox Cbo_pedidos;
        private System.Windows.Forms.TextBox Txt_PedidoBUS;
        private System.Windows.Forms.TextBox Txt_pagom;
        private System.Windows.Forms.ComboBox Cbo_metodoP;
    }
}