class EXP11N12StringBufferTest
{
	public static void main(String args[])
	{
		
		StringBuffer sb1=new StringBuffer();  //creates empty string 
		
		StringBuffer sb2=new StringBuffer("The Forbidden West");
		StringBuffer sb3=new StringBuffer(25);  

		//length()
		System.out.println("\nLengths of the respective strings:\n");
		System.out.println("Length of StringBuffer sb1: "+sb1.length());
		System.out.println("Length of StringBuffer sb2: "+sb2.length());
		System.out.println("Length of StringBuffer sb3: "+sb3.length());
		
		//capacity
		System.out.println("\nCapacity of the respective strings:\n");
		System.out.println("Capacity of StringBuffer sb1: "+sb1.capacity());
		System.out.println("Capacity of StringBuffer sb2: "+sb2.capacity());
		System.out.println("Capacity of StringBuffer sb3: "+sb3.capacity());

		//append
		System.out.println("\nAppending string 3:\n");
		sb3.append("Napolean");
		System.out.println("StringBuffer sb3: "+sb3);
		System.out.println("Length of StringBuffer sb3: "+sb3.length());
		System.out.println("Capacity of StringBuffer sb3: "+sb3.capacity());

		//reverse()
		System.out.println("\nReversing String 2:\n");
		sb2.reverse();
		System.out.println("StringBuffer sb2 after reverse: "+sb2);

		//delete
		System.out.println("\nDeleting some part of string 2:\n");
		sb2.delete(2,6);
		System.out.println("StringBuffer sb2: "+sb2);

		//substring(si) and substring(si,ei)
		
		//insert()
		System.out.println("\nInserting in string 2:\n");
		sb3.insert(0, "C ");
		System.out.println("StringBuffer sb3: "+sb3);

		//replace()
		System.out.println("\nReplacing in string 3:\n");
		sb3.replace(2,6,"Bonaparte");
		System.out.println("StringBuffer sb3: "+sb3);

		
	}
}