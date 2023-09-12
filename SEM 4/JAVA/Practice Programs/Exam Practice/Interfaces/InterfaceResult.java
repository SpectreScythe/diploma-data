
interface Sports {
    int v = 85;
}

class Student {
    Student(String x) {
        System.out.println("Name of Student : " + x);
    }
}

class Exam extends Student{
    float total = 0;
    Exam(String q, int w, int e, int r) {
        super(q);
        total = w+e+r;
    }
}

class Result extends Exam implements Sports {
    float res = 0;
    Result(String a, int b, int n, int m) {
        super(a, b, n, m);
        res = ((total+v)/400)*100;
        System.out.println("Result of student " + a + " is : " + res);
    }
}

public class InterfaceResult {
    public static void main(String[] args) {
        Result R = new Result("Master Chief", 87, 88, 86);
    }
}
