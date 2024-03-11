using System;
using System.Text.RegularExpressions;

namespace TP1.models
{
	public class Pessoa
	{
		private string _nome;
		private int _idade;
		private string _cpf;

		public string Nome
		{
			get { return _nome; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("O nome não pode ser nulo ou vazio.");
				}

				_nome = value;
			}
		}

		public int Idade
		{
			get { return _idade; }
			set
			{
				if (_idade < 0 || _idade > 120)
				{
					throw new ArgumentException("A idade deve estar entre 0 e 120 anos.");
				}
				_idade = value;
			}
		}

		public string CPF
		{
			get { return _cpf; }
			set
			{
				if (value.Length < 11 || value.Length > 14)
				{
					throw new ArgumentException("O CPF deve ter 11 dígitos sem pontução ou 14 incluindo as pontuações.");
				}

				_cpf = value;
			}
		}

		public Pessoa(string nome, int idade, string cpf)
		{
			Nome = nome;
			Idade = idade;
			CPF = cpf;
		}

		public override string ToString()
		{
			return $"Nome: {Nome}, Idade: {Idade}, CPF: {CPF}";
		}

	}


}
