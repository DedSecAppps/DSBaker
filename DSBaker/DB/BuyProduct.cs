//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSBaker.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyProduct
    {
        public int IdBuyProduct { get; set; }
        public int IdBuy { get; set; }
        public int IdProduct { get; set; }
        public string Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
