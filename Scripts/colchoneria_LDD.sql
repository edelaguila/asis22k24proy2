drop database if exists colchoneria;
create database colchoneria;
use colchoneria;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-10-2024 a las 04:03:00
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
-- Base de datos: `colchoneria`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContraModulo` (IN `p_usuario` INT, IN `p_nueva_contrasenia` VARCHAR(100))   BEGIN
    -- Actualizar la contraseña del usuario
    UPDATE tbl_usuarios
    SET password_usuario = p_nueva_contrasenia
    WHERE pk_id_usuario = p_usuario;

    -- Confirmar que el cambio se realizó
    IF ROW_COUNT() > 0 THEN
        SELECT 'Contraseña actualizada con éxito' AS resultado;
    ELSE
        SELECT 'Usuario no encontrado' AS resultado;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContrasenia` (IN `usuario` VARCHAR(255), IN `nuevaContrasenia` VARCHAR(255), IN `respuestaSeguridad` VARCHAR(255))   BEGIN
    DECLARE respuestaGuardada VARCHAR(255);
    DECLARE usuarioExiste INT;

    -- Verificar si el usuario existe
    SELECT COUNT(*) INTO usuarioExiste 
    FROM tbl_usuarios 
    WHERE username_usuario = usuario;

    IF usuarioExiste = 0 THEN
        -- Si el usuario no existe, devolver mensaje de error
        SELECT 'Usuario no encontrado' AS resultado;
    ELSE
        -- Obtener la respuesta de seguridad desde la base de datos
        SELECT respuesta INTO respuestaGuardada 
        FROM tbl_usuarios 
        WHERE username_usuario = usuario;

        -- Verificar si la respuesta ingresada coincide con la guardada
        IF LOWER(respuestaGuardada) = LOWER(respuestaSeguridad) THEN
            -- Actualizar la contraseña
            UPDATE tbl_usuarios
            SET password_usuario = nuevaContrasenia
            WHERE username_usuario = usuario;
            
            -- Devolver el resultado exitoso
            SELECT 'Contraseña actualizada con éxito' AS resultado;
        ELSE
            -- Devolver resultado si la respuesta de seguridad es incorrecta
            SELECT 'Respuesta de seguridad incorrecta' AS resultado;
        END IF;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cambioContrasenia` (IN `p_usuario` VARCHAR(20))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN        
        SELECT 'Usuario encontrado' AS resu;
    ELSE
        SELECT 'Usuario no encontrado' AS resu;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `p_usuario` VARCHAR(20), IN `p_clave` VARCHAR(100))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario AND password_usuario = p_clave;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN
        UPDATE tbl_usuarios
        SET ultima_conexion_usuario = NOW()
        WHERE username_usuario = p_usuario AND password_usuario = p_clave;
        
        SELECT 'Inicio de sesión exitoso' AS resultado;
    ELSE
        SELECT 'Inicio de sesión fallido' AS resultado;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` varchar(255) DEFAULT NULL,
  `indice` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `Pk_id_detalle_factura` int(11) NOT NULL,
  `fk_id_factura` int(11) DEFAULT NULL,
  `descripcion_factura` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `codigo_empleado` int(11) NOT NULL,
  `nombre_completo` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `puesto` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `departamento` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `Pk_id_factura` int(11) NOT NULL,
  `fecha_factura` date DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `Pk_id_pago` int(11) NOT NULL,
  `fk_id_factura` int(11) DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_empleados`
--

CREATE TABLE `registro_empleados` (
  `codigo_registro` int(11) NOT NULL,
  `codigo_empleado` int(11) NOT NULL,
  `fecha_registro` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida` time DEFAULT NULL,
  `total_de_horas` time DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_activofijo`
--

CREATE TABLE `tbl_activofijo` (
  `Pk_id_idactivofijo` int(11) NOT NULL,
  `Codigo_Activo` varchar(50) NOT NULL,
  `Tipo_Activo` varchar(50) DEFAULT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Marca` varchar(100) DEFAULT NULL,
  `Modelo` varchar(100) DEFAULT NULL,
  `Fecha_Adquisicion` date DEFAULT NULL,
  `Costo_Adquisicion` decimal(10,2) DEFAULT NULL,
  `Vida_Util` decimal(5,2) DEFAULT NULL,
  `Valor_Residual` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Pk_id_cuenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicaciones`
--

CREATE TABLE `tbl_aplicaciones` (
  `Pk_id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignaciones_perfils_usuario`
--

CREATE TABLE `tbl_asignaciones_perfils_usuario` (
  `PK_id_Perfil_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacion_modulo_aplicacion`
--

CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_id_modulos` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacion_vacaciones`
--

CREATE TABLE `tbl_asignacion_vacaciones` (
  `pk_registro_vaciones` int(11) NOT NULL,
  `asignacion_vacaciones_descripcion` varchar(25) DEFAULT NULL,
  `asignacion_vacaciones_fecha_inicio` date DEFAULT NULL,
  `asignacion_vacaciones_fecha_fin` date DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_auditorias`
--

