//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorAudit.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorEntry
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int StaffId { get; set; }
        public int ErrorId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CompletedStaffId { get; set; }
        public Nullable<int> OutcomeId { get; set; }
    }
}