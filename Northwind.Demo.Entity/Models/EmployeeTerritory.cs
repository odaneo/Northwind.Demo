namespace Northwind.Demo.Entity.Models
{
    public partial class EmployeeTerritory
    {
        public short EmployeeId { get; set; }
        public string TerritoryId { get; set; } = null!;
        public virtual Employee Employees { get; set; } = null!;
        public virtual Territory Territories { get; set; } = null!;
    }
}
