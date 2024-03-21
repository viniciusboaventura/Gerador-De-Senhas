using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Maua2
{
    /*A classe Erro tem como função facilitar a chamada de
     * erros na aplicação, servindo como uma alternativa para as exceptions
     (tem maior utilidade em aplicações mais complexas)*/

    class Erro 
    {
        public static bool TemErro { get; set; }

        private static string? mensagem;
        public static string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; TemErro = true; }
        }
    }
}
