import java.util.*;
import java.lang.*;

public class ExamInterface
{
	public static void main(String[] args)
	{
		Result R = new Result(42,89,91,88 ,"John Wick");
		R.display_res();
	}
}

class Student 
{
	protected String name;
	protected int id;
	
	Student(int i,int j , int k , int l,String n)	
	{
		id = i;
		name = n;
	}
	
	void display()	
	{
		System.out.println("Age of Student \t\t: " + id);
		System.out.println("Name of Student \t: "+ name);
	}
}

interface Exam 
{
//	int basic_salary = 75000;
	public void percent_cal(int i , int j, int k, int l);
}

class Result extends Student implements Exam
{
	protected int total = 0;
	protected int p = 0;

	Result( int i ,int j , int k , int l,String n )
	{
		super(i,j,k,l,n);
		percent_cal(i,j,k,l);
		total = i+j+k+l;	
	}

	public void percent_cal(int i , int j , int k ,int l)
	{
		double p = (float)(i+j+k+l)/400*100;
		System.out.println("Perecentage \t\t: " + p);
	}

	void display_res()
	{
		super.display();
		System.out.println("Total Marks \t\t: " + total);
		
	}
}