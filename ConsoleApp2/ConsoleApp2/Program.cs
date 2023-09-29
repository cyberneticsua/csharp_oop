// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Input your name:");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
//Console.ReadLine();

//Однорядковий коментар
/*
 * Багаторядковий коментар
 * Hello
 * Hello
 */

//Блочний оператор {}

//Залежний від регістру Console.WriteLine
string name_1;
string Name_1;

// Змінні
// Цілі числа, дійсні числа, рядки, символи, булевий тип
// Для оголошення змінної використовується наступний синтаксис
// тип_змінної імя_змінної;
int number;
float something;
bool val;
//Імя змінної:
//- може містити будь-які цифри, букви та символ підкреслення, але не може починатись з цифри
//валідне імя: _name, History345, a_b_c_d_1
//невалідне імя: 1name, school$$$$
//- ім'я не повинне містити пробілів і знаків пунктуація
//- ім'я змінної не може бути ключовим словом.
number = 1;
string my_name = "Igor"; //оголошуємо і ініціалізуємо змінну
char letter = '?';

//Константа const
const string NAME = "Igor";

//Консольне введення і виведення інформації
Console.WriteLine(); //виведення інформації в консоль
//Console.ReadLine(); //зчитування інформації з консолі

string my_name_1 = "Igor";
int age = 222;
double money = 5.44;
Console.WriteLine($"Name {my_name_1} age {age} money {money}");
Console.WriteLine(money);

//При зчитуванні з консолі за допомогою ReadLine ми отримаємо рядковий тип даних
//Для перетворення використовується клас Convert
//Convert.ToInt32 - перетворює в цілочисельний тип даних
//Convert.ToDouble - перетворює в дійсний тип (double)
int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{value1} + {value2} = {value1+value2}");
int result = value1 + value2;

//Арифметичні операції
// +
// -
// *
// / - ділення
// % - остача від цілочисельного ділення
// ++ - інкремента (збільшує значення змінної на 1)
// -- - декремента (зменшує значення змінної на 1)
int x = 1;
x++;
int a = x;

//15.09.2023
//Оператори присвоювання
// = , int x = 5; 
int b, c, e;
b = c = e = 11;
// +=, A+=B <=> A=A+B
// -=, A-=B <=> A=A-B
// *=, A*=B <=> A=A*B
// /=, A/=B <=> A=A/B
// %=, A%=B <=> A=A%B
// &=, |=, ^=, <<=, >>= - побітові операції присвоєння

//Явне перетворення типів
//Синтаксис (тип_в_який_хочемо_перетворити) значення;
//0 or 1 - 1 біт
//1 байт - 8 бітів, 00000000 (0) - 11111111 (255)
//byte -> short, ushort, int, uint, long, ulong, float, double, decimal
//sbyte -> short, int, long, float, double, decimal
//short -> int, long, float, double, decimal
//ushort -> int, uint, long, ulong, float, double, decimal
//int -> long, float, double, decimal
//uint -> long, ulong, float, double, decimal
//long -> float, double, decimal
//ulong -> float, double, decimal
//float -> double
//char -> ushort, int, uint, long, ulong, float, double, decimal
byte mm = 11;
int ll = (int) mm;
//для конвертації використується клас Convert
//Convert.ToInt32();
//int f = int.Parse(текст)

//Умовні оператори
//Операції порівняння:
//>, <, <=, >=
//== - порівняння двох операндів на рівність
//!= - перевіряє на нерівність два операнди
//Результат операцій порівнянн буде true або false
int p = 1;
int o = 2;
int d = 3;
bool r = p == o;

//Логічні операції
// | - логічне АБО
bool x1 = (7 > 10) | (7 > 5); //true
bool x2 = (7 > 10) | (7 < 5); //false
// & - логічне І
bool x11 = (7 < 10) & (7 > 5); //true
bool x22 = (7 > 10) & (7 < 5); //false
// || - логічне АБО
bool x111 = (7 > 10) || (7 > 5); //true
bool x222 = (7 > 10) || (7 < 5); //false
// && - логічне І
bool x1111 = (7 < 10) && (7 > 5); //true
bool x2222 = (7 > 10) && (7 < 5); //false
//! - логічне заперечення
bool kk = true;
bool rrr = !kk;
//Різниця між | та || (& та &&)
//У виразі y = x|z - будуть обчислюватись обидва значення x та y
//У виразі y = x||z - буде обчислюватись спочатку значення x, якщо воно true,
//то значення y не обчислюється, і результат буде true
// y = (10>5)||(10>100);

//У виразі y = x & z - будуть обчислюватись обидва значення x та y
//У виразі y = x && z - буде обчислюватись спочатку значення x, якщо воно false,
//то значення y не обчислюється, і результат буде false
// X    |   Z   |   Y   |
// false|false  |false  |
// false|true   |false  |
// true |false  |false  |
// true |true   |true   |
//y = (10<5) && (10<20);

//Умовний оператор
// if (умова)
// {
//      інструкції
// }
if (10 > 5) 
{
    Console.WriteLine("10>5");

}

if (10 > 5) Console.WriteLine("10>5");

//else
// if (умова)
// {
//      інструкції
// }
// else
// {
//      інструкції
// }
int num1 = 5;
int num2 = 10;
if (num1>num2)
{
    Console.WriteLine($"{num1}>{num2}");
}
else
{
    Console.WriteLine($"{num2}>{num1}");
}
//else if
// if (умова)
// {
//      інструкції
// }
// else if (умова)
// {
//      інструкції
// }
// else
// {
//      інструкції
// }
if (num1 > num2)
{
    Console.WriteLine($"{num1}>{num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2}>{num1}");
}
else 
{
    Console.WriteLine($"{num2}={num1}");
}

//Тернарна операція
//синтаксис [умова] ? [інструкція для true] : [інструкція для false]
int q = 2;
int t = 3;
int m = q > t ? (q + t) : (q * t);

//Цикли
//for
//foreach
//while
//do..while

//Цикл for - цикл з параметром
//for ([дія_до_виконання_циклу]; [умова]; [дія_після_виконання_ітерації])
//{
    //дії    
//}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
//int j = 0;
//for (;j<5;)
//{
//    Console.WriteLine(j);
//    j++;
//}

for (int i=1, j=15; i<10 && j>7; i++, j--)
{
    Console.WriteLine(i * j);
}

//while - цикл з передумовою
//while (умова)
//{
// дії циклу
//}

int k = 0;
while (k > 5)
{
    k++;
    Console.WriteLine(k*2);
}

//do..while - цикл з післяумовою
//do
//{
//дії циклу
//}
//while (умова);
int f = 0;
do
{
    f++;
    Console.WriteLine(f * 2);
}
while (f > 5);

//foreach - призначений для перебору набору або колекції елементів
//foreach(тип_даних змінна in колекція)
//{
//дії циклу
//}

foreach(char ccc in "Cybernetics")
{
    Console.WriteLine(ccc);
}

//Оператори continue та break
//break - вийти з цикли, не очікуючи його завершення
//наприклад: в наступному циклі будуть виведені в консоль значення від 0 до 4
for (int i=0; i<100; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}

//continue - переходить до наступної ітерації
//наприклад: в наступному циклі будуть виведені в консоль значення від 0 до 4, 6 до 99
for (int i = 0; i < 100; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}

for (int i=1; i<10; i++)
{
    for (int j=1; j<10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}