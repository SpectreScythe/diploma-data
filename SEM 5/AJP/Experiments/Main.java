import javax.swing.*;
import java.awt.*;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.*;

public class Main {

    public Main() {
        JFrame frame = new JFrame("My Key Events");
        frame.setBackground(Color.DARK_GRAY);
        frame.setForeground(Color.WHITE);
        frame.setLayout(new BorderLayout());

        JPanel P = new JPanel();
        P.setLayout(new FlowLayout());

        JLabel label1 = new JLabel("Number 1:");
        JTextField n1 = new JTextField(10);

        JLabel label2 = new JLabel("Number 2:");
        JTextField n2 = new JTextField(10);

        JPanel buttonPanel = new JPanel();
        JButton btn = new JButton("Multiply");

        buttonPanel.add(btn);

        JLabel rLabel = new JLabel();

        btn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    double num1 = Double.parseDouble(n1.getText());
                    double num2 = Double.parseDouble(n2.getText());
                    double product = num1 * num2;
                    rLabel.setText("Product: " + product);
                } catch (NumberFormatException ex) {
                    rLabel.setText("Invalid input. Please enter valid numbers.");
                }
            }
        });

        P.add(label1);
        P.add(n1);
        P.add(label2);
        P.add(n2);

        frame.add(P, BorderLayout.NORTH);
        frame.add(buttonPanel, BorderLayout.CENTER);
        frame.add(rLabel, BorderLayout.SOUTH);
        frame.setSize(400, 300);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);

    }

    public static void main(String[] args) {
        new Main();
    }
}
