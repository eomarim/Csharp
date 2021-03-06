﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSalesMvc.Data;

namespace WebSalesMvc.Migrations
{
    [DbContext(typeof(WebSalesMvcContext))]
    partial class WebSalesMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebSalesMvc.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("WebSalesMvc.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("StatusVenda");

                    b.Property<double>("Valor");

                    b.Property<int?>("VendedorVendaId");

                    b.HasKey("Id");

                    b.HasIndex("VendedorVendaId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("WebSalesMvc.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartamentoVendedorId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoVendedorId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("WebSalesMvc.Models.Venda", b =>
                {
                    b.HasOne("WebSalesMvc.Models.Vendedor", "VendedorVenda")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorVendaId");
                });

            modelBuilder.Entity("WebSalesMvc.Models.Vendedor", b =>
                {
                    b.HasOne("WebSalesMvc.Models.Departamento", "DepartamentoVendedor")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoVendedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
