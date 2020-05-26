using System;
					
public class Program
{
	public static void Main()
	{
		
	
	     // ejercicio numero 9  cual es el mayor de 3	
		Console.WriteLine("Escribre el primer numero ");
		float num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escribre el segundo numero");
		float num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escribre el tercer numero");
		float num3 = Convert.ToInt32(Console.ReadLine());
		
		if (num>num2)
	    {  if(num>num3)
		   {
			 Console.WriteLine("Escribre el primer numero es mayor");
		   }
			
		}
		
		else if (num2>num && num2>num3)
			
		{
		  Console.WriteLine("El Segundo numero es mayor");
		
		}
		else if (num3>num && num3>num2)
		{
		   Console.WriteLine("El tercer numero es mayor");
		}	
	}
}