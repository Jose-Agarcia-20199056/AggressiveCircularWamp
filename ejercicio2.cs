using System;
          
public class Program
{
  public static void Main()
  {
    // ejercicio #2 cual numero es mayor 
    
    Console.WriteLine("Escriba el primer numero entero");
    int num = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Escriba el segundo numero entero");
        int num2 = Convert.ToInt16(Console.ReadLine());
     
    if ( num>num2)
    {
      
      Console.WriteLine("El primer numero es mayor");
      
    }

        else if  ( num<num2)
        {

              Console.WriteLine("El segundo numero es mayor");
        }
    
    else
    {
      Console.WriteLine(" Ambos son iguales ");    
    
    }
    
  }
}


