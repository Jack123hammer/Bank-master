//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank_account_number
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bank_account_number()
        {
            this.Reciever = new HashSet<Reciever>();
            this.Sender = new HashSet<Sender>();
        }
    
        public int ID_Score { get; set; }
        public Nullable<int> type_of_agreement { get; set; }
        public Nullable<int> id_account { get; set; }
        public Nullable<int> amount { get; set; }
        public string type_of_currency { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual List_of_types_of_agreements List_of_types_of_agreements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reciever> Reciever { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sender> Sender { get; set; }
    }
}
