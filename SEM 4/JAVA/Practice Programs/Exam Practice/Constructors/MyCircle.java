import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class MyCircle {
    public static void main(String[] args) throws IOException {
        Circle C = new Circle();
    }
}
class Circle {
    int r;
    double pi = 3.14;
    Circle() throws IOException {
        BufferedReader BR = new BufferedReader(new InputStreamReader(System.in));
        r= Integer.parseInt(BR.readLine());
        circleFeatures();
    }
    protected void circleFeatures() {
        System.out.println("Radius : " + r);
        System.out.println("PI : " + pi);
        System.out.println("Area : " + (r*r*3.14));
    }
}
