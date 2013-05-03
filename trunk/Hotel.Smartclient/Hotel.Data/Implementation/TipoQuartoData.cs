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

        public void InsertTipoQuarto(tipo_quarto novoTipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                novoTipoQuarto.DtCadastro = DateTime.Now;
                contexto.AddTotipo_quarto(novoTipoQuarto);
                contexto.SaveChanges();
            }
        }

        public void RemoveTipoQuarto(tipo_quarto tipoQuarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.DeleteObject(tipoQuarto);
                contexto.SaveChanges();
            }
        }

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

        #endregion
    }
}
