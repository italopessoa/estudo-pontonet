using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface IReservaBusiness
    {
        void InsertReserva(reserva novaReserva);

        void RemoveReserva(reserva reserva);

        void UpdateReserva(reserva reserva);

        IList<reserva> SelectReservas();

        IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto);
    }
}
