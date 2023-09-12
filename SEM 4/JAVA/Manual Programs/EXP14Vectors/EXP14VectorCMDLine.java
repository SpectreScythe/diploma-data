
import java.util.*;
import java.lang.*;

class EXP14VectorCMDLine
{

	public static void main(String[] args)
	{

		Vector<String> V = new Vector<String>();
		for(int i = 0 ; i < args.length ; i++)
		{
		
			V.add(args[i]);
			
		}

		System.out.println("The Vector contains the following:\n");
		System.out.println(V);
		System.out.println("Size of Vector = " + V.size());
		System.out.println("Capacity of Vector = " + V.capacity());

	}

}