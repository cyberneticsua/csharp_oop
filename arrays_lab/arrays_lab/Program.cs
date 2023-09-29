//Масиви - набір однотипних даних
//тип_змінної [] назва_масиву;
int [] numbers;

//Для ініціалізації масиву використовується наступний синтаксис:
int[] nums = new int[4];

//new - створення нового об'єкту
//[4] - довжина цього масиву

int[] nums2 = new int[4] { 1, 2, 3, 5 };

int[] nums3 = new int[] { 1, 2, 3, 5 };

int[] nums4 = new[] { 1, 2, 3, 5 };

int[] nums5 = { 1, 2, 3, 5 };

//Всі методи рівноцінні
string[] names = {"Igor", "Iryna", "Kateryna"};

//Звертання до елементів масиву здійснюється за їх індексом
//Індекс першого елементу = 0
Console.WriteLine(names[2]);

names[1] = "Tetiana";
Console.WriteLine(names[1]);

//Властивість Length - повертає довжину масиву
Console.WriteLine(names.Length);

//Звертання до останнього елемента масиву
Console.WriteLine(names[names.Length-1]);

//Починаючи з версії C# 8.0 використовується спеціальний оператор ^
Console.WriteLine(names[^1]);
Console.WriteLine(names[^3]);

//Перебір елементів масиву
int[] numbers_array = {1,2,3,4,5};

Console.WriteLine("Foreach Loop");
foreach (int number in numbers_array)
{
    Console.WriteLine(number);
}

Console.WriteLine("For Loop");
for (int i = 0; i < numbers_array.Length; i++)
{
    Console.WriteLine(numbers_array[i]);
}

Console.WriteLine("While");
int j = 0;
while (j < numbers_array.Length)
{
    Console.WriteLine(numbers_array[j]);
    j++;
}
//У циклі foreach ми не можемо змінювати значення змінної

//Багатовимірні масиви
//Ранг - це кількість вимірів
int[,] nums1;
int[,] nums22 = new int[2, 3];
int[,] nums23 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums24 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums25 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums26 = { { 0, 1, 2 }, { 3, 4, 5 } };

//оголошення тривимірного масиву
int[,,] nums33 = new int[3, 4, 5];

//В кожного масиву є метод GetUpperBound(номер розмірності), який повертає індекс останнього
//елементу у визначеному вимірі
int rows = nums25.GetUpperBound(0)+1;
int columns = nums25.GetUpperBound(1)+1;

for (int i = 0; i < rows; i++)
{
    for (int k = 0; k < columns; k++)
    {
        Console.Write($"{nums25[i, k]} \t");
    }
    Console.WriteLine();
}