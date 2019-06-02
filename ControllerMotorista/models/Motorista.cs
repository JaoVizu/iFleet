using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerMotorista.models
{
    public class Motorista
    {
        public int IdMotorista { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Cnh { get; set; }
        public String  CategoriaCnh { get; set; }
        public DateTime DataNascimento { get; set; }
        public String ExameMedico { get; set; }
        public String Email { get; set; }
        public Endereco Endereco { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
