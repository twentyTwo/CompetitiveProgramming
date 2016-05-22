int ExelNumber(string A){
	int p = A.length() - 1;
	int sum = 0;

	for (int i = 0; i <A.length(); i++)
	{
		sum+= (A[i] - 'A' + 1)*pow(26, p--);
	}

	return sum;
}
