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
    
    public partial class Transaction
    {
        public int ID_transaction { get; set; }
        public string type_of_currency { get; set; }
        public string type_of_transaction { get; set; }
        public int amount_of_transaction { get; set; }
        public System.DateTime date_time_of_transaction { get; set; }
        public Nullable<int> data_of_sender { get; set; }
        public Nullable<int> data_of_reciever { get; set; }
    
        public virtual Reciever Reciever { get; set; }
        public virtual Sender Sender { get; set; }
    }
}