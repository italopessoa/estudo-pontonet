using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Entity;

namespace Hotel.Data
{
    public interface IQuartoData
    {
        /// <summary>
        /// Método para inserir novo quarto.
        /// </summary>
        /// <param name="novoQuarto">Novo Quarto. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void InsertQuarto(quarto novoQuarto);

        /// <summary>
        /// Remover quarto.
        /// </summary>
        /// <param name="quarto">Quarto a ser removido. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void RemoveQuarto(quarto quarto);

        /// <summary>
        /// Atualizar dados do quarto.
        /// </summary>
        /// <param name="quarto">Quarto a ser atualizado. <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        void UpdateQuarto(quarto quarto);

        /// <summary>
        /// Selecionar todos os quartos.
        /// </summary>
        /// <returns>Lista de Quartos <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<quarto> SelectQuartos();
        
        /// <summary>
        /// Selecionar quartos por Tipo de Quarto e/ou Valor da diária.
        /// </summary>
        /// <param name="tipoQuarto">Tipo de Quarto <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </param>
        /// <param name="preco">Preço da diária do quarto</param>
        /// <param name="maior">Indica se o valor do quarto de ve ser maior que o indicado</param>
        /// <returns>Lista de Quartos <see cref="Hotel.Entity.HotelModel.Designer.cs"/> </returns>
        IList<quarto> SelectQuartoByTipoQuartoOrPreco(tipo_quarto tipoQuarto, double preco, bool maior);
    }
}
