//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushkovExam.DataBaseF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorites
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> RecipeID { get; set; }
    
        public virtual Recipes Recipes { get; set; }
        public virtual Users Users { get; set; }
    }
}