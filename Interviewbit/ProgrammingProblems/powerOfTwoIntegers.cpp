int isPower(int A)
{
	int i, a;
	double p;
	if (A == 1)
		return 1;
	for (a = 1; a <= sqrt(A*1.0); a++)
	{
		p = log(A*1.0) / log(a*1.0);
		if (p - (int)p < 0.000000001) // As p is double
			return 1;
	}
	return 0;
}
