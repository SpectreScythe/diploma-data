import java.util.Scanner;

class Student
{
    Scanner sc = new Scanner(System.in);
    int age;

    void getdatastud()
    {
        age = sc.nextInt();
    }

    void putdatastud()
    {
        System.out.println("Age --> " + age);
    }
}

public class StudentClass
{
    public static void main(String[] args)
    {
        Student s1 = new Student();
        s1.getdatastud();
        s1.putdatastud();
    }
}