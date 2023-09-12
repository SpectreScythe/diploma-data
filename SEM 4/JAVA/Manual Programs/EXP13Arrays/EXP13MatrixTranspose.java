public class EXP13MatrixTranspose {
    static void MatTranspose() throws Exception {
        int[][] ogMat = {{1, 4, 7}, {2, 5, 8}, {3, 6, 9,}};

        int[][] transposeMat = new int[3][3];

        for (int i = 0; i < ogMat.length; i++) {
            for (int j = 0; j < ogMat.length; j++) {
                transposeMat[i][j] = ogMat[j][i];
            }
        }

        System.out.println("Original Matrix : ");

        for (int i = 0; i < ogMat.length; i++) {
            for (int j = 0; j < ogMat.length; j++) {
                System.out.print(ogMat[i][j] + "\t");
            }
            System.out.println();
        }

        System.out.println("Transposed Matrix : ");

        for (int i = 0; i < transposeMat.length; i++) {
            for (int j = 0; j < transposeMat.length; j++) {
                System.out.print(transposeMat[i][j] + "\t");
            }
            System.out.println();
        }
    }

    public static void main(String[] args) throws Exception {
        MatTranspose();
    }
}
