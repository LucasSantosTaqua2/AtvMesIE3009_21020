using System;

namespace AtvMesIE
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;

            Console.WriteLine("Por favor digite o numero do mês que deseje saber a quantidade de dias");
            Console.WriteLine("Caso não saiba o numero do mês que deseje saber digite 0 para ajuda");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Janeiro tem 31 dias");
                Console.WriteLine("-----------------------");
            }

            if (mes == 2)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Fevereiro tem 28 ou 29 dias");
                Console.WriteLine("----------------------------");

            }

            if (mes == 3)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Março tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 4)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Abril tem 30 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 5)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Maio tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 6)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Junho tem 30 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 7)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Julho tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 8)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Agosto tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 9)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Setembro tem 30 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 10)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Outubro tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 11)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Novembro tem 30 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 12)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Dezembro tem 31 dias");
                Console.WriteLine("-----------------------");

            }

            if (mes == 0)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Janeiro = 1");
                Console.WriteLine("Fevereiro = 2");
                Console.WriteLine("Março = 3");
                Console.WriteLine("Abril = 4");
                Console.WriteLine("Maio = 5");
                Console.WriteLine("Junho = 6");
                Console.WriteLine("Julho = 7");
                Console.WriteLine("Agosto = 8");
                Console.WriteLine("Setembro = 9");
                Console.WriteLine("Outubro = 10");
                Console.WriteLine("Novembro = 11");
                Console.WriteLine("Dezembro = 12");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Depois de localizar o mês desejado reinicie a aplicação");
            }

            else {
                Console.WriteLine("Por favor digite um numero valido");
            }










        }
    }
}
