
import java.util.*;

class EXP10ConstructorStudent
{
	String name;
	int rollno;

	EXP10ConstructorStudent(int a , String b)
	{
		this.rollno = a; 
		this.name = b;

		System.out.println("Name = "  + name);
		System.out.println("Rollno = "  + rollno);
	}

	public static void main(String[] args) 
	{
		EXP10ConstructorStudent O = new EXP10ConstructorStudent(210451 , "Dawg Qureshi");
	}
}