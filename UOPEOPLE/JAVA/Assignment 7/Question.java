import java.awt.*;
import javax.swing.*;

public abstract class Question {
	
	static int nQuestions = 0;
	static int nCorrect = 0;
	
	QuestionDialog question;
	String correctAnswer;
	
	
	Question(String question) {
		this.question = new QuestionDialog();	
		this.question.setLayout(new GridLayout(0,1));
		this.question.add(new JLabel ("         " + question + "      ", JLabel.CENTER  ) );
		
	}
	
	
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

	String ask() {
		
		question.setVisible(true);
		return question.answer;																							
		
	}
	void initQuestionDialog() {
		question.setModal(true);
	    question.pack();
	    question.setLocationRelativeTo(null);
	}
}
