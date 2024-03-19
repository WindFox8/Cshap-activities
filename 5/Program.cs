/*Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays. */

using System.Globalization;
using System.Reflection.Metadata.Ecma335;

int[] nums1 = arrayEntry();
int[] nums2 = arrayEntry();
int[] mergedArray = nums1.Concat(nums2).ToArray();
Array.Sort(mergedArray);
decimal median;

if (mergedArray.Length % 2 == 0){
    int index = mergedArray.Length / 2;
    median = Convert.ToDecimal(mergedArray[index] + mergedArray[index - 1]) / 2;    
    showResult(mergedArray, median);
}

else {
    median = mergedArray[mergedArray.Length / 2];
    showResult(mergedArray, median);
}

void showResult(int[] array, decimal median){
    Console.Write("Merged array = ");
    foreach (int element in array){
        Console.Write($"{element} ");
    }
    Console.Write($"and median is {median}.");
}

int[] arrayEntry(){
    Console.Write("Digite o tamanho do array: ");
    int tamanho = int.Parse(Console.ReadLine());

    int[] array = new int[tamanho];

    Console.Write("Digite numeros inteiros  separados por espaço para serem inseridos no array: ");

    string[] elementos = Console.ReadLine().Split(' ');

    for (int i = 0; i < tamanho; i++){
    array[i] = int.Parse(elementos[i]);
    }

    return array;
}