using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoProva.Model
{
    public class RevisaoProvaContext : DbContext
    {
        public DbSet<Turma> Turmma { get; set; }

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<Disciplina> Disciplina { get; set; }

        public DbSet<AlunoDisciplina> Aluno_disciplina { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=revisao_prova;user=root;password=root");
        }
    }
}
