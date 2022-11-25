int num = ReadInt("Введите число ");
int len = NumberLen(num);
SumNumbers(num, len);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int x)
{
    int index = 0;
    while (x > 0)
    {
        x /= 10; 
        index++;
    }
    return index;
}
void SumNumbers(int b, int len)
{
    int sum = 0;
    for (int a = 1; a <= len; a++)
    {
        sum += b % 10;
        b /= 10;
    }
    Console.WriteLine(sum);
}