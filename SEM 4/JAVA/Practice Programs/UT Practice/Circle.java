  class Circle {
        private final double pi = 3.14;
        private double radius;

        public Circle(double r) {
            radius = r;
            System.out.println("Radius: " + radius);
            System.out.println("PI: " + pi);
            System.out.println(pi * radius * radius);
        }

        public void display() {
            System.out.println("Radius: " + radius);
            System.out.println("PI: " + pi);
        }

        public double area() {
            return pi * radius * radius;
        }

     public static void main(String[] args) {
         Circle c = new Circle(5);
     }
    }

