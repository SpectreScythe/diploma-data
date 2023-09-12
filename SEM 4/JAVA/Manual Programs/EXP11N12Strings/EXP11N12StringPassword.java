import java.io.*;
public class EXP11N12StringPassword {
    public static void main(String[] args) throws IOException
    {
        System.out.println("Enter the password");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuffer pass = new StringBuffer(br.readLine());

        if(pass.toString().equals("Stalin"))
        {
            System.out.println("Good");
        }
        else
        System.out.println("Incorrect Password");
        System.out.println("Appended password " + pass.append("Stalin, Welcomes to the project"));
        System.out.println("Reverse password is " + pass.reverse());
        pass = new StringBuffer(pass.toString().replace("!", "$"));
        System.out.println("Pass : " + pass);
    }
}
