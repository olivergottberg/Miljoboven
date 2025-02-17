using System.ComponentModel.DataAnnotations;

namespace Miljöboven.Models;

public class ErrandStatus
{
    [Key]
    public string StatusID { get; set; }
    public string StatusName { get; set; }
}