
namespace ErrorAudit.Context.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorEntry
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CompletedStaffId { get; set; }
        public Nullable<int> OutcomeId { get; set; }
        public int ProcessingStaffEnter { get; set; }
        public int ProcessingStaffDispensing { get; set; }
        public int ProcessingStaffChecked { get; set; }
        public int NoticedStaffEnter { get; set; }
        public int NoticedStaffDispensing { get; set; }
        public int NoticedStaffChecked { get; set; }
        public string ScriptNumber { get; set; }
    }
}
