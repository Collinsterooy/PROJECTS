
public class Quiz {

	public static void main(String[] args) {
		MultipleChoiceQuestion question1 = new MultipleChoiceQuestion ("What is the past tense of bring?", " bringing", "braught", "broth", "brought", " brauth", "D");
			question1.check();
			
		MultipleChoiceQuestion question2 = new MultipleChoiceQuestion ("What is the area of a circle with a diameter of 16?", " 201.0", "318.8", "186.4", "94.8", " 256.7", "A");	
			question2.check();
			
		MultipleChoiceQuestion question3 = new MultipleChoiceQuestion ("What is the country with the largest population in the world?", " Russia", "India", "Pakistan", "United States", "China", "E");		
		question3.check();
		
		MultipleChoiceQuestion question4 = new MultipleChoiceQuestion ("Which is an animal ?", " Apple", "Goat", "Springles", "Chair", "Onion", "B");
		question4.check();
		
		MultipleChoiceQuestion question5 = new MultipleChoiceQuestion ("What is 5 + 5 - 2?", " 9", "7", "8", "5", " 11", "C");	
		question5.check();
		
		MultipleChoiceQuestion.showResults();
	
		
		
		
		
		
		
	
	}

	
}	
