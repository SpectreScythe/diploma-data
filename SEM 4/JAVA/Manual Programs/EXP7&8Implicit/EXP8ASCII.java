import java.util.*;
class EXP8ASCII
{

	public static void main(String args[])

	{

		Scanner sc = new Scanner(System.in);

		System.out.print("Enter a number to see their ASCII Value:");

		char n = sc.next().charAt(0);

		int c = n;

		System.out.println("ASCII value of " + n + " is ---> " + c);

	}

}