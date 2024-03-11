using TP1.models;

namespace TP1
{
	public class Program
	{
		private static List<Pessoa> _pessoas = [];

		public static void Main(string[] args)
		{
			// Cria uma instância da classe Pessoa
			Pessoa pessoa1 = new Pessoa("João Silva", 31, "123.456.789-00");

			// Apresenta a pessoa na tela
			Console.WriteLine(pessoa1.ToString());

			// Cria um menu em um laço infinito
			while (true)
			{
				// Mostra as opções do menu
				Console.WriteLine("------------------");
				Console.WriteLine("Opções:");
				Console.WriteLine("1 - Adicionar Pessoa");
				Console.WriteLine("2 - Mostrar Pessoas");
				Console.WriteLine("0 - Sair");
				Console.WriteLine("------------------");

				// Lê a opção do usuário
				int opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 1:
						AdicionarPessoa();
						break;
					case 2:
						MostrarPessoas();
						break;
					case 0:
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Opção inválida!");
						break;
				}
			}
		}

		private static void AdicionarPessoa()
		{
			// Lê os dados da pessoa
			Console.WriteLine("Digite o nome:");
			string nome = Console.ReadLine();

			Console.WriteLine("Digite a idade:");
			int idade = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o CPF:");
			string cpf = Console.ReadLine();

			// Cria uma nova instância da classe Pessoa
			Pessoa pessoa = new Pessoa(nome, idade, cpf);

			// Adiciona a pessoa à lista
			_pessoas.Add(pessoa);

			Console.WriteLine("Pessoa adicionada com sucesso!");
		}

		private static void MostrarPessoas()
		{
			// Mostra todas as pessoas da lista
			foreach (Pessoa pessoa in _pessoas)
			{
				Console.WriteLine(pessoa.ToString());
			}
		}
	}

}
