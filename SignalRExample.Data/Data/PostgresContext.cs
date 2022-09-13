using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SignalRExample.Data
{
    public partial class PostgresContext : DbContext
    {
        public PostgresContext()
        {
        }

        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Br> Brs { get; set; }
        public virtual DbSet<BrSumRow> BrSumRows { get; set; }
        public virtual DbSet<DocRad> DocRads { get; set; }
        public virtual DbSet<KuDetail> KuDetails { get; set; }
        public virtual DbSet<KuDetailRow> KuDetailRows { get; set; }
        public virtual DbSet<SprKbkIncome> SprKbkIncomes { get; set; }
        public virtual DbSet<SprRad> SprRads { get; set; }
        public virtual DbSet<StructRow> StructRows { get; set; }
        public virtual DbSet<ToPb> ToPbs { get; set; }
        public virtual DbSet<ToPbsRow> ToPbsRows { get; set; }
        public virtual DbSet<ToRezerv> ToRezervs { get; set; }
        public virtual DbSet<ToRezervRow> ToRezervRows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<BrSumRow>(entity =>
            {
                entity.HasIndex(e => e.BrId, "IX_BrSumRows_BrId");

                entity.HasIndex(e => e.StructRowId, "IX_BrSumRows_StructRowId");

                entity.Property(e => e.ApproveDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.SysChangeDate).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Br)
                    .WithMany(p => p.BrSumRows)
                    .HasForeignKey(d => d.BrId);

                entity.HasOne(d => d.StructRow)
                    .WithMany(p => p.BrSumRows)
                    .HasForeignKey(d => d.StructRowId);
            });

            modelBuilder.Entity<DocRad>(entity =>
            {
                entity.Property(e => e.DocDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LawDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Orgid).HasColumnName("orgid");

                entity.Property(e => e.SysChangeDate)
                    .HasColumnType("date")
                    .HasColumnName("sys_change_date");
            });

            modelBuilder.Entity<DocRadRow>(entity =>
            {
                entity.HasIndex(e => e.DocRadId, "IX_DocRadRows_DocRadId");

                entity.Property(e => e.LawDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.OndateKbk).HasColumnType("timestamp with time zone");

                entity.Property(e => e.TodateKbk).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.DocRad)
                    .WithMany(p => p.DocRadRows)
                    .HasForeignKey(d => d.DocRadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<KuDetail>(entity =>
            {
                entity.Property(e => e.ApproveDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreateDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Descr).IsRequired();

                entity.Property(e => e.DocNum).IsRequired();

                entity.Property(e => e.TopFullSprKey).IsRequired();
            });

            modelBuilder.Entity<KuDetailRow>(entity =>
            {
                entity.HasIndex(e => e.DocId, "IX_KuDetailRows_DocId");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.SprId).HasDefaultValueSql("0");

                entity.Property(e => e.SysChangeDate).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.KuDetailRows)
                    .HasForeignKey(d => d.DocId);
            });

            modelBuilder.Entity<SprKbkIncome>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.OnDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.ToDate).HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<SprRad>(entity =>
            {
                entity.HasIndex(e => e.SprKbkIncomeId, "IX_SprRads_SprKbkIncomeId");

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.Inn).IsRequired();

                entity.Property(e => e.Kbk).IsRequired();

                entity.Property(e => e.Kpp).IsRequired();

                entity.Property(e => e.OldId).HasColumnName("old_id");

                entity.Property(e => e.OnDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.ToDate).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.SprKbkIncome)
                    .WithMany(p => p.SprRads)
                    .HasForeignKey(d => d.SprKbkIncomeId);
            });

            modelBuilder.Entity<StructRow>(entity =>
            {
                entity.HasIndex(e => e.BrId, "IX_StructRows_BrId");

                entity.HasIndex(e => e.ParentRowId, "IX_StructRows_ParentRowId");

                entity.Property(e => e.FullSprKey).HasDefaultValueSql("''::text");

                entity.Property(e => e.OnDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.SysChangeDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.ToDate).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Br)
                    .WithMany(p => p.StructRows)
                    .HasForeignKey(d => d.BrId);

                entity.HasOne(d => d.ParentRow)
                    .WithMany(p => p.InverseParentRow)
                    .HasForeignKey(d => d.ParentRowId);
            });

            modelBuilder.Entity<ToPb>(entity =>
            {
                entity.Property(e => e.ApproveDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreateDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.DocStatus1)
                    .HasMaxLength(8)
                    .HasColumnName("DOC_STATUS");

                entity.Property(e => e.HasFaip)
                    .HasMaxLength(1)
                    .HasColumnName("HAS_FAIP");
            });

            modelBuilder.Entity<ToPbsRow>(entity =>
            {
                entity.Property(e => e.Descr)
                    .HasMaxLength(1)
                    .HasColumnName("DESCR");

                entity.Property(e => e.SysChangeDate).HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<ToRezerv>(entity =>
            {
                entity.ToTable("ToRezerv");

                entity.Property(e => e.ApproveDt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreateDt).HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<ToRezervRow>(entity =>
            {
                entity.Property(e => e.SysChangeDate).HasColumnType("timestamp with time zone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
