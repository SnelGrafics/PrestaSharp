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
    
    public partial class ps_specific_price
    {
        public long id_specific_price { get; set; }
        public long id_specific_price_rule { get; set; }
        public long id_cart { get; set; }
        public long id_product { get; set; }
        public long id_shop { get; set; }
        public long id_shop_group { get; set; }
        public long id_currency { get; set; }
        public long id_country { get; set; }
        public long id_group { get; set; }
        public long id_customer { get; set; }
        public long id_product_attribute { get; set; }
        public decimal price { get; set; }
        public int from_quantity { get; set; }
        public decimal reduction { get; set; }
        public string reduction_type { get; set; }
        public System.DateTime from { get; set; }
        public System.DateTime to { get; set; }
    }
}
