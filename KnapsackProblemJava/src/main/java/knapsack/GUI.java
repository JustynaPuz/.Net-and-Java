package knapsack;

import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;


public class GUI extends JFrame {

    private JTextField numberField;
    private JTextField seedField;
    private JTextField capacityField;
    private JTextArea itemListArea;
    private JTextArea itemsInListArea;
    private JButton generateButton;

    public static void main(String[] args) {
        new GUI();

    }

    public GUI() {
        createComponents();
        setTitle("KnapsackGUI");
        setSize(750, 700);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);

    }

    private void createComponents() {
        JPanel mainPanel = new JPanel(new BorderLayout());
        JPanel leftPanel = new JPanel();
        JPanel rightPanel = new JPanel();

        leftPanel.setLayout(new BoxLayout(leftPanel, BoxLayout.Y_AXIS));
        rightPanel.setLayout(new BoxLayout(rightPanel, BoxLayout.Y_AXIS));

        Border margin = BorderFactory.createEmptyBorder(10, 10, 10, 10);

        //left panel
        JPanel inputPanel = new JPanel(new GridLayout(6, 1, 10, 10));
        inputPanel.setBorder(margin);
        inputPanel.add(new JLabel("Number of items"));
        numberField = new JTextField();
        numberField.addKeyListener(new KeyAdapter() {
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                if (!Character.isDigit(c)) {
                    e.consume();
                }
            }
        });
        inputPanel.add(numberField);
        inputPanel.add(new JLabel("Seed"));
        seedField = new JTextField();
        seedField.addKeyListener(new KeyAdapter() {
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                if (!Character.isDigit(c)) {
                    e.consume();
                }
            }
        });
        inputPanel.add(seedField);
        inputPanel.add(new JLabel("Capacity"));
        capacityField = new JTextField();
        capacityField.addKeyListener(new KeyAdapter() {
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                if (!Character.isDigit(c)) {
                    e.consume();
                }
            }
        });
        inputPanel.add(capacityField);
        leftPanel.add(inputPanel);
        leftPanel.setBorder(margin);

        generateButton = new JButton("SOLVE");
        leftPanel.add(generateButton);

        leftPanel.add(new JLabel("Items in "));

        itemsInListArea = new JTextArea(12, 30);
        itemsInListArea.setBorder(margin);
        itemsInListArea.setEditable(false);
        JScrollPane scrollPaneAll = new JScrollPane(itemsInListArea);
        leftPanel.add(scrollPaneAll);

        // right panel

        rightPanel.add(new JLabel("All items"));
        rightPanel.setBorder(margin);
        itemListArea = new JTextArea(15, 30);
        itemListArea.setBorder(margin);
        itemListArea.setEditable(false);
        JScrollPane scrollPane = new JScrollPane(itemListArea);
        scrollPane.add(Box.createHorizontalStrut(15));
        rightPanel.add(scrollPane);

        mainPanel.add(leftPanel, BorderLayout.WEST);
        mainPanel.add(rightPanel, BorderLayout.EAST);

        // Add listeners
        generateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                itemsInListArea.setText("");
                itemListArea.setText("");
                solve();

            }
        });

        this.add(mainPanel);

    }

    private void solve() {
        int numberOfItems = Integer.parseInt(numberField.getText());
        int seed = Integer.parseInt(seedField.getText());
        int capacity = Integer.parseInt(capacityField.getText());
        Problem problem = new Problem(numberOfItems, seed, 11, 1);
        Result result = problem.solve(capacity);
        itemListArea.setText("");
        itemListArea.append(problem.itemsToString());
        itemsInListArea.append(result.toString());

    }

    {
// GUI initializer generated by IntelliJ IDEA GUI Designer
// >>> IMPORTANT!! <<<
// DO NOT EDIT OR ADD ANY CODE HERE!
        $$$setupUI$$$();
    }

    /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
    private void $$$setupUI$$$() {
        final JPanel panel1 = new JPanel();
        panel1.setLayout(new GridBagLayout());
    }
}
