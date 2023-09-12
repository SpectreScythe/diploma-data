import java.util.*;

public class EXP10ConstructorBook
{
	Scanner sc = new Scanner(System.in);

	int price;
	String name;
	String author;

	EXP10ConstructorBook()
	{
		System.out.print("Enter price of the Book:");
		price = sc.nextInt();

		sc.nextLine();

		System.out.print("Enter name of the Book:");
		name = sc.nextLine();

		System.out.print("Enter author of the Book:");
		author = sc.nextLine();

		System.out.println("Price of the Book is " + price + "$");
		System.out.println("Name of the Book is " + name);
		System.out.println("Author of the Book is " + author);
	}

	public static void main(String[] args)
	{
		EXP10ConstructorBook B = new EXP10ConstructorBook();
	}
}