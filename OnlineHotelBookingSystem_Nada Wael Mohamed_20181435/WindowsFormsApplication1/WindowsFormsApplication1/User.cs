//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Customer_Service_Team = new HashSet<Customer_Service_Team>();
        }
    
        public int User_Id { get; set; }
        public string FirstName { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Hotal_Name { get; set; }
        public string Lastname { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual SignUp SignUp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Service_Team> Customer_Service_Team { get; set; }
    }
}
