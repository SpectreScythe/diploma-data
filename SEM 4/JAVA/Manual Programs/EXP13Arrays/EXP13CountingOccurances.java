import java.io.*;
public class EXP13CountingOccurances
{
    static void CountingElement() throws Exception
    {
        InputStreamReader r=new InputStreamReader(System.in);
        BufferedReader br=new BufferedReader(r);

        System.out.print("Enter the size of the array: ");
        int n = Integer.parseInt(br.readLine());
        int[] a = new int[n];

        for (int i = 0 ; i < a.length ; i++)
        {
            System.out.print("Enter value for position [" + (i+1) + "] : ");
            a[i] = Integer.parseInt(br.readLine());
        }

        System.out.print("Enter element to be counted: ");
        int ToBeSearched = Integer.parseInt(br.readLine());
        //br.readLine();

        int flag = 0;

        for (int j : a) {
            if (j == ToBeSearched) {
                flag++;
            } else {
                continue;
            }
        }

        if (flag == 0 ){
            System.out.println("Element does not exist...");
        }
        else {
            System.out.println("Element " + ToBeSearched + " is present " + flag + " times in the array...");
        }
    }
    public static void main(String[] args) throws Exception
    {
        CountingElement();
    }
}
