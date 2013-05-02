using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;
using Hotel.Business;
using Hotel.Business.Implementation;

namespace Hotel.Facade.Implementation
{
    public class HotelFacade : IHotelFacade
    {
        private IClienteBusiness clienteBusiness = new ClienteBusiness();

        #region IHotelFacade Members

        #region Cliente

        public void InsertCliente(cliente novoCliente)
        {
            this.clienteBusiness.InsertCliente(novoCliente);
        }

        public void RemoveCliente(cliente cliente)
        {
            this.clienteBusiness.RemoveCliente(cliente);
        }

        public void UpdateCliente(cliente cliente)
        {
            this.clienteBusiness.UpdateCliente(cliente);
        }

        public IList<cliente> SelectClientesByNome(string nomeCliente)
        {
            return this.clienteBusiness.SelectClientesByNome(nomeCliente);
        }

        public IList<cliente> SelectClientes()
        {
            return this.clienteBusiness.SelectClientes();
        }

        #endregion

        #region TipoQuarto

        public void InsertTipoQuarto(tipo_quarto novoTipoQuarto)
        {
            throw new NotImplementedException();
        }

        public void RemoveTipoQuarto(tipo_quarto tipoQuarto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTipoQuarto(tipo_quarto tipoQuarto)
        {
            throw new NotImplementedException();
        }

        public IList<tipo_quarto> SelectTiposQuarto()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Quarto

        public void InsertQuarto(quarto novoQuarto)
        {
            throw new NotImplementedException();
        }

        public void RemoveQuarto(quarto quarto)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuarto(quarto quarto)
        {
            throw new NotImplementedException();
        }

        public IList<quarto> SelectQuartos()
        {
            throw new NotImplementedException();
        }

        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tiopQuarto, double preco, bool maior)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Reserva

        public void InsertReserva(reserva novaReserva)
        {
            throw new NotImplementedException();
        }

        public void RemoveReserva(reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void UpdateReserva(reserva reserva)
        {
            throw new NotImplementedException();
        }

        public IList<reserva> SelectReservas()
        {
            throw new NotImplementedException();
        }

        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto uarto)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
