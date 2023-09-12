public class EXP18StudMrks {
    public static void main(String[] args) {
        Test T = new Test();
        T.showResult();
    }
}

class Student {
    int rollN = 210451 , age = 18;
    String name = "Dawg Qureshi";
    protected void SInfo() {
        System.out.println("Name : \t\t\t" + name);
        System.out.println("Age : \t\t\t" + age);
        System.out.println("Roll Number : \t\t"+ rollN);
    }
}

class Test extends Student {
    int m1 = 79,m2 = 83 ,m3 = 88;
    int r = (m1+m2+m3)/3;
    protected void showResult() {
        SInfo();
        System.out.println("Result : \t\t" + r);
    }
}
