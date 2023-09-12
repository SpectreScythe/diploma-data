import java.io.*;
public class EXP13ArraySumAvg
{
    static void SumAvgArray() throws Exception
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

        int sum = 0;

        for (int i = 0 ; i < a.length ; i++)
        {
            sum += a[i];
        }

        int avg = (sum / a.length);

        System.out.println("Average : " + avg);
        System.out.println("Sum : " + sum);
    }
    public static void main(String[] args) throws Exception
    {
        SumAvgArray();
    }
}
