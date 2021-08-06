using SrPago.Examem.Cocktails.DataAccess.Implementation;
using SrPago.Examen.Cocktails.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SrPago.Examen.Cocktails.ViewModel.Implementation
{
    /// <summary>
    /// Clase for cocktail view model
    /// </summary>
    public class CocktailViewModel
    {
        /// <summary>
        /// Get list subfilter
        /// </summary>
        /// <param name="option">option selected</param>
        /// <returns>Drink filter</returns>
        public DrinksFilter GetListFilters(int option) 
        {
            var cocktailService = new CocktailServiceClient();
            switch (option)
            {
                case 0:
                    return cocktailService.GetListbyParameter('c', "Category");
                case 1:
                    return cocktailService.GetListbyParameter('g', "Glass");
                case 2:
                    return cocktailService.GetListbyParameter('i', "Ingredient");
            }
            return null;
        }
        
    }
}
