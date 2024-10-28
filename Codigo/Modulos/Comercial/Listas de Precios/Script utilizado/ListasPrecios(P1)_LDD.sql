CREATE DATABASE ListasPrecios_P1;
USE ListasPrecios_P1;

-- tabla sacada del modulo de logistica
CREATE TABLE IF NOT EXISTS tbl_productos (
    Pk_id_Producto INT AUTO_INCREMENT PRIMARY KEY,
    nombreProducto VARCHAR(30) NOT NULL,
    pesoProducto VARCHAR(20),
    precioUnitario DECIMAL(10, 2) NOT NULL,
    clasificacion VARCHAR(30),
    stock INT NOT NULL,
    empaque VARCHAR(50),
    codigoProducto INT NOT NULL,
    estado TINYINT(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- cambios realizados para el funcionamiento de mi modulo 
-- campos que necesito tbl_productos tenga y no posee 

ALTER TABLE tbl_productos
MODIFY nombreProducto VARCHAR(50) NOT NULL; -- este lo aplique yo porque algunos de los nombres de los productos de prueba eran de mas de 30

ALTER TABLE tbl_productos
ADD COLUMN precio_venta DECIMAL(10, 2) AFTER precioUnitario,
ADD COLUMN costo_compra DECIMAL(10, 2) AFTER precio_venta;

-- tablas creadas por mi (funcionamiento de lists precios)

-- Tabla para líneas de productos
CREATE TABLE tbl_lineas (
    pk_id_linea INT AUTO_INCREMENT PRIMARY KEY,
    nombre_linea VARCHAR(50) NOT NULL
);

-- Tabla para marcas de productos
CREATE TABLE tbl_marcas (
    pk_id_marca INT AUTO_INCREMENT PRIMARY KEY,
    nombre_marca VARCHAR(50) NOT NULL
);

-- Tabla para categorías de inventario
CREATE TABLE tbl_inventario (
    pk_id_inventario INT AUTO_INCREMENT PRIMARY KEY,
    descripcion_inventario VARCHAR(50) NOT NULL
);

-- Tabla de asociación entre productos y líneas
CREATE TABLE tbl_producto_linea (
    fk_id_producto INT,
    fk_id_linea INT,
    PRIMARY KEY (fk_id_producto, fk_id_linea),
    FOREIGN KEY (fk_id_producto) REFERENCES tbl_productos (Pk_id_Producto),
    FOREIGN KEY (fk_id_linea) REFERENCES tbl_lineas (pk_id_linea)
);

-- Tabla de asociación entre productos y marcas
CREATE TABLE tbl_producto_marca (
    fk_id_producto INT,
    fk_id_marca INT,
    PRIMARY KEY (fk_id_producto, fk_id_marca),
    FOREIGN KEY (fk_id_producto) REFERENCES tbl_productos (Pk_id_Producto),
    FOREIGN KEY (fk_id_marca) REFERENCES tbl_marcas (pk_id_marca)
);

-- Tabla de asociación entre productos e inventario
CREATE TABLE tbl_producto_inventario (
    fk_id_producto INT,
    fk_id_inventario INT,
    PRIMARY KEY (fk_id_producto, fk_id_inventario),
    FOREIGN KEY (fk_id_producto) REFERENCES tbl_productos (Pk_id_Producto),
    FOREIGN KEY (fk_id_inventario) REFERENCES tbl_inventario (pk_id_inventario)
);

-- tablas importantes 
CREATE TABLE IF NOT EXISTS Tbl_lista_encabezado (
    Pk_id_lista_Encabezado INT(11) NOT NULL,
    ListEncabezado_nombre VARCHAR(50),
    ListEncabezado_fecha DATE,
    ListEncabezado_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_lista_Encabezado)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS Tbl_lista_detalle (
    Pk_id_lista_detalle INT(11) NOT NULL,
    Fk_id_lista_Encabezado INT,
    Fk_id_Producto INT,
    ListDetalle_clasif VARCHAR(50) NOT NULL, -- clasificación general
    ListDetalle_tipo VARCHAR(50) NOT NULL, -- clasificación especifica
    ListDetalle_cod VARCHAR(50) NOT NULL, 
    ListDetalle_prod VARCHAR(50) NOT NULL, 
    ListDetalle_preU DECIMAL(10, 2) NOT NULL,
    ListDetalle_preV DECIMAL(10, 2) NOT NULL,
    ListDetalle_costoC DECIMAL(10, 2) NOT NULL,
    ListDetalle_peso VARCHAR(20) NOT NULL,
    ListDetalle_stock INT NOT NULL,
    ListDetalle_empaque VARCHAR(50) NOT NULL, 
    ListDetalle_gananciaI DECIMAL(10, 2) NOT NULL,
    ListDetalle_gananciaF DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (Fk_id_lista_Encabezado) REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado),
    FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto),
	PRIMARY KEY (Pk_id_lista_detalle)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


