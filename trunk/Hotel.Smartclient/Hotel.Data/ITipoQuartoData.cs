using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data
{
    public interface ITipoQuartoData
    {
        void InsertTipoQuarto(tipo_quarto novoTipoQuarto);

        void RemoveTipoQuarto(tipo_quarto tipoQuarto);

        void UpdateTipoQuarto(tipo_quarto tipoQuarto);

        IList<tipo_quarto> SelectTiposQuarto();
    }
}
