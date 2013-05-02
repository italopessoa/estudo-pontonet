-- Table: cliente

-- DROP TABLE cliente;

CREATE TABLE cliente
(
  "IdCliente" serial NOT NULL,
  "NomeCliente" character varying NOT NULL,
  "DtNascimento" date NOT NULL,
  "EmailCliente" character(1),
  "TelefoneCliente" character varying,
  "DtCadastro" date NOT NULL,
  CONSTRAINT cliente_pk PRIMARY KEY ("IdCliente")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE cliente
  OWNER TO postgres;
