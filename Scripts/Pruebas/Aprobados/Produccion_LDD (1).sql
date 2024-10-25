-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3308
-- Tiempo de generación: 19-10-2024 a las 06:34:20
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
-- Base de datos: `produccion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cierre_produccion`
--

CREATE TABLE `tbl_cierre_produccion` (
  `id_cierre` int(11) NOT NULL,
  `saldo_anterior` decimal(10,2) NOT NULL,
  `cargo_mes` decimal(10,2) NOT NULL,
  `abono_mes` decimal(10,2) NOT NULL,
  `saldo_actual` decimal(10,2) NOT NULL,
  `cargo_acumulado` decimal(10,2) NOT NULL,
  `abono_acumulado` decimal(10,2) NOT NULL,
  `id_orden` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_conversiones`
--

CREATE TABLE `tbl_conversiones` (
  `id_conversion` int(11) NOT NULL,
  `unidad_origen` varchar(50) NOT NULL,
  `unidad_destino` varchar(50) NOT NULL,
  `factor_conversion` decimal(10,6) NOT NULL,
  `tipo_conversion` varchar(50) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empleados`
--

CREATE TABLE `tbl_empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombre_empleado` varchar(100) NOT NULL,
  `apellido_empleado` varchar(100) NOT NULL,
  `puesto` varchar(100) NOT NULL,
  `fecha_asignacion` date NOT NULL,
  `salario` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_lotes`
--

CREATE TABLE `tbl_lotes` (
  `id_lote` int(11) NOT NULL,
  `codigo_lote` varchar(50) NOT NULL,
  `producto` varchar(100) NOT NULL,
  `cantidad` decimal(10,2) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_expiracion` date DEFAULT NULL,
  `etapa` varchar(20) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mantenimiento_produccion`
--

CREATE TABLE `tbl_mantenimiento_produccion` (
  `id_producto` int(11) NOT NULL,
  `nombre_producto` varchar(100) DEFAULT NULL,
  `descripcion_producto` varchar(150) DEFAULT NULL,
  `detalles_producto` varchar(100) DEFAULT NULL,
  `costo_fabricacion` decimal(10,2) DEFAULT NULL,
  `precio_venta` decimal(10,2) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_maquinaria`
--

CREATE TABLE `tbl_maquinaria` (
  `id_maquina` int(11) NOT NULL,
  `nombre_maquina` varchar(100) NOT NULL,
  `tipo_maquina` varchar(50) NOT NULL,
  `capacidad_produccion` decimal(10,2) NOT NULL,
  `horas_operacion` decimal(10,2) DEFAULT NULL,
  `mantenimiento_periodico` varchar(20) DEFAULT NULL,
  `ultima_mantenimiento` date DEFAULT NULL,
  `proximo_mantenimiento` date DEFAULT NULL,
  `responsable` varchar(100) DEFAULT NULL,
  `ubicacion` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordenes_produccion`
--

CREATE TABLE `tbl_ordenes_produccion` (
  `id_orden` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `costo_total` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_proceso_produccion`
--

CREATE TABLE `tbl_proceso_produccion` (
  `id_proceso` int(11) NOT NULL,
  `descripcion_proceso` varchar(255) NOT NULL,
  `fecha` date NOT NULL,
  `costo_fabricacion` decimal(10,2) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `id_orden` int(11) NOT NULL,
  `duracion_horas` decimal(5,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_recetas`
--

CREATE TABLE `tbl_recetas` (
  `id_receta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_fabricacion` decimal(10,2) NOT NULL,
  `campo` varchar(100) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reporte_produccion`
--

CREATE TABLE `tbl_reporte_produccion` (
  `id_reporte` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `descripcion` text DEFAULT NULL,
  `id_orden` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_series`
--

CREATE TABLE `tbl_series` (
  `id_serie` int(11) NOT NULL,
  `codigo_serie` varchar(50) NOT NULL,
  `producto` varchar(100) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date DEFAULT NULL,
  `etapa` varchar(20) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_transaccion_contable`
--

CREATE TABLE `tbl_transaccion_contable` (
  `id_transaccion` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `monto` decimal(10,2) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `id_orden` int(11) NOT NULL,
  `tipo_transaccion` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_cierre_produccion`
--
ALTER TABLE `tbl_cierre_produccion`
  ADD PRIMARY KEY (`id_cierre`),
  ADD KEY `id_orden` (`id_orden`);

--
-- Indices de la tabla `tbl_conversiones`
--
ALTER TABLE `tbl_conversiones`
  ADD PRIMARY KEY (`id_conversion`);

--
-- Indices de la tabla `tbl_empleados`
--
ALTER TABLE `tbl_empleados`
  ADD PRIMARY KEY (`id_empleado`);

--
-- Indices de la tabla `tbl_lotes`
--
ALTER TABLE `tbl_lotes`
  ADD PRIMARY KEY (`id_lote`);

--
-- Indices de la tabla `tbl_mantenimiento_produccion`
--
ALTER TABLE `tbl_mantenimiento_produccion`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `tbl_maquinaria`
--
ALTER TABLE `tbl_maquinaria`
  ADD PRIMARY KEY (`id_maquina`);

--
-- Indices de la tabla `tbl_ordenes_produccion`
--
ALTER TABLE `tbl_ordenes_produccion`
  ADD PRIMARY KEY (`id_orden`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `tbl_proceso_produccion`
--
ALTER TABLE `tbl_proceso_produccion`
  ADD PRIMARY KEY (`id_proceso`),
  ADD KEY `id_empleado` (`id_empleado`),
  ADD KEY `id_orden` (`id_orden`);

--
-- Indices de la tabla `tbl_recetas`
--
ALTER TABLE `tbl_recetas`
  ADD PRIMARY KEY (`id_receta`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `tbl_reporte_produccion`
--
ALTER TABLE `tbl_reporte_produccion`
  ADD PRIMARY KEY (`id_reporte`),
  ADD KEY `id_orden` (`id_orden`);

--
-- Indices de la tabla `tbl_series`
--
ALTER TABLE `tbl_series`
  ADD PRIMARY KEY (`id_serie`);

--
-- Indices de la tabla `tbl_transaccion_contable`
--
ALTER TABLE `tbl_transaccion_contable`
  ADD PRIMARY KEY (`id_transaccion`),
  ADD KEY `id_orden` (`id_orden`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_cierre_produccion`
--
ALTER TABLE `tbl_cierre_produccion`
  MODIFY `id_cierre` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_conversiones`
--
ALTER TABLE `tbl_conversiones`
  MODIFY `id_conversion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_empleados`
--
ALTER TABLE `tbl_empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_lotes`
--
ALTER TABLE `tbl_lotes`
  MODIFY `id_lote` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_mantenimiento_produccion`
--
ALTER TABLE `tbl_mantenimiento_produccion`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_maquinaria`
--
ALTER TABLE `tbl_maquinaria`
  MODIFY `id_maquina` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_ordenes_produccion`
--
ALTER TABLE `tbl_ordenes_produccion`
  MODIFY `id_orden` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_proceso_produccion`
--
ALTER TABLE `tbl_proceso_produccion`
  MODIFY `id_proceso` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_recetas`
--
ALTER TABLE `tbl_recetas`
  MODIFY `id_receta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_reporte_produccion`
--
ALTER TABLE `tbl_reporte_produccion`
  MODIFY `id_reporte` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_series`
--
ALTER TABLE `tbl_series`
  MODIFY `id_serie` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_transaccion_contable`
--
ALTER TABLE `tbl_transaccion_contable`
  MODIFY `id_transaccion` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_ordenes_produccion`
--
ALTER TABLE `tbl_ordenes_produccion`
  ADD CONSTRAINT `tbl_ordenes_produccion_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `tbl_mantenimiento_produccion` (`id_producto`);

--
-- Filtros para la tabla `tbl_proceso_produccion`
--
ALTER TABLE `tbl_proceso_produccion`
  ADD CONSTRAINT `tbl_proceso_produccion_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `tbl_empleados` (`id_empleado`),
  ADD CONSTRAINT `tbl_proceso_produccion_ibfk_2` FOREIGN KEY (`id_orden`) REFERENCES `tbl_ordenes_produccion` (`id_orden`);

--
-- Filtros para la tabla `tbl_recetas`
--
ALTER TABLE `tbl_recetas`
  ADD CONSTRAINT `tbl_recetas_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `tbl_mantenimiento_produccion` (`id_producto`);

--
-- Filtros para la tabla `tbl_reporte_produccion`
--
ALTER TABLE `tbl_reporte_produccion`
  ADD CONSTRAINT `tbl_reporte_produccion_ibfk_1` FOREIGN KEY (`id_orden`) REFERENCES `tbl_ordenes_produccion` (`id_orden`);

--
-- Filtros para la tabla `tbl_transaccion_contable`
--
ALTER TABLE `tbl_transaccion_contable`
  ADD CONSTRAINT `tbl_transaccion_contable_ibfk_1` FOREIGN KEY (`id_orden`) REFERENCES `tbl_ordenes_produccion` (`id_orden`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
