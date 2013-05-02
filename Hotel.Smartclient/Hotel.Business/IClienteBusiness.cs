using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface IClienteBusiness
    {
        void InsertCliente(cliente novoCliente);

        void RemoveCliente(cliente cliente);

        void UpdateCliente(cliente cliente);

        IList<cliente> SelectClientesByNome(string nomeCliente);

        IList<cliente> SelectClientes();
    }
}
