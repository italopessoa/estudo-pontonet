using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface IClienteBusiness
    {
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
    }
}
