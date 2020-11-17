using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoProva.Model
{
    public class TurmaAluno
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
