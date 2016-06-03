int reverse(int x) {
    int n=0, d;
	
	while (x != 0){
		d = x % 10;
		x = x / 10;
		// Because MAX integer is 2147483647 and we are checking just before multiplying 10
		if (n > 214748364 || n < -214748364) return 0; 
		n = (n * 10) + d; 	
	
	}
	return n;
}
