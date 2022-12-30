import javax.swing.JOptionPane;

public class Quiz {

	public static void main(String[] args) {
		String question = "What is the past tense of bring?\n";
		question += "A. bringing\n";
		question += "B. braught\n";
		question += "C. broth\n";
		question += "D. brought\n";
		question += "E. brauth\n";
		
		String correctAnswer = "D";
		
		check(question, correctAnswer);
		
		question = "What is the area of a circle with a diameter of 16?\n";
		question += "A. 201.0\n";
		question += "B. 318.8\n";
		question += "C. 186.4\n";
		question += "D. 94.8\n";
		question += "E. 256.7\n";
		
		correctAnswer = "A";
		
		check(question, correctAnswer);
		
		question = "What is the country with the largest population in the world?\n";
		question += "A. Russia\n";
		question += "B. India\n";
		question += "C. Pakistan\n";
		question += "D. United States\n";
		question += "E. China\n";
		
        correctAnswer = "E";
		
		check(question, correctAnswer);
		
		JOptionPane.showMessageDialog(null, "You got " + nCorrect + " questions correct out of  " + nQuestions + " questions" );
		
	}

	public static String ask(String question) {
		
		while (true) {
			String answer = JOptionPane.showInputDialog(question);
			answer = answer.toUpperCase();
			if (answer.equals("A")  ||  (answer.equals("B")) || (answer.equals("C")) || (answer.equals("D")) || (answer.equals("E")) ) {
				 return answer;
				}
			else {
				JOptionPane.showMessageDialog(null,"Invalid answer. Please enter A, B, C, D, or E.");
			}
		}	
	}
	public static void check(String question, String correctAnswer) {
		
		nQuestions++;
		String answer;
		answer = ask(question);		
		if ( answer.equals(correctAnswer)) {
			nCorrect++;
			JOptionPane.showMessageDialog(null,"Correct!" );
		}
		else {
			JOptionPane.showMessageDialog(null,"Incorrect. The correct answer is "+ correctAnswer);
		}
	}
	public static int nQuestions = 0;
	public static int nCorrect = 0;
}	
