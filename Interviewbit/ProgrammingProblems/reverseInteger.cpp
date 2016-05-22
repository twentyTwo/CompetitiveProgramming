int ReverseInt(int A){
	int n=0, d;

	while (A != 0){
		d = A % 10;
		A = A / 10;
		if (n > 214748364 || n < -214748364) return 0;
		n = (n * 10) + d; 	
	}
	return n;
}
