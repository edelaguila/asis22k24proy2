
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class ProveedorNuevo
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
            this.components = new System.ComponentModel.Container();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_telefono_provee = new System.Windows.Forms.Label();
            this.Txt_direccion_provee = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_cliente = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.Label();
            this.Dgv_proveedor_nuevo = new System.Windows.Forms.DataGridView();
            this.tblproveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Capa_Vista_Cuentas_Corrientes.DataSet1();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_saldo_provee = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_estado_provee = new System.Windows.Forms.Label();
            this.Txt_nombre_provee = new System.Windows.Forms.Label();
            this.Txt_fecha_registro = new System.Windows.Forms.Label();
            this.Txt_Titulo = new System.Windows.Forms.Label();
            this.txt_email_provee = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.tbl_proveedoresTableAdapter = new Capa_Vista_Cuentas_Corrientes.DataSet1TableAdapters.tbl_proveedoresTableAdapter();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Pk_id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldocuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedor_nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(234, 233);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(279, 30);
            this.Txt_telefono.TabIndex = 58;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(234, 189);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(279, 30);
            this.Txt_direccion.TabIndex = 57;
            // 
            // Txt_telefono_provee
            // 
            this.Txt_telefono_provee.AutoSize = true;
            this.Txt_telefono_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono_provee.Location = new System.Drawing.Point(149, 233);
            this.Txt_telefono_provee.Name = "Txt_telefono_provee";
            this.Txt_telefono_provee.Size = new System.Drawing.Size(79, 23);
            this.Txt_telefono_provee.TabIndex = 56;
            this.Txt_telefono_provee.Text = "Telefono:";
            // 
            // Txt_direccion_provee
            // 
            this.Txt_direccion_provee.AutoSize = true;
            this.Txt_direccion_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion_provee.Location = new System.Drawing.Point(140, 194);
            this.Txt_direccion_provee.Name = "Txt_direccion_provee";
            this.Txt_direccion_provee.Size = new System.Drawing.Size(88, 23);
            this.Txt_direccion_provee.TabIndex = 55;
            this.Txt_direccion_provee.Text = "Dirección:";
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
            this.Cbo_estado.Location = new System.Drawing.Point(715, 134);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 54;
            // 
            // Txt_id_cliente
            // 
            this.Txt_id_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_cliente.Location = new System.Drawing.Point(234, 68);
            this.Txt_id_cliente.Name = "Txt_id_cliente";
            this.Txt_id_cliente.Size = new System.Drawing.Size(202, 30);
            this.Txt_id_cliente.TabIndex = 53;
            this.Txt_id_cliente.TextChanged += new System.EventHandler(this.Txt_id_cliente_TextChanged);
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.AutoSize = true;
            this.Txt_proveedor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_proveedor.Location = new System.Drawing.Point(117, 68);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(111, 23);
            this.Txt_proveedor.TabIndex = 52;
            this.Txt_proveedor.Text = "Id Proveedor:";
            // 
            // Dgv_proveedor_nuevo
            // 
            this.Dgv_proveedor_nuevo.AutoGenerateColumns = false;
            this.Dgv_proveedor_nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_proveedor_nuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_proveedor_nuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pk_id_proveedor,
            this.fecharegistroDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.saldocuentaDataGridViewTextBoxColumn,
            this.estadoproveedorDataGridViewTextBoxColumn});
            this.Dgv_proveedor_nuevo.DataSource = this.tblproveedoresBindingSource;
            this.Dgv_proveedor_nuevo.Location = new System.Drawing.Point(37, 343);
            this.Dgv_proveedor_nuevo.Name = "Dgv_proveedor_nuevo";
            this.Dgv_proveedor_nuevo.RowHeadersWidth = 51;
            this.Dgv_proveedor_nuevo.Size = new System.Drawing.Size(1054, 256);
            this.Dgv_proveedor_nuevo.TabIndex = 51;
            // 
            // tblproveedoresBindingSource
            // 
            this.tblproveedoresBindingSource.DataMember = "tbl_proveedores";
            this.tblproveedoresBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_saldo.Location = new System.Drawing.Point(714, 84);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(279, 30);
            this.Txt_saldo.TabIndex = 50;
            // 
            // txt_saldo_provee
            // 
            this.txt_saldo_provee.AutoSize = true;
            this.txt_saldo_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo_provee.Location = new System.Drawing.Point(593, 84);
            this.txt_saldo_provee.Name = "txt_saldo_provee";
            this.txt_saldo_provee.Size = new System.Drawing.Size(116, 23);
            this.txt_saldo_provee.TabIndex = 49;
            this.txt_saldo_provee.Text = "Saldo cuenta: ";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(234, 150);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(279, 30);
            this.Txt_nombre.TabIndex = 48;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha.Location = new System.Drawing.Point(234, 105);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(279, 30);
            this.Txt_fecha.TabIndex = 47;
            // 
            // txt_estado_provee
            // 
            this.txt_estado_provee.AutoSize = true;
            this.txt_estado_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado_provee.Location = new System.Drawing.Point(562, 135);
            this.txt_estado_provee.Name = "txt_estado_provee";
            this.txt_estado_provee.Size = new System.Drawing.Size(147, 23);
            this.txt_estado_provee.TabIndex = 46;
            this.txt_estado_provee.Text = "Estado Proveedor:";
            // 
            // Txt_nombre_provee
            // 
            this.Txt_nombre_provee.AutoSize = true;
            this.Txt_nombre_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre_provee.Location = new System.Drawing.Point(151, 150);
            this.Txt_nombre_provee.Name = "Txt_nombre_provee";
            this.Txt_nombre_provee.Size = new System.Drawing.Size(77, 23);
            this.Txt_nombre_provee.TabIndex = 45;
            this.Txt_nombre_provee.Text = "Nombre:";
            // 
            // Txt_fecha_registro
            // 
            this.Txt_fecha_registro.AutoSize = true;
            this.Txt_fecha_registro.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_registro.Location = new System.Drawing.Point(81, 110);
            this.Txt_fecha_registro.Name = "Txt_fecha_registro";
            this.Txt_fecha_registro.Size = new System.Drawing.Size(147, 23);
            this.Txt_fecha_registro.TabIndex = 44;
            this.Txt_fecha_registro.Text = "Fecha de registro: ";
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.AutoSize = true;
            this.Txt_Titulo.Location = new System.Drawing.Point(437, 18);
            this.Txt_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(199, 17);
            this.Txt_Titulo.TabIndex = 43;
            this.Txt_Titulo.Text = "Creacion de Proveedor Nuevo";
            this.Txt_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Txt_Titulo.UseMnemonic = false;
            // 
            // txt_email_provee
            // 
            this.txt_email_provee.AutoSize = true;
            this.txt_email_provee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_provee.Location = new System.Drawing.Point(170, 275);
            this.txt_email_provee.Name = "txt_email_provee";
            this.txt_email_provee.Size = new System.Drawing.Size(58, 23);
            this.txt_email_provee.TabIndex = 59;
            this.txt_email_provee.Text = "Email:";
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(235, 275);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(278, 22);
            this.Txt_email.TabIndex = 60;
            // 
            // tbl_proveedoresTableAdapter
            // 
            this.tbl_proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(593, 194);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(116, 44);
            this.Btn_guardar.TabIndex = 61;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(728, 194);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(108, 43);
            this.Btn_editar.TabIndex = 62;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(853, 194);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(105, 43);
            this.Btn_Eliminar.TabIndex = 63;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Pk_id_proveedor
            // 
            this.Pk_id_proveedor.DataPropertyName = "Pk_id_proveedor";
            this.Pk_id_proveedor.HeaderText = "Id Proveedor";
            this.Pk_id_proveedor.MinimumWidth = 6;
            this.Pk_id_proveedor.Name = "Pk_id_proveedor";
            this.Pk_id_proveedor.Width = 125;
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de registro";
            this.fecharegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            this.fecharegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // saldocuentaDataGridViewTextBoxColumn
            // 
            this.saldocuentaDataGridViewTextBoxColumn.DataPropertyName = "saldo_cuenta";
            this.saldocuentaDataGridViewTextBoxColumn.HeaderText = "Saldo de cuenta";
            this.saldocuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldocuentaDataGridViewTextBoxColumn.Name = "saldocuentaDataGridViewTextBoxColumn";
            this.saldocuentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoproveedorDataGridViewTextBoxColumn
            // 
            this.estadoproveedorDataGridViewTextBoxColumn.DataPropertyName = "estado_proveedor";
            this.estadoproveedorDataGridViewTextBoxColumn.HeaderText = "Estado del proveedor";
            this.estadoproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoproveedorDataGridViewTextBoxColumn.Name = "estadoproveedorDataGridViewTextBoxColumn";
            this.estadoproveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProveedorNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1103, 653);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.txt_email_provee);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.Txt_telefono_provee);
            this.Controls.Add(this.Txt_direccion_provee);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_cliente);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Dgv_proveedor_nuevo);
            this.Controls.Add(this.Txt_saldo);
            this.Controls.Add(this.txt_saldo_provee);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.txt_estado_provee);
            this.Controls.Add(this.Txt_nombre_provee);
            this.Controls.Add(this.Txt_fecha_registro);
            this.Controls.Add(this.Txt_Titulo);
            this.Name = "ProveedorNuevo";
            this.Text = "ProveedorNuevo";
            this.Load += new System.EventHandler(this.ProveedorNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedor_nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Txt_telefono_provee;
        private System.Windows.Forms.Label Txt_direccion_provee;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_cliente;
        private System.Windows.Forms.Label Txt_proveedor;
        private System.Windows.Forms.DataGridView Dgv_proveedor_nuevo;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.Label txt_saldo_provee;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label txt_estado_provee;
        private System.Windows.Forms.Label Txt_nombre_provee;
        private System.Windows.Forms.Label Txt_fecha_registro;
        private System.Windows.Forms.Label Txt_Titulo;
        private System.Windows.Forms.Label txt_email_provee;
        private System.Windows.Forms.TextBox Txt_email;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblproveedoresBindingSource;
        private DataSet1TableAdapters.tbl_proveedoresTableAdapter tbl_proveedoresTableAdapter;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pk_id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldocuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoproveedorDataGridViewTextBoxColumn;
    }
}