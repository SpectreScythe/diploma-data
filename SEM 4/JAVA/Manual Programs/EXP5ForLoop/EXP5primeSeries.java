import java.util.Scanner;

public class EXP5primeSeries {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Range : ");
        int n = sc.nextInt();
        int count = 0;
        System.out.print("Prime Series : ");
        for (int i = 1; i <= n; i++) {
            count = 0;
            for (int j = 1; j<= i; j++) {
                if (i%j == 0) {
                    count++;
                }
            }
            if (count == 2) {
                System.out.print(i + " ");
            }
        }
    }
}
