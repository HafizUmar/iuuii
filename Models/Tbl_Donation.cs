//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BCharityTHeme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Donation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Donation()
        {
            this.Tbl_PayPalPayment = new HashSet<Tbl_PayPalPayment>();
        }
    
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public string ItemName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailID { get; set; }
        public string Purpose { get; set; }
        public string Type { get; set; }
        public string C_Address { get; set; }
        public string C_City { get; set; }
        public string Status { get; set; }
        public string C_country { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_PayPalPayment> Tbl_PayPalPayment { get; set; }
    }
}
