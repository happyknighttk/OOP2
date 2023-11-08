//3. Gün

int n1 = 10;
int n2 = 20;

n1 = n2;
n2 = 65;
Console.WriteLine(n1);

int[] numbers1 = new int[] { 10,20,30 };
int[] numbers2 = new int[] { 100,200,300 };
numbers1 = numbers2;
numbers2[0] = 999;
Console.WriteLine(numbers1[0]);