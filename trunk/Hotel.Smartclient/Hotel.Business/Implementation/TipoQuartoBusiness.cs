using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;
using Hotel.Data;
using Hotel.Data.Implementation;

namespace Hotel.Business.Implementation
{
    public class TipoQuartoBusiness : ITipoQuartoBusiness
    {
        #region Private Members

        private ITipoQuartoData tipoQuartoData;

        #endregion

        #region Constructor

        public TipoQuartoBusiness()
        {
            this.tipoQuartoData = new TipoQuartoData();
        }

        #endregion

        #region ITipoQuartoBusiness Members

        /// <summary>
        /// <see cref="Hotel.Business.ITipoQuartoBusiness.InsertTipoQuarto"/>
        /// </summary>
        public void InsertTipoQuarto(tipo_quarto novoTipoQuarto)
        {
            this.tipoQuartoData.InsertTipoQuarto(novoTipoQuarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.ITipoQuartoBusiness.RemoveTipoQuarto"/>
        /// </summary>
        public void RemoveTipoQuarto(tipo_quarto tipoQuarto)
        {
            this.tipoQuartoData.RemoveTipoQuarto(tipoQuarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.ITipoQuartoBusiness.UpdateTipoQuarto"/>
        /// </summary>
        public void UpdateTipoQuarto(tipo_quarto tipoQuarto)
        {
            this.tipoQuartoData.UpdateTipoQuarto(tipoQuarto);
        }

        /// <summary>
        /// <see cref="Hotel.Business.ITipoQuartoBusiness.SelectTiposQuarto"/>
        /// </summary>
        public IList<tipo_quarto> SelectTiposQuarto()
        {
            return this.tipoQuartoData.SelectTiposQuarto();
        }

        /// <summary>
        /// <see cref="Hotel.Business.ITipoQuartoBusiness.SelectTipoQuartoById"/>
        /// </summary>
        public tipo_quarto SelectTipoQuartoById(int idTipoQuarto)
        {
            return this.tipoQuartoData.SelectTipoQuartoById(idTipoQuarto);
        }

        #endregion
    }
}
