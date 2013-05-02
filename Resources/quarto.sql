-- Table: quarto

-- DROP TABLE quarto;

CREATE TABLE quarto
(
  "IdQuarto" serial NOT NULL,
  "TipoQuarto" integer NOT NULL,
  "PrecoQuarto" double precision NOT NULL,
  "DtCadastro" date NOT NULL,
  CONSTRAINT quarto_pk PRIMARY KEY ("IdQuarto"),
  CONSTRAINT tiop_quarto_fk FOREIGN KEY ("TipoQuarto")
      REFERENCES tipo_quarto ("IdTipoQuarto") MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE quarto
  OWNER TO postgres;
