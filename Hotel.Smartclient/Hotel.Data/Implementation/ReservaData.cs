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
                int idTipoQuarto = novaReserva.quarto.tipo_quarto.IdTipoQuarto;
                reserva aux = new reserva();

                aux.cliente = contexto.cliente.First(c => c.IdCliente == novaReserva.cliente.IdCliente);
                aux.quarto = contexto.quarto.First(q => q.IdQuarto == novaReserva.quarto.IdQuarto);
                aux.quarto.tipo_quarto = contexto.tipo_quarto.First(tq => tq.IdTipoQuarto == idTipoQuarto);
                aux.DtReserva = DateTime.Now;
                contexto.AddToreserva(aux);
                contexto.SaveChanges();
            }
        }

        public void RemoveReserva(reserva reserva)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                contexto.DeleteObject(contexto.reserva.First(r => r.IdReserva == reserva.IdReserva));
                contexto.SaveChanges();
            }
        }

        public void UpdateReserva(reserva reserva)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                reserva reservaAux = contexto.reserva.First(r => r.IdReserva == reserva.IdReserva);

                reservaAux.DtEntrada = reserva.DtEntrada;
                reservaAux.DtSaida = reserva.DtSaida;

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
                foreach (reserva item in reservasQuery)
                {
                    item.clienteReference.Load();
                    item.quartoReference.Load();
                }
            }

            return reservas;
        }

        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto)
        {
            IList<reserva> reservas = new List<reserva>();

            using (HotelEntities contexto = new HotelEntities())
            {
                IQueryable<reserva> reservasQuery = null;
                if (cliente != null && quarto == null)
                {
                    reservasQuery = from reserva r in contexto.reserva
                                    where r.cliente.IdCliente == cliente.IdCliente
                                    select r;
                }
                else if (cliente == null && quarto != null)
                {
                    reservasQuery = from reserva r in contexto.reserva
                                    where r.quarto.IdQuarto == quarto.IdQuarto
                                    select r;
                }
                else if (cliente != null && quarto != null)
                {
                    reservasQuery = from reserva r in contexto.reserva
                                    where r.quarto.IdQuarto == quarto.IdQuarto
                                    && r.cliente.IdCliente == cliente.IdCliente
                                    select r;
                }
                else
                {
                    reservasQuery = from reserva r in contexto.reserva select r;
                }

                foreach (reserva item in reservasQuery)
                {
                    item.clienteReference.Load();
                    item.quartoReference.Load();
                }
                reservas = reservasQuery.ToList<reserva>();
            }

            return reservas;
        }

        #endregion
    }
}