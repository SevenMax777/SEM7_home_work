void PrintArrayReverse(int[] array, int i)
{
	if (i < 0)
		return;

	Console.Write(array[i] + " ");
	PrintArrayReverse(array, i - 1);
}

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReverse(array, array.Length - 1);