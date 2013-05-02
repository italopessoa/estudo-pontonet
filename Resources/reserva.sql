-- Table: reserva

-- DROP TABLE reserva;

CREATE TABLE reserva
(
  "IdReserva" serial NOT NULL,
  "IdCliente" integer NOT NULL,
  "IdQuarto" integer NOT NULL,
  "DtEntrada" date NOT NULL,
  "DtSaida" date NOT NULL,
  CONSTRAINT reserva_pk PRIMARY KEY ("IdReserva"),
  CONSTRAINT reserva_cliente_fk FOREIGN KEY ("IdCliente")
      REFERENCES cliente ("IdCliente") MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT reserva_quarto_fk FOREIGN KEY ("IdQuarto")
      REFERENCES quarto ("IdQuarto") MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE reserva
  OWNER TO postgres;
