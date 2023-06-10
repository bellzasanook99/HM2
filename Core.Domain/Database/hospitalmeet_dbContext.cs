using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Core.Domain.Database
{
    public partial class hospitalmeet_dbContext : DbContext
    {
        public hospitalmeet_dbContext()
        {
        }

        public hospitalmeet_dbContext(DbContextOptions<hospitalmeet_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountAlbum> AccountAlbums { get; set; }
        public virtual DbSet<MtbLanguage> MtbLanguages { get; set; }
        public virtual DbSet<MtbPageType> MtbPageTypes { get; set; }
        public virtual DbSet<TblAccount> TblAccounts { get; set; }
        public virtual DbSet<TblAccountAlbum> TblAccountAlbums { get; set; }
        public virtual DbSet<TblAccountBlogGay> TblAccountBlogGays { get; set; }
        public virtual DbSet<TblAccountCert> TblAccountCerts { get; set; }
        public virtual DbSet<TblAccountCover> TblAccountCovers { get; set; }
        public virtual DbSet<TblAccountDesc> TblAccountDescs { get; set; }
        public virtual DbSet<TblAccountExp> TblAccountExps { get; set; }
        public virtual DbSet<TblAccountGallery> TblAccountGalleries { get; set; }
        public virtual DbSet<TblAccountInfo> TblAccountInfos { get; set; }
        public virtual DbSet<TblAccountNetwork> TblAccountNetworks { get; set; }
        public virtual DbSet<TblAccountProfile> TblAccountProfiles { get; set; }
        public virtual DbSet<TblAccountReview> TblAccountReviews { get; set; }
        public virtual DbSet<TblAccountService> TblAccountServices { get; set; }
        public virtual DbSet<TblAccountTitle> TblAccountTitles { get; set; }
        public virtual DbSet<TblAccountWeek> TblAccountWeeks { get; set; }
        public virtual DbSet<TblAmphure> TblAmphures { get; set; }
        public virtual DbSet<TblBlogMsg> TblBlogMsgs { get; set; }
        public virtual DbSet<TblBoardMsg> TblBoardMsgs { get; set; }
        public virtual DbSet<TblDistrict> TblDistricts { get; set; }
        public virtual DbSet<TblGenderType> TblGenderTypes { get; set; }
        public virtual DbSet<TblGeography> TblGeographies { get; set; }
        public virtual DbSet<TblGroupBlog> TblGroupBlogs { get; set; }
        public virtual DbSet<TblHeadManue> TblHeadManues { get; set; }
        public virtual DbSet<TblLogAccessWeb> TblLogAccessWebs { get; set; }
        public virtual DbSet<TblLogBugReport> TblLogBugReports { get; set; }
        public virtual DbSet<TblLogReport> TblLogReports { get; set; }
        public virtual DbSet<TblMassageNotify> TblMassageNotifies { get; set; }
        public virtual DbSet<TblMedium> TblMedia { get; set; }
        public virtual DbSet<TblMenusList> TblMenusLists { get; set; }
        public virtual DbSet<TblMenusType> TblMenusTypes { get; set; }
        public virtual DbSet<TblMonitorParam> TblMonitorParams { get; set; }
        public virtual DbSet<TblOtpState> TblOtpStates { get; set; }
        public virtual DbSet<TblPermissionType> TblPermissionTypes { get; set; }
        public virtual DbSet<TblPromoteImg> TblPromoteImgs { get; set; }
        public virtual DbSet<TblProvince> TblProvinces { get; set; }
        public virtual DbSet<TblReview> TblReviews { get; set; }
        public virtual DbSet<TblServiceMenu> TblServiceMenus { get; set; }
        public virtual DbSet<TblServiceTime> TblServiceTimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=hospitalmeet_db;Trusted_Connection=True;User ID=sa;Password=Admin1234!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_100_CI_AI");

            modelBuilder.Entity<AccountAlbum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountAlbum");

                entity.Property(e => e.AlbumName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AlbumNo).ValueGeneratedOnAdd();

                entity.Property(e => e.AlbumRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtbLanguage>(entity =>
            {
                entity.HasKey(e => e.LagId);

                entity.ToTable("mtbLanguage");

                entity.Property(e => e.LagId).ValueGeneratedNever();

                entity.Property(e => e.LagName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagNameshot)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtbPageType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mtbPageType");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PageName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.AccountNo);

                entity.ToTable("tblAccount");

                entity.Property(e => e.AccountPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AmphuresId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Astate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CagsLists)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cagsLists")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FistName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NickName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PageType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinesId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Verified).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblAccountAlbum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountAlbum");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlbumRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GalleryRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountBlogGay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountBlogGay");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BlogRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BlogimgRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblAccountCert>(entity =>
            {
                entity.HasKey(e => e.CertRef);

                entity.ToTable("tblAccountCert");

                entity.Property(e => e.CertRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.CertDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CertNo).ValueGeneratedOnAdd();

                entity.Property(e => e.CertPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CertTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expire).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAccountCover>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountCover");

                entity.Property(e => e.AccountCoverRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CoverId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblAccountDesc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountDesc");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescId).ValueGeneratedOnAdd();

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountExp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountExp");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ExpFilePath).IsUnicode(false);

                entity.Property(e => e.ExperienceNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleExp)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountGallery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountGallery");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlbumRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GalleryPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAccountInfo>(entity =>
            {
                entity.HasKey(e => e.AccountPhone);

                entity.ToTable("tblAccountInfo");

                entity.Property(e => e.AccountPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountRef)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity).HasDefaultValueSql("((0))");

                entity.Property(e => e.AddressProvince).HasDefaultValueSql("((0))");

                entity.Property(e => e.AnotPro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallIns)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallOuts)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExTech)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FistName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderType).HasDefaultValueSql("((0))");

                entity.Property(e => e.GoogleLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Review)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Verified).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAccountNetwork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountNetwork");

                entity.Property(e => e.AccountRef)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRefNetwork)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetworkId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblAccountProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountProfile");

                entity.Property(e => e.AccountProfileRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblAccountReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountReview");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BlogRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MsgReview).IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountService");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ServiceRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleService)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountTitle");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleBar)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TitleDetile)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountWeek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountWeeks");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ToTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAmphure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAmphures");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_th");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            });

            modelBuilder.Entity<TblBlogMsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBlogMsg");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BlogMsg).IsUnicode(false);

                entity.Property(e => e.BlogRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupRef).HasDefaultValueSql("((65776))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageType).HasDefaultValueSql("((4))");

                entity.Property(e => e.UrlRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBoardMsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBoardMsg");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BoardMsg).IsUnicode(false);

                entity.Property(e => e.BoardRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageType).HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.ToTable("tblDistricts");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.AmphureId).HasColumnName("amphure_id");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_th");

                entity.Property(e => e.ZipCode).HasColumnName("zip_code");
            });

            modelBuilder.Entity<TblGenderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenderType");

                entity.Property(e => e.GenderNameEng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GenderNameENG");

                entity.Property(e => e.GenderNameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GenderNameTH");
            });

            modelBuilder.Entity<TblGeography>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGeographies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblGroupBlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGroupBlog");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupNameEng)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GroupNameENG")
                    .HasDefaultValueSql("('wait for content')");

                entity.Property(e => e.GroupNameTh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GroupNameTH");

                entity.Property(e => e.GroupRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imgurl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imgurl");
            });

            modelBuilder.Entity<TblHeadManue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHeadManues");

                entity.Property(e => e.HedManuId).ValueGeneratedOnAdd();

                entity.Property(e => e.HedManuName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HedMenuAction)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HedMenuController)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HedMenuUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Lag)
                    .WithMany()
                    .HasForeignKey(d => d.LagId)
                    .HasConstraintName("FK_tblHeadManues_mtbLanguage");
            });

            modelBuilder.Entity<TblLogAccessWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblLogAccessWeb");

                entity.Property(e => e.AccessPageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewAccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogBugReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblLogBugReport");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.BugDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BugRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BugTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLogReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblLogReport");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.BugDetail).IsUnicode(false);

                entity.Property(e => e.BugType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ViewAccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ViewRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMassageNotify>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMassageNotify");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Massage).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageType).HasDefaultValueSql("((0))");

                entity.Property(e => e.TitelName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ViewRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMedium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMedia");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageType).HasDefaultValueSql("((3))");

                entity.Property(e => e.VdoFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VdoFileTitleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VdoRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VdoTitleName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMenusList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMenusList");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManusGroup).HasDefaultValueSql("((1))");

                entity.Property(e => e.ManusNameUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MenusDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MenusNameEng)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MenusNameENG");

                entity.Property(e => e.MenusNameTh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MenusNameTH");

                entity.Property(e => e.MenusNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblMenusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMenusType");

                entity.Property(e => e.GroupNameEng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupNameENG");

                entity.Property(e => e.GroupNameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupNameTH");
            });

            modelBuilder.Entity<TblMonitorParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMonitorParam");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameTh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblOtpState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblOtpState");

                entity.Property(e => e.AccountPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtpCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtpRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtpRunningNo).ValueGeneratedOnAdd();

                entity.Property(e => e.OtpState).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegisType).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblPermissionType>(entity =>
            {
                entity.HasKey(e => e.PermissionType);

                entity.ToTable("tblPermissionType");

                entity.Property(e => e.PermissionType).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PermissionDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionNameEng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionNameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblPromoteImg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblPromoteImg");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewsContent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewsPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewsRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblProvinces");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.GeographyId).HasColumnName("geography_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imgurl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imgurl");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_th");
            });

            modelBuilder.Entity<TblReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblReviews");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountReview)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Review)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblServiceMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblServiceMenus");

                entity.Property(e => e.AccountRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MenusMyDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServiceTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblServiceTime");

                entity.Property(e => e.ServicePrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTimeNo).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
