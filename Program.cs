// Jacob Dekok
// 10/17/2022
// Git Hub Transfer - Mini Challenge #7 Reverse number
// This is a conosle project that reverses
// a number or string that the user inputs


Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

bool validChoice = false;
string num = "";
bool isConverted = false;
bool isNumber;
int x = 0;
int y = 0;


while(!validChoice){

    Console.WriteLine("Would you like to Reverse Integers or Strings? 'Integer' 'String'");
string UC = Console.ReadLine().ToLower();

if(UC == "string"){
    
    validChoice = true;

    Console.Write("Enter a String: ");
    char[] charArray = Console.ReadLine().ToCharArray();
	

	string reversedInput = "";
	
	for(int i = charArray.Length - 1; i > -1; i--){
		
		reversedInput += charArray[i];
    }
    
    Console.WriteLine(reversedInput);
}else if (UC == "integer"){

    validChoice = true;

    while(isConverted != true){
    
    Console.Write("Enter an Integer: ");
    num = Console.ReadLine();

    isNumber = Int32.TryParse(num, out x);

    if(isNumber == true){
        isConverted = true;
    }else{
        Console.WriteLine("Invalid entry, please try again. ");
    }
}

 while(x != 0){

    int z = x % 10;
    y = y * 10 + z;
    x /= 10;
}
    Console.WriteLine("Reversed Number: " + y);

 }else{
    Console.WriteLine("I'm sorry that input was invalid.");
}

}



    Console.WriteLine("");
    Console.WriteLine("Would you like to reverse another? 'YES' 'NO'");
    playAgain = Console.ReadLine().ToUpper();
    Console.WriteLine("");

    if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

}

