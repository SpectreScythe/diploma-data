import javax.swing.*;
import java.awt.event.*;

public class Main {
    public static void windowAdapterDemo() {
        JFrame frame = new JFrame("WindowAdapter Demo");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(300, 200);

        frame.addWindowListener(new WindowAdapter() {
            @Override
            public void windowOpened(WindowEvent e) {
                System.out.println("Window opened.");
            }

            @Override
            public void windowClosing(WindowEvent e) {
                System.out.println("Window closing.");
            }

            @Override
            public void windowClosed(WindowEvent e) {
                System.out.println("Window closed.");
            }

            @Override
            public void windowIconified(WindowEvent e) {
                System.out.println("Window iconified (minimized).");
            }

            @Override
            public void windowDeiconified(WindowEvent e) {
                System.out.println("Window deiconified (restored).");
            }
        });

        JButton closeButton = new JButton("Close Window");
        closeButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                frame.dispose();
            }
        });

        frame.add(closeButton);
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        windowAdapterDemo();
    }
}
