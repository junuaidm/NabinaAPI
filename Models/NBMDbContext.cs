using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class NBMDbContext : DbContext
    {
        public NBMDbContext()
        {
        }

        public NBMDbContext(DbContextOptions<NBMDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCostCentre> AccountCostCentre { get; set; }
        public virtual DbSet<AccountGroup> AccountGroup { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<AccountsLedgerDetail> AccountsLedgerDetail { get; set; }
        public virtual DbSet<AccountsLedgerDetailOld> AccountsLedgerDetailOld { get; set; }
        public virtual DbSet<AccountsSubLedgerDetail> AccountsSubLedgerDetail { get; set; }
        public virtual DbSet<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
        public virtual DbSet<AccountsVoucherMaster> AccountsVoucherMaster { get; set; }
        public virtual DbSet<BillCollectors> BillCollectors { get; set; }
        public virtual DbSet<CardsMaster> CardsMaster { get; set; }
        public virtual DbSet<CardsRegister> CardsRegister { get; set; }
        public virtual DbSet<CashCustomer> CashCustomer { get; set; }
        public virtual DbSet<ChequeRegister> ChequeRegister { get; set; }
        public virtual DbSet<ChequeRegisterDetail> ChequeRegisterDetail { get; set; }
        public virtual DbSet<CostCentre> CostCentre { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CustomerAccounts> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerBalanceDetail> CustomerBalanceDetail { get; set; }
        public virtual DbSet<CustomerBalanceMaster> CustomerBalanceMaster { get; set; }
        public virtual DbSet<CustomerContactDetails> CustomerContactDetails { get; set; }
        public virtual DbSet<CustomerCreditDetailPayments> CustomerCreditDetailPayments { get; set; }
        public virtual DbSet<CustomerCreditDetails> CustomerCreditDetails { get; set; }
        public virtual DbSet<CustomerCreditOpeningApprovals> CustomerCreditOpeningApprovals { get; set; }
        public virtual DbSet<CustomerDocuments> CustomerDocuments { get; set; }
        public virtual DbSet<CustomerEnquiries> CustomerEnquiries { get; set; }
        public virtual DbSet<CustomerMandatoryDocuments> CustomerMandatoryDocuments { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<CustomerMasterAccountDetails> CustomerMasterAccountDetails { get; set; }
        public virtual DbSet<CustomerMasterAccounts> CustomerMasterAccounts { get; set; }
        public virtual DbSet<CustomerSalesPersons> CustomerSalesPersons { get; set; }
        public virtual DbSet<CustomerStatus> CustomerStatus { get; set; }
        public virtual DbSet<CustomersInfo> CustomersInfo { get; set; }
        public virtual DbSet<DeliveryNoteDetail> DeliveryNoteDetail { get; set; }
        public virtual DbSet<DeliveryNoteIssuerDetail> DeliveryNoteIssuerDetail { get; set; }
        public virtual DbSet<DeliveryNoteItemDetail> DeliveryNoteItemDetail { get; set; }
        public virtual DbSet<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual DbSet<DeliveryNoteReceiverTypeMaster> DeliveryNoteReceiverTypeMaster { get; set; }
        public virtual DbSet<DeliveryTypeMaster> DeliveryTypeMaster { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<EmailType> EmailType { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<Erpconfig> Erpconfig { get; set; }
        public virtual DbSet<FollowUpItemTypeMaster> FollowUpItemTypeMaster { get; set; }
        public virtual DbSet<FollowUpItemTypes> FollowUpItemTypes { get; set; }
        public virtual DbSet<Followups> Followups { get; set; }
        public virtual DbSet<Foreman> Foreman { get; set; }
        public virtual DbSet<FormOfPayments> FormOfPayments { get; set; }
        public virtual DbSet<FxingStaffType> FxingStaffType { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceItemCategory> InvoiceItemCategory { get; set; }
        public virtual DbSet<InvoiceItemCategoryDetail> InvoiceItemCategoryDetail { get; set; }
        public virtual DbSet<ItemAttributes> ItemAttributes { get; set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; set; }
        public virtual DbSet<ItemClassifications> ItemClassifications { get; set; }
        public virtual DbSet<ItemGroupDetails> ItemGroupDetails { get; set; }
        public virtual DbSet<ItemGroups> ItemGroups { get; set; }
        public virtual DbSet<ItemImages> ItemImages { get; set; }
        public virtual DbSet<ItemPriceLog> ItemPriceLog { get; set; }
        public virtual DbSet<ItemPricing> ItemPricing { get; set; }
        public virtual DbSet<ItemProperties> ItemProperties { get; set; }
        public virtual DbSet<ItemSetDetails> ItemSetDetails { get; set; }
        public virtual DbSet<ItemSets> ItemSets { get; set; }
        public virtual DbSet<ItemSetsImages> ItemSetsImages { get; set; }
        public virtual DbSet<ItemSubCategories> ItemSubCategories { get; set; }
        public virtual DbSet<ItemSubCategoryItemTypes> ItemSubCategoryItemTypes { get; set; }
        public virtual DbSet<ItemSubstitutes> ItemSubstitutes { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<ItemTypeCategories> ItemTypeCategories { get; set; }
        public virtual DbSet<Items> Items { get; set; }
       
        public virtual DbSet<LedgerAccounts> LedgerAccounts { get; set; }
        public virtual DbSet<LedgerSubAccounts> LedgerSubAccounts { get; set; }
        public virtual DbSet<LocationCharges> LocationCharges { get; set; }
        public virtual DbSet<MailSettingMaster> MailSettingMaster { get; set; }
        public virtual DbSet<MemitemsIssued> MemitemsIssued { get; set; }
        public virtual DbSet<Memmaster> Memmaster { get; set; }
        public virtual DbSet<ProjectDocuments> ProjectDocuments { get; set; }
        public virtual DbSet<ProjectHistory> ProjectHistory { get; set; }
        public virtual DbSet<ProjectSiteDetails> ProjectSiteDetails { get; set; }
        public virtual DbSet<ProjectStakeHolderType> ProjectStakeHolderType { get; set; }
        public virtual DbSet<ProjectStakeHolders> ProjectStakeHolders { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesInfo> RolesInfo { get; set; }
        public virtual DbSet<SalesCashInvoiceDetails> SalesCashInvoiceDetails { get; set; }
        public virtual DbSet<SalesCashInvoiceMaster> SalesCashInvoiceMaster { get; set; }
        public virtual DbSet<SalesContractDocuments> SalesContractDocuments { get; set; }
        public virtual DbSet<SalesContractDoorDetails> SalesContractDoorDetails { get; set; }
        public virtual DbSet<SalesContractKitchenAccessories> SalesContractKitchenAccessories { get; set; }
        public virtual DbSet<SalesContractKitchenDetails> SalesContractKitchenDetails { get; set; }
        public virtual DbSet<SalesContractMaster> SalesContractMaster { get; set; }
        public virtual DbSet<SalesContractPaymentTerms> SalesContractPaymentTerms { get; set; }
        public virtual DbSet<SalesContractPaymentType> SalesContractPaymentType { get; set; }
        public virtual DbSet<SalesContractPayments> SalesContractPayments { get; set; }
        public virtual DbSet<SalesContractProductDetails> SalesContractProductDetails { get; set; }
        public virtual DbSet<SalesContractWardrobeDetails> SalesContractWardrobeDetails { get; set; }
        public virtual DbSet<SalesCreditInvoiceDetails> SalesCreditInvoiceDetails { get; set; }
        public virtual DbSet<SalesCreditInvoiceMaster> SalesCreditInvoiceMaster { get; set; }
        public virtual DbSet<SalesDeliveryTerms> SalesDeliveryTerms { get; set; }
        public virtual DbSet<SalesDeliveryTime> SalesDeliveryTime { get; set; }
        public virtual DbSet<SalesGroup> SalesGroup { get; set; }
        public virtual DbSet<SalesGroupDiscount> SalesGroupDiscount { get; set; }
        public virtual DbSet<SalesGroupDiscountDefinedFor> SalesGroupDiscountDefinedFor { get; set; }
        public virtual DbSet<SalesInvoiceDocuments> SalesInvoiceDocuments { get; set; }
        public virtual DbSet<SalesInvoicePayments> SalesInvoicePayments { get; set; }
        public virtual DbSet<SalesInvoiceTerms> SalesInvoiceTerms { get; set; }
        public virtual DbSet<SalesInvoiceTmpSiv> SalesInvoiceTmpSiv { get; set; }
        public virtual DbSet<SalesInvoiceType> SalesInvoiceType { get; set; }
        public virtual DbSet<SalesMockupInvoiceDetails> SalesMockupInvoiceDetails { get; set; }
        public virtual DbSet<SalesMockupInvoiceMaster> SalesMockupInvoiceMaster { get; set; }
        public virtual DbSet<SalesPaymentTerms> SalesPaymentTerms { get; set; }
        public virtual DbSet<SalesPersons> SalesPersons { get; set; }
        public virtual DbSet<SalesPriceValidity> SalesPriceValidity { get; set; }
        public virtual DbSet<SalesQuotation> SalesQuotation { get; set; }
        public virtual DbSet<SalesQuotationDetails> SalesQuotationDetails { get; set; }
        public virtual DbSet<SalesQuotationDiscountType> SalesQuotationDiscountType { get; set; }
        public virtual DbSet<SalesQuotationDocuments> SalesQuotationDocuments { get; set; }
        public virtual DbSet<SalesQuotationRawMaterial> SalesQuotationRawMaterial { get; set; }
        public virtual DbSet<SalesQuotationType> SalesQuotationType { get; set; }
        public virtual DbSet<SalesReceiptDetails> SalesReceiptDetails { get; set; }
        public virtual DbSet<SalesReceiptDocuments> SalesReceiptDocuments { get; set; }
        public virtual DbSet<SalesReceiptMaster> SalesReceiptMaster { get; set; }
        public virtual DbSet<SalesReturnConfirmationDetails> SalesReturnConfirmationDetails { get; set; }
        public virtual DbSet<SalesReturnConfirmationMaster> SalesReturnConfirmationMaster { get; set; }
        public virtual DbSet<SalesSampleInvoiceDetails> SalesSampleInvoiceDetails { get; set; }
        public virtual DbSet<SalesSampleInvoiceMaster> SalesSampleInvoiceMaster { get; set; }
        public virtual DbSet<SampleVoucherRequestDetail> SampleVoucherRequestDetail { get; set; }
        public virtual DbSet<SampleVoucherRequestMaster> SampleVoucherRequestMaster { get; set; }
        public virtual DbSet<Smstype> Smstype { get; set; }
        public virtual DbSet<SpallowedDiscounts> SpallowedDiscounts { get; set; }
        public virtual DbSet<SqdeliveryAddress> SqdeliveryAddress { get; set; }
        public virtual DbSet<Srmmaster> Srmmaster { get; set; }
        public virtual DbSet<SrmreturnedItems> SrmreturnedItems { get; set; }
        public virtual DbSet<StoreIssueVoucherDetail> StoreIssueVoucherDetail { get; set; }
        public virtual DbSet<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
        public virtual DbSet<SubLedgerAccountType> SubLedgerAccountType { get; set; }
        public virtual DbSet<SupplierType> SupplierType { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<TermsAndConditions> TermsAndConditions { get; set; }
        public virtual DbSet<TermsOfDelivery> TermsOfDelivery { get; set; }
        public virtual DbSet<TermsOfPayments> TermsOfPayments { get; set; }
        public virtual DbSet<TermsType> TermsType { get; set; }
        public virtual DbSet<TimeOfDeliveries> TimeOfDeliveries { get; set; }
        public virtual DbSet<UnitOfConversion> UnitOfConversion { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInfo> UsersInfo { get; set; }
        public virtual DbSet<VoucherType> VoucherType { get; set; }
        public virtual DbSet<WhWareHouseStorageArea> WhWareHouseStorageArea { get; set; }

        // Unable to generate entity type for table 'dbo.SMSHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CustomerMasterLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ItemPriceUpdation'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server==CVSLAP2\\NEWCVSLAP2;Database=NBMKM;UID=sa;PWD=313root786;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountCostCentre>(entity =>
            {
                entity.Property(e => e.AccountCostCentreId).HasColumnName("AccountCostCentreID");

                entity.Property(e => e.AccountCostCentreAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCostCentreAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountCostCentreDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCostCentreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCostCentreUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCostCentreUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccountGroup>(entity =>
            {
                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountGroupAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountGroupCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupNonEditable).HasMaxLength(10);

                entity.Property(e => e.AccountGroupParentId).HasColumnName("AccountGroupParentID");

                entity.Property(e => e.AccountGroupUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.AccountGroup)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_AccountGroup_AccountType");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountsLedgerDetail>(entity =>
            {
                entity.Property(e => e.AccountsLedgerDetailId).HasColumnName("AccountsLedgerDetailID");

                entity.Property(e => e.AccountCostCentreId).HasColumnName("AccountCostCentreID");

                entity.Property(e => e.AccountsLedgerDetailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsLedgerDetailAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountsLedgerDetailCreditAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.AccountsLedgerDetailDebitAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.AccountsLedgerDetailEntryForCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsLedgerDetailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsLedgerDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.RefDate).HasColumnType("date");

                entity.Property(e => e.RefDetailId).HasColumnName("RefDetailID");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.HasOne(d => d.AccountCostCentre)
                    .WithMany(p => p.AccountsLedgerDetail)
                    .HasForeignKey(d => d.AccountCostCentreId)
                    .HasConstraintName("FK_AccountsLedgerDetail_AccountCostCentre");

                entity.HasOne(d => d.LedgerAccount)
                    .WithMany(p => p.AccountsLedgerDetail)
                    .HasForeignKey(d => d.LedgerAccountId)
                    .HasConstraintName("FK_AccountsLedgerDetail_LedgerAccounts");

                entity.HasOne(d => d.VoucherType)
                    .WithMany(p => p.AccountsLedgerDetail)
                    .HasForeignKey(d => d.VoucherTypeId)
                    .HasConstraintName("FK_AccountsLedgerDetail_VoucherType");
            });

            modelBuilder.Entity<AccountsLedgerDetailOld>(entity =>
            {
                entity.HasKey(e => e.AccountsLedgerDetailId)
                    .HasName("PK_LedgerAccountsDetailOld");

                entity.Property(e => e.AccountsLedgerDetailId).HasColumnName("AccountsLedgerDetailID");

                entity.Property(e => e.AccountCostCentreId).HasColumnName("AccountCostCentreID");

                entity.Property(e => e.AccountsLedgerDetailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsLedgerDetailAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountsLedgerDetailCreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccountsLedgerDetailDebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccountsLedgerDetailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsLedgerDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.RefDate).HasColumnType("date");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");
            });

            modelBuilder.Entity<AccountsSubLedgerDetail>(entity =>
            {
                entity.Property(e => e.AccountsSubLedgerDetailId).HasColumnName("AccountsSubLedgerDetailID");

                entity.Property(e => e.AccountCostCentreId).HasColumnName("AccountCostCentreID");

                entity.Property(e => e.AccountsSubLedgerDetailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsSubLedgerDetailAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccountsSubLedgerDetailCreditAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.AccountsSubLedgerDetailDebitAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.AccountsSubLedgerDetailEntryForCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsSubLedgerDetailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountsSubLedgerDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefDate).HasColumnType("date");

                entity.Property(e => e.RefDetailId).HasColumnName("RefDetailID");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.SubLedgerAccountId).HasColumnName("SubLedgerAccountID");

                entity.Property(e => e.SubLedgerAccountTypeId).HasColumnName("SubLedgerAccountTypeID");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.HasOne(d => d.AccountCostCentre)
                    .WithMany(p => p.AccountsSubLedgerDetail)
                    .HasForeignKey(d => d.AccountCostCentreId)
                    .HasConstraintName("FK_AccountsSubLedgerDetail_AccountCostCentre");

                entity.HasOne(d => d.SubLedgerAccountType)
                    .WithMany(p => p.AccountsSubLedgerDetail)
                    .HasForeignKey(d => d.SubLedgerAccountTypeId)
                    .HasConstraintName("FK_AccountsSubLedgerDetail_SubLedgerAccountType");

                entity.HasOne(d => d.VoucherType)
                    .WithMany(p => p.AccountsSubLedgerDetail)
                    .HasForeignKey(d => d.VoucherTypeId)
                    .HasConstraintName("FK_AccountsSubLedgerDetail_VoucherType");
            });

            modelBuilder.Entity<AccountsVoucherDetail>(entity =>
            {
                entity.HasKey(e => e.VoucherDetailId);

                entity.Property(e => e.VoucherDetailId).HasColumnName("VoucherDetailID");

                entity.Property(e => e.AccountCostCentreId).HasColumnName("AccountCostCentreID");

                entity.Property(e => e.ChequeRegisterId).HasColumnName("ChequeRegisterID");

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.SubLedgerAccountId).HasColumnName("SubLedgerAccountID");

                entity.Property(e => e.SubLedgerAccountTypeId).HasColumnName("SubLedgerAccountTypeID");

                entity.Property(e => e.VoucherDetaiAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherDetaiAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VoucherDetaiUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherDetailCreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VoucherDetailDebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VoucherDetailDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.AccountCostCentre)
                    .WithMany(p => p.AccountsVoucherDetail)
                    .HasForeignKey(d => d.AccountCostCentreId)
                    .HasConstraintName("FK_AccountsVoucherDetail_AccountCostCentre");

                entity.HasOne(d => d.ChequeRegister)
                    .WithMany(p => p.AccountsVoucherDetail)
                    .HasForeignKey(d => d.ChequeRegisterId)
                    .HasConstraintName("FK_AccountsVoucherDetail_ChequeRegister");

                entity.HasOne(d => d.LedgerAccount)
                    .WithMany(p => p.AccountsVoucherDetail)
                    .HasForeignKey(d => d.LedgerAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsVoucherDetail_LedgerAccounts");

                entity.HasOne(d => d.SubLedgerAccountType)
                    .WithMany(p => p.AccountsVoucherDetail)
                    .HasForeignKey(d => d.SubLedgerAccountTypeId)
                    .HasConstraintName("FK_AccountsVoucherDetail_SubLedgerAccountType");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.AccountsVoucherDetail)
                    .HasForeignKey(d => d.VoucherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsVoucherDetail_AccountsVoucherMaster");
            });

            modelBuilder.Entity<AccountsVoucherMaster>(entity =>
            {
                entity.HasKey(e => e.VoucherId)
                    .HasName("PK_AccountsVoucher");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.SubLedgerAccountId).HasColumnName("SubLedgerAccountID");

                entity.Property(e => e.SubLedgerAccountTypeId).HasColumnName("SubLedgerAccountTypeID");

                entity.Property(e => e.VoucherAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VoucherAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VoucherBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherChequeDate).HasColumnType("date");

                entity.Property(e => e.VoucherChequeDepositVoucherId).HasColumnName("VoucherChequeDepositVoucherID");

                entity.Property(e => e.VoucherChequeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherEffectiveDate).HasColumnType("date");

                entity.Property(e => e.VoucherGrantee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.Property(e => e.VoucherUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.VoucherType)
                    .WithMany(p => p.AccountsVoucherMaster)
                    .HasForeignKey(d => d.VoucherTypeId)
                    .HasConstraintName("FK_AccountsVoucherMaster_VoucherType");
            });

            modelBuilder.Entity<BillCollectors>(entity =>
            {
                entity.HasKey(e => e.BillCollectorId);

                entity.Property(e => e.BillCollectorId).HasColumnName("BillCollectorID");

                entity.Property(e => e.BillCollectorAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCollectorAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BillCollectorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCollectorShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCollectorUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCollectorUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            });

            modelBuilder.Entity<CardsMaster>(entity =>
            {
                entity.HasKey(e => e.CardsId);

                entity.Property(e => e.CardsId).HasColumnName("CardsID");

                entity.Property(e => e.CardsAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardsAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardsServiceChargePercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CardsUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardsUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CardsRegister>(entity =>
            {
                entity.HasKey(e => e.Crid);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.CardsId).HasColumnName("CardsID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CraddedBy)
                    .HasColumnName("CRAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CraddedWhen)
                    .HasColumnName("CRAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrcardActualServiceChargeAmount)
                    .HasColumnName("CRCardActualServiceChargeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrcardActualServiceChargePercentage)
                    .HasColumnName("CRCardActualServiceChargePercentage")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CrcardAmount)
                    .HasColumnName("CRCardAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrcardBankName)
                    .HasColumnName("CRCardBankName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrcardNo)
                    .HasColumnName("CRCardNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CrcardServiceChargeAmount)
                    .HasColumnName("CRCardServiceChargeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrcardServiceChargePercentage)
                    .HasColumnName("CRCardServiceChargePercentage")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CrclearDate)
                    .HasColumnName("CRClearDate")
                    .HasColumnType("date");

                entity.Property(e => e.Crdate)
                    .HasColumnName("CRDate")
                    .HasColumnType("date");

                entity.Property(e => e.Crremarks)
                    .HasColumnName("CRRemarks")
                    .IsUnicode(false);

                entity.Property(e => e.Crstatus).HasColumnName("CRStatus");

                entity.Property(e => e.CrupdatedBy)
                    .HasColumnName("CRUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrupdatedWhen)
                    .HasColumnName("CRUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesReceiptId).HasColumnName("SalesReceiptID");
            });

            modelBuilder.Entity<CashCustomer>(entity =>
            {
                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CashCustomerAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CashCustomerAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerContactPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.CashCustomerMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerPobox)
                    .HasColumnName("CashCustomerPOBox")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerTelephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashCustomerUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CashCustomeraddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChequeRegister>(entity =>
            {
                entity.Property(e => e.ChequeRegisterId).HasColumnName("ChequeRegisterID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ChequeRegisterChequeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRegisterChequeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChequeRegisterChequeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeRegisterChequeBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRegisterChequeBouncedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeClearedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeDepositedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeGivenBackDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRegisterChequePostPonedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRegisterChequeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRegisterChequeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChequeRegisterDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterDepositVoucherDetailId).HasColumnName("ChequeRegisterDepositVoucherDetailID");

                entity.Property(e => e.ChequeRegisterDepositVoucherId).HasColumnName("ChequeRegisterDepositVoucherID");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesReceiptId).HasColumnName("SalesReceiptID");

                entity.Property(e => e.SubLedgerAccountId).HasColumnName("SubLedgerAccountID");

                entity.Property(e => e.SubLedgerAccountTypeId).HasColumnName("SubLedgerAccountTypeID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.CashCustomer)
                    .WithMany(p => p.ChequeRegister)
                    .HasForeignKey(d => d.CashCustomerId)
                    .HasConstraintName("FK_ChequeRegister_CashCustomer");

                entity.HasOne(d => d.ChequeRegisterDepositVoucherDetail)
                    .WithMany(p => p.ChequeRegisterNavigation)
                    .HasForeignKey(d => d.ChequeRegisterDepositVoucherDetailId)
                    .HasConstraintName("FK_ChequeRegister_AccountsVoucherDetail");

                entity.HasOne(d => d.ChequeRegisterDepositVoucher)
                    .WithMany(p => p.ChequeRegisterChequeRegisterDepositVoucher)
                    .HasForeignKey(d => d.ChequeRegisterDepositVoucherId)
                    .HasConstraintName("FK_ChequeRegister_AccountsVoucherMaster1");

                entity.HasOne(d => d.LedgerAccount)
                    .WithMany(p => p.ChequeRegister)
                    .HasForeignKey(d => d.LedgerAccountId)
                    .HasConstraintName("FK_ChequeRegister_LedgerAccounts");

                entity.HasOne(d => d.SalesCashInvoice)
                    .WithMany(p => p.ChequeRegister)
                    .HasForeignKey(d => d.SalesCashInvoiceId)
                    .HasConstraintName("FK_ChequeRegister_SalesCashInvoiceMaster");

                entity.HasOne(d => d.SalesReceipt)
                    .WithMany(p => p.ChequeRegister)
                    .HasForeignKey(d => d.SalesReceiptId)
                    .HasConstraintName("FK_ChequeRegister_SalesReceiptMaster");

                entity.HasOne(d => d.SubLedgerAccountType)
                    .WithMany(p => p.ChequeRegister)
                    .HasForeignKey(d => d.SubLedgerAccountTypeId)
                    .HasConstraintName("FK_ChequeRegister_SubLedgerAccountType");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.ChequeRegisterVoucher)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_ChequeRegister_AccountsVoucherMaster");
            });

            modelBuilder.Entity<ChequeRegisterDetail>(entity =>
            {
                entity.HasKey(e => e.CrdetailId);

                entity.Property(e => e.CrdetailId).HasColumnName("CRDetailID");

                entity.Property(e => e.ChequeRegisterChequeBouncedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeCleareDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterChequeDepositedDate).HasColumnType("date");

                entity.Property(e => e.ChequeRegisterId).HasColumnName("ChequeRegisterID");

                entity.Property(e => e.CrdetailAddedBy)
                    .HasColumnName("CRDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdetailAddedWhen)
                    .HasColumnName("CRDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrdetailStatus).HasColumnName("CRDetailStatus");

                entity.Property(e => e.CrdetailUpdatedBy)
                    .HasColumnName("CRDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdetailUpdatedWhen)
                    .HasColumnName("CRDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VoucherDetailId).HasColumnName("VoucherDetailID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<CostCentre>(entity =>
            {
                entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");

                entity.Property(e => e.CostCentreAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentreAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CostCentreDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentreName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentreUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentreUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerAccounts>(entity =>
            {
                entity.HasKey(e => e.CustAccntId);

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustAccntAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustAccntAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustAccntDate).HasColumnType("date");

                entity.Property(e => e.CustAccntDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustAccntName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustAccntNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustAccntUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustAccntUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAccounts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerAccounts_CustomerMaster");
            });

            modelBuilder.Entity<CustomerBalanceDetail>(entity =>
            {
                entity.Property(e => e.CustomerBalanceDetailId).HasColumnName("CustomerBalanceDetailID");

                entity.Property(e => e.CustomerBalanceDetailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceDetailAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerBalanceDetailAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerBalanceDetailAmountType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceDetailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerBalanceId).HasColumnName("CustomerBalanceID");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.Srmid).HasColumnName("SRMID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<CustomerBalanceMaster>(entity =>
            {
                entity.HasKey(e => e.CustomerBalanceId)
                    .HasName("PK_CustomerBalance");

                entity.Property(e => e.CustomerBalanceId).HasColumnName("CustomerBalanceID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustomerBalanceAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerBalanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerBalanceAmountType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceDate).HasColumnType("date");

                entity.Property(e => e.CustomerBalanceUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalanceUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.Srmid).HasColumnName("SRMID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<CustomerContactDetails>(entity =>
            {
                entity.HasKey(e => e.ContactDetId);

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.ContactAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDetTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTelNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContactDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerContactDetails_CustomerMaster");
            });

            modelBuilder.Entity<CustomerCreditDetailPayments>(entity =>
            {
                entity.HasKey(e => e.CcdpaymentId)
                    .HasName("PK_CustomerCreditPaymentDetails");

                entity.Property(e => e.CcdpaymentId).HasColumnName("CCDPaymentID");

                entity.Property(e => e.CcppaymentAddedBy)
                    .HasColumnName("CCPPaymentAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CcppaymentAddedWhen)
                    .HasColumnName("CCPPaymentAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustCreditId).HasColumnName("CustCreditID");

                entity.Property(e => e.InvPaymentId).HasColumnName("InvPaymentID");
            });

            modelBuilder.Entity<CustomerCreditDetails>(entity =>
            {
                entity.HasKey(e => e.CusCreditId);

                entity.Property(e => e.CusCreditId).HasColumnName("CusCreditID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustByCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustByCurrentCheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustByLpo)
                    .HasColumnName("CustByLPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustByPdcheque)
                    .HasColumnName("CustByPDCheque")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustCreditAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCreditAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustCreditAdvanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustCreditAdvancePercent).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.CustCreditDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustCreditLimitValidUpto).HasColumnType("date");

                entity.Property(e => e.CustCreditOpeningDate).HasColumnType("date");

                entity.Property(e => e.CustCreditUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCreditUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustCreditUtilisedAgainstInvoice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustCreditapprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCreditapprovedDate).HasColumnType("date");

                entity.Property(e => e.CustCurrentChequeDate).HasColumnType("date");

                entity.Property(e => e.CustMaximumCreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustPdchequeDate)
                    .HasColumnName("CustPDChequeDate")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesInvoiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCreditDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerCreditDetails_CustomerMaster");
            });

            modelBuilder.Entity<CustomerCreditOpeningApprovals>(entity =>
            {
                entity.HasKey(e => e.CustomerCreditOpeningApprovalId);

                entity.Property(e => e.CustomerCreditOpeningApprovalId).HasColumnName("CustomerCreditOpeningApprovalID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApproverUserId).HasColumnName("ApproverUserID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.MenuApprovalId).HasColumnName("MenuApprovalID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CustomerDocuments>(entity =>
            {
                entity.HasKey(e => e.CustDocId);

                entity.Property(e => e.CustDocId).HasColumnName("CustDocID");

                entity.Property(e => e.CustDocAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustDocAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustDocDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustDocFileName).HasMaxLength(100);

                entity.Property(e => e.CustDocFileType).HasMaxLength(50);

                entity.Property(e => e.CustDocName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustDocTypeId).HasColumnName("CustDocTypeID");

                entity.Property(e => e.CustDocUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustDocUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDocuments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerDocuments_CustomerMaster");
            });

            modelBuilder.Entity<CustomerEnquiries>(entity =>
            {
                entity.HasKey(e => e.CustEnquiryId);

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustEnqAdd1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqAdd2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustEnqAssignedOn).HasColumnType("date");

                entity.Property(e => e.CustEnqClosedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqClosingDate).HasColumnType("date");

                entity.Property(e => e.CustEnqClosingReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqContactPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqCustName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqMobile)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqReReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqReceivedDate).HasColumnType("date");

                entity.Property(e => e.CustEnqTelephone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEnqUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerEnquiries)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerEnquiries_CustomerMaster");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CustomerEnquiries)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CustomerEnquiries_Projects");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.CustomerEnquiries)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_CustomerEnquiries_SalesPersons");
            });

            modelBuilder.Entity<CustomerMandatoryDocuments>(entity =>
            {
                entity.HasKey(e => e.MandatoryDocumentId);

                entity.Property(e => e.MandatoryDocumentId).HasColumnName("MandatoryDocumentID");

                entity.Property(e => e.MandatoryDocumentName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfPayment)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CapitalAsPerCr)
                    .HasColumnName("CapitalAsPerCR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUtilised).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrexpiryDate)
                    .HasColumnName("CRExpiryDate")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCreditPeriodAllowed).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustomerCrno)
                    .HasColumnName("CustomerCRNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNatureOfBusiness)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNotes).IsUnicode(false);

                entity.Property(e => e.CustomerOwnerPartner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPobox)
                    .HasColumnName("CustomerPOBox")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRegExpiry).HasColumnType("date");

                entity.Property(e => e.CustomerRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerResidenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTelNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.CustomerWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuaranteeChequeDate).HasColumnType("date");

                entity.Property(e => e.IsEditable).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMopcashCheque).HasColumnName("IsMOPCashCheque");

                entity.Property(e => e.IsMopchequeGuarantee).HasColumnName("IsMOPChequeGuarantee");

                entity.Property(e => e.IsMopcreditInvoice).HasColumnName("IsMOPCreditInvoice");

                entity.Property(e => e.IsMopletterOfCredit).HasColumnName("IsMOPLetterOfCredit");

                entity.Property(e => e.IsMoplocalPurchaseOrder).HasColumnName("IsMOPLocalPurchaseOrder");

                entity.Property(e => e.IsMoppdcheque).HasColumnName("IsMOPPDCheque");

                entity.Property(e => e.IsPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPriorityCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSearchable).HasDefaultValueSql("((1))");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.MaximumCreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.PromotionsCanBeSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SignatoryAsPerCr)
                    .HasColumnName("SignatoryAsPerCR")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMasterAccountDetails>(entity =>
            {
                entity.HasKey(e => e.CustomerMasterAccountDetailId);

                entity.Property(e => e.CustomerMasterAccountDetailId).HasColumnName("CustomerMasterAccountDetailID");

                entity.Property(e => e.CustMasterAccountId).HasColumnName("CustMasterAccountID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerMasterAccountDetailAddedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterAccountDetailAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerMasterAccountDetailUpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMasterAccountDetailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerMasterAccounts>(entity =>
            {
                entity.HasKey(e => e.CustMasterAccountId);

                entity.Property(e => e.CustMasterAccountId).HasColumnName("CustMasterAccountID");

                entity.Property(e => e.CustMasterAccountAddedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustMasterAccountAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustMasterAccountCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustMasterAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustMasterAccountNotes).IsUnicode(false);

                entity.Property(e => e.CustMasterAccountUpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustMasterAccountUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMaximumCreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerSalesPersons>(entity =>
            {
                entity.HasKey(e => e.CustSpid);

                entity.Property(e => e.CustSpid).HasColumnName("CustSPID");

                entity.Property(e => e.CustSpactiveFrom)
                    .HasColumnName("CustSPActiveFrom")
                    .HasColumnType("date");

                entity.Property(e => e.CustSpactiveTo)
                    .HasColumnName("CustSPActiveTo")
                    .HasColumnType("date");

                entity.Property(e => e.CustSpaddedBy)
                    .HasColumnName("CustSPAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustSpaddedWhen)
                    .HasColumnName("CustSPAddedWhen")
                    .HasColumnType("date");

                entity.Property(e => e.CustSpisActive).HasColumnName("CustSPIsActive");

                entity.Property(e => e.CustSpisDefault).HasColumnName("CustSPIsDefault");

                entity.Property(e => e.CustSpupdatedBy)
                    .HasColumnName("CustSPUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustSpupdatedWhen)
                    .HasColumnName("CustSPUpdatedWhen")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerSalesPersons)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerSalesPersons_CustomerMaster");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.CustomerSalesPersons)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_CustomerSalesPersons_SalesPersons");
            });

            modelBuilder.Entity<CustomerStatus>(entity =>
            {
                entity.HasKey(e => e.CustStatusId);

                entity.Property(e => e.CustStatusId).HasColumnName("CustStatusID");

                entity.Property(e => e.CustStatusAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustStatusAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustStatusDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustStatusUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustStatusUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomersInfo>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerAccntCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAdd1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAdd2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.CustomerCreditPeriod).HasColumnType("date");

                entity.Property(e => e.CustomerCrno)
                    .HasColumnName("CustomerCRNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerExpiryDate).HasColumnType("date");

                entity.Property(e => e.CustomerFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNob)
                    .HasColumnName("CustomerNOB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPobox).HasColumnName("CustomerPOBox");

                entity.Property(e => e.CustomerRegDate).HasColumnType("date");

                entity.Property(e => e.CustomerRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSecurity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerTelNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.CustomerWebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryNoteDetail>(entity =>
            {
                entity.HasKey(e => e.DndetailId);

                entity.Property(e => e.DndetailId).HasColumnName("DNDetailID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.BaseUnitQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("DeliveryNoteID");

                entity.Property(e => e.DndetailsAddedBy)
                    .HasColumnName("DNDetailsAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DndetailsAddedWhen)
                    .HasColumnName("DNDetailsAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DndetailsUpdatedBy)
                    .HasColumnName("DNDetailsUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DndetailsUpdatedWhen)
                    .HasColumnName("DNDetailsUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DnitemActualQty)
                    .HasColumnName("DNItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DnitemQty)
                    .HasColumnName("DNItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MemitemIssuedId).HasColumnName("MEMItemIssuedID");

                entity.Property(e => e.SivdetailId).HasColumnName("SIVDetailID");

                entity.Property(e => e.SlcashInvoiceDetailId).HasColumnName("SLCashInvoiceDetailID");

                entity.Property(e => e.SlcreditInvoiceDetailId).HasColumnName("SLCreditInvoiceDetailID");

                entity.Property(e => e.SlmockupInvoiceDetailId).HasColumnName("SLMockupInvoiceDetailID");

                entity.Property(e => e.SlsampleInvoiceDetailId).HasColumnName("SLSampleInvoiceDetailID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.DeliveryNote)
                    .WithMany(p => p.DeliveryNoteDetail)
                    .HasForeignKey(d => d.DeliveryNoteId)
                    .HasConstraintName("FK_DeliveryNoteDetail_DeliveryNoteMaster");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DeliveryNoteDetail)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_DeliveryNoteDetail_Items");

                entity.HasOne(d => d.Sivdetail)
                    .WithMany(p => p.DeliveryNoteDetail)
                    .HasForeignKey(d => d.SivdetailId)
                    .HasConstraintName("FK_DeliveryNoteDetail_StoreIssueVoucherDetail");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DeliveryNoteDetail)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_DeliveryNoteDetail_Units");
            });

            modelBuilder.Entity<DeliveryNoteIssuerDetail>(entity =>
            {
                entity.HasKey(e => e.DnissuerDetailId);

                entity.Property(e => e.DnissuerDetailId).HasColumnName("DNIssuerDetailID");

                entity.Property(e => e.ClerkId).HasColumnName("ClerkID");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("DeliveryNoteID");

                entity.Property(e => e.DnissuerDetailAddedBy)
                    .HasColumnName("DNIssuerDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DnissuerDetailAddedWhen)
                    .HasColumnName("DNIssuerDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DnissuerDetailUpdatedBy)
                    .HasColumnName("DNIssuerDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DnissuerDetailUpdatedWhen)
                    .HasColumnName("DNIssuerDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeliveryNoteItemDetail>(entity =>
            {
                entity.HasKey(e => e.DnitemDetailId)
                    .HasName("PK_DeliveryNoteItemDetails");

                entity.Property(e => e.DnitemDetailId).HasColumnName("DNItemDetailID");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.BaseUnitQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("DeliveryNoteID");

                entity.Property(e => e.DndetailId).HasColumnName("DNDetailID");

                entity.Property(e => e.DnitemDetailsAddedBy)
                    .HasColumnName("DNItemDetailsAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DnitemDetailsAddedWhen)
                    .HasColumnName("DNItemDetailsAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DnitemDetailsDeliveryQty)
                    .HasColumnName("DNItemDetailsDeliveryQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DnitemDetailsQtyBeforeDelivery)
                    .HasColumnName("DNItemDetailsQtyBeforeDelivery")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DnitemDetailsUpdatedBy)
                    .HasColumnName("DNItemDetailsUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DnitemDetailsUpdatedWhen)
                    .HasColumnName("DNItemDetailsUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.StorageAreaId).HasColumnName("StorageAreaID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.BaseUnit)
                    .WithMany(p => p.DeliveryNoteItemDetailBaseUnit)
                    .HasForeignKey(d => d.BaseUnitId)
                    .HasConstraintName("FK_DeliveryNoteItemDetail_Units1");

                entity.HasOne(d => d.DeliveryNote)
                    .WithMany(p => p.DeliveryNoteItemDetail)
                    .HasForeignKey(d => d.DeliveryNoteId)
                    .HasConstraintName("FK_DeliveryNoteItemDetail_DeliveryNoteMaster");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DeliveryNoteItemDetail)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_DeliveryNoteItemDetail_Items");

                entity.HasOne(d => d.StorageArea)
                    .WithMany(p => p.DeliveryNoteItemDetail)
                    .HasForeignKey(d => d.StorageAreaId)
                    .HasConstraintName("FK_DeliveryNoteItemDetail_WhWareHouseStorageArea");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DeliveryNoteItemDetailUnit)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_DeliveryNoteItemDetail_Units");
            });

            modelBuilder.Entity<DeliveryNoteMaster>(entity =>
            {
                entity.HasKey(e => e.DeliveryNoteId);

                entity.Property(e => e.DeliveryNoteId).HasColumnName("DeliveryNoteID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryNoteAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryNoteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNoteDeliveryAddress).HasColumnType("text");

                entity.Property(e => e.DeliveryNoteDeliveryVehicleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteItemsReceivedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteReceiverTypeId).HasColumnName("DeliveryNoteReceiverTypeID");

                entity.Property(e => e.DeliveryNoteRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.ForemanId).HasColumnName("ForemanID");

                entity.Property(e => e.InChargeId).HasColumnName("InChargeID");

                entity.Property(e => e.IsLcdeliveryNote).HasColumnName("IsLCDeliveryNote");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.Sivid).HasColumnName("SIVID");

                entity.HasOne(d => d.Mem)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.Memid)
                    .HasConstraintName("FK_DeliveryNoteMaster_MEMMaster");

                entity.HasOne(d => d.SalesCashInvoice)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.SalesCashInvoiceId);

                entity.HasOne(d => d.SalesCreditInvoice)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.SalesCreditInvoiceId);

                entity.HasOne(d => d.SalesMockupInvoice)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.SalesMockupInvoiceId)
                    .HasConstraintName("FK_DeliveryNoteMaster_SalesMockupInvoiceMaster");

                entity.HasOne(d => d.SalesSampleInvoice)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.SalesSampleInvoiceId)
                    .HasConstraintName("FK_DeliveryNoteMaster_SalesSampleInvoiceMaster");

                entity.HasOne(d => d.Siv)
                    .WithMany(p => p.DeliveryNoteMaster)
                    .HasForeignKey(d => d.Sivid)
                    .HasConstraintName("FK_DeliveryNoteMaster_StoreIssueVoucherMaster");
            });

            modelBuilder.Entity<DeliveryNoteReceiverTypeMaster>(entity =>
            {
                entity.HasKey(e => e.DeliveryNoteReceiverTypeId);

                entity.Property(e => e.DeliveryNoteReceiverTypeId).HasColumnName("DeliveryNoteReceiverTypeID");

                entity.Property(e => e.DeliveryNoteReceiverTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteReceiverTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryNoteReceiverTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteReceiverTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNoteReceiverTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeliveryTypeMaster>(entity =>
            {
                entity.HasKey(e => e.DeliveryTypeId);

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.DeliveryTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DocumentTypes>(entity =>
            {
                entity.HasKey(e => e.DocTypeId);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.DocTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocTypeAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.DocTypeDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocTypeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasKey(e => e.EmailLogFileId);

                entity.Property(e => e.EmailLogFileId).HasColumnName("EmailLogFileID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.EmailLogCcrecipients)
                    .HasColumnName("EmailLogCCRecipients")
                    .IsUnicode(false);

                entity.Property(e => e.EmailLogEmailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLogEmailFromId)
                    .HasColumnName("EmailLogEmailFromID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLogToEmailRecipients).IsUnicode(false);

                entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");

                entity.Property(e => e.EmailTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddedwhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAttachment1).HasMaxLength(100);

                entity.Property(e => e.EmailAttachment2).HasMaxLength(100);

                entity.Property(e => e.EmailAttachment3).HasMaxLength(100);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("EmailCC")
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSentBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSentDate).HasColumnType("datetime");

                entity.Property(e => e.EmailTo).IsUnicode(false);

                entity.Property(e => e.EmailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemAttachment1).HasMaxLength(100);

                entity.Property(e => e.SystemAttachment2).HasMaxLength(100);

                entity.Property(e => e.SystemAttachment3).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Erpconfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId);

                entity.ToTable("ERPConfig");

                entity.Property(e => e.ConfigId).HasColumnName("ConfigID");

                entity.Property(e => e.VariableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VariableType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VariableValue)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FollowUpItemTypeMaster>(entity =>
            {
                entity.Property(e => e.FollowUpItemTypeMasterId).HasColumnName("FollowUpItemTypeMasterID");

                entity.Property(e => e.FollowUpItemTypeMasterAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpItemTypeMasterAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.FollowUpItemTypeMasterName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpItemTypeMasterUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpItemTypeMasterUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<FollowUpItemTypes>(entity =>
            {
                entity.HasKey(e => e.FollowUpItemTypeId);

                entity.Property(e => e.FollowUpItemTypeId).HasColumnName("FollowUpItemTypeID");

                entity.Property(e => e.FollowUpId).HasColumnName("FollowUpID");

                entity.Property(e => e.FollowUpItemTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpItemTypeAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.FollowUpItemTypeMasterId).HasColumnName("FollowUpItemTypeMasterID");

                entity.Property(e => e.FollowUpItemTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpItemTypeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<Followups>(entity =>
            {
                entity.HasKey(e => e.FollowupId);

                entity.Property(e => e.FollowupId).HasColumnName("FollowupID");

                entity.Property(e => e.FollowupAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.FollowupAssignedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupAssignedByUserId).HasColumnName("FollowupAssignedByUserID");

                entity.Property(e => e.FollowupAssignedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupAssignedToSalesPersonId).HasColumnName("FollowupAssignedToSalesPersonID");

                entity.Property(e => e.FollowupContact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupDate).HasColumnType("date");

                entity.Property(e => e.FollowupDetails).HasColumnType("text");

                entity.Property(e => e.FollowupDocFileName).HasMaxLength(150);

                entity.Property(e => e.FollowupDocFileType).HasMaxLength(150);

                entity.Property(e => e.FollowupFor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupRefId).HasColumnName("FollowupRefID");

                entity.Property(e => e.FollowupShortDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.StakeHolderId).HasColumnName("StakeHolderID");
            });

            modelBuilder.Entity<Foreman>(entity =>
            {
                entity.Property(e => e.ForemanId).HasColumnName("ForemanID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ForemanAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForemanAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ForemanName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForemanUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForemanUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FormOfPayments>(entity =>
            {
                entity.HasKey(e => e.Fopid);

                entity.Property(e => e.Fopid).HasColumnName("FOPId");

                entity.Property(e => e.FopaddedBy)
                    .HasColumnName("FOPAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FopaddedWhen)
                    .HasColumnName("FOPAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fopname)
                    .HasColumnName("FOPName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FopupdatedBy)
                    .HasColumnName("FOPUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FopupdatedWhen)
                    .HasColumnName("FOPUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FxingStaffType>(entity =>
            {
                entity.HasKey(e => e.FixingStaffTypeId);

                entity.Property(e => e.FixingStaffTypeId).HasColumnName("FixingStaffTypeID");

                entity.Property(e => e.FixingStaffTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixingStaffTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FixingStaffTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixingStaffTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixingStaffTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.InvDetailId);

                entity.Property(e => e.InvDetailId).HasColumnName("InvDetailID");

                entity.Property(e => e.AllowDiscountId).HasColumnName("AllowDiscountID");

                entity.Property(e => e.InvDetailActualDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvDetailAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.InvDetailAdvtPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailDiscPerItem).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailNetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailNewPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailQty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvDetailTtlDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvDetailUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvDetailUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<InvoiceItemCategory>(entity =>
            {
                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceItemCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InvoiceItemCategoryDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemCategDetailId);

                entity.Property(e => e.InvoiceItemCategDetailId).HasColumnName("InvoiceItemCategDetailID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemAttributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttribAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttribAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttribArtNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AttribBreadth)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribCaliber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AttribExpiryDate).HasColumnType("date");

                entity.Property(e => e.AttribHeight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribLength)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribManufacturersCode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AttribMaxShelfLife)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribMaxTemp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribMinTemp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AttribRemovedQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AttribShade)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AttribTonality).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AttribUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttribUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttribVolume)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttribWeigth)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Mrcid).HasColumnName("MRCID");

                entity.Property(e => e.Srvid).HasColumnName("SRVID");

                entity.Property(e => e.StorageAreaId).HasColumnName("StorageAreaID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemAttributes)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemAttributes_Items");
            });

            modelBuilder.Entity<ItemCategories>(entity =>
            {
                entity.HasKey(e => e.ItemCategId);

                entity.Property(e => e.ItemCategId).HasColumnName("ItemCategID");

                entity.Property(e => e.ItemCategAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemCategCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ItemClassifications>(entity =>
            {
                entity.HasKey(e => e.ItemClassId);

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.CostOfSalesAccountId).HasColumnName("CostOfSalesAccountID");

                entity.Property(e => e.FactoryStockAccountId).HasColumnName("FactoryStockAccountID");

                entity.Property(e => e.GoodsInTransitAccountId).HasColumnName("GoodsInTransitAccountID");

                entity.Property(e => e.GrnrevenueAccountId).HasColumnName("GRNRevenueAccountID");

                entity.Property(e => e.ItemClassAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemClassDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassNonEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemClassUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesRevenueAccountId).HasColumnName("SalesRevenueAccountID");

                entity.Property(e => e.SalesSampleInvoiceAccountId).HasColumnName("SalesSampleInvoiceAccountID");

                entity.Property(e => e.StockAccountId).HasColumnName("StockAccountID");
            });

            modelBuilder.Entity<ItemGroupDetails>(entity =>
            {
                entity.HasKey(e => e.IgdetailId);

                entity.Property(e => e.IgdetailId).HasColumnName("IGDetailID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IgdetailAddedBy)
                    .HasColumnName("IGDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgdetailAddedWhen)
                    .HasColumnName("IGDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IgdetailDesc)
                    .HasColumnName("IGDetailDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IgdetailIsActive).HasColumnName("IGDetailIsActive");

                entity.Property(e => e.IgdetailQty)
                    .HasColumnName("IGDetailQty")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IgdetailUpdatedBy)
                    .HasColumnName("IGDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgdetailUpdatedWhen)
                    .HasColumnName("IGDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ItemGroupDetails)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemGroupDetails_ItemGroups");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemGroupDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemGroupDetails_Items");
            });

            modelBuilder.Entity<ItemGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupAddedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.GroupAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.GroupUpdatedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.GroupUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemImages>(entity =>
            {
                entity.HasKey(e => e.ItemImgId);

                entity.Property(e => e.ItemImgId).HasColumnName("ItemImgID");

                entity.Property(e => e.ImageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImgAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemImgAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemImgDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemImgName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemImgUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemImgUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemPriceLog>(entity =>
            {
                entity.Property(e => e.ItemPriceLogId).HasColumnName("ItemPriceLogID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCostModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemOldCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOldSellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemSellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemSellingPriceModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabourFactor).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.OldLabourFactor).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.OldSellingPriceFactor).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.PricingNewPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PricingOldPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PricingSchemeId).HasColumnName("PricingSchemeID");

                entity.Property(e => e.RawMaterialCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RawMaterialOldCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SellingPriceFactor).HasColumnType("decimal(8, 4)");
            });

            modelBuilder.Entity<ItemPricing>(entity =>
            {
                entity.HasKey(e => e.PricingId);

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.PricingAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricingAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PricingDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PricingFop).HasColumnName("PricingFOP");

                entity.Property(e => e.PricingFrom).HasColumnType("date");

                entity.Property(e => e.PricingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricingPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PricingQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PricingTo).HasColumnType("date");

                entity.Property(e => e.PricingUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricingUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPricing)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemPricing_Items");
            });

            modelBuilder.Entity<ItemProperties>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyId);

                entity.Property(e => e.ItemPropertyId).HasColumnName("ItemPropertyID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemPropertyAddedBy)
                    .HasColumnName("ItemPropertyAddedBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPropertyAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemPropertyModifiedBy)
                    .HasColumnName("ItemPropertyModifiedBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPropertyModifiedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubCategId).HasColumnName("SubCategID");

                entity.HasOne(d => d.SubCateg)
                    .WithMany(p => p.ItemProperties)
                    .HasForeignKey(d => d.SubCategId)
                    .HasConstraintName("FK_ItemProperties_ItemSubCategories");
            });

            modelBuilder.Entity<ItemSetDetails>(entity =>
            {
                entity.HasKey(e => e.IsdetailId);

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.Isactive).HasColumnName("ISActive");

                entity.Property(e => e.IsdetailAddedBy)
                    .HasColumnName("ISDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsdetailAddedWhen)
                    .HasColumnName("ISDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsdetailDesc)
                    .HasColumnName("ISDetailDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsdetailQty)
                    .HasColumnName("ISDetailQty")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IsdetailUpdatedBy)
                    .HasColumnName("ISDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsdetailUpdatedWhen)
                    .HasColumnName("ISDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.ItemSetDetails)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemSetDetails_ItemSets");
            });

            modelBuilder.Entity<ItemSets>(entity =>
            {
                entity.HasKey(e => e.SetId);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SetAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SetCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SetDateFrom).HasColumnType("date");

                entity.Property(e => e.SetDateTo).HasColumnType("date");

                entity.Property(e => e.SetDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SetDescArabic).HasMaxLength(2000);

                entity.Property(e => e.SetName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SetUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemSetsImages>(entity =>
            {
                entity.HasKey(e => e.SetImgId);

                entity.Property(e => e.SetImgId).HasColumnName("SetImgID");

                entity.Property(e => e.ImageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SetImgAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetImgAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SetImgDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SetImgName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetImgUpdateWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SetImgUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.ItemSetsImages)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_ItemSetsImages_ItemSets");
            });

            modelBuilder.Entity<ItemSubCategories>(entity =>
            {
                entity.HasKey(e => e.SubCategId);

                entity.Property(e => e.SubCategId).HasColumnName("SubCategID");

                entity.Property(e => e.ItemCategId).HasColumnName("ItemCategID");

                entity.Property(e => e.SubCategAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubCategIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubCategName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategUpdatedWhen)
                    .HasColumnName("SubCategUpdatedWHen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ItemCateg)
                    .WithMany(p => p.ItemSubCategories)
                    .HasForeignKey(d => d.ItemCategId)
                    .HasConstraintName("FK_ItemSubCategories_ItemCategories1");
            });

            modelBuilder.Entity<ItemSubCategoryItemTypes>(entity =>
            {
                entity.HasKey(e => e.ItemSubCategTypeId);

                entity.Property(e => e.ItemSubCategTypeId).HasColumnName("ItemSubCategTypeID");

                entity.Property(e => e.ItemSubCategTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubCategTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemSubCategTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubCategTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.SubCategId).HasColumnName("SubCategID");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemSubCategoryItemTypes)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_ItemSubCategoryItemTypes_ItemType");

                entity.HasOne(d => d.SubCateg)
                    .WithMany(p => p.ItemSubCategoryItemTypes)
                    .HasForeignKey(d => d.SubCategId)
                    .HasConstraintName("FK_ItemSubCategoryItemTypes_ItemSubCategories");
            });

            modelBuilder.Entity<ItemSubstitutes>(entity =>
            {
                entity.HasKey(e => e.ItemSubId)
                    .HasName("PK_ItemSubtitutes");

                entity.Property(e => e.ItemSubId).HasColumnName("ItemSubID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemSubAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemSubRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubstituteItemId).HasColumnName("SubstituteItemID");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");

                entity.Property(e => e.ItemTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemTypeCategories>(entity =>
            {
                entity.HasKey(e => e.ItemTypeCategId);

                entity.Property(e => e.ItemTypeCategId).HasColumnName("ItemTypeCategID");

                entity.Property(e => e.ItemCategId).HasColumnName("ItemCategID");

                entity.Property(e => e.ItemTypeCategoriesAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeCategoriesAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTypeCategoriesModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeCategoriesModifiedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemCateg)
                    .WithMany(p => p.ItemTypeCategories)
                    .HasForeignKey(d => d.ItemCategId)
                    .HasConstraintName("FK_ItemTypeCategories_ItemCategories");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemTypeCategories)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_ItemTypeCategories_ItemType");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");

                entity.Property(e => e.FixingCommissionCategoryId).HasColumnName("FixingCommissionCategoryID");

                entity.Property(e => e.ItemActualStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemAddedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemArtNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ItemBalanceQtyToIssue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemBalanceQtyToProduce).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemConsumableFactor).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ItemCostModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCriticalLevel).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDefConsumption).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDetDescArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemDetDescEng).HasColumnType("text");

                entity.Property(e => e.ItemEconomicOrder).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemFactoryStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemGoodsInTransitStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemGroundStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemIsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemLabourFactor).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.ItemMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMaxStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMaxTransferQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMaxValidDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMinTransferQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMonthlyDemand).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ItemReOrderLevel).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemReservedStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemRfcode)
                    .HasColumnName("ItemRFCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSaleValidityFrom).HasColumnType("date");

                entity.Property(e => e.ItemSaleValidityTo).HasColumnType("date");

                entity.Property(e => e.ItemSampleStocks).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemSellingPriceFactor).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.ItemSellingPriceModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.ItemUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemYearlyDemand).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RawMaterialCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.CostCentre)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CostCentreId)
                    .HasConstraintName("FK_Items_CostCentre");

                entity.HasOne(d => d.ItemClass)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_Items_ItemClassifications");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_Items_ItemType");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Items_Suppliers");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Items_Units");
            });

            modelBuilder.Entity<LedgerAccounts>(entity =>
            {
                entity.HasKey(e => e.LedgerAccountId);

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.AccountgroupId).HasColumnName("AccountgroupID");

                entity.Property(e => e.LedgerAccountAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerAccountAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LedgerAccountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerAccountUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerAccountUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OpeningBalance).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.OpeningBalanceDate).HasColumnType("date");

                entity.Property(e => e.OpeningBalanceType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubledgerAccountTypeId).HasColumnName("SubledgerAccountTypeID");

                entity.HasOne(d => d.Accountgroup)
                    .WithMany(p => p.LedgerAccounts)
                    .HasForeignKey(d => d.AccountgroupId)
                    .HasConstraintName("FK_LedgerAccounts_AccountGroup");
            });

            modelBuilder.Entity<LedgerSubAccounts>(entity =>
            {
                entity.HasKey(e => e.LedgerSubAccountId);

                entity.Property(e => e.LedgerSubAccountId).HasColumnName("LedgerSubAccountID");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.LedgerSubAccountAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerSubAccountAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LedgerSubAccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerSubAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerSubAccountUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerSubAccountUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LocationCharges>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LocationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MailSettingMaster>(entity =>
            {
                entity.HasKey(e => e.MailSettingId);

                entity.Property(e => e.MailSettingId).HasColumnName("MailSettingID");

                entity.Property(e => e.MailBodyMain).HasColumnType("text");

                entity.Property(e => e.MailFromEmailId).HasColumnName("MailFromEmailID");

                entity.Property(e => e.MailReceiversMailId)
                    .HasColumnName("MailReceiversMailID")
                    .HasColumnType("text");

                entity.Property(e => e.MailSettingAddedBy).HasMaxLength(50);

                entity.Property(e => e.MailSettingAddedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemitemsIssued>(entity =>
            {
                entity.HasKey(e => e.MemitemIssuedId)
                    .HasName("PK_MEMItemIssued");

                entity.ToTable("MEMItemsIssued");

                entity.Property(e => e.MemitemIssuedId).HasColumnName("MEMItemIssuedID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.BaseUnitQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescriptionArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImgId).HasColumnName("ItemImgID");

                entity.Property(e => e.Memid).HasColumnName("MEMId");

                entity.Property(e => e.MemitemIssuedActualQty)
                    .HasColumnName("MEMItemIssuedActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemitemIssuedAddedBy)
                    .HasColumnName("MEMItemIssuedAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemitemIssuedAddedWhen)
                    .HasColumnName("MEMItemIssuedAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemitemIssuedDiscountAmount)
                    .HasColumnName("MEMItemIssuedDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemitemIssuedDiscountPercentage)
                    .HasColumnName("MEMItemIssuedDiscountPercentage")
                    .HasColumnType("decimal(19, 15)");

                entity.Property(e => e.MemitemIssuedItemCost)
                    .HasColumnName("MEMItemIssuedItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MemitemIssuedItemPrice)
                    .HasColumnName("MEMItemIssuedItemPrice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MemitemIssuedNetAmount)
                    .HasColumnName("MEMItemIssuedNetAmount")
                    .HasColumnType("decimal(30, 15)");

                entity.Property(e => e.MemitemIssuedNetRate)
                    .HasColumnName("MEMItemIssuedNetRate")
                    .HasColumnType("decimal(30, 15)");

                entity.Property(e => e.MemitemIssuedQty)
                    .HasColumnName("MEMItemIssuedQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemitemIssuedSerialNo).HasColumnName("MEMItemIssuedSerialNo");

                entity.Property(e => e.MemitemIssuedSetQty)
                    .HasColumnName("MEMItemIssuedSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemitemIssuedUnitPrice)
                    .HasColumnName("MEMItemIssuedUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemitemIssuedUpdatedBy)
                    .HasColumnName("MEMItemIssuedUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemitemIssuedUpdatedWhen)
                    .HasColumnName("MEMItemIssuedUpdatedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.MemitemsIssued)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_MEMItemsIssued_Items");

                entity.HasOne(d => d.Mem)
                    .WithMany(p => p.MemitemsIssued)
                    .HasForeignKey(d => d.Memid)
                    .HasConstraintName("FK_MEMItemsIssued_MEMMaster");
            });

            modelBuilder.Entity<Memmaster>(entity =>
            {
                entity.HasKey(e => e.Memid)
                    .HasName("PK_MaterialExchangeMemoMaster");

                entity.ToTable("MEMMaster");

                entity.Property(e => e.Memid).HasColumnName("MEMId");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.MemaddedBy)
                    .HasColumnName("MEMAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemaddedWhen)
                    .HasColumnName("MEMAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembankCharge)
                    .HasColumnName("MEMBankCharge")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Memcode)
                    .HasColumnName("MEMCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Memdate)
                    .HasColumnName("MEMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemisPrinted).HasColumnName("MEMIsPrinted");

                entity.Property(e => e.Memreason)
                    .HasColumnName("MEMReason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Memremarks)
                    .HasColumnName("MEMRemarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Memstatus)
                    .HasColumnName("MEMStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MemtotalAmountIssued)
                    .HasColumnName("MEMTotalAmountIssued")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemtotalDeliveryCharge)
                    .HasColumnName("MEMTotalDeliveryCharge")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemtotalDiscountAmountIssued)
                    .HasColumnName("MEMTotalDiscountAmountIssued")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemtotalDiscountPercentageIssued)
                    .HasColumnName("MEMTotalDiscountPercentageIssued")
                    .HasColumnType("decimal(20, 15)");

                entity.Property(e => e.MemtotalFixingCharge)
                    .HasColumnName("MEMTotalFixingCharge")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemtotalNetAmountIssued)
                    .HasColumnName("MEMTotalNetAmountIssued")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MemtotalReturnedAmount)
                    .HasColumnName("MEMTotalReturnedAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Memtype).HasColumnName("MEMType");

                entity.Property(e => e.MemupdatedBy)
                    .HasColumnName("MEMUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemupdatedWhen)
                    .HasColumnName("MEMUpdatedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.Sivid).HasColumnName("SIVId");

                entity.Property(e => e.Srcid).HasColumnName("SRCId");

                entity.HasOne(d => d.Siv)
                    .WithMany(p => p.Memmaster)
                    .HasForeignKey(d => d.Sivid)
                    .HasConstraintName("FK_MEMMaster_StoreIssueVoucherMaster");

                entity.HasOne(d => d.Src)
                    .WithMany(p => p.Memmaster)
                    .HasForeignKey(d => d.Srcid)
                    .HasConstraintName("FK_MEMMaster_SalesReturnConfirmationMaster");
            });

            modelBuilder.Entity<ProjectDocuments>(entity =>
            {
                entity.HasKey(e => e.PrjDocId);

                entity.Property(e => e.PrjDocId).HasColumnName("PrjDocID");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.PrjDocAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjDocAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrjDocDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrjDocFileName).HasMaxLength(100);

                entity.Property(e => e.PrjDocFileType).HasMaxLength(50);

                entity.Property(e => e.PrjDocName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjDocUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjDocUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDocuments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectDocuments_Projects");
            });

            modelBuilder.Entity<ProjectHistory>(entity =>
            {
                entity.Property(e => e.ProjectHistoryId).HasColumnName("ProjectHistoryID");

                entity.Property(e => e.ProjectHistoryAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectHistoryAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectHistoryChanges).IsUnicode(false);

                entity.Property(e => e.ProjectHistoryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectHistoryTableId).HasColumnName("ProjectHistoryTableID");

                entity.Property(e => e.ProjectHistoryTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectHistoryUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectHistoryUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<ProjectSiteDetails>(entity =>
            {
                entity.HasKey(e => e.ProjectSiteId);

                entity.Property(e => e.ProjectSiteId).HasColumnName("ProjectSiteID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectSiteAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectSiteAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSitePobox)
                    .HasColumnName("ProjectSitePOBox")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteStreet)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectSiteUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectStakeHolderType>(entity =>
            {
                entity.HasKey(e => e.StakeHolderTypeId);

                entity.Property(e => e.StakeHolderTypeId).HasColumnName("StakeHolderTypeID");

                entity.Property(e => e.StakeHolderTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StakeHolderTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StakeHolderTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StakeHolderTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StakeHolderTypeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectStakeHolders>(entity =>
            {
                entity.HasKey(e => e.ProjectStakeHolderId);

                entity.Property(e => e.ProjectStakeHolderId).HasColumnName("ProjectStakeHolderID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectStakeHolderAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectStakeHolderEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderRemarks).IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStakeHolderUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StakeHolderTypeId).HasColumnName("StakeHolderTypeID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectStakeHolders)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectStakeHolders_Projects");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.ProjectTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ContactAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectActionDeadLine).HasColumnType("date");

                entity.Property(e => e.ProjectAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCompletionDate).HasColumnType("date");

                entity.Property(e => e.ProjectDate).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNotes).IsUnicode(false);

                entity.Property(e => e.ProjectOthers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectReferenceDate).HasColumnType("date");

                entity.Property(e => e.ProjectStartDate).HasColumnType("date");

                entity.Property(e => e.ProjectSupervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.ProjectUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Projects_CustomerMaster");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.DefaultUserId).HasColumnName("DefaultUserID");

                entity.Property(e => e.RoleAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleParentId).HasColumnName("RoleParentID");

                entity.Property(e => e.RoleUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RolesInfo>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.AppId).HasColumnName("app_id");

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleStatus).HasColumnName("role_status");
            });

            modelBuilder.Entity<SalesCashInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.SlcashInvoiceDetailId)
                    .HasName("PK_SalesCashInvoiceItems");

                entity.Property(e => e.SlcashInvoiceDetailId).HasColumnName("SLCashInvoiceDetailID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStockAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemCostAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescription).IsUnicode(false);

                entity.Property(e => e.ItemDescriptionArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SlcashInvoiceDetailAddedBy)
                    .HasColumnName("SLCashInvoiceDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlcashInvoiceDetailAddedWhen)
                    .HasColumnName("SLCashInvoiceDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SlcashInvoiceDetailItemActualQty)
                    .HasColumnName("SLCashInvoiceDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemAvailableQty)
                    .HasColumnName("SLCashInvoiceDetailItemAvailableQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemBaseUnitQty)
                    .HasColumnName("SLCashInvoiceDetailItemBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemCost)
                    .HasColumnName("SLCashInvoiceDetailItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SlcashInvoiceDetailItemDiscountAmount)
                    .HasColumnName("SLCashInvoiceDetailItemDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemDiscountPercentage)
                    .HasColumnName("SLCashInvoiceDetailItemDiscountPercentage")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemLabourFactor)
                    .HasColumnName("SLCashInvoiceDetailItemLabourFactor")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemNetAmount)
                    .HasColumnName("SLCashInvoiceDetailItemNetAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemPrice)
                    .HasColumnName("SLCashInvoiceDetailItemPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemQty)
                    .HasColumnName("SLCashInvoiceDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailItemSetQty)
                    .HasColumnName("SLCashInvoiceDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailSerialNo).HasColumnName("SLCashInvoiceDetailSerialNo");

                entity.Property(e => e.SlcashInvoiceDetailUnitPrice)
                    .HasColumnName("SLCashInvoiceDetailUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcashInvoiceDetailUpdatedBy)
                    .HasColumnName("SLCashInvoiceDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlcashInvoiceDetailUpdatedWhen)
                    .HasColumnName("SLCashInvoiceDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesCashInvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesCashInvoiceDetails_Items");
            });

            modelBuilder.Entity<SalesCashInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.SalesCashInvoiceId)
                    .HasName("PK_SalesInvoiceMaster");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRepresentative)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingChargeReceiptId).HasColumnName("DrawingChargeReceiptID");

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.PaymentTermsDueDate).HasColumnType("date");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesCashInvoiceAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesCashInvoiceBankCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceCancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCashInvoiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCashInvoiceDeliveryCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceDeliveryDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceDrawingChargeDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceFixingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceFixingDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCashInvoiceJobSize).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SalesCashInvoiceNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceNotes).IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceRetentionDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCashInvoiceRetentionPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SalesCashInvoiceTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceTaxPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesCashInvoiceTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCashInvoiceTotalDiscountPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesCashInvoiceTotalNoOfSiv).HasColumnName("SalesCashInvoiceTotalNoOfSIV");

                entity.Property(e => e.SalesCashInvoiceUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCashInvoiceUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesInvoiceDiscountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceFileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceNoOfUnits).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.HasOne(d => d.CashCustomer)
                    .WithMany(p => p.SalesCashInvoiceMaster)
                    .HasForeignKey(d => d.CashCustomerId)
                    .HasConstraintName("FK_SalesCashInvoiceMaster_CashCustomer");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesCashInvoiceMaster)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_SalesCashInvoiceMaster_SalesPersons");
            });

            modelBuilder.Entity<SalesContractDocuments>(entity =>
            {
                entity.HasKey(e => e.ScdocId);

                entity.Property(e => e.ScdocId).HasColumnName("SCDocID");

                entity.Property(e => e.ScdocAddedBy)
                    .HasColumnName("SCDocAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdocAddedWhen)
                    .HasColumnName("SCDocAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScdocFileName)
                    .HasColumnName("SCDocFileName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScdocFileType)
                    .IsRequired()
                    .HasColumnName("SCDocFileType")
                    .HasMaxLength(50);

                entity.Property(e => e.ScdocIsActive).HasColumnName("SCDocIsActive");

                entity.Property(e => e.ScdocName)
                    .HasColumnName("SCDocName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScdocRemarks)
                    .HasColumnName("SCDocRemarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ScdocTypeId).HasColumnName("SCDocTypeID");

                entity.Property(e => e.ScdocUpdatedBy)
                    .HasColumnName("SCDocUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdocUpdatedWhen)
                    .HasColumnName("SCDocUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Scid).HasColumnName("SCID");
            });

            modelBuilder.Entity<SalesContractDoorDetails>(entity =>
            {
                entity.HasKey(e => e.SalesContractDoorDetailId);

                entity.Property(e => e.SalesContractDoorDetailId).HasColumnName("SalesContractDoorDetailID");

                entity.Property(e => e.SalesContractAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesContractUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.ScdoorArchitrave)
                    .HasColumnName("SCDoorArchitrave")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorCategory)
                    .HasColumnName("SCDoorCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorColor)
                    .HasColumnName("SCDoorColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorDesignCode)
                    .HasColumnName("SCDoorDesignCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorFireratedMinutes)
                    .HasColumnName("SCDoorFireratedMinutes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorFrame)
                    .HasColumnName("SCDoorFrame")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorHandleCode)
                    .HasColumnName("SCDoorHandleCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorHasArchitrave).HasColumnName("SCDoorHasArchitrave");

                entity.Property(e => e.ScdoorHasFrame).HasColumnName("SCDoorHasFrame");

                entity.Property(e => e.ScdoorHasShutter).HasColumnName("SCDoorHasShutter");

                entity.Property(e => e.ScdoorHingesColor)
                    .HasColumnName("SCDoorHingesColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorLockCode)
                    .HasColumnName("SCDoorLockCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorOtherDetails)
                    .HasColumnName("SCDoorOtherDetails")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ScdoorOtherDetailsArabic)
                    .HasColumnName("SCDoorOtherDetailsArabic")
                    .HasMaxLength(150);

                entity.Property(e => e.ScdoorQty)
                    .HasColumnName("SCDoorQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ScdoorType)
                    .HasColumnName("SCDoorType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SalesContract)
                    .WithMany(p => p.SalesContractDoorDetails)
                    .HasForeignKey(d => d.SalesContractId)
                    .HasConstraintName("FK_SalesContractDoorDetails_SalesContractMaster");
            });

            modelBuilder.Entity<SalesContractKitchenAccessories>(entity =>
            {
                entity.HasKey(e => e.SalesContractAccessoryId);

                entity.Property(e => e.SalesContractAccessoryId).HasColumnName("SalesContractAccessoryID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesContractKitchenDetailId).HasColumnName("SalesContractKitchenDetailID");

                entity.Property(e => e.ScaccessoryAddedBy)
                    .HasColumnName("SCAccessoryAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScaccessoryAddedWhen)
                    .HasColumnName("SCAccessoryAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScaccessoryApplianceCode)
                    .HasColumnName("SCAccessoryApplianceCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScaccessoryApplianceQty)
                    .HasColumnName("SCAccessoryApplianceQty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScaccessoryApplianceTypeId).HasColumnName("SCAccessoryApplianceTypeID");

                entity.Property(e => e.ScaccessoryApplianceTypeName)
                    .HasColumnName("SCAccessoryApplianceTypeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScaccessoryType)
                    .HasColumnName("SCAccessoryType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScaccessoryUpdatedBy)
                    .HasColumnName("SCAccessoryUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScaccessoryUpdatedWhen)
                    .HasColumnName("SCAccessoryUpdatedWhen")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SalesContract)
                    .WithMany(p => p.SalesContractKitchenAccessories)
                    .HasForeignKey(d => d.SalesContractId)
                    .HasConstraintName("FK_SalesContractKitchenAccessories_SalesContractMaster");

                entity.HasOne(d => d.SalesContractKitchenDetail)
                    .WithMany(p => p.SalesContractKitchenAccessories)
                    .HasForeignKey(d => d.SalesContractKitchenDetailId)
                    .HasConstraintName("FK_SalesContractKitchenAccessories_SalesContractKitchenDetails");
            });

            modelBuilder.Entity<SalesContractKitchenDetails>(entity =>
            {
                entity.HasKey(e => e.SalesContractKitchenDetailId)
                    .HasName("PK_SCKDetails");

                entity.Property(e => e.SalesContractKitchenDetailId).HasColumnName("SalesContractKitchenDetailID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SckdetailAddedBy)
                    .HasColumnName("SCKDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailAddedWhen)
                    .HasColumnName("SCKDetailAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SckdetailCarcaseColor)
                    .HasColumnName("SCKDetailCarcaseColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailCarcaseIsColor).HasColumnName("SCKDetailCarcaseIsColor");

                entity.Property(e => e.SckdetailCarcaseIsWhite).HasColumnName("SCKDetailCarcaseIsWhite");

                entity.Property(e => e.SckdetailColCodes)
                    .HasColumnName("SCKDetailColCodes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailColMoonstoneColor)
                    .HasColumnName("SCKDetailColMoonstoneColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailCorniceIsBottom).HasColumnName("SCKDetailCorniceIsBottom");

                entity.Property(e => e.SckdetailCorniceIsTop).HasColumnName("SCKDetailCorniceIsTop");

                entity.Property(e => e.SckdetailCorniceIsTopBox).HasColumnName("SCKDetailCorniceIsTopBox");

                entity.Property(e => e.SckdetailCorniceIsWithOut).HasColumnName("SCKDetailCorniceIsWithOut");

                entity.Property(e => e.SckdetailDesign)
                    .HasColumnName("SCKDetailDesign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailDoorColor)
                    .HasColumnName("SCKDetailDoorColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailHandleCodes)
                    .HasColumnName("SCKDetailHandleCodes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailIsColMoonstone).HasColumnName("SCKDetailIsColMoonstone");

                entity.Property(e => e.SckdetailIsColStSteel).HasColumnName("SCKDetailIsColStSteel");

                entity.Property(e => e.SckdetailIsSinkDouble).HasColumnName("SCKDetailIsSinkDouble");

                entity.Property(e => e.SckdetailIsSinkMoonstone).HasColumnName("SCKDetailIsSinkMoonstone");

                entity.Property(e => e.SckdetailIsSinkSingle).HasColumnName("SCKDetailIsSinkSingle");

                entity.Property(e => e.SckdetailIsSinkStSteel).HasColumnName("SCKDetailIsSinkStSteel");

                entity.Property(e => e.SckdetailMixerCodes)
                    .HasColumnName("SCKDetailMixerCodes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailQty)
                    .HasColumnName("SCKDetailQty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SckdetailSinkCodes)
                    .HasColumnName("SCKDetailSinkCodes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailSinkMoonstoneColor)
                    .HasColumnName("SCKDetailSinkMoonstoneColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailSkirtingEndIsWout).HasColumnName("SCKDetailSkirtingEndIsWout");

                entity.Property(e => e.SckdetailSkirtingIsArtMarble).HasColumnName("SCKDetailSkirtingIsArtMarble");

                entity.Property(e => e.SckdetailSkirtingIsEndBaseEndWall).HasColumnName("SCKDetailSkirtingIsEndBaseEndWall");

                entity.Property(e => e.SckdetailSkirtingIsGlassType).HasColumnName("SCKDetailSkirtingIsGlassType");

                entity.Property(e => e.SckdetailSkirtingIsMoonstone).HasColumnName("SCKDetailSkirtingIsMoonstone");

                entity.Property(e => e.SckdetailSkirtingIsPlasticPlinth).HasColumnName("SCKDetailSkirtingIsPlasticPlinth");

                entity.Property(e => e.SckdetailSkirtingIsStsteel).HasColumnName("SCKDetailSkirtingIsSTSteel");

                entity.Property(e => e.SckdetailSkirtingIsWithOut).HasColumnName("SCKDetailSkirtingIsWithOut");

                entity.Property(e => e.SckdetailSkirtingIsWithRail).HasColumnName("SCKDetailSkirtingIsWithRail");

                entity.Property(e => e.SckdetailSkirtingIsWoutRail).HasColumnName("SCKDetailSkirtingIsWoutRail");

                entity.Property(e => e.SckdetailSkirtingMoonstoneColor)
                    .HasColumnName("SCKDetailSkirtingMoonstoneColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailSkirtingStsteelHeight)
                    .HasColumnName("SCKDetailSkirtingSTSteelHeight")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailSkirtingWithRailColor)
                    .HasColumnName("SCKDetailSkirtingWithRailColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailType)
                    .HasColumnName("SCKDetailType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailUpdatedBy)
                    .HasColumnName("SCKDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailUpdatedWhen)
                    .HasColumnName("SCKDetailUpdatedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SckdetailWorktopColor)
                    .HasColumnName("SCKDetailWorktopColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckdetailWorktopIsWithOut).HasColumnName("SCKDetailWorktopIsWithOut");

                entity.Property(e => e.SckdetailWorktopType)
                    .HasColumnName("SCKDetailWorktopType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SckitchenAccessoryDetails)
                    .HasColumnName("SCKitchenAccessoryDetails")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SckitchenAccessoryDetailsArabic)
                    .HasColumnName("SCKitchenAccessoryDetailsArabic")
                    .HasMaxLength(500);

                entity.Property(e => e.SckitchenOtherDetails)
                    .HasColumnName("SCKitchenOtherDetails")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SckitchenOtherDetailsArabic)
                    .HasColumnName("SCKitchenOtherDetailsArabic")
                    .HasMaxLength(500);

                entity.HasOne(d => d.SalesContract)
                    .WithMany(p => p.SalesContractKitchenDetails)
                    .HasForeignKey(d => d.SalesContractId)
                    .HasConstraintName("FK_SCKDetails_SalesContractMaster");
            });

            modelBuilder.Entity<SalesContractMaster>(entity =>
            {
                entity.HasKey(e => e.SalesContractId);

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesContractAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.SalesContractCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustComputerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustCrno)
                    .HasColumnName("SalesContractCustCRNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerAddressArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractCustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerFaxNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerMobNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerNameArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractCustomerRepresentedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerRepresentedByArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractCustomerRepresentiveMobNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractCustomerTelNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractDate).HasColumnType("date");

                entity.Property(e => e.SalesContractDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractDescriptionArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractGenerateDate).HasColumnType("date");

                entity.Property(e => e.SalesContractNabinaRepresentedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractNabinaRepresentedByArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractPurposeLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPurposeLocationArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractPurposeLocationQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesContractPurposeProductFor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPurposeProductForArabic).HasMaxLength(500);

                entity.Property(e => e.SalesContractQuotationAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesContractQuotationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractQuotationDate).HasColumnType("date");

                entity.Property(e => e.SalesContractSalesPersonId).HasColumnName("SalesContractSalesPersonID");

                entity.Property(e => e.SalesContractSiteReadinessDate).HasColumnType("date");

                entity.Property(e => e.SalesContractUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesContractPaymentTerms>(entity =>
            {
                entity.HasKey(e => e.SalesContractPaymentTermId);

                entity.Property(e => e.SalesContractPaymentTermId).HasColumnName("SalesContractPaymentTermID");

                entity.Property(e => e.SalesContractPaymentTermAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentTermAddedWhen).HasColumnType("date");

                entity.Property(e => e.SalesContractPaymentTermName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentTermNameArabic).HasMaxLength(50);

                entity.Property(e => e.SalesContractPaymentTermUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentTermUpdatedWhen).HasColumnType("date");
            });

            modelBuilder.Entity<SalesContractPaymentType>(entity =>
            {
                entity.Property(e => e.SalesContractPaymentTypeId).HasColumnName("SalesContractPaymentTypeID");

                entity.Property(e => e.SalesContractPaymentAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentAddedWhen).HasColumnType("date");

                entity.Property(e => e.SalesContractPaymentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentTypeNameArabic).HasMaxLength(100);

                entity.Property(e => e.SalesContractPaymentUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentUpdatedWhen).HasColumnType("date");
            });

            modelBuilder.Entity<SalesContractPayments>(entity =>
            {
                entity.HasKey(e => e.SalesContractPaymentId);

                entity.Property(e => e.SalesContractPaymentId).HasColumnName("SalesContractPaymentID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesContractPaymentAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentAddedWhen).HasColumnType("date");

                entity.Property(e => e.SalesContractPaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesContractPaymentChequeDate).HasColumnType("date");

                entity.Property(e => e.SalesContractPaymentDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentPercentageOfTotalAmount).HasColumnType("decimal(18, 14)");

                entity.Property(e => e.SalesContractPaymentTermId).HasColumnName("SalesContractPaymentTermID");

                entity.Property(e => e.SalesContractPaymentTypeId).HasColumnName("SalesContractPaymentTypeID");

                entity.Property(e => e.SalesContractPaymentUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractPaymentUpdatedWhen).HasColumnType("date");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            });

            modelBuilder.Entity<SalesContractProductDetails>(entity =>
            {
                entity.HasKey(e => e.SalesContractProductDetailId);

                entity.Property(e => e.SalesContractProductDetailId).HasColumnName("SalesContractProductDetailID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesContractProductAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractProductAddedWhen)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesContractProductDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractProductLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractProductQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesContractProductUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesContractProductUpdatedWhen)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SalesContract)
                    .WithMany(p => p.SalesContractProductDetails)
                    .HasForeignKey(d => d.SalesContractId)
                    .HasConstraintName("FK_SalesContractProductDetails_SalesContractMaster");
            });

            modelBuilder.Entity<SalesContractWardrobeDetails>(entity =>
            {
                entity.HasKey(e => e.SalesContractWardrobeDetailId);

                entity.Property(e => e.SalesContractWardrobeDetailId).HasColumnName("SalesContractWardrobeDetailID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.ScwaddedBy)
                    .HasColumnName("SCWAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwaddedWhen)
                    .HasColumnName("SCWAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScwadditionalAccessoryDetails)
                    .HasColumnName("SCWAdditionalAccessoryDetails")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwcarcaseColor)
                    .HasColumnName("SCWCarcaseColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwcorniceIsTop).HasColumnName("SCWCorniceIsTop");

                entity.Property(e => e.ScwdesignIsMilano).HasColumnName("SCWDesignIsMilano");

                entity.Property(e => e.ScwdesignIsPlain).HasColumnName("SCWDesignIsPlain");

                entity.Property(e => e.ScwdoorColor)
                    .HasColumnName("SCWDoorColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwdoorIsGlassDoor).HasColumnName("SCWDoorIsGlassDoor");

                entity.Property(e => e.ScwdoorIsMixed).HasColumnName("SCWDoorIsMixed");

                entity.Property(e => e.ScwdoorIsWithMirror).HasColumnName("SCWDoorIsWithMirror");

                entity.Property(e => e.ScwdoorIsWithOutMirror).HasColumnName("SCWDoorIsWithOutMirror");

                entity.Property(e => e.ScwdressingTableQty)
                    .HasColumnName("SCWDressingTableQty")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ScwextraShelfQty)
                    .HasColumnName("SCWExtraShelfQty")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Scwhandle)
                    .HasColumnName("SCWHandle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwisWithAdditionalAccessories).HasColumnName("SCWIsWithAdditionalAccessories");

                entity.Property(e => e.ScwisWithDressingTable).HasColumnName("SCWIsWithDressingTable");

                entity.Property(e => e.ScwisWithExtraShelves).HasColumnName("SCWIsWithExtraShelves");

                entity.Property(e => e.ScwisWithHanger).HasColumnName("SCWIsWithHanger");

                entity.Property(e => e.ScwisWithOutCornice).HasColumnName("SCWIsWithOutCornice");

                entity.Property(e => e.ScwisWithShoeRack).HasColumnName("SCWIsWithShoeRack");

                entity.Property(e => e.ScwmodelIsNormal).HasColumnName("SCWModelIsNormal");

                entity.Property(e => e.ScwmodelIsSliding).HasColumnName("SCWModelIsSliding");

                entity.Property(e => e.ScwremarksOne)
                    .HasColumnName("SCWRemarksOne")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScwremarksTwo)
                    .HasColumnName("SCWRemarksTwo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Scwskirting)
                    .HasColumnName("SCWSkirting")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwtypeIsCliff).HasColumnName("SCWTypeIsCliff");

                entity.Property(e => e.ScwtypeIsPvc).HasColumnName("SCWTypeIsPVC");

                entity.Property(e => e.ScwupdatedBy)
                    .HasColumnName("SCWUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScwupdatedWhen)
                    .HasColumnName("SCWUpdatedWhen")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SalesContract)
                    .WithMany(p => p.SalesContractWardrobeDetails)
                    .HasForeignKey(d => d.SalesContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesContractWardrobeDetails_SalesContractMaster");
            });

            modelBuilder.Entity<SalesCreditInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.SlcreditInvoiceDetailId)
                    .HasName("PK_SalesCreditInvoiceItems");

                entity.Property(e => e.SlcreditInvoiceDetailId).HasColumnName("SLCreditInvoiceDetailID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStockAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemCostAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescription).IsUnicode(false);

                entity.Property(e => e.ItemDescriptionArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SlcreditInvoiceDetailAddedBy)
                    .HasColumnName("SLCreditInvoiceDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlcreditInvoiceDetailAddedWhen)
                    .HasColumnName("SLCreditInvoiceDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SlcreditInvoiceDetailItemActualQty)
                    .HasColumnName("SLCreditInvoiceDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemAvailableQty)
                    .HasColumnName("SLCreditInvoiceDetailItemAvailableQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemBaseUnitQty)
                    .HasColumnName("SLCreditInvoiceDetailItemBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemCost)
                    .HasColumnName("SLCreditInvoiceDetailItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SlcreditInvoiceDetailItemDiscountAmount)
                    .HasColumnName("SLCreditInvoiceDetailItemDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemDiscountPercentage)
                    .HasColumnName("SLCreditInvoiceDetailItemDiscountPercentage")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemLabourFactor)
                    .HasColumnName("SLCreditInvoiceDetailItemLabourFactor")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemNetAmount)
                    .HasColumnName("SLCreditInvoiceDetailItemNetAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemPrice)
                    .HasColumnName("SLCreditInvoiceDetailItemPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemQty)
                    .HasColumnName("SLCreditInvoiceDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailItemSetQty)
                    .HasColumnName("SLCreditInvoiceDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailSerialNo).HasColumnName("SLCreditInvoiceDetailSerialNo");

                entity.Property(e => e.SlcreditInvoiceDetailUnitPrice)
                    .HasColumnName("SLCreditInvoiceDetailUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlcreditInvoiceDetailUpdatedBy)
                    .HasColumnName("SLCreditInvoiceDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlcreditInvoiceDetailUpdatedWhen)
                    .HasColumnName("SLCreditInvoiceDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<SalesCreditInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.SalesCreditInvoiceId);

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRepresentative)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingChargeReceiptId).HasColumnName("DrawingChargeReceiptID");

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.PaymentTermsDueDate).HasColumnType("date");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesCreditInvoiceAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesCreditInvoiceBankCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceCancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCreditInvoiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCreditInvoiceDeliveryCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceDeliveryDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceDrawingChargeDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceFixingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceFixingDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCreditInvoiceGeneratedDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCreditInvoiceJobSize).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SalesCreditInvoiceNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceNotes).IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceRetentionDate).HasColumnType("datetime");

                entity.Property(e => e.SalesCreditInvoiceRetentionPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SalesCreditInvoiceTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceTaxPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesCreditInvoiceTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesCreditInvoiceTotalDiscountPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesCreditInvoiceTotalNoOfSiv).HasColumnName("SalesCreditInvoiceTotalNoOfSIV");

                entity.Property(e => e.SalesCreditInvoiceUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditInvoiceUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesInvoiceDiscountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceFileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceNoOfUnits).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesCreditInvoiceMaster)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_SalesCreditInvoiceMaster_SalesPersons");
            });

            modelBuilder.Entity<SalesDeliveryTerms>(entity =>
            {
                entity.HasKey(e => e.DeliveryTermsId);

                entity.Property(e => e.DeliveryTermsId).HasColumnName("DeliveryTermsID");

                entity.Property(e => e.DeliveryTermsAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTermsAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTermsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTermsUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTermsUpdatedWhen).HasMaxLength(10);
            });

            modelBuilder.Entity<SalesDeliveryTime>(entity =>
            {
                entity.HasKey(e => e.DeliveryTimeId);

                entity.Property(e => e.DeliveryTimeId).HasColumnName("DeliveryTimeID");

                entity.Property(e => e.DeliveryTimeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTimeAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTimeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTimeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTimeUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesGroup>(entity =>
            {
                entity.Property(e => e.SalesGroupId).HasColumnName("SalesGroupID");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.SalesGroupAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroupAddedWhen).HasColumnType("date");

                entity.Property(e => e.SalesGroupCanEdit).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesGroupDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroupMaxDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroupUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroupUpdatedWhen).HasColumnType("date");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SalesGroup)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SalesGroup_RolesInfo");
            });

            modelBuilder.Entity<SalesGroupDiscount>(entity =>
            {
                entity.HasKey(e => e.GroupDisId);

                entity.Property(e => e.GroupDisId).HasColumnName("GroupDisID");

                entity.Property(e => e.GroupDisAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDisAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupDisAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GroupDisNotes).IsUnicode(false);

                entity.Property(e => e.GroupDisUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDisUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupDisValidFrom).HasColumnType("date");

                entity.Property(e => e.GroupDisValidTo).HasColumnType("date");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.SalesGroupId).HasColumnName("SalesGroupID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.GroupDisDefinedNavigation)
                    .WithMany(p => p.SalesGroupDiscount)
                    .HasForeignKey(d => d.GroupDisDefined)
                    .HasConstraintName("FK_SalesGroupDiscount_SalesGroupDiscountDefinedFor");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.SalesGroupDiscount)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_SalesGroupDiscount_ItemType");

                entity.HasOne(d => d.SalesGroup)
                    .WithMany(p => p.SalesGroupDiscount)
                    .HasForeignKey(d => d.SalesGroupId)
                    .HasConstraintName("FK_SalesGroupDiscount_SalesGroup");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SalesGroupDiscount)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SalesGroupDiscount_Suppliers");
            });

            modelBuilder.Entity<SalesGroupDiscountDefinedFor>(entity =>
            {
                entity.HasKey(e => e.DefinedForId);

                entity.Property(e => e.DefinedForId).HasColumnName("DefinedForID");

                entity.Property(e => e.DefinedForName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesInvoiceDocuments>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDocId);

                entity.Property(e => e.SalesInvoiceDocId).HasColumnName("SalesInvoiceDocID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesInvoiceDocAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceDocAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesInvoiceDocDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceDocFileName).HasMaxLength(100);

                entity.Property(e => e.SalesInvoiceDocFileType).HasMaxLength(50);

                entity.Property(e => e.SalesInvoiceDocName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceDocType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceDocUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceDocUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");
            });

            modelBuilder.Entity<SalesInvoicePayments>(entity =>
            {
                entity.HasKey(e => e.InvPaymentId);

                entity.Property(e => e.InvPaymentId).HasColumnName("InvPaymentID");

                entity.Property(e => e.CardsId).HasColumnName("CardsID");

                entity.Property(e => e.InvPaymentAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvPaymentAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvPaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvPaymentBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvPaymentDocumentDate).HasColumnType("date");

                entity.Property(e => e.InvPaymentDocumentNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvPaymentUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvPaymentUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PdtypeId).HasColumnName("PDTypeID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");
            });

            modelBuilder.Entity<SalesInvoiceTerms>(entity =>
            {
                entity.HasKey(e => e.InvTermId);

                entity.Property(e => e.InvTermId).HasColumnName("InvTermID");

                entity.Property(e => e.InvTermAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvTermAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.InvTermUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvTermUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.InvTermsTypeId).HasColumnName("InvTermsTypeID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.TermsId).HasColumnName("TermsID");
            });

            modelBuilder.Entity<SalesInvoiceTmpSiv>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceTmpSivdetailId);

                entity.ToTable("SalesInvoiceTmpSIV");

                entity.Property(e => e.SalesInvoiceTmpSivdetailId).HasColumnName("SalesInvoiceTmpSIVDetailID");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesInvoiceTmpDeliveryContactNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTmpDeliveryContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTmpDeliveryLoc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTmpSivdetailAddedBy)
                    .HasColumnName("SalesInvoiceTmpSIVDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTmpSivdetailAddedWhen)
                    .HasColumnName("SalesInvoiceTmpSIVDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesInvoiceTmpSivdetailQty)
                    .HasColumnName("SalesInvoiceTmpSIVDetailQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesInvoiceTmpSivdetailSerialNo).HasColumnName("SalesInvoiceTmpSIVDetailSerialNo");

                entity.Property(e => e.SalesInvoiceTmpSivdetailUpdatedBy)
                    .HasColumnName("SalesInvoiceTmpSIVDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTmpSivdetailUpdatedWhen)
                    .HasColumnName("SalesInvoiceTmpSIVDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesInvoiceTmpSivid).HasColumnName("SalesInvoiceTmpSIVID");

                entity.Property(e => e.SalesInvoiceTmpSivname)
                    .HasColumnName("SalesInvoiceTmpSIVName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.SetId).HasColumnName("SetID");
            });

            modelBuilder.Entity<SalesInvoiceType>(entity =>
            {
                entity.Property(e => e.SalesInvoiceTypeId).HasColumnName("SalesInvoiceTypeID");

                entity.Property(e => e.SalesInvoiceTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesInvoiceTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesMockupInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.SlmockupInvoiceDetailId)
                    .HasName("PK_SalesMockupInvoiceItems");

                entity.Property(e => e.SlmockupInvoiceDetailId).HasColumnName("SLMockupInvoiceDetailID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStockAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCostAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescription).IsUnicode(false);

                entity.Property(e => e.ItemDescriptionArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SlmockUpInvoiceDetailItemAvailableQty)
                    .HasColumnName("SLMockUpInvoiceDetailItemAvailableQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailAddedBy)
                    .HasColumnName("SLMockupInvoiceDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlmockupInvoiceDetailAddedWhen)
                    .HasColumnName("SLMockupInvoiceDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SlmockupInvoiceDetailItemActualQty)
                    .HasColumnName("SLMockupInvoiceDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemBaseUnitQty)
                    .HasColumnName("SLMockupInvoiceDetailItemBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemCost)
                    .HasColumnName("SLMockupInvoiceDetailItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SlmockupInvoiceDetailItemDiscountAmount)
                    .HasColumnName("SLMockupInvoiceDetailItemDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemDiscountPercentage)
                    .HasColumnName("SLMockupInvoiceDetailItemDiscountPercentage")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemLabourFactor)
                    .HasColumnName("SLMockupInvoiceDetailItemLabourFactor")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemNetAmount)
                    .HasColumnName("SLMockupInvoiceDetailItemNetAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemPrice)
                    .HasColumnName("SLMockupInvoiceDetailItemPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemQty)
                    .HasColumnName("SLMockupInvoiceDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailItemSetQty)
                    .HasColumnName("SLMockupInvoiceDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailSerialNo).HasColumnName("SLMockupInvoiceDetailSerialNo");

                entity.Property(e => e.SlmockupInvoiceDetailUnitPrice)
                    .HasColumnName("SLMockupInvoiceDetailUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlmockupInvoiceDetailUpdatedBy)
                    .HasColumnName("SLMockupInvoiceDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlmockupInvoiceDetailUpdatedWhen)
                    .HasColumnName("SLMockupInvoiceDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesMockupInvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesMockupInvoiceDetails_Items");
            });

            modelBuilder.Entity<SalesMockupInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.SalesMockupInvoiceId);

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRepresentative)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsDueDate).HasColumnType("date");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesInvoiceFileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceNoOfUnits).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SalesMockupInvoiceAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesMockupInvoiceBankCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceCancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.SalesMockupInvoiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.SalesMockupInvoiceDeliveryCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceDeliveryDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceFixingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceFixingDate).HasColumnType("datetime");

                entity.Property(e => e.SalesMockupInvoiceJobSize).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SalesMockupInvoiceNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceNotes).IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceRetentionDate).HasColumnType("datetime");

                entity.Property(e => e.SalesMockupInvoiceRetentionPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SalesMockupInvoiceTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceTaxPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesMockupInvoiceTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesMockupInvoiceTotalDiscountPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesMockupInvoiceTotalNoOfSiv).HasColumnName("SalesMockupInvoiceTotalNoOfSIV");

                entity.Property(e => e.SalesMockupInvoiceUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesMockupInvoiceUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesMockupInvoiceMaster)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_SalesMockupInvoiceMaster_SalesPersons");
            });

            modelBuilder.Entity<SalesPaymentTerms>(entity =>
            {
                entity.HasKey(e => e.PaymentTermsId);

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.PaymentTermsAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesPersons>(entity =>
            {
                entity.HasKey(e => e.SalesPersonId);

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SalesGroupId).HasColumnName("SalesGroupID");

                entity.Property(e => e.SalesPersonAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesPersonContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonDesignation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonExtNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPersonUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.SalesGroup)
                    .WithMany(p => p.SalesPersons)
                    .HasForeignKey(d => d.SalesGroupId)
                    .HasConstraintName("FK_SalesPersons_SalesGroup");
            });

            modelBuilder.Entity<SalesPriceValidity>(entity =>
            {
                entity.HasKey(e => e.PriceValidityId);

                entity.Property(e => e.PriceValidityId).HasColumnName("PriceValidityID");

                entity.Property(e => e.PriceValidityAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.PriceValidityAddedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceValidityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceValidityUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceValidityUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesQuotation>(entity =>
            {
                entity.HasKey(e => e.SalesQuoteId);

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryTermsId).HasColumnName("DeliveryTermsID");

                entity.Property(e => e.DeliveryTimeId).HasColumnName("DeliveryTimeID");

                entity.Property(e => e.DrawingChargeDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DrawingChargeReceiptId).HasColumnName("DrawingChargeReceiptID");

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.ParentSalesQuoteId).HasColumnName("ParentSalesQuoteID");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.PriceValidityId).HasColumnName("PriceValidityID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesQuoteAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesQuoteApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.SalesQuoteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteCustomerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteDiscountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteDiscountType).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesQuoteFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteInvoiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteIsDeliveryAndInstallation).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesQuoteIsDeliveryOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesQuoteNoOfUnits).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SalesQuoteNotes).IsUnicode(false);

                entity.Property(e => e.SalesQuoteOurReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteStockReservationExpiryDate).HasColumnType("date");

                entity.Property(e => e.SalesQuoteSubject).IsUnicode(false);

                entity.Property(e => e.SalesQuoteTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTaxPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalBankCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalDiscountOnDelivery).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalDiscountPercent).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesQuoteTotalFixing).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTotalNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesQuoteTypeId).HasColumnName("SalesQuoteTypeID");

                entity.Property(e => e.SalesQuoteUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TermsId).HasColumnName("TermsID");

                entity.HasOne(d => d.CashCustomer)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.CashCustomerId)
                    .HasConstraintName("FK_SalesQuotation_CashCustomer");

                entity.HasOne(d => d.ContactDet)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.ContactDetId)
                    .HasConstraintName("FK_SalesQuotation_CustomerContactDetails");

                entity.HasOne(d => d.CustAccnt)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.CustAccntId)
                    .HasConstraintName("FK_SalesQuotation_CustomerAccounts");

                entity.HasOne(d => d.CustEnquiry)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.CustEnquiryId)
                    .HasConstraintName("FK_SalesQuotation_CustomerEnquiries");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesQuotation_CustomerMaster");

                entity.HasOne(d => d.DeliveryTerms)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.DeliveryTermsId)
                    .HasConstraintName("FK_SalesQuotation_SalesDeliveryTerms");

                entity.HasOne(d => d.DeliveryTime)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.DeliveryTimeId)
                    .HasConstraintName("FK_SalesQuotation_SalesDeliveryTime");

                entity.HasOne(d => d.PaymentTerms)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.PaymentTermsId)
                    .HasConstraintName("FK_SalesQuotation_SalesPaymentTerms");

                entity.HasOne(d => d.PriceValidity)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.PriceValidityId)
                    .HasConstraintName("FK_SalesQuotation_SalesPriceValidity");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_SalesQuotation_Projects");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_SalesQuotation_SalesPersons");

                entity.HasOne(d => d.SalesQuoteType)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.SalesQuoteTypeId)
                    .HasConstraintName("FK_SalesQuotation_SalesQuotationType");

                entity.HasOne(d => d.Terms)
                    .WithMany(p => p.SalesQuotation)
                    .HasForeignKey(d => d.TermsId)
                    .HasConstraintName("FK_SalesQuotation_TermsAndConditions");
            });

            modelBuilder.Entity<SalesQuotationDetails>(entity =>
            {
                entity.HasKey(e => e.SqdetailId);

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemDescription).IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImgId).HasColumnName("ItemImgID");

                entity.Property(e => e.ParentSqdetailId).HasColumnName("ParentSQDetailID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SqdetailAddedBy)
                    .HasColumnName("SQDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdetailAddedWhen)
                    .HasColumnName("SQDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdetailBaseUnitId).HasColumnName("SQDetailBaseUnitID");

                entity.Property(e => e.SqdetailBaseUnitQty)
                    .HasColumnName("SQDetailBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SqdetailItemActualQty)
                    .HasColumnName("SQDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SqdetailItemCost)
                    .HasColumnName("SQDetailItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SqdetailItemDiscountAmount)
                    .HasColumnName("SQDetailItemDiscountAmount")
                    .HasColumnType("decimal(36, 14)");

                entity.Property(e => e.SqdetailItemDiscountPercentage)
                    .HasColumnName("SQDetailItemDiscountPercentage")
                    .HasColumnType("decimal(18, 14)");

                entity.Property(e => e.SqdetailItemNetAmount)
                    .HasColumnName("SQDetailItemNetAmount")
                    .HasColumnType("decimal(36, 14)");

                entity.Property(e => e.SqdetailItemNetRate)
                    .HasColumnName("SQDetailItemNetRate")
                    .HasColumnType("decimal(36, 14)");

                entity.Property(e => e.SqdetailItemPrice)
                    .HasColumnName("SQDetailItemPrice")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SqdetailItemQty)
                    .HasColumnName("SQDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SqdetailItemSetQty)
                    .HasColumnName("SQDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SqdetailSerialNo).HasColumnName("SQDetailSerialNo");

                entity.Property(e => e.SqdetailUpdatedBy)
                    .HasColumnName("SQDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdetailUpdatedWhen)
                    .HasColumnName("SQDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Isdetail)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.IsdetailId)
                    .HasConstraintName("FK_SalesQuotationDetails_ItemSetDetails");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesQuotationDetails_Items");

                entity.HasOne(d => d.ItemImg)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.ItemImgId)
                    .HasConstraintName("FK_SalesQuotationDetails_ItemImages");

                entity.HasOne(d => d.Pricing)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.PricingId)
                    .HasConstraintName("FK_SalesQuotationDetails_ItemPricing");

                entity.HasOne(d => d.SalesQuote)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.SalesQuoteId)
                    .HasConstraintName("FK_SalesQuotationDetails_SalesQuotation");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_SalesQuotationDetails_ItemSets");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SalesQuotationDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_SalesQuotationDetails_Units");
            });

            modelBuilder.Entity<SalesQuotationDiscountType>(entity =>
            {
                entity.HasKey(e => e.SalesQuoteDiscountTypeId);

                entity.Property(e => e.SalesQuoteDiscountTypeId).HasColumnName("SalesQuoteDiscountTypeID");

                entity.Property(e => e.SalesQuoteDiscountTypeAddedBy).HasMaxLength(10);

                entity.Property(e => e.SalesQuoteDiscountTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesQuoteDiscountTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteDiscountTypeUpdateWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesQuoteDiscountTypeUpdatedBy).HasMaxLength(10);
            });

            modelBuilder.Entity<SalesQuotationDocuments>(entity =>
            {
                entity.HasKey(e => e.SqdocId);

                entity.Property(e => e.SqdocId).HasColumnName("SQDocID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SqdocAddedBy)
                    .HasColumnName("SQDocAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdocAddedWhen)
                    .HasColumnName("SQDocAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SqdocDesc)
                    .HasColumnName("SQDocDesc")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SqdocFileImage).HasColumnName("SQDocFileImage");

                entity.Property(e => e.SqdocFileName)
                    .HasColumnName("SQDocFileName")
                    .HasMaxLength(100);

                entity.Property(e => e.SqdocFileType)
                    .HasColumnName("SQDocFileType")
                    .HasMaxLength(50);

                entity.Property(e => e.SqdocIsActive).HasColumnName("SQDocIsActive");

                entity.Property(e => e.SqdocName)
                    .HasColumnName("SQDocName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdocUpdatedBy)
                    .HasColumnName("SQDocUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdocUpdatedWhen)
                    .HasColumnName("SQDocUpdatedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SqisDesignDoc).HasColumnName("SQIsDesignDoc");

                entity.HasOne(d => d.SalesQuote)
                    .WithMany(p => p.SalesQuotationDocuments)
                    .HasForeignKey(d => d.SalesQuoteId)
                    .HasConstraintName("FK_SalesQuotationDocuments_SalesQuotation");
            });

            modelBuilder.Entity<SalesQuotationRawMaterial>(entity =>
            {
                entity.HasKey(e => e.Sqrmid);

                entity.Property(e => e.Sqrmid).HasColumnName("SQRMID");

                entity.Property(e => e.Bomrmid).HasColumnName("BOMRMID");

                entity.Property(e => e.BomrmunitId).HasColumnName("BOMRMUnitID");

                entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.SqrawMaterialId).HasColumnName("SQRawMaterialID");

                entity.Property(e => e.SqrawMaterialQty)
                    .HasColumnName("SQRawMaterialQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SqrmaddedBy)
                    .HasColumnName("SQRMAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqrmaddedWhen)
                    .HasColumnName("SQRMAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqrmupdatedBy)
                    .HasColumnName("SQRMUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqrmupdatedWhen)
                    .HasColumnName("SQRMUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesQuotationType>(entity =>
            {
                entity.HasKey(e => e.SalesQuoteTypeId);

                entity.Property(e => e.SalesQuoteTypeId).HasColumnName("SalesQuoteTypeID");

                entity.Property(e => e.SalesQuoteTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesQuoteTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesQuoteTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesReceiptDetails>(entity =>
            {
                entity.HasKey(e => e.SrdetailId)
                    .HasName("PK_SalesReceiptDetail");

                entity.Property(e => e.SrdetailId).HasColumnName("SRDetailID");

                entity.Property(e => e.Memid).HasColumnName("MEMId");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesReceiptId).HasColumnName("SalesReceiptID");

                entity.Property(e => e.SrdetailAddedBy)
                    .HasColumnName("SRDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrdetailAddedWhen)
                    .HasColumnName("SRDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SrdetailAmount)
                    .HasColumnName("SRDetailAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrdetailAmountIsAdvance).HasColumnName("SRDetailAmountIsAdvance");

                entity.Property(e => e.SrdetailRemarks)
                    .HasColumnName("SRDetailRemarks")
                    .IsUnicode(false);

                entity.Property(e => e.SrdetailUpdatedBy)
                    .HasColumnName("SRDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrdetailUpdatedWhen)
                    .HasColumnName("SRDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesReceiptDocuments>(entity =>
            {
                entity.HasKey(e => e.SrdocId);

                entity.Property(e => e.SrdocId).HasColumnName("SRDocID");

                entity.Property(e => e.SalesReceiptId).HasColumnName("SalesReceiptID");

                entity.Property(e => e.SrdocAddedBy)
                    .HasColumnName("SRDocAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrdocAddedWhen)
                    .HasColumnName("SRDocAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SrdocDesc)
                    .HasColumnName("SRDocDesc")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SrdocFileName)
                    .HasColumnName("SRDocFileName")
                    .HasMaxLength(250);

                entity.Property(e => e.SrdocFileType)
                    .HasColumnName("SRDocFileType")
                    .HasMaxLength(50);

                entity.Property(e => e.SrdocIsActive).HasColumnName("SRDocIsActive");

                entity.Property(e => e.SrdocName)
                    .HasColumnName("SRDocName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrdocUpdatedBy)
                    .HasColumnName("SRDocUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrdocUpdatedWhen)
                    .HasColumnName("SRDocUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesReceiptMaster>(entity =>
            {
                entity.HasKey(e => e.SalesReceiptId);

                entity.Property(e => e.SalesReceiptId).HasColumnName("SalesReceiptID");

                entity.Property(e => e.BillCollectorId).HasColumnName("BillCollectorID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DrawingCustomerAddress)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingCustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsReceiptForDrawingCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesReceiptAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesReceiptAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesReceiptBankId).HasColumnName("SalesReceiptBankID");

                entity.Property(e => e.SalesReceiptBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptCardId).HasColumnName("SalesReceiptCardID");

                entity.Property(e => e.SalesReceiptCardNo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptChequeDated).HasColumnType("date");

                entity.Property(e => e.SalesReceiptChequeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.SalesReceiptDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptIsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesReceiptNotes).IsUnicode(false);

                entity.Property(e => e.SalesReceiptPaymentMode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CashCustomer)
                    .WithMany(p => p.SalesReceiptMaster)
                    .HasForeignKey(d => d.CashCustomerId)
                    .HasConstraintName("FK_SalesReceiptMaster_CashCustomer");
            });

            modelBuilder.Entity<SalesReturnConfirmationDetails>(entity =>
            {
                entity.HasKey(e => e.SrcdetailId);

                entity.Property(e => e.SrcdetailId).HasColumnName("SRCDetailID");

                entity.Property(e => e.SivdetailId).HasColumnName("SIVDetailID");

                entity.Property(e => e.SrcdetailAddedBy)
                    .HasColumnName("SRCDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrcdetailAddedWhen)
                    .HasColumnName("SRCDetailAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SrcdetailReturnedActualQty)
                    .HasColumnName("SRCDetailReturnedActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrcdetailReturnedQty)
                    .HasColumnName("SRCDetailReturnedQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrcdetailUpdatedBy)
                    .HasColumnName("SRCDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrcdetailUpdatedWhen)
                    .HasColumnName("SRCDetailUpdatedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Srcid).HasColumnName("SRCId");
            });

            modelBuilder.Entity<SalesReturnConfirmationMaster>(entity =>
            {
                entity.HasKey(e => e.Srcid)
                    .HasName("PK_SalesReturnConfirmation");

                entity.Property(e => e.Srcid).HasColumnName("SRCId");

                entity.Property(e => e.Sivid).HasColumnName("SIVId");

                entity.Property(e => e.SrcaddedBy)
                    .HasColumnName("SRCAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrcaddedWhen)
                    .HasColumnName("SRCAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SrcdeliveryNoteNo)
                    .HasColumnName("SRCDeliveryNoteNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Srcno)
                    .HasColumnName("SRCNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Srcremarks)
                    .HasColumnName("SRCRemarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SrcreturnedDate)
                    .HasColumnName("SRCReturnedDate")
                    .HasColumnType("date");

                entity.Property(e => e.Srcstatus)
                    .HasColumnName("SRCStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SrcupdatedBy)
                    .HasColumnName("SRCUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrcupdatedWhen)
                    .HasColumnName("SRCUpdatedWhen")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Siv)
                    .WithMany(p => p.SalesReturnConfirmationMaster)
                    .HasForeignKey(d => d.Sivid)
                    .HasConstraintName("FK_SalesReturnConfirmationMaster_StoreIssueVoucherMaster");
            });

            modelBuilder.Entity<SalesSampleInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.SlsampleInvoiceDetailId)
                    .HasName("PK_SalesSampleInvoiceItems");

                entity.Property(e => e.SlsampleInvoiceDetailId).HasColumnName("SLSampleInvoiceDetailID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStockAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemCostAtCancellation).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescription).IsUnicode(false);

                entity.Property(e => e.ItemDescriptionArabic).HasMaxLength(2000);

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SlsampleInvoiceDetailAddedBy)
                    .HasColumnName("SLSampleInvoiceDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlsampleInvoiceDetailAddedWhen)
                    .HasColumnName("SLSampleInvoiceDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SlsampleInvoiceDetailItemActualQty)
                    .HasColumnName("SLSampleInvoiceDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemAvailableQty)
                    .HasColumnName("SLSampleInvoiceDetailItemAvailableQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemBaseUnitQty)
                    .HasColumnName("SLSampleInvoiceDetailItemBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemCost)
                    .HasColumnName("SLSampleInvoiceDetailItemCost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SlsampleInvoiceDetailItemDiscountAmount)
                    .HasColumnName("SLSampleInvoiceDetailItemDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemDiscountPercentage)
                    .HasColumnName("SLSampleInvoiceDetailItemDiscountPercentage")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemLabourFactor)
                    .HasColumnName("SLSampleInvoiceDetailItemLabourFactor")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemNetAmount)
                    .HasColumnName("SLSampleInvoiceDetailItemNetAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemPrice)
                    .HasColumnName("SLSampleInvoiceDetailItemPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemQty)
                    .HasColumnName("SLSampleInvoiceDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailItemSetQty)
                    .HasColumnName("SLSampleInvoiceDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailSerialNo).HasColumnName("SLSampleInvoiceDetailSerialNo");

                entity.Property(e => e.SlsampleInvoiceDetailUnitPrice)
                    .HasColumnName("SLSampleInvoiceDetailUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SlsampleInvoiceDetailUpdatedBy)
                    .HasColumnName("SLSampleInvoiceDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlsampleInvoiceDetailUpdatedWhen)
                    .HasColumnName("SLSampleInvoiceDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdetailId).HasColumnName("SQDetailID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesSampleInvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesSampleInvoiceDetails_Items");
            });

            modelBuilder.Entity<SalesSampleInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.SalesSampleInvoiceId);

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.ContactDetId).HasColumnName("ContactDetID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustEnquiryId).HasColumnName("CustEnquiryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRepresentative)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.PaymentTermsDueDate).HasColumnType("date");

                entity.Property(e => e.PaymentTermsId).HasColumnName("PaymentTermsID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesContractId).HasColumnName("SalesContractID");

                entity.Property(e => e.SalesInvoiceFileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceNoOfUnits).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SalesSampleInvoiceAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesSampleInvoiceBankCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceCancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.SalesSampleInvoiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.SalesSampleInvoiceDeliveryCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceDeliveryDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceFixingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceFixingDate).HasColumnType("datetime");

                entity.Property(e => e.SalesSampleInvoiceJobSize).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SalesSampleInvoiceNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceNotes).IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceRetentionDate).HasColumnType("datetime");

                entity.Property(e => e.SalesSampleInvoiceRetentionPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SalesSampleInvoiceTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceTaxPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesSampleInvoiceTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesSampleInvoiceTotalDiscountPercentage).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SalesSampleInvoiceTotalNoOfSiv).HasColumnName("SalesSampleInvoiceTotalNoOfSIV");

                entity.Property(e => e.SalesSampleInvoiceUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSampleInvoiceUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesSampleInvoiceMaster)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_SalesSampleInvoiceMaster_SalesPersons");
            });

            modelBuilder.Entity<SampleVoucherRequestDetail>(entity =>
            {
                entity.HasKey(e => e.SvrdetailId);

                entity.Property(e => e.SvrdetailId).HasColumnName("SVRDetailID");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.SvrdetailAddedBy)
                    .HasColumnName("SVRDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvrdetailAddedWhen)
                    .HasColumnName("SVRDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SvrdetailQuantity)
                    .HasColumnName("SVRDetailQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SvrdetailUpdatedBy)
                    .HasColumnName("SVRDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvrdetailUpdatedWhen)
                    .HasColumnName("SVRDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Svrid).HasColumnName("SVRID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<SampleVoucherRequestMaster>(entity =>
            {
                entity.HasKey(e => e.Svrid)
                    .HasName("PK_SampleVoucherRequest");

                entity.Property(e => e.Svrid).HasColumnName("SVRID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrderRequestCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvraddedBy)
                    .HasColumnName("SVRAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvraddedWhen).HasColumnName("SVRAddedWhen");

                entity.Property(e => e.Svramount)
                    .HasColumnName("SVRAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Svrcode)
                    .HasColumnName("SVRCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Svrdate).HasColumnName("SVRDate");

                entity.Property(e => e.Svrdescription)
                    .HasColumnName("SVRDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Svrstatus).HasColumnName("SVRStatus");

                entity.Property(e => e.SvrupdatedBy)
                    .HasColumnName("SVRUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvrupdatedWhen).HasColumnName("SVRUpdatedWhen");
            });

            modelBuilder.Entity<Smstype>(entity =>
            {
                entity.ToTable("SMSType");

                entity.Property(e => e.SmstypeId).HasColumnName("SMSTypeID");

                entity.Property(e => e.SmstypeAddedBy)
                    .HasColumnName("SMSTypeAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmstypeAddedWhen)
                    .HasColumnName("SMSTypeAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SmstypeName)
                    .HasColumnName("SMSTypeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmstypeUpdatedBy)
                    .HasColumnName("SMSTypeUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmstypeUpdatedWhen)
                    .HasColumnName("SMSTypeUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SpallowedDiscounts>(entity =>
            {
                entity.HasKey(e => e.AllowedDiscountId);

                entity.ToTable("SPAllowedDiscounts");

                entity.Property(e => e.AllowedDiscountId).HasColumnName("AllowedDiscountID");

                entity.Property(e => e.AllowedDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllowedDiscountAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllowedDiscountAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.AllowedDiscountUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllowedDiscountUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<SqdeliveryAddress>(entity =>
            {
                entity.ToTable("SQDeliveryAddress");

                entity.Property(e => e.SqdeliveryAddressId).HasColumnName("SQDeliveryAddressID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");

                entity.Property(e => e.SqdeliveryAddress1)
                    .HasColumnName("SQDeliveryAddress")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SqdeliveryAddressAddedBy)
                    .HasColumnName("SQDeliveryAddressAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdeliveryAddressAddedWhen)
                    .HasColumnName("SQDeliveryAddressAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdeliveryAddressUpdatedBy)
                    .HasColumnName("SQDeliveryAddressUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqdeliveryAddressUpdatedWhen)
                    .HasColumnName("SQDeliveryAddressUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqdeliveryCharge)
                    .HasColumnName("SQDeliveryCharge")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SqdeliveryDescr)
                    .HasColumnName("SQDeliveryDescr")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SqdeliveryNoOfTrips).HasColumnName("SQDeliveryNoOfTrips");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SqdeliveryAddress)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_SQDeliveryAddress_LocationCharges");

                entity.HasOne(d => d.SalesQuote)
                    .WithMany(p => p.SqdeliveryAddress)
                    .HasForeignKey(d => d.SalesQuoteId)
                    .HasConstraintName("FK_SQDeliveryAddress_SalesQuotation");
            });

            modelBuilder.Entity<Srmmaster>(entity =>
            {
                entity.HasKey(e => e.Srmid);

                entity.ToTable("SRMMaster");

                entity.Property(e => e.Srmid).HasColumnName("SRMID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.InvoiceItemCategoryId).HasColumnName("InvoiceItemCategoryID");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.Sivid).HasColumnName("SIVID");

                entity.Property(e => e.Srcid).HasColumnName("SRCID");

                entity.Property(e => e.SrmaddedWhen)
                    .HasColumnName("SRMAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Srmaddedby)
                    .HasColumnName("SRMAddedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Srmcode)
                    .HasColumnName("SRMCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Srmdate)
                    .HasColumnName("SRMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SrmfixingCharge)
                    .HasColumnName("SRMFixingCharge")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SrmisPrinted).HasColumnName("SRMIsPrinted");

                entity.Property(e => e.Srmreason)
                    .HasColumnName("SRMReason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Srmrecommendation)
                    .HasColumnName("SRMRecommendation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Srmremarks)
                    .HasColumnName("SRMRemarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Srmstatus).HasColumnName("SRMStatus");

                entity.Property(e => e.SrmtotalReturnedAmount)
                    .HasColumnName("SRMTotalReturnedAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmtotalReturnedDeliveyCharge)
                    .HasColumnName("SRMTotalReturnedDeliveyCharge")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Srmtype).HasColumnName("SRMType");

                entity.Property(e => e.SrmupdatedWhen)
                    .HasColumnName("SRMUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Srmupdatedby)
                    .HasColumnName("SRMUpdatedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SrmreturnedItems>(entity =>
            {
                entity.HasKey(e => e.SrmreturnItemId);

                entity.ToTable("SRMReturnedItems");

                entity.Property(e => e.SrmreturnItemId).HasColumnName("SRMReturnItemID");

                entity.Property(e => e.BaseUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");

                entity.Property(e => e.BaseUnitQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemActualStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemGroundStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.SivdetailId).HasColumnName("SIVDetailID");

                entity.Property(e => e.SrcdetailId).HasColumnName("SRCDetailID");

                entity.Property(e => e.Srmid).HasColumnName("SRMID");

                entity.Property(e => e.SrmreturnAddedBy)
                    .HasColumnName("SRMReturnAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrmreturnAddedWhen)
                    .HasColumnName("SRMReturnAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SrmreturnItemActualQty)
                    .HasColumnName("SRMReturnItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemCost)
                    .HasColumnName("SRMReturnItemCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemDescArabic)
                    .HasColumnName("SRMReturnItemDescArabic")
                    .HasMaxLength(4000);

                entity.Property(e => e.SrmreturnItemDiscount)
                    .HasColumnName("SRMReturnItemDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemDiscountAmount)
                    .HasColumnName("SRMReturnItemDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemNetAmount)
                    .HasColumnName("SRMReturnItemNetAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemPrice)
                    .HasColumnName("SRMReturnItemPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemQty)
                    .HasColumnName("SRMReturnItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnItemUnitPrice)
                    .HasColumnName("SRMReturnItemUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SrmreturnUpdatedBy)
                    .HasColumnName("SRMReturnUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrmreturnUpdatedWhen)
                    .HasColumnName("SRMReturnUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SrmreturnedItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SRMReturnedItems_Items");

                entity.HasOne(d => d.Srm)
                    .WithMany(p => p.SrmreturnedItems)
                    .HasForeignKey(d => d.Srmid)
                    .HasConstraintName("FK_SRMReturnedItems_SRMMaster");
            });

            modelBuilder.Entity<StoreIssueVoucherDetail>(entity =>
            {
                entity.HasKey(e => e.SivdetailId);

                entity.Property(e => e.SivdetailId).HasColumnName("SIVDetailID");

                entity.Property(e => e.IsdetailId).HasColumnName("ISDetailID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MemitemIssuedId).HasColumnName("MEMItemIssuedID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SivdetailAddedBy)
                    .HasColumnName("SIVDetailAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivdetailAddedWhen)
                    .HasColumnName("SIVDetailAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SivdetailBaseUnitId).HasColumnName("SIVDetailBaseUnitID");

                entity.Property(e => e.SivdetailBaseUnitQty)
                    .HasColumnName("SIVDetailBaseUnitQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailItemActualQty)
                    .HasColumnName("SIVDetailItemActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailItemDeliveredActualQty)
                    .HasColumnName("SIVDetailItemDeliveredActualQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailItemDeliveredQty)
                    .HasColumnName("SIVDetailItemDeliveredQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailItemQty)
                    .HasColumnName("SIVDetailItemQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailItemSetQty)
                    .HasColumnName("SIVDetailItemSetQty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SivdetailSerialNo).HasColumnName("SIVDetailSerialNo");

                entity.Property(e => e.SivdetailUpdatedBy)
                    .HasColumnName("SIVDetailUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivdetailUpdatedWhen)
                    .HasColumnName("SIVDetailUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sivid).HasColumnName("SIVID");

                entity.Property(e => e.SlcashInvoiceDetailId).HasColumnName("SLCashInvoiceDetailID");

                entity.Property(e => e.SlcreditInvoiceDetailId).HasColumnName("SLCreditInvoiceDetailID");

                entity.Property(e => e.SlmockupInvoiceDetailId).HasColumnName("SLMockupInvoiceDetailID");

                entity.Property(e => e.SlsampleInvoiceDetailId).HasColumnName("SLSampleInvoiceDetailID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StoreIssueVoucherDetail)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_StoreIssueVoucherDetail_Items");

                entity.HasOne(d => d.Siv)
                    .WithMany(p => p.StoreIssueVoucherDetail)
                    .HasForeignKey(d => d.Sivid)
                    .HasConstraintName("FK_StoreIssueVoucherDetail_StoreIssueVoucherMaster");
            });

            modelBuilder.Entity<StoreIssueVoucherMaster>(entity =>
            {
                entity.HasKey(e => e.Sivid);

                entity.Property(e => e.Sivid).HasColumnName("SIVID");

                entity.Property(e => e.CashCustomerId).HasColumnName("CashCustomerID");

                entity.Property(e => e.CustAccntId).HasColumnName("CustAccntID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.SalesCashInvoiceId).HasColumnName("SalesCashInvoiceID");

                entity.Property(e => e.SalesCreditInvoiceId).HasColumnName("SalesCreditInvoiceID");

                entity.Property(e => e.SalesMockupInvoiceId).HasColumnName("SalesMockupInvoiceID");

                entity.Property(e => e.SalesSampleInvoiceId).HasColumnName("SalesSampleInvoiceID");

                entity.Property(e => e.SivaddedBy)
                    .HasColumnName("SIVAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivaddedWhen)
                    .HasColumnName("SIVAddedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sivcode)
                    .HasColumnName("SIVCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivcontactPerson)
                    .HasColumnName("SIVContactPerson")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sivdate)
                    .HasColumnName("SIVDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SivdeliveryContactNo)
                    .HasColumnName("SIVDeliveryContactNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivdeliveryLoc)
                    .HasColumnName("SIVDeliveryLoc")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SivisPrinted).HasColumnName("SIVIsPrinted");

                entity.Property(e => e.Sivstatus).HasColumnName("SIVStatus");

                entity.Property(e => e.SivupdatedBy)
                    .HasColumnName("SIVUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SivupdatedWhen)
                    .HasColumnName("SIVUpdatedWhen")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CashCustomer)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.CashCustomerId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_CashCustomer");

                entity.HasOne(d => d.CustAccnt)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.CustAccntId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_CustomerAccounts");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_CustomerMaster");

                entity.HasOne(d => d.Mem)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.Memid)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_MEMMaster");

                entity.HasOne(d => d.SalesCashInvoice)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.SalesCashInvoiceId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_SalesCashInvoiceMaster");

                entity.HasOne(d => d.SalesCreditInvoice)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.SalesCreditInvoiceId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_SalesCreditInvoiceMaster");

                entity.HasOne(d => d.SalesMockupInvoice)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.SalesMockupInvoiceId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_SalesMockupInvoiceMaster");

                entity.HasOne(d => d.SalesSampleInvoice)
                    .WithMany(p => p.StoreIssueVoucherMaster)
                    .HasForeignKey(d => d.SalesSampleInvoiceId)
                    .HasConstraintName("FK_StoreIssueVoucherMaster_SalesSampleInvoiceMaster");
            });

            modelBuilder.Entity<SubLedgerAccountType>(entity =>
            {
                entity.Property(e => e.SubLedgerAccountTypeId).HasColumnName("SubLedgerAccountTypeID");

                entity.Property(e => e.SubLedgerAccountTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubLedgerAccountTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubLedgerAccountTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubLedgerAccountTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubLedgerAccountTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubLedgerAccountTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.Property(e => e.SupplierTypeId).HasColumnName("SupplierTypeID");

                entity.Property(e => e.SupplierRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.LedgerAccountId).HasColumnName("LedgerAccountID");

                entity.Property(e => e.SupplierAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierFaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierSince)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTelNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTypeId).HasColumnName("SupplierTypeID");

                entity.Property(e => e.SupplierUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierUpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.SupplierWebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TermsAndConditions>(entity =>
            {
                entity.HasKey(e => e.TermsId);

                entity.Property(e => e.TermsId).HasColumnName("TermsID");

                entity.Property(e => e.TermsAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TermsDocuments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsFileType).HasMaxLength(50);

                entity.Property(e => e.TermsInArabic).HasMaxLength(250);

                entity.Property(e => e.TermsInEnglish)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TermsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsTypeId).HasColumnName("TermsTypeID");

                entity.Property(e => e.TermsUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TermsOfDelivery>(entity =>
            {
                entity.HasKey(e => e.DelTermId);

                entity.Property(e => e.DelTermId).HasColumnName("DelTermID");

                entity.Property(e => e.DelTermAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelTermAddedWhen).HasColumnType("datetime");

                entity.Property(e => e.DelTermName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DelTermUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelTermUpdatedWhen).HasColumnType("datetime");
            });

            modelBuilder.Entity<TermsOfPayments>(entity =>
            {
                entity.HasKey(e => e.Topid);

                entity.Property(e => e.Topid).HasColumnName("TOPId");

                entity.Property(e => e.TopaddedBy)
                    .HasColumnName("TOPAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopaddedWhen)
                    .HasColumnName("TOPAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Topname)
                    .HasColumnName("TOPName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TopupdatedBy)
                    .HasColumnName("TOPUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopupdatedWhen)
                    .HasColumnName("TOPUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TermsType>(entity =>
            {
                entity.Property(e => e.TermsTypeId).HasColumnName("TermsTypeID");

                entity.Property(e => e.TermsTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TermsTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TimeOfDeliveries>(entity =>
            {
                entity.HasKey(e => e.Todid);

                entity.Property(e => e.Todid).HasColumnName("TODId");

                entity.Property(e => e.TodaddedBy)
                    .HasColumnName("TODAddedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TodaddedWhen)
                    .HasColumnName("TODAddedWhen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Todname)
                    .HasColumnName("TODName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TodupdatedBy)
                    .HasColumnName("TODUpdatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TodupdatedWhen)
                    .HasColumnName("TODUpdatedWhen")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UnitOfConversion>(entity =>
            {
                entity.HasKey(e => e.ConversionId)
                    .HasName("PK_UnitOfConvertions");

                entity.Property(e => e.ConversionId).HasColumnName("ConversionID");

                entity.Property(e => e.ActualRateForSteel)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConversionAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ConversionRate).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ConversionUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.UnitIdfrom).HasColumnName("UnitIDFrom");

                entity.Property(e => e.UnitIdto).HasColumnName("UnitIDTo");

                entity.HasOne(d => d.UnitIdfromNavigation)
                    .WithMany(p => p.UnitOfConversionUnitIdfromNavigation)
                    .HasForeignKey(d => d.UnitIdfrom)
                    .HasConstraintName("FK_UnitOfConversion_Units1");

                entity.HasOne(d => d.UnitIdtoNavigation)
                    .WithMany(p => p.UnitOfConversionUnitIdtoNavigation)
                    .HasForeignKey(d => d.UnitIdto)
                    .HasConstraintName("FK_UnitOfConversion_Units");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSymbol)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LoginPassword).IsUnicode(false);

                entity.Property(e => e.ManagerUserId).HasColumnName("ManagerUserID");

                entity.Property(e => e.UserAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserEmailId)
                    .HasColumnName("UserEmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddedby)
                    .HasColumnName("user_addedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddeddate)
                    .HasColumnName("user_addeddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("user_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPriority).HasColumnName("user_priority");

                entity.Property(e => e.UserStatus).HasColumnName("user_status");

                entity.Property(e => e.UserUpdatedby)
                    .HasColumnName("user_updatedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdateddate)
                    .HasColumnName("user_updateddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserUsername)
                    .HasColumnName("user_username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VoucherType>(entity =>
            {
                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.Property(e => e.VoucherTypeAbbreviation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VoucherTypeCanUseForTransaction).HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeNonEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherTypeParentId).HasColumnName("VoucherTypeParentID");

                entity.Property(e => e.VoucherTypeUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WhWareHouseStorageArea>(entity =>
            {
                entity.HasKey(e => e.StorageAreaId)
                    .HasName("PK_StorageBin");

                entity.Property(e => e.StorageAreaId).HasColumnName("StorageAreaID");

                entity.Property(e => e.SaitemId).HasColumnName("SAItemID");

                entity.Property(e => e.StorageAreaAddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorageAreaAddedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StorageAreaCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StorageAreaHeight).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.StorageAreaLength).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.StorageAreaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorageAreaRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StorageAreaUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorageAreaUpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StorageAreaWidth).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.WhWareHouseStorageArea)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_WhWareHouseStorageArea_Units");

               
            });
        }
    }
}
