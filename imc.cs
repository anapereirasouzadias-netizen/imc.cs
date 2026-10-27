using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		//Declaração de variáveis
		String nome;
		double altura;
		double peso;
		double imc;
	
		
		//Coleta das variáveis
		Console.WriteLine("insira o nome");
	    nome= Console.ReadLine();
		Console.WriteLine("insira o peso");	 
	 	peso = Convert.ToDouble(Console. ReadLine());
		Console.WriteLine("insira altura");	 
	    altura = Convert.ToDouble(Console. ReadLine());
	    imc = peso/(altura*altura);
		if (imc >= 18.5 && imc <= 24.99){
			Console.WriteLine(nome + " seu imc é " +imc+ " seu peso está normal");
		} 
		else if (imc >= 25 && imc <= 29.99){
			Console.WriteLine(nome + " seu imc é " +imc+ " você está com sobrepeso");
		}
		else if (imc >= 30){
			Console.WriteLine(nome + " seu imc é " +imc+ " você está obeso");
		}
																							 															
		else {
			Console.WriteLine(nome + " seu imc é " +imc+ " você está abaixo do peso");
	    }
	}
}
							 
																									 
																				