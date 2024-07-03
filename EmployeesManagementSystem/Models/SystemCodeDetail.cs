namespace EmployeesManagementSystem.Models
{
    public class SystemCodeDetail:UserActivity
    {
        public int Id { get; set; }
        public int SystemCodeId { get; set; }
        public SystemCode SystemCode { get; set; }
        public string code { get; set; }
        public string Description { get; set; }
        public int? OrderNo { get; set; }
    }
}
