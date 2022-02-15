using static System.Console;

WriteLine("\tSorting Algorithm");

int[] numbers = { 10, 2, 7, 50, 1, 9, 100, 34, 67 , 77 };

WriteLine("Sorting with Bubble Sort\n");

Write("Original Array: ");

foreach (int number in numbers)
    Write($"{number} ");

WriteLine("\n\nSorting the array using Bubble Sort\n");
int[] arraySorted = bubbleSort(numbers);

Write("Sorted Array: ");
foreach (int number in arraySorted)
    Write($"{number} ");

ReadLine();

static int[] bubbleSort(int[] array)
{
	int size = array.Length;
	int comparisonNumber = 0;
	int changeNumber = 0;

	for (int i = size - 1; i >= 1; i--)
	{
		for (int j = 0; j < i; j++)
		{
			comparisonNumber++;
			if (array[j] > array[j + 1])
			{
				int aux = array[j];
				array[j] = array[j + 1];
				array[j + 1] = aux;
				changeNumber++;
			}
		}
	}

	return array;
}
