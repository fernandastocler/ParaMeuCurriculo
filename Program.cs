using System;
					
public class Program
{
	public static void Main()
	{
		Console.Clear();
		
		double primeira_nota,
		       segunda_nota,
		       terceira_nota,
		       quarta_nota,
		       media;
		
		Console.WriteLine("Informar a primeira nota: ");
		primeira_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a segunda nota: ");
		segunda_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a terceira nota: ");
		terceira_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a quarta nota: ");
		quarta_nota = Convert.ToDouble(Console.ReadLine());
		
		media = (primeira_nota + segunda_nota + terceira_nota + quarta_nota) / 4.0;
		Console.WriteLine("A media é: " + media );
		
		if (media >=60)
		{
			Console.WriteLine("Aprovado");
		}
		
		else if (media >=40)
		{
			Console.WriteLine("Recuperação");
		}
		
		else
		{
			Console.WriteLine("Reprovado");
		}
	}
}