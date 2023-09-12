import java.util.*;
public class EXP4TernaryOperator {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Which year is it?");
        int flag = 0;
        boolean con=true;
        int year = scanner.nextInt();
        String s = (year%4 == 0) ? "it is a leap year" :  "it is not a leap year";
        System.out.println(s);
    }

}
