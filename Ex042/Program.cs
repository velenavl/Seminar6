// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string str = ConvertNumber(x);
// string ConvertNumber(int x)
// {
//     string result = "";
//     while(x > 0)
//     {
//         int y = x % 2;
//         result = Convert.ToString(y) + result;
//         x = x / 2;
//     }
//     return result;
// }
// Console.WriteLine(str);

Console.WriteLine("Введите десятичное число: ");
int i = Convert.ToInt32(Console.ReadLine());
string s= Convert.ToString(i, 2);
Console.WriteLine("В двоичной системе исчисления это: "+s);
    