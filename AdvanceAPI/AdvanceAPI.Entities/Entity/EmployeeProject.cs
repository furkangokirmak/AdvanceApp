﻿namespace AdvanceAPI.Entities.Entity
{
    public class EmployeeProject : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
