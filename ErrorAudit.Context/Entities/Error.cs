namespace ErrorAudit.Context.Entities
{
    using System;
    using System.Collections.Generic;
    
    public class Error
    {
        public int Id { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorCode { get; set; }
        public Nullable<int> ErrorTypeId { get; set; }
    }
}
