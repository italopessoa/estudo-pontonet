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

        #region Private Members

        private IClienteBusiness clienteBusiness;
        private IQuartoBusiness quartoBusiness;
        private ITipoQuartoBusiness tipoQuartoBusiness;
        private IReservaBusiness reservaBusiness;

        #endregion

        #region Constructor

        public HotelFacade()
        {
            this.clienteBusiness = new ClienteBusiness();
            this.quartoBusiness = new QuartoBusiness();
            this.tipoQuartoBusiness = new TipoQuartoBusiness();
            this.reservaBusiness = new ReservaBusiness();
        }

        #endregion

        #region IHotelFacade Members

        #region Cliente

        /// <summary>
        /// <see cref="Hotel.IHotelFacade.InserirCliente"/>
        /// </summary>
        public void InsertCliente(cliente novoCliente)
        {
            this.clienteBusiness.InsertCliente(novoCliente);
        }

        /// <summary>
        /// <see cref="Hotel.IHotelFacade.RemoveCliente"/>
        /// </summary>
        public void RemoveCliente(cliente cliente)
        {
            this.clienteBusiness.RemoveCliente(cliente);
        }

        /// <summary>
        /// <see cref="Hotel.IHotelFacade.UpdateCliente"/>
        /// </summary>
        public void UpdateCliente(cliente cliente)
        {
            this.clienteBusiness.UpdateCliente(cliente);
        }

        /// <summary>
        /// <see cref="Hotel.IHotelFacade.SelectClientesByNome"/>
        /// </summary>
        public IList<cliente> SelectClientesByNome(string nomeCliente)
        {
            return this.clienteBusiness.SelectClientesByNome(nomeCliente);
        }

        /// <summary>
        /// <see cref="Hotel.IHotelFacade.SelectClientes"/>
        /// </summary>
        public IList<cliente> SelectClientes()
        {
            return this.clienteBusiness.SelectClientes();
        }

        #endregion

        #region TipoQuarto

        public void InsertTipoQuarto(tipo_quarto novoTipoQuarto)
        {
            this.tipoQuartoBusiness.InsertTipoQuarto(novoTipoQuarto);
        }

        public void RemoveTipoQuarto(tipo_quarto tipoQuarto)
        {
            this.tipoQuartoBusiness.RemoveTipoQuarto(tipoQuarto);
        }

        public void UpdateTipoQuarto(tipo_quarto tipoQuarto)
        {
            this.tipoQuartoBusiness.UpdateTipoQuarto(tipoQuarto);
        }

        public IList<tipo_quarto> SelectTiposQuarto()
        {
            return this.tipoQuartoBusiness.SelectTiposQuarto();
        }

        public tipo_quarto SelectTipoQuartoById(int idTipoQuarto)
        {
            return this.tipoQuartoBusiness.SelectTipoQuartoById(idTipoQuarto);
        }

        #endregion

        #region Quarto

        /// <summary>
        /// <see cref="Hotel.Facade.IHotelFacade.InsertQuarto"/>
        /// </summary>
        public void InsertQuarto(quarto novoQuarto)
        {
            this.quartoBusiness.InsertQuarto(novoQuarto);
        }

        /// <summary>
        /// <see cref="Hotel.Facade.IHotelFacade.RemoveQuarto"/>
        /// </summary>
        public void RemoveQuarto(quarto quarto)
        {
            this.quartoBusiness.RemoveQuarto(quarto);
        }

        /// <summary>
        /// <see cref="Hotel.Facade.IHotelFacade.UpdateQuarto"/>
        /// </summary>
        public void UpdateQuarto(quarto quarto)
        {
            this.quartoBusiness.UpdateQuarto(quarto);
        }

        /// <summary>
        /// <see cref="Hotel.Facade.IHotelFacade.SelectQuartos"/>
        /// </summary>
        public IList<quarto> SelectQuartos()
        {
            return this.quartoBusiness.SelectQuartos();
        }

        /// <summary>
        /// <see cref="Hotel.Facade.IHotelFacade.SelectQuartoByTipoQuartoOrPreco"/>
        /// </summary>
        public IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior)
        {
            return this.quartoBusiness.SelectQuartoByTipoQuartoOrPreco(tipoQuarto, preco, maior);
        }

        #endregion

        #region Reserva

        public void InsertReserva(reserva novaReserva)
        {
            this.reservaBusiness.InsertReserva(novaReserva);
        }

        public void RemoveReserva(reserva reserva)
        {
            this.reservaBusiness.RemoveReserva(reserva);
        }

        public void UpdateReserva(reserva reserva)
        {
            this.reservaBusiness.UpdateReserva(reserva);
        }

        public IList<reserva> SelectReservas()
        {
            return this.reservaBusiness.SelectReservas();
        }

        public IList<reserva> SelectReservaByClienteOrQuarto(cliente cliente, quarto quarto)
        {
            return this.reservaBusiness.SelectReservaByClienteOrQuarto(cliente, quarto);
        }

        #endregion

        #endregion
    }
}
