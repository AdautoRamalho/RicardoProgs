using RicardoProj.Models;
using System;

namespace RicardoProj
{
    public class Program
    {
        static void Main(string[] args)
        {
            var utils = new Utils();

            utils.InsertAdminMenu();

            Console.WriteLine();
            Console.WriteLine("programa terminou, aperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }

    public class Utils
    {
        public void InsertAdminMenu()
        {
            Console.WriteLine("Cadastro de Administradores do Sistema");

            do
            {
                var createdAdmin = CreateAdmin();

                SaveAdmin(createdAdmin);

                Console.WriteLine("Deseja repetir o processo? se sim, precione S");
            } while (Console.ReadKey(true).Key == ConsoleKey.S);
        }

        private void SaveAdmin(Admin adminToSave)
        {

        }

        private Admin CreateAdmin()
        {
            var newAdmin = new Admin();            
            //hey, computador, separa aí um pedaço da memória pra eu salvar as coisas do meu User

            Console.WriteLine();
            Console.WriteLine("Digite o nome do Admin e aperte ENTER!");
            newAdmin.DisplayName = Console.ReadLine();
            //hey, computador, pega o que quer que seja que veio do método ReadLine, e joga pra dentro do DisplayName,
            // lá naquele lugar da memória que vc salvou pra mim
            Console.WriteLine("Digite o login do Admin e aperte ENTER!");
            newAdmin.UserName = Console.ReadLine();
            Console.WriteLine("Digite a senha do Admin e aperte ENTER!");
            newAdmin.Password= Console.ReadLine();

            Console.WriteLine($"As iniciais do {newAdmin.Id}, são: {newAdmin.Initials}");

            return newAdmin;
        }
    }
}
