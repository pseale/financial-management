﻿// <auto-generated />
using System;
using FinanMan.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanMan.Database.Migrations.Migrations
{
    [DbContext(typeof(FinanManContext))]
    [Migration("20230116184623_AddBoolFieldToAccountType")]
    partial class AddBoolFieldToAccountType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("Name");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DepositReasonId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepositReasonId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuAccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IncreaseOnPayment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            IncreaseOnPayment = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Checking",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            IncreaseOnPayment = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Savings",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            IncreaseOnPayment = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Credit Card",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            IncreaseOnPayment = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cash",
                            SortOrder = 4
                        });
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Grocery Store",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "General Goods",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fast Food",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Restaraunt",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Streaming Serivce",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 6,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Apothecary",
                            SortOrder = 6
                        },
                        new
                        {
                            Id = 7,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Clothing",
                            SortOrder = 7
                        });
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuDepositReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("DepositReasons");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuLineItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("LineItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sub Total",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tax",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fee",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Surcharge",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Shipping",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 6,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tip",
                            SortOrder = 6
                        },
                        new
                        {
                            Id = 7,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Refund",
                            SortOrder = 7
                        },
                        new
                        {
                            Id = 8,
                            Deleted = false,
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Discount",
                            SortOrder = 8
                        });
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuRecurrenceType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("RecurrenceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            DisplayText = "One-time",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "OneTime",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            DisplayText = "Daily",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Daily",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            DisplayText = "Weekly",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Weekly",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            DisplayText = "Bi-weekly",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "BiWeekly",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            Deleted = false,
                            DisplayText = "Monthly",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monthly",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 6,
                            Deleted = false,
                            DisplayText = "Bi-monthly",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "BiMonthly",
                            SortOrder = 6
                        },
                        new
                        {
                            Id = 7,
                            Deleted = false,
                            DisplayText = "Quarterly",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Quarterly",
                            SortOrder = 7
                        },
                        new
                        {
                            Id = 8,
                            Deleted = false,
                            DisplayText = "Semi-annually",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "SemiAnnually",
                            SortOrder = 8
                        },
                        new
                        {
                            Id = 9,
                            Deleted = false,
                            DisplayText = "Annually",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Annually",
                            SortOrder = 9
                        },
                        new
                        {
                            Id = 10,
                            Deleted = false,
                            DisplayText = "Custom...",
                            LastUpdated = new DateTime(2022, 7, 25, 17, 41, 0, 0, DateTimeKind.Unspecified),
                            Name = "Custom",
                            SortOrder = 10
                        });
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Payee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Payees");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PayeeId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PayeeId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.PaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Detail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("LineItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LineItemTypeId");

                    b.HasIndex("PaymentId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.ScheduledTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("DayNum")
                        .HasColumnType("int");

                    b.Property<string>("Memo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayeeId")
                        .HasColumnType("int");

                    b.Property<int>("RecurrenceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PayeeId");

                    b.HasIndex("RecurrenceTypeId");

                    b.ToTable("ScheduledTransactions");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("PostingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PurgeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TargetAccountId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TargetAccountId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("LuCategoryPayee", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("PayeesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "PayeesId");

                    b.HasIndex("PayeesId");

                    b.ToTable("LuCategoryPayee");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Account", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.LuAccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Deposit", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.LuDepositReason", "DepositReason")
                        .WithMany("Deposits")
                        .HasForeignKey("DepositReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Transaction", "Transaction")
                        .WithOne("Deposit")
                        .HasForeignKey("FinanMan.Database.Models.Tables.Deposit", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepositReason");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Payment", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.Payee", "Payee")
                        .WithMany("Payments")
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Transaction", "Transaction")
                        .WithOne("Payment")
                        .HasForeignKey("FinanMan.Database.Models.Tables.Payment", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payee");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.PaymentDetail", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.LuLineItemType", "LineItemType")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("LineItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Payment", "Payment")
                        .WithMany("PaymentDetails")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LineItemType");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.ScheduledTransaction", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.Account", "Account")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Payee", "Payee")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.LuRecurrenceType", "RecurrenceType")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("RecurrenceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Payee");

                    b.Navigation("RecurrenceType");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Transaction", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Transfer", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.Account", "TargetAccount")
                        .WithMany("Transfers")
                        .HasForeignKey("TargetAccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Transaction", "Transaction")
                        .WithOne("Transfer")
                        .HasForeignKey("FinanMan.Database.Models.Tables.Transfer", "TransactionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("TargetAccount");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("LuCategoryPayee", b =>
                {
                    b.HasOne("FinanMan.Database.Models.Tables.LuCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanMan.Database.Models.Tables.Payee", null)
                        .WithMany()
                        .HasForeignKey("PayeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Account", b =>
                {
                    b.Navigation("ScheduledTransactions");

                    b.Navigation("Transactions");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuDepositReason", b =>
                {
                    b.Navigation("Deposits");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuLineItemType", b =>
                {
                    b.Navigation("TransactionDetails");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.LuRecurrenceType", b =>
                {
                    b.Navigation("ScheduledTransactions");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Payee", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("ScheduledTransactions");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Payment", b =>
                {
                    b.Navigation("PaymentDetails");
                });

            modelBuilder.Entity("FinanMan.Database.Models.Tables.Transaction", b =>
                {
                    b.Navigation("Deposit");

                    b.Navigation("Payment");

                    b.Navigation("Transfer");
                });
#pragma warning restore 612, 618
        }
    }
}
