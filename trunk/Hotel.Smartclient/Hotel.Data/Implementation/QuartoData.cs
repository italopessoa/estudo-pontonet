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
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.AddToquarto(novoQuarto);
                contexto.SaveChanges();
            }
        }

        public void RemoveQuarto(quarto quarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                quarto quartoAux = contexto.quarto.First(q => q.IdQuarto == quarto.IdQuarto);

                contexto.DeleteObject(quartoAux);
                contexto.SaveChanges();
            }
        }

        public void UpdateQuarto(quarto quarto)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                quarto quartoAux = contexto.quarto.First(q => q.IdQuarto == quarto.IdQuarto);

                /*if (quartoeAux != null)
                {
                    quartoeAux.NomeCliente = cliente.NomeCliente;
                }*/
                contexto.SaveChanges();
            }
        }

        public IList<quarto> SelectQuartos()
        {
            List<quarto> quartos = new List<quarto>();
            using (HotelEntities contexto = new HotelEntities())
            {
                var quartoQuery = from quarto q in contexto.quarto select q;

                if (quartoQuery != null)
                {
                    quartos = quartoQuery.ToList<quarto>();
                }
            }

            return quartos;
        }

        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior)
        {
            List<quarto> quartos = new List<quarto>();
            using (HotelEntities contexto = new HotelEntities())
            {
            }

            return quartos;
        }

        #endregion
    }
}
