class program {
    static void Main(string[] args) {
        Console.WriteLine("grabfood delivery");
        Console.WriteLine("Please select menu");
        Console.WriteLine("-------------");
       Console.WriteLine("1. Breakfast Set");
       Console.WriteLine("2. Weekend Set");
       Console.WriteLine("3. coffee");
       Console.Write("Please enter a valid menu: ");
       string input = Console.ReadLine();
       switch(input) {
        case "Breakfast Set": 
            Console.Clear();
            
            Console.WriteLine("Ok Please Wait^^");
            break;
        case "Weekend Set":
            Console.Clear();
            Console.WriteLine("Weekend Set");
            break;
        case "coffee": 
            Console.Clear();
            Console.WriteLine("Sorry your order is out of stock TT");
            break;
        default: 
            Console.WriteLine("End");
            break;
       }

    }
   
    
}
 
 
  