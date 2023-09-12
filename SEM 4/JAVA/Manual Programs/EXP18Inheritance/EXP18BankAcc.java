public class EXP18BankAcc {
    public static void main(String[] args) {
        EXP18Account A = new EXP18Account();
        A.AccNumber();
    }
}

class EXP18Bank {
    String bName = "Silicon Valley Bank";
    protected void BankName() {
        System.out.println("Bank Name : \t\t\t" + bName);
    }
}

class EXP18Account extends EXP18Bank {
    long accNum = 842695173;
    protected void AccNumber() {
        BankName();
        System.out.println("Account Number : \t\t" + accNum);
    }
}