CREATE TABLE `tbl_auditorias` (
  `Pk_ID_AUDITORIA` int(11) NOT NULL,
  `Fk_ID_BODEGA` int(11) NOT NULL,
  `Fk_ID_PRODUCTO` int(11) NOT NULL,
  `FECHA_AUDITORIA` date DEFAULT NULL,
  `DISCREPANCIA_DETECTADA` tinyint(1) DEFAULT 0,
  `CANTIDAD_REGISTRADA` int(11) NOT NULL,
  `CANTIDAD_FISICA` int(11) NOT NULL,
  `OBSERVACIONES` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_banco`
--

CREATE TABLE `tbl_banco` (
  `pk_banco_id` int(11) NOT NULL,
  `banco_nombre` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `Pk_id_bitacora` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(200) NOT NULL,
  `tabla` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bodegas`
--

CREATE TABLE `tbl_bodegas` (
  `Pk_ID_BODEGA` int(11) NOT NULL,
  `NOMBRE_BODEGA` varchar(100) NOT NULL,
  `UBICACION` varchar(255) NOT NULL,
  `CAPACIDAD` int(11) NOT NULL,
  `FECHA_REGISTRO` date DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_caja_cliente`
--

CREATE TABLE `tbl_caja_cliente` (
  `Pk_id_caja_cliente` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `caja_cliente_nombre` varchar(150) NOT NULL,
  `Fk_id_deuda` int(11) NOT NULL,
  `caja_deuda_monto` decimal(10,2) NOT NULL,
  `caja_mora_monto` decimal(10,2) NOT NULL,
  `caja_transaccion_monto` decimal(10,2) NOT NULL,
  `caja_saldo_restante` decimal(10,2) NOT NULL DEFAULT 0.00,
  `caja_estado` tinyint(4) NOT NULL DEFAULT 1,
  `caja_fecha_registro` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_caja_proveedor`
--

CREATE TABLE `tbl_caja_proveedor` (
  `Pk_id_caja_proveedor` int(11) NOT NULL,
  `Fk_id_proveedor` int(11) NOT NULL,
  `caja_proveedor_nombre` varchar(150) NOT NULL,
  `Fk_id_deuda` int(11) NOT NULL,
  `caja_deuda_monto` decimal(10,2) NOT NULL,
  `caja_transaccion_monto` decimal(10,2) NOT NULL,
  `caja_saldo_restante` decimal(10,2) NOT NULL DEFAULT 0.00,
  `caja_estado` tinyint(4) NOT NULL DEFAULT 1,
  `caja_fecha_registro` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_chofer`
--

CREATE TABLE `tbl_chofer` (
  `Pk_id_chofer` int(11) NOT NULL,
  `nombreEmpresa` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `licencia` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `direccion` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_clientes`
--

CREATE TABLE `tbl_clientes` (
  `Pk_id_cliente` int(11) NOT NULL,
  `Clientes_nombre` varchar(100) NOT NULL,
  `Clientes_apellido` varchar(100) NOT NULL,
  `Clientes_nit` varchar(20) NOT NULL,
  `Clientes_telefon` varchar(20) NOT NULL,
  `Clientes_direccion` varchar(255) NOT NULL,
  `Clientes_No_Cuenta` varchar(255) NOT NULL,
  `Clientes_estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cobrador`
--

CREATE TABLE `tbl_cobrador` (
  `Pk_id_cobrador` int(11) NOT NULL,
  `Fk_id_empleado` int(11) NOT NULL,
  `cobrador_nombre` varchar(150) NOT NULL,
  `cobrador_direccion` varchar(150) NOT NULL,
  `cobrador_telefono` int(11) NOT NULL,
  `cobrador_depto` varchar(150) NOT NULL,
  `cobrador_estado` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_comisiones_encabezado`
--

CREATE TABLE `tbl_comisiones_encabezado` (
  `Pk_id_comisionEnc` int(11) NOT NULL,
  `Fk_id_vendedor` int(11) NOT NULL,
  `Comisiones_fecha_` date NOT NULL,
  `Comisiones_total_venta` decimal(10,2) NOT NULL,
  `Comisiones_total_comision` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_configuracion`
--

CREATE TABLE `tbl_configuracion` (
  `Pk_id_config` int(11) NOT NULL,
  `mes` int(11) NOT NULL,
  `anio` int(11) NOT NULL,
  `metodo` varchar(10) NOT NULL,
  `Pk_id_cuenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_consultainteligente`
--

CREATE TABLE `tbl_consultainteligente` (
  `Pk_consultaID` int(11) NOT NULL,
  `nombre_consulta` varchar(50) NOT NULL,
  `tipo_consulta` int(1) NOT NULL,
  `consulta_SQLE` varchar(100) NOT NULL,
  `consulta_estatus` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_contabilidad`
--

CREATE TABLE `tbl_contabilidad` (
  `Pk_id_contabilidad` int(11) NOT NULL,
  `Contabilidad_tipo_registro` varchar(50) NOT NULL,
  `Contabilidad_descripcion` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_contratos`
--

CREATE TABLE `tbl_contratos` (
  `pk_id_contrato` int(11) NOT NULL,
  `contratos_fecha_creacion` date NOT NULL,
  `contratos_salario` decimal(10,2) NOT NULL,
  `contratos_tipo_contrato` varchar(35) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_control_anticipos`
--

CREATE TABLE `tbl_control_anticipos` (
  `pk_registro_anticipos` int(11) NOT NULL,
  `anticipos_cantidad` decimal(10,2) DEFAULT NULL,
  `anticipos_descripcion` varchar(50) DEFAULT NULL,
  `anticipos_mes` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_control_faltas`
--

CREATE TABLE `tbl_control_faltas` (
  `pk_registro_faltas` int(11) NOT NULL,
  `faltas_fecha_falta` date DEFAULT NULL,
  `faltas_mes` varchar(25) DEFAULT NULL,
  `faltas_justificacion` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizacion_detalle`
--

CREATE TABLE `tbl_cotizacion_detalle` (
  `Pk_id_CotizacionDet` int(11) NOT NULL,
  `Fk_id_cotizacionEnc` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `CotizacionDet_cantidad` int(11) NOT NULL,
  `CotizacionDet_precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizacion_encabezado`
--

CREATE TABLE `tbl_cotizacion_encabezado` (
  `Pk_id_cotizacionEnc` int(11) NOT NULL,
  `Fk_id_vendedor` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `CotizacionEnc_fechaVenc` date NOT NULL,
  `CotizacionEnc_total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cuentabancaria`
--

CREATE TABLE `tbl_cuentabancaria` (
  `pk_cuenta_id` int(11) NOT NULL,
  `fk_banco_id` int(11) NOT NULL,
  `cuenta_numero` varchar(20) NOT NULL,
  `cuenta_saldo` decimal(10,2) NOT NULL,
  `cuenta_tipo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cuentas`
--

CREATE TABLE `tbl_cuentas` (
  `Pk_id_cuenta` int(11) NOT NULL,
  `Pk_id_tipocuenta` int(11) NOT NULL,
  `Pk_id_encabezadocuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(50) NOT NULL,
  `cargo_mes` float DEFAULT 0,
  `abono_mes` float DEFAULT 0,
  `saldo_ant` float DEFAULT 0,
  `saldo_act` float DEFAULT 0,
  `cargo_acumulado` float DEFAULT 0,
  `abono_acumulado` float DEFAULT 0,
  `Pk_id_cuenta_enlace` int(11) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_datos_pedido`
--

CREATE TABLE `tbl_datos_pedido` (
  `Pk_id_guia` int(11) NOT NULL,
  `fechaEmision` date NOT NULL,
  `fechaTraslado` date NOT NULL,
  `direccionPartida` varchar(255) NOT NULL,
  `direccionLlegada` varchar(255) NOT NULL,
  `numeroOrdenRecojo` varchar(20) DEFAULT NULL,
  `formaPago` varchar(50) NOT NULL,
  `destino` varchar(255) NOT NULL,
  `Fk_id_remitente` int(11) NOT NULL,
  `Fk_id_destinatario` int(11) NOT NULL,
  `Fk_id_vehiculo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_dedu_perp`
--

CREATE TABLE `tbl_dedu_perp` (
  `pk_dedu_perp` int(11) NOT NULL,
  `dedu_perp_clase` varchar(25) DEFAULT NULL,
  `dedu_perp_concepto` varchar(25) DEFAULT NULL,
  `dedu_perp_tipo` varchar(25) DEFAULT NULL,
  `dedu_perp_aplicacion` varchar(25) DEFAULT NULL,
  `dedu_perp_excepcion` tinyint(1) DEFAULT NULL,
  `dedu_perp_monto` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_dedu_perp_emp`
--

CREATE TABLE `tbl_dedu_perp_emp` (
  `pk_dedu_perp_emp` int(11) NOT NULL,
  `Fk_clave_empleado` int(11) NOT NULL,
  `Fk_dedu_perp` int(11) NOT NULL,
  `dedu_perp_emp_cantidad` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_departamentos`
--

CREATE TABLE `tbl_departamentos` (
  `pk_id_departamento` int(11) NOT NULL,
  `departamentos_nombre_departamento` varchar(50) DEFAULT NULL,
  `departamentos_descripcion` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_destinatario`
--

CREATE TABLE `tbl_destinatario` (
  `Pk_id_destinatario` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `correoElectronico` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_comisiones`
--

CREATE TABLE `tbl_detalle_comisiones` (
  `Pk_id_detalle_comision` int(11) NOT NULL,
  `Fk_id_comisionEnc` int(11) NOT NULL,
  `Fk_id_factura` int(11) NOT NULL,
  `Comisiones_porcentaje` decimal(5,2) NOT NULL,
  `Comisiones_monto_venta` decimal(10,2) NOT NULL,
  `Comisiones_monto_comision` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_ordenes_compra`
--

CREATE TABLE `tbl_detalle_ordenes_compra` (
  `Pk_detOrCom_id` int(11) NOT NULL,
  `Fk_encOrCom_id` int(11) DEFAULT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `DetOrCom_cantidad` int(11) NOT NULL,
  `DetOrCom_preUni` decimal(10,2) NOT NULL,
  `DetOrCom_total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_deudas_clientes`
--

CREATE TABLE `tbl_deudas_clientes` (
  `Pk_id_deuda` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_cobrador` int(11) NOT NULL,
  `Fk_id_pago` int(11) NOT NULL,
  `deuda_monto` decimal(10,2) NOT NULL,
  `deuda_fecha_inicio_deuda` varchar(255) NOT NULL,
  `deuda_fecha_vencimiento_deuda` varchar(255) NOT NULL,
  `deuda_descripcion_deuda` varchar(255) DEFAULT NULL,
  `deuda_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_deudas_proveedores`
--

CREATE TABLE `tbl_deudas_proveedores` (
  `Pk_id_deuda` int(11) NOT NULL,
  `Fk_id_proveedor` int(11) NOT NULL,
  `Fk_id_pago` int(11) NOT NULL,
  `deuda_monto` decimal(10,2) NOT NULL,
  `deuda_fecha_inicio` date NOT NULL,
  `deuda_fecha_vencimiento` date NOT NULL,
  `deuda_descripcion` varchar(255) DEFAULT NULL,
  `deuda_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empleados`
--

CREATE TABLE `tbl_empleados` (
  `pk_clave` int(11) NOT NULL,
  `empleados_nombre` varchar(50) NOT NULL,
  `empleados_apellido` varchar(50) DEFAULT NULL,
  `empleados_fecha_nacimiento` date DEFAULT NULL,
  `empleados_no_identificacion` varchar(50) NOT NULL,
  `empleados_codigo_postal` varchar(50) DEFAULT NULL,
  `empleados_fecha_alta` date DEFAULT NULL,
  `empleados_fecha_baja` date DEFAULT NULL,
  `empleados_causa_baja` varchar(50) DEFAULT NULL,
  `fk_id_departamento` int(11) NOT NULL,
  `fk_id_puestos` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empresas`
--

CREATE TABLE `tbl_empresas` (
  `empresa_id` int(11) NOT NULL,
  `empresas_nombre` varchar(255) NOT NULL,
  `empresas_logo` longblob DEFAULT NULL,
  `empresas_fecha_creacion` timestamp NOT NULL DEFAULT current_timestamp(),
  `empresas_direccion` varchar(255) DEFAULT NULL,
  `empresas_telefono` varchar(20) DEFAULT NULL,
  `empresas_email` varchar(100) DEFAULT NULL,
  `empresas_pagina_web` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadoclasecuenta`
--

CREATE TABLE `tbl_encabezadoclasecuenta` (
  `Pk_id_encabezadocuenta` int(11) NOT NULL,
  `nombre_tipocuenta` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_existencias_bodega`
--

CREATE TABLE `tbl_existencias_bodega` (
  `Pk_ID_EXISTENCIA` int(11) NOT NULL,
  `Fk_ID_BODEGA` int(11) NOT NULL,
  `Fk_ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD_ACTUAL` int(11) NOT NULL,
  `CANTIDAD_INICIAL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_factura`
--

CREATE TABLE `tbl_factura` (
  `Pk_id_factura` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_pedidoEnc` int(11) NOT NULL,
  `factura_fecha` date NOT NULL,
  `factura_formPago` varchar(20) NOT NULL,
  `factura_subtotal` decimal(10,2) NOT NULL,
  `factura_iva` decimal(10,2) NOT NULL,
  `factura_total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_formadepago`
--

CREATE TABLE `tbl_formadepago` (
  `Pk_id_pago` int(11) NOT NULL,
  `pago_nombre` varchar(150) NOT NULL,
  `pago_tipo_moneda` varchar(15) NOT NULL,
  `pado_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_historico_cuentas`
--

CREATE TABLE `tbl_historico_cuentas` (
  `Pk_id_cuenta` int(11) NOT NULL,
  `mes` int(11) NOT NULL,
  `anio` int(11) NOT NULL,
  `cargo_mes` float DEFAULT 0,
  `abono_mes` float DEFAULT 0,
  `saldo_ant` float DEFAULT 0,
  `saldo_act` float DEFAULT 0,
  `cargo_acumulado` float DEFAULT 0,
  `abono_acumulado` float DEFAULT 0,
  `saldoanual` float DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_horas_extra`
--

CREATE TABLE `tbl_horas_extra` (
  `pk_registro_horas` int(11) NOT NULL,
  `horas_mes` varchar(25) DEFAULT NULL,
  `horas_cantidad_horas` decimal(10,2) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_linea`
--

CREATE TABLE `tbl_linea` (
  `Pk_id_linea` int(11) NOT NULL,
  `nombre_linea` varchar(50) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `fk_id_marca` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_liquidacion_trabajadores`
--

CREATE TABLE `tbl_liquidacion_trabajadores` (
  `pk_registro_liquidacion` int(11) NOT NULL,
  `liquidacion_aguinaldo` decimal(10,2) NOT NULL,
  `liquidacion_bono_14` decimal(10,2) NOT NULL,
  `liquidacion_vacaciones` decimal(10,2) NOT NULL,
  `liquidacion_tipo_operacion` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_lista_detalle`
--

CREATE TABLE `tbl_lista_detalle` (
  `Pk_id_lista_detalle` int(11) NOT NULL,
  `Fk_id_lista_Encabezado` int(11) NOT NULL,
  `Fk_id_Producto` int(11) NOT NULL,
  `ListDetalle_preVenta` decimal(10,2) DEFAULT NULL,
  `ListDetalle_descuento` decimal(10,2) DEFAULT NULL,
  `ListDetalle_impuesto` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_lista_encabezado`
--

CREATE TABLE `tbl_lista_encabezado` (
  `Pk_id_lista_Encabezado` int(11) NOT NULL,
  `ListEncabezado_nombre` varchar(50) DEFAULT NULL,
  `ListEncabezado_fecha` date DEFAULT NULL,
  `ListEncabezado_estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_locales`
--

CREATE TABLE `tbl_locales` (
  `Pk_ID_LOCAL` int(11) NOT NULL,
  `NOMBRE_LOCAL` varchar(100) NOT NULL,
  `UBICACION` varchar(255) NOT NULL,
  `CAPACIDAD` int(11) NOT NULL,
  `ESTADO` varchar(50) NOT NULL DEFAULT 'Activo',
  `FECHA_REGISTRO` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mantenimiento`
--

CREATE TABLE `tbl_mantenimiento` (
  `Pk_id_Mantenimiento` int(11) NOT NULL,
  `nombre_Solicitante` varchar(20) NOT NULL,
  `tipo_de_Mantenimiento` varchar(15) NOT NULL,
  `componente_Afectado` varchar(15) NOT NULL,
  `fecha` date NOT NULL,
  `responsable_Asignado` varchar(20) NOT NULL,
  `codigo_Error_Problema` varchar(50) NOT NULL,
  `estado_del_Mantenimiento` varchar(20) NOT NULL,
  `tiempo_Estimado` varchar(30) NOT NULL,
  `Fk_id_movimiento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_marca`
--

CREATE TABLE `tbl_marca` (
  `Pk_id_Marca` int(11) NOT NULL,
  `nombre_Marca` varchar(50) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `fk_id_Producto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulos`
--

CREATE TABLE `tbl_modulos` (
  `Pk_id_modulos` int(11) NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mora_clientes`
--

CREATE TABLE `tbl_mora_clientes` (
  `Pk_id_mora` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_transaccion` int(11) NOT NULL,
  `morafecha` date NOT NULL,
  `mora_monto` decimal(10,2) NOT NULL,
  `mora_dias` int(11) NOT NULL,
  `mora_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_movimiento`
--

CREATE TABLE `tbl_movimiento` (
  `Pk_id_movimiento` int(11) NOT NULL,
  `Movimiento_codigo` varchar(50) NOT NULL,
  `Movimiento_cuenta` varchar(50) NOT NULL,
  `Movimiento_tipo` varchar(20) NOT NULL,
  `Movimiento_valor` decimal(10,2) NOT NULL,
  `Movimiento_cargos` decimal(10,2) NOT NULL,
  `Movimiento_abonos` decimal(10,2) NOT NULL,
  `Fk_id_poliza` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_movimientobancario`
--

CREATE TABLE `tbl_movimientobancario` (
  `pk_movimientobancario_id` int(11) NOT NULL,
  `fk_cuenta_id` int(11) NOT NULL,
  `movimientobancario_fecha` date NOT NULL,
  `movimientobancario_tipo` varchar(50) NOT NULL,
  `movimientobancario_monto` decimal(10,2) NOT NULL,
  `movimientobancario_descripcion` text DEFAULT NULL,
  `movimientobancario_metodo_pago` varchar(50) DEFAULT NULL,
  `movimientobancario_estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_movimiento_de_inventario`
--

CREATE TABLE `tbl_movimiento_de_inventario` (
  `Pk_id_movimiento` int(11) NOT NULL,
  `estado` varchar(15) DEFAULT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `Fk_id_stock` int(11) NOT NULL,
  `Fk_ID_LOCALES` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordenes_compra`
--

CREATE TABLE `tbl_ordenes_compra` (
  `Pk_encOrCom_id` int(11) NOT NULL,
  `EncOrCom_numero` varchar(20) NOT NULL,
  `Fk_prov_id` int(11) DEFAULT NULL,
  `EncOrCom_fechaEntrega` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_paises`
--

CREATE TABLE `tbl_paises` (
  `Pk_id_pais` int(11) NOT NULL,
  `pais_nombre` varchar(150) NOT NULL,
  `pais_region` varchar(150) NOT NULL,
  `pais_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pedido_detalle`
--

CREATE TABLE `tbl_pedido_detalle` (
  `Pk_id_pedidoDet` int(11) NOT NULL,
  `Fk_id_pedidoEnc` int(11) DEFAULT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `Fk_id_cotizacionEnc` int(11) DEFAULT NULL,
  `PedidoDet_cantidad` int(11) DEFAULT NULL,
  `PedidoEnc_precio` decimal(10,2) DEFAULT NULL,
  `PedidoEnc_total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pedido_encabezado`
--

CREATE TABLE `tbl_pedido_encabezado` (
  `Pk_id_PedidoEnc` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_vendedor` int(11) NOT NULL,
  `PedidoEncfecha` date NOT NULL,
  `PedidoEnc_total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfiles`
--

CREATE TABLE `tbl_perfiles` (
  `Pk_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicaciones_usuario`
--

CREATE TABLE `tbl_permisos_aplicaciones_usuario` (
  `PK_id_Aplicacion_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicacion_perfil`
--

CREATE TABLE `tbl_permisos_aplicacion_perfil` (
  `PK_id_Aplicacion_Perfil` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_planilla_detalle`
--

CREATE TABLE `tbl_planilla_detalle` (
  `pk_registro_planilla_Detalle` int(11) NOT NULL,
  `detalle_total_Percepciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_Deducciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_liquido` decimal(10,2) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `fk_id_contrato` int(11) NOT NULL,
  `fk_id_registro_planilla_Encabezado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_planilla_encabezado`
--

CREATE TABLE `tbl_planilla_encabezado` (
  `pk_registro_planilla_Encabezado` int(11) NOT NULL,
  `encabezado_correlativo_planilla` int(11) NOT NULL,
  `encabezado_fecha_inicio` date DEFAULT NULL,
  `encabezado_fecha_final` date DEFAULT NULL,
  `encabezado_total_mes` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza`
--

CREATE TABLE `tbl_poliza` (
  `Pk_id_poliza` int(11) NOT NULL,
  `Poliza_fecha_emision` date NOT NULL,
  `Poliza_concepto` varchar(255) NOT NULL,
  `Poliza_docto` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_polizadetalle`
--

CREATE TABLE `tbl_polizadetalle` (
  `Pk_id_polizadetalle` int(11) NOT NULL,
  `Pk_id_polizaencabezado` int(11) NOT NULL,
  `Pk_id_cuenta` int(11) NOT NULL,
  `Pk_id_tipooperacion` int(11) NOT NULL,
  `valor` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_polizaencabezado`
--

CREATE TABLE `tbl_polizaencabezado` (
  `Pk_id_polizaencabezado` int(11) NOT NULL,
  `fechaPoliza` varchar(50) DEFAULT NULL,
  `concepto` varchar(65) DEFAULT NULL,
  `Pk_id_tipopoliza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza_contabilidad`
--

CREATE TABLE `tbl_poliza_contabilidad` (
  `Fk_id_poliza` int(11) NOT NULL,
  `Fk_id_contabilidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza_rango_fechas`
--

CREATE TABLE `tbl_poliza_rango_fechas` (
  `Fk_id_poliza` int(11) NOT NULL,
  `Fk_id_rango` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_productos`
--

CREATE TABLE `tbl_productos` (
  `Pk_id_Producto` int(11) NOT NULL,
  `codigoProducto` int(11) NOT NULL,
  `nombreProducto` varchar(30) NOT NULL,
  `pesoProducto` varchar(20) DEFAULT NULL,
  `precioUnitario` decimal(10,2) NOT NULL,
  `clasificacion` varchar(30) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `stock` int(11) NOT NULL,
  `empaque` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_proveedores`
--

CREATE TABLE `tbl_proveedores` (
  `Pk_prov_id` int(11) NOT NULL,
  `Prov_nombre` varchar(100) NOT NULL,
  `Prov_direccion` varchar(255) DEFAULT NULL,
  `Prov_telefono` varchar(20) DEFAULT NULL,
  `Prov_email` varchar(100) DEFAULT NULL,
  `Prov_fechaRegistro` date DEFAULT NULL,
  `Prov_estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_puestos_trabajo`
--

CREATE TABLE `tbl_puestos_trabajo` (
  `pk_id_puestos` int(11) NOT NULL,
  `puestos_nombre_puesto` varchar(50) DEFAULT NULL,
  `puestos_descripcion` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rango_fechas`
--

CREATE TABLE `tbl_rango_fechas` (
  `Pk_id_rango` int(11) NOT NULL,
  `Rango_fecha_inicio` date NOT NULL,
  `Rango_fecha_fin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_regreporteria`
--

CREATE TABLE `tbl_regreporteria` (
  `idregistro` int(11) NOT NULL,
  `ruta` varchar(500) NOT NULL,
  `nombre_archivo` varchar(45) NOT NULL,
  `aplicacion` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `Fk_id_modulos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_remitente`
--

CREATE TABLE `tbl_remitente` (
  `Pk_id_remitente` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `correoElectronico` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipocambio`
--

CREATE TABLE `tbl_tipocambio` (
  `pk_id_tipoCambio` int(11) NOT NULL,
  `tipoCambio_nombre_moneda` varchar(50) NOT NULL,
  `tipoCambio_valor_moneda` decimal(5,3) NOT NULL,
  `tipoCambio_valorCambio_moneda` decimal(5,3) NOT NULL,
  `tipoCambio_estatus` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipocuenta`
--

CREATE TABLE `tbl_tipocuenta` (
  `PK_id_tipocuenta` int(11) NOT NULL,
  `nombre_tipocuenta` varchar(50) NOT NULL,
  `serie_tipocuenta` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipooperacion`
--

CREATE TABLE `tbl_tipooperacion` (
  `Pk_id_tipooperacion` int(11) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipopoliza`
--

CREATE TABLE `tbl_tipopoliza` (
  `Pk_id_tipopoliza` int(11) NOT NULL,
  `tipo` varchar(65) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_transaccion`
--

CREATE TABLE `tbl_transaccion` (
  `pk_transaccion_id` int(11) NOT NULL,
  `fk_cuenta_id` int(11) NOT NULL,
  `transaccion_fecha` datetime NOT NULL,
  `transaccion_monto` decimal(10,2) NOT NULL,
  `transaccion_estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_transaccion_cliente`
--

CREATE TABLE `tbl_transaccion_cliente` (
  `Pk_id_transaccion` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_pais` int(11) NOT NULL,
  `transaccion_fecha` varchar(150) NOT NULL,
  `tansaccion_cuenta` varchar(150) NOT NULL,
  `transaccion_cuotas` varchar(2) NOT NULL,
  `transaccion_monto` decimal(10,2) DEFAULT NULL,
  `Fk_id_pago` int(11) NOT NULL,
  `transaccion_tipo_moneda` varchar(100) NOT NULL,
  `transaccionserie` varchar(100) NOT NULL,
  `transaccion_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_transaccion_proveedor`
--

CREATE TABLE `tbl_transaccion_proveedor` (
  `Pk_id_transaccion` int(11) NOT NULL,
  `Fk_id_proveedor` int(11) NOT NULL,
  `Fk_id_pais` int(11) NOT NULL,
  `fecha_transaccion` varchar(150) NOT NULL,
  `tansaccion_cuenta` varchar(150) NOT NULL,
  `tansaccion_cuotas` varchar(2) NOT NULL,
  `transaccion_monto` decimal(10,2) DEFAULT NULL,
  `Fk_id_pago` int(11) NOT NULL,
  `transaccion_tipo_moneda` varchar(100) NOT NULL,
  `transaccion_serie` varchar(100) NOT NULL,
  `transaccion_estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_trasladoproductos`
--

CREATE TABLE `tbl_trasladoproductos` (
  `Pk_id_TrasladoProductos` int(11) NOT NULL,
  `documento` varchar(50) NOT NULL,
  `fecha` datetime NOT NULL,
  `costoTotal` decimal(10,2) NOT NULL,
  `costoTotalGeneral` decimal(10,2) NOT NULL,
  `precioTotal` decimal(10,2) NOT NULL,
  `Fk_id_Producto` int(11) NOT NULL,
  `Fk_id_guia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuarios`
--

CREATE TABLE `tbl_usuarios` (
  `Pk_id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `ultima_conexion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint(4) NOT NULL DEFAULT 0,
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vehiculos`
--

CREATE TABLE `tbl_vehiculos` (
  `Pk_id_vehiculo` int(11) NOT NULL,
  `numeroPlaca` varchar(10) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `color` varchar(30) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `horaLlegada` datetime NOT NULL,
  `horaSalida` datetime DEFAULT NULL,
  `pesoTotal` decimal(10,2) NOT NULL,
  `Fk_id_chofer` int(11) NOT NULL,
  `Estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vendedores`
--

CREATE TABLE `tbl_vendedores` (
  `Pk_id_vendedor` int(11) NOT NULL,
  `vendedores_nombre` varchar(100) NOT NULL,
  `vendedores_apellido` varchar(100) NOT NULL,
  `vendedores_sueldo` decimal(10,2) NOT NULL,
  `vendedores_direccion` varchar(255) NOT NULL,
  `vendedores_telefono` varchar(20) NOT NULL,
  `Fk_id_empleado` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `vendedores_estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `id_venta` int(11) NOT NULL,
  `monto` int(11) NOT NULL,
  `nombre_cliente` varchar(50) NOT NULL,
  `nombre_empleado` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwaplicacionperfil`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionperfil` (
`ID` int(11)
,`Perfil` varchar(50)
,`Aplicacion` int(11)
,`Insertar` tinyint(1)
,`Modificar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwaplicacionusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionusuario` (
`Aplicacion` int(11)
,`ID` int(11)
,`Usuario` varchar(50)
,`Insertar` tinyint(1)
,`Editar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwmoduloaplicacion`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwmoduloaplicacion` (
`ID` int(11)
,`Modulo` varchar(50)
,`Aplicacion` int(11)
,`Nombre` varchar(50)
,`Descripcion` varchar(150)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwperfilusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwperfilusuario` (
`ID` int(11)
,`Usuario` varchar(50)
,`nickName` varchar(20)
,`perfil` int(11)
,`Nombre` varchar(50)
);

-- --------------------------------------------------------
-- MODULO PRODUCCION INICIO
CREATE TABLE IF NOT EXISTS `tbl_cierre_produccion` (
  `pk_id_cierre` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `saldo_anterior` decimal(10,2) NOT NULL,
  `cargos_mes` decimal(10,2) NOT NULL,
  `abonos_mes` decimal(10,2) NOT NULL,
  `saldo_actual` decimal(10,2) NOT NULL,
  `cargos_acumulados` decimal(10,2) NOT NULL,
  `abonos_acumulados` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_conversiones` (
  `id_conversion` int(11) NOT NULL,
  `unidad_origen` varchar(50) NOT NULL,
  `unidad_destino` varchar(50) NOT NULL,
  `factor_conversion` decimal(10,6) NOT NULL,
  `tipo_conversion` varchar(50) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_detalles` (
  `Pk_id_lotes_detalle` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `Fk_id_lote` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_encabezado` (
  `Pk_id_lote` int(11) NOT NULL,
  `codigo_lote` varchar(100) DEFAULT NULL,
  `Fecha_Producción` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_mantenimientos` (
  `Pk_id_maquinaria` int(11) NOT NULL,
  `nombre_maquinaria` varchar(255) DEFAULT NULL,
  `tipo_maquina` varchar(255) DEFAULT NULL,
  `hora_operacion` decimal(10,2) DEFAULT NULL,
  `mantenimiento_periodico` varchar(100) DEFAULT NULL,
  `ultima_mantenimiento` date DEFAULT NULL,
  `proximo_mantenimiento` date DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `desgaste_porcentaje` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion` (
  `Pk_id_orden` int(11) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_orden` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_detalle` (
  `Pk_id_proceso_detalle` int(11) NOT NULL,
  `Fk_id_productos` int(11) DEFAULT NULL,
  `Fk_id_receta` int(11) DEFAULT NULL,
  `Fk_id_empleado` int(11) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `costo_u` decimal(10,2) DEFAULT NULL,
  `costo_t` decimal(10,2) DEFAULT NULL,
  `duracion_horas` decimal(10,2) DEFAULT NULL,
  `mano_de_obra` decimal(10,2) DEFAULT NULL,
  `costo_luz` decimal(10,2) DEFAULT NULL,
  `costo_agua` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_encabezado` (
  `Pk_id_proceso` int(11) NOT NULL,
  `Fk_id_orden` int(11) DEFAULT NULL,
  `Fk_id_maquinaria` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_recetas` (
  `Pk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `cama` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_receta_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_rrhh_produccion` (
  `id_RRHH` int(10) UNSIGNED NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `id_contrato` int(11) NOT NULL,
  `dias` int(11) NOT NULL,
  `total_dias` decimal(10,2) NOT NULL,
  `horas` decimal(10,2) NOT NULL,
  `total_horas` decimal(10,2) NOT NULL,
  `id_hora_extra` int(11) DEFAULT NULL,
  `total_horas_extras` decimal(10,2) DEFAULT NULL,
  `total_mano_obra` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
-- MODULO PRODUCCION FINAL

--
-- Estructura para la vista `vwaplicacionperfil`
--
DROP TABLE IF EXISTS `vwaplicacionperfil`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwaplicacionperfil`  AS SELECT `b`.`Fk_id_perfil` AS `ID`, `a`.`nombre_perfil` AS `Perfil`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Modificar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicacion_perfil` `b` join `tbl_perfiles` `a` on(`a`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwaplicacionusuario`
--
DROP TABLE IF EXISTS `vwaplicacionusuario`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwaplicacionusuario`  AS SELECT `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Editar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicaciones_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwmoduloaplicacion`
--
DROP TABLE IF EXISTS `vwmoduloaplicacion`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwmoduloaplicacion`  AS SELECT `b`.`Fk_id_modulos` AS `ID`, `a`.`nombre_modulo` AS `Modulo`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `c`.`nombre_aplicacion` AS `Nombre`, `c`.`descripcion_aplicacion` AS `Descripcion` FROM ((`tbl_asignacion_modulo_aplicacion` `b` join `tbl_modulos` `a` on(`a`.`Pk_id_modulos` = `b`.`Fk_id_modulos`)) join `tbl_aplicaciones` `c` on(`c`.`Pk_id_aplicacion` = `b`.`Fk_id_aplicacion`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwperfilusuario`
--
DROP TABLE IF EXISTS `vwperfilusuario`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwperfilusuario`  AS SELECT `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `a`.`username_usuario` AS `nickName`, `b`.`Fk_id_perfil` AS `perfil`, `c`.`nombre_perfil` AS `Nombre` FROM ((`tbl_asignaciones_perfils_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) join `tbl_perfiles` `c` on(`c`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  ADD PRIMARY KEY (`Id_ayuda`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`Pk_id_detalle_factura`),
  ADD KEY `fk_id_factura` (`fk_id_factura`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`codigo_empleado`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`Pk_id_factura`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`Pk_id_pago`),
  ADD KEY `fk_id_factura` (`fk_id_factura`);

--
-- Indices de la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  ADD PRIMARY KEY (`codigo_registro`),
  ADD KEY `fk_codigo_empleado` (`codigo_empleado`);

--
-- Indices de la tabla `tbl_activofijo`
--
ALTER TABLE `tbl_activofijo`
  ADD PRIMARY KEY (`Pk_id_idactivofijo`),
  ADD UNIQUE KEY `Codigo_Activo` (`Codigo_Activo`),
  ADD KEY `Pk_id_cuenta` (`Pk_id_cuenta`);

--
-- Indices de la tabla `tbl_aplicaciones`
--
ALTER TABLE `tbl_aplicaciones`
  ADD PRIMARY KEY (`Pk_id_aplicacion`);

--
-- Indices de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD PRIMARY KEY (`PK_id_Perfil_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD PRIMARY KEY (`Fk_id_modulos`,`Fk_id_aplicacion`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_asignacion_vacaciones`
--
ALTER TABLE `tbl_asignacion_vacaciones`
  ADD PRIMARY KEY (`pk_registro_vaciones`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_auditorias`
--
ALTER TABLE `tbl_auditorias`
  ADD PRIMARY KEY (`Pk_ID_AUDITORIA`),
  ADD KEY `Fk_ID_BODEGA` (`Fk_ID_BODEGA`),
  ADD KEY `Fk_ID_PRODUCTO` (`Fk_ID_PRODUCTO`);

--
-- Indices de la tabla `tbl_banco`
--
ALTER TABLE `tbl_banco`
  ADD PRIMARY KEY (`pk_banco_id`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`Pk_id_bitacora`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_bodegas`
--
ALTER TABLE `tbl_bodegas`
  ADD PRIMARY KEY (`Pk_ID_BODEGA`);

--
-- Indices de la tabla `tbl_caja_cliente`
--
ALTER TABLE `tbl_caja_cliente`
  ADD PRIMARY KEY (`Pk_id_caja_cliente`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`),
  ADD KEY `Fk_id_deuda` (`Fk_id_deuda`);

--
-- Indices de la tabla `tbl_caja_proveedor`
--
ALTER TABLE `tbl_caja_proveedor`
  ADD PRIMARY KEY (`Pk_id_caja_proveedor`),
  ADD KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  ADD KEY `Fk_id_deuda` (`Fk_id_deuda`);

--
-- Indices de la tabla `tbl_chofer`
--
ALTER TABLE `tbl_chofer`
  ADD PRIMARY KEY (`Pk_id_chofer`);

--
-- Indices de la tabla `tbl_clientes`
--
ALTER TABLE `tbl_clientes`
  ADD PRIMARY KEY (`Pk_id_cliente`);

--
-- Indices de la tabla `tbl_cobrador`
--
ALTER TABLE `tbl_cobrador`
  ADD PRIMARY KEY (`Pk_id_cobrador`),
  ADD KEY `Fk_id_empleado` (`Fk_id_empleado`);

--
-- Indices de la tabla `tbl_comisiones_encabezado`
--
ALTER TABLE `tbl_comisiones_encabezado`
  ADD PRIMARY KEY (`Pk_id_comisionEnc`),
  ADD KEY `Fk_id_vendedor` (`Fk_id_vendedor`);

--
-- Indices de la tabla `tbl_configuracion`
--
ALTER TABLE `tbl_configuracion`
  ADD PRIMARY KEY (`Pk_id_config`),
  ADD KEY `Pk_id_cuenta` (`Pk_id_cuenta`);

--
-- Indices de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  ADD PRIMARY KEY (`Pk_consultaID`);

--
-- Indices de la tabla `tbl_contabilidad`
--
ALTER TABLE `tbl_contabilidad`
  ADD PRIMARY KEY (`Pk_id_contabilidad`);

--
-- Indices de la tabla `tbl_contratos`
--
ALTER TABLE `tbl_contratos`
  ADD PRIMARY KEY (`pk_id_contrato`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_control_anticipos`
--
ALTER TABLE `tbl_control_anticipos`
  ADD PRIMARY KEY (`pk_registro_anticipos`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_control_faltas`
--
ALTER TABLE `tbl_control_faltas`
  ADD PRIMARY KEY (`pk_registro_faltas`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_cotizacion_detalle`
--
ALTER TABLE `tbl_cotizacion_detalle`
  ADD PRIMARY KEY (`Pk_id_CotizacionDet`),
  ADD KEY `Fk_id_cotizacionEnc` (`Fk_id_cotizacionEnc`),
  ADD KEY `Fk_id_producto` (`Fk_id_producto`);

--
-- Indices de la tabla `tbl_cotizacion_encabezado`
--
ALTER TABLE `tbl_cotizacion_encabezado`
  ADD PRIMARY KEY (`Pk_id_cotizacionEnc`),
  ADD KEY `Fk_id_vendedor` (`Fk_id_vendedor`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`);

--
-- Indices de la tabla `tbl_cuentabancaria`
--
ALTER TABLE `tbl_cuentabancaria`
  ADD PRIMARY KEY (`pk_cuenta_id`),
  ADD UNIQUE KEY `cuenta_numero` (`cuenta_numero`),
  ADD KEY `fk_banco` (`fk_banco_id`);

--
-- Indices de la tabla `tbl_cuentas`
--
ALTER TABLE `tbl_cuentas`
  ADD PRIMARY KEY (`Pk_id_cuenta`,`Pk_id_tipocuenta`,`Pk_id_encabezadocuenta`),
  ADD UNIQUE KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  ADD KEY `Pk_id_tipocuenta` (`Pk_id_tipocuenta`),
  ADD KEY `Pk_id_encabezadocuenta` (`Pk_id_encabezadocuenta`),
  ADD KEY `Pk_id_cuenta_enlace` (`Pk_id_cuenta_enlace`);

--
-- Indices de la tabla `tbl_datos_pedido`
--
ALTER TABLE `tbl_datos_pedido`
  ADD PRIMARY KEY (`Pk_id_guia`),
  ADD KEY `Fk_id_remitente` (`Fk_id_remitente`),
  ADD KEY `Fk_id_destinatario` (`Fk_id_destinatario`),
  ADD KEY `Fk_id_vehiculo` (`Fk_id_vehiculo`);

--
-- Indices de la tabla `tbl_dedu_perp`
--
ALTER TABLE `tbl_dedu_perp`
  ADD PRIMARY KEY (`pk_dedu_perp`);

--
-- Indices de la tabla `tbl_dedu_perp_emp`
--
ALTER TABLE `tbl_dedu_perp_emp`
  ADD PRIMARY KEY (`pk_dedu_perp_emp`),
  ADD KEY `Fk_clave_empleado` (`Fk_clave_empleado`),
  ADD KEY `Fk_dedu_perp` (`Fk_dedu_perp`);

--
-- Indices de la tabla `tbl_departamentos`
--
ALTER TABLE `tbl_departamentos`
  ADD PRIMARY KEY (`pk_id_departamento`);

--
-- Indices de la tabla `tbl_destinatario`
--
ALTER TABLE `tbl_destinatario`
  ADD PRIMARY KEY (`Pk_id_destinatario`);

--
-- Indices de la tabla `tbl_detalle_comisiones`
--
ALTER TABLE `tbl_detalle_comisiones`
  ADD PRIMARY KEY (`Pk_id_detalle_comision`),
  ADD KEY `Fk_id_comisionEnc` (`Fk_id_comisionEnc`),
  ADD KEY `Fk_id_factura` (`Fk_id_factura`);

--
-- Indices de la tabla `tbl_detalle_ordenes_compra`
--
ALTER TABLE `tbl_detalle_ordenes_compra`
  ADD PRIMARY KEY (`Pk_detOrCom_id`),
  ADD KEY `Fk_encOrCom_id` (`Fk_encOrCom_id`),
  ADD KEY `Fk_id_producto` (`Fk_id_producto`);

--
-- Indices de la tabla `tbl_deudas_clientes`
--
ALTER TABLE `tbl_deudas_clientes`
  ADD PRIMARY KEY (`Pk_id_deuda`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`),
  ADD KEY `Fk_id_cobrador` (`Fk_id_cobrador`),
  ADD KEY `Fk_id_pago` (`Fk_id_pago`);

--
-- Indices de la tabla `tbl_deudas_proveedores`
--
ALTER TABLE `tbl_deudas_proveedores`
  ADD PRIMARY KEY (`Pk_id_deuda`),
  ADD KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  ADD KEY `Fk_id_pago` (`Fk_id_pago`);

--
-- Indices de la tabla `tbl_empleados`
--
ALTER TABLE `tbl_empleados`
  ADD PRIMARY KEY (`pk_clave`),
  ADD KEY `fk_id_departamento` (`fk_id_departamento`),
  ADD KEY `fk_id_puestos` (`fk_id_puestos`);

--
-- Indices de la tabla `tbl_empresas`
--
ALTER TABLE `tbl_empresas`
  ADD PRIMARY KEY (`empresa_id`);

--
-- Indices de la tabla `tbl_encabezadoclasecuenta`
--
ALTER TABLE `tbl_encabezadoclasecuenta`
  ADD PRIMARY KEY (`Pk_id_encabezadocuenta`);

--
-- Indices de la tabla `tbl_existencias_bodega`
--
ALTER TABLE `tbl_existencias_bodega`
  ADD PRIMARY KEY (`Pk_ID_EXISTENCIA`),
  ADD KEY `FK_EXISTENCIA_BODEGA` (`Fk_ID_BODEGA`),
  ADD KEY `FK_EXISTENCIA_PRODUCTO` (`Fk_ID_PRODUCTO`);

--
-- Indices de la tabla `tbl_factura`
--
ALTER TABLE `tbl_factura`
  ADD PRIMARY KEY (`Pk_id_factura`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`);

--
-- Indices de la tabla `tbl_formadepago`
--
ALTER TABLE `tbl_formadepago`
  ADD PRIMARY KEY (`Pk_id_pago`);

--
-- Indices de la tabla `tbl_historico_cuentas`
--
ALTER TABLE `tbl_historico_cuentas`
  ADD PRIMARY KEY (`Pk_id_cuenta`,`mes`,`anio`);

--
-- Indices de la tabla `tbl_horas_extra`
--
ALTER TABLE `tbl_horas_extra`
  ADD PRIMARY KEY (`pk_registro_horas`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_linea`
--
ALTER TABLE `tbl_linea`
  ADD PRIMARY KEY (`Pk_id_linea`),
  ADD KEY `fk_id_marca` (`fk_id_marca`);

--
-- Indices de la tabla `tbl_liquidacion_trabajadores`
--
ALTER TABLE `tbl_liquidacion_trabajadores`
  ADD PRIMARY KEY (`pk_registro_liquidacion`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`);

--
-- Indices de la tabla `tbl_lista_detalle`
--
ALTER TABLE `tbl_lista_detalle`
  ADD PRIMARY KEY (`Pk_id_lista_detalle`),
  ADD KEY `Fk_id_lista_Encabezado` (`Fk_id_lista_Encabezado`),
  ADD KEY `Fk_id_Producto` (`Fk_id_Producto`);

--
-- Indices de la tabla `tbl_lista_encabezado`
--
ALTER TABLE `tbl_lista_encabezado`
  ADD PRIMARY KEY (`Pk_id_lista_Encabezado`);

--
-- Indices de la tabla `tbl_locales`
--
ALTER TABLE `tbl_locales`
  ADD PRIMARY KEY (`Pk_ID_LOCAL`);

--
-- Indices de la tabla `tbl_mantenimiento`
--
ALTER TABLE `tbl_mantenimiento`
  ADD PRIMARY KEY (`Pk_id_Mantenimiento`),
  ADD KEY `Fk_id_movimiento` (`Fk_id_movimiento`);

--
-- Indices de la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  ADD PRIMARY KEY (`Pk_id_Marca`),
  ADD KEY `fk_id_Producto` (`fk_id_Producto`);

--
-- Indices de la tabla `tbl_modulos`
--
ALTER TABLE `tbl_modulos`
  ADD PRIMARY KEY (`Pk_id_modulos`);

--
-- Indices de la tabla `tbl_mora_clientes`
--
ALTER TABLE `tbl_mora_clientes`
  ADD PRIMARY KEY (`Pk_id_mora`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`),
  ADD KEY `Fk_id_transaccion` (`Fk_id_transaccion`);

--
-- Indices de la tabla `tbl_movimiento`
--
ALTER TABLE `tbl_movimiento`
  ADD PRIMARY KEY (`Pk_id_movimiento`),
  ADD KEY `Fk_id_poliza` (`Fk_id_poliza`);

--
-- Indices de la tabla `tbl_movimientobancario`
--
ALTER TABLE `tbl_movimientobancario`
  ADD PRIMARY KEY (`pk_movimientobancario_id`),
  ADD KEY `fk_cuenta` (`fk_cuenta_id`);

--
-- Indices de la tabla `tbl_movimiento_de_inventario`
--
ALTER TABLE `tbl_movimiento_de_inventario`
  ADD PRIMARY KEY (`Pk_id_movimiento`),
  ADD KEY `Fk_id_producto` (`Fk_id_producto`),
  ADD KEY `Fk_id_stock` (`Fk_id_stock`),
  ADD KEY `FK_EXISTENCIA_LOCAL` (`Fk_ID_LOCALES`);

--
-- Indices de la tabla `tbl_ordenes_compra`
--
ALTER TABLE `tbl_ordenes_compra`
  ADD PRIMARY KEY (`Pk_encOrCom_id`),
  ADD UNIQUE KEY `EncOrCom_numero` (`EncOrCom_numero`),
  ADD KEY `Fk_prov_id` (`Fk_prov_id`);

--
-- Indices de la tabla `tbl_paises`
--
ALTER TABLE `tbl_paises`
  ADD PRIMARY KEY (`Pk_id_pais`);

--
-- Indices de la tabla `tbl_pedido_detalle`
--
ALTER TABLE `tbl_pedido_detalle`
  ADD PRIMARY KEY (`Pk_id_pedidoDet`),
  ADD KEY `Fk_id_pedidoEnc` (`Fk_id_pedidoEnc`),
  ADD KEY `Fk_id_producto` (`Fk_id_producto`),
  ADD KEY `Fk_id_cotizacionEnc` (`Fk_id_cotizacionEnc`);

--
-- Indices de la tabla `tbl_pedido_encabezado`
--
ALTER TABLE `tbl_pedido_encabezado`
  ADD PRIMARY KEY (`Pk_id_PedidoEnc`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`),
  ADD KEY `Fk_id_vendedor` (`Fk_id_vendedor`);

--
-- Indices de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  ADD PRIMARY KEY (`Pk_id_perfil`);

--
-- Indices de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Perfil`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_planilla_detalle`
--
ALTER TABLE `tbl_planilla_detalle`
  ADD PRIMARY KEY (`pk_registro_planilla_Detalle`),
  ADD KEY `fk_clave_empleado` (`fk_clave_empleado`),
  ADD KEY `fk_id_contrato` (`fk_id_contrato`),
  ADD KEY `fk_id_registro_planilla_Encabezado` (`fk_id_registro_planilla_Encabezado`);

--
-- Indices de la tabla `tbl_planilla_encabezado`
--
ALTER TABLE `tbl_planilla_encabezado`
  ADD PRIMARY KEY (`pk_registro_planilla_Encabezado`);

--
-- Indices de la tabla `tbl_poliza`
--
ALTER TABLE `tbl_poliza`
  ADD PRIMARY KEY (`Pk_id_poliza`);

--
-- Indices de la tabla `tbl_polizadetalle`
--
ALTER TABLE `tbl_polizadetalle`
  ADD PRIMARY KEY (`Pk_id_polizadetalle`),
  ADD KEY `Pk_id_polizaencabezado` (`Pk_id_polizaencabezado`),
  ADD KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  ADD KEY `Pk_id_tipooperacion` (`Pk_id_tipooperacion`);

--
-- Indices de la tabla `tbl_polizaencabezado`
--
ALTER TABLE `tbl_polizaencabezado`
  ADD PRIMARY KEY (`Pk_id_polizaencabezado`),
  ADD KEY `Pk_id_tipopoliza` (`Pk_id_tipopoliza`);

--
-- Indices de la tabla `tbl_poliza_contabilidad`
--
ALTER TABLE `tbl_poliza_contabilidad`
  ADD PRIMARY KEY (`Fk_id_poliza`,`Fk_id_contabilidad`),
  ADD KEY `Fk_id_contabilidad` (`Fk_id_contabilidad`);

--
-- Indices de la tabla `tbl_poliza_rango_fechas`
--
ALTER TABLE `tbl_poliza_rango_fechas`
  ADD PRIMARY KEY (`Fk_id_poliza`,`Fk_id_rango`),
  ADD KEY `Fk_id_rango` (`Fk_id_rango`);

--
-- Indices de la tabla `tbl_productos`
--
ALTER TABLE `tbl_productos`
  ADD PRIMARY KEY (`Pk_id_Producto`);

--
-- Indices de la tabla `tbl_proveedores`
--
ALTER TABLE `tbl_proveedores`
  ADD PRIMARY KEY (`Pk_prov_id`);

--
-- Indices de la tabla `tbl_puestos_trabajo`
--
ALTER TABLE `tbl_puestos_trabajo`
  ADD PRIMARY KEY (`pk_id_puestos`);

--
-- Indices de la tabla `tbl_rango_fechas`
--
ALTER TABLE `tbl_rango_fechas`
  ADD PRIMARY KEY (`Pk_id_rango`);

--
-- Indices de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD PRIMARY KEY (`idregistro`),
  ADD KEY `Fk_id_modulos` (`Fk_id_modulos`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_remitente`
--
ALTER TABLE `tbl_remitente`
  ADD PRIMARY KEY (`Pk_id_remitente`);

--
-- Indices de la tabla `tbl_tipocambio`
--
ALTER TABLE `tbl_tipocambio`
  ADD PRIMARY KEY (`pk_id_tipoCambio`);

--
-- Indices de la tabla `tbl_tipocuenta`
--
ALTER TABLE `tbl_tipocuenta`
  ADD PRIMARY KEY (`PK_id_tipocuenta`);

--
-- Indices de la tabla `tbl_tipooperacion`
--
ALTER TABLE `tbl_tipooperacion`
  ADD PRIMARY KEY (`Pk_id_tipooperacion`);

--
-- Indices de la tabla `tbl_tipopoliza`
--
ALTER TABLE `tbl_tipopoliza`
  ADD PRIMARY KEY (`Pk_id_tipopoliza`);

--
-- Indices de la tabla `tbl_transaccion`
--
ALTER TABLE `tbl_transaccion`
  ADD PRIMARY KEY (`pk_transaccion_id`),
  ADD KEY `fk_cuenta_id` (`fk_cuenta_id`);

--
-- Indices de la tabla `tbl_transaccion_cliente`
--
ALTER TABLE `tbl_transaccion_cliente`
  ADD PRIMARY KEY (`Pk_id_transaccion`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`),
  ADD KEY `Fk_id_pago` (`Fk_id_pago`),
  ADD KEY `Fk_id_pais` (`Fk_id_pais`);

--
-- Indices de la tabla `tbl_transaccion_proveedor`
--
ALTER TABLE `tbl_transaccion_proveedor`
  ADD PRIMARY KEY (`Pk_id_transaccion`),
  ADD KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  ADD KEY `Fk_id_pago` (`Fk_id_pago`),
  ADD KEY `Fk_id_pais` (`Fk_id_pais`);

--
-- Indices de la tabla `tbl_trasladoproductos`
--
ALTER TABLE `tbl_trasladoproductos`
  ADD PRIMARY KEY (`Pk_id_TrasladoProductos`),
  ADD KEY `Fk_id_Producto` (`Fk_id_Producto`),
  ADD KEY `Fk_id_guia` (`Fk_id_guia`);

--
-- Indices de la tabla `tbl_usuarios`
--
ALTER TABLE `tbl_usuarios`
  ADD PRIMARY KEY (`Pk_id_usuario`);

--
-- Indices de la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD PRIMARY KEY (`Pk_id_vehiculo`),
  ADD KEY `Fk_id_chofer` (`Fk_id_chofer`);

--
-- Indices de la tabla `tbl_vendedores`
--
ALTER TABLE `tbl_vendedores`
  ADD PRIMARY KEY (`Pk_id_vendedor`),
  ADD KEY `Fk_id_empleado` (`Fk_id_empleado`),
  ADD KEY `Fk_id_cliente` (`Fk_id_cliente`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id_venta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  MODIFY `Id_ayuda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  MODIFY `Pk_id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `codigo_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `Pk_id_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `Pk_id_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  MODIFY `codigo_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT de la tabla `tbl_activofijo`
--
ALTER TABLE `tbl_activofijo`
  MODIFY `Pk_id_idactivofijo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  MODIFY `PK_id_Perfil_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tbl_asignacion_vacaciones`
--
ALTER TABLE `tbl_asignacion_vacaciones`
  MODIFY `pk_registro_vaciones` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_auditorias`
--
ALTER TABLE `tbl_auditorias`
  MODIFY `Pk_ID_AUDITORIA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_banco`
--
ALTER TABLE `tbl_banco`
  MODIFY `pk_banco_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `Pk_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=200;

--
-- AUTO_INCREMENT de la tabla `tbl_bodegas`
--
ALTER TABLE `tbl_bodegas`
  MODIFY `Pk_ID_BODEGA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_caja_cliente`
--
ALTER TABLE `tbl_caja_cliente`
  MODIFY `Pk_id_caja_cliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_caja_proveedor`
--
ALTER TABLE `tbl_caja_proveedor`
  MODIFY `Pk_id_caja_proveedor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_chofer`
--
ALTER TABLE `tbl_chofer`
  MODIFY `Pk_id_chofer` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_cobrador`
--
ALTER TABLE `tbl_cobrador`
  MODIFY `Pk_id_cobrador` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_configuracion`
--
ALTER TABLE `tbl_configuracion`
  MODIFY `Pk_id_config` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  MODIFY `Pk_consultaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_contratos`
--
ALTER TABLE `tbl_contratos`
  MODIFY `pk_id_contrato` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_control_anticipos`
--
ALTER TABLE `tbl_control_anticipos`
  MODIFY `pk_registro_anticipos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_control_faltas`
--
ALTER TABLE `tbl_control_faltas`
  MODIFY `pk_registro_faltas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_cuentabancaria`
--
ALTER TABLE `tbl_cuentabancaria`
  MODIFY `pk_cuenta_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_datos_pedido`
--
ALTER TABLE `tbl_datos_pedido`
  MODIFY `Pk_id_guia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_dedu_perp`
--
ALTER TABLE `tbl_dedu_perp`
  MODIFY `pk_dedu_perp` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_dedu_perp_emp`
--
ALTER TABLE `tbl_dedu_perp_emp`
  MODIFY `pk_dedu_perp_emp` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_departamentos`
--
ALTER TABLE `tbl_departamentos`
  MODIFY `pk_id_departamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_destinatario`
--
ALTER TABLE `tbl_destinatario`
  MODIFY `Pk_id_destinatario` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_deudas_clientes`
--
ALTER TABLE `tbl_deudas_clientes`
  MODIFY `Pk_id_deuda` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_deudas_proveedores`
--
ALTER TABLE `tbl_deudas_proveedores`
  MODIFY `Pk_id_deuda` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_empleados`
--
ALTER TABLE `tbl_empleados`
  MODIFY `pk_clave` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_empresas`
--
ALTER TABLE `tbl_empresas`
  MODIFY `empresa_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_existencias_bodega`
--
ALTER TABLE `tbl_existencias_bodega`
  MODIFY `Pk_ID_EXISTENCIA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_formadepago`
--
ALTER TABLE `tbl_formadepago`
  MODIFY `Pk_id_pago` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_horas_extra`
--
ALTER TABLE `tbl_horas_extra`
  MODIFY `pk_registro_horas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_linea`
--
ALTER TABLE `tbl_linea`
  MODIFY `Pk_id_linea` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_liquidacion_trabajadores`
--
ALTER TABLE `tbl_liquidacion_trabajadores`
  MODIFY `pk_registro_liquidacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_locales`
--
ALTER TABLE `tbl_locales`
  MODIFY `Pk_ID_LOCAL` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_mantenimiento`
--
ALTER TABLE `tbl_mantenimiento`
  MODIFY `Pk_id_Mantenimiento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  MODIFY `Pk_id_Marca` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_mora_clientes`
--
ALTER TABLE `tbl_mora_clientes`
  MODIFY `Pk_id_mora` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_movimientobancario`
--
ALTER TABLE `tbl_movimientobancario`
  MODIFY `pk_movimientobancario_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_movimiento_de_inventario`
--
ALTER TABLE `tbl_movimiento_de_inventario`
  MODIFY `Pk_id_movimiento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_paises`
--
ALTER TABLE `tbl_paises`
  MODIFY `Pk_id_pais` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  MODIFY `Pk_id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  MODIFY `PK_id_Aplicacion_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  MODIFY `PK_id_Aplicacion_Perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=223;

--
-- AUTO_INCREMENT de la tabla `tbl_planilla_detalle`
--
ALTER TABLE `tbl_planilla_detalle`
  MODIFY `pk_registro_planilla_Detalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_planilla_encabezado`
--
ALTER TABLE `tbl_planilla_encabezado`
  MODIFY `pk_registro_planilla_Encabezado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_polizadetalle`
--
ALTER TABLE `tbl_polizadetalle`
  MODIFY `Pk_id_polizadetalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_polizaencabezado`
--
ALTER TABLE `tbl_polizaencabezado`
  MODIFY `Pk_id_polizaencabezado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_productos`
--
ALTER TABLE `tbl_productos`
  MODIFY `Pk_id_Producto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_puestos_trabajo`
--
ALTER TABLE `tbl_puestos_trabajo`
  MODIFY `pk_id_puestos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  MODIFY `idregistro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tbl_remitente`
--
ALTER TABLE `tbl_remitente`
  MODIFY `Pk_id_remitente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_tipocambio`
--
ALTER TABLE `tbl_tipocambio`
  MODIFY `pk_id_tipoCambio` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_transaccion`
--
ALTER TABLE `tbl_transaccion`
  MODIFY `pk_transaccion_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_transaccion_cliente`
--
ALTER TABLE `tbl_transaccion_cliente`
  MODIFY `Pk_id_transaccion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_transaccion_proveedor`
--
ALTER TABLE `tbl_transaccion_proveedor`
  MODIFY `Pk_id_transaccion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_trasladoproductos`
--
ALTER TABLE `tbl_trasladoproductos`
  MODIFY `Pk_id_TrasladoProductos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_usuarios`
--
ALTER TABLE `tbl_usuarios`
  MODIFY `Pk_id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  MODIFY `Pk_id_vehiculo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `detallefactura_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `factura` (`Pk_id_factura`);

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `factura` (`Pk_id_factura`);

--
-- Filtros para la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  ADD CONSTRAINT `fk_codigo_empleado` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleados` (`codigo_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tbl_activofijo`
--
ALTER TABLE `tbl_activofijo`
  ADD CONSTRAINT `tbl_activofijo_ibfk_1` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`) ON DELETE CASCADE;

--
-- Filtros para la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_asignacion_vacaciones`
--
ALTER TABLE `tbl_asignacion_vacaciones`
  ADD CONSTRAINT `tbl_asignacion_vacaciones_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_auditorias`
--
ALTER TABLE `tbl_auditorias`
  ADD CONSTRAINT `tbl_auditorias_ibfk_1` FOREIGN KEY (`Fk_ID_BODEGA`) REFERENCES `tbl_bodegas` (`Pk_ID_BODEGA`),
  ADD CONSTRAINT `tbl_auditorias_ibfk_2` FOREIGN KEY (`Fk_ID_PRODUCTO`) REFERENCES `tbl_productos` (`Pk_id_Producto`);

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_bitacora_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_caja_cliente`
--
ALTER TABLE `tbl_caja_cliente`
  ADD CONSTRAINT `tbl_caja_cliente_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_caja_cliente_ibfk_2` FOREIGN KEY (`Fk_id_deuda`) REFERENCES `tbl_deudas_clientes` (`Pk_id_deuda`);

--
-- Filtros para la tabla `tbl_caja_proveedor`
--
ALTER TABLE `tbl_caja_proveedor`
  ADD CONSTRAINT `tbl_caja_proveedor_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  ADD CONSTRAINT `tbl_caja_proveedor_ibfk_2` FOREIGN KEY (`Fk_id_deuda`) REFERENCES `tbl_deudas_proveedores` (`Pk_id_deuda`);

--
-- Filtros para la tabla `tbl_cobrador`
--
ALTER TABLE `tbl_cobrador`
  ADD CONSTRAINT `tbl_cobrador_ibfk_1` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_comisiones_encabezado`
--
ALTER TABLE `tbl_comisiones_encabezado`
  ADD CONSTRAINT `tbl_comisiones_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`);

--
-- Filtros para la tabla `tbl_configuracion`
--
ALTER TABLE `tbl_configuracion`
  ADD CONSTRAINT `tbl_configuracion_ibfk_1` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`);

--
-- Filtros para la tabla `tbl_contratos`
--
ALTER TABLE `tbl_contratos`
  ADD CONSTRAINT `tbl_contratos_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_control_anticipos`
--
ALTER TABLE `tbl_control_anticipos`
  ADD CONSTRAINT `tbl_control_anticipos_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_control_faltas`
--
ALTER TABLE `tbl_control_faltas`
  ADD CONSTRAINT `tbl_control_faltas_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_cotizacion_detalle`
--
ALTER TABLE `tbl_cotizacion_detalle`
  ADD CONSTRAINT `tbl_cotizacion_detalle_ibfk_1` FOREIGN KEY (`Fk_id_cotizacionEnc`) REFERENCES `tbl_cotizacion_encabezado` (`Pk_id_cotizacionEnc`),
  ADD CONSTRAINT `tbl_cotizacion_detalle_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_lista_detalle` (`Pk_id_lista_detalle`);

--
-- Filtros para la tabla `tbl_cotizacion_encabezado`
--
ALTER TABLE `tbl_cotizacion_encabezado`
  ADD CONSTRAINT `tbl_cotizacion_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`),
  ADD CONSTRAINT `tbl_cotizacion_encabezado_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`);

--
-- Filtros para la tabla `tbl_cuentabancaria`
--
ALTER TABLE `tbl_cuentabancaria`
  ADD CONSTRAINT `fk_banco` FOREIGN KEY (`fk_banco_id`) REFERENCES `tbl_banco` (`pk_banco_id`);

--
-- Filtros para la tabla `tbl_cuentas`
--
ALTER TABLE `tbl_cuentas`
  ADD CONSTRAINT `tbl_cuentas_ibfk_1` FOREIGN KEY (`Pk_id_tipocuenta`) REFERENCES `tbl_tipocuenta` (`PK_id_tipocuenta`),
  ADD CONSTRAINT `tbl_cuentas_ibfk_2` FOREIGN KEY (`Pk_id_encabezadocuenta`) REFERENCES `tbl_encabezadoclasecuenta` (`Pk_id_encabezadocuenta`),
  ADD CONSTRAINT `tbl_cuentas_ibfk_3` FOREIGN KEY (`Pk_id_cuenta_enlace`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`);

--
-- Filtros para la tabla `tbl_datos_pedido`
--
ALTER TABLE `tbl_datos_pedido`
  ADD CONSTRAINT `tbl_datos_pedido_ibfk_1` FOREIGN KEY (`Fk_id_remitente`) REFERENCES `tbl_remitente` (`Pk_id_remitente`),
  ADD CONSTRAINT `tbl_datos_pedido_ibfk_2` FOREIGN KEY (`Fk_id_destinatario`) REFERENCES `tbl_destinatario` (`Pk_id_destinatario`),
  ADD CONSTRAINT `tbl_datos_pedido_ibfk_3` FOREIGN KEY (`Fk_id_vehiculo`) REFERENCES `tbl_vehiculos` (`Pk_id_vehiculo`);

--
-- Filtros para la tabla `tbl_dedu_perp_emp`
--
ALTER TABLE `tbl_dedu_perp_emp`
  ADD CONSTRAINT `tbl_dedu_perp_emp_ibfk_1` FOREIGN KEY (`Fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  ADD CONSTRAINT `tbl_dedu_perp_emp_ibfk_2` FOREIGN KEY (`Fk_dedu_perp`) REFERENCES `tbl_dedu_perp` (`pk_dedu_perp`);

--
-- Filtros para la tabla `tbl_detalle_comisiones`
--
ALTER TABLE `tbl_detalle_comisiones`
  ADD CONSTRAINT `tbl_detalle_comisiones_ibfk_1` FOREIGN KEY (`Fk_id_comisionEnc`) REFERENCES `tbl_comisiones_encabezado` (`Pk_id_comisionEnc`),
  ADD CONSTRAINT `tbl_detalle_comisiones_ibfk_2` FOREIGN KEY (`Fk_id_factura`) REFERENCES `tbl_factura` (`Pk_id_factura`);

--
-- Filtros para la tabla `tbl_detalle_ordenes_compra`
--
ALTER TABLE `tbl_detalle_ordenes_compra`
  ADD CONSTRAINT `tbl_detalle_ordenes_compra_ibfk_1` FOREIGN KEY (`Fk_encOrCom_id`) REFERENCES `tbl_ordenes_compra` (`Pk_encOrCom_id`),
  ADD CONSTRAINT `tbl_detalle_ordenes_compra_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`);

--
-- Filtros para la tabla `tbl_deudas_clientes`
--
ALTER TABLE `tbl_deudas_clientes`
  ADD CONSTRAINT `tbl_deudas_clientes_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_deudas_clientes_ibfk_2` FOREIGN KEY (`Fk_id_cobrador`) REFERENCES `tbl_cobrador` (`Pk_id_cobrador`),
  ADD CONSTRAINT `tbl_deudas_clientes_ibfk_3` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`);

--
-- Filtros para la tabla `tbl_deudas_proveedores`
--
ALTER TABLE `tbl_deudas_proveedores`
  ADD CONSTRAINT `tbl_deudas_proveedores_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  ADD CONSTRAINT `tbl_deudas_proveedores_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`);

--
-- Filtros para la tabla `tbl_empleados`
--
ALTER TABLE `tbl_empleados`
  ADD CONSTRAINT `tbl_empleados_ibfk_1` FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` (`pk_id_departamento`),
  ADD CONSTRAINT `tbl_empleados_ibfk_2` FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`);

--
-- Filtros para la tabla `tbl_existencias_bodega`
--
ALTER TABLE `tbl_existencias_bodega`
  ADD CONSTRAINT `FK_EXISTENCIA_BODEGA` FOREIGN KEY (`Fk_ID_BODEGA`) REFERENCES `tbl_bodegas` (`Pk_ID_BODEGA`),
  ADD CONSTRAINT `FK_EXISTENCIA_PRODUCTO` FOREIGN KEY (`Fk_ID_PRODUCTO`) REFERENCES `tbl_productos` (`Pk_id_Producto`);

--
-- Filtros para la tabla `tbl_factura`
--
ALTER TABLE `tbl_factura`
  ADD CONSTRAINT `tbl_factura_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_factura_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`);

--
-- Filtros para la tabla `tbl_historico_cuentas`
--
ALTER TABLE `tbl_historico_cuentas`
  ADD CONSTRAINT `tbl_historico_cuentas_ibfk_1` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`);

--
-- Filtros para la tabla `tbl_horas_extra`
--
ALTER TABLE `tbl_horas_extra`
  ADD CONSTRAINT `tbl_horas_extra_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_linea`
--
ALTER TABLE `tbl_linea`
  ADD CONSTRAINT `tbl_linea_ibfk_1` FOREIGN KEY (`fk_id_marca`) REFERENCES `tbl_marca` (`Pk_id_Marca`);

--
-- Filtros para la tabla `tbl_liquidacion_trabajadores`
--
ALTER TABLE `tbl_liquidacion_trabajadores`
  ADD CONSTRAINT `tbl_liquidacion_trabajadores_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`);

--
-- Filtros para la tabla `tbl_lista_detalle`
--
ALTER TABLE `tbl_lista_detalle`
  ADD CONSTRAINT `tbl_lista_detalle_ibfk_1` FOREIGN KEY (`Fk_id_lista_Encabezado`) REFERENCES `tbl_lista_encabezado` (`Pk_id_lista_Encabezado`),
  ADD CONSTRAINT `tbl_lista_detalle_ibfk_2` FOREIGN KEY (`Fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`);

--
-- Filtros para la tabla `tbl_mantenimiento`
--
ALTER TABLE `tbl_mantenimiento`
  ADD CONSTRAINT `tbl_mantenimiento_ibfk_1` FOREIGN KEY (`Fk_id_movimiento`) REFERENCES `tbl_movimiento_de_inventario` (`Pk_id_movimiento`);

--
-- Filtros para la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  ADD CONSTRAINT `tbl_marca_ibfk_1` FOREIGN KEY (`fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`);

--
-- Filtros para la tabla `tbl_mora_clientes`
--
ALTER TABLE `tbl_mora_clientes`
  ADD CONSTRAINT `tbl_mora_clientes_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_mora_clientes_ibfk_2` FOREIGN KEY (`Fk_id_transaccion`) REFERENCES `tbl_transaccion_cliente` (`Pk_id_transaccion`);

--
-- Filtros para la tabla `tbl_movimiento`
--
ALTER TABLE `tbl_movimiento`
  ADD CONSTRAINT `tbl_movimiento_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`);

--
-- Filtros para la tabla `tbl_movimientobancario`
--
ALTER TABLE `tbl_movimientobancario`
  ADD CONSTRAINT `fk_cuenta` FOREIGN KEY (`fk_cuenta_id`) REFERENCES `tbl_cuentabancaria` (`pk_cuenta_id`);

--
-- Filtros para la tabla `tbl_movimiento_de_inventario`
--
ALTER TABLE `tbl_movimiento_de_inventario`
  ADD CONSTRAINT `FK_EXISTENCIA_LOCAL` FOREIGN KEY (`Fk_ID_LOCALES`) REFERENCES `tbl_locales` (`Pk_ID_LOCAL`),
  ADD CONSTRAINT `tbl_movimiento_de_inventario_ibfk_1` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  ADD CONSTRAINT `tbl_movimiento_de_inventario_ibfk_2` FOREIGN KEY (`Fk_id_stock`) REFERENCES `tbl_trasladoproductos` (`Pk_id_TrasladoProductos`);

--
-- Filtros para la tabla `tbl_ordenes_compra`
--
ALTER TABLE `tbl_ordenes_compra`
  ADD CONSTRAINT `tbl_ordenes_compra_ibfk_1` FOREIGN KEY (`Fk_prov_id`) REFERENCES `tbl_proveedores` (`Pk_prov_id`);

--
-- Filtros para la tabla `tbl_pedido_detalle`
--
ALTER TABLE `tbl_pedido_detalle`
  ADD CONSTRAINT `tbl_pedido_detalle_ibfk_1` FOREIGN KEY (`Fk_id_pedidoEnc`) REFERENCES `tbl_pedido_encabezado` (`Pk_id_PedidoEnc`),
  ADD CONSTRAINT `tbl_pedido_detalle_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  ADD CONSTRAINT `tbl_pedido_detalle_ibfk_3` FOREIGN KEY (`Fk_id_cotizacionEnc`) REFERENCES `tbl_cotizacion_encabezado` (`Pk_id_cotizacionEnc`);

--
-- Filtros para la tabla `tbl_pedido_encabezado`
--
ALTER TABLE `tbl_pedido_encabezado`
  ADD CONSTRAINT `tbl_pedido_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_pedido_encabezado_ibfk_2` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`);

--
-- Filtros para la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_1` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_planilla_detalle`
--
ALTER TABLE `tbl_planilla_detalle`
  ADD CONSTRAINT `tbl_planilla_detalle_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  ADD CONSTRAINT `tbl_planilla_detalle_ibfk_2` FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`),
  ADD CONSTRAINT `tbl_planilla_detalle_ibfk_3` FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES `tbl_planilla_encabezado` (`pk_registro_planilla_Encabezado`);

--
-- Filtros para la tabla `tbl_polizadetalle`
--
ALTER TABLE `tbl_polizadetalle`
  ADD CONSTRAINT `tbl_polizadetalle_ibfk_1` FOREIGN KEY (`Pk_id_polizaencabezado`) REFERENCES `tbl_polizaencabezado` (`Pk_id_polizaencabezado`),
  ADD CONSTRAINT `tbl_polizadetalle_ibfk_2` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`),
  ADD CONSTRAINT `tbl_polizadetalle_ibfk_3` FOREIGN KEY (`Pk_id_tipooperacion`) REFERENCES `tbl_tipooperacion` (`Pk_id_tipooperacion`);

--
-- Filtros para la tabla `tbl_polizaencabezado`
--
ALTER TABLE `tbl_polizaencabezado`
  ADD CONSTRAINT `tbl_polizaencabezado_ibfk_1` FOREIGN KEY (`Pk_id_tipopoliza`) REFERENCES `tbl_tipopoliza` (`Pk_id_tipopoliza`);

--
-- Filtros para la tabla `tbl_poliza_contabilidad`
--
ALTER TABLE `tbl_poliza_contabilidad`
  ADD CONSTRAINT `tbl_poliza_contabilidad_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`),
  ADD CONSTRAINT `tbl_poliza_contabilidad_ibfk_2` FOREIGN KEY (`Fk_id_contabilidad`) REFERENCES `tbl_contabilidad` (`Pk_id_contabilidad`);

--
-- Filtros para la tabla `tbl_poliza_rango_fechas`
--
ALTER TABLE `tbl_poliza_rango_fechas`
  ADD CONSTRAINT `tbl_poliza_rango_fechas_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`),
  ADD CONSTRAINT `tbl_poliza_rango_fechas_ibfk_2` FOREIGN KEY (`Fk_id_rango`) REFERENCES `tbl_rango_fechas` (`Pk_id_rango`);

--
-- Filtros para la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD CONSTRAINT `tbl_regreporteria_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_regreporteria_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_transaccion`
--
ALTER TABLE `tbl_transaccion`
  ADD CONSTRAINT `fk_cuenta_id` FOREIGN KEY (`fk_cuenta_id`) REFERENCES `tbl_cuentabancaria` (`pk_cuenta_id`);

--
-- Filtros para la tabla `tbl_transaccion_cliente`
--
ALTER TABLE `tbl_transaccion_cliente`
  ADD CONSTRAINT `tbl_transaccion_cliente_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  ADD CONSTRAINT `tbl_transaccion_cliente_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`),
  ADD CONSTRAINT `tbl_transaccion_cliente_ibfk_3` FOREIGN KEY (`Fk_id_pais`) REFERENCES `tbl_paises` (`Pk_id_pais`);

--
-- Filtros para la tabla `tbl_transaccion_proveedor`
--
ALTER TABLE `tbl_transaccion_proveedor`
  ADD CONSTRAINT `tbl_transaccion_proveedor_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  ADD CONSTRAINT `tbl_transaccion_proveedor_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`),
  ADD CONSTRAINT `tbl_transaccion_proveedor_ibfk_3` FOREIGN KEY (`Fk_id_pais`) REFERENCES `tbl_paises` (`Pk_id_pais`);

--
-- Filtros para la tabla `tbl_trasladoproductos`
--
ALTER TABLE `tbl_trasladoproductos`
  ADD CONSTRAINT `tbl_trasladoproductos_ibfk_1` FOREIGN KEY (`Fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  ADD CONSTRAINT `tbl_trasladoproductos_ibfk_2` FOREIGN KEY (`Fk_id_guia`) REFERENCES `tbl_datos_pedido` (`Pk_id_guia`);

--
-- Filtros para la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD CONSTRAINT `tbl_vehiculos_ibfk_1` FOREIGN KEY (`Fk_id_chofer`) REFERENCES `tbl_chofer` (`Pk_id_chofer`);

--
-- Filtros para la tabla `tbl_vendedores`
--
ALTER TABLE `tbl_vendedores`
  ADD CONSTRAINT `tbl_vendedores_ibfk_1` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  ADD CONSTRAINT `tbl_vendedores_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
