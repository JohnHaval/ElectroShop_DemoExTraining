//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectroShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPrices
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
    
        public virtual Storage Storage { get; set; }
    }
}
