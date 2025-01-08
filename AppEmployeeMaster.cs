using System;
using System.Collections.Generic;

namespace GFAS.Models
{
    public partial class AppEmployeeMaster
    {
        public Guid Id { get; set; }
        public string Pno { get; set; } = null!;
        public string? Ename { get; set; }
        public string? OffDay1 { get; set; }
        public string? OffDay2 { get; set; }
        public bool? SaturdayHalf { get; set; }
        public bool? ShiftDuty { get; set; }
        public bool? ManualEntry { get; set; }
        public bool? Suspention { get; set; }
        public DateTime? SuspentionFromDate { get; set; }
        public DateTime? SuspentionTodate { get; set; }
        public bool? PaidOnSuspention { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? DivisionName { get; set; }
        public string? DepartmentName { get; set; }
        public string? SectionName { get; set; }
        public DateTime? ManualFromDate { get; set; }
        public DateTime? ManualToDate { get; set; }
        public string? Location { get; set; }
        public decimal? Intime { get; set; }
        public decimal? Outtime { get; set; }
        public string? Shift { get; set; }
        public bool? Discharge { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string? EmailId { get; set; }
        public string? Phone { get; set; }
        public string? Designation { get; set; }
        public DateTime? Dob { get; set; }
        public string? ReportingPno { get; set; }
        public string? Level { get; set; }
        public string? CostCenter { get; set; }
        public DateTime? DateOfEmpl { get; set; }
        public string? Bg { get; set; }
        public string? Gender { get; set; }
        public DateTime? ContinuityOfService { get; set; }
    }
}
