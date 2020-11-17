using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoProva.Model
{
    public class AlunoDisciplina
    {

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public int DisciplicaId { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}
