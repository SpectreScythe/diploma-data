public class PrimeOrNot {
    public static void main(String[] args) {
        checkForPrime();
    }
    static void checkForPrime() {
        int x = 19;
        int flag = 0;
        for (int i = 1 ; i <= x ; i++) {
            if (x % i ==0) {
                flag++;
            }
        }
        if (flag > 2) {
            System.out.println("False");
        }
        else {
            System.out.println("True");
        }
    }
}
