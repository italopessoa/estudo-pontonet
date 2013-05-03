﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface IQuartoBusiness
    {
        void InsertQuarto(quarto novoQuarto);

        void RemoveQuarto(quarto quarto);

        void UpdateQuarto(quarto quarto);

        IList<quarto> SelectQuartos();

        IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior);
    }
}