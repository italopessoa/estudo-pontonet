﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("HotelModel", "reserva_cliente_fk", "cliente", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Hotel.Entity.cliente), "reserva", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Hotel.Entity.reserva))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("HotelModel", "reserva_quarto_fk", "quarto", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Hotel.Entity.quarto), "reserva", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Hotel.Entity.reserva))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("HotelModel", "tiop_quarto_fk", "tipo_quarto", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Hotel.Entity.tipo_quarto), "quarto", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Hotel.Entity.quarto))]

// Original file name:
// Generation date: 14/05/2013 13:08:26
namespace Hotel.Entity
{
    
    /// <summary>
    /// There are no comments for HotelEntities in the schema.
    /// </summary>
    public partial class HotelEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new HotelEntities object using the connection string found in the 'HotelEntities' section of the application configuration file.
        /// </summary>
        public HotelEntities() : 
                base("name=HotelEntities", "HotelEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new HotelEntities object.
        /// </summary>
        public HotelEntities(string connectionString) : 
                base(connectionString, "HotelEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new HotelEntities object.
        /// </summary>
        public HotelEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "HotelEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<cliente> cliente
        {
            get
            {
                if ((this._cliente == null))
                {
                    this._cliente = base.CreateQuery<cliente>("[cliente]");
                }
                return this._cliente;
            }
        }
        private global::System.Data.Objects.ObjectQuery<cliente> _cliente;
        /// <summary>
        /// There are no comments for quarto in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<quarto> quarto
        {
            get
            {
                if ((this._quarto == null))
                {
                    this._quarto = base.CreateQuery<quarto>("[quarto]");
                }
                return this._quarto;
            }
        }
        private global::System.Data.Objects.ObjectQuery<quarto> _quarto;
        /// <summary>
        /// There are no comments for reserva in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<reserva> reserva
        {
            get
            {
                if ((this._reserva == null))
                {
                    this._reserva = base.CreateQuery<reserva>("[reserva]");
                }
                return this._reserva;
            }
        }
        private global::System.Data.Objects.ObjectQuery<reserva> _reserva;
        /// <summary>
        /// There are no comments for tipo_quarto in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<tipo_quarto> tipo_quarto
        {
            get
            {
                if ((this._tipo_quarto == null))
                {
                    this._tipo_quarto = base.CreateQuery<tipo_quarto>("[tipo_quarto]");
                }
                return this._tipo_quarto;
            }
        }
        private global::System.Data.Objects.ObjectQuery<tipo_quarto> _tipo_quarto;
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        public void AddTocliente(cliente cliente)
        {
            base.AddObject("cliente", cliente);
        }
        /// <summary>
        /// There are no comments for quarto in the schema.
        /// </summary>
        public void AddToquarto(quarto quarto)
        {
            base.AddObject("quarto", quarto);
        }
        /// <summary>
        /// There are no comments for reserva in the schema.
        /// </summary>
        public void AddToreserva(reserva reserva)
        {
            base.AddObject("reserva", reserva);
        }
        /// <summary>
        /// There are no comments for tipo_quarto in the schema.
        /// </summary>
        public void AddTotipo_quarto(tipo_quarto tipo_quarto)
        {
            base.AddObject("tipo_quarto", tipo_quarto);
        }
    }
    /// <summary>
    /// There are no comments for HotelModel.cliente in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdCliente
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="HotelModel", Name="cliente")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class cliente : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new cliente object.
        /// </summary>
        /// <param name="idCliente">Initial value of IdCliente.</param>
        /// <param name="nomeCliente">Initial value of NomeCliente.</param>
        /// <param name="dtNascimento">Initial value of DtNascimento.</param>
        /// <param name="dtCadastro">Initial value of DtCadastro.</param>
        public static cliente Createcliente(int idCliente, string nomeCliente, global::System.DateTime dtNascimento, global::System.DateTime dtCadastro)
        {
            cliente cliente = new cliente();
            cliente.IdCliente = idCliente;
            cliente.NomeCliente = nomeCliente;
            cliente.DtNascimento = dtNascimento;
            cliente.DtCadastro = dtCadastro;
            return cliente;
        }
        /// <summary>
        /// There are no comments for Property IdCliente in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente
        {
            get
            {
                return this._IdCliente;
            }
            set
            {
                this.OnIdClienteChanging(value);
                this.ReportPropertyChanging("IdCliente");
                this._IdCliente = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IdCliente");
                this.OnIdClienteChanged();
            }
        }
        private int _IdCliente;
        partial void OnIdClienteChanging(int value);
        partial void OnIdClienteChanged();
        /// <summary>
        /// There are no comments for Property NomeCliente in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeCliente
        {
            get
            {
                return this._NomeCliente;
            }
            set
            {
                this.OnNomeClienteChanging(value);
                this.ReportPropertyChanging("NomeCliente");
                this._NomeCliente = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NomeCliente");
                this.OnNomeClienteChanged();
            }
        }
        private string _NomeCliente;
        partial void OnNomeClienteChanging(string value);
        partial void OnNomeClienteChanged();
        /// <summary>
        /// There are no comments for Property DtNascimento in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtNascimento
        {
            get
            {
                return this._DtNascimento;
            }
            set
            {
                this.OnDtNascimentoChanging(value);
                this.ReportPropertyChanging("DtNascimento");
                this._DtNascimento = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtNascimento");
                this.OnDtNascimentoChanged();
            }
        }
        private global::System.DateTime _DtNascimento;
        partial void OnDtNascimentoChanging(global::System.DateTime value);
        partial void OnDtNascimentoChanged();
        /// <summary>
        /// There are no comments for Property EmailCliente in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailCliente
        {
            get
            {
                return this._EmailCliente;
            }
            set
            {
                this.OnEmailClienteChanging(value);
                this.ReportPropertyChanging("EmailCliente");
                this._EmailCliente = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("EmailCliente");
                this.OnEmailClienteChanged();
            }
        }
        private string _EmailCliente;
        partial void OnEmailClienteChanging(string value);
        partial void OnEmailClienteChanged();
        /// <summary>
        /// There are no comments for Property TelefoneCliente in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string TelefoneCliente
        {
            get
            {
                return this._TelefoneCliente;
            }
            set
            {
                this.OnTelefoneClienteChanging(value);
                this.ReportPropertyChanging("TelefoneCliente");
                this._TelefoneCliente = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("TelefoneCliente");
                this.OnTelefoneClienteChanged();
            }
        }
        private string _TelefoneCliente;
        partial void OnTelefoneClienteChanging(string value);
        partial void OnTelefoneClienteChanged();
        /// <summary>
        /// There are no comments for Property DtCadastro in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtCadastro
        {
            get
            {
                return this._DtCadastro;
            }
            set
            {
                this.OnDtCadastroChanging(value);
                this.ReportPropertyChanging("DtCadastro");
                this._DtCadastro = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtCadastro");
                this.OnDtCadastroChanged();
            }
        }
        private global::System.DateTime _DtCadastro;
        partial void OnDtCadastroChanging(global::System.DateTime value);
        partial void OnDtCadastroChanged();
        /// <summary>
        /// There are no comments for reserva in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "reserva_cliente_fk", "reserva")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<reserva> reserva
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<reserva>("HotelModel.reserva_cliente_fk", "reserva");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<reserva>("HotelModel.reserva_cliente_fk", "reserva", value);
                }
            }
        }

        public int Idade
        {
            get
            {
                int anos = System.DateTime.Now.Year - this._DtNascimento.Year;
                if (System.DateTime.Now.Month < this._DtNascimento.Month ||
                    (System.DateTime.Now.Month == this._DtNascimento.Month && System.DateTime.Now.Day < this._DtNascimento.Day))
                    anos--;
                return anos;
            }
        }
    }
    /// <summary>
    /// There are no comments for HotelModel.quarto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdQuarto
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="HotelModel", Name="quarto")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class quarto : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new quarto object.
        /// </summary>
        /// <param name="idQuarto">Initial value of IdQuarto.</param>
        /// <param name="precoQuarto">Initial value of PrecoQuarto.</param>
        /// <param name="dtCadastro">Initial value of DtCadastro.</param>
        public static quarto Createquarto(int idQuarto, double precoQuarto, global::System.DateTime dtCadastro)
        {
            quarto quarto = new quarto();
            quarto.IdQuarto = idQuarto;
            quarto.PrecoQuarto = precoQuarto;
            quarto.DtCadastro = dtCadastro;
            return quarto;
        }
        /// <summary>
        /// There are no comments for Property IdQuarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int IdQuarto
        {
            get
            {
                return this._IdQuarto;
            }
            set
            {
                this.OnIdQuartoChanging(value);
                this.ReportPropertyChanging("IdQuarto");
                this._IdQuarto = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IdQuarto");
                this.OnIdQuartoChanged();
            }
        }
        private int _IdQuarto;
        partial void OnIdQuartoChanging(int value);
        partial void OnIdQuartoChanged();
        /// <summary>
        /// There are no comments for Property PrecoQuarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecoQuarto
        {
            get
            {
                return this._PrecoQuarto;
            }
            set
            {
                this.OnPrecoQuartoChanging(value);
                this.ReportPropertyChanging("PrecoQuarto");
                this._PrecoQuarto = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PrecoQuarto");
                this.OnPrecoQuartoChanged();
            }
        }
        private double _PrecoQuarto;
        partial void OnPrecoQuartoChanging(double value);
        partial void OnPrecoQuartoChanged();
        /// <summary>
        /// There are no comments for Property DtCadastro in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtCadastro
        {
            get
            {
                return this._DtCadastro;
            }
            set
            {
                this.OnDtCadastroChanging(value);
                this.ReportPropertyChanging("DtCadastro");
                this._DtCadastro = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtCadastro");
                this.OnDtCadastroChanged();
            }
        }
        private global::System.DateTime _DtCadastro;
        partial void OnDtCadastroChanging(global::System.DateTime value);
        partial void OnDtCadastroChanged();
        /// <summary>
        /// There are no comments for reserva in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "reserva_quarto_fk", "reserva")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<reserva> reserva
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<reserva>("HotelModel.reserva_quarto_fk", "reserva");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<reserva>("HotelModel.reserva_quarto_fk", "reserva", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for tipo_quarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "tiop_quarto_fk", "tipo_quarto")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public tipo_quarto tipo_quarto
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<tipo_quarto>("HotelModel.tiop_quarto_fk", "tipo_quarto").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<tipo_quarto>("HotelModel.tiop_quarto_fk", "tipo_quarto").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for tipo_quarto in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<tipo_quarto> tipo_quartoReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<tipo_quarto>("HotelModel.tiop_quarto_fk", "tipo_quarto");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<tipo_quarto>("HotelModel.tiop_quarto_fk", "tipo_quarto", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for HotelModel.reserva in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdReserva
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="HotelModel", Name="reserva")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class reserva : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new reserva object.
        /// </summary>
        /// <param name="idReserva">Initial value of IdReserva.</param>
        /// <param name="dtEntrada">Initial value of DtEntrada.</param>
        /// <param name="dtSaida">Initial value of DtSaida.</param>
        public static reserva Createreserva(int idReserva, global::System.DateTime dtEntrada, global::System.DateTime dtSaida)
        {
            reserva reserva = new reserva();
            reserva.IdReserva = idReserva;
            reserva.DtEntrada = dtEntrada;
            reserva.DtSaida = dtSaida;
            return reserva;
        }
        /// <summary>
        /// There are no comments for Property IdReserva in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int IdReserva
        {
            get
            {
                return this._IdReserva;
            }
            set
            {
                this.OnIdReservaChanging(value);
                this.ReportPropertyChanging("IdReserva");
                this._IdReserva = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IdReserva");
                this.OnIdReservaChanged();
            }
        }
        private int _IdReserva;
        partial void OnIdReservaChanging(int value);
        partial void OnIdReservaChanged();
        /// <summary>
        /// There are no comments for Property DtEntrada in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtEntrada
        {
            get
            {
                return this._DtEntrada;
            }
            set
            {
                this.OnDtEntradaChanging(value);
                this.ReportPropertyChanging("DtEntrada");
                this._DtEntrada = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtEntrada");
                this.OnDtEntradaChanged();
            }
        }
        private global::System.DateTime _DtEntrada;
        partial void OnDtEntradaChanging(global::System.DateTime value);
        partial void OnDtEntradaChanged();
        /// <summary>
        /// There are no comments for Property DtSaida in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtSaida
        {
            get
            {
                return this._DtSaida;
            }
            set
            {
                this.OnDtSaidaChanging(value);
                this.ReportPropertyChanging("DtSaida");
                this._DtSaida = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtSaida");
                this.OnDtSaidaChanged();
            }
        }
        private global::System.DateTime _DtSaida;
        partial void OnDtSaidaChanging(global::System.DateTime value);
        partial void OnDtSaidaChanged();
        /// <summary>
        /// There are no comments for Property DtReserva in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> DtReserva
        {
            get
            {
                return this._DtReserva;
            }
            set
            {
                this.OnDtReservaChanging(value);
                this.ReportPropertyChanging("DtReserva");
                this._DtReserva = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtReserva");
                this.OnDtReservaChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _DtReserva;
        partial void OnDtReservaChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDtReservaChanged();
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "reserva_cliente_fk", "cliente")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public cliente cliente
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cliente>("HotelModel.reserva_cliente_fk", "cliente").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cliente>("HotelModel.reserva_cliente_fk", "cliente").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<cliente> clienteReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cliente>("HotelModel.reserva_cliente_fk", "cliente");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<cliente>("HotelModel.reserva_cliente_fk", "cliente", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for quarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "reserva_quarto_fk", "quarto")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public quarto quarto
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<quarto>("HotelModel.reserva_quarto_fk", "quarto").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<quarto>("HotelModel.reserva_quarto_fk", "quarto").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for quarto in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<quarto> quartoReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<quarto>("HotelModel.reserva_quarto_fk", "quarto");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<quarto>("HotelModel.reserva_quarto_fk", "quarto", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for HotelModel.tipo_quarto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdTipoQuarto
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="HotelModel", Name="tipo_quarto")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class tipo_quarto : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new tipo_quarto object.
        /// </summary>
        /// <param name="idTipoQuarto">Initial value of IdTipoQuarto.</param>
        /// <param name="nomeTipoQuarto">Initial value of NomeTipoQuarto.</param>
        /// <param name="dtCadastro">Initial value of DtCadastro.</param>
        public static tipo_quarto Createtipo_quarto(int idTipoQuarto, string nomeTipoQuarto, global::System.DateTime dtCadastro)
        {
            tipo_quarto tipo_quarto = new tipo_quarto();
            tipo_quarto.IdTipoQuarto = idTipoQuarto;
            tipo_quarto.NomeTipoQuarto = nomeTipoQuarto;
            tipo_quarto.DtCadastro = dtCadastro;
            return tipo_quarto;
        }
        /// <summary>
        /// There are no comments for Property IdTipoQuarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTipoQuarto
        {
            get
            {
                return this._IdTipoQuarto;
            }
            set
            {
                this.OnIdTipoQuartoChanging(value);
                this.ReportPropertyChanging("IdTipoQuarto");
                this._IdTipoQuarto = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IdTipoQuarto");
                this.OnIdTipoQuartoChanged();
            }
        }
        private int _IdTipoQuarto;
        partial void OnIdTipoQuartoChanging(int value);
        partial void OnIdTipoQuartoChanged();
        /// <summary>
        /// There are no comments for Property NomeTipoQuarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeTipoQuarto
        {
            get
            {
                return this._NomeTipoQuarto;
            }
            set
            {
                this.OnNomeTipoQuartoChanging(value);
                this.ReportPropertyChanging("NomeTipoQuarto");
                this._NomeTipoQuarto = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NomeTipoQuarto");
                this.OnNomeTipoQuartoChanged();
            }
        }
        private string _NomeTipoQuarto;
        partial void OnNomeTipoQuartoChanging(string value);
        partial void OnNomeTipoQuartoChanged();
        /// <summary>
        /// There are no comments for Property DtCadastro in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DtCadastro
        {
            get
            {
                return this._DtCadastro;
            }
            set
            {
                this.OnDtCadastroChanging(value);
                this.ReportPropertyChanging("DtCadastro");
                this._DtCadastro = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DtCadastro");
                this.OnDtCadastroChanged();
            }
        }
        private global::System.DateTime _DtCadastro;
        partial void OnDtCadastroChanging(global::System.DateTime value);
        partial void OnDtCadastroChanged();
        /// <summary>
        /// There are no comments for quarto in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("HotelModel", "tiop_quarto_fk", "quarto")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<quarto> quarto
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<quarto>("HotelModel.tiop_quarto_fk", "quarto");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<quarto>("HotelModel.tiop_quarto_fk", "quarto", value);
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            tipo_quarto castObj = (tipo_quarto)obj;
            return (castObj != null) &&
                (this._IdTipoQuarto == castObj._IdTipoQuarto);
        }
    }
}
