using System; 

namespace RPS{
/*
 - Random ran(1,4) -> based on num r, p, s
 -  string array of r,p,s
 - show user how to play game
 - ask player for input  (1,2,3) *easer for user  
 - Out of 3 attemps - needs 2 wins
 - conditional statements: r > s; p > r; s > p, if equal ask to again
*/
public class RPSGame{

    private int[] RPS= {1,2,3}; // rock = 1, paper = 2, scissors = 3

    private int attempts = 0;
    private int uScore = 0, cScore = 0;

    public void Start(){
        Console.WriteLine("Please input 1 for Rock, 2 for Paper or 3 for Scissors.");
        while (true) {
        int uInput = int.Parse(Console.ReadLine()!);
        if (uInput != 1 || uInput !=2 || uInput !=3){
            Console.WriteLine("Invalid entry.");
            continue;
        }
        Random rand = new Random();
        var cInput = rand.Next(1,4);
        compareInput(uInput, cInput);
        break;       
        }
    }
    //this method compares user input and cpu input
    private void compareInput(int uInput, int cInput){
        if((uInput==1 && cInput==1) || (uInput==2 && cInput==2) || (uInput==3 && cInput==3)){
            Console.WriteLine("Draw");            
        }

        else if((uInput==1 && cInput==3) || (uInput==3 && cInput==2) || (uInput==2 && cInput==1)){
            Console.WriteLine("User wins"); 
            uScore++; 
            attempts++;          
        }
        else {
            Console.WriteLine("Computer wins");
            cScore++;
            attempts++;
        }        
    }

    //method to check game status
    private int winGame(){
        if(attempts == 3){
            return -1;
        }
        else if(this.uScore == 2){
            return 1;
        }
        return 0;
    }


}
}



