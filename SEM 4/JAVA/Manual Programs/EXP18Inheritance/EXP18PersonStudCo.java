public class EXP18PersonStudCo {
    public static void main(String[] args) {
        EXP18CoStud C = new EXP18CoStud();
        C.CGender();
    }
}

class EXP18Person {
    String fName = "Simon";
    String lName = "Riley";
    protected void PName() {
        System.out.println("Full name : \t\t\t" + fName + " " + lName);
    }
}

class EXP18Student extends EXP18Person {
    String branch = "Computer Engineering";
    protected void SBranch() {
        System.out.println("Branch : \t\t\t" + branch);
    }
}

class EXP18CoStud extends EXP18Student{
    String gender = "Male";
    protected void CGender() {
        PName();
        SBranch();
        System.out.println("Gender : \t\t\t" + gender);
    }
}
