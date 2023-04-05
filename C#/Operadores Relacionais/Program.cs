using System;

namespace Operadores_Relacionais
{
    class Program
    {
        static void Main()
        {
            /*
            double nota1 = 8.0;
            double nota2 = 9.0;

            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);
            */
            /*
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota == 10.0);
            */

            /*
            var atividade1 = true;
            var atividade2 = false;

            var todas = atividade1 && atividade2;

            Console.WriteLine("Fez todas as atividades ? {0}", todas);

            var umaApenas = atividade1 || atividade2;

            Console.WriteLine("Fez pelo menos uma das atividades ? {0}", umaApenas);

            Console.WriteLine("Não fez nenhuma ? {0}", !umaApenas);
            */

            //&& = e
            //|| = ou
            //! = not


            /*
            //Operadores Unários
            var X = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!X);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);

            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n2-- == ++n1);
            */

            /*
            //if = se
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2){
                Console.WriteLine(n1 + n2);
            }
            if (n3 < n2){
                Console.WriteLine(n3 + n2);
            */

            /*
            //else =  se não
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2) {
                Console.WriteLine("Condição 1 é satisfeita !!");
                Console.WriteLine("Resultado da soma é {0}", n1 + n2);
            }
            if (n3 < n2) {
                Console.WriteLine(n3 + n2);
            }
            else {
                Console.WriteLine("Condição 2 não é satisfeita!!.");
            */

            /*
            //while repetição erro
            var n1 = 1;
            

            while (n1 <= 15)
            {
                Console.WriteLine(n1);
                n1 ++;
            */


            /*
            //aprovado ou não kkk

            float media = 0;

            Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");

            Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno!");

            Console.WriteLine("Digite a primeira nota: ");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Digite a segunda nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Digite a terceira nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno é: {0}", media);

                if(media < 7)
            {
                Console.WriteLine("Aluno está de recuperação");
            }
            else
            {
                Console.WriteLine("Aluno aprovado");
            }
            */

            //Calculadora soma

            bool opcao = true;

            Console.WriteLine("Olá, irei realizar a soma de numeros que você deseja até você desejar parar");

            Console.WriteLine("Digite o valor inicial: ");
            float.TryParse(Console.ReadLine(), out float inicial);

            while (opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial: ");
                float.TryParse(Console.ReadLine(), out float n1);
                inicial = inicial + n1;
                Console.WriteLine("A soma até o momento é {0}", inicial);
                Console.WriteLine("Deseja sair do programa? 1 - sim 2 - não");
                int.TryParse(Console.ReadLine(), out int saida);
                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Saindo do programa.");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continuando a Soma.");
                        break;
                    default:
                        Console.WriteLine("Opção Inváçida. Retornandon para soma.");
                        break;
                }
            }

        }
    }
}