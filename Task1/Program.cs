void PrintNumbers(int m, int n)
{
	if (m > n)
	{
		return;
	}

	Console.WriteLine(m);
	PrintNumbers(m + 1, n);
}

int m = 1;
int n = 5;
PrintNumbers(m, n);