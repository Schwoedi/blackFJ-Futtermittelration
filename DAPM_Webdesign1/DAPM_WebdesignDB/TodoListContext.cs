using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Todo_listShared;

public partial class TodoListContext : DbContext
{
    public TodoListContext()
    {
    }

    public TodoListContext(DbContextOptions<TodoListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Priorität> Prioritäts { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TodoList> TodoLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=db/Todo_list.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Priorität>(entity =>
        {
            entity.Property(e => e.PriorId).ValueGeneratedNever();

            entity.HasOne(d => d.Prior).WithOne(p => p.Priorität).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.Property(e => e.StatusId).ValueGeneratedNever();

            entity.HasOne(d => d.StatusNavigation).WithOne(p => p.Status).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TodoList>(entity =>
        {
            entity.Property(e => e.TodoId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
