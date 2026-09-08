import java.util.Scanner;

public class SimpleQuizApp {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);

        String[] questions = {
                "1.What is the earlier name of Java ?",
                "2.Java Programming was designed by ?",
                "3.Which kind of Language java is ?",
                "4.Which one is the primitive data type?",
                "5.Which of the following is used to create an object in java?",
                "6.Which package contains scanner class? ",
                "7.Which of the following is not a valid access modifier in java?",
                "8.Which of the following is not a Java keyword?",
                "9.What is the size of an int variable in Java?",
                "10. What is the super class of all class in java?"
        };
        String[][] options = {
                {"A. Netbean", "B. Oak", "C. Eclipse"},
                {"A. Microsoft", "B. Mozilla Corporation", "C. Sun Microsystems"},
                {"A. Object Oriented", "B. Event Driven", "C. Procedural"},
                {"A. String", "B. Numeric", "C. Array"},
                {"A. create", "B. class", "C. new"},
                {"A. Java.io","B. java.util","C. java.net"},
                {"A. Public", "B. Private,","C. friendly"},
                {"A. Boolean", "B. static","C. void"},
                {"A. 2bytes","B. 8bytes","C. 4bytes"},
                {"A. object","B. class","C. main"}
        };

        char[] correctAnswers = {'B', 'C', 'A','B','C','B','C','A','C','A'};

        String[] explanations = {
                "Java was initially called Oak, developed by James Gosling.",
                "Java was developed by James Gosling at Sun Microsystems (later acquired by Oracle).",
                "Java is an Object-Oriented Programming (OOP) language.",
                "Numeric is a primitive data type category. String and Array are objects.",
                "`new` is the keyword used to create objects in Java.",
                "`java.util` package contains the Scanner class used for input.",
                "`friendly` is not a valid access modifier in Java.",
                "`Boolean` is a data type, not a keyword in Java.",
                "An `int` variable in Java is 4 bytes (32 bits) in size.",
                "The `Object` class is the superclass of all classes in Java."
        };

        int score = 0;

        System.out.println("Welcome to Simple Quiz! \n");
        for (int i = 0; i < questions.length; i++) {
            System.out.println(questions[i]);
            for (String option : options[i]) {
                System.out.println(option);
            }
            System.out.print("Your answer (A/B/C):");
            try{
                String userInput = input.next().toUpperCase();

                if (userInput.length() == 1 && "ABC" .contains(userInput)) {
                    if (userInput.charAt(0) == correctAnswers[i]) {
                        System.out.println("Correct!\n");
                        score++;
                    }
                    else {
                        System.out.println("Incorrect! Correct answer:" + correctAnswers[i] + "\n" );
                    }
                    System.out.println("Explanation: " + explanations[i] + "\n");
                } else {
                    System.out.println("Invalid Input! Skipping question. \n" );
                }
            }
            catch (Exception e) {
                System.out.println("Error Reading Input! Skipping question. \n" );
            }
        }
        System.out.println("Quiz Over!");
        System.out.println("Your Score: " + score + " out of " + questions.length );
    }
}