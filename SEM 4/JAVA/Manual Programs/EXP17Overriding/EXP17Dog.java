class EXP17MAnimal {
    void move() {
        System.out.println("Animal moves.");
    }
}

class EXP17MDog extends EXP17MAnimal {
    void move() {
        super.move(); // Call the move() method of the parent class
        System.out.println("Dog moves.");
    }
}

class EXP17Dog {
    public static void main(String[] args) {
        EXP17MAnimal animal = new EXP17MAnimal();
        animal.move(); // Output: "Animal moves."

        EXP17MDog dog = new EXP17MDog();
        dog.move(); // Output: "Animal moves." followed by "Dog moves."
    }
}
