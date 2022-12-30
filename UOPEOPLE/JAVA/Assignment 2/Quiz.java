import javax.swing.JOptionPane;

public class Quiz {

	public static void main(String[] args) {
		String question = "What is the past tense of bring?\n";
		question += "A. bringing\n";
		question += "B. braught\n";
		question += "C. broth\n";
		question += "D. brought\n";
		question += "E. brauth\n";
		
		String answer = JOptionPane.showInputDialog(question);
		answer = answer.toUpperCase();
		if (answer.equals("D")) {
			 JOptionPane.showMessageDialog(null,"Correct!");
			}
		else if (answer.equals("A") || answer.equals("B") || answer.equals("C") || answer.equals("E")) {
			 JOptionPane.showMessageDialog(null,"Incorrect, Try again");
			}
		else {
			JOptionPane.showMessageDialog(null,"Invalid answer. Please enter A, B, C, D, or E.");
		}
	}

}
