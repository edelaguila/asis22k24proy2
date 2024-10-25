-- CREATE DATABASE IF NOT EXISTS Contabilidad;
-- USE Contabilidad;

-- Tabla para encabezados de clases de cuentas
CREATE TABLE IF NOT EXISTS tbl_encabezadoclasecuenta (
    Pk_id_encabezadocuenta INT NOT NULL, 
    nombre_tipocuenta VARCHAR(50) NOT NULL,
    estado TINYINT(1) NOT NULL, 
    PRIMARY KEY (Pk_id_encabezadocuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

-- Tabla para tipos de cuenta
CREATE TABLE IF NOT EXISTS tbl_tipocuenta (
    PK_id_tipocuenta INT NOT NULL, 
    nombre_tipocuenta VARCHAR(50) NOT NULL,
    serie_tipocuenta VARCHAR(50) NOT NULL,
    estado TINYINT NOT NULL, 
    PRIMARY KEY (PK_id_tipocuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

-- Tabla para tipos de póliza
CREATE TABLE IF NOT EXISTS tbl_tipopoliza (
    Pk_id_tipopoliza INT NOT NULL, 
    tipo VARCHAR(65),
    estado TINYINT NOT NULL, 
    PRIMARY KEY (Pk_Id_tipopoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para encabezados de póliza
CREATE TABLE IF NOT EXISTS tbl_polizaencabezado (
    Pk_id_polizaencabezado INT AUTO_INCREMENT NOT NULL, 
    fechaPoliza VARCHAR(50),
    concepto VARCHAR(65),
    Pk_id_tipopoliza INT NOT NULL, 
    PRIMARY KEY (Pk_id_polizaencabezado),
    FOREIGN KEY (Pk_id_tipopoliza) REFERENCES tbl_tipopoliza (Pk_id_tipopoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para tipos de operación
CREATE TABLE IF NOT EXISTS tbl_tipooperacion (
    Pk_id_tipooperacion INT NOT NULL,
    nombre VARCHAR(65), 
    estado TINYINT NOT NULL, 
    PRIMARY KEY (Pk_id_tipooperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para cuentas
CREATE TABLE IF NOT EXISTS tbl_cuentas (
    Pk_id_cuenta INT UNIQUE NOT NULL, 
    Pk_id_tipocuenta INT NOT NULL, 
    Pk_id_encabezadocuenta INT NOT NULL,
    nombre_cuenta VARCHAR(50) NOT NULL,
    cargo_mes FLOAT DEFAULT 0,
    abono_mes FLOAT DEFAULT 0,
    saldo_ant FLOAT DEFAULT 0,
    saldo_act FLOAT DEFAULT 0,
    cargo_acumulado FLOAT DEFAULT 0,
    abono_acumulado FLOAT DEFAULT 0,
    Pk_id_cuenta_enlace INT NULL,
    estado TINYINT NOT NULL,
    
    PRIMARY KEY (Pk_id_cuenta, Pk_id_tipocuenta, Pk_id_encabezadocuenta),
    
    FOREIGN KEY (Pk_id_tipocuenta) REFERENCES tbl_tipocuenta(PK_id_tipocuenta),
    FOREIGN KEY (Pk_id_encabezadocuenta) REFERENCES tbl_encabezadoclasecuenta(Pk_id_encabezadocuenta),
    FOREIGN KEY (Pk_id_cuenta_enlace) REFERENCES tbl_cuentas(Pk_id_cuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

CREATE TABLE IF NOT EXISTS tbl_configuracion (
    Pk_id_config INT AUTO_INCREMENT NOT NULL PRIMARY KEY,      
    mes INT NOT NULL,                                 
    anio INT NOT NULL,                                
    metodo VARCHAR(10) NOT NULL,                     
    Pk_id_cuenta INT NOT NULL,                       
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas(Pk_id_cuenta)  
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabla para activos fijos
CREATE TABLE IF NOT EXISTS tbl_activofijo (
    Pk_id_idactivofijo INT(11) NOT NULL AUTO_INCREMENT,  
    Codigo_Activo VARCHAR(50) NOT NULL,               
    Tipo_Activo VARCHAR(50) DEFAULT NULL,            
    Descripcion VARCHAR(255) NOT NULL,                
    Marca VARCHAR(100) DEFAULT NULL,                  
    Modelo VARCHAR(100) DEFAULT NULL,                
    Fecha_Adquisicion DATE DEFAULT NULL,              
    Costo_Adquisicion DECIMAL(10,2) DEFAULT NULL,    
    Vida_Util DECIMAL(5,2) DEFAULT NULL,              
    Valor_Residual DECIMAL(10,2) DEFAULT NULL,        
    Estado VARCHAR(50) DEFAULT NULL,                  
    Pk_id_cuenta INT NOT NULL,                        
    PRIMARY KEY (Pk_id_idactivofijo),                    
    UNIQUE (Codigo_Activo),                           
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas (Pk_id_cuenta) ON DELETE CASCADE 
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla para detalles de póliza
CREATE TABLE IF NOT EXISTS tbl_polizadetalle (
    Pk_id_polizadetalle INT AUTO_INCREMENT NOT NULL, 
    Pk_id_polizaencabezado INT NOT NULL,
    Pk_id_cuenta INT NOT NULL,
    Pk_id_tipooperacion INT NOT NULL,
    valor FLOAT,

    PRIMARY KEY (Pk_id_polizadetalle),

    FOREIGN KEY (Pk_id_polizaencabezado) REFERENCES tbl_polizaencabezado (Pk_id_polizaencabezado),
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas (Pk_id_cuenta),
    FOREIGN KEY (Pk_id_tipooperacion) REFERENCES tbl_tipooperacion (Pk_id_tipooperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS tbl_historico_cuentas (
    Pk_id_cuenta INT NOT NULL, 
    mes INT NOT NULL,
    anio INT NOT NULL,
    cargo_mes FLOAT DEFAULT 0,
    abono_mes FLOAT DEFAULT 0,
    saldo_ant FLOAT DEFAULT 0,
    saldo_act FLOAT DEFAULT 0,
    cargo_acumulado FLOAT DEFAULT 0,
    abono_acumulado FLOAT DEFAULT 0,
    saldoanual FLOAT DEFAULT 0,
    
    PRIMARY KEY (Pk_id_cuenta, mes, anio),
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas(Pk_id_cuenta)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
