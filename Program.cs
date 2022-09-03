int a = 10; // int - целочисленные данные
float b = 12.4f; // float дробные числа
string d = "Hello World"; // string - строковые данные 
double c = 8.4; // double дробные числа
bool e = true; // false // bool данные с условием то есть истина или ложь

Console.WriteLine(a * 10 + 20);

Console.WriteLine("Введите число от 1 до 10 ");
string name = Console.ReadLine(); // "5" + "5" = "55"
int number = Convert.ToInt32(name); // 5 + 5 = 10
int sekretNumber = 7;
if(number > sekretNumber)
{
    Console.WriteLine("Секретное число меньше");
}
else if(number < sekretNumber)
{
    Console.WriteLine("Секретное число больше");
}
else
{
    Console.WriteLine("Мы угадали");
}