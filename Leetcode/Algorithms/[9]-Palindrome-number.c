bool isPalindrome(int x) {
  int nDigits = 0, revNum=0, t;
	int tempA = x;
	
	if(x<0) return false;
	
	while (tempA != 0){
		tempA /= 10;
		nDigits++;
	}

	for (int i = 1; i <= nDigits / 2; i++)
	{
		t = x % 10;
		x /= 10;
		revNum = revNum * 10 + t;
	}

	if (nDigits & 1 == 1) x /= 10; // oddNumber & 1 == 1, evenNumber & 1 = 0
	
	if (x == revNum) return true;
	return false;
}
