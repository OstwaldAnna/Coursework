//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace magazin.Bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersObject
    {
        public int id { get; set; }
        public int idOrder { get; set; }
        public Nullable<int> idObject { get; set; }
    
        public virtual Closes Closes { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
