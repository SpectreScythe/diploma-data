public class EXP13ArrayAdd {
    static void addArray() throws Exception {
        int[][] arrayA = {{1, 4, 7}, {2, 5, 8}, {3, 6, 9}};
        int[][] arrayB = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

        int[][] arrayC = new int[3][3];

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                arrayC[i][j] = arrayA[i][j] + arrayB[i][j];
            }
        }

        System.out.println("Matrix A : ");

        for (int i = 0; i < arrayA.length; i++) {
            for (int j = 0; j < arrayA.length; j++) {
                System.out.print(arrayA[i][j] + "\t");
            }
            System.out.println();
        }

        System.out.println("Matrix B : ");

        for (int i = 0; i < arrayB.length; i++) {
            for (int j = 0; j < arrayB.length; j++) {
                System.out.print(arrayB[i][j] + "\t");
            }
            System.out.println();
        }

        System.out.println("Matrix after Addition : ");

        for (int i = 0; i < arrayC.length; i++) {
            for (int j = 0; j < arrayC.length; j++) {
                System.out.print(arrayC[i][j] + "\t");
            }
            System.out.println();
        }

    }

    public static void main(String[] args) throws Exception {
        addArray();
    }
}
