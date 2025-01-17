CREATE TABLE BAIRRO (
  BAI_ID SMALLINT NOT NULL PRIMARY KEY,
  BAI_DS VARCHAR(70) NOT NULL
);
COMMIT;

CREATE GENERATOR GEN_BAI_ID;

CREATE TRIGGER T_BAIRRO_01
  ACTIVE BEFORE INSERT OR UPDATE
  ON BAIRRO
AS
BEGIN
  IF (NEW.BAI_ID IS NULL)
    THEN NEW.BAI_ID = NEXT VALUE FOR GEN_BAI_ID;
END;

COMMIT;

CREATE TABLE CIDADE (
  CID_ID SMALLINT NOT NULL PRIMARY KEY,
  CID_DS VARCHAR(70) NOT NULL,
  CID_UF CHAR(02) NOT NULL
);
COMMIT;

CREATE GENERATOR GEN_CID_ID;

CREATE TRIGGER T_CIDADE_01
  ACTIVE BEFORE INSERT OR UPDATE
  ON CIDADE
AS
BEGIN
  IF (NEW.CID_ID IS NULL)
    THEN NEW.CID_ID = NEXT VALUE FOR GEN_CID_ID;
END;

COMMIT;


CREATE TABLE PESSOA (
  PES_ID SMALLINT NOT NULL PRIMARY KEY,
  PES_NOME VARCHAR(200) NOT NULL,
  PES_CPF VARCHAR(20) NOT NULL,
  PES_ENDERECO CHAR(70) NOT NULL,
  PES_ENDERECO_NR INTEGER NOT NULL,
  PES_CEP VARCHAR(20) NOT NULL,
  PES_TELEFONE_PRINCIPAL VARCHAR(20) NOT NULL,
  PES_TELEFONE_SECUNDARIO VARCHAR(20) NOT NULL
);
COMMIT;

CREATE GENERATOR GEN_PES_ID;

CREATE TRIGGER T_PESSOA_01
  ACTIVE BEFORE INSERT OR UPDATE
  ON PESSOA
AS
BEGIN
  IF (NEW.PES_ID IS NULL)
    THEN NEW.PES_ID = NEXT VALUE FOR GEN_PES_ID;
END;

COMMIT;
