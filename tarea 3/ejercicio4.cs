
using System;
					
public class Program
{
	public static void Main()
	{
		// ejercicio # multiplo de 10
	
		
		Console.WriteLine("Escriba un numero entero");
		int num = Convert.ToInt32(Console.ReadLine());
		 
		
		 
		if ( num % 10 == 0 )
		{
			
			Console.WriteLine("el numero es multiplo de 10" );
			Console.WriteLine("escribe un segundo numero" );			
            int num2 = Convert.ToInt32(Console.ReadLine());
			
		 	if	(num2 % 10 == 0)	
			{ 
			         
		        Console.WriteLine("el segundo numero es multiplo de 10" );		
		 
			}
			
			else 
			{
			  
				Console.WriteLine("el segundo numero no es multiplo de 10" );
			}
			
			
		}
		
	      
		
		
		 else 
		 {	
			 
			 Console.WriteLine(" el primer numero no es multiplo de 10 ");    
		
		 }	
	}
}
