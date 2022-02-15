using Challenge001;
using static System.Console;

WriteLine("\tSorting Algorithm\n");

int[] numbers = { 10, 2, 7, 50, 1, 9, 100, 34, 67 , 77 };
SortArray sortArray = new();

WriteLine("Original Array: ");
sortArray.ShowArray(numbers);

WriteLine("\n\n\tSorting the array using Bubble Sort\n");
int[] arrayBubble = sortArray.BubbleSort(numbers);

WriteLine("Sorted Array: ");
sortArray.ShowArray(arrayBubble);

ReadLine();