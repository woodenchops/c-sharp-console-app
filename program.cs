using System;
namespace myNameSpace {

class Program {
    static void Main() {
        
       int runningTotal = 0;
       bool keepGoing = true;
        
      while(keepGoing) {
          
       Console.Write("How may hours have you studied? "); 
    
       string entry = Console.ReadLine();
          
       if(entry == "quit") {
           keepGoing = false;
       } else {
        
       int minutes = int.Parse(entry);
           
       if(minutes <= 0) {
           Console.WriteLine(minutes + " is not accepted");
       } else {
           
       if(minutes <= 10) {
           Console.WriteLine("Not bad");
       } else if(minutes >= 30) {
           Console.WriteLine("Awesome!");
       }
       }
        
        runningTotal = runningTotal + minutes;
        
       Console.WriteLine("You have studied " + runningTotal + " hours");
       }
    }
        
        Console.WriteLine("bye");
    }
}
}