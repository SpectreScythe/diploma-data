public class EXP13SumAvgMxN {
    static void SumAvgMxN() throws Exception {
        int[][] arrayA = {{1, 4, 7}, {2, 5, 8}, {3, 6, 9}};

        int sum = 0;

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                    sum += arrayA[i][j];
            }
        }

        System.out.println("Matrix A : ");

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                System.out.print(arrayA[i][j] + "\t");
            }
            System.out.println();
        }

        int avg = (sum / 9);

        System.out.println("Sum : " + sum);
        System.out.println("Average : " + avg);

    }

    public static void main(String[] args) throws Exception {
        SumAvgMxN();
    }
}
