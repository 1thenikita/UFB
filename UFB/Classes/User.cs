//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UFB.Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int ID_Role { get; set; }
        public bool Password_Change { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Note { get; set; }
        public System.DateTime DT_Entrance { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual Role Role { get; set; }
    }
}