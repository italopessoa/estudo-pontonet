using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data.Implementation
{
    public class QuartoData : IQuartoData
    {
        #region IQuartoData Members

        public void InsertQuarto(quarto novoQuarto)
        {
            throw new NotImplementedException();
        }

        public void RemoveQuarto(quarto quarto)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuarto(quarto quarto)
        {
            throw new NotImplementedException();
        }

        public IList<quarto> SelectQuartos()
        {
            throw new NotImplementedException();
        }

        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tiopQuarto, double preco, bool maior)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
