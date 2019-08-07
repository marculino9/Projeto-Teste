﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto02.Contexto;

namespace Projeto02.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190807161817_teste")]
    partial class teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto02.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListaDeCargos");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Projeto02.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GestorId");

                    b.Property<int>("ListaDeEquipes");

                    b.HasKey("Id");

                    b.HasIndex("GestorId");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("Projeto02.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("EquipeId");

                    b.Property<string>("Maquina")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("EquipeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Funcionarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Funcionario");
                });

            modelBuilder.Entity("Projeto02.Models.Licenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chave")
                        .IsRequired();

                    b.Property<int>("Quantidade");

                    b.Property<int>("SoftwareId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("SoftwareId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Licencas");
                });

            modelBuilder.Entity("Projeto02.Models.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Versao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("Projeto02.Models.SolicitacaoLicenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataTermino");

                    b.Property<int>("ListaDeRequerimento");

                    b.Property<int>("ListaDeStatus");

                    b.Property<string>("MotivoDeUso");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Protocolo");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("SolicitacaoLicencas");
                });

            modelBuilder.Entity("Projeto02.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Projeto02.Models.Gestor", b =>
                {
                    b.HasBaseType("Projeto02.Models.Funcionario");

                    b.HasDiscriminator().HasValue("Gestor");
                });

            modelBuilder.Entity("Projeto02.Models.Equipe", b =>
                {
                    b.HasOne("Projeto02.Models.Gestor", "Gestor")
                        .WithMany()
                        .HasForeignKey("GestorId");
                });

            modelBuilder.Entity("Projeto02.Models.Funcionario", b =>
                {
                    b.HasOne("Projeto02.Models.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projeto02.Models.Equipe", "Equipe")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projeto02.Models.Usuario", "Usuario")
                        .WithMany("Funcionarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto02.Models.Licenca", b =>
                {
                    b.HasOne("Projeto02.Models.Software", "Software")
                        .WithMany()
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projeto02.Models.Usuario")
                        .WithMany("Licencas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Projeto02.Models.SolicitacaoLicenca", b =>
                {
                    b.HasOne("Projeto02.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}