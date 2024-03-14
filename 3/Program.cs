int[] l1 = GetUserInput("Array1");
int[] l2 = GetUserInput("Array2");
int[] sum = new int[5];

int offSetIncrement = 0;

ArraySum();

Console.Write("Sum: ");
foreach (int i in sum){
    Console.Write($"{i} ");
}

int[] GetUserInput(string arrayName){
    Console.WriteLine($"Please enter 5 integers for {arrayName}:");
    Console.WriteLine();
    int[] array = new int[5];

    for (int i = 0; i < 5; i++){
        bool isValidInput = false;
        while (!isValidInput){
            Console.Write($"Number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int value)){
                if (value >= 0 && value <= 9){
                    array[i] = value;
                    isValidInput = true;
                }
                else{
                    Console.WriteLine("Invalid input! Please enter an integer between 0 and 9.");
                }
            }
            else{
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
    }
    Console.WriteLine();
    return array;
}

void ArraySum (){

    Array.Reverse(l1);
    Array.Reverse(l2);

    for (int i=0; i<l1.Length; i++){
        sum[i] = l1[i] + l2[i];
        if (offSetIncrement == 1){
            sum[i] += 1;
            offSetIncrement--;
        }

        if (sum[i] > 9){
            sum[i] -= 10;
            offSetIncrement++;
        }

        if (i == l1.Length - 1 && offSetIncrement == 1){
            Array.Resize(ref sum, 6);
            sum[5] = offSetIncrement;
        }
    }
}

int[] ArrayInvert (int[] array){
    int[] arrayTemp = new int[array.Length];
    Array.Copy(array, arrayTemp, array.Length);
    Array.Reverse(arrayTemp);

    return arrayTemp;
}