using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Todo_listShared;

[Table("TodoList")]
public partial class TodoList
{
    public string Kurzbeschreibung { get; set; } = null!;

    public string Beschreibung { get; set; } = null!;

    public string ErstelltAm { get; set; } = null!;

    public string Fälligkeitsdatum { get; set; } = null!;

    [Key]
    public long TodoId { get; set; }

    [InverseProperty("Prior")]
    public virtual Priorität? Priorität { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual Status? Status { get; set; }
}
