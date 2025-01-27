﻿using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos
{
    // DB First: Criar uma aplicação onde o banco de dados já existe
    // Code First: Criar um banco de dados a partir de uma aplicação existente
    // Seed: Alimentar o banco de dados com registros
    // Migration: Representação do mapeamento que será aplicado no banco de dados
    // Mapeamento: Representação da entidade em tabelas, colunas, indices...
    internal class RacaMapeamento : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {

            builder.ToTable("racas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("especie"); // NOT NULL

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnName("nome");

            // Populando a tabela de raça com dois registros
            builder.HasData(
                new Raca
                {
                    Id = 1,
                    Nome = "Frajola",
                    Especie = "Gato"
                },
                new Raca
                {
                    Id = 2,
                    Nome = "Piupiu",
                    Especie = "Capivara"
                });

        }
    }
}
