using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business.Implementation
{
    public class QuartoBusiness : IQuartoBusiness
    {
        #region IQuartoBusiness Members

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
