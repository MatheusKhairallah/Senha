using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, usuário. Por favor, digite sua senha: ");
            string senha=Console.ReadLine();

            Console.Clear();

            if(senha=="1234abcd")
            Console.WriteLine("Acesso permitido");

            else
            Console.WriteLine("Acesso negado");
        }
    }
}
