
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
public class PracticalExam {
    public static void UserAuthenticationDemo() {
        JFrame frame = new JFrame("User Authentication"); frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(new FlowLayout());
        JLabel usernameLabel = new JLabel("Username:");
        JTextField usernameField = new JTextField(15);
        JLabel passwordLabel = new JLabel("Password:");
        JPasswordField passwordField = new JPasswordField(15);
        JButton loginButton = new JButton("Login");
        loginButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String enteredUsername = usernameField.getText();
                char[] enteredPassword = passwordField.getPassword();
                if (isValidUser(enteredUsername, enteredPassword)) {                    JOptionPane.showMessageDialog(frame, "Authentication successful!");
                } else {
                    JOptionPane.showMessageDialog(frame, "Authentication failed. Please try again.", "Error", JOptionPane.ERROR_MESSAGE); }
                passwordField.setText("");}});
        frame.add(usernameLabel);
        frame.add(usernameField);
        frame.add(passwordLabel);
        frame.add(passwordField);
        frame.add(loginButton);
        frame.setSize(300, 150);
        frame.setVisible(true); }
    private static boolean isValidUser(String username, char[] password) {
        String enteredPassword = new String(password);
        String VALID_USERNAME = "theyseemerollin";
        String VALID_PASSWORD = "qwertyuiop";
        return username.equals(VALID_USERNAME) && enteredPassword.equals(VALID_PASSWORD); }
    public static void main(String[] args) {
        UserAuthenticationDemo();}}
