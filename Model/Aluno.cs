using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RevisaoProva.Model
{
    public class Aluno
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public int Periodo { get; set; }

        public int Idade { get; set; }

        public int DisciplinasId { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public IList<AlunoDisciplina> AlunoDisciplina { get; set; }
    }
}
