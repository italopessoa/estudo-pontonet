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

        /// <summary>
        /// Método para inserir novo cliente.
        /// </summary>
        /// <param name="novoCliente">Novo Cliente. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void InsertCliente(cliente novoCliente);

        /// <summary>
        /// Método para remover um cliente.
        /// </summary>
        /// <param name="cliente">Cliente a ser removido. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void RemoveCliente(cliente cliente);

        /// <summary>
        /// Atualizar dados do cliente.
        /// </summary>
        /// <param name="cliente">Cliente a ser atualizado. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void UpdateCliente(cliente cliente);

        /// <summary>
        ///  Selecionar clientes por nome.
        /// </summary>
        /// <param name="nomeCliente">Nome do cliente ou parte dele</param>
        /// <returns>Lista de Clientes <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<cliente> SelectClientesByNome(string nomeCliente);

        /// <summary>
        ///  Selecionar todos os Clientes.
        /// </summary>
        /// <returns>Lista de Clientes <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<cliente> SelectClientes();

        #endregion

        #region TipoQuarto

        void InsertTipoQuarto(tipo_quarto novoTipoQuarto);

        void RemoveTipoQuarto(tipo_quarto tipoQuarto);

        void UpdateTipoQuarto(tipo_quarto tipoQuarto);

        IList<tipo_quarto> SelectTiposQuarto();

        tipo_quarto SelectTipoQuartoById(int idTipoQuarto);

        #endregion

        #region Quarto

        /// <summary>
        /// Método para inserir novo quarto.
        /// </summary>
        /// <param name="novoQuarto">Novo Quarto. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void InsertQuarto(quarto novoQuarto);

        /// <summary>
        /// Remover quarto.
        /// </summary>
        /// <param name="quarto">Quarto a ser removido. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void RemoveQuarto(quarto quarto);

        /// <summary>
        /// Atualizar dados do quarto.
        /// </summary>
        /// <param name="quarto">Quarto a ser atualizado. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void UpdateQuarto(quarto quarto);

        /// <summary>
        /// Selecionar todos os quartos.
        /// </summary>
        /// <returns>Lista de Quartos <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<quarto> SelectQuartos();

        /// <summary>
        /// Selecionar quartos por Tipo de Quarto e/ou Valor da diária.
        /// </summary>
        /// <param name="tipoQuarto">Tipo de Quarto <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        /// <param name="preco">Preço da diária do quarto</param>
        /// <param name="maior">Indica se o valor do quarto de ve ser maior que o indicado</param>
        /// <returns>Lista de Quartos <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
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
