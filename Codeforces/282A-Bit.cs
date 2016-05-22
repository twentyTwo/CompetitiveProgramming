using System;

class Program {
  static void Main() {
    int x = 0, i=0;
	string str;
    int n = int.Parse(Console.ReadLine());
    for (i = 0 ; i < n ; i++) {
      str = Console.ReadLine();
      if (str.Contains("++")) x++; else x--;
    }
    Console.WriteLine(x);
  }
}
