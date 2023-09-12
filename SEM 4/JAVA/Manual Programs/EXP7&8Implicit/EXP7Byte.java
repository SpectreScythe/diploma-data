import java.util.*;

class EXP7Byte
{

	public static void main(String args[])
	{
		byte n;
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter a number form 0 to 127 : ");
		n = sc.nextByte();
		System.out.println();
		char c = (char) n;
		int i = n;
		float f  = n;
		short s = n;
		long l = n;
		System.out.println("In character format : " + c);
		System.out.println("In integer format : " + i);
		System.out.println("In float format : " + f);
		System.out.println("In short format : " + s);
		System.out.println("In long format : " + l);
	}

}