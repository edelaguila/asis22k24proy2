
-- Tabla Clientes
CREATE TABLE IF NOT EXISTS Tbl_clientes(
    Pk_id_cliente int(11) NOT NULL,
    Clientes_nombre VARCHAR(100) NOT NULL,
    Clientes_apellido VARCHAR(100) NOT NULL,
    Clientes_nit VARCHAR(20) NOT NULL,
    Clientes_telefon VARCHAR(20) NOT NULL ,
    Clientes_direccion VARCHAR(255) NOT NULL,
    Clientes_No_Cuenta VARCHAR(255) NOT NULL,
    Clientes_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_cliente)
);

-- Tabla Vendedores
CREATE TABLE IF NOT EXISTS Tbl_vendedores (
    Pk_id_vendedor int (11) NOT NULL,
    vendedores_nombre VARCHAR(100)NOT NULL ,
    vendedores_apellido VARCHAR(100)NOT NULL ,
    vendedores_sueldo DECIMAL(10,2)NOT NULL ,
    vendedores_direccion VARCHAR(255)NOT NULL ,
    vendedores_telefono VARCHAR(20)NOT NULL ,
	Fk_id_empleado INT NOT NULL,
    Fk_id_cliente INT NOT NULL,
    vendedores_estado tinyint(1) DEFAULT 1,
    FOREIGN KEY (Fk_id_empleado) REFERENCES tbl_empleados(pk_clave),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_vendedor)
);

-- Tabla Proveedores
CREATE TABLE IF NOT EXISTS Tbl_proveedores (
    Pk_prov_id INT,
    Prov_nombre VARCHAR(100) NOT NULL,
    Prov_direccion VARCHAR(255),
    Prov_telefono VARCHAR(20),
    Prov_email VARCHAR(100),
    Prov_fechaRegistro DATE,
    Prov_estado tinyint(1) DEFAULT 1,
     PRIMARY KEY (Pk_prov_id)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS Tbl_lista_encabezado (
    Pk_id_lista_Encabezado INT(11) NOT NULL,
    ListEncabezado_nombre VARCHAR(50),
    ListEncabezado_fecha DATE,
    ListEncabezado_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_lista_Encabezado)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS Tbl_lista_detalle (
    Pk_id_lista_detalle INT(11) NOT NULL,
    Fk_id_lista_Encabezado INT NOT NULL,
    Fk_id_Producto INT NOT NULL,
    ListDetalle_preVenta DECIMAL(10,2) NULL, -- precio de venta
    ListDetalle_descuento DECIMAL(10,2) NULL,
    ListDetalle_impuesto DECIMAL(10,2) NULL,
    FOREIGN KEY (Fk_id_lista_Encabezado) REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado),
    FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    PRIMARY KEY (Pk_id_lista_detalle)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla Ordenes de Compra
CREATE TABLE IF NOT EXISTS Tbl_ordenes_compra (
    Pk_encOrCom_id  int (11) NOT NULL,
    EncOrCom_numero VARCHAR(20) NOT NULL UNIQUE,
    Fk_prov_id INT,
    EncOrCom_fechaEntrega DATE,
    FOREIGN KEY (Fk_prov_id) REFERENCES Tbl_proveedores(Pk_prov_id),
    PRIMARY KEY (Pk_encOrCom_id)
);

-- Tabla Detalle Ordenes de Compra
CREATE TABLE IF NOT EXISTS Tbl_detalle_ordenes_compra (
    Pk_detOrCom_id  int (11) NOT NULL,
    Fk_encOrCom_id INT,
    Fk_id_producto INT,
    DetOrCom_cantidad INT NOT NULL,
    DetOrCom_preUni DECIMAL(10,2) NOT NULL,
    DetOrCom_total DECIMAL(10,2),
    FOREIGN KEY (Fk_encOrCom_id) REFERENCES Tbl_ordenes_compra(Pk_encOrCom_id),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_productos(Pk_id_producto),
    PRIMARY KEY (Pk_detOrCom_id)
);

-- Tabla Póliza
CREATE TABLE IF NOT EXISTS Tbl_poliza (
    Pk_id_poliza  int (11) NOT NULL,
    Poliza_fecha_emision DATE NOT NULL,
    Poliza_concepto VARCHAR(255) NOT NULL,
    Poliza_docto VARCHAR(50),
    PRIMARY KEY (Pk_id_poliza)
);

-- Tabla Movimiento
CREATE TABLE IF NOT EXISTS Tbl_movimiento (
    Pk_id_movimiento  int (11) NOT NULL,
    Movimiento_codigo VARCHAR(50) NOT NULL,
    Movimiento_cuenta VARCHAR(50) NOT NULL,
    Movimiento_tipo VARCHAR(20) NOT NULL,
    Movimiento_valor DECIMAL(10,2) NOT NULL,
    Movimiento_cargos DECIMAL(10,2) NOT NULL,
    Movimiento_abonos DECIMAL(10,2) NOT NULL,
    Fk_id_poliza INT,
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    PRIMARY KEY (Pk_id_movimiento)
);

-- Tabla Contabilidad
CREATE TABLE IF NOT EXISTS Tbl_contabilidad (
    Pk_id_contabilidad  int (11) NOT NULL,
    Contabilidad_tipo_registro VARCHAR(50) NOT NULL,
    Contabilidad_descripcion VARCHAR(255) NOT NULL,
    PRIMARY KEY (Pk_id_contabilidad)
);

-- Relación entre Póliza y Contabilidad
CREATE TABLE IF NOT EXISTS Tbl_poliza_contabilidad (
    Fk_id_poliza  int (11) NOT NULL,
    Fk_id_contabilidad INT,
    PRIMARY KEY (Fk_id_poliza, Fk_id_contabilidad),
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    FOREIGN KEY (Fk_id_contabilidad) REFERENCES Tbl_contabilidad(Pk_id_contabilidad)
);

-- Tabla Rango de Fechas
CREATE TABLE IF NOT EXISTS Tbl_rango_fechas (
    Pk_id_rango  int (11) NOT NULL,
    Rango_fecha_inicio DATE NOT NULL,
    Rango_fecha_fin DATE NOT NULL,
    PRIMARY KEY (Pk_id_rango)
);

-- Relación entre Póliza y Rango de Fechas
CREATE TABLE IF NOT EXISTS Tbl_poliza_rango_fechas (
    Fk_id_poliza  int (11) NOT NULL,
    Fk_id_rango INT,
    PRIMARY KEY (Fk_id_poliza, Fk_id_rango),
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    FOREIGN KEY (Fk_id_rango) REFERENCES Tbl_rango_fechas(Pk_id_rango)
);

-- Tabla Cotización Encabezado
CREATE TABLE IF NOT EXISTS Tbl_cotizacion_encabezado (
    Pk_id_cotizacionEnc int (11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Fk_id_cliente INT NOT NULL,
    CotizacionEnc_fechaVenc DATE NOT NULL,
    CotizacionEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_cotizacionEnc)
);

-- Tabla Cotización Detalle
CREATE TABLE IF NOT EXISTS Tbl_cotizacion_detalle (
    Pk_id_CotizacionDet int (11) NOT NULL,
    Fk_id_cotizacionEnc INT  NOT NULL, 
    Fk_id_producto INT  NOT NULL,
    CotizacionDet_cantidad INT  NOT NULL,
    CotizacionDet_precio DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_lista_detalle(Pk_id_lista_detalle),
    PRIMARY KEY (Pk_id_CotizacionDet)
);


-- Tabla Pedido Encabezado
CREATE TABLE IF NOT EXISTS Tbl_pedido_encabezado (
    Pk_id_PedidoEnc int (11) NOT NULL,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_vendedor INT  NOT NULL,
    PedidoEncfecha DATE  NOT NULL,
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_PedidoEnc)
);

