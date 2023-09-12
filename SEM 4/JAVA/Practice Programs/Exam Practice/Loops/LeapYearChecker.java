public class LeapYearChecker {
    public static void main(String[] args) {
        checkYear();
    }

    static void checkYear() {
        int y = 2004;
        if ((y % 400 == 0) || (y % 100 != 0 && y % 4 == 0)) {
            System.out.println("Its a leap year");
        } else {
            System.out.println("Its not a leap year");
        }
    }
}
