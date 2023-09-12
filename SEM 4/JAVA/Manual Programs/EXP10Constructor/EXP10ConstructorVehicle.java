
import java.util.*;

class EXP10ConstructorVehicle
{
	String name;
	int rollno;

	EXP10ConstructorVehicle(int a , String b)
	{
		this.rollno = a; 
		this.name = b;
	}

	EXP10ConstructorVehicle(EXP10ConstructorVehicle O)
	{
		name = O.name; 
		rollno = O.rollno;

		System.out.println("Model = " + this.name);
		System.out.println("Plate Number = " + this.rollno);
	}

	public static void main(String[] args) 
	{
		EXP10ConstructorVehicle O = new EXP10ConstructorVehicle(3035 , "Honda Amaze");
		EXP10ConstructorVehicle R = new EXP10ConstructorVehicle(O);		
	}
}