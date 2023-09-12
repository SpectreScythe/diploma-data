import javax.lang.model.util.ElementScanner6;

public class argsEO
{
    public static void main(String[] n)
    {
        int x = Integer.parseInt(n[0]);

        if (x%2==0)
        {
            System.out.println("Even");
        }
        else
        {
            System.out.println("Odd");
        }
    }
}
