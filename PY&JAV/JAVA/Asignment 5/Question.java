import javax.swing.JOptionPane;

public abstract class Question {
	
	static int nQuestions = 0;
	static int nCorrect = 0;
	
	String question;
	String correctAnswer;
	
	void check() {
		
		nQuestions++;
		String answer;
		answer = ask();		
		if ( answer.equals(correctAnswer)) {
			nCorrect++;
			JOptionPane.showMessageDialog(null,"Correct!" );
		}
		else {
			JOptionPane.showMessageDialog(null,"Incorrect. The correct answer is "+ correctAnswer);
		}
	}
	
	static void showResults() {
		JOptionPane.showMessageDialog(null, "You got " + nCorrect + " questions correct out of  " + nQuestions + " questions" );
	}

	abstract String ask();
}
