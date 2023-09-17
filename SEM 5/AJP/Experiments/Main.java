import javax.swing.*;
import javax.swing.tree.DefaultMutableTreeNode;
import java.awt.*;

public class Main {
    public Main() {
        JFrame frame = new JFrame("My System Tree");
        frame.setBackground(Color.DARK_GRAY);
        frame.setForeground(Color.WHITE);

        DefaultMutableTreeNode root = new DefaultMutableTreeNode("This PC");

        DefaultMutableTreeNode folder4 = new DefaultMutableTreeNode("Windows");
        DefaultMutableTreeNode folder3 = new DefaultMutableTreeNode("Users");
        DefaultMutableTreeNode folder1 = new DefaultMutableTreeNode("qarq90");
        DefaultMutableTreeNode folder2 = new DefaultMutableTreeNode("Program Files");

        DefaultMutableTreeNode file1 = new DefaultMutableTreeNode("Diploma");
        DefaultMutableTreeNode file2 = new DefaultMutableTreeNode("Lock Screen");
        DefaultMutableTreeNode file3 = new DefaultMutableTreeNode("Softwares");

        DefaultMutableTreeNode file11 = new DefaultMutableTreeNode("Git");
        DefaultMutableTreeNode file12 = new DefaultMutableTreeNode("JetBrains");
        DefaultMutableTreeNode file13 = new DefaultMutableTreeNode("CClearner");

        root.add(folder1);
        root.add(folder2);
        root.add(folder3);
        root.add(folder4);

        folder1.add(file1);
        folder1.add(file2);
        folder1.add(file3);

        folder2.add(file11);
        folder2.add(file12);
        folder2.add(file13);

        JTree tree = new JTree(root);

        JScrollPane scrollPane = new JScrollPane(tree);

        tree.setBackground(Color.DARK_GRAY);
        tree.setForeground(Color.WHITE);
        tree.setSize(400,300);

        frame.add(scrollPane);

        frame.setSize(400, 300);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }

    public static void main(String[] args) {
            new Main();
    }
}
