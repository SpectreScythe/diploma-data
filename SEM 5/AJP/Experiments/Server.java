import java.net.*;
import java.io.*;
public class Server
{
    public static void main(String args[])throws IOException
    {
        byte b[]=new byte[3072];
        DatagramSocket dsoc=new DatagramSocket(1000);
        FileOutputStream f=new FileOutputStream("D:\\Diploma''SEM 5''AJP''Experiments''PQR.txt");
        while(true)
        {
            DatagramPacket dp=new DatagramPacket(b,b.length);
            dsoc.receive(dp);
            String str = new String(dp.getData(),0,dp.getLength());
            System.out.println(str);
            byte c[]=str.getBytes();
            f.write(c);
            f.close();
            System.out.println("success...");
        }
    }
}
