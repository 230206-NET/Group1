using System; 

namespace RPS{
/*
 - Random ran(1,4) -> based on num r, p, s
 -  string array of r,p,s
 - show user how to play game
 - ask player for input  (1,2,3) *easer for user  
 - Out of 3 attemps - needs 2 wins
 - conditional statements: r > s; p > r; s > p, if equal ask to again
  TO DO:
  - display user input 
  - display computer input
  - catch invalid input
  - 
*/
public class RPSGame{

   // private int[] RPS= {1,2,3}; // rock = 1, paper = 2, scissors = 3
    static private string[] RPSstr= {"Rock","Paper","Scissors"};

    private static int attempts = 0;
    private static int uScore = 0, cScore = 0;

    public static void Main(string[] args){
      int status;
        Console.WriteLine("Please input 1 for Rock, 2 for Paper or 3 for Scissors.");
        while (true) {
          int uInput = int.Parse(Console.ReadLine()!);
          if (uInput == 1 || uInput ==2 || uInput ==3){
            Random rand = new Random();
            int cInput = rand.Next(1,4);
            //Display input vs input
            Console.WriteLine("Computer:" + RPSstr[cInput - 1] + " VS User:" + RPSstr[uInput - 1]);
            compareInput(uInput, cInput);
            status = winGame();
            if(status == -1){
              Console.BackgroundColor = ConsoleColor.Red;
              Console.WriteLine("You lost the game!");
              System.Environment.Exit(0);  
            } else if(status == 1){
              Console.BackgroundColor = ConsoleColor.Green;
              Console.WriteLine("You won the game!");
              System.Environment.Exit(0);  
            }
          } else{
            Console.WriteLine("Invalid entry. Try again"); 
            continue;
          }
        }
    }
    //this method compares user input and cpu input
      static private void  compareInput(int uInput, int cInput){
        if((uInput==cInput) || (uInput==cInput) || (uInput == cInput)){
            Console.WriteLine("Draw");            
        }

        else if((uInput==1 && cInput==3) || (uInput==3 && cInput==2) || (uInput==2 && cInput==1)){
            Console.WriteLine("User wins this round"); 
            RPSGame.uScore++; 
            RPSGame.attempts++;          
        }
        else {
            Console.WriteLine("Computer wins this round");
            RPSGame.cScore++;
            RPSGame.attempts++;
        }        
    }

    //method to check game status
    static private int winGame(){
        if(RPSGame.cScore == 2){
            return -1;
        }
        else if(RPSGame.uScore == 2){
            return 1;
        }
        return 0;
    }


}
}
