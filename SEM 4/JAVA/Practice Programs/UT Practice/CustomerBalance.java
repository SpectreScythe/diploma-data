 class customer {
        protected String name;
        protected int balance;
        customer(String n , int b) {
            name = n;
            balance = b;

            try {
                CheckBalance(balance);
                System.out.println("Valid Amount");
            }
            catch (InvalidBalance e) {
                System.out.println(e.getMessage());
            }
        }
     public static void CheckBalance(int bal) throws InvalidBalance {
        int bal1 = bal;
        if (bal1 < 1500) {
            throw new InvalidBalance("Invalid balance");
        }
    }
}
class InvalidBalance extends Exception {
    InvalidBalance(String msg) {
        super(msg);
    }
}
 public class CustomerBalance {
     public static void main(String[] args) {
         customer c = new customer("Jesse" , 200);
     }
}
