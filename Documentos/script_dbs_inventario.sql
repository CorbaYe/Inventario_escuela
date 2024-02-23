create schema dbs_inventario;
use dbs_inventario;

create table tbl_tipo(
	pk_codigo varchar(2) not null,
    nombre varchar(50) not null,
    nomenclatura varchar(5) not null,
    primary key (pk_codigo)
);

create table tbl_estado(
	pk_codigo varchar(2) not null,
    nombre varchar(50) not null,
    nomenclatura varchar(5) not null,
    primary key (pk_codigo)
);

create table tbl_sala(
	pk_id varchar(10) not null,
    nombre varchar(60) not null,
    cantidad_equipos int not null,
    fk_codigo_tbl_estado varchar(2) not null,
    primary key (pk_codigo),
    constraint tbl_sala_tbl_estado foreign key (fk_codigo_tbl_estado) references tbl_estado(pk_codigo) on update cascade on delete cascade
);

create table tbl_equipos(
	pk_serial varchar(10) not null,
    nombre varchar(60) not null,
	aplicaciones varchar(1000) not null,
    especificaciones varchar(1000) not null,
    fk_codigo_tbl_tipo varchar(2) not null,
    config_red varchar(1000) not null,
    fk_codigo_tbl_estado varchar(2) not null,
    foto longblob,
    fk_id_sala varchar(10),
    fecha date not null,
    primary key (pk_codigo),
    constraint tbl_equipos_tbl_tipo foreign key (fk_codigo_tbl_tipo) references tbl_tipo(pk_codigo) on update cascade on delete cascade,
    constraint tbl_equipos_tbl_estado foreign key (fk_codigo_tbl_estado) references tbl_estado(pk_codigo) on update cascade on delete cascade,
	constraint tbl_equipos_tbl_sala foreign key (fk_id_sala) references tbl_sala(pk_id) on update cascade on delete cascade
);

-- insert
insert into tbl_tipo
value('1','PC ESCRITORIO','PC'),('2','PC PORTATIL','POR'),('3','PC TABLEROS','TBL'),('4','VIDEO BEAN','VB'),('5','MESAS','MES'),('6','SILLAS','SILL'),('7','PARLANTES','PAR'),
('8','VENTILADOR','VEN'),('9','AIRE ACONDICIONADO','AAC');

insert into tbl_estado
value('1','ACTIVO','AC'),('2','INACTIVO','IN'),('3','DE BAJA','DB'),('4','EN REPARACIÓN','ER');