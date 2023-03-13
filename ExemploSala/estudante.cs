using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSala
{
    internal class Estudante
    {
        public string RA;
        public string nome;
        public double notaBim1;
        public double notaBim2;

        public string relatorio()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("Nome: {0}\n", nome);
            sb.AppendFormat("RA: {0}\n", RA);
            sb.AppendFormat("Nota 1º Bimestre {0}\n", notaBim1);
            sb.AppendFormat("Nota 2º Bimestre {0}\n", notaBim2);
            
            return sb.ToString();
        }
    }
}
