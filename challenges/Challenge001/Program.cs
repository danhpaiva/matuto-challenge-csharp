using Challenge001;
using static System.Console;

WriteLine("\tSorting Algorithm\n");

int[] numbers = { 10, 2, 7, 50, 1, 9, 100, 34, 67 , 77 };
SortArray sortArray = new();

WriteLine("Choose a sorting type:\n[1]Bubble Sort [2]Merge Sort [3]Quick Sort [4]Heap Sort [X]Exit");
string option = ReadLine().ToUpper();

switch (option)
{
    case "1":
        Clear();
        WriteLine("Original Array: ");
        sortArray.ShowArray(numbers);

        WriteLine("\n\n\tSorting the array using Bubble Sort\n");
        int[] arrayBubble = sortArray.BubbleSort(numbers);

        WriteLine("Sorted Array: ");
        sortArray.ShowArray(arrayBubble);
        ReadLine();
        break;
    case "X":
        WriteLine("Thanks...Press Enter to exit...");
        Console.ReadLine();
        break;
    default:
        WriteLine("Number Invalid...\nPress Enter to exit...");
        Console.ReadLine();
        break;
}