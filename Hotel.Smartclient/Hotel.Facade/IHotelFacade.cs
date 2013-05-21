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

        /// <summary>
        /// Método para inserir novo tipo de quarto.
        /// </summary>
        /// <param name="novoTipoQuarto">Nova Tipo de Quarto. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void InsertTipoQuarto(tipo_quarto novoTipoQuarto);

        /// <summary>
        /// Método para remover um tipo de quarto.
        /// </summary>
        /// <param name="tipoQuarto">Tipo de quarto a ser removida. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void RemoveTipoQuarto(tipo_quarto tipoQuarto);

        /// <summary>
        /// Método para alterar os dados de um tipo de quarto.
        /// </summary>
        /// <param name="tipoQuarto">Tipo de quarto a ser alterado. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void UpdateTipoQuarto(tipo_quarto tipoQuarto);

        /// <summary>
        /// Selecionar todos os Tipos de quarto.
        /// </summary>
        /// <returns>Lista de Tipos de quarto <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<tipo_quarto> SelectTiposQuarto();

        /// <summary>
        /// Selecionar tipo de quarto pelo Identificador.
        /// </summary>
        /// <returns>Tipo de quarto <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
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

        #endregion
    }
}
