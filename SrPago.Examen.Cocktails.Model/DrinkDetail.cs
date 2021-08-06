using System;
using System.Collections.Generic;
using System.Text;

namespace SrPago.Examen.Cocktails.Model
{
    /// <summary>
    /// Class for drink detail
    /// </summary>
    public class DrinkDetail
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Alcoholic
        /// </summary>
        public string Alcoholic { get; set; }

        /// <summary>
        /// Glass
        /// </summary>
        public string Glass { get; set; }

        /// <summary>
        /// Instructions
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Thumb { get; set; }

        /// <summary>
        /// Ingresients
        /// </summary>
        public string Ingredients { get; set; }
    }
}
