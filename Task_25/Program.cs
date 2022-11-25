Console.WriteLine("Число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int x = 1; x < b; x++)
{ 
    step = step * a;
}
Console.WriteLine("A в натуральной степени B равно " + step); 