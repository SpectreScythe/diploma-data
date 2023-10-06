import javax.swing.*;
import java.awt.*;

public class MyServer extends JFrame {
    MyServer(){
        setTitle("Chat Tach | Server");
        getContentPane().setBackground(Color.DARK_GRAY);
        setSize(600,400);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
    }
    public static void main(String[] args) {
        new MyServer();
    }
}
