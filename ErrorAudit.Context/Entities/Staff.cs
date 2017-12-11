namespace ErrorAudit.Context.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initial { get; set; }
        public Nullable<int> OrganizationId { get; set; }
    }
}
