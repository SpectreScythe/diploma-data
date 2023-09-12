import java.util.*;

class EXP7Kilo
{

	public static void main(String args[])
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter a number to convert to miles and meters : ");
		int km = sc.nextInt();
		System.out.println();
		double miles = (km / 1.6);
		double meters = km * 1000;
		System.out.println("In KM : " + km);
		System.out.println("In M : " + meters);
		System.out.println("In MI : " + miles);
	}

}