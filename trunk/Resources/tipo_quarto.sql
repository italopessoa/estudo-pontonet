-- Table: tipo_quarto

-- DROP TABLE tipo_quarto;

CREATE TABLE tipo_quarto
(
  "IdTipoQuarto" serial NOT NULL,
  "NomeTipoQuarto" character varying NOT NULL,
  "DtCadastro" date NOT NULL,
  CONSTRAINT tipo_quarto_pk PRIMARY KEY ("IdTipoQuarto")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE tipo_quarto
  OWNER TO postgres;
