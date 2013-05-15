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
        #region Private Members

        private IQuartoData quartoData;

        #endregion

        #region Constructor

        public QuartoBusiness()
        {
            this.quartoData = new QuartoData();
        }

        #endregion

        #region IQuartoBusiness Members

        /// <summary>
        /// <see cref="Hotel.Business.IQuartoBusiness.InsertQuarto"/>
        /// </summary>
        public void InsertQuarto(quarto novoQuarto)
        {
            this.quartoData.InsertQuarto(novoQuarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IQuartoBusiness.RemoveQuarto"/>
        /// </summary>
        public void RemoveQuarto(quarto quarto)
        {
            this.quartoData.RemoveQuarto(quarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IQuartoBusiness.UpdateQuarto"/>
        /// </summary>
        public void UpdateQuarto(quarto quarto)
        {
            this.quartoData.UpdateQuarto(quarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IQuartoBusiness.SelectQuartos"/>
        /// </summary>
        public IList<quarto> SelectQuartos()
        {
            return this.quartoData.SelectQuartos();
        }

        /// <summary>
        /// <see cref="Hotel.Business.IQuartoBusiness.SelectQuartoByTipoQuartoOrPreco"/>
        /// </summary>
        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior)
        {
            return this.quartoData.SelectQuartoByTipoQuartoOrPreco(tipoQuarto, preco, maior);
        }

        #endregion
    }
}
