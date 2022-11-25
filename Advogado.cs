using System;
using System.Collections.Generic;

namespace Advocacia
{
   public class Advogado
    {

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Sexo { get; set; }

        public bool verificarSeAdvogadoEMaiordeIdade()
        {
            if (this.Idade>=18)
            {
                return false;
            }
            else
            {
                return false;
            }
           
        }
        public List<Advogado> getAllAdvogados()
        {
            return null;

        }

    }
}
