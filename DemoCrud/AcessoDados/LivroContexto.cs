﻿using DemoCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DemoCrud.AcessoDados
{
    public class LivroContexto : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }

        //Configurando o Bando de dados

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }
    }
}