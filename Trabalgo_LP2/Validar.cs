using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Validar
    {
        public static bool ValCPF(string cpf)
        {
            int[] Dig1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] Dig2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string ArmazenarCpf = "";
            string Digito;

            int soma, resto, i;

            if (cpf.Length != 11)
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(",", "").Replace("-", "");
            }
            ArmazenarCpf = cpf.Substring(0, 9);

            if ((cpf != "00000000000") && (cpf != "11111111111") && (cpf != "22222222222") &&
                (cpf != "33333333333") && (cpf != "44444444444") && (cpf != "55555555555") &&
                (cpf != "66666666666") && (cpf != "77777777777") && (cpf != "88888888888") &&
                (cpf != "99999999999"))
            {
                //Digito 1
                soma = 0;
                for (i = 0; i < 9; i++)
                {
                    soma += int.Parse(ArmazenarCpf[i].ToString()) * Dig1[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                Digito = resto.ToString();
                ArmazenarCpf = ArmazenarCpf + Digito;

                //Digito 2
                soma = 0;
                for (i = 0; i < 10; i++)
                {
                    soma += int.Parse(ArmazenarCpf[i].ToString()) * Dig2[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                Digito = resto.ToString();

                ArmazenarCpf = ArmazenarCpf + Digito;

                return cpf.EndsWith(Digito);
            }
            else
            {
                return false;
            }
        }
    }
}
