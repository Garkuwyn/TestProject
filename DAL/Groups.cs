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
    
    public partial class Groups
    {
        public Groups()
        {
            this.Persons = new HashSet<Persons>();
        }
    
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Curator { get; set; }
    
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
