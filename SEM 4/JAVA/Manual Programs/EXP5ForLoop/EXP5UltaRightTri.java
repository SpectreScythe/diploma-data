import java.util.Scanner;

public class EXP5UltaRightTri {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Rows : ");
        int rows = sc.nextInt();

        for(int i = 0; i<=rows; i++) {
            for (int j = rows; j>i; j--) {
                System.out.print("* ");
            }
            System.out.println();
        }
    }
}