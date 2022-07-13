// Task38


double[] newArr = new double[5]{3, 7, 22, 2, 78};
int minNumb = 0;
int maxNumb = 0;
double result = 0;
for (int i = 0; i < 5; i++) 
{
    if(newArr[i] < newArr[minNumb])
    {
        minNumb = i;
    }
    else if(newArr[i] > newArr[maxNumb])
    {
        maxNumb = i;
    }
}

result = newArr[maxNumb] - newArr[minNumb];
Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine("Разница между максимальным и минимальным значением массива = " + result);
