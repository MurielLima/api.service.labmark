﻿// <auto-generated />
using System;
using Labmark.Domain.Shared.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labmark.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210105234224_column tipoacesso")]
    partial class columntipoacesso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("LAB")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cep")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("CEP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Numero")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("TipoAcesso")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa", "LAB");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaFisica", b =>
                {
                    b.Property<int>("FkPessoaId")
                        .HasColumnType("int")
                        .HasColumnName("fk_Pessoa_Id");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.HasKey("FkPessoaId")
                        .HasName("PK__PessoaFi__F76A5F7027EF5180");

                    b.HasIndex(new[] { "Cpf" }, "UQ__PessoaFi__C1F89731FE4ADCAE")
                        .IsUnique();

                    b.ToTable("PessoaFisica", "LAB");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaJuridica", b =>
                {
                    b.Property<int>("FkPessoaId")
                        .HasColumnType("int")
                        .HasColumnName("fk_Pessoa_Id");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ResponsavelTecnico")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("FkPessoaId")
                        .HasName("PK__PessoaJu__F76A5F70FD19FCDB");

                    b.HasIndex(new[] { "Cnpj" }, "UQ__PessoaJu__AA57D6B4275C4649")
                        .IsUnique();

                    b.ToTable("PessoaJuridica", "LAB");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("DDD");

                    b.Property<int?>("FkPessoaId")
                        .HasColumnType("int")
                        .HasColumnName("fk_Pessoa_Id");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("FkPessoaId");

                    b.ToTable("Telefone", "LAB");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("FkPessoaId")
                        .HasColumnType("int")
                        .HasColumnName("fk_Pessoa_Id");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FkPessoaId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaFisica", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", "FkPessoa")
                        .WithOne("PessoaFisica")
                        .HasForeignKey("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaFisica", "FkPessoaId")
                        .HasConstraintName("FK_PessoaFisica_2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FkPessoa");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaJuridica", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", "FkPessoa")
                        .WithOne("PessoaJuridica")
                        .HasForeignKey("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.PessoaJuridica", "FkPessoaId")
                        .HasConstraintName("FK_PessoaJuridica_2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FkPessoa");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Telefone", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", "FkPessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("FkPessoaId")
                        .HasConstraintName("FK_Telefone_2")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("FkPessoa");
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", "FkPessoa")
                        .WithMany()
                        .HasForeignKey("FkPessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FkPessoa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labmark.Domain.Modules.Account.Infrastructure.EFCore.Entities.Pessoa", b =>
                {
                    b.Navigation("PessoaFisica");

                    b.Navigation("PessoaJuridica");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
