import java.io.*;
public class EXP13SortingArray
{
    static void SortingInArray() throws Exception
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

        for (int i = 0 ; i < a.length-1 ; i++)
        {
            for (int j = i+1 ; j < a.length ; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        System.out.println("After Sorting :");

        for (int i = 0 ; i < a.length ; i++)
        {
            System.out.println("Value at position [" + (i+1) + "] : " + a[i]);
        }
    }
    public static void main(String[] args) throws Exception
    {
        SortingInArray();
    }
}
