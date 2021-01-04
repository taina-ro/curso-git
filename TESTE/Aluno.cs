using System;
using System.Collections.Generic;
using System.Text;

namespace TESTE
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string Nome;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
                return true;
            else
                return false;
        }

        public double Resto()
        {
            if (Aprovado() == false)
                return 60.0 - NotaFinal();
            else
                return 0.0;
        }

    }
}
