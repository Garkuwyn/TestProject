//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduatesProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Positions
    {
        public Positions()
        {
            this.PersonsProffesions = new HashSet<PersonsProffesions>();
        }
    
        public int Id { get; set; }
        public string Position { get; set; }
        public Nullable<decimal> RateInPercent { get; set; }
    
        public virtual ICollection<PersonsProffesions> PersonsProffesions { get; set; }
    }
}
