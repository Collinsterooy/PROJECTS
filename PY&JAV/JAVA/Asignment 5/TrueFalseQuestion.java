import  javax.swing.JOptionPane;
/**
 * 
 */

/**
 * @author colli
 *
 */
public class TrueFalseQuestion extends Question {
	
	String question;
		
	public TrueFalseQuestion(String question, String answer) {
		this.question = "TRUE OR FALSE: " +question;
		correctAnswer = answer;

	}	
	String ask() {
	
		while (true) {
			String answer = JOptionPane.showInputDialog(question);
			answer = answer.toUpperCase();
			if (answer.equals("F")  ||  (answer.equals("FALSE")) || (answer.equals("N")) || (answer.equals("NO"))) {
				answer = "FALSE";
				 return answer;
				}
			else if (answer.equals("T") || (answer.equals("TRUE")) || (answer.equals("Y")) || (answer.equals("YES"))){
				answer = "TRUE";
				return answer;
			}
			else {
				JOptionPane.showMessageDialog(null,"Invalid answer. Please enter TRUE or FALSE.");
			}
		}	
	}
	
}
