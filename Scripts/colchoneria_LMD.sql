--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`, `estado`) VALUES
(1, 'AyudaNavegador.chm', 'AyudaNav.html', 1),
(2, 'AyudaReportes.chm', 'AyudaRep.html', 1),
(8, 'AyudaMonitoreoAlmacen.chm', 'AyudaMonAlmacen.html', 1);

--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(2000, 'MDI LOGISTICA', 'PARA LOGISTICA', 1),
(3000, 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', 1),
(5000, 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', 1),
(6000, 'MDI NOMINAS', 'PARA NOMINAS', 1),
(6001, 'Mant. Trabajadores', 'PARA NOMINAS', 1),
(6002, 'Mant. Puestos de Trabajo', 'PARA NOMINAS', 1),
(6003, 'Mant. Departamentos', 'PARA NOMINAS', 1),
(6004, 'Mant. Contratos', 'PARA NOMINAS', 1),
(6005, 'Mant. Percepciones', 'PARA NOMINAS', 1),
(6006, 'Mant. Horas Extras', 'PARA NOMINAS', 1),
(6007, 'Mant. Faltas', 'PARA NOMINAS', 1),
(6101, 'Asgn. Puesto - Depto.', 'PARA NOMINAS', 1),
(6102, 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', 1),
(6103, 'Asgn. Contrato Trabajador', 'PARA NOMINAS', 1),
(6104, 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', 1),
(6105, 'Asgn. Prestaciones Individual', 'PARA NOMINAS', 1),
(6106, 'Prcs. Nomina', 'PARA NOMINAS', 1),
(6201, 'Rpt. Planillas', 'PARA NOMINAS', 1),
(6202, 'Rpt. Contratos', 'PARA NOMINAS', 1),
(6203, 'Rpt. Trabajadores', 'PARA NOMINAS', 1),
(6301, 'ACCESO SEGURIDAD', 'PARA NOMINAS', 1),
(7000, 'MDI BANCOS', 'PARA BANCOS', 1),
(8000, 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', 1);

--
-- Volcado de datos para la tabla `tbl_consultainteligente`
--

INSERT INTO `tbl_consultainteligente` (`Pk_consultaID`, `nombre_consulta`, `tipo_consulta`, `consulta_SQLE`, `consulta_estatus`) VALUES
(1, '', 0, 'SELECT id_venta FROM venta;', 1),
(2, '', 0, 'SELECT SELECT id_venta FROM venta;id_venta AS * FROM venta;', 1),
(3, '', 0, 'SELECT * FROM venta;', 1),
(4, '', 0, 'SELECT * FROM venta;', 1),
(5, '', 0, 'SELECT * FROM venta;', 1),
(6, '', 0, 'SELECT * FROM venta;', 1),
(7, 'dsf', 0, 'SELECT * FROM venta;', 1),
(8, '', 0, 'SELECT * FROM venta;', 1),
(9, '', 0, 'SELECT * FROM venta;', 1),
(10, 'viccccccccc', 0, 'SELECT * FROM venta;', 1),
(11, 'consultaaaaa', 0, 'SELECT * FROM factura;', 1),
(12, '', 0, 'SELECT * FROM factura;', 1),
(13, 'jkjkkjk', 0, 'SELECT * FROM factura;', 1);

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(2000, 'LOGISTICA', 'Logistica', 1),
(3000, 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
(5000, 'PRODUCCIÓN', 'Produccion', 1),
(6000, 'NOMINAS', 'Nominas', 1),
(7000, 'BANCOS', 'Bancos', 1),
(8000, 'CONTABILIDAD', 'Contabilidad', 1);

--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`Pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
(3, 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
(4, 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
(5, 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
(6, 'NOMINAS', 'contiene todos los permisos de nominas', 1),
(7, 'BANCOS', 'contiene todos los permisos de bancos', 1),
(8, 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1),
(9, 'AUDITOR', 'Permite la revisión y auditoría de actividades sin capacidad de modificar datos', 1),
(10, 'SOporte Técnico', 'Permite brindar asistencia técnica sin acceso completo a la administración', 1),
(11, 'ADMINISTRADOR', 'Acceso completo al sistema con ciertas restricciones según sea necesario', 1),
(12, 'GESTOR DE PROYECTOS', 'Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración', 1),
(13, 'GESTOR DE DATOS', 'Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración', 1);


--
-- Volcado de datos para la tabla `tbl_permisos_aplicacion_perfil`
--

INSERT INTO `tbl_permisos_aplicacion_perfil` (`PK_id_Aplicacion_Perfil`, `Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1000, 1, 1, 1, 1, 1),
(2, 1, 1001, 1, 1, 1, 1, 1),
(3, 1, 1002, 1, 1, 1, 1, 1),
(4, 1, 1003, 1, 1, 1, 1, 1),
(5, 1, 1004, 1, 1, 1, 1, 1),
(6, 1, 1101, 1, 1, 1, 1, 1),
(7, 1, 1102, 1, 1, 1, 1, 1),
(8, 1, 1103, 1, 1, 1, 1, 1),
(9, 1, 1201, 1, 1, 1, 1, 1),
(10, 1, 1301, 1, 1, 1, 1, 1),
(11, 1, 2000, 1, 1, 1, 1, 1),
(12, 1, 3000, 1, 1, 1, 1, 1),
(13, 1, 5000, 1, 1, 1, 1, 1),
(14, 1, 6000, 1, 1, 1, 1, 1),
(15, 1, 6001, 1, 1, 1, 1, 1),
(16, 1, 6002, 1, 1, 1, 1, 1),
(17, 1, 6003, 1, 1, 1, 1, 1),
(18, 1, 6004, 1, 1, 1, 1, 1),
(19, 1, 6005, 1, 1, 1, 1, 1),
(20, 1, 6006, 1, 1, 1, 1, 1),
(21, 1, 6007, 1, 1, 1, 1, 1),
(22, 1, 6101, 1, 1, 1, 1, 1),
(23, 1, 6102, 1, 1, 1, 1, 1),
(24, 1, 6103, 1, 1, 1, 1, 1),
(25, 1, 6104, 1, 1, 1, 1, 1),
(26, 1, 6105, 1, 1, 1, 1, 1),
(27, 1, 6106, 1, 1, 1, 1, 1),
(28, 1, 6201, 1, 1, 1, 1, 1),
(29, 1, 6202, 1, 1, 1, 1, 1),
(30, 1, 6203, 1, 1, 1, 1, 1),
(31, 1, 6301, 1, 1, 1, 1, 1),
(32, 1, 7000, 1, 1, 1, 1, 1),
(33, 1, 8000, 1, 1, 1, 1, 1),
(34, 2, 1000, 1, 1, 1, 1, 1),
(35, 3, 2000, 1, 1, 1, 1, 1),
(36, 4, 3000, 1, 1, 1, 1, 1),
(37, 5, 5000, 1, 1, 1, 1, 1),
(38, 6, 6000, 1, 1, 1, 1, 1),
(39, 6, 6001, 1, 1, 1, 1, 1),
(40, 6, 6002, 1, 1, 1, 1, 1),
(41, 6, 6003, 1, 1, 1, 1, 1),
(42, 6, 6004, 1, 1, 1, 1, 1),
(43, 6, 6005, 1, 1, 1, 1, 1),
(44, 6, 6006, 1, 1, 1, 1, 1),
(45, 6, 6007, 1, 1, 1, 1, 1),
(46, 6, 6101, 1, 1, 1, 1, 1),
(47, 6, 6102, 1, 1, 1, 1, 1),
(48, 6, 6103, 1, 1, 1, 1, 1),
(49, 6, 6104, 1, 1, 1, 1, 1),
(50, 6, 6105, 1, 1, 1, 1, 1),
(51, 6, 6106, 1, 1, 1, 1, 1),
(52, 6, 6201, 1, 1, 1, 1, 1),
(53, 6, 6202, 1, 1, 1, 1, 1),
(54, 6, 6203, 1, 1, 1, 1, 1),
(55, 6, 6301, 1, 1, 1, 1, 1),
(56, 7, 7000, 1, 1, 1, 1, 1),
(57, 8, 8000, 1, 1, 1, 1, 1),
(58, 9, 1000, 1, 1, 1, 1, 1),
(59, 9, 1001, 1, 1, 1, 1, 1),
(60, 9, 1002, 1, 1, 1, 1, 1),
(61, 9, 1003, 1, 1, 1, 1, 1),
(62, 9, 1004, 1, 1, 1, 1, 1),
(63, 9, 1101, 1, 1, 1, 1, 1),
(64, 9, 1102, 1, 1, 1, 1, 1),
(65, 9, 1103, 1, 1, 1, 1, 1),
(66, 9, 1201, 1, 1, 1, 1, 1),
(67, 9, 1301, 1, 1, 1, 1, 1),
(68, 9, 2000, 1, 1, 1, 1, 1),
(69, 9, 3000, 1, 1, 1, 1, 1),
(70, 9, 5000, 1, 1, 1, 1, 1),
(71, 9, 6000, 1, 1, 1, 1, 1),
(72, 9, 6001, 1, 1, 1, 1, 1),
(73, 9, 6002, 1, 1, 1, 1, 1),
(74, 9, 6003, 1, 1, 1, 1, 1),
(75, 9, 6004, 1, 1, 1, 1, 1),
(76, 9, 6005, 1, 1, 1, 1, 1),
(77, 9, 6006, 1, 1, 1, 1, 1),
(78, 9, 6007, 1, 1, 1, 1, 1),
(79, 9, 6101, 1, 1, 1, 1, 1),
(80, 9, 6102, 1, 1, 1, 1, 1),
(81, 9, 6103, 1, 1, 1, 1, 1),
(82, 9, 6104, 1, 1, 1, 1, 1),
(83, 9, 6105, 1, 1, 1, 1, 1),
(84, 9, 6106, 1, 1, 1, 1, 1),
(85, 9, 6201, 1, 1, 1, 1, 1),
(86, 9, 6202, 1, 1, 1, 1, 1),
(87, 9, 6203, 1, 1, 1, 1, 1),
(88, 9, 6301, 1, 1, 1, 1, 1),
(89, 9, 7000, 1, 1, 1, 1, 1),
(90, 9, 8000, 1, 1, 1, 1, 1),
(91, 10, 1000, 1, 1, 1, 1, 1),
(92, 10, 1001, 1, 1, 1, 1, 1),
(93, 10, 1002, 1, 1, 1, 1, 1),
(94, 10, 1003, 1, 1, 1, 1, 1),
(95, 10, 1004, 1, 1, 1, 1, 1),
(96, 10, 1101, 1, 1, 1, 1, 1),
(97, 10, 1102, 1, 1, 1, 1, 1),
(98, 10, 1103, 1, 1, 1, 1, 1),
(99, 10, 1201, 1, 1, 1, 1, 1),
(100, 10, 1301, 1, 1, 1, 1, 1),
(101, 10, 2000, 1, 1, 1, 1, 1),
(102, 10, 3000, 1, 1, 1, 1, 1),
(103, 10, 5000, 1, 1, 1, 1, 1),
(104, 10, 6000, 1, 1, 1, 1, 1),
(105, 10, 6001, 1, 1, 1, 1, 1),
(106, 10, 6002, 1, 1, 1, 1, 1),
(107, 10, 6003, 1, 1, 1, 1, 1),
(108, 10, 6004, 1, 1, 1, 1, 1),
(109, 10, 6005, 1, 1, 1, 1, 1),
(110, 10, 6006, 1, 1, 1, 1, 1),
(111, 10, 6007, 1, 1, 1, 1, 1),
(112, 10, 6101, 1, 1, 1, 1, 1),
(113, 10, 6102, 1, 1, 1, 1, 1),
(114, 10, 6103, 1, 1, 1, 1, 1),
(115, 10, 6104, 1, 1, 1, 1, 1),
(116, 10, 6105, 1, 1, 1, 1, 1),
(117, 10, 6106, 1, 1, 1, 1, 1),
(118, 10, 6201, 1, 1, 1, 1, 1),
(119, 10, 6202, 1, 1, 1, 1, 1),
(120, 10, 6203, 1, 1, 1, 1, 1),
(121, 10, 6301, 1, 1, 1, 1, 1),
(122, 10, 7000, 1, 1, 1, 1, 1),
(123, 10, 8000, 1, 1, 1, 1, 1),
(124, 11, 1000, 1, 1, 1, 1, 1),
(125, 11, 1001, 1, 1, 1, 1, 1),
(126, 11, 1002, 1, 1, 1, 1, 1),
(127, 11, 1003, 1, 1, 1, 1, 1),
(128, 11, 1004, 1, 1, 1, 1, 1),
(129, 11, 1101, 1, 1, 1, 1, 1),
(130, 11, 1102, 1, 1, 1, 1, 1),
(131, 11, 1103, 1, 1, 1, 1, 1),
(132, 11, 1201, 1, 1, 1, 1, 1),
(133, 11, 1301, 1, 1, 1, 1, 1),
(134, 11, 2000, 1, 1, 1, 1, 1),
(135, 11, 3000, 1, 1, 1, 1, 1),
(136, 11, 5000, 1, 1, 1, 1, 1),
(137, 11, 6000, 1, 1, 1, 1, 1),
(138, 11, 6001, 1, 1, 1, 1, 1),
(139, 11, 6002, 1, 1, 1, 1, 1),
(140, 11, 6003, 1, 1, 1, 1, 1),
(141, 11, 6004, 1, 1, 1, 1, 1),
(142, 11, 6005, 1, 1, 1, 1, 1),
(143, 11, 6006, 1, 1, 1, 1, 1),
(144, 11, 6007, 1, 1, 1, 1, 1),
(145, 11, 6101, 1, 1, 1, 1, 1),
(146, 11, 6102, 1, 1, 1, 1, 1),
(147, 11, 6103, 1, 1, 1, 1, 1),
(148, 11, 6104, 1, 1, 1, 1, 1),
(149, 11, 6105, 1, 1, 1, 1, 1),
(150, 11, 6106, 1, 1, 1, 1, 1),
(151, 11, 6201, 1, 1, 1, 1, 1),
(152, 11, 6202, 1, 1, 1, 1, 1),
(153, 11, 6203, 1, 1, 1, 1, 1),
(154, 11, 6301, 1, 1, 1, 1, 1),
(155, 11, 7000, 1, 1, 1, 1, 1),
(156, 11, 8000, 1, 1, 1, 1, 1),
(157, 12, 1000, 1, 1, 1, 1, 1),
(158, 12, 1001, 1, 1, 1, 1, 1),
(159, 12, 1002, 1, 1, 1, 1, 1),
(160, 12, 1003, 1, 1, 1, 1, 1),
(161, 12, 1004, 1, 1, 1, 1, 1),
(162, 12, 1101, 1, 1, 1, 1, 1),
(163, 12, 1102, 1, 1, 1, 1, 1),
(164, 12, 1103, 1, 1, 1, 1, 1),
(165, 12, 1201, 1, 1, 1, 1, 1),
(166, 12, 1301, 1, 1, 1, 1, 1),
(167, 12, 2000, 1, 1, 1, 1, 1),
(168, 12, 3000, 1, 1, 1, 1, 1),
(169, 12, 5000, 1, 1, 1, 1, 1),
(170, 12, 6000, 1, 1, 1, 1, 1),
(171, 12, 6001, 1, 1, 1, 1, 1),
(172, 12, 6002, 1, 1, 1, 1, 1),
(173, 12, 6003, 1, 1, 1, 1, 1),
(174, 12, 6004, 1, 1, 1, 1, 1),
(175, 12, 6005, 1, 1, 1, 1, 1),
(176, 12, 6006, 1, 1, 1, 1, 1),
(177, 12, 6007, 1, 1, 1, 1, 1),
(178, 12, 6101, 1, 1, 1, 1, 1),
(179, 12, 6102, 1, 1, 1, 1, 1),
(180, 12, 6103, 1, 1, 1, 1, 1),
(181, 12, 6104, 1, 1, 1, 1, 1),
(182, 12, 6105, 1, 1, 1, 1, 1),
(183, 12, 6106, 1, 1, 1, 1, 1),
(184, 12, 6201, 1, 1, 1, 1, 1),
(185, 12, 6202, 1, 1, 1, 1, 1),
(186, 12, 6203, 1, 1, 1, 1, 1),
(187, 12, 6301, 1, 1, 1, 1, 1),
(188, 12, 7000, 1, 1, 1, 1, 1),
(189, 12, 8000, 1, 1, 1, 1, 1),
(190, 13, 1000, 1, 1, 1, 1, 1),
(191, 13, 1001, 1, 1, 1, 1, 1),
(192, 13, 1002, 1, 1, 1, 1, 1),
(193, 13, 1003, 1, 1, 1, 1, 1),
(194, 13, 1004, 1, 1, 1, 1, 1),
(195, 13, 1101, 1, 1, 1, 1, 1),
(196, 13, 1102, 1, 1, 1, 1, 1),
(197, 13, 1103, 1, 1, 1, 1, 1),
(198, 13, 1201, 1, 1, 1, 1, 1),
(199, 13, 1301, 1, 1, 1, 1, 1),
(200, 13, 2000, 1, 1, 1, 1, 1),
(201, 13, 3000, 1, 1, 1, 1, 1),
(202, 13, 5000, 1, 1, 1, 1, 1),
(203, 13, 6000, 1, 1, 1, 1, 1),
(204, 13, 6001, 1, 1, 1, 1, 1),
(205, 13, 6002, 1, 1, 1, 1, 1),
(206, 13, 6003, 1, 1, 1, 1, 1),
(207, 13, 6004, 1, 1, 1, 1, 1),
(208, 13, 6005, 1, 1, 1, 1, 1),
(209, 13, 6006, 1, 1, 1, 1, 1),
(210, 13, 6007, 1, 1, 1, 1, 1),
(211, 13, 6101, 1, 1, 1, 1, 1),
(212, 13, 6102, 1, 1, 1, 1, 1),
(213, 13, 6103, 1, 1, 1, 1, 1),
(214, 13, 6104, 1, 1, 1, 1, 1),
(215, 13, 6105, 1, 1, 1, 1, 1),
(216, 13, 6106, 1, 1, 1, 1, 1),
(217, 13, 6201, 1, 1, 1, 1, 1),
(218, 13, 6202, 1, 1, 1, 1, 1),
(219, 13, 6203, 1, 1, 1, 1, 1),
(220, 13, 6301, 1, 1, 1, 1, 1),
(221, 13, 7000, 1, 1, 1, 1, 1),
(222, 13, 8000, 1, 1, 1, 1, 1);

--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`Pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `ultima_conexion_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', '52c88f064ed5ed9161d01f634f5e3bfcf5c77fec94fb398b6690e1b41178eb6c', 'esduardo@gmail.com', '2024-09-21 00:55:40', 1, 'COLOR FAVORITO', 'ROJO'),
(2, 'Ismar', 'Cortez', 'Ismar', 'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', 'icortezs@miumg.edu.gt', '2024-09-17 17:32:03', 1, 'Nombre de familiar', 'Eunice');

--
-- Volcado de datos para la tabla `tbl_asignaciones_perfils_usuario`
--

INSERT INTO `tbl_asignaciones_perfils_usuario` (`PK_id_Perfil_Usuario`, `Fk_id_usuario`, `Fk_id_perfil`) VALUES
(1, 1, 1);

--
-- Volcado de datos para la tabla `tbl_asignacion_modulo_aplicacion`
--

INSERT INTO `tbl_asignacion_modulo_aplicacion` (`Fk_id_modulos`, `Fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(2000, 2000),
(3000, 3000),
(5000, 5000),
(6000, 6000),
(6000, 6001),
(6000, 6002),
(6000, 6003),
(6000, 6004),
(6000, 6005),
(6000, 6006),
(6000, 6007),
(6000, 6101),
(6000, 6102),
(6000, 6103),
(6000, 6104),
(6000, 6105),
(6000, 6106),
(6000, 6201),
(6000, 6202),
(6000, 6203),
(6000, 6301),
(7000, 7000),
(8000, 8000);

--
-- Volcado de datos para la tabla `tbl_permisos_aplicaciones_usuario`
--

INSERT INTO `tbl_permisos_aplicaciones_usuario` (`PK_id_Aplicacion_Usuario`, `Fk_id_usuario`, `Fk_id_aplicacion`, `guardar_permiso`, `buscar_permiso`, `modificar_permiso`, `eliminar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1002, 1, 1, 1, 1, 0),
(2, 1, 2000, 0, 0, 0, 0, 0),
(3, 1, 1000, 1, 1, 1, 1, 1),
(4, 1, 8000, 0, 0, 0, 0, 0),
(6, 1, 1000, 1, 1, 1, 1, 1),
(7, 1, 1000, 0, 0, 0, 0, 1);


-- Se actualiza la contraseña de admin, ya que no debe ingresarse hasheado manualmente
UPDATE `tbl_usuarios` SET `password_usuario` = 'HO0aGo4nM94=' WHERE `Pk_id_usuario` = 1;

-- Se eliminó el usuario 2 porque solo el admin debe crearse desde la base de datos
DELETE FROM `tbl_usuarios` WHERE `Pk_id_usuario` = 2;

-- Se hashea la contraseña
UPDATE tbl_usuarios
SET password_usuario = SHA2('HO0aGo4nM94=', 256) 
WHERE username_usuario = 'admin';
--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `monto`, `nombre_cliente`, `nombre_empleado`, `estado`) VALUES
(1, 111, 'Josue', 'David', 1),
(2, 222, 'Fernando', 'David', 1),
(3, 100, 'Josue David', 'Joel Lopez', 1),
(4, 400, 'Sebastian', 'Victor', 1),
(5, 555, 'Brayan', 'Daniel', 1),
(6, 8888, 'pedro', 'perez', 1),
(7, 555, 'roro', 'pablo', 1),
(8, 444, 'shiro', 'rodolfo', 1),
(9, 999, 'Brayan', 'Daniel', 1),
(10, 111, 'shiro', 'sh', 1),
(11, 88, 'lol', 'lol', 1),
(12, 1111, 'lll', 'lll', 1),
(13, 1111, 'www', 'www', 1),
(14, 56456, 'wwww', 'qqq', 1),
(15, 111223, 'hola', 'hol', 1),
(16, 2222, 'yy', 'yyy', 1),
(17, 555, 'ggg', 'ggg', 1),
(18, 100, 'ahora', 'ddd', 1),
(19, 100, 'pedro', 'lucas', 1),
(20, 555, 'cliente', 'empleado', 1),
(21, 200, 'cliente', 'empleado', 1),
(22, 200, 'rrr', 'www', 1),
(23, 333, 'www', 'qqq', 1),
(24, 33, 'eee', 'xxx', 1),
(25, 600, 'ññ', 'lll', 1),
(26, 6456, 'qqq', 'fff', 1),
(27, 555, 'ddd', 'aaa', 1),
(28, 666, 'qqq', 'aaa', 1),
(29, 666, 'cliente', 'empleado', 1),
(30, 888, 'Cliente1', 'Empleado122', 1),
(31, 6666, 'ClientePrueba', 'EmpleadoPrueba', 1),
(32, 6666, 'qq', 'qqq', 1),
(33, 999, 'cliente', 'emple', 1),
(34, 333, 'cli', 'emp', 1),
(35, 65, 'pedro', 'juan', 1),
(36, 65656, 'djf', 'kjk', 1),
(37, 0, '', '', 1),
(38, 0, '', '', 1);


-- LMD DE LOGISTICA INICIO
INSERT INTO Tbl_Productos (codigoProducto, nombreProducto, pesoProducto, precioUnitario, clasificacion, stock, empaque, comisionInventario, comisionCosto, estado)
VALUES
(1001, 'Colchón Queen', '20 kg', 250.00, 'Dormitorio', 100, 'Caja', 0.10, 0.20, 1),
(1002, 'Colchón King', '25 kg', 350.00, 'Dormitorio', 50, 'Caja', 0.15, 0.20, 1),
(1003, 'Sofá 3 Plazas', '80 kg', 500.00, 'Sala', 30, 'Desarmado', 0.10, 0.20, 1),
(1004, 'Almohada Visc.', '1 kg', 30.00, 'Accesorios', 200, 'Bolsa', 0.15, 0.30, 1),
(1005, 'Mesa de Centro', '25 kg', 120.00, 'Sala', 60, 'Desarmado', 0.10, 0.25, 1);

INSERT INTO TBL_BODEGAS (NOMBRE_BODEGA, UBICACION, CAPACIDAD, FECHA_REGISTRO, estado) 
VALUES 
('Bodega Central', 'Av. Principal 100', 100, '2024-10-23', 1),
('Bodega Norte', 'Calle Norte 200', 80, '2024-10-23', 1),
('Bodega Sur', 'Calle Sur 300', 60, '2024-10-23', 1);


INSERT INTO TBL_EXISTENCIAS_BODEGA (Fk_ID_BODEGA, Fk_ID_PRODUCTO, CANTIDAD_ACTUAL, CANTIDAD_INICIAL)
VALUES
(1, 1, 20, 20),  -- Colchón Queen en Bodega Central
(1, 2, 15, 15),  -- Colchón King en Bodega Central
(2, 3, 10, 10);  -- Sofá 3 Plazas en Bodega Norte

INSERT INTO TBL_AUDITORIAS (Fk_ID_BODEGA, Fk_ID_PRODUCTO, FECHA_AUDITORIA, DISCREPANCIA_DETECTADA, CANTIDAD_REGISTRADA, CANTIDAD_FISICA, OBSERVACIONES)
VALUES 
(1, 1, CURDATE(), FALSE, 20, 20, 'Auditoría de rutina, todo en orden.'),
(2, 3, CURDATE(), TRUE, 8, 10, 'Discrepancia detectada en el Sofá 3 Plazas.');

-- LMD DE LOGISTICA FINAL