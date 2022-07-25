﻿using FinanMan.Database.Data;
using FinanMan.Database.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace FinanMan.Database;

public class FinanManContext : DbContext
{
    public FinanManContext(DbContextOptions<FinanManContext> options) : base(options) { }

    protected FinanManContext() { }

    // TODO: Take a look at the syntax: 
    //   public DbSet<Account> Accounts => Set<Account>();
    //   and compare it to the approach below
    #region Tables
    public virtual DbSet<Account> Accounts { get; set; } = default!;
    public virtual DbSet<Payee> Payees { get; set; } = default!;
    public virtual DbSet<ScheduledTransaction> ScheduledTransactions { get; set; } = default!;
    public virtual DbSet<Transaction> Transactions { get; set; } = default!;
    public virtual DbSet<TransactionDetail> TransactionDetails { get; set; } = default!;
    public virtual DbSet<Transfer> Transfers { get; set; } = default!;

    #region Lookups
    public virtual DbSet<LuAccountType> AccountTypes { get; set; } = default!;
    public virtual DbSet<LuCategory> Categories { get; set; } = default!;
    public virtual DbSet<LuLineItemType> LineItemTypes { get; set; } = default!;
    public virtual DbSet<LuRecurrenceType> RecurrenceTypes { get; set; } = default!;
    #endregion Lookups
    #endregion Tables

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Account>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .IsRequired();

            entity.HasIndex(e => e.Name);
        });
        
        modelBuilder.Entity<LuAccountType>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsRequired();

            entity.HasIndex(e => e.Name);
        });
        
        modelBuilder.Entity<LuCategory>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsRequired();

            entity.HasIndex(e => e.Name);
        });
        
        modelBuilder.Entity<LuRecurrenceType>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsRequired();
            
            entity.Property(e => e.DisplayText)
                .HasMaxLength(20)
                .IsRequired();

            entity.HasIndex(e => e.Name);
        });

        modelBuilder.Entity<Payee>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .IsRequired();

            entity.HasIndex(e => e.Name);
        });
        
        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.Property(e => e.Memo)
                .HasMaxLength(255)
                .IsRequired();
        });
        
        modelBuilder.Entity<TransactionDetail>(entity =>
        {
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsRequired();
        });

        modelBuilder.Seed();
    }
}