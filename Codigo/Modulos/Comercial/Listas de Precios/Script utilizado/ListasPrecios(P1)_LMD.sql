USE ListasPrecios_P1;

-- insert de prueba 
INSERT INTO tbl_productos 
(Pk_id_Producto, nombreProducto, pesoProducto, precioUnitario, precio_venta, costo_compra, clasificacion, stock, empaque, codigoProducto, estado) 
VALUES 
(1, 'Colchón Doble', '30 kg', 200.00, 300.00, 150.00, 'Colchones', 50, 'Caja', 101, 1),
(2, 'Colchón Individual', '25 kg', 150.00, 220.00, 100.00, 'Colchones', 70, 'Caja', 102, 1),
(3, 'Base para Colchón', '15 kg', 100.00, 150.00, 75.00, 'Accesorios', 30, 'Caja', 103, 1),
(4, 'Almohada de Espuma', '1 kg', 20.00, 30.00, 10.00, 'Accesorios', 100, 'Bolsa', 104, 1),
(5, 'Colchón para Cuna', '8 kg', 80.00, 120.00, 40.00, 'Colchones', 40, 'Caja', 105, 1),
(6, 'Funda para Colchón', '0.5 kg', 10.00, 15.00, 5.00, 'Accesorios', 150, 'Bolsa', 106, 1),
(7, 'Colchón King Size', '45 kg', 350.00, 500.00, 200.00, 'Colchones', 20, 'Caja', 107, 1),
(8, 'Colchón Matrimonial', '35 kg', 250.00, 400.00, 180.00, 'Colchones', 25, 'Caja', 108, 1),
(9, 'Almohada de Plumas', '1 kg', 25.00, 40.00, 15.00, 'Accesorios', 80, 'Bolsa', 109, 1),
(10, 'Colchón Viscoelástico', '40 kg', 300.00, 450.00, 180.00, 'Colchones', 15, 'Caja', 110, 1),
(11, 'Protector de Colchón', '1 kg', 15.00, 25.00, 10.00, 'Accesorios', 90, 'Bolsa', 111, 1),
(12, 'Colchón de Resortes', '35 kg', 200.00, 320.00, 130.00, 'Colchones', 35, 'Caja', 112, 1),
(13, 'Almohada de Gel', '1 kg', 22.00, 35.00, 12.00, 'Accesorios', 60, 'Bolsa', 113, 1),
(14, 'Colchón de Aire', '5 kg', 50.00, 80.00, 30.00, 'Colchones', 40, 'Caja', 114, 1),
(15, 'Funda de Almohada', '0.2 kg', 5.00, 10.00, 3.00, 'Accesorios', 200, 'Bolsa', 115, 1),
(16, 'Colchón Reversible', '30 kg', 220.00, 340.00, 140.00, 'Colchones', 20, 'Caja', 116, 1),
(17, 'Almohada Antialérgica', '0.8 kg', 18.00, 28.00, 8.00, 'Accesorios', 100, 'Bolsa', 117, 1),
(18, 'Colchón Futón', '20 kg', 120.00, 180.00, 70.00, 'Colchones', 30, 'Caja', 118, 1),
(19, 'Colchón de Latex', '35 kg', 280.00, 420.00, 170.00, 'Colchones', 10, 'Caja', 119, 1),
(20, 'Almohada de Memory Foam', '1 kg', 30.00, 45.00, 20.00, 'Accesorios', 75, 'Bolsa', 120, 1);

-- Insertar líneas de producto
INSERT INTO tbl_lineas (nombre_linea) VALUES 
('Descanso'),
('Confort'),
('Infantil');

-- Insertar marcas
INSERT INTO tbl_marcas (nombre_marca) VALUES 
('Dormiline'),
('SleepWell'),
('ComfortRest');

-- Insertar inventarios
INSERT INTO tbl_inventario (descripcion_inventario) VALUES 
('Bodega Central'),
('Sucursal Norte'),
('Sucursal Sur');

