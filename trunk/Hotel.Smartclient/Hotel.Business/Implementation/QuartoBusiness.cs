using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;
using Hotel.Data;
using Hotel.Data.Implementation;

namespace Hotel.Business.Implementation
{
    public class QuartoBusiness : IQuartoBusiness
    {
        private IQuartoData quartoData = new QuartoData();

        #region IQuartoBusiness Members

        public void InsertQuarto(quarto novoQuarto)
        {
            this.quartoData.InsertQuarto(novoQuarto);
        }

        public void RemoveQuarto(quarto quarto)
        {
            this.quartoData.RemoveQuarto(quarto);
        }

        public void UpdateQuarto(quarto quarto)
        {
            this.quartoData.UpdateQuarto(quarto);
        }

        public IList<quarto> SelectQuartos()
        {
            return this.quartoData.SelectQuartos();
        }

        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior)
        {
            return this.quartoData.SelectQuartoByTipoQuartoOrPreco(tipoQuarto, preco, maior);
        }

        #endregion
    }
}
