using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface IReservaBusiness
    {
        /// <summary>
        /// Método para inserir nova reserva.
        /// </summary>
        /// <param name="novaReserva">Nova Reserva. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void InsertReserva(reserva novaReserva);

        /// <summary>
        /// Método para remover uma reserva.
        /// </summary>
        /// <param name="reserva">Reserva a ser removida. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void RemoveReserva(reserva reserva);

        /// <summary>
        /// Método para alterar os dados de uma reserva.
        /// </summary>
        /// <param name="reserva">Reserva a ser alterada. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void UpdateReserva(reserva reserva);

        /// <summary>
        /// Selecionar todas as reservas.
        /// </summary>
        /// <returns>Lista de tipo_quarto tipoQuarto <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<reserva> SelectReservas();

        /// <summary>
        /// Selecionar reservas por cliente e/ou quarto
        /// </summary>
        /// <param name="cliente">Cliente que fez a rserva. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        /// <param name="quarto">Quarto utilizado na reserva. <see cref="Hotel.Entity.HotelModel.Designer.cs"/></param>
        /// <returns>Lista de Reservas <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto);
    }
}
