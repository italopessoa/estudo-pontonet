using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Business
{
    public interface ITipoQuartoBusiness
    {
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
    }
}
