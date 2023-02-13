using RPS;
public class Program {

 public static void Main(string[] args){
        Console.WriteLine("Please select game to play:");
        Console.WriteLine("[1] Rock, Paper, Scissors");
        int input = 0;
        while(true) {
            if(!int.TryParse(Console.ReadLine()!,out input)){
                  Console.WriteLine("Input must be number");
                  continue;
                }
            if (input == 1) {
                RPS.RPSGame.Start();
            }
        }

 }
        
    
}
