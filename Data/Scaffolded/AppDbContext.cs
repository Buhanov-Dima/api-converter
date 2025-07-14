using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api_converter.Data.Scaffolded;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Addresses> Addresses { get; set; }

    public virtual DbSet<AppealEntities> AppealEntities { get; set; }

    public virtual DbSet<Appeals> Appeals { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<BaseFileModels> BaseFileModels { get; set; }

    public virtual DbSet<BenchmarkReestrs> BenchmarkReestrs { get; set; }

    public virtual DbSet<Clients> Clients { get; set; }

    public virtual DbSet<Coefficients> Coefficients { get; set; }

    public virtual DbSet<ComStatus> ComStatus { get; set; }

    public virtual DbSet<Comments> Comments { get; set; }

    public virtual DbSet<CourtSessionForDebts> CourtSessionForDebts { get; set; }

    public virtual DbSet<Courts> Courts { get; set; }

    public virtual DbSet<DatesOfDebts> DatesOfDebts { get; set; }

    public virtual DbSet<DebtUserInfoes> DebtUserInfoes { get; set; }

    public virtual DbSet<Debtors> Debtors { get; set; }

    public virtual DbSet<Debts> Debts { get; set; }

    public virtual DbSet<DescriptionCourts> DescriptionCourts { get; set; }

    public virtual DbSet<DeterminationOfReturns> DeterminationOfReturns { get; set; }

    public virtual DbSet<Dublicates> Dublicates { get; set; }

    public virtual DbSet<EntityTypes> EntityTypes { get; set; }

    public virtual DbSet<ExStatus> ExStatus { get; set; }

    public virtual DbSet<FileModels> FileModels { get; set; }

    public virtual DbSet<Fssps> Fssps { get; set; }

    public virtual DbSet<Histories> Histories { get; set; }

    public virtual DbSet<Logs> Logs { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

    public virtual DbSet<Notifications> Notifications { get; set; }

    public virtual DbSet<Organizations> Organizations { get; set; }

    public virtual DbSet<Passports> Passports { get; set; }

    public virtual DbSet<Payments> Payments { get; set; }

    public virtual DbSet<People> People { get; set; }

    public virtual DbSet<Phones> Phones { get; set; }

    public virtual DbSet<PinUsers> PinUsers { get; set; }

    public virtual DbSet<ProductClients> ProductClients { get; set; }

    public virtual DbSet<ProductTypes> ProductTypes { get; set; }

    public virtual DbSet<ReasonForEndings> ReasonForEndings { get; set; }

    public virtual DbSet<Reasons> Reasons { get; set; }

    public virtual DbSet<Reestrs> Reestrs { get; set; }

    public virtual DbSet<Regions> Regions { get; set; }

    public virtual DbSet<ReportActivityWithDebtorTts> ReportActivityWithDebtorTts { get; set; }

    public virtual DbSet<ReportActivityWithGosTts> ReportActivityWithGosTts { get; set; }

    public virtual DbSet<ReportIncomingTts> ReportIncomingTts { get; set; }

    public virtual DbSet<ReportOutgoingTts> ReportOutgoingTts { get; set; }

    public virtual DbSet<ReportViewModels> ReportViewModels { get; set; }

    public virtual DbSet<RequestCourts> RequestCourts { get; set; }

    public virtual DbSet<Requisites> Requisites { get; set; }

    public virtual DbSet<Stats> Stats { get; set; }

    public virtual DbSet<Status> Status { get; set; }

    public virtual DbSet<TransferDebts> TransferDebts { get; set; }

    public virtual DbSet<TransferToUses> TransferToUses { get; set; }

    public virtual DbSet<TypeActivities> TypeActivities { get; set; }

    public virtual DbSet<TypeAddresses> TypeAddresses { get; set; }

    public virtual DbSet<TypeBenchmarks> TypeBenchmarks { get; set; }

    public virtual DbSet<TypeComs> TypeComs { get; set; }

    public virtual DbSet<TypeCourts> TypeCourts { get; set; }

    public virtual DbSet<TypeDescriptions> TypeDescriptions { get; set; }

    public virtual DbSet<TypeDocuments> TypeDocuments { get; set; }

    public virtual DbSet<TypeFssps> TypeFssps { get; set; }

    public virtual DbSet<TypeNotifications> TypeNotifications { get; set; }

    public virtual DbSet<TypeOfDocs> TypeOfDocs { get; set; }

    public virtual DbSet<TypeOfOrgs> TypeOfOrgs { get; set; }

    public virtual DbSet<TypeOfProductions> TypeOfProductions { get; set; }

    public virtual DbSet<TypeOfResolutions> TypeOfResolutions { get; set; }

    public virtual DbSet<TypePatterns> TypePatterns { get; set; }

    public virtual DbSet<TypePhones> TypePhones { get; set; }

    public virtual DbSet<UserInfoTasks> UserInfoTasks { get; set; }

    public virtual DbSet<UserTasks> UserTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Addresses>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK_dbo.Addresses");

            entity.ToTable("Addresses", "dbo");

            entity.HasIndex(e => e.DebtorDebtorId, "Addresses_IX_Debtor_DebtorID");

            entity.HasIndex(e => e.RegionId, "Addresses_IX_RegionID");

            entity.HasIndex(e => e.TypeAddressId, "Addresses_IX_TypeAddressID");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.DebtorDebtorId).HasColumnName("Debtor_DebtorID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TypeAddressId)
                .HasDefaultValue(0)
                .HasColumnName("TypeAddressID");

            entity.HasOne(d => d.DebtorDebtor).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.DebtorDebtorId)
                .HasConstraintName("FK_dbo.Addresses_dbo.Debtors_Debtor_DebtorID");

            entity.HasOne(d => d.RegionNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_dbo.Addresses_dbo.Regions_RegionID");

            entity.HasOne(d => d.TypeAddress).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.TypeAddressId)
                .HasConstraintName("FK_dbo.Addresses_dbo.TypeAddresses_TypeAddressID");
        });

        modelBuilder.Entity<AppealEntities>(entity =>
        {
            entity.HasKey(e => e.AppealEntityId).HasName("PK_dbo.AppealEntities");

            entity.ToTable("AppealEntities", "dbo");

            entity.HasIndex(e => e.AddressId, "AppealEntities_IX_AddressID");

            entity.HasIndex(e => e.ComStatusId, "AppealEntities_IX_ComStatusID");

            entity.HasIndex(e => e.CommentId, "AppealEntities_IX_CommentID");

            entity.HasIndex(e => e.CompanyId, "AppealEntities_IX_CompanyID");

            entity.HasIndex(e => e.CourtId, "AppealEntities_IX_CourtID");

            entity.HasIndex(e => e.DebtDebtId, "AppealEntities_IX_Debt_DebtID");

            entity.HasIndex(e => e.FsspId, "AppealEntities_IX_FsspID");

            entity.HasIndex(e => e.TypeComId, "AppealEntities_IX_TypeComID");

            entity.Property(e => e.AppealEntityId)
                .ValueGeneratedNever()
                .HasColumnName("AppealEntityID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.ComStatusId).HasColumnName("ComStatusID");
            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CourtId).HasColumnName("CourtID");
            entity.Property(e => e.DateGetResult).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfConsideration).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfRulingAppeal).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfTheComplaint)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtDebtId).HasColumnName("Debt_DebtID");
            entity.Property(e => e.FsspId).HasColumnName("FsspID");
            entity.Property(e => e.Result).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ResultStatus).HasDefaultValue(0);
            entity.Property(e => e.TypeComId).HasColumnName("TypeComID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Address).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.Addresses_AddressID");

            entity.HasOne(d => d.ComStatus).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.ComStatusId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.ComStatus_ComStatusID");

            entity.HasOne(d => d.Comment).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.Comments_CommentID");

            entity.HasOne(d => d.Company).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.Organizations_CompanyID");

            entity.HasOne(d => d.Court).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.CourtId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.Courts_CourtID");

            entity.HasOne(d => d.DebtDebt).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.DebtDebtId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.Debts_Debt_DebtID");

            entity.HasOne(d => d.Fssp).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.FsspId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.FSSPs_FsspID");

            entity.HasOne(d => d.TypeCom).WithMany(p => p.AppealEntities)
                .HasForeignKey(d => d.TypeComId)
                .HasConstraintName("FK_dbo.AppealEntities_dbo.TypeComs_TypeComID");
        });

        modelBuilder.Entity<Appeals>(entity =>
        {
            entity.HasKey(e => e.AppealId).HasName("PK_dbo.Appeals");

            entity.ToTable("Appeals", "dbo");

            entity.HasIndex(e => e.AddressId, "Appeals_IX_AddressID");

            entity.HasIndex(e => e.ComStatusId, "Appeals_IX_ComStatusID");

            entity.HasIndex(e => e.CommentId, "Appeals_IX_CommentID");

            entity.HasIndex(e => e.CourtId, "Appeals_IX_CourtID");

            entity.HasIndex(e => e.DebtDebtId, "Appeals_IX_Debt_DebtID");

            entity.HasIndex(e => e.FsspId, "Appeals_IX_FsspID");

            entity.HasIndex(e => e.OrganizationCompanyId, "Appeals_IX_Organization_CompanyID");

            entity.HasIndex(e => e.TypeComId, "Appeals_IX_TypeComID");

            entity.Property(e => e.AppealId).HasColumnName("AppealID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.ComStatusId).HasColumnName("ComStatusID");
            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.CourtId).HasColumnName("CourtID");
            entity.Property(e => e.DateGetResult).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfConsideration).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfRulingAppeal).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfTheComplaint)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtDebtId).HasColumnName("Debt_DebtID");
            entity.Property(e => e.FsspId).HasColumnName("FsspID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.OrganizationCompanyId).HasColumnName("Organization_CompanyID");
            entity.Property(e => e.Result).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Shpi).HasColumnName("shpi");
            entity.Property(e => e.TypeComId).HasColumnName("TypeComID");

            entity.HasOne(d => d.Address).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.Appeals_dbo.Addresses_AddressID");

            entity.HasOne(d => d.ComStatus).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.ComStatusId)
                .HasConstraintName("FK_dbo.Appeals_dbo.ComStatus_ComStatusID");

            entity.HasOne(d => d.Comment).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK_dbo.Appeals_dbo.Comments_CommentID");

            entity.HasOne(d => d.Court).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.CourtId)
                .HasConstraintName("FK_dbo.Appeals_dbo.Courts_CourtID");

            entity.HasOne(d => d.DebtDebt).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.DebtDebtId)
                .HasConstraintName("FK_dbo.Appeals_dbo.Debts_Debt_DebtID");

            entity.HasOne(d => d.Fssp).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.FsspId)
                .HasConstraintName("FK_dbo.Appeals_dbo.FSSPs_FsspID");

            entity.HasOne(d => d.OrganizationCompany).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.OrganizationCompanyId)
                .HasConstraintName("FK_dbo.Appeals_dbo.Organizations_Organization_CompanyID");

            entity.HasOne(d => d.TypeCom).WithMany(p => p.Appeals)
                .HasForeignKey(d => d.TypeComId)
                .HasConstraintName("FK_dbo.Appeals_dbo.TypeComs_TypeComID");
        });

        modelBuilder.Entity<AspNetRoles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.ToTable("AspNetRoles", "dbo");

            entity.HasIndex(e => e.Name, "AspNetRoles_RoleNameIndex").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Discriminator)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying");
        });

        modelBuilder.Entity<AspNetUserClaims>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.ToTable("AspNetUserClaims", "dbo");

            entity.HasIndex(e => e.UserId, "AspNetUserClaims_IX_UserId");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogins>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.ToTable("AspNetUserLogins", "dbo");

            entity.HasIndex(e => e.UserId, "AspNetUserLogins_IX_UserId");

            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.ProviderKey)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUsers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.ToTable("AspNetUsers", "dbo");

            entity.HasIndex(e => e.UserName, "AspNetUsers_UserNameIndex").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.AccessFailedCount).HasDefaultValue(0);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmailConfirmed).HasDefaultValue(false);
            entity.Property(e => e.LockoutEnabled).HasDefaultValue(false);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.PhoneNumberConfirmed).HasDefaultValue(false);
            entity.Property(e => e.TwoFactorEnabled).HasDefaultValue(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying");

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRoles",
                    r => r.HasOne<AspNetRoles>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUsers>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles", "dbo");
                        j.HasIndex(new[] { "RoleId" }, "AspNetUserRoles_IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "AspNetUserRoles_IX_UserId");
                        j.IndexerProperty<string>("UserId")
                            .HasMaxLength(128)
                            .HasDefaultValueSql("''::character varying");
                        j.IndexerProperty<string>("RoleId")
                            .HasMaxLength(128)
                            .HasDefaultValueSql("''::character varying");
                    });
        });

        modelBuilder.Entity<BaseFileModels>(entity =>
        {
            entity.HasKey(e => e.FileModelId).HasName("PK_dbo.BaseFileModels");

            entity.ToTable("BaseFileModels", "dbo");

            entity.HasIndex(e => e.DebtId, "BaseFileModels_IX_DebtID");

            entity.HasIndex(e => e.TypeDocumentId, "BaseFileModels_IX_TypeDocumentID");

            entity.HasIndex(e => e.TypeOfDocId, "BaseFileModels_IX_TypeOfDocID");

            entity.Property(e => e.FileModelId).HasColumnName("FileModelID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.DownloadDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeDocumentId)
                .HasDefaultValue(0)
                .HasColumnName("TypeDocumentID");
            entity.Property(e => e.TypeOfDocId)
                .HasDefaultValue(0)
                .HasColumnName("TypeOfDocID");

            entity.HasOne(d => d.Debt).WithMany(p => p.BaseFileModels)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.BaseFileModels_dbo.Debts_DebtID");

            entity.HasOne(d => d.TypeDocument).WithMany(p => p.BaseFileModels)
                .HasForeignKey(d => d.TypeDocumentId)
                .HasConstraintName("FK_dbo.BaseFileModels_dbo.TypeDocuments_TypeDocumentID");

            entity.HasOne(d => d.TypeOfDoc).WithMany(p => p.BaseFileModels)
                .HasForeignKey(d => d.TypeOfDocId)
                .HasConstraintName("FK_dbo.BaseFileModels_dbo.TypeOfDocs_TypeOfDocID");
        });

        modelBuilder.Entity<BenchmarkReestrs>(entity =>
        {
            entity.HasKey(e => e.BenchmarkId).HasName("PK_dbo.BenchmarkReestrs");

            entity.ToTable("BenchmarkReestrs", "dbo");

            entity.HasIndex(e => e.ReestrId, "BenchmarkReestrs_IX_ReestrID");

            entity.HasIndex(e => e.TypeId, "BenchmarkReestrs_IX_TypeID");

            entity.Property(e => e.BenchmarkId).HasColumnName("BenchmarkID");
            entity.Property(e => e.BenchmarkStep).HasDefaultValue(0);
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.ReestrId).HasColumnName("ReestrID");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeId)
                .HasDefaultValue(0)
                .HasColumnName("TypeID");
            entity.Property(e => e.ValueMoney)
                .HasPrecision(18, 2)
                .HasColumnName("value_money");
            entity.Property(e => e.ValuePercent)
                .HasPrecision(18, 2)
                .HasColumnName("value_percent");

            entity.HasOne(d => d.Reestr).WithMany(p => p.BenchmarkReestrs)
                .HasForeignKey(d => d.ReestrId)
                .HasConstraintName("FK_dbo.BenchmarkReestrs_dbo.Reestrs_ReestrID");

            entity.HasOne(d => d.Type).WithMany(p => p.BenchmarkReestrs)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_dbo.BenchmarkReestrs_dbo.TypeBenchmarks_TypeID");
        });

        modelBuilder.Entity<Clients>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK_dbo.Clients");

            entity.ToTable("Clients", "dbo");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.Bik).HasColumnName("BIK");
            entity.Property(e => e.CorAcc).HasColumnName("CorACC");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.Kpp).HasColumnName("KPP");
            entity.Property(e => e.Ogrn).HasColumnName("OGRN");
            entity.Property(e => e.PaymentAcc).HasColumnName("PaymentACC");
        });

        modelBuilder.Entity<Coefficients>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Coefficients");

            entity.ToTable("Coefficients", "dbo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Coef)
                .HasPrecision(18, 2)
                .HasColumnName("coef");
        });

        modelBuilder.Entity<ComStatus>(entity =>
        {
            entity.HasKey(e => e.ComStatusId).HasName("PK_dbo.ComStatus");

            entity.ToTable("ComStatus", "dbo");

            entity.Property(e => e.ComStatusId).HasColumnName("ComStatusID");
        });

        modelBuilder.Entity<Comments>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK_dbo.Comments");

            entity.ToTable("Comments", "dbo");

            entity.HasIndex(e => e.DebtId, "Comments_IX_DebtID");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.CommentDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("commentDate");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Debt).WithMany(p => p.Comments)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.Comments_dbo.Debts_DebtID");
        });

        modelBuilder.Entity<CourtSessionForDebts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CourtSessionForDebts");

            entity.ToTable("CourtSessionForDebts", "dbo");

            entity.HasIndex(e => e.DebtDebtId, "CourtSessionForDebts_IX_Debt_DebtID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCourtSession)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtDebtId).HasColumnName("Debt_DebtID");

            entity.HasOne(d => d.DebtDebt).WithMany(p => p.CourtSessionForDebts)
                .HasForeignKey(d => d.DebtDebtId)
                .HasConstraintName("FK_dbo.CourtSessionForDebts_dbo.Debts_Debt_DebtID");
        });

        modelBuilder.Entity<Courts>(entity =>
        {
            entity.HasKey(e => e.CourtId).HasName("PK_dbo.Courts");

            entity.ToTable("Courts", "dbo");

            entity.HasIndex(e => e.AddressId, "Courts_IX_AddressID");

            entity.HasIndex(e => e.TypeCourtId, "Courts_IX_TypeCourtID");

            entity.Property(e => e.CourtId).HasColumnName("CourtID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.Bik).HasColumnName("BIK");
            entity.Property(e => e.Identifer).HasColumnName("identifer");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.Kbk).HasColumnName("KBK");
            entity.Property(e => e.Kpp).HasColumnName("KPP");
            entity.Property(e => e.Oktmo).HasColumnName("OKTMO");
            entity.Property(e => e.PaymentAcc).HasColumnName("PaymentACC");
            entity.Property(e => e.RullerCourtId).HasColumnName("RullerCourtID");
            entity.Property(e => e.TypeCourtId).HasColumnName("TypeCourtID");
            entity.Property(e => e.Ufk).HasColumnName("UFK");

            entity.HasOne(d => d.Address).WithMany(p => p.Courts)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.Courts_dbo.Addresses_AddressID");

            entity.HasOne(d => d.TypeCourt).WithMany(p => p.Courts)
                .HasForeignKey(d => d.TypeCourtId)
                .HasConstraintName("FK_dbo.Courts_dbo.TypeCourts_TypeCourtID");
        });

        modelBuilder.Entity<DatesOfDebts>(entity =>
        {
            entity.HasKey(e => e.DatesOfDebtId).HasName("PK_dbo.DatesOfDebts");

            entity.ToTable("DatesOfDebts", "dbo");

            entity.Property(e => e.DatesOfDebtId).HasColumnName("DatesOfDebtID");
            entity.Property(e => e.ActualDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ComplitionDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ComplitionDateOsp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ComplitionDateOSP");
            entity.Property(e => e.DateArrestProperty).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateDisputeOverLaw).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateGetDisputeOverLaw).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfCancellationSp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DateOfCancellationSP");
            entity.Property(e => e.DateOfEntryCourtDecision).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfExpiration).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfFilingClaim).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfGetIl)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DateOfGetIL");
            entity.Property(e => e.DateOfHearing).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfInitiation).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfIssueIl)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DateOfIssueIL");
            entity.Property(e => e.DateOfLastPay).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfOrder).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfPayStateDuty).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfPosting).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfReceipt).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfReceiptCancelSp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DateOfReceiptCancelSP");
            entity.Property(e => e.DateOfReceiptTheJudgment).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfRecivedDoc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfSendToBank).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfSendToCourt).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfSendToExecution).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfSendToOsp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DateOfSendToOSP");
            entity.Property(e => e.DateOfSubmission).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOutOfWork).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateStart).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateTransfer).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateСourtDecision).HasColumnType("timestamp without time zone");
            entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ExitRestrictionDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ExpirationDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.HelpDetermination).HasColumnType("timestamp without time zone");
            entity.Property(e => e.LastChangeForDebt).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Notification).HasColumnType("timestamp without time zone");
            entity.Property(e => e.OverdueDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.RetirementDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.StartContract).HasColumnType("timestamp without time zone");
            entity.Property(e => e.StateDutyReturn).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Statement).HasColumnType("timestamp without time zone");
            entity.Property(e => e.StatementIfns)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("StatementIFNS");
        });

        modelBuilder.Entity<DebtUserInfoes>(entity =>
        {
            entity.HasKey(e => e.DebtInfoId).HasName("PK_dbo.DebtUserInfoes");

            entity.ToTable("DebtUserInfoes", "dbo");

            entity.Property(e => e.DebtInfoId).HasColumnName("DebtInfoID");
            entity.Property(e => e.UserCallingId).HasColumnName("UserCallingID");
            entity.Property(e => e.UserExecutiveId).HasColumnName("UserExecutiveID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Debtors>(entity =>
        {
            entity.HasKey(e => e.DebtorId).HasName("PK_dbo.Debtors");

            entity.ToTable("Debtors", "dbo");

            entity.HasIndex(e => e.PassportId, "Debtors_IX_PassportID");

            entity.Property(e => e.DebtorId).HasColumnName("DebtorID");
            entity.Property(e => e.AddressId)
                .HasDefaultValue(0)
                .HasColumnName("AddressID");
            entity.Property(e => e.DateOfBirth)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.FName).HasColumnName("F_Name");
            entity.Property(e => e.LName).HasColumnName("L_Name");
            entity.Property(e => e.PassportId)
                .HasDefaultValue(0)
                .HasColumnName("PassportID");
            entity.Property(e => e.SName).HasColumnName("S_Name");

            entity.HasOne(d => d.Passport).WithMany(p => p.Debtors)
                .HasForeignKey(d => d.PassportId)
                .HasConstraintName("FK_dbo.Debtors_dbo.Passports_PassportID");
        });

        modelBuilder.Entity<Debts>(entity =>
        {
            entity.HasKey(e => e.DebtId).HasName("PK_dbo.Debts");

            entity.ToTable("Debts", "dbo");

            entity.HasIndex(e => e.CourtId, "Debts_IX_CourtID");

            entity.HasIndex(e => e.DatesOfDebtId, "Debts_IX_DatesOfDebtID");

            entity.HasIndex(e => e.DebtInfoId, "Debts_IX_DebtInfoID");

            entity.HasIndex(e => e.DebtorId, "Debts_IX_DebtorID");

            entity.HasIndex(e => e.ExStatusId, "Debts_IX_ExStatusID");

            entity.HasIndex(e => e.FsspId, "Debts_IX_FsspID");

            entity.HasIndex(e => e.ProductTypeId, "Debts_IX_ProductTypeID");

            entity.HasIndex(e => e.ReestrId, "Debts_IX_ReestrID");

            entity.HasIndex(e => e.RegionId, "Debts_IX_RegionID");

            entity.HasIndex(e => e.StatusId, "Debts_IX_StatusID");

            entity.HasIndex(e => e.TypeOfDocId, "Debts_IX_TypeOfDocID");

            entity.HasIndex(e => e.TypeOfProductionId, "Debts_IX_TypeOfProductionID");

            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.AmountContractD).HasPrecision(18, 2);
            entity.Property(e => e.CancelSp).HasColumnName("CancelSP");
            entity.Property(e => e.CheckTransfer).HasDefaultValue(false);
            entity.Property(e => e.CountOfSend).HasDefaultValue(0);
            entity.Property(e => e.CourtId).HasColumnName("CourtID");
            entity.Property(e => e.DatesOfDebtId).HasColumnName("DatesOfDebtID");
            entity.Property(e => e.DebtInfoId).HasColumnName("DebtInfoID");
            entity.Property(e => e.DebtorId)
                .HasDefaultValue(0)
                .HasColumnName("DebtorID");
            entity.Property(e => e.ExStatusId).HasColumnName("ExStatusID");
            entity.Property(e => e.FsspId).HasColumnName("FsspID");
            entity.Property(e => e.IdentiferTt).HasColumnName("IdentiferTT");
            entity.Property(e => e.Ilnumber).HasColumnName("ILNumber");
            entity.Property(e => e.MainDebtD).HasPrecision(18, 2);
            entity.Property(e => e.MonthlyPaymentD).HasPrecision(18, 2);
            entity.Property(e => e.NumberPov).HasColumnName("NumberPOV");
            entity.Property(e => e.OverdueDebtD).HasPrecision(18, 2);
            entity.Property(e => e.PaymentAll).HasPrecision(18, 2);
            entity.Property(e => e.PaymentCount).HasDefaultValue(0);
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.ReestrId)
                .HasDefaultValue(0)
                .HasColumnName("ReestrID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StateDutyD).HasPrecision(18, 2);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TotalDebtD).HasPrecision(18, 2);
            entity.Property(e => e.TypeOfDocId).HasColumnName("TypeOfDocID");
            entity.Property(e => e.TypeOfProductionId)
                .HasDefaultValue(0)
                .HasColumnName("TypeOfProductionID");

            entity.HasOne(d => d.Court).WithMany(p => p.Debts)
                .HasForeignKey(d => d.CourtId)
                .HasConstraintName("FK_dbo.Debts_dbo.Courts_CourtID");

            entity.HasOne(d => d.DatesOfDebt).WithMany(p => p.Debts)
                .HasForeignKey(d => d.DatesOfDebtId)
                .HasConstraintName("FK_dbo.Debts_dbo.DatesOfDebts_DatesOfDebtID");

            entity.HasOne(d => d.DebtInfo).WithMany(p => p.Debts)
                .HasForeignKey(d => d.DebtInfoId)
                .HasConstraintName("FK_dbo.Debts_dbo.DebtUserInfoes_DebtInfoID");

            entity.HasOne(d => d.Debtor).WithMany(p => p.Debts)
                .HasForeignKey(d => d.DebtorId)
                .HasConstraintName("FK_dbo.Debts_dbo.Debtors_DebtorID");

            entity.HasOne(d => d.ExStatus).WithMany(p => p.Debts)
                .HasForeignKey(d => d.ExStatusId)
                .HasConstraintName("FK_dbo.Debts_dbo.ExStatus_ExStatusID");

            entity.HasOne(d => d.Fssp).WithMany(p => p.Debts)
                .HasForeignKey(d => d.FsspId)
                .HasConstraintName("FK_dbo.Debts_dbo.FSSPs_FsspID");

            entity.HasOne(d => d.ProductType).WithMany(p => p.Debts)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_dbo.Debts_dbo.ProductTypes_ProductTypeID");

            entity.HasOne(d => d.Reestr).WithMany(p => p.Debts)
                .HasForeignKey(d => d.ReestrId)
                .HasConstraintName("FK_dbo.Debts_dbo.Reestrs_ReestrID");

            entity.HasOne(d => d.Region).WithMany(p => p.Debts)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_dbo.Debts_dbo.Regions_RegionID");

            entity.HasOne(d => d.Status).WithMany(p => p.Debts)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_dbo.Debts_dbo.Status_StatusID");

            entity.HasOne(d => d.TypeOfDoc).WithMany(p => p.Debts)
                .HasForeignKey(d => d.TypeOfDocId)
                .HasConstraintName("FK_dbo.Debts_dbo.TypeOfDocs_TypeOfDocID");

            entity.HasOne(d => d.TypeOfProduction).WithMany(p => p.Debts)
                .HasForeignKey(d => d.TypeOfProductionId)
                .HasConstraintName("FK_dbo.Debts_dbo.TypeOfProductions_TypeOfProductionID");
        });

        modelBuilder.Entity<DescriptionCourts>(entity =>
        {
            entity.HasKey(e => e.DescriptionCourtId).HasName("PK_dbo.DescriptionCourts");

            entity.ToTable("DescriptionCourts", "dbo");

            entity.HasIndex(e => e.DebtId, "DescriptionCourts_IX_DebtID");

            entity.HasIndex(e => e.TypeId, "DescriptionCourts_IX_TypeID");

            entity.Property(e => e.DescriptionCourtId).HasColumnName("DescriptionCourtID");
            entity.Property(e => e.DateOfTransferSlip).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateSendToBank).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.GetToCourtSlip).HasColumnType("timestamp without time zone");
            entity.Property(e => e.SendToCourtSlip)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.Debt).WithMany(p => p.DescriptionCourts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.DescriptionCourts_dbo.Debts_DebtID");

            entity.HasOne(d => d.Type).WithMany(p => p.DescriptionCourts)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_dbo.DescriptionCourts_dbo.TypeDescriptions_TypeID");
        });

        modelBuilder.Entity<DeterminationOfReturns>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PK_dbo.DeterminationOfReturns");

            entity.ToTable("DeterminationOfReturns", "dbo");

            entity.HasIndex(e => e.DebtId, "DeterminationOfReturns_IX_DebtID");

            entity.Property(e => e.ReturnId).HasColumnName("ReturnID");
            entity.Property(e => e.DateDefinitionsToReturn)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfResubmissionToCourt).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfReturnDoc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");

            entity.HasOne(d => d.Debt).WithMany(p => p.DeterminationOfReturns)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.DeterminationOfReturns_dbo.Debts_DebtID");
        });

        modelBuilder.Entity<Dublicates>(entity =>
        {
            entity.HasKey(e => e.DublicateId).HasName("PK_dbo.Dublicates");

            entity.ToTable("Dublicates", "dbo");

            entity.HasIndex(e => e.DebtId, "Dublicates_IX_DebtID");

            entity.Property(e => e.DublicateId).HasColumnName("DublicateID");
            entity.Property(e => e.DateOfGetDuplicate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfSendDuplicate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");

            entity.HasOne(d => d.Debt).WithMany(p => p.Dublicates)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.Dublicates_dbo.Debts_DebtID");
        });

        modelBuilder.Entity<EntityTypes>(entity =>
        {
            entity.HasKey(e => e.EntityTypeId).HasName("PK_dbo.EntityTypes");

            entity.ToTable("EntityTypes", "dbo");

            entity.Property(e => e.EntityTypeId)
                .ValueGeneratedNever()
                .HasColumnName("EntityTypeID");
        });

        modelBuilder.Entity<ExStatus>(entity =>
        {
            entity.HasKey(e => e.ExStatusId).HasName("PK_dbo.ExStatus");

            entity.ToTable("ExStatus", "dbo");

            entity.Property(e => e.ExStatusId).HasColumnName("ExStatusID");
        });

        modelBuilder.Entity<FileModels>(entity =>
        {
            entity.HasKey(e => e.FileModelId).HasName("PK_dbo.FileModels");

            entity.ToTable("FileModels", "dbo");

            entity.HasIndex(e => e.DebtId, "FileModels_IX_DebtID");

            entity.HasIndex(e => e.ReportIncomingTtid, "FileModels_IX_ReportIncomingTTId");

            entity.HasIndex(e => e.ReportOutgoingTtid, "FileModels_IX_ReportOutgoingTTId");

            entity.HasIndex(e => e.TypeDocumentId, "FileModels_IX_TypeDocumentID");

            entity.Property(e => e.FileModelId).HasColumnName("FileModelID");
            entity.Property(e => e.DateOfIssue).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.DownloadDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.NumberOfDocumentIl).HasColumnName("NumberOfDocumentIL");
            entity.Property(e => e.NumberOfProductiontIl).HasColumnName("NumberOfProductiontIL");
            entity.Property(e => e.RecivedDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ReportIncomingTtid).HasColumnName("ReportIncomingTTId");
            entity.Property(e => e.ReportOutgoingTtid).HasColumnName("ReportOutgoingTTId");
            entity.Property(e => e.Shpi).HasColumnName("shpi");
            entity.Property(e => e.TypeDocumentId).HasColumnName("TypeDocumentID");

            entity.HasOne(d => d.Debt).WithMany(p => p.FileModels)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.FileModels_dbo.Debts_DebtID");

            entity.HasOne(d => d.ReportIncomingTt).WithMany(p => p.FileModels)
                .HasForeignKey(d => d.ReportIncomingTtid)
                .HasConstraintName("FK_dbo.FileModels_dbo.ReportIncomingTTs_ReportIncomingTTId");

            entity.HasOne(d => d.ReportOutgoingTt).WithMany(p => p.FileModels)
                .HasForeignKey(d => d.ReportOutgoingTtid)
                .HasConstraintName("FK_dbo.FileModels_dbo.ReportOutgoingTTs_ReportOutgoingTTId");

            entity.HasOne(d => d.TypeDocument).WithMany(p => p.FileModels)
                .HasForeignKey(d => d.TypeDocumentId)
                .HasConstraintName("FK_dbo.FileModels_dbo.TypeDocuments_TypeDocumentID");
        });

        modelBuilder.Entity<Fssps>(entity =>
        {
            entity.HasKey(e => e.FsspId).HasName("PK_dbo.FSSPs");

            entity.ToTable("FSSPs", "dbo");

            entity.HasIndex(e => e.AddressId, "FSSPs_IX_AddressID");

            entity.HasIndex(e => e.TypeFsspId, "FSSPs_IX_TypeFsspID");

            entity.Property(e => e.FsspId).HasColumnName("FsspID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.HigherFssp).HasColumnName("HigherFSSP");
            entity.Property(e => e.HigherFsspaddress).HasColumnName("HigherFSSPaddress");
            entity.Property(e => e.Identifer).HasColumnName("identifer");
            entity.Property(e => e.RullerFsspid).HasColumnName("RullerFSSPID");
            entity.Property(e => e.TypeFsspId).HasColumnName("TypeFsspID");

            entity.HasOne(d => d.Address).WithMany(p => p.Fssps)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.FSSPs_dbo.Addresses_AddressID");

            entity.HasOne(d => d.TypeFssp).WithMany(p => p.Fssps)
                .HasForeignKey(d => d.TypeFsspId)
                .HasConstraintName("FK_dbo.FSSPs_dbo.TypeFSSPs_TypeFsspID");
        });

        modelBuilder.Entity<Histories>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Histories");

            entity.ToTable("Histories", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId).HasColumnName("ActionID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Logs>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Logs");

            entity.ToTable("Logs", "dbo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateNote)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory", "dbo");

            entity.Property(e => e.MigrationId)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.ContextKey)
                .HasMaxLength(300)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Model).HasDefaultValueSql("'\\x'::bytea");
            entity.Property(e => e.ProductVersion)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying");
        });

        modelBuilder.Entity<Notifications>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Notifications");

            entity.ToTable("Notifications", "dbo");

            entity.HasIndex(e => e.DebtDebtId, "Notifications_IX_Debt_DebtID");

            entity.HasIndex(e => e.TypeNotificationId, "Notifications_IX_TypeNotificationID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.DebtDebtId).HasColumnName("Debt_DebtID");
            entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.TmpDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeNotificationId)
                .HasDefaultValue(0)
                .HasColumnName("TypeNotificationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.DebtDebt).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.DebtDebtId)
                .HasConstraintName("FK_dbo.Notifications_dbo.Debts_Debt_DebtID");

            entity.HasOne(d => d.TypeNotification).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TypeNotificationId)
                .HasConstraintName("FK_dbo.Notifications_dbo.TypeNotifications_TypeNotificationID");
        });

        modelBuilder.Entity<Organizations>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK_dbo.Organizations");

            entity.ToTable("Organizations", "dbo");

            entity.HasIndex(e => e.AddressId, "Organizations_IX_AddressID");

            entity.HasIndex(e => e.DebtDebtId, "Organizations_IX_Debt_DebtID");

            entity.HasIndex(e => e.PersonId, "Organizations_IX_PersonID");

            entity.HasIndex(e => e.RequisiteId, "Organizations_IX_RequisiteID");

            entity.HasIndex(e => e.TypeOfOrgId, "Organizations_IX_TypeOfOrgID");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("CompanyID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.DebtDebtId).HasColumnName("Debt_DebtID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.RequisiteId).HasColumnName("RequisiteID");
            entity.Property(e => e.TypeOfOrgId).HasColumnName("TypeOfOrgID");

            entity.HasOne(d => d.Address).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.Organizations_dbo.Addresses_AddressID");

            entity.HasOne(d => d.DebtDebt).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.DebtDebtId)
                .HasConstraintName("FK_dbo.Organizations_dbo.Debts_Debt_DebtID");

            entity.HasOne(d => d.Person).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_dbo.Organizations_dbo.People_PersonID");

            entity.HasOne(d => d.Requisite).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.RequisiteId)
                .HasConstraintName("FK_dbo.Organizations_dbo.Requisites_RequisiteID");

            entity.HasOne(d => d.TypeOfOrg).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.TypeOfOrgId)
                .HasConstraintName("FK_dbo.Organizations_dbo.TypeOfOrgs_TypeOfOrgID");
        });

        modelBuilder.Entity<Passports>(entity =>
        {
            entity.HasKey(e => e.PassportId).HasName("PK_dbo.Passports");

            entity.ToTable("Passports", "dbo");

            entity.Property(e => e.PassportId).HasColumnName("PassportID");
            entity.Property(e => e.DateOfIssue).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<Payments>(entity =>
        {
            entity.HasKey(e => e.PayId).HasName("PK_dbo.Payments");

            entity.ToTable("Payments", "dbo");

            entity.HasIndex(e => e.DebtId, "Payments_IX_DebtID");

            entity.Property(e => e.PayId).HasColumnName("PayID");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.PaymentCost).HasPrecision(18, 2);
            entity.Property(e => e.PaymentDay).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Debt).WithMany(p => p.Payments)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.Payments_dbo.Debts_DebtID");
        });

        modelBuilder.Entity<People>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK_dbo.People");

            entity.ToTable("People", "dbo");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("PersonID");
        });

        modelBuilder.Entity<Phones>(entity =>
        {
            entity.HasKey(e => e.PhoneId).HasName("PK_dbo.Phones");

            entity.ToTable("Phones", "dbo");

            entity.HasIndex(e => e.CourtCourtId, "Phones_IX_Court_CourtID");

            entity.HasIndex(e => e.DebtorDebtorId, "Phones_IX_Debtor_DebtorID");

            entity.HasIndex(e => e.EntityTypeId, "Phones_IX_EntityTypeID");

            entity.HasIndex(e => e.FsspFsspId, "Phones_IX_FSSP_FsspID");

            entity.HasIndex(e => e.OrganizationCompanyId, "Phones_IX_Organization_CompanyID");

            entity.HasIndex(e => e.TypePhoneTypePhoneId, "Phones_IX_TypePhone_TypePhoneID");

            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            entity.Property(e => e.CourtCourtId).HasColumnName("Court_CourtID");
            entity.Property(e => e.DebtorDebtorId).HasColumnName("Debtor_DebtorID");
            entity.Property(e => e.EntityId)
                .HasDefaultValue(0)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityTypeId)
                .HasDefaultValue(0)
                .HasColumnName("EntityTypeID");
            entity.Property(e => e.FsspFsspId).HasColumnName("FSSP_FsspID");
            entity.Property(e => e.ModelId).HasColumnName("ModelID");
            entity.Property(e => e.OrganizationCompanyId).HasColumnName("Organization_CompanyID");
            entity.Property(e => e.PhoneStatusId).HasColumnName("PhoneStatusID");
            entity.Property(e => e.TypePhoneTypePhoneId).HasColumnName("TypePhone_TypePhoneID");

            entity.HasOne(d => d.CourtCourt).WithMany(p => p.Phones)
                .HasForeignKey(d => d.CourtCourtId)
                .HasConstraintName("FK_dbo.Phones_dbo.Courts_Court_CourtID");

            entity.HasOne(d => d.DebtorDebtor).WithMany(p => p.Phones)
                .HasForeignKey(d => d.DebtorDebtorId)
                .HasConstraintName("FK_dbo.Phones_dbo.Debtors_Debtor_DebtorID");

            entity.HasOne(d => d.EntityType).WithMany(p => p.Phones)
                .HasForeignKey(d => d.EntityTypeId)
                .HasConstraintName("FK_dbo.Phones_dbo.EntityTypes_EntityTypeID");

            entity.HasOne(d => d.FsspFssp).WithMany(p => p.Phones)
                .HasForeignKey(d => d.FsspFsspId)
                .HasConstraintName("FK_dbo.Phones_dbo.FSSPs_FSSP_FsspID");

            entity.HasOne(d => d.OrganizationCompany).WithMany(p => p.Phones)
                .HasForeignKey(d => d.OrganizationCompanyId)
                .HasConstraintName("FK_dbo.Phones_dbo.Organizations_Organization_CompanyID");

            entity.HasOne(d => d.TypePhoneTypePhone).WithMany(p => p.Phones)
                .HasForeignKey(d => d.TypePhoneTypePhoneId)
                .HasConstraintName("FK_dbo.Phones_dbo.TypePhones_TypePhone_TypePhoneID");
        });

        modelBuilder.Entity<PinUsers>(entity =>
        {
            entity.HasKey(e => e.PinUserId).HasName("PK_dbo.PinUsers");

            entity.ToTable("PinUsers", "dbo");

            entity.Property(e => e.PinUserId).HasColumnName("PinUserID");
        });

        modelBuilder.Entity<ProductClients>(entity =>
        {
            entity.HasKey(e => e.ProductClientId).HasName("PK_dbo.ProductClients");

            entity.ToTable("ProductClients", "dbo");

            entity.HasIndex(e => e.ProductTypeProductTypeId, "ProductClients_IX_ProductType_ProductTypeID");

            entity.Property(e => e.ProductClientId).HasColumnName("ProductClientID");
            entity.Property(e => e.ProductTypeProductTypeId).HasColumnName("ProductType_ProductTypeID");

            entity.HasOne(d => d.ProductTypeProductType).WithMany(p => p.ProductClients)
                .HasForeignKey(d => d.ProductTypeProductTypeId)
                .HasConstraintName("FK_dbo.ProductClients_dbo.ProductTypes_ProductType_ProductTypeI");
        });

        modelBuilder.Entity<ProductTypes>(entity =>
        {
            entity.HasKey(e => e.ProductTypeId).HasName("PK_dbo.ProductTypes");

            entity.ToTable("ProductTypes", "dbo");

            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.Client).HasDefaultValue(0);
        });

        modelBuilder.Entity<ReasonForEndings>(entity =>
        {
            entity.HasKey(e => e.ReasonForEndingId).HasName("PK_dbo.ReasonForEndings");

            entity.ToTable("ReasonForEndings", "dbo");

            entity.Property(e => e.ReasonForEndingId).HasColumnName("ReasonForEndingID");
        });

        modelBuilder.Entity<Reasons>(entity =>
        {
            entity.HasKey(e => e.ReasonId).HasName("PK_dbo.Reasons");

            entity.ToTable("Reasons", "dbo");

            entity.HasIndex(e => e.DebtId, "Reasons_IX_DebtID");

            entity.HasIndex(e => e.ReturnId, "Reasons_IX_ReturnID");

            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.ReasonGroupId)
                .HasDefaultValue(0)
                .HasColumnName("ReasonGroupID");
            entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

            entity.HasOne(d => d.Debt).WithMany(p => p.Reasons)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.Reasons_dbo.Debts_DebtID");

            entity.HasOne(d => d.Return).WithMany(p => p.Reasons)
                .HasForeignKey(d => d.ReturnId)
                .HasConstraintName("FK_dbo.Reasons_dbo.DeterminationOfReturns_ReturnID");
        });

        modelBuilder.Entity<Reestrs>(entity =>
        {
            entity.HasKey(e => e.ReestrId).HasName("PK_dbo.Reestrs");

            entity.ToTable("Reestrs", "dbo");

            entity.HasIndex(e => e.ClientId, "Reestrs_IX_ClientID");

            entity.HasIndex(e => e.PinUserId, "Reestrs_IX_PinUserID");

            entity.Property(e => e.ReestrId).HasColumnName("ReestrID");
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.DateOfReciving)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfStart)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.PinUserId).HasColumnName("PinUserID");

            entity.HasOne(d => d.Client).WithMany(p => p.Reestrs)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_dbo.Reestrs_dbo.Clients_ClientID");

            entity.HasOne(d => d.PinUser).WithMany(p => p.Reestrs)
                .HasForeignKey(d => d.PinUserId)
                .HasConstraintName("FK_dbo.Reestrs_dbo.PinUsers_PinUserID");
        });

        modelBuilder.Entity<Regions>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK_dbo.Regions");

            entity.ToTable("Regions", "dbo");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Utc).HasColumnName("UTC");
        });

        modelBuilder.Entity<ReportActivityWithDebtorTts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReportActivityWithDebtorTTs");

            entity.ToTable("ReportActivityWithDebtorTTs", "dbo");

            entity.HasIndex(e => e.CommentId, "ReportActivityWithDebtorTTs_IX_CommentID");

            entity.HasIndex(e => e.DebtId, "ReportActivityWithDebtorTTs_IX_DebtID");

            entity.HasIndex(e => e.TypeActivityId, "ReportActivityWithDebtorTTs_IX_TypeActivityID");

            entity.Property(e => e.ActivityDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.PromiseAmount).HasPrecision(18, 2);
            entity.Property(e => e.PromiseDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.TransferReestrDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeActivityId)
                .HasDefaultValue(0)
                .HasColumnName("TypeActivityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Comment).WithMany(p => p.ReportActivityWithDebtorTts)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK_dbo.ReportActivityWithDebtorTTs_dbo.Comments_CommentID");

            entity.HasOne(d => d.Debt).WithMany(p => p.ReportActivityWithDebtorTts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.ReportActivityWithDebtorTTs_dbo.Debts_DebtID");

            entity.HasOne(d => d.TypeActivity).WithMany(p => p.ReportActivityWithDebtorTts)
                .HasForeignKey(d => d.TypeActivityId)
                .HasConstraintName("FK_dbo.ReportActivityWithDebtorTTs_dbo.TypeActivities_TypeActiv");
        });

        modelBuilder.Entity<ReportActivityWithGosTts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReportActivityWithGosTTs");

            entity.ToTable("ReportActivityWithGosTTs", "dbo");

            entity.HasIndex(e => e.CommentId, "ReportActivityWithGosTTs_IX_CommentID");

            entity.HasIndex(e => e.DebtId, "ReportActivityWithGosTTs_IX_DebtID");

            entity.HasIndex(e => e.TypeActivityId, "ReportActivityWithGosTTs_IX_TypeActivityID");

            entity.Property(e => e.ActivityDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.ActivityPersonFio).HasColumnName("ActivityPersonFIO");
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.TransferReestrDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeActivityId)
                .HasDefaultValue(0)
                .HasColumnName("TypeActivityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Comment).WithMany(p => p.ReportActivityWithGosTts)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK_dbo.ReportActivityWithGosTTs_dbo.Comments_CommentID");

            entity.HasOne(d => d.Debt).WithMany(p => p.ReportActivityWithGosTts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.ReportActivityWithGosTTs_dbo.Debts_DebtID");

            entity.HasOne(d => d.TypeActivity).WithMany(p => p.ReportActivityWithGosTts)
                .HasForeignKey(d => d.TypeActivityId)
                .HasConstraintName("FK_dbo.ReportActivityWithGosTTs_dbo.TypeActivities_TypeActivity");
        });

        modelBuilder.Entity<ReportIncomingTts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReportIncomingTTs");

            entity.ToTable("ReportIncomingTTs", "dbo");

            entity.HasIndex(e => e.DebtId, "ReportIncomingTTs_IX_DebtID");

            entity.HasIndex(e => e.ReasonForEndingId, "ReportIncomingTTs_IX_ReasonForEndingID");

            entity.HasIndex(e => e.TypeDocumentId, "ReportIncomingTTs_IX_TypeDocumentID");

            entity.HasIndex(e => e.TypeOfResolutionId, "ReportIncomingTTs_IX_TypeOfResolutionID");

            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.DateOfIssue).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.MainDebt).HasPrecision(18, 2);
            entity.Property(e => e.NumberOfDocumentIl).HasColumnName("NumberOfDocumentIL");
            entity.Property(e => e.NumberOfProductiontIl).HasColumnName("NumberOfProductiontIL");
            entity.Property(e => e.Penalties).HasPrecision(18, 2);
            entity.Property(e => e.Percent).HasPrecision(18, 2);
            entity.Property(e => e.ReasonForEndingId).HasColumnName("ReasonForEndingID");
            entity.Property(e => e.RecivedDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Shpi).HasColumnName("SHPI");
            entity.Property(e => e.StateDuty).HasPrecision(18, 2);
            entity.Property(e => e.TransferReestrDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeDocumentId)
                .HasDefaultValue(0)
                .HasColumnName("TypeDocumentID");
            entity.Property(e => e.TypeOfResolutionId)
                .HasDefaultValue(0)
                .HasColumnName("TypeOfResolutionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Debt).WithMany(p => p.ReportIncomingTts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.ReportIncomingTTs_dbo.Debts_DebtID");

            entity.HasOne(d => d.ReasonForEnding).WithMany(p => p.ReportIncomingTts)
                .HasForeignKey(d => d.ReasonForEndingId)
                .HasConstraintName("FK_dbo.ReportIncomingTTs_dbo.ReasonForEndings_ReasonForEndingID");

            entity.HasOne(d => d.TypeDocument).WithMany(p => p.ReportIncomingTts)
                .HasForeignKey(d => d.TypeDocumentId)
                .HasConstraintName("FK_dbo.ReportIncomingTTs_dbo.TypeDocuments_TypeDocumentID");

            entity.HasOne(d => d.TypeOfResolution).WithMany(p => p.ReportIncomingTts)
                .HasForeignKey(d => d.TypeOfResolutionId)
                .HasConstraintName("FK_dbo.ReportIncomingTTs_dbo.TypeOfResolutions_TypeOfResolution");
        });

        modelBuilder.Entity<ReportOutgoingTts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReportOutgoingTTs");

            entity.ToTable("ReportOutgoingTTs", "dbo");

            entity.HasIndex(e => e.AddressId, "ReportOutgoingTTs_IX_AddressID");

            entity.HasIndex(e => e.DebtId, "ReportOutgoingTTs_IX_DebtID");

            entity.HasIndex(e => e.TypeDocumentId, "ReportOutgoingTTs_IX_TypeDocumentID");

            entity.Property(e => e.AddressId)
                .HasDefaultValue(0)
                .HasColumnName("AddressID");
            entity.Property(e => e.AmountOfClaims).HasPrecision(18, 2);
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.DebtId)
                .HasDefaultValue(0)
                .HasColumnName("DebtID");
            entity.Property(e => e.SendDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Shpi).HasColumnName("SHPI");
            entity.Property(e => e.TransferReestrDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TypeDocumentId)
                .HasDefaultValue(0)
                .HasColumnName("TypeDocumentID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Address).WithMany(p => p.ReportOutgoingTts)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_dbo.ReportOutgoingTTs_dbo.Addresses_AddressID");

            entity.HasOne(d => d.Debt).WithMany(p => p.ReportOutgoingTts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.ReportOutgoingTTs_dbo.Debts_DebtID");

            entity.HasOne(d => d.TypeDocument).WithMany(p => p.ReportOutgoingTts)
                .HasForeignKey(d => d.TypeDocumentId)
                .HasConstraintName("FK_dbo.ReportOutgoingTTs_dbo.TypeDocuments_TypeDocumentID");
        });

        modelBuilder.Entity<ReportViewModels>(entity =>
        {
            entity.HasKey(e => e.StatId).HasName("PK_dbo.ReportViewModels");

            entity.ToTable("ReportViewModels", "dbo");

            entity.Property(e => e.StatId).HasColumnName("StatID");
            entity.Property(e => e.CancellCount).HasDefaultValue(0);
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.ComplaintCountGet).HasDefaultValue(0);
            entity.Property(e => e.ComplaintCountSend).HasDefaultValue(0);
            entity.Property(e => e.CourtId)
                .HasDefaultValue(0)
                .HasColumnName("CourtID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtCountNotinWork).HasDefaultValue(0);
            entity.Property(e => e.DebtCountReestr).HasDefaultValue(0);
            entity.Property(e => e.DispatchOrder).HasDefaultValue(0);
            entity.Property(e => e.DispatchSheet).HasDefaultValue(0);
            entity.Property(e => e.DublicateCountGet).HasDefaultValue(0);
            entity.Property(e => e.DublicateCountSend).HasDefaultValue(0);
            entity.Property(e => e.OrderCount).HasDefaultValue(0);
            entity.Property(e => e.ReestrId)
                .HasDefaultValue(0)
                .HasColumnName("ReestrID");
            entity.Property(e => e.RefusalsCount).HasDefaultValue(0);
            entity.Property(e => e.RegionId)
                .HasDefaultValue(0)
                .HasColumnName("RegionID");
            entity.Property(e => e.RequestCount).HasDefaultValue(0);
            entity.Property(e => e.ReturnCount).HasDefaultValue(0);
            entity.Property(e => e.SheetCount).HasDefaultValue(0);
            entity.Property(e => e.SlipCount).HasDefaultValue(0);
            entity.Property(e => e.SubmissionCount).HasDefaultValue(0);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<RequestCourts>(entity =>
        {
            entity.HasKey(e => e.RequestCourtId).HasName("PK_dbo.RequestCourts");

            entity.ToTable("RequestCourts", "dbo");

            entity.HasIndex(e => e.DebtId, "RequestCourts_IX_DebtID");

            entity.Property(e => e.RequestCourtId).HasColumnName("RequestCourtID");
            entity.Property(e => e.DateOfGetBackTheRequest).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DateOfTheRequest)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.TxtRequest).HasColumnName("txtRequest");

            entity.HasOne(d => d.Debt).WithMany(p => p.RequestCourts)
                .HasForeignKey(d => d.DebtId)
                .HasConstraintName("FK_dbo.RequestCourts_dbo.Debts_DebtID");
        });

        modelBuilder.Entity<Requisites>(entity =>
        {
            entity.HasKey(e => e.RequisiteId).HasName("PK_dbo.Requisites");

            entity.ToTable("Requisites", "dbo");

            entity.Property(e => e.RequisiteId)
                .ValueGeneratedNever()
                .HasColumnName("RequisiteID");
            entity.Property(e => e.Bik).HasColumnName("BIK");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.Kbk).HasColumnName("KBK");
            entity.Property(e => e.Kpp).HasColumnName("KPP");
            entity.Property(e => e.Oktmo).HasColumnName("OKTMO");
            entity.Property(e => e.PaymentAcc).HasColumnName("PaymentACC");
            entity.Property(e => e.Ufk).HasColumnName("UFK");
        });

        modelBuilder.Entity<Stats>(entity =>
        {
            entity.HasKey(e => e.StatId).HasName("PK_dbo.Stats");

            entity.ToTable("Stats", "dbo");

            entity.HasIndex(e => e.ReportViewModelStatId, "Stats_IX_ReportViewModel_StatID");

            entity.Property(e => e.StatId).HasColumnName("StatID");
            entity.Property(e => e.ReportViewModelStatId).HasColumnName("ReportViewModel_StatID");
            entity.Property(e => e.Stat)
                .HasDefaultValue(0)
                .HasColumnName("stat");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(0)
                .HasColumnName("StatusID");

            entity.HasOne(d => d.ReportViewModelStat).WithMany(p => p.Stats)
                .HasForeignKey(d => d.ReportViewModelStatId)
                .HasConstraintName("FK_dbo.Stats_dbo.ReportViewModels_ReportViewModel_StatID");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK_dbo.Status");

            entity.ToTable("Status", "dbo");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<TransferDebts>(entity =>
        {
            entity.HasKey(e => e.TransferDebtId).HasName("PK_dbo.TransferDebts");

            entity.ToTable("TransferDebts", "dbo");

            entity.HasIndex(e => e.TransferId, "TransferDebts_IX_TransferID");

            entity.Property(e => e.TransferDebtId).HasColumnName("TransferDebtID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TransferDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TransferId).HasColumnName("TransferID");

            entity.HasOne(d => d.Transfer).WithMany(p => p.TransferDebts)
                .HasForeignKey(d => d.TransferId)
                .HasConstraintName("FK_dbo.TransferDebts_dbo.TransferToUses_TransferID");
        });

        modelBuilder.Entity<TransferToUses>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK_dbo.TransferToUses");

            entity.ToTable("TransferToUses", "dbo");

            entity.Property(e => e.TransferId).HasColumnName("TransferID");
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("ClientID");
            entity.Property(e => e.ConfirmDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.ReestrId)
                .HasDefaultValue(0)
                .HasColumnName("ReestrID");
            entity.Property(e => e.TransferStatus).HasDefaultValue(0);
        });

        modelBuilder.Entity<TypeActivities>(entity =>
        {
            entity.HasKey(e => e.TypeActivityId).HasName("PK_dbo.TypeActivities");

            entity.ToTable("TypeActivities", "dbo");

            entity.Property(e => e.TypeActivityId).HasColumnName("TypeActivityID");
        });

        modelBuilder.Entity<TypeAddresses>(entity =>
        {
            entity.HasKey(e => e.TypeAddressId).HasName("PK_dbo.TypeAddresses");

            entity.ToTable("TypeAddresses", "dbo");

            entity.Property(e => e.TypeAddressId).HasColumnName("TypeAddressID");
        });

        modelBuilder.Entity<TypeBenchmarks>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK_dbo.TypeBenchmarks");

            entity.ToTable("TypeBenchmarks", "dbo");

            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<TypeComs>(entity =>
        {
            entity.HasKey(e => e.TypeComId).HasName("PK_dbo.TypeComs");

            entity.ToTable("TypeComs", "dbo");

            entity.Property(e => e.TypeComId).HasColumnName("TypeComID");
        });

        modelBuilder.Entity<TypeCourts>(entity =>
        {
            entity.HasKey(e => e.TypeCourtId).HasName("PK_dbo.TypeCourts");

            entity.ToTable("TypeCourts", "dbo");

            entity.Property(e => e.TypeCourtId).HasColumnName("TypeCourtID");
        });

        modelBuilder.Entity<TypeDescriptions>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK_dbo.TypeDescriptions");

            entity.ToTable("TypeDescriptions", "dbo");

            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<TypeDocuments>(entity =>
        {
            entity.HasKey(e => e.TypeDocumentId).HasName("PK_dbo.TypeDocuments");

            entity.ToTable("TypeDocuments", "dbo");

            entity.Property(e => e.TypeDocumentId).HasColumnName("TypeDocumentID");
        });

        modelBuilder.Entity<TypeFssps>(entity =>
        {
            entity.HasKey(e => e.TypeFsspId).HasName("PK_dbo.TypeFSSPs");

            entity.ToTable("TypeFSSPs", "dbo");

            entity.Property(e => e.TypeFsspId).HasColumnName("TypeFsspID");
        });

        modelBuilder.Entity<TypeNotifications>(entity =>
        {
            entity.HasKey(e => e.TypeNotificationId).HasName("PK_dbo.TypeNotifications");

            entity.ToTable("TypeNotifications", "dbo");

            entity.Property(e => e.TypeNotificationId).HasColumnName("TypeNotificationID");
        });

        modelBuilder.Entity<TypeOfDocs>(entity =>
        {
            entity.HasKey(e => e.TypeOfDocId).HasName("PK_dbo.TypeOfDocs");

            entity.ToTable("TypeOfDocs", "dbo");

            entity.Property(e => e.TypeOfDocId).HasColumnName("TypeOfDocID");
        });

        modelBuilder.Entity<TypeOfOrgs>(entity =>
        {
            entity.HasKey(e => e.TypeOfOrgId).HasName("PK_dbo.TypeOfOrgs");

            entity.ToTable("TypeOfOrgs", "dbo");

            entity.Property(e => e.TypeOfOrgId).HasColumnName("TypeOfOrgID");
        });

        modelBuilder.Entity<TypeOfProductions>(entity =>
        {
            entity.HasKey(e => e.TypeOfProductionId).HasName("PK_dbo.TypeOfProductions");

            entity.ToTable("TypeOfProductions", "dbo");

            entity.Property(e => e.TypeOfProductionId).HasColumnName("TypeOfProductionID");
        });

        modelBuilder.Entity<TypeOfResolutions>(entity =>
        {
            entity.HasKey(e => e.TypeOfResolutionId).HasName("PK_dbo.TypeOfResolutions");

            entity.ToTable("TypeOfResolutions", "dbo");

            entity.Property(e => e.TypeOfResolutionId).HasColumnName("TypeOfResolutionID");
        });

        modelBuilder.Entity<TypePatterns>(entity =>
        {
            entity.HasKey(e => e.TypePatternId).HasName("PK_dbo.TypePatterns");

            entity.ToTable("TypePatterns", "dbo");

            entity.HasIndex(e => e.TypeOfProductionId, "TypePatterns_IX_TypeOfProductionID");

            entity.Property(e => e.TypePatternId).HasColumnName("TypePatternID");
            entity.Property(e => e.Path).HasColumnName("_path");
            entity.Property(e => e.TypeOfProductionId)
                .HasDefaultValue(0)
                .HasColumnName("TypeOfProductionID");

            entity.HasOne(d => d.TypeOfProduction).WithMany(p => p.TypePatterns)
                .HasForeignKey(d => d.TypeOfProductionId)
                .HasConstraintName("FK_dbo.TypePatterns_dbo.TypeOfProductions_TypeOfProductionID");
        });

        modelBuilder.Entity<TypePhones>(entity =>
        {
            entity.HasKey(e => e.TypePhoneId).HasName("PK_dbo.TypePhones");

            entity.ToTable("TypePhones", "dbo");

            entity.Property(e => e.TypePhoneId)
                .HasDefaultValueSql("nextval('dbo.\"TypePhones_PhoneStatusID_seq\"'::regclass)")
                .HasColumnName("TypePhoneID");
        });

        modelBuilder.Entity<UserInfoTasks>(entity =>
        {
            entity.HasKey(e => e.UserInfoTaskId).HasName("PK_dbo.UserInfoTasks");

            entity.ToTable("UserInfoTasks", "dbo");

            entity.Property(e => e.UserInfoTaskId).HasColumnName("UserInfoTaskID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserTasks>(entity =>
        {
            entity.HasKey(e => e.UserTaskId).HasName("PK_dbo.UserTasks");

            entity.ToTable("UserTasks", "dbo");

            entity.HasIndex(e => e.UserInfoTaskUserInfoTaskId, "UserTasks_IX_UserInfoTask_UserInfoTaskID");

            entity.Property(e => e.UserTaskId).HasColumnName("UserTaskID");
            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DebtId).HasColumnName("DebtID");
            entity.Property(e => e.FinishDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.OverdueDays).HasDefaultValue(0);
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'-infinity'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserInfoTaskUserInfoTaskId).HasColumnName("UserInfoTask_UserInfoTaskID");
            entity.Property(e => e.Visible).HasDefaultValue(false);

            entity.HasOne(d => d.UserInfoTaskUserInfoTask).WithMany(p => p.UserTasks)
                .HasForeignKey(d => d.UserInfoTaskUserInfoTaskId)
                .HasConstraintName("FK_dbo.UserTasks_dbo.UserInfoTasks_UserInfoTask_UserInfoTaskID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
