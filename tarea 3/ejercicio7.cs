using System;
					
public class Program
{
	public static void Main()
	{
		// ejercicio # numero par 
		
		Console.WriteLine("Escriba un numero entero");
		int num = Convert.ToInt32(Console.ReadLine());
		 
		
		 
		if ( num % 4 == 0 )
		{
			
			Console.WriteLine("El primer numero es multiplo de 4" );
			
		}
		
	    else  if (num % 5 == 0)
		{
		  Console.WriteLine("el primer numero es multiple de 5 ");    
		
		}
		
		
		 else 
		 {	
			 
			 Console.WriteLine("el primer numero no es multiplo  de 4 ni de 5 ");    
		
		 }	
	}
}
