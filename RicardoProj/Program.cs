using System;
using System.Collections.Generic;

namespace RicardoProj
{
    public class Program
    {
        static void Main(string[] args)
        {
            // bit = 0
            // byte = 00000000
            // escala decimal = 2            
            // escala binaria = 00000000 00000000 00000000 00000000

            /*EZ*/

            // Integer, inteiros
            int numeroInteiro = 0123456789; //4 bytes -> -2,147,483,648 to 2,147,483,647
            long numeroInteiroLongo = 0123456789; //8 bytes -> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            // Floating, ponto flutuante
            float numeroFlutuante1 = 0.1f; // 4 bytes
            double numeroFlutuante2 = 0.1; // 8 bytes
            Decimal numeroFlutuante3 = 0.1m; // -79,228,162,514,264,337,593,543,950,335 to 79,228,162,514,264,337,593,543,950,335

            // Literal, literais
            char caractere = 'A'; // 2 bytes
            string texto = "ABCDEFG"; // 2 bytes por letra

            // Boolean, boleanos (lógicos)
            bool boolean = true; //ou false // 1 bit

            /*EITA GIOVANA*/

            //Arrays, conjuntos
            int[] arrayInt = { 4, 8, 15, 3 };
            // Index (indice) representa o item que você quer acessar e sempre começa em 0
            int segundoItem = arrayInt[1];
            arrayInt[3] = 45;
            int tamanho = arrayInt.Length;
            // inicializando e preenchendo depois
            int[] arrayIntA = new int[0];
            //alterando o tamanho depois
            System.Array.Resize(ref arrayIntA, 2);

            //List, listas
            List<int> listaInt = new List<int>();
            listaInt.Add(0);
            var item0DaLista = listaInt[0];
            listaInt.RemoveAt(5);

            //escrever na tela:
            // 1 - o maior numero inteiro possivel e o menor numero inteiro possivel
            // 2 - o menor numero long possivel + o maior inteiro possivel
            // 3 - a soma de dois numeros float com dois numeros double
            // 4 - um numero Decimal com precisão 12, e escala 2 (precisão -> 159,42 <- escala)
            // 5 - um texto que represente dois caracteres separados por espaço
            // 6 - a ultima tecla que foi digitada pelo usuario
            // 7 - um valor booleano somado com false e multiplicado por true
            // 8 - criar uma array de tamanho 5 e adicionar 12 valores na array, sendo que o proximo é sempre maior que o anterior
            // 9 - criar uma lista que recebera todos os textos que foram escritos na tela até agora e mostrar o tamanho Lenght da lista

            Console.WriteLine("programa terminou, aperte qualquer tecla para sair..."); // escreve coisas na tela
            Console.ReadKey(); // retorna a ultima tecla pressionada
        }
    }
}
