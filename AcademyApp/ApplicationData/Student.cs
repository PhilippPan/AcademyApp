//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademyApp.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.History = new HashSet<History>();
            this.Journal = new HashSet<Journal>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdNameGroup { get; set; }
        public int IdSpecial { get; set; }
        public int IdYearAdd { get; set; }
        public int IdFormTime { get; set; }
    
        public virtual FormTime FormTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Journal> Journal { get; set; }
        public virtual NameGroup NameGroup { get; set; }
        public virtual Special Special { get; set; }
        public virtual YearAdd YearAdd { get; set; }
    }
}
