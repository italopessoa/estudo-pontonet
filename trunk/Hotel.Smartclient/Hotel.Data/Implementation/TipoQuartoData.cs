using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data.Implementation
{
    public class TipoQuartoData : ITipoQuartoData
    {
        #region ITipoQuartoData Members

        /// <summary>
        /// <see cref="Hotel.Data.ITipoQuartoData.InsertTipoQuarto"/>
        /// </summary>
        public void InsertTipoQuarto(tipo_quarto novoTipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                novoTipoQuarto.DtCadastro = DateTime.Now;
                contexto.AddTotipo_quarto(novoTipoQuarto);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.ITipoQuartoData.RemoveTipoQuarto"/>
        /// </summary>
        public void RemoveTipoQuarto(tipo_quarto tipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.DeleteObject(tipoQuarto);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.ITipoQuartoData.UpdateTipoQuarto"/>
        /// </summary>
        public void UpdateTipoQuarto(tipo_quarto tipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                tipo_quarto tipoQuartoAux = contexto.tipo_quarto.First(tq => tq.IdTipoQuarto == tipoQuarto.IdTipoQuarto);

                if (tipoQuartoAux != null)
                {
                    tipoQuartoAux.NomeTipoQuarto = tipoQuarto.NomeTipoQuarto;
                }
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.ITipoQuartoData.SelectTiposQuarto"/>
        /// </summary>
        public IList<tipo_quarto> SelectTiposQuarto()
        {
            List<tipo_quarto> tiposQuarto = new List<tipo_quarto>();
            using (HotelEntities contexto = new HotelEntities())
            {
                var tiposQuartoQuery = from tipo_quarto tq in contexto.tipo_quarto select tq;

                if (tiposQuartoQuery != null)
                {
                    tiposQuarto = tiposQuartoQuery.ToList<tipo_quarto>();
                }
            }
            return tiposQuarto;
        }

        /// <summary>
        /// <see cref="Hotel.Data.ITipoQuartoData.SelectTipoQuartoById"/>
        /// </summary>
        public tipo_quarto SelectTipoQuartoById(int idTipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                var tipoQuartoQuery = from tipo_quarto tq in contexto.tipo_quarto
                                      where tq.IdTipoQuarto == idTipoQuarto
                                      select tq;

                tipo_quarto tipoQuarto = null;
                if (tipoQuartoQuery != null)
                {
                     tipoQuarto = tipoQuartoQuery.First<tipo_quarto>();
                }

                return tipoQuarto;
            }
        }
        #endregion
    }
}
