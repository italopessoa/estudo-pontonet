﻿using System;
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
            throw new NotImplementedException();
        }

        public void RemoveReserva(reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void UpdateReserva(reserva reserva)
        {
            throw new NotImplementedException();
        }

        public IList<reserva> SelectReservas()
        {
            throw new NotImplementedException();
        }

        public IList<quarto> SelectQuartoByClienteOrQuarto(cliente cliente, quarto uarto)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}