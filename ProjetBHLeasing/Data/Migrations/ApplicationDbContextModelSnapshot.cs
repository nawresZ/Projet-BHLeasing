﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using ProjetBHLeasing.Data;

#nullable disable

namespace ProjetBHLeasing.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NormalizedName\" IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NormalizedUserName\" IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Client", b =>
                {
                    b.Property<int>("IDrow")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDrow"));

                    b.Property<string>("clientId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("dateAppel")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("dateReglement")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("idAction")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double?>("montant")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<string>("observations")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("resultats")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IDrow");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.His_Relances", b =>
                {
                    b.Property<int>("id_his_relance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_his_relance"));

                    b.Property<int?>("ID_USER_MODIF")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("IdProvenance")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("code_client")
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<DateTime?>("date_derniere_relance")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("date_prochaine_relance")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("date_rdv")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("date_traitement")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("date_user_creat")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("date_user_modif")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("id_action")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_campagne")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_disponibilite")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_moralite")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_ptf")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_relance")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_sinistre")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_solvabilite")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_sort")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("infos")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("NCLOB");

                    b.Property<double>("montant")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<string>("observation")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("NCLOB");

                    b.Property<string>("provenance")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("id_his_relance");

                    b.HasIndex("ID_USER_MODIF");

                    b.ToTable("His_Relances");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Profil", b =>
                {
                    b.Property<int>("id_profil")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<int>("b_systeme")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("date_user_creat")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("date_user_modif")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("id_user_modif")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id_profil");

                    b.ToTable("Profil");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Utilisateur", b =>
                {
                    b.Property<int>("id_user")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ID_PROFIL")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("abreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<int>("b_modifier_ptf")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("date_derniers_acces")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("date_user_creat")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("date_user_modif")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("id_departement")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_user_modif")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_user_responsable")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("mail")
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<int>("matricule")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("rib")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<string>("statut")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.HasKey("id_user");

                    b.HasIndex("ID_PROFIL");

                    b.ToTable("Utilisateur");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.His_Relances", b =>
                {
                    b.HasOne("ProjetBHLeasing.Models.Utilisateur", "UserModif")
                        .WithMany("HisRelances")
                        .HasForeignKey("ID_USER_MODIF");

                    b.Navigation("UserModif");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Utilisateur", b =>
                {
                    b.HasOne("ProjetBHLeasing.Models.Profil", "Profil")
                        .WithMany("Utilisateurs")
                        .HasForeignKey("ID_PROFIL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profil");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Profil", b =>
                {
                    b.Navigation("Utilisateurs");
                });

            modelBuilder.Entity("ProjetBHLeasing.Models.Utilisateur", b =>
                {
                    b.Navigation("HisRelances");
                });
#pragma warning restore 612, 618
        }
    }
}
