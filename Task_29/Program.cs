int lenArray = ReadInt("Длина массива ");
int[] randomArray = new int[lenArray];
for (int a = 0; a < randomArray.Length; a++)
{
    randomArray[a] = new Random().Next(1,9);
    Console.Write(randomArray[a] + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}