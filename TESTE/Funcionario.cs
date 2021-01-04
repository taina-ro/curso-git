using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace TESTE
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            double Porcentagem = SalarioBruto * porcentagem / 100;
            SalarioBruto += Porcentagem;
        }
        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
