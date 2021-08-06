using System;
using System.Collections.Generic;
using System.Text;

namespace SrPago.Examen.Cocktails.Model
{
    /// <summary>
    /// Dto for lis filters
    /// </summary>
    public class DrinksFilter
    {
        /// <summary>
        /// Element of filter
        /// </summary>
        public List<Category> drinks { set; get; }
    }
}
