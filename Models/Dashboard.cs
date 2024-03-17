namespace lifedashboard.Models
{
    public class Dashboard
    {
        public string? TotalMember { get; set; }
        public string? TotalRevenue { get; set; }
        public string? RevenueCurrentYear { get; set; }
        public string? RevenueCurrentMonth { get; set; }
        public string? MemberVisitedCurrentMonth { get; set; }
        public string? MemberVisitedToday { get; set; }
        public string? NewAdmissionCurrentMonth { get; set; }

        public string? RevenueCurrentDay { get; set; }
    }
}
