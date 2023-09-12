import java.util.*;
public class EXP3Div6{
        public static void main(String[] args)
        {
            int n = 12;

            System.out.println("Enter an integer: 12");

            if( n % 2 == 0 )
            {
                if(n % 3 == 0)
                {
                    System.out.println("It is divisible by 6");
                }
            }
            else
                System.out.println("No is not divisible by 6");
        }
}