﻿// <auto-generated />
using System;
using FastCleanAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FastCleanAPI.Migrations
{
    [DbContext(typeof(FastCleanContext))]
    [Migration("20220102205322_AlteracaoMarcANDReviews")]
    partial class AlteracaoMarcANDReviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FastCleanAPI.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Marcacao", b =>
                {
                    b.Property<int>("MarcacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcacaoId"), 1L, 1);

                    b.Property<bool>("CliReview")
                        .HasColumnType("bit");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Cozinha")
                        .HasColumnType("bit");

                    b.Property<string>("Detalhes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuracaoTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FuncReview")
                        .HasColumnType("bit");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("HoraFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInicial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatitudeMarcacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongitudeMarcacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MarcacaoAceitePeloCliente")
                        .HasColumnType("bit");

                    b.Property<bool>("MarcacaoAceitePeloFunc")
                        .HasColumnType("bit");

                    b.Property<string>("MoradaMarcacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCasasDeBanho")
                        .HasColumnType("int");

                    b.Property<int>("NumHorasPrevistas")
                        .HasColumnType("int");

                    b.Property<int>("NumQuartos")
                        .HasColumnType("int");

                    b.Property<bool>("Sala")
                        .HasColumnType("bit");

                    b.Property<bool>("Terminada")
                        .HasColumnType("bit");

                    b.Property<int>("TipoAgendamento")
                        .HasColumnType("int");

                    b.Property<int>("TipoImovel")
                        .HasColumnType("int");

                    b.Property<int>("TipoLimpeza")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("MarcacaoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Marcacoes");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderId");

                    b.ToTable("Mensagens");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Morada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Concelho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distrito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freguesia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Moradas");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReportCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Arquivado")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportedId")
                        .HasColumnType("int");

                    b.Property<int>("ReporterId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportedId");

                    b.HasIndex("ReporterId");

                    b.ToTable("ReportsClientes");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReportFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Arquivado")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportedId")
                        .HasColumnType("int");

                    b.Property<int>("ReporterId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportedId");

                    b.HasIndex("ReporterId");

                    b.ToTable("ReportsFuncionario");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReviewClienteDatails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cotacao")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewedId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReviewedId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("ReviewsClientes");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReviewFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cotacao")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewedId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReviewedId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("ReviewsFuncionarios");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Utilizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aceite")
                        .HasColumnType("bit");

                    b.Property<bool>("Banido")
                        .HasColumnType("bit");

                    b.Property<string>("Cadastro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<string>("CcFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contacto")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoradaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MoradaId");

                    b.ToTable("Utilizador");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Utilizador");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Cliente", b =>
                {
                    b.HasBaseType("FastCleanAPI.Models.Utilizador");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Funcionario", b =>
                {
                    b.HasBaseType("FastCleanAPI.Models.Utilizador");

                    b.Property<string>("CartaDeConducao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CvFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("HistoricoMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<bool>("Subscricao")
                        .HasColumnType("bit");

                    b.Property<int>("TipoLimpeza")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Funcionario");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Chat", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Cliente", "Cliente")
                        .WithMany("ListaDeChats")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Funcionario", "Funcionario")
                        .WithMany("ListaDeChats")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Marcacao", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Cliente", "Cliente")
                        .WithMany("ListaDeMarcacoes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("FastCleanAPI.Models.Funcionario", "Funcionario")
                        .WithMany("ListaDeMarcacoes")
                        .HasForeignKey("FuncionarioId");

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Mensagem", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Chat", "Chat")
                        .WithMany("ListaMensagens")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Utilizador", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReportCliente", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Cliente", "Reported")
                        .WithMany("ListaDeReports")
                        .HasForeignKey("ReportedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Funcionario", "Reporter")
                        .WithMany()
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reported");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReportFuncionario", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Funcionario", "Reported")
                        .WithMany("ListaDeReports")
                        .HasForeignKey("ReportedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Cliente", "Reporter")
                        .WithMany()
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reported");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReviewClienteDatails", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Cliente", "Reviewed")
                        .WithMany("ListaDeReviews")
                        .HasForeignKey("ReviewedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Funcionario", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewed");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("FastCleanAPI.Models.ReviewFuncionario", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Funcionario", "Reviewed")
                        .WithMany("ListaDeReviews")
                        .HasForeignKey("ReviewedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCleanAPI.Models.Cliente", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewed");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Utilizador", b =>
                {
                    b.HasOne("FastCleanAPI.Models.Morada", "Morada")
                        .WithMany()
                        .HasForeignKey("MoradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Morada");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Chat", b =>
                {
                    b.Navigation("ListaMensagens");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Cliente", b =>
                {
                    b.Navigation("ListaDeChats");

                    b.Navigation("ListaDeMarcacoes");

                    b.Navigation("ListaDeReports");

                    b.Navigation("ListaDeReviews");
                });

            modelBuilder.Entity("FastCleanAPI.Models.Funcionario", b =>
                {
                    b.Navigation("ListaDeChats");

                    b.Navigation("ListaDeMarcacoes");

                    b.Navigation("ListaDeReports");

                    b.Navigation("ListaDeReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
