-- Tablas de Locaciones
DROP TABLE Paises CASCADE CONSTRAINTS;
CREATE TABLE Paises (
  idPais NUMERIC NOT NULL,
  nombre VARCHAR(45) NULL,
  PRIMARY KEY(idPais)
);

DROP TABLE Estados CASCADE CONSTRAINTS;
CREATE TABLE Estados (
  idEstado NUMERIC NOT NULL,
  idPais NUMERIC NOT NULL,
  nombre VARCHAR(45) NULL,
  PRIMARY KEY(idEstado),
  CONSTRAINT fk_pais FOREIGN KEY(idPais) REFERENCES Paises(idPais)
);

DROP TABLE Ciudades CASCADE CONSTRAINTS;
CREATE TABLE Ciudades (
  idCiudad NUMERIC NOT NULL,
  idEstado NUMERIC NULL,
  nombre VARCHAR(45) NULL,
  PRIMARY KEY(idCiudad),
  CONSTRAINT fk_estado FOREIGN KEY(idEstado) REFERENCES Estados(idEstado)
);

DROP TABLE Colonias CASCADE CONSTRAINTS;
CREATE TABLE Colonias (
  idColonia NUMERIC NOT NULL,
  idCiudad NUMERIC NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY(idColonia),
  CONSTRAINT fk_ciudad FOREIGN KEY(idCiudad) REFERENCES Ciudades(idCiudad)
);

DROP TABLE Domicilios CASCADE CONSTRAINTS;
CREATE TABLE Domicilios (
  idDomicilio NUMERIC NOT NULL,
  idColonia NUMERIC NOT NULL,
  calle VARCHAR(45) NULL,
  No_domicilio VARCHAR(6) NULL,
  PRIMARY KEY(idDomicilio),
  CONSTRAINT fk_colonia FOREIGN KEY(idColonia) REFERENCES Colonias(idColonia)
);

-- Tablas de entidades
DROP TABLE Contribuyentes CASCADE CONSTRAINTS;
CREATE TABLE Contribuyentes (
  curp VARCHAR(18) NOT NULL,
  rfc VARCHAR(13) NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  paterno VARCHAR(45) NOT NULL,
  materno VARCHAR(45) NOT NULL,
  edad NUMERIC NULL,
  sexo VARCHAR(45) NULL,
  telefono VARCHAR(12) NULL,
  email VARCHAR(45) NULL,
  idDomicilio NUMERIC NOT NULL,
  PRIMARY KEY(curp),
  CONSTRAINT fk_domicilio_contribuyentes FOREIGN KEY(idDomicilio) REFERENCES Domicilios(idDomicilio)
);

DROP TABLE Licencias CASCADE CONSTRAINTS;
CREATE TABLE Licencias (
  idLicencia NUMERIC NOT NULL,
  idContribuyente VARCHAR(18) NOT NULL,
  tipoLicencia VARCHAR(2) NOT NULL,
  fechaExpedicion DATE NOT NULL,
  fechaExpiracion DATE NOT NULL,
  donadorOrganos CHAR(1) NOT NULL,
  contactoEmergencia VARCHAR(45) NOT NULL,
  telefonoEmergencia VARCHAR(12) NOT NULL,
  PRIMARY KEY(idLicencia),
  CONSTRAINT fk_curp_contribuyente FOREIGN KEY(idContribuyente) REFERENCES Contribuyentes(curp)
);

DROP TABLE Empleados CASCADE CONSTRAINTS;
CREATE TABLE Empleados (
  curp VARCHAR(18) NOT NULL,
  rfc VARCHAR(13) NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  paterno VARCHAR(45) NOT NULL,
  materno VARCHAR(45) NOT NULL,
  username VARCHAR(45) NOT NULL,
  password VARCHAR(200) NOT NULL,
  edad NUMERIC NULL,
  sexo VARCHAR(45) NULL,
  email VARCHAR(45) NULL,
  telefono VARCHAR(12) NOT NULL,
  idDomicilio NUMERIC NOT NULL,
  PRIMARY KEY(curp),
  CONSTRAINT fk_domicilio_empleados FOREIGN KEY(idDomicilio) REFERENCES Domicilios(idDomicilio)
);

-- Tablas de Vehiculos
DROP TABLE MarcasVehiculos CASCADE CONSTRAINTS;
CREATE TABLE MarcasVehiculos (
  idMarca NUMERIC NOT NULL,
  nombre VARCHAR(45) NULL,
  PRIMARY KEY(idMarca)
);

DROP TABLE TiposVehiculos CASCADE CONSTRAINTS;
CREATE TABLE TiposVehiculos (
  idTipo NUMERIC NOT NULL,
  tipo VARCHAR(45) NULL,
  PRIMARY KEY(idTipo)
);

DROP TABLE PadronVehicular CASCADE CONSTRAINTS;
CREATE TABLE PadronVehicular (
  noSerie VARCHAR(17) NOT NULL,
  noFactura VARCHAR(45) NOT NULL,
  fechaFactura DATE NOT NULL,
  importeFactura NUMERIC(38,2) NOT NULL,
  implementacion VARCHAR(45) NOT NULL,
  color VARCHAR(45) NOT NULL,
  combustible VARCHAR(45) NOT NULL,
  pasajeros NUMERIC NOT NULL,
  idTipo NUMERIC NOT NULL,
  idMarca NUMERIC NOT NULL,
  idContribuyente VARCHAR(18) NOT NULL,
  idEmpleado VARCHAR(18) NOT NULL,
  PRIMARY KEY(noSerie),
  CONSTRAINT fk_empleado_padron FOREIGN KEY(idEmpleado) REFERENCES Empleados(curp),
  CONSTRAINT fk_contribuyente_padron FOREIGN KEY(idContribuyente) REFERENCES Contribuyentes(curp),
  CONSTRAINT fk_marca_padron FOREIGN KEY(idMarca) REFERENCES MarcasVehiculos(idMarca),
  CONSTRAINT fk_tipo_padron FOREIGN KEY(idTipo) REFERENCES TiposVehiculos(idTipo)
);

DROP TABLE PlacasVehiculos CASCADE CONSTRAINTS;
CREATE TABLE PlacasVehiculos (
  idPlacas VARCHAR(10) NOT NULL,
  idLicencia NUMERIC NOT NULL,
  idVehiculo VARCHAR(17) NOT NULL,
  PRIMARY KEY(idPlacas),
  CONSTRAINT fk_placa_licencia FOREIGN KEY(idLicencia) REFERENCES Licencias(idLicencia),
  CONSTRAINT fk_placa_padron FOREIGN KEY(idVehiculo) REFERENCES PadronVehicular(noSerie)
);

-- Tablas de Multas
DROP TABLE Multas CASCADE CONSTRAINTS;
CREATE TABLE Multas (
  idMulta NUMERIC NOT NULL,
  idPlacas VARCHAR(10) NOT NULL,
  fechaExpedicionMulta DATE NOT NULL,
  fechaLiquidacionMulta DATE NULL,
  importe NUMERIC(38,2) NOT NULL,
  descripcion LONG NULL,
  PRIMARY KEY(idMulta),
  CONSTRAINT fk_multa_placas FOREIGN KEY(idPlacas) REFERENCES PlacasVehiculos(idPlacas)
);