#include <stdio.h>

/*
	Tips: Is 123456789 divisible by 11?
	Check whether +1-2+3-4+5-6+7-8+9 is divisible by 11 or not.
*/

int main(){
	char str[1001];
	int num = 0, i, a = 0, b = 0;;

	while (scanf(" %s[^\n]", str)){ 
		a = b = 0;
		if (str[0] == '0' && str[1] == '\0') break;

		i = 0;
		while (str[i]){
			if (i % 2) b += str[i] - '0';
			else a += str[i] - '0';
			i++;
		}

		if ((a-b) % 11==0) printf("%s is a multiple of 11.\n", str);
		else printf("%s is not a multiple of 11.\n", str);		
	}
	return 0;
}
