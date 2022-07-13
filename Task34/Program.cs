// Task 34

Console.Write("Введите длину массива: ");
int lenthArr = Convert.ToInt32(Console.ReadLine());
int[] newArr = new int[lenthArr];
int total = 0;
for (int i = 0; i < lenthArr; i++)
{
    newArr[i] = new Random().Next(100, 1000); // newArr[i] = rnd.Next(-9, 10);
    Console.Write(newArr[i] + " ");
    if(newArr[i] % 2 == 0)
    {
         total++;
    }
    
}
Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine("Количество четных чисел в массиве: " + total);