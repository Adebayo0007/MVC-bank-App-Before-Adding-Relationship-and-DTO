// <auto-generated />
using System;
using MVC_MobileBankApp.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_MobileBankApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bank_App.Models.CEO", b =>
                {
                    b.Property<string>("CEOId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CEOId");

                    b.ToTable("CEOs");
                });

            modelBuilder.Entity("Bank_App.Models.Customer", b =>
                {
                    b.Property<string>("AccountNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AccountNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.Admin", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StaffId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.Manager", b =>
                {
                    b.Property<string>("ManagerId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.Transaction", b =>
                {
                    b.Property<string>("RefNum")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<string>("CustomerAccountNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientAccountNumber")
                        .HasColumnType("longtext");

                    b.Property<int>("TransactType")
                        .HasColumnType("int");

                    b.HasKey("RefNum");

                    b.HasIndex("CustomerAccountNumber");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminStaffId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CEOId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CustomerAccountNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AdminStaffId");

                    b.HasIndex("CEOId");

                    b.HasIndex("CustomerAccountNumber");

                    b.HasIndex("ManagerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.Transaction", b =>
                {
                    b.HasOne("Bank_App.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerAccountNumber");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MVC_MobileBankApp.Models.User", b =>
                {
                    b.HasOne("MVC_MobileBankApp.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminStaffId");

                    b.HasOne("Bank_App.Models.CEO", "Ceo")
                        .WithMany()
                        .HasForeignKey("CEOId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bank_App.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerAccountNumber");

                    b.HasOne("MVC_MobileBankApp.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Ceo");

                    b.Navigation("Customer");

                    b.Navigation("Manager");
                });
#pragma warning restore 612, 618
        }
    }
}
