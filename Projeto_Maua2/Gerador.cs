using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Maua2
{
    class Gerador //classe responsavel pelos métodos geradores principais.
    {
      public static string GeraNumero(int Max)
        {
         Random gera = new Random(); //instancia da Classe Random de nome gera, com metodos capazes de criar seqiencias aleatórias

            string numero = "";
            for (int i = 0; i < Max; i++) //percorre um loop para gerar numeros com o nº de caracteres indicado pelo usuario.
            {
                numero += gera.Next(0, 10); // gera um dígito aleatório entre 0 e 9
            }
            return numero;
        }

        public static string GeraCaracter(int Tamanho)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; //variavel contendo o alfabeto em maiusculo e minusculo.
            char[] senha = new char[Tamanho]; //char com o tamanho desejado pelo usuario, no qual percorrerá um loop para adicionar caracteres.

            Random gera = new Random();

            for (int i = 0; i < Tamanho; i++) //loop que adiciona um caractere entre os disponiveis aleatoriamente a cada iteração
            {
                senha[i] = chars[gera.Next(chars.Length)];
            }

          

            return new string (senha); //retorno da array char 'senha' em formato string
        }

        public static string GeraNumLetra(int Tamanho)
        {
            Random gera = new Random();
            const string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789"; //variavel que armazena os números de 0 a 9
            char[] senha = new char[Tamanho];

            senha[0] = numeros[gera.Next(numeros.Length)];  // garante que a senha contenha pelo menos um número

           
            for (int i = 1; i < Tamanho; i++)  // preencher o restante da senha com caracteres aleatórios
            {
                senha[i] = letras[gera.Next(letras.Length)];
            }

            
            for (int i = 0; i < Tamanho; i++) // embaralha a senha para garantir aleatoriedade
            {
                int j = gera.Next(i, Tamanho);
                char temp = senha[i];
                senha[i] = senha[j];
                senha[j] = temp;
            }

            return new string(senha);

        }

        public static string GeraTudo(int Tamanho)
        {
            Random gera = new Random();
            const string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            const string especiais = "!@#$%^&*()-_=+[{]}|;:,<.>/?"; //variavel armazenando os caracteres especiais
            char[] senha = new char[Tamanho];

            
            senha[0] = numeros[gera.Next(numeros.Length)];


            senha[1] = especiais[gera.Next(especiais.Length)]; // garantir que a senha contenha pelo menos um caractere especial

            senha[2] = especiais[gera.Next(especiais.Length)];


            for (int i = 3; i < Tamanho; i++) //preenche o restante da senha com letras
            {
                senha[i] = letras[gera.Next(letras.Length)];
                
                
            }

           
            for (int i = 0; i < Tamanho; i++) // loop para embaralhar a senha
            {
                int j = gera.Next(i, Tamanho);
                char temp = senha[i];
                senha[i] = senha[j];
                senha[j] = temp;
            }

            return new string(senha);
        }
           
    }
        
        
}

