﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaRH.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios{ get; set; } = default!;
        public DbSet<Atividade> Atividades { get; set; } = default!;
        public DbSet<ValorHora> ValorHoras { get; set; } = default!;
        public DbSet<Trabalho> Trabalhos { get; set; } = default!;

    }
}