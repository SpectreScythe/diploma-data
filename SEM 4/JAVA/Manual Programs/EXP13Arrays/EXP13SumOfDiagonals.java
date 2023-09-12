public class EXP13SumOfDiagonals {
    static void DiagonalsAdd() throws Exception {
        int[][] arrayA = {{1, 4, 7}, {2, 5, 8}, {3, 6, 9}};

        int sumOfDiagonals = 0;

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                if (i == j) {
                    sumOfDiagonals += arrayA[i][j];
                }
            }
        }

        System.out.println("Matrix A : ");

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                System.out.print(arrayA[i][j] + "\t");
            }
            System.out.println();
        }

        System.out.println("Sum of the Diagonals : " + sumOfDiagonals);

    }

    public static void main(String[] args) throws Exception {
        DiagonalsAdd();
    }
}
