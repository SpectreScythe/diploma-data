public class PrimeSeries {
    public static void main(String[] args) {
        SeriesOfPrime();
    }
    static void SeriesOfPrime() {
        int x = 30;
        for (int i = 2 ; i <= x ; i++) {
            int flag = 0;
            for (int j = 1 ; j <= i ; j++) {
                if (i % j == 0) {
                    flag++;
                }
            }
            if (flag == 2) {
                System.out.print(i + "\t");
            }
        }
    }
}
