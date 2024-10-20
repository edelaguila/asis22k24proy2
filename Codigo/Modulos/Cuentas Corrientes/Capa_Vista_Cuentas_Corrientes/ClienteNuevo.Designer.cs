
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class ClienteNuevo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_cliente = new System.Windows.Forms.TextBox();
            this._cliente = new System.Windows.Forms.Label();
            this.Dgv_cliente_nuevo = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombe_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.Lbl_saldo = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_id_vendedor = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_id_vendedor = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente_nuevo)).BeginInit();
            this.SuspendLayout();
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
            this.Cbo_estado.Location = new System.Drawing.Point(274, 311);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 30);
            this.Cbo_estado.TabIndex = 33;
            // 
            // Txt_id_cliente
            // 
            this.Txt_id_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_cliente.Location = new System.Drawing.Point(274, 106);
            this.Txt_id_cliente.Name = "Txt_id_cliente";
            this.Txt_id_cliente.Size = new System.Drawing.Size(202, 26);
            this.Txt_id_cliente.TabIndex = 32;
            // 
            // _cliente
            // 
            this._cliente.AutoSize = true;
            this._cliente.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cliente.Location = new System.Drawing.Point(83, 110);
            this._cliente.Name = "_cliente";
            this._cliente.Size = new System.Drawing.Size(71, 18);
            this._cliente.TabIndex = 31;
            this._cliente.Text = "Id Cliente:";
            // 
            // Dgv_cliente_nuevo
            // 
            this.Dgv_cliente_nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_cliente_nuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cliente_nuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.id_vendedor,
            this.nombe_cliente,
            this.saldo_actual,
            this.estado_cliente});
            this.Dgv_cliente_nuevo.Location = new System.Drawing.Point(77, 364);
            this.Dgv_cliente_nuevo.Name = "Dgv_cliente_nuevo";
            this.Dgv_cliente_nuevo.Size = new System.Drawing.Size(703, 222);
            this.Dgv_cliente_nuevo.TabIndex = 30;
            // 
            // id_cliente
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_cliente.HeaderText = "Id Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // id_vendedor
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_vendedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_vendedor.HeaderText = "Id Vendedor";
            this.id_vendedor.Name = "id_vendedor";
            // 
            // nombe_cliente
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombe_cliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombe_cliente.HeaderText = "Nombre";
            this.nombe_cliente.Name = "nombe_cliente";
            // 
            // saldo_actual
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo_actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.saldo_actual.HeaderText = "Saldo Actual";
            this.saldo_actual.Name = "saldo_actual";
            // 
            // estado_cliente
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_cliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.estado_cliente.HeaderText = "Estado Cliente";
            this.estado_cliente.Name = "estado_cliente";
            this.estado_cliente.ReadOnly = true;
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_saldo.Location = new System.Drawing.Point(273, 276);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(279, 26);
            this.Txt_saldo.TabIndex = 29;
            // 
            // Lbl_saldo
            // 
            this.Lbl_saldo.AutoSize = true;
            this.Lbl_saldo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldo.Location = new System.Drawing.Point(83, 280);
            this.Lbl_saldo.Name = "Lbl_saldo";
            this.Lbl_saldo.Size = new System.Drawing.Size(92, 18);
            this.Lbl_saldo.TabIndex = 28;
            this.Lbl_saldo.Text = "Saldo Actual: ";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(274, 179);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(279, 26);
            this.Txt_nombre.TabIndex = 27;
            // 
            // Txt_id_vendedor
            // 
            this.Txt_id_vendedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_vendedor.Location = new System.Drawing.Point(274, 142);
            this.Txt_id_vendedor.Name = "Txt_id_vendedor";
            this.Txt_id_vendedor.Size = new System.Drawing.Size(279, 26);
            this.Txt_id_vendedor.TabIndex = 26;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(83, 311);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(99, 18);
            this.Lbl_estado.TabIndex = 25;
            this.Lbl_estado.Text = "Estado Cliente:";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(83, 179);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(63, 18);
            this.Lbl_nombre.TabIndex = 24;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Lbl_id_vendedor
            // 
            this.Lbl_id_vendedor.AutoSize = true;
            this.Lbl_id_vendedor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_vendedor.Location = new System.Drawing.Point(83, 142);
            this.Lbl_id_vendedor.Name = "Lbl_id_vendedor";
            this.Lbl_id_vendedor.Size = new System.Drawing.Size(91, 18);
            this.Lbl_id_vendedor.TabIndex = 23;
            this.Lbl_id_vendedor.Text = "Id Vendedor: ";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(237, 25);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(209, 22);
            this.Lbl_Titulo.TabIndex = 22;
            this.Lbl_Titulo.Text = "Creacion de Cliente Nuevo";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Titulo.UseMnemonic = false;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(268, 624);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(100, 36);
            this.Btn_buscar.TabIndex = 38;
            this.Btn_buscar.Text = "Buscar ";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(575, 624);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 36);
            this.Btn_eliminar.TabIndex = 37;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(477, 624);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(92, 36);
            this.Btn_actualizar.TabIndex = 36;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Location = new System.Drawing.Point(374, 624);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(97, 36);
            this.Btn_editar.TabIndex = 35;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Location = new System.Drawing.Point(153, 624);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(109, 36);
            this.Btn_guardar.TabIndex = 34;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Telefono:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(274, 243);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(279, 26);
            this.Txt_direccion.TabIndex = 41;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(273, 211);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(279, 26);
            this.Txt_telefono.TabIndex = 42;
            // 
            // ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(805, 679);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_cliente);
            this.Controls.Add(this._cliente);
            this.Controls.Add(this.Dgv_cliente_nuevo);
            this.Controls.Add(this.Txt_saldo);
            this.Controls.Add(this.Lbl_saldo);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_id_vendedor);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Lbl_id_vendedor);
            this.Controls.Add(this.Lbl_Titulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ClienteNuevo";
            this.Text = "ClientesNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente_nuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_cliente;
        private System.Windows.Forms.Label _cliente;
        private System.Windows.Forms.DataGridView Dgv_cliente_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombe_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cliente;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.Label Lbl_saldo;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_id_vendedor;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_id_vendedor;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_telefono;
    }
}