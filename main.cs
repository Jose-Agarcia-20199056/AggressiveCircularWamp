using System;
					
public class Program
{
	public static void Main()
	{
		// ejercicio # numero par 
		
		Console.WriteLine("Escriba un numero entero");
		int num = Convert.ToInt16(Console.ReadLine());
		 
		if (num % 2 ==0)
		{
			
			Console.WriteLine("El numero es par");
			
		}
		
		else
		{
		  Console.WriteLine("El numero es impar");    
		
		}
		
	}
}
