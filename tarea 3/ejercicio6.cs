using System;
					
public class Program
{
	public static void Main()
	{
		 // ejercicio #6
		
		
		Console.WriteLine("Escriba el primer numero");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escriba el segundo numero");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		if (num2 > 0)
		{
			Console.WriteLine(" El resultado de la division de los dos numero es: " + num/num2);
			
		}	
		
		else
		{
		    Console.WriteLine(" Error: No se puede dividir entre cero");
			
		}	
			
	}
}
