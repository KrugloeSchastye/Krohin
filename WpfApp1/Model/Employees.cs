//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.RegistrationZakaza = new HashSet<RegistrationZakaza>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> BirthdayDate { get; set; }
        public Nullable<int> Restaurant { get; set; }
        public Nullable<int> IdRole { get; set; }
        public Nullable<int> SumZakazov { get; set; }
        public Nullable<int> Premia { get; set; }
        public Nullable<int> VxodId { get; set; }
    
        public virtual Restaurants Restaurants { get; set; }
        public virtual Roles Roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationZakaza> RegistrationZakaza { get; set; }
        public virtual Vxod Vxod { get; set; }
    }
}