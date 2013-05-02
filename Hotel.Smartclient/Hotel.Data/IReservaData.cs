using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data
{
    public interface IReservaData
    {
        void InsertReserva(reserva novaReserva);

        void RemoveReserva(reserva reserva);

        void UpdateReserva(reserva reserva);

        IList<reserva> SelectReservas();

        IList<quarto> SelectQuartoByClienteOrQuarto(cliente cliente, quarto uarto);
    }
}
