﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SignalRExample.Data;

namespace SignalRExample.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20220928092054_PresentorPivotRow")]
    partial class PresentorPivotRow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "en_US.utf8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SignalRExample.Data.Br", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BrType")
                        .HasColumnType("integer");

                    b.Property<long>("OrgSid")
                        .HasColumnType("bigint");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Brs");
                });

            modelBuilder.Entity("SignalRExample.Data.BrSumRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ApproveDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("BrId")
                        .HasColumnType("bigint");

                    b.Property<long>("DocumentId")
                        .HasColumnType("bigint");

                    b.Property<long>("Generation")
                        .HasColumnType("bigint");

                    b.Property<int?>("OrderBy")
                        .HasColumnType("integer");

                    b.Property<decimal>("SmBa1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmPof")
                        .HasColumnType("numeric");

                    b.Property<long>("StructRowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SysChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("XmlInfo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "BrId" }, "IX_BrSumRows_BrId");

                    b.HasIndex(new[] { "StructRowId" }, "IX_BrSumRows_StructRowId");

                    b.ToTable("BrSumRows");
                });

            modelBuilder.Entity("SignalRExample.Data.DocRad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BossFio")
                        .HasColumnType("text");

                    b.Property<string>("BossStat")
                        .HasColumnType("text");

                    b.Property<string>("Descr")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DocDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DocNum")
                        .HasColumnType("text");

                    b.Property<string>("ExecuterFio")
                        .HasColumnType("text");

                    b.Property<string>("ExecuterPhone")
                        .HasColumnType("text");

                    b.Property<string>("ExecuterStat")
                        .HasColumnType("text");

                    b.Property<long?>("Generation")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LawDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LawNumber")
                        .HasColumnType("text");

                    b.Property<long?>("Orgid")
                        .HasColumnType("bigint")
                        .HasColumnName("orgid");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("SysChangeDate")
                        .HasColumnType("date")
                        .HasColumnName("sys_change_date");

                    b.Property<long?>("UserSid")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("DocRads");
                });

            modelBuilder.Entity("SignalRExample.Data.DocRadRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AdbInn")
                        .HasColumnType("text");

                    b.Property<string>("AdbKpp")
                        .HasColumnType("text");

                    b.Property<string>("AdbName")
                        .HasColumnType("text");

                    b.Property<long>("DocRadId")
                        .HasColumnType("bigint");

                    b.Property<string>("KbkCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LawDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LawLegalName")
                        .HasColumnType("text");

                    b.Property<string>("LawNumber")
                        .HasColumnType("text");

                    b.Property<DateTime?>("OndateKbk")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("RadId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("TodateKbk")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DocRadId" }, "IX_DocRadRows_DocRadId");

                    b.ToTable("DocRadRow");
                });

            modelBuilder.Entity("SignalRExample.Data.KuDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ApproveDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("BrSid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DocNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DocStatus")
                        .HasColumnType("text");

                    b.Property<string>("DocStatusName")
                        .HasColumnType("text");

                    b.Property<bool>("IsFirstDistribution")
                        .HasColumnType("boolean");

                    b.Property<long>("OrgSid")
                        .HasColumnType("bigint");

                    b.Property<long>("TopBrRowSid")
                        .HasColumnType("bigint");

                    b.Property<string>("TopFullSprKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserSid")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("KuDetails");
                });

            modelBuilder.Entity("SignalRExample.Data.KuDetailRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("DocId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullSprKey")
                        .HasColumnType("text");

                    b.Property<long?>("Generation")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("Sid")
                        .HasColumnType("bigint")
                        .HasColumnName("SID");

                    b.Property<decimal>("SmBa1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmPof")
                        .HasColumnType("numeric");

                    b.Property<long?>("SprId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("0");

                    b.Property<long?>("StructRowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("SysChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DocId" }, "IX_KuDetailRows_DocId");

                    b.ToTable("KuDetailRows");
                });

            modelBuilder.Entity("SignalRExample.Data.PresentorPivotRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Csr")
                        .HasColumnType("text");

                    b.Property<long>("DocSid")
                        .HasColumnType("bigint");

                    b.Property<string>("FaipCode")
                        .HasColumnType("text");

                    b.Property<string>("Kosgu")
                        .HasColumnType("text");

                    b.Property<string>("Nr")
                        .HasColumnType("text");

                    b.Property<string>("NrCaption")
                        .HasColumnType("text");

                    b.Property<string>("NrTo")
                        .HasColumnType("text");

                    b.Property<string>("Ou")
                        .HasColumnType("text");

                    b.Property<string>("OuCaption")
                        .HasColumnType("text");

                    b.Property<string>("PbsCode")
                        .HasColumnType("text");

                    b.Property<string>("PbsName")
                        .HasColumnType("text");

                    b.Property<string>("PbsSort")
                        .HasColumnType("text");

                    b.Property<string>("RzPrz")
                        .HasColumnType("text");

                    b.Property<DateTime>("SumDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SumMesureName")
                        .HasColumnType("text");

                    b.Property<string>("SumMesureSort")
                        .HasColumnType("text");

                    b.Property<string>("SumPartType")
                        .HasColumnType("text");

                    b.Property<string>("UnderNr")
                        .HasColumnType("text");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.Property<string>("Vr")
                        .HasColumnType("text");

                    b.Property<int>("YearNum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PresentorPivotRows");
                });

            modelBuilder.Entity("SignalRExample.Data.SprKbkIncome", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("OnDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("SprKbkIncomes");
                });

            modelBuilder.Entity("SignalRExample.Data.SprRad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Inn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Kbk")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Kpp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("OldId")
                        .HasColumnType("bigint")
                        .HasColumnName("old_id");

                    b.Property<DateTime>("OnDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("SprKbkIncomeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SprKbkIncomeId" }, "IX_SprRads_SprKbkIncomeId");

                    b.ToTable("SprRads");
                });

            modelBuilder.Entity("SignalRExample.Data.StructRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("BrId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullSprKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValueSql("''::text");

                    b.Property<DateTime?>("OnDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("ParentRowId")
                        .HasColumnType("bigint");

                    b.Property<long>("SprId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("SysChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("XmlInfo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "BrId" }, "IX_StructRows_BrId");

                    b.HasIndex(new[] { "ParentRowId" }, "IX_StructRows_ParentRowId");

                    b.ToTable("StructRows");
                });

            modelBuilder.Entity("SignalRExample.Data.ToPb", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ApproveDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("BrSid")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descr")
                        .HasColumnType("text");

                    b.Property<string>("DocNum")
                        .HasColumnType("text");

                    b.Property<string>("DocStatus")
                        .HasColumnType("text");

                    b.Property<string>("DocStatus1")
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("DOC_STATUS");

                    b.Property<string>("DocStatusName")
                        .HasColumnType("text");

                    b.Property<string>("HasFaip")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("HAS_FAIP");

                    b.Property<bool?>("IsFirstDistribution")
                        .HasColumnType("boolean");

                    b.Property<long?>("OrgSid")
                        .HasColumnType("bigint");

                    b.Property<long?>("TopBrRowSid")
                        .HasColumnType("bigint");

                    b.Property<string>("TopFullSprKey")
                        .HasColumnType("text");

                    b.Property<long?>("UserSid")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ToPbs");
                });

            modelBuilder.Entity("SignalRExample.Data.ToPbsRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descr")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("DESCR");

                    b.Property<long?>("DocId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullSprKey")
                        .HasColumnType("text");

                    b.Property<long?>("Generation")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("SmBa1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmPof")
                        .HasColumnType("numeric");

                    b.Property<long?>("SprId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StructRowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("SysChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ToPbsRows");
                });

            modelBuilder.Entity("SignalRExample.Data.ToRezerv", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ApproveDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("BrSid")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateDt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descr")
                        .HasColumnType("text");

                    b.Property<string>("DocNum")
                        .HasColumnType("text");

                    b.Property<string>("DocStatus")
                        .HasColumnType("text");

                    b.Property<string>("DocStatusName")
                        .HasColumnType("text");

                    b.Property<bool?>("IsFirstDistribution")
                        .HasColumnType("boolean");

                    b.Property<long?>("OrgSid")
                        .HasColumnType("bigint");

                    b.Property<long?>("TopBrRowSid")
                        .HasColumnType("bigint");

                    b.Property<string>("TopFullSprKey")
                        .HasColumnType("text");

                    b.Property<long?>("UserSid")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ToRezerv");
                });

            modelBuilder.Entity("SignalRExample.Data.ToRezervRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("DocId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullSprKey")
                        .HasColumnType("text");

                    b.Property<long?>("Generation")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("SmBa1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmBa3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmLbo3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SmPof")
                        .HasColumnType("numeric");

                    b.Property<long?>("SprId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StructRowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("SysChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ToRezervRows");
                });

            modelBuilder.Entity("SignalRExample.Data.BrSumRow", b =>
                {
                    b.HasOne("SignalRExample.Data.Br", "Br")
                        .WithMany("BrSumRows")
                        .HasForeignKey("BrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SignalRExample.Data.StructRow", "StructRow")
                        .WithMany("BrSumRows")
                        .HasForeignKey("StructRowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Br");

                    b.Navigation("StructRow");
                });

            modelBuilder.Entity("SignalRExample.Data.DocRadRow", b =>
                {
                    b.HasOne("SignalRExample.Data.DocRad", "DocRad")
                        .WithMany("DocRadRows")
                        .HasForeignKey("DocRadId")
                        .IsRequired();

                    b.Navigation("DocRad");
                });

            modelBuilder.Entity("SignalRExample.Data.KuDetailRow", b =>
                {
                    b.HasOne("SignalRExample.Data.KuDetail", "Doc")
                        .WithMany("KuDetailRows")
                        .HasForeignKey("DocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doc");
                });

            modelBuilder.Entity("SignalRExample.Data.SprRad", b =>
                {
                    b.HasOne("SignalRExample.Data.SprKbkIncome", "SprKbkIncome")
                        .WithMany("SprRads")
                        .HasForeignKey("SprKbkIncomeId");

                    b.Navigation("SprKbkIncome");
                });

            modelBuilder.Entity("SignalRExample.Data.StructRow", b =>
                {
                    b.HasOne("SignalRExample.Data.Br", "Br")
                        .WithMany("StructRows")
                        .HasForeignKey("BrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SignalRExample.Data.StructRow", "ParentRow")
                        .WithMany("InverseParentRow")
                        .HasForeignKey("ParentRowId");

                    b.Navigation("Br");

                    b.Navigation("ParentRow");
                });

            modelBuilder.Entity("SignalRExample.Data.Br", b =>
                {
                    b.Navigation("BrSumRows");

                    b.Navigation("StructRows");
                });

            modelBuilder.Entity("SignalRExample.Data.DocRad", b =>
                {
                    b.Navigation("DocRadRows");
                });

            modelBuilder.Entity("SignalRExample.Data.KuDetail", b =>
                {
                    b.Navigation("KuDetailRows");
                });

            modelBuilder.Entity("SignalRExample.Data.SprKbkIncome", b =>
                {
                    b.Navigation("SprRads");
                });

            modelBuilder.Entity("SignalRExample.Data.StructRow", b =>
                {
                    b.Navigation("BrSumRows");

                    b.Navigation("InverseParentRow");
                });
#pragma warning restore 612, 618
        }
    }
}
