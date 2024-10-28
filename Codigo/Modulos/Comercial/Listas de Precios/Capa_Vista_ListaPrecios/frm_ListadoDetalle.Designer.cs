
namespace Capa_Vista_ListaPrecios
{
    partial class frm_ListadoDetalle
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
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_productobuscado = new System.Windows.Forms.TextBox();
            this.Txt_busqueda = new System.Windows.Forms.Label();
            this.Cbo_clasificacionGeneral = new System.Windows.Forms.ComboBox();
            this.Dgv_detalleProductos = new System.Windows.Forms.DataGridView();
            this.listBox_resultados = new System.Windows.Forms.ListBox();
            this.panel_resultado = new System.Windows.Forms.Panel();
            this.Cbo_clasificacionEspecifica = new System.Windows.Forms.ComboBox();
            this.Txt_clasificacionSeleccionada = new System.Windows.Forms.TextBox();
            this.Txt_clasificacionEspecificaSeleccionada = new System.Windows.Forms.TextBox();
            this.Txt_clasificacion = new System.Windows.Forms.Label();
            this.Gpb_modo = new System.Windows.Forms.GroupBox();
            this.Txt_aplicar = new System.Windows.Forms.Label();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Txt_descuento = new System.Windows.Forms.Label();
            this.Txt_forzado = new System.Windows.Forms.TextBox();
            this.Rdb_forzar = new System.Windows.Forms.RadioButton();
            this.Rdb_precioventa = new System.Windows.Forms.RadioButton();
            this.Rdb_costocompra = new System.Windows.Forms.RadioButton();
            this.Txt_precioforzado = new System.Windows.Forms.Label();
            this.Dgv_seleccionados = new System.Windows.Forms.DataGridView();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_costo = new System.Windows.Forms.TextBox();
            this.Txt_costocompra = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Txt_precioventa = new System.Windows.Forms.Label();
            this.Rdb_ninguno = new System.Windows.Forms.RadioButton();
            this.Btn_aplicar = new System.Windows.Forms.Button();
            this.Gbp_datos2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleProductos)).BeginInit();
            this.panel_resultado.SuspendLayout();
            this.Gpb_modo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_seleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_producto.Location = new System.Drawing.Point(147, 431);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(216, 23);
            this.Cbo_producto.TabIndex = 316;
            this.Cbo_producto.SelectedIndexChanged += new System.EventHandler(this.Cbo_producto_SelectedIndexChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(66, 387);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 26);
            this.Btn_buscar.TabIndex = 314;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_productobuscado
            // 
            this.Txt_productobuscado.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_productobuscado.Location = new System.Drawing.Point(147, 391);
            this.Txt_productobuscado.Name = "Txt_productobuscado";
            this.Txt_productobuscado.Size = new System.Drawing.Size(216, 22);
            this.Txt_productobuscado.TabIndex = 315;
            this.Txt_productobuscado.TextChanged += new System.EventHandler(this.Txt_productobuscado_TextChanged);
            // 
            // Txt_busqueda
            // 
            this.Txt_busqueda.AutoSize = true;
            this.Txt_busqueda.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Txt_busqueda.ForeColor = System.Drawing.Color.Black;
            this.Txt_busqueda.Location = new System.Drawing.Point(407, 53);
            this.Txt_busqueda.Name = "Txt_busqueda";
            this.Txt_busqueda.Size = new System.Drawing.Size(39, 19);
            this.Txt_busqueda.TabIndex = 313;
            this.Txt_busqueda.Text = "Tipo:";
            // 
            // Cbo_clasificacionGeneral
            // 
            this.Cbo_clasificacionGeneral.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_clasificacionGeneral.FormattingEnabled = true;
            this.Cbo_clasificacionGeneral.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_clasificacionGeneral.Location = new System.Drawing.Point(129, 53);
            this.Cbo_clasificacionGeneral.Name = "Cbo_clasificacionGeneral";
            this.Cbo_clasificacionGeneral.Size = new System.Drawing.Size(216, 23);
            this.Cbo_clasificacionGeneral.TabIndex = 317;
            this.Cbo_clasificacionGeneral.SelectedIndexChanged += new System.EventHandler(this.Cbo_clasificacion_SelectedIndexChanged);
            // 
            // Dgv_detalleProductos
            // 
            this.Dgv_detalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleProductos.Location = new System.Drawing.Point(39, 104);
            this.Dgv_detalleProductos.Name = "Dgv_detalleProductos";
            this.Dgv_detalleProductos.Size = new System.Drawing.Size(652, 188);
            this.Dgv_detalleProductos.TabIndex = 318;
            this.Dgv_detalleProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_detalleProductos_CellContentClick);
            // 
            // listBox_resultados
            // 
            this.listBox_resultados.FormattingEnabled = true;
            this.listBox_resultados.Location = new System.Drawing.Point(3, 2);
            this.listBox_resultados.Name = "listBox_resultados";
            this.listBox_resultados.Size = new System.Drawing.Size(210, 95);
            this.listBox_resultados.TabIndex = 319;
            this.listBox_resultados.SelectedIndexChanged += new System.EventHandler(this.listBox_resultados_SelectedIndexChanged);
            // 
            // panel_resultado
            // 
            this.panel_resultado.Controls.Add(this.listBox_resultados);
            this.panel_resultado.Location = new System.Drawing.Point(147, 460);
            this.panel_resultado.Name = "panel_resultado";
            this.panel_resultado.Size = new System.Drawing.Size(216, 100);
            this.panel_resultado.TabIndex = 320;
            // 
            // Cbo_clasificacionEspecifica
            // 
            this.Cbo_clasificacionEspecifica.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_clasificacionEspecifica.FormattingEnabled = true;
            this.Cbo_clasificacionEspecifica.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_clasificacionEspecifica.Location = new System.Drawing.Point(466, 53);
            this.Cbo_clasificacionEspecifica.Name = "Cbo_clasificacionEspecifica";
            this.Cbo_clasificacionEspecifica.Size = new System.Drawing.Size(223, 23);
            this.Cbo_clasificacionEspecifica.TabIndex = 321;
            this.Cbo_clasificacionEspecifica.SelectedIndexChanged += new System.EventHandler(this.Cbo_clasificacionEspecifica_SelectedIndexChanged_1);
            // 
            // Txt_clasificacionSeleccionada
            // 
            this.Txt_clasificacionSeleccionada.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_clasificacionSeleccionada.Location = new System.Drawing.Point(129, 93);
            this.Txt_clasificacionSeleccionada.Name = "Txt_clasificacionSeleccionada";
            this.Txt_clasificacionSeleccionada.Size = new System.Drawing.Size(216, 22);
            this.Txt_clasificacionSeleccionada.TabIndex = 322;
            this.Txt_clasificacionSeleccionada.Visible = false;
            this.Txt_clasificacionSeleccionada.TextChanged += new System.EventHandler(this.Txt_clasificacionSeleccionada_TextChanged);
            // 
            // Txt_clasificacionEspecificaSeleccionada
            // 
            this.Txt_clasificacionEspecificaSeleccionada.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_clasificacionEspecificaSeleccionada.Location = new System.Drawing.Point(466, 92);
            this.Txt_clasificacionEspecificaSeleccionada.Name = "Txt_clasificacionEspecificaSeleccionada";
            this.Txt_clasificacionEspecificaSeleccionada.Size = new System.Drawing.Size(223, 22);
            this.Txt_clasificacionEspecificaSeleccionada.TabIndex = 323;
            this.Txt_clasificacionEspecificaSeleccionada.Visible = false;
            // 
            // Txt_clasificacion
            // 
            this.Txt_clasificacion.AutoSize = true;
            this.Txt_clasificacion.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Txt_clasificacion.ForeColor = System.Drawing.Color.Black;
            this.Txt_clasificacion.Location = new System.Drawing.Point(35, 53);
            this.Txt_clasificacion.Name = "Txt_clasificacion";
            this.Txt_clasificacion.Size = new System.Drawing.Size(88, 19);
            this.Txt_clasificacion.TabIndex = 325;
            this.Txt_clasificacion.Text = "Clasificación:";
            // 
            // Gpb_modo
            // 
            this.Gpb_modo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_modo.Controls.Add(this.Rdb_ninguno);
            this.Gpb_modo.Controls.Add(this.Txt_aplicar);
            this.Gpb_modo.Controls.Add(this.Txt_porcentaje);
            this.Gpb_modo.Controls.Add(this.Txt_descuento);
            this.Gpb_modo.Controls.Add(this.Txt_forzado);
            this.Gpb_modo.Controls.Add(this.Rdb_forzar);
            this.Gpb_modo.Controls.Add(this.Rdb_precioventa);
            this.Gpb_modo.Controls.Add(this.Rdb_costocompra);
            this.Gpb_modo.Controls.Add(this.Txt_precioforzado);
            this.Gpb_modo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Gpb_modo.ForeColor = System.Drawing.Color.Blue;
            this.Gpb_modo.Location = new System.Drawing.Point(724, 312);
            this.Gpb_modo.Name = "Gpb_modo";
            this.Gpb_modo.Size = new System.Drawing.Size(505, 184);
            this.Gpb_modo.TabIndex = 326;
            this.Gpb_modo.TabStop = false;
            this.Gpb_modo.Text = "Métodos de fijación de precios";
            this.Gpb_modo.Enter += new System.EventHandler(this.Gpb_modo_Enter);
            // 
            // Txt_aplicar
            // 
            this.Txt_aplicar.AutoSize = true;
            this.Txt_aplicar.ForeColor = System.Drawing.Color.Black;
            this.Txt_aplicar.Location = new System.Drawing.Point(478, 67);
            this.Txt_aplicar.Name = "Txt_aplicar";
            this.Txt_aplicar.Size = new System.Drawing.Size(20, 16);
            this.Txt_aplicar.TabIndex = 317;
            this.Txt_aplicar.Text = "%";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Location = new System.Drawing.Point(356, 62);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(121, 23);
            this.Txt_porcentaje.TabIndex = 315;
            this.Txt_porcentaje.TextChanged += new System.EventHandler(this.Txt_porcentaje_TextChanged);
            // 
            // Txt_descuento
            // 
            this.Txt_descuento.AutoSize = true;
            this.Txt_descuento.Font = new System.Drawing.Font("Arial Narrow", 6.5F, System.Drawing.FontStyle.Bold);
            this.Txt_descuento.ForeColor = System.Drawing.Color.Red;
            this.Txt_descuento.Location = new System.Drawing.Point(364, 46);
            this.Txt_descuento.Name = "Txt_descuento";
            this.Txt_descuento.Size = new System.Drawing.Size(103, 13);
            this.Txt_descuento.TabIndex = 316;
            this.Txt_descuento.Text = "Ingreso Opcional (Entero)";
            // 
            // Txt_forzado
            // 
            this.Txt_forzado.Location = new System.Drawing.Point(156, 133);
            this.Txt_forzado.Name = "Txt_forzado";
            this.Txt_forzado.Size = new System.Drawing.Size(93, 23);
            this.Txt_forzado.TabIndex = 314;
            this.Txt_forzado.TextChanged += new System.EventHandler(this.Txt_forzado_TextChanged);
            // 
            // Rdb_forzar
            // 
            this.Rdb_forzar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_forzar.AutoSize = true;
            this.Rdb_forzar.ForeColor = System.Drawing.Color.Black;
            this.Rdb_forzar.Location = new System.Drawing.Point(15, 104);
            this.Rdb_forzar.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_forzar.Name = "Rdb_forzar";
            this.Rdb_forzar.Size = new System.Drawing.Size(102, 20);
            this.Rdb_forzar.TabIndex = 4;
            this.Rdb_forzar.TabStop = true;
            this.Rdb_forzar.Text = "Forzar precio";
            this.Rdb_forzar.UseVisualStyleBackColor = true;
            this.Rdb_forzar.CheckedChanged += new System.EventHandler(this.Rdb_forzar_CheckedChanged);
            // 
            // Rdb_precioventa
            // 
            this.Rdb_precioventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_precioventa.AutoSize = true;
            this.Rdb_precioventa.ForeColor = System.Drawing.Color.Black;
            this.Rdb_precioventa.Location = new System.Drawing.Point(15, 30);
            this.Rdb_precioventa.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_precioventa.Name = "Rdb_precioventa";
            this.Rdb_precioventa.Size = new System.Drawing.Size(256, 20);
            this.Rdb_precioventa.TabIndex = 2;
            this.Rdb_precioventa.TabStop = true;
            this.Rdb_precioventa.Text = "Usar descuento contra el precio de venta";
            this.Rdb_precioventa.UseVisualStyleBackColor = true;
            this.Rdb_precioventa.CheckedChanged += new System.EventHandler(this.Rdb_precioventa_CheckedChanged);
            // 
            // Rdb_costocompra
            // 
            this.Rdb_costocompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_costocompra.AutoSize = true;
            this.Rdb_costocompra.ForeColor = System.Drawing.Color.Black;
            this.Rdb_costocompra.Location = new System.Drawing.Point(15, 65);
            this.Rdb_costocompra.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_costocompra.Name = "Rdb_costocompra";
            this.Rdb_costocompra.Size = new System.Drawing.Size(325, 20);
            this.Rdb_costocompra.TabIndex = 3;
            this.Rdb_costocompra.TabStop = true;
            this.Rdb_costocompra.Text = "Usar ganancia a partir del costo promedio de compra";
            this.Rdb_costocompra.UseVisualStyleBackColor = true;
            this.Rdb_costocompra.CheckedChanged += new System.EventHandler(this.Rdb_costocompra_CheckedChanged);
            // 
            // Txt_precioforzado
            // 
            this.Txt_precioforzado.AutoSize = true;
            this.Txt_precioforzado.ForeColor = System.Drawing.Color.Black;
            this.Txt_precioforzado.Location = new System.Drawing.Point(152, 111);
            this.Txt_precioforzado.Name = "Txt_precioforzado";
            this.Txt_precioforzado.Size = new System.Drawing.Size(91, 16);
            this.Txt_precioforzado.TabIndex = 0;
            this.Txt_precioforzado.Text = "Precio forzado";
            // 
            // Dgv_seleccionados
            // 
            this.Dgv_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_seleccionados.Location = new System.Drawing.Point(724, 104);
            this.Dgv_seleccionados.Name = "Dgv_seleccionados";
            this.Dgv_seleccionados.Size = new System.Drawing.Size(505, 188);
            this.Dgv_seleccionados.TabIndex = 327;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Location = new System.Drawing.Point(436, 312);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(120, 42);
            this.Btn_aceptar.TabIndex = 328;
            this.Btn_aceptar.Text = "Aceptar Selección";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(569, 312);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(120, 42);
            this.Btn_cancelar.TabIndex = 329;
            this.Btn_cancelar.Text = "Cancelar Selección";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_costo
            // 
            this.Txt_costo.Font = new System.Drawing.Font("Arial Narrow", 7.5F, System.Drawing.FontStyle.Bold);
            this.Txt_costo.ForeColor = System.Drawing.Color.Red;
            this.Txt_costo.Location = new System.Drawing.Point(355, 566);
            this.Txt_costo.Name = "Txt_costo";
            this.Txt_costo.Size = new System.Drawing.Size(74, 19);
            this.Txt_costo.TabIndex = 333;
            // 
            // Txt_costocompra
            // 
            this.Txt_costocompra.AutoSize = true;
            this.Txt_costocompra.Font = new System.Drawing.Font("Arial Narrow", 6.5F, System.Drawing.FontStyle.Bold);
            this.Txt_costocompra.ForeColor = System.Drawing.Color.Red;
            this.Txt_costocompra.Location = new System.Drawing.Point(237, 570);
            this.Txt_costocompra.Name = "Txt_costocompra";
            this.Txt_costocompra.Size = new System.Drawing.Size(112, 13);
            this.Txt_costocompra.TabIndex = 332;
            this.Txt_costocompra.Text = "Costo promedio de compra:";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Arial Narrow", 7.5F, System.Drawing.FontStyle.Bold);
            this.Txt_precio.ForeColor = System.Drawing.Color.Red;
            this.Txt_precio.Location = new System.Drawing.Point(131, 564);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(74, 19);
            this.Txt_precio.TabIndex = 331;
            // 
            // Txt_precioventa
            // 
            this.Txt_precioventa.AutoSize = true;
            this.Txt_precioventa.Font = new System.Drawing.Font("Arial Narrow", 6.5F, System.Drawing.FontStyle.Bold);
            this.Txt_precioventa.ForeColor = System.Drawing.Color.Red;
            this.Txt_precioventa.Location = new System.Drawing.Point(45, 568);
            this.Txt_precioventa.Name = "Txt_precioventa";
            this.Txt_precioventa.Size = new System.Drawing.Size(80, 13);
            this.Txt_precioventa.TabIndex = 330;
            this.Txt_precioventa.Text = "Descuento de venta:";
            // 
            // Rdb_ninguno
            // 
            this.Rdb_ninguno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_ninguno.AutoSize = true;
            this.Rdb_ninguno.ForeColor = System.Drawing.Color.Black;
            this.Rdb_ninguno.Location = new System.Drawing.Point(15, 145);
            this.Rdb_ninguno.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_ninguno.Name = "Rdb_ninguno";
            this.Rdb_ninguno.Size = new System.Drawing.Size(97, 20);
            this.Rdb_ninguno.TabIndex = 318;
            this.Rdb_ninguno.TabStop = true;
            this.Rdb_ninguno.Text = "Sin Cambios";
            this.Rdb_ninguno.UseVisualStyleBackColor = true;
            // 
            // Btn_aplicar
            // 
            this.Btn_aplicar.Location = new System.Drawing.Point(1109, 515);
            this.Btn_aplicar.Name = "Btn_aplicar";
            this.Btn_aplicar.Size = new System.Drawing.Size(120, 42);
            this.Btn_aplicar.TabIndex = 334;
            this.Btn_aplicar.Text = "Aplicar Precios";
            this.Btn_aplicar.UseVisualStyleBackColor = true;
            // 
            // Gbp_datos2
            // 
            this.Gbp_datos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbp_datos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gbp_datos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbp_datos2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Gbp_datos2.Location = new System.Drawing.Point(714, 78);
            this.Gbp_datos2.Margin = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Name = "Gbp_datos2";
            this.Gbp_datos2.Padding = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Size = new System.Drawing.Size(524, 430);
            this.Gbp_datos2.TabIndex = 335;
            this.Gbp_datos2.TabStop = false;
            this.Gbp_datos2.Text = "Consulta de Cambios a Aplicar";
            // 
            // frm_ListadoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1262, 609);
            this.Controls.Add(this.Btn_aplicar);
            this.Controls.Add(this.Txt_costo);
            this.Controls.Add(this.Txt_costocompra);
            this.Controls.Add(this.Txt_precio);
            this.Controls.Add(this.Txt_precioventa);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Gpb_modo);
            this.Controls.Add(this.Txt_clasificacion);
            this.Controls.Add(this.Txt_clasificacionEspecificaSeleccionada);
            this.Controls.Add(this.Txt_clasificacionSeleccionada);
            this.Controls.Add(this.Cbo_clasificacionEspecifica);
            this.Controls.Add(this.panel_resultado);
            this.Controls.Add(this.Dgv_detalleProductos);
            this.Controls.Add(this.Cbo_clasificacionGeneral);
            this.Controls.Add(this.Cbo_producto);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_productobuscado);
            this.Controls.Add(this.Txt_busqueda);
            this.Controls.Add(this.Dgv_seleccionados);
            this.Controls.Add(this.Gbp_datos2);
            this.Name = "frm_ListadoDetalle";
            this.Text = "frm_ListadoDetalle";
            this.Load += new System.EventHandler(this.frm_ListadoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleProductos)).EndInit();
            this.panel_resultado.ResumeLayout(false);
            this.Gpb_modo.ResumeLayout(false);
            this.Gpb_modo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_seleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_productobuscado;
        private System.Windows.Forms.Label Txt_busqueda;
        private System.Windows.Forms.ComboBox Cbo_clasificacionGeneral;
        private System.Windows.Forms.DataGridView Dgv_detalleProductos;
        private System.Windows.Forms.ListBox listBox_resultados;
        private System.Windows.Forms.Panel panel_resultado;
        private System.Windows.Forms.ComboBox Cbo_clasificacionEspecifica;
        private System.Windows.Forms.TextBox Txt_clasificacionSeleccionada;
        private System.Windows.Forms.TextBox Txt_clasificacionEspecificaSeleccionada;
        private System.Windows.Forms.Label Txt_clasificacion;
        private System.Windows.Forms.GroupBox Gpb_modo;
        private System.Windows.Forms.Label Txt_aplicar;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.Label Txt_descuento;
        private System.Windows.Forms.TextBox Txt_forzado;
        private System.Windows.Forms.RadioButton Rdb_forzar;
        private System.Windows.Forms.RadioButton Rdb_precioventa;
        private System.Windows.Forms.RadioButton Rdb_costocompra;
        private System.Windows.Forms.Label Txt_precioforzado;
        private System.Windows.Forms.DataGridView Dgv_seleccionados;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_costo;
        private System.Windows.Forms.Label Txt_costocompra;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Txt_precioventa;
        private System.Windows.Forms.RadioButton Rdb_ninguno;
        private System.Windows.Forms.Button Btn_aplicar;
        private System.Windows.Forms.GroupBox Gbp_datos2;
    }
}