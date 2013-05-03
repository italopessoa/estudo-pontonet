using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Facade
{
    public interface IHotelFacade
    {
        #region Cliente

        void InsertCliente(cliente novoCliente);

        void RemoveCliente(cliente cliente);

        void UpdateCliente(cliente cliente);

        IList<cliente> SelectClientesByNome(string nomeCliente);

        IList<cliente> SelectClientes();

        #endregion

        #region TipoQuarto

        void InsertTipoQuarto(tipo_quarto novoTipoQuarto);

        void RemoveTipoQuarto(tipo_quarto tipoQuarto);

        void UpdateTipoQuarto(tipo_quarto tipoQuarto);

        IList<tipo_quarto> SelectTiposQuarto();

        #endregion

        #region Quarto

        void InsertQuarto(quarto novoQuarto);

        void RemoveQuarto(quarto quarto);

        void UpdateQuarto(quarto quarto);

        IList<quarto> SelectQuartos();

        IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior);

        #endregion

        #region Reserva

        void InsertReserva(reserva novaReserva);

        void RemoveReserva(reserva reserva);

        void UpdateReserva(reserva reserva);

        IList<reserva> SelectReservas();

        IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto);

        #endregion
    }
}
