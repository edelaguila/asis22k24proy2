CREATE TABLE tbl_explosion (
    pk_id_explosion INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_orden INT, -- Relacionado con la orden de producción
    fk_id_producto INT, -- Producto que se descompone
    cantidad INT, -- Cantidad de producto a descomponer
    costo_total DECIMAL(10,2), -- Costo total de la descomposición
    duracion_horas DECIMAL(10,2), -- Duración en horas
    fk_id_proceso INT, -- Relación con el proceso
    fecha_explosion DATE, -- Fecha de la explosión
    FOREIGN KEY (fk_id_orden) REFERENCES tbl_ordenes_produccion(pk_id_orden),
    FOREIGN KEY (fk_id_producto) REFERENCES tbl_productos(pk_id_producto),
    FOREIGN KEY (fk_id_proceso) REFERENCES tbl_proceso_produccion_encabezado(pk_id_proceso)
);





CREATE TABLE tbl_implosion (
    pk_id_implosion INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_orden INT, -- Relacionado con la orden de producción
    fk_id_producto_final INT, -- Producto final que se construye
    fk_id_componente INT, -- Componente utilizado en la consolidación
    cantidad_componente INT, -- Cantidad de cada componente
    costo_componente DECIMAL(10,2), -- Costo de cada componente
    duracion_horas DECIMAL(10,2), -- Duración en horas para consolidar el componente
    fk_id_proceso INT, -- Relación con el proceso de producción
    fecha_implosion DATE, -- Fecha de la implosión
    FOREIGN KEY (fk_id_orden) REFERENCES tbl_ordenes_produccion(pk_id_orden),
    FOREIGN KEY (fk_id_producto_final) REFERENCES tbl_productos(pk_id_producto),
    FOREIGN KEY (fk_id_componente) REFERENCES tbl_productos(pk_id_producto),
    FOREIGN KEY (fk_id_proceso) REFERENCES tbl_proceso_produccion_encabezado(pk_id_proceso)
);