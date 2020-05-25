using System;
					
public class Program
{
	public static void Main()
	{
		// ejercicio #  múltiplo del segundo 
		
		Console.WriteLine("Escriba el primer numero entero");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escriba el segundo numero entero");
		int num2 = Convert.ToInt32(Console.ReadLine());
		 
		
		 
		if (num% num2 ==  0)
		{
			
			Console.WriteLine("El primer numero es muliplo del segundo" );
			
		}
		
	    else 
		{
		  Console.WriteLine("el primer numero no es multiplo del segundo ");    
		
		}
		
	}
}
