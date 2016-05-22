string convertToTitle(int A) {
	string r = "";
	while (A > 0) {
		r = (char)(65 + (A - 1) % 26) + r;
		A = (A - 1) / 26;
	}
	return r;
}
