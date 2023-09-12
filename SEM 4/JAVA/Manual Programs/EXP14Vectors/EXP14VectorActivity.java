
import java.util.*;
import java.lang.*;

class EXP14VectorActivity
{
	public static void main(String[] args)
	{
		Vector V = new Vector();
	
		//Integers		

		int x = 1;
		V.addElement(x);
	
		for(int i = 2 ; i <= 4 ; i ++)
		{
			V.addElement(i);
		}
	
		V.addElement(new Integer(5));

		//Strings

		V.addElement(new String("Walter White"));
		V.addElement(new String("Jesse Pinkman"));
		
		V.addElement("Gustavo Fring");

		//Characters

		V.addElement('$');
		V.addElement('@');
		V.addElement('#');
		
		//Float

		V.addElement(new Float(3.14));
		V.addElement(new Float(420.69));
		
		V.addElement(20.22);

		System.out.println("Original Vector");
		System.out.println(V);
		System.out.println("Size of Vector = " + V.size());
		System.out.println("Capacity of Vector = " + V.capacity());

		V.addElement(new String("Hank Schrader"));
		V.removeElementAt(1);
		if(V.contains(new String("Gustavo Fring")))
			System.out.println("String \'Gustavo Fring\' Found");
		else
			System.out.println("String \'Gustavo Fring\' not found");
		System.out.println("First element of Vector : "+V.elementAt(0));
		System.out.println("Last element of Vector : "+V.elementAt(V.size()-1));
		System.out.println("Latest Vector");
		System.out.println(V);


	}
}