

namespace nomesIdades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Nomes/Idades deseja cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];


            for (int i = 0; i < quantidade.Length; i++)
            {
                Console.Write("Escreva o nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Escreva a idade: ");
                nomes[i] = Console.ReadLine();
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($ "Nome: {nomes[i]}, Idade: {idades[i]}");
            }
        }             
    }
}
