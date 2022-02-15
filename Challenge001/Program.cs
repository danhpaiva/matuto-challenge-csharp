using static System.Console;

WriteLine("\tSorting Algorithm\n");

int[] numbers = { 10, 2, 7, 50, 1, 9, 100, 34, 67 , 77 };

WriteLine("Original Array: ");
ShowArray(numbers);

WriteLine("\n\n\tSorting the array using Bubble Sort\n");
int[] arraySorted = bubbleSort(numbers);

WriteLine("Sorted Array: ");
ShowArray(arraySorted);

ReadLine();

static void ShowArray(int[] arrayNumbers)
{
	foreach (int number in arrayNumbers)
		Write($"{number} ");
}

static int[] bubbleSort(int[] array)
{
	int size = array.Length - 1;
	int comparisonNumber = 0;
	int changeNumber = 0;

	for (int i = size; i >= 1; i--)
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
