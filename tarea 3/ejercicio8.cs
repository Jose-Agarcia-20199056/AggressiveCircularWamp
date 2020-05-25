using System;
					
public class Program
{
	public static void Main()
	{
		// ejercicio # numeros positivos o negativos  
		
		Console.WriteLine("Escriba el primer numero entero");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escriba el segundo numero entero");
		int num2 = Convert.ToInt32(Console.ReadLine());
		 
		if (num > 0)		
		{  if (num2 < 0)
		   {  
			Console.WriteLine(" el primer numero es positivo"); 
			
		   }
			
		     if(num > 0)
		  {   if (num2 > 0)
		     
			 {
			      Console.WriteLine(" Los dos numeros son positivos");
		     }
		   }   
			   
		 }
		
	    else  
	     {  
		     Console.WriteLine(" ninguno de los numeros es positivo");
			 
			
		 }
		
	}
}
