using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Maua2
{
    class GeradorBLL //
    {
        public static void ValidaEntrada(string Tamanho)    /*metodo capaz de validar a entrada do usuario,
                                                             * detectando caso não seja um número e caso o número
                                                             * digitado não esteja dentro do solicitado */
        {
            Erro.TemErro = false;

            if (!int.TryParse(Tamanho, out _))
            {
                Erro.Mensagem = "Digite um número válido.";
            }


           else if (int.Parse(Tamanho) < 4 || int.Parse(Tamanho) > 120)
            {
                Erro.Mensagem = "Tamanho inválido! \n Digite apenas entre 4 e 120";
                return;
            }

        }
    }
}