-- Asociar productos a líneas
INSERT INTO tbl_producto_linea (fk_id_producto, fk_id_linea) VALUES 
(1, 1),  -- Colchón Doble - Línea Descanso
(2, 1),  -- Colchón Individual - Línea Descanso
(3, 2),  -- Base para Colchón - Línea Confort
(4, 2),  -- Almohada de Espuma - Línea Confort
(5, 3),  -- Colchón para Cuna - Línea Infantil
(6, 2),  -- Funda para Colchón - Línea Confort
(7, 1),  -- Colchón King Size - Línea Descanso
(8, 1),  -- Colchón Matrimonial - Línea Descanso
(9, 2),  -- Almohada de Plumas - Línea Confort
(10, 1), -- Colchón Viscoelástico - Línea Descanso
(11, 2), -- Protector de Colchón - Línea Confort
(12, 1), -- Colchón de Resortes - Línea Descanso
(13, 2), -- Almohada de Gel - Línea Confort
(14, 1), -- Colchón de Aire - Línea Descanso
(15, 2), -- Funda de Almohada - Línea Confort
(16, 1), -- Colchón Reversible - Línea Descanso
(17, 2), -- Almohada Antialérgica - Línea Confort
(18, 1), -- Colchón Futón - Línea Descanso
(19, 1), -- Colchón de Latex - Línea Descanso
(20, 2); -- Almohada de Memory Foam - Línea Confort

-- Asociar productos a marcas
INSERT INTO tbl_producto_marca (fk_id_producto, fk_id_marca) VALUES 
(1, 1),  -- Colchón Doble - Dormiline
(2, 1),  -- Colchón Individual - Dormiline
(3, 2),  -- Base para Colchón - SleepWell
(4, 3),  -- Almohada de Espuma - ComfortRest
(5, 1),  -- Colchón para Cuna - Dormiline
(6, 2),  -- Funda para Colchón - SleepWell
(7, 1),  -- Colchón King Size - Dormiline
(8, 1),  -- Colchón Matrimonial - Dormiline
(9, 3),  -- Almohada de Plumas - ComfortRest
(10, 1), -- Colchón Viscoelástico - Dormiline
(11, 2), -- Protector de Colchón - SleepWell
(12, 1), -- Colchón de Resortes - Dormiline
(13, 3), -- Almohada de Gel - ComfortRest
(14, 1), -- Colchón de Aire - Dormiline
(15, 2), -- Funda de Almohada - SleepWell
(16, 1), -- Colchón Reversible - Dormiline
(17, 3), -- Almohada Antialérgica - ComfortRest
(18, 2), -- Colchón Futón - SleepWell
(19, 1), -- Colchón de Latex - Dormiline
(20, 3); -- Almohada de Memory Foam - ComfortRest

-- Asociar productos a inventarios
INSERT INTO tbl_producto_inventario (fk_id_producto, fk_id_inventario) VALUES 
(1, 1),  -- Colchón Doble - Bodega Central
(2, 2),  -- Colchón Individual - Sucursal Norte
(3, 3),  -- Base para Colchón - Sucursal Sur
(4, 1),  -- Almohada de Espuma - Bodega Central
(5, 2),  -- Colchón para Cuna - Sucursal Norte
(6, 3),  -- Funda para Colchón - Sucursal Sur
(7, 1),  -- Colchón King Size - Bodega Central
(8, 2),  -- Colchón Matrimonial - Sucursal Norte
(9, 3),  -- Almohada de Plumas - Sucursal Sur
(10, 1), -- Colchón Viscoelástico - Bodega Central
(11, 2), -- Protector de Colchón - Sucursal Norte
(12, 3), -- Colchón de Resortes - Sucursal Sur
(13, 1), -- Almohada de Gel - Bodega Central
(14, 2), -- Colchón de Aire - Sucursal Norte
(15, 3), -- Funda de Almohada - Sucursal Sur
(16, 1), -- Colchón Reversible - Bodega Central
(17, 2), -- Almohada Antialérgica - Sucursal Norte
(18, 3), -- Colchón Futón - Sucursal Sur
(19, 1), -- Colchón de Latex - Bodega Central
(20, 2); -- Almohada de Memory Foam - Sucursal Norte

