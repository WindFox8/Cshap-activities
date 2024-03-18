/* Given a string, find the length of the longest substring without repeating characters. The string consists of English letters, numbers, digits, symbols and spaces. */

Console.WriteLine("This program find the length of the longest substring without repeating characters");
Console.Write("Write something for verification: ");
string userInput = Console.ReadLine();
string noRepeat = "";

for (int i = 0; i < userInput.Length; i++){
    
    string temp = "";

    for (int j = i; j < userInput.Length; j++){
        if (!temp.Contains(userInput[j])){
            temp += userInput[j];
        }
        else{
            if (temp.Length > noRepeat.Length){
                noRepeat = temp;
                break;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine($" The answer is \"{noRepeat}\" with the length of {noRepeat.Length}");