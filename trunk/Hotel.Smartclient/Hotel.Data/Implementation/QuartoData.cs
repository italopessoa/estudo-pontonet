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
            using (var contexto = new HotelEntities())
            {
                novoQuarto.DtCadastro = DateTime.Now;
                novoQuarto.tipo_quarto = contexto.tipo_quarto.First(tq => tq.IdTipoQuarto == novoQuarto.tipo_quarto.IdTipoQuarto);
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
                quartoAux.tipo_quartoReference.Load();

                if (quartoAux != null)
                {
                    if(quarto.PrecoQuarto>0)
                        quartoAux.PrecoQuarto = quarto.PrecoQuarto;

                    if (quarto.tipo_quarto != null)
                        quartoAux.tipo_quarto = contexto.tipo_quarto.First(tq => tq.IdTipoQuarto == quarto.tipo_quarto.IdTipoQuarto);
                }
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
                IQueryable<quarto> quartosQuery = null;
                if (tipoQuarto != null && preco > 0)
                {
                    if (maior)
                    {
                        //o tipo de quarto vai ser recuperado na tela, pois nao esta dando certo
                        quartosQuery = from quarto q in contexto.quarto
                                       where q.tipo_quarto.IdTipoQuarto == tipoQuarto.IdTipoQuarto
                                       && q.PrecoQuarto >= preco
                                       select q;
                    }
                    else
                    {
                        quartosQuery = from quarto q in contexto.quarto
                                       where q.tipo_quarto.IdTipoQuarto == tipoQuarto.IdTipoQuarto
                                       && q.PrecoQuarto <= preco
                                       select q;
                    }
                }

                if (tipoQuarto != null && preco == 0)
                {
                    quartosQuery = from quarto q in contexto.quarto
                                   where q.tipo_quarto.IdTipoQuarto == tipoQuarto.IdTipoQuarto
                                   select q;
                }

                if (tipoQuarto == null && preco > 0)
                {
                    if (maior)
                    {
                        quartosQuery = from quarto q in contexto.quarto
                                       where q.PrecoQuarto >= preco select q;
                    }
                    else
                    {
                        quartosQuery = from quarto q in contexto.quarto
                                       where q.PrecoQuarto <= preco select q;
                    }
                }

                if (tipoQuarto == null && preco == 0)
                {
                    quartosQuery = from quarto q in contexto.quarto select q;
                }

                if (quartosQuery != null)
                {
                    quartos = quartosQuery.ToList<quarto>();
                    foreach (quarto q in quartos) q.tipo_quartoReference.Load();
                }
            }

            return quartos;
        }

        #endregion
    }
}
