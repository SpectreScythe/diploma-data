
import java.util.*;

class EXP15CharacterMethods
{
	static void CharacterMethods()
	{
		Character ch1 = new Character('T');
		Character ch2 = new Character('9');
		Character ch3 = new Character('p');

		System.out.println("\n---Checking for digit---\n");

		System.out.println("Is Character 1 a digit? \t\t\t\t" + Character.isDigit(ch1));	
		System.out.println("Is Character 2 a digit? \t\t\t\t" + Character.isDigit(ch2));	
		System.out.println("Is Character 3 a digit? \t\t\t\t" + Character.isDigit(ch3));

		System.out.println("\n---Checking for letter---\n");

		System.out.println("Is Character 1 a letter? \t\t\t\t " + Character.isLetter(ch1));	
		System.out.println("Is Character 2 a letter? \t\t\t\t" + Character.isLetter(ch2));	
		System.out.println("Is Character 3 a letter? \t\t\t\t" + Character.isLetter(ch3));

		System.out.println("\n---Checking for letter or digit---\n");

		System.out.println("Is Character 1 a letter or a digit? \t\t\t" + Character.isLetterOrDigit(ch1));	
		System.out.println("Is Character 2 a letter or a digit? \t\t\t" + Character.isLetterOrDigit(ch2));	
		System.out.println("Is Character 3 a letter or a digit? \t\t\t" + Character.isLetterOrDigit(ch3));
		
		System.out.println("\n---Checking for Upper case---\n");

		System.out.println("Is Character 1 an Upper Case? \t\t\t\t" + Character.isUpperCase(ch1));	
		System.out.println("Is Character 2 an Upper Case? \t\t\t\t" + Character.isUpperCase(ch2));	
		System.out.println("Is Character 3 an Upper Case? \t\t\t\t" + Character.isUpperCase(ch3));

		System.out.println("\n---Checking for Lower case---\n");

		System.out.println("Is Character 1 a Lower Case? \t\t\t\t" + Character.isLowerCase(ch1));	
		System.out.println("Is Character 2 a Lower Case? \t\t\t\t" + Character.isLowerCase(ch2));	
		System.out.println("Is Character 3 a Lower Case? \t\t\t\t" + Character.isLowerCase(ch3));

		System.out.println("\n---Checking for white space---\n");

		System.out.println("Is Character 1 a white space? \t\t\t\t" + Character.isWhitespace(ch1));	
		System.out.println("Is Character 2 a white space? \t\t\t\t" + Character.isWhitespace(ch2));	
		System.out.println("Is Character 3 a white space? \t\t\t\t" + Character.isWhitespace(ch3));

		System.out.println("\n---Coverting to Upper Case---\n");

		System.out.println("Converting Character 1 to an Upper Case: \t\t" + Character.toUpperCase(ch1));	
		System.out.println("Converting Character 2 to an Upper Case: \t\t" + Character.toUpperCase(ch2));	
		System.out.println("Converting Character 3 to an Upper Case: \t\t" + Character.toUpperCase(ch3));

		System.out.println("\n---Coverting to Lower Case---\n");

		System.out.println("Converting Character 1 to a lower Case: \t\t" + Character.toLowerCase(ch1));	
		System.out.println("Converting Character 2 to a lower Case: \t\t" + Character.toLowerCase(ch2));	
		System.out.println("Converting Character 3 to a lower Case: \t\t" + Character.toLowerCase(ch3));
}

	public static void main(String[] args)
	{
		CharacterMethods();
	}
}