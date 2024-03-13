/* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. */

using System.Runtime.CompilerServices;

int[] nums = new int[5];
int target = 0;
string repeatProcedure;

do {
    UserEntry();
    Console.WriteLine();
    CheckNums();
    Console.WriteLine();

    Console.Write("Would you like to repeat the procedure? (y/n): ");
    repeatProcedure = Console.ReadLine().Trim().ToLower();
    Console.WriteLine();

    while (repeatProcedure != "y" && repeatProcedure != "n")
    {
        Console.WriteLine("Invalid input! Please enter 'y' or 'n'.");
        Console.Write("Would you like to repeat the procedure? (y/n): ");
        repeatProcedure = Console.ReadLine().Trim().ToLower();
        Console.WriteLine();
    }
} while (repeatProcedure == "y");


void UserEntry() {
    Console.WriteLine("Please enter 5 integers:");

    for (int i = 0; i < 5; i++){

        Console.Write($"Number {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out nums[i])){
            Console.WriteLine();
            Console.WriteLine("Invalid input! Please enter an integer.");
            Console.Write($"Number {i + 1}: ");
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Please enter the target sum:");

    Console.Write($"Target: ");
    while (!int.TryParse(Console.ReadLine(), out target)){
            Console.WriteLine();
            Console.WriteLine("Invalid input! Please enter an integer.");
            Console.Write($"Target: ");
    }
}

void CheckNums (){
    for (int i = 0; i < nums.Length; i++) {
        for (int j = i; j < nums.Length; j++){
            int sum = nums[i]+nums[j];
            if (target == sum){
                Console.WriteLine($"The sum of numbers {nums[i]} and {nums[j]} at positions {i} and {j} respectively, is equal to the target value which is {target}");
            }
        }
    }
}
