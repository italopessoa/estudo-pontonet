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

        /// <summary>
        /// <see cref="Hotel.Business.IReservaBusiness.InsertReserva"/>
        /// </summary>
        public void InsertReserva(reserva novaReserva)
        {
            this.reservaData.InsertReserva(novaReserva);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IReservaBusiness.RemoveReserva"/>
        /// </summary>
        public void RemoveReserva(reserva reserva)
        {
            this.reservaData.RemoveReserva(reserva);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IReservaBusiness.UpdateReserva"/>
        /// </summary>
        public void UpdateReserva(reserva reserva)
        {
            this.reservaData.UpdateReserva(reserva);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IReservaBusiness.SelectReservas"/>
        /// </summaryBusiness
        public IList<reserva> SelectReservas()
        {
            return this.reservaData.SelectReservas();
        }

        /// <summary>
        /// <see cref="Hotel.Business.IReservaBusiness.SelectReservaByClienteOrQuarto"/>
        /// </summary>
        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto)
        {
            return this.reservaData.SelectReservaByClienteOrQuarto(cliente, quarto);
        }

        #endregion
    }
}
