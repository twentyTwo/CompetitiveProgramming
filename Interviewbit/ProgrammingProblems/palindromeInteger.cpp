int PalindromeInteger(int A){
	int nDigits = 0, revNum=0, t;
	int tempA = A;
	
	
	while (tempA != 0){
		tempA /= 10;
		nDigits++;
	}

	for (int i = 1; i <= nDigits / 2; i++)
	{
		t = A % 10;
		A /= 10;
		revNum = revNum * 10 + t;
	}

	if (nDigits & 1 == 1) A /= 10;
	
	if (A == revNum) return 1;
	return 0;
}