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
    
    public partial class GiftSertificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiftSertificate()
        {
            this.RegistrationZakaza = new HashSet<RegistrationZakaza>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Nominal { get; set; }
        public string Status { get; set; }
        public Nullable<int> SumZakaza { get; set; }
        public Nullable<int> UnusedNominal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationZakaza> RegistrationZakaza { get; set; }
    }
}
