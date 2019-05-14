using System;
					
public class Program
{
	public static void Main()
	{  
	  //reading values and converting them to integers
		
	  //1st variable
	  string a1;
      Console.Write("Please give a number as 1st variable: ");
      a1 = Console.ReadLine();
      int a = Convert.ToInt32(a1);
	  
	  //2nd variable
	  string b1;
      Console.Write("Please give a number as 2nd variable: ");
      b1 = Console.ReadLine();
      int b = Convert.ToInt32(b1);
       
		//exchanging values
        a = a + b; 
        b = a - b; 
        a = a - b; 
		
		//printing exchanged values
        Console.WriteLine("The value of the 1st variable: " + a ); 
		Console.WriteLine("The value of the 2nd variable: " + b ); 
	}
}