use colchoneria;
-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-09-2024 a las 09:00:00
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `controlempleados`
--

DELIMITER $$
--
-- Procedimientos

DESPUES
-- TABLAS MAESTRAS DE CUENTAS CORRIENTES

-- Esta tabla pertenece al módulo de compras y ventas
CREATE TABLE IF NOT EXISTS `Tbl_vendedor` (
	Pk_id_vendedor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_vendedor VARCHAR(150) NOT NULL,
    direccion_vendedor VARCHAR(150) NOT NULL,
    telefono_vendedor INT NOT NULL,
    departamento_vendedor VARCHAR(150) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- Esta tabla pertenece al módulo de compras y ventas
CREATE TABLE IF NOT EXISTS `Tbl_clientes` (
	Pk_id_cliente INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_vendedor INT NOT NULL,
    nombre_cliente VARCHAR(150) NOT NULL,
    telefono_cliente INT NOT NULL,
    direccion_cliente VARCHAR(150) NOT NULL,
    saldo_cuenta VARCHAR(150) NOT NULL,
	estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `Tbl_vendedor` (`Pk_id_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;  

CREATE TABLE IF NOT EXISTS `Tbl_cobrador` (
	Pk_id_cobrador INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_empleado INT NOT NULL,--Fk_id_empleados pertenece a la tabla de tbl_empleados del módulo de nomina
    nombre_cobrador VARCHAR(150) NOT NULL,
    direccion_cobrador VARCHAR(150) NOT NULL,
    telefono_cobrador INT NOT NULL,
    depto_cobrador VARCHAR(150) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_empleado`) REFERENCES tbl_empleados (pk_clave) -- tbl de nomina
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

CREATE TABLE IF NOT EXISTS `Tbl_paises` (
	Pk_id_pais INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_pais VARCHAR(150) NOT NULL,
    region_pais VARCHAR(150) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS `Tbl_tipodepago` (
	Pk_id_pago INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_pago VARCHAR(150) NOT NULL,
    tipo_moneda VARCHAR(15) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

CREATE TABLE IF NOT EXISTS `Tbl_Deudas_Clientes` (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_cobrador INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    fecha_inicio_deuda VARCHAR(255) NOT NULL,
    fecha_vencimiento_deuda VARCHAR(255) NOT NULL,
    descripcion_deuda VARCHAR(255),
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clientes` (`Pk_id_cliente`),
    FOREIGN KEY (`Fk_id_cobrador`) REFERENCES `Tbl_cobrador` (`Pk_id_cobrador`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_tipodepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
--
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_cliente` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    fecha_transaccion VARCHAR(150) NOT NULL,
    cuenta_tansaccion VARCHAR(150) NOT NULL,
    cuotas_transaccion VARCHAR(2) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    monto_transaccion Decimal(10,2),
    saldo_pendiente Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    tipo_moneda VARCHAR(100) NOT NULL,
    serie_transaccion VARCHAR(100) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clienteS` (`Pk_id_cliente`),
    FOREIGN KEY (`Fk_id_deuda`) REFERENCES `Tbl_Deudas_Clientes` (`Pk_id_deuda`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_tipodepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS mora_clientes (
    Pk_id_mora INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_transaccion INT NOT NULL,
    fecha_mora DATE NOT NULL,
    monto_mora DECIMAL(10, 2) NOT NULL,
    dias_en_mora INT NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_transaccion) REFERENCES Tbl_Transaccion_cliente (Pk_id_transaccion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS Tbl_caja_cliente (
    Pk_id_caja_cliente INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    nombre_cliente VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    monto_mora DECIMAL(10, 2) NOT NULL,
    monto_transaccion DECIMAL(10, 2) NOT NULL,
    saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Clientes (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Esta tabla pertenece al módulo de compras y ventas
CREATE TABLE IF NOT EXISTS `Tbl_proveedores` (
	Pk_id_proveedor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fecha_registro VARCHAR(150) NOT NULL,
    nombre_proveedor VARCHAR(150) NOT NULL,
    direccion VARCHAR(255),
    telefono VARCHAR(20),
    email VARCHAR(100),
    saldo_cuenta VARCHAR(150) NOT NULL,
	estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    CREATE TABLE IF NOT EXISTS `Tbl_Deudas_Proveedores` (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    fecha_inicio_deuda DATE NOT NULL,
    fecha_vencimiento_deuda DATE NOT NULL,
    descripcion_deuda VARCHAR(255),
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `Tbl_proveedores` (`Pk_id_proveedor`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_tipodepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
--
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_proveedor` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    fecha_transaccion VARCHAR(150) NOT NULL,
    cuenta_tansaccion VARCHAR(150) NOT NULL,
    cuotas_transaccion VARCHAR(2) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    monto_transaccion Decimal(10,2),
    saldo_pendiente Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    tipo_moneda VARCHAR(100) NOT NULL,
    serie_transaccion VARCHAR(100) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `Tbl_proveedores` (`Pk_id_proveedor`),
    FOREIGN KEY (`Fk_id_deuda`) REFERENCES `Tbl_Deudas_Proveedores` (`PK_id_deuda`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_tipodepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS Tbl_caja_proveedor (
    Pk_id_caja_proveedor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    nombre_proveedor VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    monto_deuda DECIMAL(10, 2) NOT NULL,
    monto_transaccion DECIMAL(10, 2) NOT NULL,
    saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_proveedor) REFERENCES Tbl_proveedores (Pk_id_proveedor),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Proveedores (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- FIN TABLAS MAESTRAS CUENTAS CORRIENTES
