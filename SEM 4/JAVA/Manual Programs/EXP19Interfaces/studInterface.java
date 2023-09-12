import java.util.*;
import java.lang.*;

public class studInterface
{
	public static void main(String[] args)
	{
		Result R = new Result(51 ,"Ethan Winters", 85,87);
		R.display();
	}
}

class Student
{
	protected String name;
	protected int id;
	
	Student(int i,String n)	
	{
		id = i;
		name = n;
	}
	
	void display()	
	{
		System.out.println("\nUnique ID of Student \t: " + id);
		System.out.println("Name of Student \t: "+ name);
	}
}

class Exams extends Student
{
	protected int m1;
	protected int m2;

	Exams(int i, String d,int mrk1 , int mrk2)
	{
		super(i,d);
		m1 = mrk1;
		m2 = mrk2;
	}

	void display()	
	{	
		super.display();
		System.out.println("Marks in Subject A \t: " + m1);
		System.out.println("Marks in Subject B \t: " + m2);
	}
	
}

interface Sports 
{
	int mrk = 7;
}

class Result extends Exams implements Sports
{
	protected int total = 0;
	
	Result( int i ,String n , int m , int b)
	{
		super(i,n ,m,b);
		total = m1 + m2;	
	}

	void display()
	{
		super.display();
		System.out.println("Total Marks \t\t: " + total);
	}
}