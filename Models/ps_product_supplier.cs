//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ps_product_supplier
    {
        public long id_product_supplier { get; set; }
        public long id_product { get; set; }
        public long id_product_attribute { get; set; }
        public long id_supplier { get; set; }
        public string product_supplier_reference { get; set; }
        public decimal product_supplier_price_te { get; set; }
        public long id_currency { get; set; }
    }
}
