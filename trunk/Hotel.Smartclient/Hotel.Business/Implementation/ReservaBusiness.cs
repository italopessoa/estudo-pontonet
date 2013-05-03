using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;
using Hotel.Data;
using Hotel.Data.Implementation;

namespace Hotel.Business.Implementation
{
    public class ReservaBusiness : IReservaBusiness
    {
        #region Private Members

        private IReservaData reservaData;

        #endregion

        #region Constructor

        public ReservaBusiness()
        {
            this.reservaData = new ReservaData();
        }

        #endregion

        #region IReservaBusiness Members

        public void InsertReserva(reserva novaReserva)
        {
            this.reservaData.InsertReserva(novaReserva);
        }

        public void RemoveReserva(reserva reserva)
        {
            this.reservaData.RemoveReserva(reserva);
        }

        public void UpdateReserva(reserva reserva)
        {
            this.reservaData.UpdateReserva(reserva);
        }

        public IList<reserva> SelectReservas()
        {
            return this.reservaData.SelectReservas();
        }

        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto)
        {
            return this.reservaData.SelectReservaByClienteOrQuarto(cliente, quarto);
        }

        #endregion
    }
}
