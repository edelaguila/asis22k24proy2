
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Vendedores_Clts
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
            this.Lbl_id_cliente = new System.Windows.Forms.Label();
            this.Lbl_id_vendedor = new System.Windows.Forms.Label();
            this.Lbl_nombre_cliente = new System.Windows.Forms.Label();
            this.Lbl_telefono_cliente = new System.Windows.Forms.Label();
            this.Lbl_direccion_cliente = new System.Windows.Forms.Label();
            this.Lbl_saldo_cta = new System.Windows.Forms.Label();
            this.Lbl_saldo_cliente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_cliente
            // 
            this.Lbl_id_cliente.AutoSize = true;
            this.Lbl_id_cliente.Location = new System.Drawing.Point(229, 71);
            this.Lbl_id_cliente.Name = "Lbl_id_cliente";
            this.Lbl_id_cliente.Size = new System.Drawing.Size(56, 13);
            this.Lbl_id_cliente.TabIndex = 0;
            this.Lbl_id_cliente.Text = "ID Cliente:";
            // 
            // Lbl_id_vendedor
            // 
            this.Lbl_id_vendedor.AutoSize = true;
            this.Lbl_id_vendedor.Location = new System.Drawing.Point(229, 95);
            this.Lbl_id_vendedor.Name = "Lbl_id_vendedor";
            this.Lbl_id_vendedor.Size = new System.Drawing.Size(67, 13);
            this.Lbl_id_vendedor.TabIndex = 1;
            this.Lbl_id_vendedor.Text = "ID Vendedor";
            // 
            // Lbl_nombre_cliente
            // 
            this.Lbl_nombre_cliente.AutoSize = true;
            this.Lbl_nombre_cliente.Location = new System.Drawing.Point(229, 120);
            this.Lbl_nombre_cliente.Name = "Lbl_nombre_cliente";
            this.Lbl_nombre_cliente.Size = new System.Drawing.Size(82, 13);
            this.Lbl_nombre_cliente.TabIndex = 2;
            this.Lbl_nombre_cliente.Text = "Nombre Cliente:";
            // 
            // Lbl_telefono_cliente
            // 
            this.Lbl_telefono_cliente.AutoSize = true;
            this.Lbl_telefono_cliente.Location = new System.Drawing.Point(229, 150);
            this.Lbl_telefono_cliente.Name = "Lbl_telefono_cliente";
            this.Lbl_telefono_cliente.Size = new System.Drawing.Size(90, 13);
            this.Lbl_telefono_cliente.TabIndex = 3;
            this.Lbl_telefono_cliente.Text = "Telefono Cliente: ";
            // 
            // Lbl_direccion_cliente
            // 
            this.Lbl_direccion_cliente.AutoSize = true;
            this.Lbl_direccion_cliente.Location = new System.Drawing.Point(229, 176);
            this.Lbl_direccion_cliente.Name = "Lbl_direccion_cliente";
            this.Lbl_direccion_cliente.Size = new System.Drawing.Size(90, 13);
            this.Lbl_direccion_cliente.TabIndex = 4;
            this.Lbl_direccion_cliente.Text = "Dirección Cliente:";
            // 
            // Lbl_saldo_cta
            // 
            this.Lbl_saldo_cta.AutoSize = true;
            this.Lbl_saldo_cta.Location = new System.Drawing.Point(229, 202);
            this.Lbl_saldo_cta.Name = "Lbl_saldo_cta";
            this.Lbl_saldo_cta.Size = new System.Drawing.Size(74, 13);
            this.Lbl_saldo_cta.TabIndex = 5;
            this.Lbl_saldo_cta.Text = "Saldo Cuenta:";
            // 
            // Lbl_saldo_cliente
            // 
            this.Lbl_saldo_cliente.AutoSize = true;
            this.Lbl_saldo_cliente.Location = new System.Drawing.Point(229, 228);
            this.Lbl_saldo_cliente.Name = "Lbl_saldo_cliente";
            this.Lbl_saldo_cliente.Size = new System.Drawing.Size(78, 13);
            this.Lbl_saldo_cliente.TabIndex = 6;
            this.Lbl_saldo_cliente.Text = "Estado Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.comboBox1.Location = new System.Drawing.Point(368, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(368, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(368, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(368, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(368, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 20);
            this.textBox6.TabIndex = 13;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(549, 270);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 67;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(161, 270);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 66;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(668, 270);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(113, 35);
            this.Btn_borrar.TabIndex = 65;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(421, 270);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 35);
            this.Btn_actualizar.TabIndex = 64;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(291, 270);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 63;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(29, 270);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 62;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(29, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 157);
            this.dataGridView1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "VENDEDORES - CLIENTE- ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Vendedor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Cliente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono Cliente";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección Cliente";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Saldo Cuenta";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado Cliente";
            this.Column7.Name = "Column7";
            // 
            // Vendedores_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lbl_saldo_cliente);
            this.Controls.Add(this.Lbl_saldo_cta);
            this.Controls.Add(this.Lbl_direccion_cliente);
            this.Controls.Add(this.Lbl_telefono_cliente);
            this.Controls.Add(this.Lbl_nombre_cliente);
            this.Controls.Add(this.Lbl_id_vendedor);
            this.Controls.Add(this.Lbl_id_cliente);
            this.Name = "Vendedores_Clts";
            this.Text = "Vendedores_Clts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id_cliente;
        private System.Windows.Forms.Label Lbl_id_vendedor;
        private System.Windows.Forms.Label Lbl_nombre_cliente;
        private System.Windows.Forms.Label Lbl_telefono_cliente;
        private System.Windows.Forms.Label Lbl_direccion_cliente;
        private System.Windows.Forms.Label Lbl_saldo_cta;
        private System.Windows.Forms.Label Lbl_saldo_cliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}