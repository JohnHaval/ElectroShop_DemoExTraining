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
    
    public partial class Storage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int TypeID { get; set; }
        public int CompanyID { get; set; }        
    
        public virtual Companies Companies { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
        public virtual Types Types { get; set; }
    }
}