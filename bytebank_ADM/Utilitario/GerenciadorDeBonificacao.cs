using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double SalarioAtualizado { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            funcionario.Salario += funcionario.GetBonificacao();
        }
    }
}
