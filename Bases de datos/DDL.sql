CREATE DATABASE CitaApp;
GO

USE CitaApp;

CREATE TABLE empresas (
	id INT IDENTITY(1,1) NOT NULL,
	identificacion VARCHAR(20) NOT NULL,
	nombre VARCHAR(40) NOT NULL,
	razonSocial VARCHAR(50),
	tipo VARCHAR(25), /* Natural - Juridica */
	direccion VARCHAR(100),
	telefono VARCHAR(15),
	logo VARCHAR(100),
	correoElectronico VARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id)
);

CREATE TABLE parametros (
	id INT IDENTITY(1,1) NOT NULL,
	solicitarPago BIT DEFAULT 0, /* `1` - Activo; `0` - Inactivo */
	porcentajePago 	NUMERIC(10,2),
	tiempoReagendamiento INT,
	tiempoCancelancion INT,
	multaCancelacion BIT DEFAULT 0, /* `1` - Activo; `0` - Inactivo */
	porcentajeCancelacion NUMERIC(10,2),
	cantidadAforo INT NOT NULL,
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE categorias (
	id INT IDENTITY(1,1) NOT NULL,
	nombre VARCHAR(35) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE productos (
	id INT IDENTITY(1,1) NOT NULL,
	nombre VARCHAR(35) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	tipo VARCHAR(20) NOT NULL, /* Prodcuto - Servicio - Web */
	id_Categorias INT NOT NULL,
	stock NUMERIC(10,2),
	valor NUMERIC(10,2) NOT NULL,
	id_Parametros INT NOT NULL,
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Categorias) REFERENCES categorias(id),
	FOREIGN KEY (id_Parametros) REFERENCES parametros(id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE espacios (
	id INT IDENTITY(1,1) NOT NULL,
	nombre VARCHAR(35) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	tipo VARCHAR(35), /* Privado - publico */
	direccion VARCHAR(100),
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE profesionales (
	id INT IDENTITY(1,1) NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	nombre VARCHAR(35) NOT NULL,
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE disponibilidad (
	id INT IDENTITY(1,1) NOT NULL,
	fechaInicio Date NOT NULL,
	fechaFin Date NOT NULL,
	horaInicio Time NOT NULL,
	horaFin Time NOT NULL,
	id_Espacio INT,
	id_Profesional INT,
	id_Producto INT,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Espacio) REFERENCES espacios(id),
	FOREIGN KEY (id_Profesional) REFERENCES profesionales(id),
	FOREIGN KEY (id_Producto) REFERENCES productos(id)
);

CREATE TABLE usuarios (
	id INT IDENTITY(1,1) NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	nombre VARCHAR(35) NOT NULL,
	apellido VARCHAR(35) NOT NULL,
	correoElectronico VARCHAR(100) NOT NULL,
	contrasenia VARBINARY(8000) NOT NULL,
	tipo INT DEFAULT 0, /* 0 - Cliente; 1 - Empleados */
	direccion VARCHAR(100),
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id)
);

CREATE TABLE agendamientos (
	id INT IDENTITY(1,1) NOT NULL,
	fechaInicio Date NOT NULL,
	fechaFin Date NOT NULL,
	horaInicio Time NOT NULL,
	horaFin Time NOT NULL,
	id_Espacio INT NOT NULL,
	id_Profesional INT,
	id_Producto INT,
	id_Usuario INT NOT NULL,
	id_Empresa INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Espacio) REFERENCES espacios(id),
	FOREIGN KEY (id_Profesional) REFERENCES profesionales(id),
	FOREIGN KEY (id_Producto) REFERENCES productos(id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id),
	FOREIGN KEY (id_Usuario) REFERENCES usuarios(id)
);

CREATE TABLE pagos (
	id INT IDENTITY(1,1) NOT NULL,
	id_Agendamiento INT NOT NULL,
	valor NUMERIC(10,2) NOT NULL,
	saldo NUMERIC(10,2) NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Agendamiento) REFERENCES agendamientos(id)
);

CREATE TABLE planes (
	id INT IDENTITY(1,1) NOT NULL,
	nombre INT NOT NULL,
	descripcion VARCHAR(35) NOT NULL,
	valor NUMERIC(10,2) NOT NULL,
	duracion INT NOT NULL, /* Meses */
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id)
);

CREATE TABLE suscripciones (
	id INT IDENTITY(1,1) NOT NULL,
	id_Empresa INT NOT NULL,
	fechaInicio Date NOT NULL,
	fechaFin Date NULL,
	id_Plan INT NOT NULL,
	estado BIT DEFAULT 1,  /* `1` - Activo; `0` - Inactivo */
	PRIMARY KEY (id),
	FOREIGN KEY (id_Empresa) REFERENCES empresas(id),
	FOREIGN KEY (id_Plan) REFERENCES planes(id)
);
