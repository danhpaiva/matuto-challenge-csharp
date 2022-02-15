using static System.Console;

namespace Challenge001
{
	public class SortArray
	{
		public void ShowArray(int[] arrayNumbers)
		{
			foreach (int number in arrayNumbers)
				Write($"{number} ");
		}

		public int[] BubbleSort(int[] array)
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
	}
}
