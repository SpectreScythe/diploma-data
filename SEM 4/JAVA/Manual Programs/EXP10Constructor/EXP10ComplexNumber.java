import java.util.*;
class EXP10ComplexNumber
{
	int realNum1;
	int imaginaryNum1;

	EXP10ComplexNumber(int realNum1, int imaginaryNum1)
	{	
		this.realNum1 = realNum1;
		this.imaginaryNum1 = imaginaryNum1;		
	}

	EXP10ComplexNumber()
	{	
		this(0,0);		
	}
	
	static void Add(EXP10ComplexNumber A, EXP10ComplexNumber B) {
		EXP10ComplexNumber C = new EXP10ComplexNumber();
		C.realNum1 = A.realNum1 + B.realNum1;
		C.imaginaryNum1 = A.imaginaryNum1 + B.imaginaryNum1;
		System.out.println("Result : " + C.realNum1 + " + " + C.imaginaryNum1 + "i");
	}

	void display() {
		System.out.println("Result : " + realNum1 + " + " + imaginaryNum1 + "i");
	}

	public static void main(String[] args)
	{
		EXP10ComplexNumber S1 = new EXP10ComplexNumber(10, 20);
		EXP10ComplexNumber S2 = new EXP10ComplexNumber(5, 5);
		S1.display();
		S2.display();
		Add(S1, S2);
		
	}
}