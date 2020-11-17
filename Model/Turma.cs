using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoProva.Model
{
    public class Turma
    {
        public int Id { get; set; }

        public int AlunosId { get; set; }
        public ICollection<Aluno> Alunos { get; set; } }
    }
}
