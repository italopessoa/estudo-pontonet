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

        public void InsertCliente(cliente novoCliente)
        {
            this.clienteData.InsertCliente(novoCliente);   
        }

        public void RemoveCliente(cliente cliente)
        {
            this.clienteData.RemoveCliente(cliente);
        }

        public void UpdateCliente(cliente cliente)
        {
            this.clienteData.UpdateCliente(cliente);
        }

        public IList<cliente> SelectClientesByNome(string nomeCliente)
        {
            return this.clienteData.SelectClientesByNome(nomeCliente);
        }

        public IList<cliente> SelectClientes()
        {
            return this.clienteData.SelectClientes();
        }

        #endregion
    }
}
