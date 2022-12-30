
public class Quiz {

	public static void main(String[] args) {
		Question question1 = new MultipleChoiceQuestion ("What is the past tense of bring?", " bringing", "braught", "broth", "brought", " brauth", "D");
			question1.check();
			
		Question question2 = new MultipleChoiceQuestion ("What is the area of a circle with a diameter of 16?", " 201.0", "318.8", "186.4", "94.8", " 256.7", "A");	
			question2.check();
			
		Question question3 = new MultipleChoiceQuestion ("What is the country with the largest population in the world?", " Russia", "India", "Pakistan", "United States", "China", "E");		
		question3.check();
		
		Question question4 = new MultipleChoiceQuestion ("Which is an animal ?", " Apple", "Goat", "Springles", "Chair", "Onion", "B");
		question4.check();
		
		Question question5 = new MultipleChoiceQuestion ("What is 5 + 5 - 2?", " 9", "7", "8", "5", " 11", "C");	
		question5.check();
		
		Question Mquestion1 = new TrueFalseQuestion ("Is 79 a prime number?", "TRUE");
		Mquestion1.check();
		
		Question Mquestion2 = new TrueFalseQuestion ("Stratosphere is above the Mesophere?", "FALSE");
		Mquestion2.check();
		
		Question Mquestion3 = new TrueFalseQuestion ("798 divided by 6 is 133?", "TRUE");
		Mquestion3.check();
		
		Question Mquestion4 = new TrueFalseQuestion ("A worm is a mamal ?", "FALSE");
		Mquestion4.check();
		
		Question Mquestion5 = new TrueFalseQuestion ("The earth is round?", "TRUE");
		Mquestion5.check();
		
		Question.showResults();
	
		
		
		
		
		
		
	
	}

	
}	
