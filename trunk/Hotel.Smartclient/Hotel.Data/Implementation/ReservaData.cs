using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data.Implementation
{
    public class ReservaData : IReservaData
    {
        #region IReservaData Members

        public void InsertReserva(reserva novaReserva)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.AddToreserva(novaReserva);
                contexto.SaveChanges();
            }
        }

        public void RemoveReserva(reserva reserva)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.DeleteObject(reserva);
                contexto.SaveChanges();
            }
        }

        public void UpdateReserva(reserva reserva)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                reserva reservaAux = contexto.reserva.First(r => r.IdReserva == reserva.IdReserva);

                contexto.DeleteObject(reservaAux);
                contexto.SaveChanges();
            }
        }

        public IList<reserva> SelectReservas()
        {
            IList<reserva> reservas = new List<reserva>();
            using (HotelEntities contexto = new HotelEntities())
            {
                var reservasQuery = from reserva r in contexto.reserva select r;

                if (reservasQuery != null)
                {
                    reservas = reservasQuery.ToList<reserva>();
                }
            }

            return reservas;
        }

        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto)
        {
            IList<reserva> reservas = new List<reserva>();

            using (HotelEntities contexto = new HotelEntities())
            {
                if (cliente != null && quarto == null)
                {
                    var reservasQuery = from reserva r in contexto.reserva 
                                        where r.cliente.IdCliente == cliente.IdCliente select r;
                } 
                else if (cliente == null && quarto != null)
                {
                    var reservasQuery = from reserva r in contexto.reserva 
                                        where r.quarto.IdQuarto == quarto.IdQuarto select r;
                }
                else if (cliente != null && quarto != null)
                {
                    var reservasQuery = from reserva r in contexto.reserva
                                        where r.quarto.IdQuarto == quarto.IdQuarto
                                        && r.cliente.IdCliente == cliente.IdCliente
                                        select r;
                }
                else
                {
                    var reservasQuery = from reserva r in contexto.reserva select r;
                }
            }

            

            return reservas;
        }

        #endregion
    }
}