-- Tabla Pedido Detalle
CREATE TABLE IF NOT EXISTS Tbl_pedido_detalle (
    Pk_id_pedidoDet int (11) NOT NULL,
    Fk_id_pedidoEnc INT,
    Fk_id_producto INT,
    Fk_id_cotizacionEnc int,
    PedidoDet_cantidad int,
    PedidoEnc_precio decimal(10,2),
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_pedidoEnc) REFERENCES Tbl_pedido_encabezado(Pk_id_PedidoEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_productos(Pk_id_producto),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    PRIMARY KEY (Pk_id_pedidoDet)
);

-- Tabla Factura Encabezado
CREATE TABLE IF NOT EXISTS Tbl_factura (
    Pk_id_factura int (11) NOT NULL,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_pedidoEnc INT  NOT NULL,
    factura_fecha DATE  NOT NULL,
    factura_formPago VARCHAR(20)  NOT NULL,
    factura_subtotal DECIMAL(10,2)  NOT NULL,
    factura_iva DECIMAL(10,2)  NOT NULL,
    factura_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
	FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_factura)
);



CREATE TABLE IF NOT EXISTS Tbl_comisiones_encabezado (
    Pk_id_comisionEnc INT(11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Comisiones_fecha_ DATE NOT NULL,
    Comisiones_total_venta DECIMAL(10,2) NOT NULL,
    Comisiones_total_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_comisionEnc)
);

-- Detalle Comisiones
CREATE TABLE IF NOT EXISTS Tbl_detalle_comisiones (
    Pk_id_detalle_comision INT(11) NOT NULL,
    Fk_id_comisionEnc INT NOT NULL,
    Fk_id_factura INT NOT NULL,
    Comisiones_porcentaje DECIMAL(5,2) NOT NULL,
    Comisiones_monto_venta DECIMAL(10,2) NOT NULL,
    Comisiones_monto_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_comisionEnc) REFERENCES Tbl_comisiones_encabezado(Pk_id_comisionEnc),
    FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura),
    PRIMARY KEY (Pk_id_detalle_comision)
);

