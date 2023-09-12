
class EXP11N12StringActivity
 {
    
    static void StringMethods() 
	{
        
		String s1 = "Horizon";
		String s2 = new String("Ghost Of Tsushima");
		char[] ch = {'R','E','7'};	
		String s3 = new String(ch);
        
		//charAt()
		System.out.println("The character at index 4 in s2 is : " + s2.charAt(4));

		//equals()	
		System.out.println("Are strings s1 and s2 equal with integers? ---> " + s1.compareTo(s2));
		s2 = s1;
		System.out.println("After copying s1 into s2 , are the strings s1 and s2 equal with integers? ---> " + s1.compareTo(s2));

		//equals()	
		System.out.println("After copying - Are strings s1 and s2 equal? ---> " + s1.equals(s2));
		s2 = ("Ghost Of Tsushima");
		System.out.println("After copying OG value - Are strings s1 and s2 equal? ---> " + s1.equals(s2));		

		//equalsIgnoreCase()
		s2 = s1;
		System.out.println("Are strings s1 and s2 equal if we ignore thier casings? ---> " + s1.equalsIgnoreCase(s2));
		s2 = ("Ghost Of Tsushima");
		System.out.println("After copying OG value - Are strings s1 and s2 equal if we ignore thier casings? ---> " + s1.equalsIgnoreCase(s2));

		//equals()	
		System.out.println("The length of string s3 is : " + s3.length());
		System.out.println("The length of string s2 is : " + s2.length());

		//replace()	
		System.out.println(s2);
		System.out.println("Replacing \'S\' with \'$\' in String s2" + s2.replace("s","$"));

		//startsWith()	
		System.out.println("Does string s3 start with \'R\'? " + s3.startsWith("R"));
		System.out.println("Does string s3 start with \'h\'? " + s3.startsWith("h"));
    	
		//endsWith()	
		System.out.println("Does string s3 end with \'7\'? " + s3.endsWith("7"));
		System.out.println("Does string s3 end with \'l\'? " + s3.endsWith("l"));

		//indexOf()	
		System.out.println("First Index of \'o\' in string s1 : " + s1.indexOf("o"));
		System.out.println("First Index of \'s\' in string s1 :" + s2.indexOf("s"));

		//lastIndexOf()	
		System.out.println("Last Index of \'o\' in string s1 : " + s1.lastIndexOf("o"));
		System.out.println("Last Index of \'s\' in string s1 :" + s2.lastIndexOf("s"));

		//substring()
		System.out.println("Substring of s2 from index 3 - 11 is : " + s2.substring(3 , 11));

	}
    
    public static void main(String[] args) 
	{
		StringMethods();     
   	 }
}