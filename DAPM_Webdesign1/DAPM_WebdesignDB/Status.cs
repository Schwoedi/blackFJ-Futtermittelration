using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Todo_listShared;

[Table("Status")]
public partial class Status
{
    [Key]
    public long StatusId { get; set; }

    public string Name { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Status")]
    public virtual TodoList StatusNavigation { get; set; } = null!;
}
