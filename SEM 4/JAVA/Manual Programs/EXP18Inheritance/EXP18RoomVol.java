public class EXP18RoomVol {
    public static void main(String[] args) {
        EXP18Volume V = new EXP18Volume();
        V.calVol();
    }
}

class EXP18Room {
    int length = 15;
    int breadth = 10;
    int area = length * breadth;
    protected void calArea() {
        System.out.println("Area of the Room is " + area);
    }
}

class EXP18Volume extends EXP18Room {
    protected void calVol() {
        int height = 10;
        int vol = length * breadth * height;
        calArea();
        System.out.println("Volume of the Room is " + vol);
    }
}
