int a = 39;
int b = 15;
int c = 20;
int d = 78;
int e = 41;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max =");
Console.WriteLine(max);