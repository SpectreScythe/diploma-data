import java.util.*;

public class EXP3OddoEven {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        System.out.println("\nEnter an integer:");
        int num = scanner.nextInt();
        if (num %2 ==0)
        {
            System.out.println(num + " is even");
        }
        else
        {
            System.out.println(num + " is odd");
        }
    }

}
