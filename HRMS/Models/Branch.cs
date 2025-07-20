using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models;

public enum BranchStatusEnum
{
    Active = 1,
    InActive = 0
}

public class Branch
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BranchId { get; set; }

    [MaxLength(100)]
    public string? BranchName { get; set; }

    [MaxLength(150)]
    public string? BranchEmailAddress { get; set; }

    [MaxLength(200)]
    public string? BranchAddress { get; set; }

    [MaxLength(20)]
    public string? ContactNo { get; set; }

    [MaxLength(20)]
    public string? LandlineNo { get; set; }

    [MaxLength(20)]
    public string? FaxNo { get; set; }

    [MaxLength(50)]
    public string? City { get; set; }

    [MaxLength(10)]
    public string? BranchCityCode { get; set; }

    [MaxLength(20)]
    public string? BranchPostalCode { get; set; }

    [MaxLength(50)]
    public string? BranchLabourFileno { get; set; }

    [MaxLength(100)]
    public string? BranchAreaManager { get; set; }

    [MaxLength(100)]
    public string? BranchManager { get; set; }

    [MaxLength(100)]
    public string? BranchAssistantManager { get; set; }

    [MaxLength(100)]
    public string? CreatedBy { get; set; }

    public BranchStatusEnum BranchStatus { get; set; } = BranchStatusEnum.Active;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
