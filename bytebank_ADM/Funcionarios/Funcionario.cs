using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual double SalarioAtualizado()
        {
            return Salario + GetBonificacao();
        }

        public override string ToString()
        {
            return Nome + ", " +  Cpf + ", " + SalarioAtualizado().ToString("C2", CultureInfo.CurrentCulture);
        }
    }
}
