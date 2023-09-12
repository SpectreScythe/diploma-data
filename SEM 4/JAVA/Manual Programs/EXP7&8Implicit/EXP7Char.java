import java.util.*;

class EXP7Char
{

	public static void main(String args[])
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter a number : ");
		char c = sc.next().charAt(0);
		System.out.println();
		int i = c;
		float f  = c;
		double s = c;
		long l = c;
		System.out.println("In character format : " + c);
		System.out.println("In integer format : " + i);
		System.out.println("In float format : " + f);
		System.out.println("In short format : " + s);
		System.out.println("In long format : " + l);
	}

}