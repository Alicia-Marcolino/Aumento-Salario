/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 26/02/2022
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AumentoSalarioCargos
{
	class Program
	{
		public static void Main(string[] args)
		{
			float porcentagem;
			float salarioatual;
			float diferenca;
			
			Console.WriteLine("Escreva seu cargo: ");
			string cargo = Console.ReadLine();
			
			
			Console.WriteLine("Escreva seu salário: ");
			float salario = float.Parse (Console.ReadLine());
			
			{ 
				if (cargo == "gerente"){
				
		
			 porcentagem = (salario * 10/100);
			 salarioatual = (salario + porcentagem);
			 diferenca = (salarioatual - salario);
			Console.WriteLine("Salário Antigo: " + salario);
			Console.WriteLine();
			Console.WriteLine("Salário Atual: " + salarioatual);
			Console.WriteLine();
			Console.WriteLine("Diferença: " + diferenca);
			Console.WriteLine();
				}
				
				else if (cargo == "engenheiro")
				{

			porcentagem = (salario * 20/100);
			salarioatual = (salario + porcentagem);
			diferenca = (salarioatual - salario);
			Console.WriteLine("Salário Antigo: " + salario);
			Console.WriteLine();
			Console.WriteLine("Salário Atual: " + salarioatual);
			Console.WriteLine();
			Console.WriteLine("Diferença: " + diferenca);
			Console.WriteLine();
			
				}
				
			else if (cargo == "técnico")
			{
				
			porcentagem = (salario * 30/100);
			salarioatual = (salario + porcentagem);
			diferenca = (salarioatual - salario);
			Console.WriteLine("Salário Antigo: " + salario);
			Console.WriteLine();
			Console.WriteLine("Salário Atual: " + salarioatual);
			Console.WriteLine();
			Console.WriteLine("Diferença: " + diferenca);
			Console.WriteLine();
				
			}
			else{
			porcentagem = (salario * 40/100);
			salarioatual = (salario + porcentagem);
			diferenca = (salarioatual - salario);
			Console.WriteLine("Salário Antigo: " + salario);
			Console.WriteLine();
			Console.WriteLine("Salário Atual: " + salarioatual);
			Console.WriteLine();
			Console.WriteLine("Diferença: " + diferenca);
			Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
}