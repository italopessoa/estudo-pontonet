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

        /// <summary>
        /// <see cref="Hotel.Data.IClienteData.InserirCliente"/>
        /// </summary>
        public void InsertCliente(cliente novoCliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                novoCliente.DtCadastro = DateTime.Now;
                contexto.AddTocliente(novoCliente);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.IClienteData.RemoveCliente"/>
        /// </summary>
        public void RemoveCliente(cliente cliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                cliente clienteAux = contexto.cliente.First(c => c.IdCliente == cliente.IdCliente);

                contexto.DeleteObject(clienteAux);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.IClienteData.UpdateCliente"/>
        /// </summary>
        public void UpdateCliente(cliente cliente)
        {
            using (HotelEntities contexto = new HotelEntities())
            {
                cliente clienteAux = contexto.cliente.First(c => c.IdCliente == cliente.IdCliente);

                if (clienteAux != null)
                {
                    clienteAux.NomeCliente = cliente.NomeCliente;
                    clienteAux.DtNascimento = cliente.DtNascimento;
                    clienteAux.TelefoneCliente = cliente.TelefoneCliente;
                    clienteAux.EmailCliente = cliente.EmailCliente;
                }
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// <see cref="Hotel.Data.IClienteData.SelectClientesByNome"/>
        /// </summary>
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

        /// <summary>
        /// <see cref="Hotel.Data.IClienteData.SelectClientes"/>
        /// </summary>
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
