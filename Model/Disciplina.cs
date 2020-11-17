using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoProva.Model
{
    public class Disciplina
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public int AlunoId { get; set; }
        public List<Aluno>  Alunos { get; set; }
    }
}
