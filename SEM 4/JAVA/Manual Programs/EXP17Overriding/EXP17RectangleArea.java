class EXP17ARectangle {
    protected double length;
    protected double width;

    public EXP17ARectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    public double area() {
        return length * width;
    }
}

class EXP17ASquare extends EXP17ARectangle {
    public EXP17ASquare(double side) {
        super(side, side);
    }

    public double area() {
        return length * length; // Override the area() method for Square
    }
}

class EXP17RectangleArea {
    public static void main(String[] args) {
        EXP17ARectangle rectangle = new EXP17ARectangle(5, 10);
        System.out.println("Rectangle Area: " + rectangle.area()); // Output: Rectangle Area: 50.0

        EXP17ASquare square = new EXP17ASquare(7);
        System.out.println("Square Area: " + square.area()); // Output: Square Area: 49.0
    }
}
