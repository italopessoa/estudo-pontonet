using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;
using Hotel.Data;
using Hotel.Data.Implementation;

namespace Hotel.Business.Implementation
{
    public class ClienteBusiness : IClienteBusiness
    {
        private IClienteData clienteData = new ClienteData();

        #region Private Members
        #endregion

        #region Constructor
        #endregion

        #region IClienteBusiness Members

        /// <summary>
        /// <see cref="Hotel.Business.IClienteBusiness.InserirCliente"/>
        /// </summary>
        public void InsertCliente(cliente novoCliente)
        {
            this.clienteData.InsertCliente(novoCliente);   
        }

        /// <summary>
        /// <see cref="Hotel.Business.IClienteBusiness.RemoveCliente"/>
        /// </summary>
        public void RemoveCliente(cliente cliente)
        {
            this.clienteData.RemoveCliente(cliente);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IClienteBusiness.UpdateCliente"/>
        /// </summary>
        public void UpdateCliente(cliente cliente)
        {
            this.clienteData.UpdateCliente(cliente);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IClienteBusiness.SelectClientesByNome"/>
        /// </summary>
        public IList<cliente> SelectClientesByNome(string nomeCliente)
        {
            return this.clienteData.SelectClientesByNome(nomeCliente);
        }

        /// <summary>
        /// <see cref="Hotel.Business.IClienteBusiness.SelectClientes"/>
        /// </summary>
        public IList<cliente> SelectClientes()
        {
            return this.clienteData.SelectClientes();
        }

        #endregion
    }
}
