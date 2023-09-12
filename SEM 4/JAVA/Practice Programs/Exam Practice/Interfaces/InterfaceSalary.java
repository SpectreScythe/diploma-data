
interface Salary {
    int basic_salary = 45000;
    void Basic_sal();
}
class Employee {
    Employee(String name, int age) {
        System.out.println("Name of Employee : " + name);
        System.out.println("Age of Employee : " + age);
    }
}
class Gross extends Employee implements Salary{
    double totalS;
    Gross(String name, int age, int TA, int DA, int HRA) {
        super(name,age);
        totalS = basic_salary+TA+DA+HRA;
        total_sal();
    }

    public void Basic_sal() {
        System.out.println("Basic Salary : " + basic_salary);
    }
    void total_sal() {
        Basic_sal();
        System.out.println("Gross Salary is : " + totalS);
    }
}

public class InterfaceSalary {
    public static void main(String[] args) {
        Gross G = new Gross("Gustavo Fring", 48, 3000, 5500, 7000);
    }
}
