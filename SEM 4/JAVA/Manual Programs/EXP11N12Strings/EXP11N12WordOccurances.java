public class EXP11N12WordOccurances {
public static void main(String args[]) {
String string = "The enemy of my enemy is my friend.";
String word = "enemy";
String temp[] = string.split(" ");
int count = 0;
for (int i = 0; i < temp.length; i++) {
if (word.equals(temp[i]))
count++;
}
System.out.println("\nThe string is: " + string);
System.out.println("The word " + word + " occurs " + count + " times in the above string\n");
}
}