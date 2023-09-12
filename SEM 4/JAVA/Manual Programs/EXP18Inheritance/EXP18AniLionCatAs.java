public class EXP18AniLionCatAs {
    public static void main(String[] args) {
        Ashera A = new Ashera();
        A.cName();
    }
}

class Animal {
    protected void Type() {
        System.out.println("A 4 legged animal \t\t\t\t\t ---> Animal Class");
    }
}

class Lion extends Animal {
    protected void Carnivore() {
        System.out.println("Belongs to family of lions \t\t\t\t ---> Lion Class");
    }
}

class cat extends Lion {
    protected void CATegory() {
        System.out.println("Its a white cat \t\t\t\t\t ---> Cat Class");
    }
}

class Ashera extends cat {
    protected void cName() {
        Type();
        Carnivore();
        CATegory();
        System.out.println("The cats name is Ashera \t\t\t\t ---> Ashera Class");
    }
}
