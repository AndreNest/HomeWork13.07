// Task 36

Console.Write("Введите длину массива: ");
int lenthArr = Convert.ToInt32(Console.ReadLine());
int[] newArr = new int[lenthArr];
int total = 0;
for (int i = 1; i < lenthArr; i+=2) //if(i % 2 != 0) // for (int i = 0; i < lenthArr && i % 2 != 0; i++)
{
    newArr[i] = new Random().Next(100, 1000); // newArr[i] = rnd.Next(-9, 10);
    Console.Write(newArr[i] + " "); 
    total = total + newArr[i];
    
    
}
Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine("Сумма нечетных значений массива " + total);
