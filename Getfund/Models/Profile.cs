//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Getfund.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public Nullable<int> ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> NID { get; set; }
        public string ProfilePicture { get; set; }
    
        public virtual GUser GUser { get; set; }
    }
}
