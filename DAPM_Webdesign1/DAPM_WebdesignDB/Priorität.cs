using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Todo_listShared;

[Table("Priorität")]
public partial class Priorität
{
    [Key]
    public long PriorId { get; set; }

    [Column(TypeName = "NUMERIC")]
    public byte[] Name { get; set; } = null!;

    [ForeignKey("PriorId")]
    [InverseProperty("Priorität")]
    public virtual TodoList Prior { get; set; } = null!;
}
