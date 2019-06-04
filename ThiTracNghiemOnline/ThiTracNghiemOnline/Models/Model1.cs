namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<BAI_THI> BAI_THI { get; set; }
        public virtual DbSet<CAU_HOI> CAU_HOI { get; set; }
        public virtual DbSet<CHI_TIET_BT> CHI_TIET_BT { get; set; }
        public virtual DbSet<DE_THI> DE_THI { get; set; }
        public virtual DbSet<DIA_CHI> DIA_CHI { get; set; }
        public virtual DbSet<GIAO_VIEN> GIAO_VIEN { get; set; }
        public virtual DbSet<HOC_SINH> HOC_SINH { get; set; }
        public virtual DbSet<KHOI> KHOIs { get; set; }
        public virtual DbSet<LOAI_DC> LOAI_DC { get; set; }
        public virtual DbSet<LOAI_DE_THI> LOAI_DE_THI { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<LOP_HOC> LOP_HOC { get; set; }
        public virtual DbSet<LUA_CHON> LUA_CHON { get; set; }
        public virtual DbSet<MON_HOC> MON_HOC { get; set; }
        public virtual DbSet<PHAN_CONG_DAY> PHAN_CONG_DAY { get; set; }
        public virtual DbSet<PHUONG_XA> PHUONG_XA { get; set; }
        public virtual DbSet<QUAN_HUYEN> QUAN_HUYEN { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<TINH_TP> TINH_TP { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<USER_GROUP> USER_GROUP { get; set; }
        public virtual DbSet<DiaChiH> DiaChiHS { get; set; }
        public virtual DbSet<DSDeThi> DSDeThis { get; set; }
        public virtual DbSet<DSLuaChonCuaBaiThi> DSLuaChonCuaBaiThis { get; set; }
        public virtual DbSet<DSLuaChonCuaDeThi> DSLuaChonCuaDeThis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAI_THI>()
                .HasMany(e => e.CHI_TIET_BT)
                .WithRequired(e => e.BAI_THI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAU_HOI>()
                .HasMany(e => e.CHI_TIET_BT)
                .WithRequired(e => e.CAU_HOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAU_HOI>()
                .HasMany(e => e.DE_THI)
                .WithMany(e => e.CAU_HOI)
                .Map(m => m.ToTable("CHI_TIET_DE_THI").MapLeftKey("MA_CH").MapRightKey("MA_DT"));

            modelBuilder.Entity<DE_THI>()
                .HasMany(e => e.LOP_HOC)
                .WithMany(e => e.DE_THI)
                .Map(m => m.ToTable("DE_THI_CUA_LOP").MapLeftKey("MA_DT").MapRightKey("MA_LOP_HOC"));

            modelBuilder.Entity<DIA_CHI>()
                .Property(e => e.MA_PHUONG_XA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAO_VIEN>()
                .HasMany(e => e.PHAN_CONG_DAY)
                .WithRequired(e => e.GIAO_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP_HOC>()
                .HasMany(e => e.PHAN_CONG_DAY)
                .WithRequired(e => e.LOP_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MON_HOC>()
                .HasMany(e => e.PHAN_CONG_DAY)
                .WithRequired(e => e.MON_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHUONG_XA>()
                .Property(e => e.MA_PHUONG_XA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHUONG_XA>()
                .Property(e => e.MA_QUAN_HUYEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUAN_HUYEN>()
                .Property(e => e.MA_QUAN_HUYEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUAN_HUYEN>()
                .Property(e => e.MA_TINH_TP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.USER_GROUP)
                .WithMany(e => e.ROLEs)
                .Map(m => m.ToTable("PHAN_QUYEN").MapLeftKey("ROLE_ID").MapRightKey("GROUP_ID"));

            modelBuilder.Entity<TINH_TP>()
                .Property(e => e.MA_TINH_TP)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
