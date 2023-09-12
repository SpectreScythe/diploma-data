class EXP10ConstructorAccount {
	int Acc_No;
	String Name;

	EXP10ConstructorAccount(int Acc_No, String Name) {
		this.Acc_No = Acc_No;
		this.Name = Name;
	}

	EXP10ConstructorAccount(EXP10ConstructorAccount acc){
		this.Acc_No = acc.Acc_No;
		this.Name = acc.Name;
	}

	void display() {
		System.out.println("EXP10ConstructorAccount No : " + Acc_No);
		System.out.println("EXP10ConstructorAccount Name : " + Name);
	}

	
	public static void main(String[] args) {
		EXP10ConstructorAccount acc1 = new EXP10ConstructorAccount(210451, "Dawg");
		EXP10ConstructorAccount acc2 = new EXP10ConstructorAccount(acc1); 
		System.out.println("\nOriginal Object");
		acc1.display();
		System.out.println("\nCopied Object");
		acc2.display();
	}

}