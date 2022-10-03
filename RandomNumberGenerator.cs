using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		Random x = new Random();
		
		int num = x.Next(2000,3000);
		
	    Console.WriteLine(num);
	}
}

/*
Next()	Returns a positive random integer within the default range -2,147,483,648 to 2,147,483, 647.
Next(int)	Returns a positive random integer that is less than the specified maximum value.
Next(int, int)	Returns a positive random integer within the specified minimum and maximum range (includes min and excludes max).
NextDouble()	Generates random floating-point number that is greater than or equal to 0.0 and less than 1.0.
NextByte()	Fills the specified array with the random bytes.
*/
