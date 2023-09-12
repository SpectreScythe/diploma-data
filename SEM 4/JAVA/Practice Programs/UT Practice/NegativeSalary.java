class Emp {
    protected String name;
    protected int sal;

    Emp(int s, String n) {
        name = n;
        sal = s;
        try {
            ErrorSalary(sal);
            System.out.println("Valid Salary");
        } catch (SalaryIsNegative e) {
            System.out.println(e.getMessage());
        }
    }

    static void ErrorSalary(int sala) throws SalaryIsNegative {
        if (sala < 0)
            throw new SalaryIsNegative("Negative Salary");
    }
}

class SalaryIsNegative extends Exception {
    SalaryIsNegative(String msg) {
        super(msg);
    }
}

public class NegativeSalary {
    public static void main(String[] args) {
        Emp e = new Emp(-2000, "Walter");
    }
}
