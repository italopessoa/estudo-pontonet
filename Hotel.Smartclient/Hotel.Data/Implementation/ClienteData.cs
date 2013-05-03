using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data.Implementation
{
    public class ClienteData : IClienteData
    {
        #region IClienteData Members

        public void InsertCliente(cliente novoCliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                novoCliente.DtCadastro = DateTime.Now;
                contexto.AddTocliente(novoCliente);
                contexto.SaveChanges();
            }
        }

        public void RemoveCliente(cliente cliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                cliente clienteAux = contexto.cliente.First(c => c.IdCliente == cliente.IdCliente);

                contexto.DeleteObject(clienteAux);
                contexto.SaveChanges();
            }
        }

        public void UpdateCliente(cliente cliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                cliente clienteAux = contexto.cliente.First(c => c.IdCliente == cliente.IdCliente);

                if (clienteAux != null)
                {
                    clienteAux.NomeCliente = cliente.NomeCliente;
                }
                contexto.SaveChanges();
            }
        }

        public IList<cliente> SelectClientesByNome(string nomeCliente)
        {
            List<cliente> clientes = new List<cliente>();
            using (HotelEntities contexto = new HotelEntities())
            {
                var clientesQuery = from cliente c in contexto.cliente where c.NomeCliente.Contains(nomeCliente) select c ;

                if (clientesQuery != null)
                {
                    clientes = clientesQuery.ToList<cliente>();
                }
            }

            return clientes;
        }

        public IList<cliente> SelectClientes()
        {
            List<cliente> clientes = new List<cliente>();
            using (HotelEntities contexto = new HotelEntities())
            {
                var clientesQuery = from cliente c in contexto.cliente select c;

                if (clientesQuery != null)
                {
                    clientes = clientesQuery.ToList<cliente>();
                }
            }

            return clientes;
        }

        #endregion
    }
}
