CREATE TABLE tbl_mantenimientos (
    Pk_id_maquinaria INT AUTO_INCREMENT NOT NULL,
    nombre_maquinaria VARCHAR(255),
    tipo_maquina VARCHAR(255),
    hora_operacion DECIMAL(10,2),
    mantenimiento_periodico VARCHAR(100),
    ultima_mantenimiento DATE,
    proximo_mantenimiento DATE,
    área VARCHAR(100),
    desgaste_porcentaje DECIMAL(10,2),
    estado TINYINT(1),
    PRIMARY KEY (Pk_id_maquinaria)
);