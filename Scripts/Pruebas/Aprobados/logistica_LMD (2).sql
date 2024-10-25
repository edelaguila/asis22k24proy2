INSERT INTO Tbl_Productos (codigoProducto, nombreProducto, pesoProducto, precioUnitario, clasificacion, stock, empaque, estado)
VALUES
(1001, 'Colchón Queen', '20 kg', 250.00, 'Dormitorio', 100, 'Caja', 1),
(1002, 'Colchón King', '25 kg', 350.00, 'Dormitorio', 50, 'Caja', 1),
(1003, 'Sofá 3 Plazas', '80 kg', 500.00, 'Sala', 30, 'Desarmado', 1),
(1004, 'Almohada Visc.', '1 kg', 30.00, 'Accesorios', 200, 'Bolsa', 1),
(1005, 'Mesa de Centro', '25 kg', 120.00, 'Sala', 60, 'Desarmado', 1);

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