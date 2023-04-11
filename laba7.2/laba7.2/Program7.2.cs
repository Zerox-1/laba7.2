using laba7._2.laba7._2;
using laba7_2;
Worker Ivan = new("Иван", "Кукин", new DateTime(1950, 04, 01), Convert.ToChar("м"), 30000, 25);
Console.WriteLine(Ivan);
Worker Ludmila = new("Людмила", "Кукина", new DateTime(1965, 05, 01), Convert.ToChar("ж"), 30000, 0);
Console.WriteLine(Ludmila);
Building a = new Building();
a.Cost = 3000000;
a.Address = "Зайцева, 79";
Building b = new Building(a);
a.Owner = Ivan;
b.Owner = Ludmila;
Stead a1 = new Stead(Ivan, 500000, 600);
Stead b1 = new(a1);
b1.Owner = Ludmila;
Stead a2 = new(Ivan, 300000, 1000);
Horse h2 = new(Ivan, 20000, 7, 250, "Ромашка");
Car c2 = new(Ivan, 10000, 27, "ЗАЗ-965", 27);
SmallShip s2 = new(Ivan, 25000, 0, 15, "", 15);
Holding[] arr = new Holding[6]; Holding[] arr2 = new Holding[6];
arr[0] = a;
arr[1] = a1;
arr[2] = a2;
arr[3] = h2;
arr[4] = c2;
arr[5] = s2;
arr2[0] = a;
arr2[1] = a1;
arr2[2] = a2;
arr2[3] = h2;
arr2[4] = c2;
arr2[5] = s2;
double sum = 0;
for (int i = 0; i < 6; i++)
{
    sum += arr[i].Cost;
}
Console.WriteLine("Oбщая стоимость их имущества: " + sum);

INalog[] arr1 = new INalog[6];
arr1[0] = a;
arr1[1] = a1;
arr1[2] = a2;
arr1[3] = c2;
arr1[4] = s2;
arr1[5] = h2;

double sum1 = 0;
for (int i = 0; i < 6; i++)
{
    sum1 += arr1[i].nalog();
}
Console.WriteLine("Oбщая стоимость их налогов: " + sum1);
Console.WriteLine("Не упорядоченные стоимости:");
for(int i=0; i<6; i++)
{
    Console.WriteLine(arr[i].Cost);
}
Console.WriteLine();
Console.WriteLine("Упорядоченные стоимости первым способом:");
for (int j = 0; j < 6; j++)
{
    for (int i = 0; i < 5; i++)
    {
        if (arr[i].CompareTo(arr[i + 1]) == 1)
        {
            Holding temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
            i--;
        }
    }
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(arr[i].Cost);
}
Console.WriteLine();
Console.WriteLine("Упорядоченные стоимости первым способом:");
Array.Sort(arr2);
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(arr2[i].Cost);
}