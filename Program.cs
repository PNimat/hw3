// Задача 19

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPalindrome(number));

string isPalindrome(int num)
{
    if(num>10000 && num<99999)
    {
        int first = number/10000;
        int second = number/1000%10;
        int therd = number/100%10;
        int fourth = number/10%10;
        int fifth = number%10;
        
        Console.WriteLine($"{first} {second} {therd} {fourth} {fifth}");
        if(first == fifth && second == fourth)
        {
            return "Число является полиндромом";
        }
        else return "Число не является полиндромом";
    }
    else return "Число не подходит";
}
*/

// Задача 21
/*
double res = Distance(3, 6, 8, 2, 1, -7);
Console.WriteLine(res);

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int i1 = xb-xa;
    int i2 = yb-ya;
    int i3 = zb-za;

    int fSt = Convert.ToInt32(Math.Pow(i1, 2));
    int sSt = Convert.ToInt32(Math.Pow(i2, 2));
    int tSt = Convert.ToInt32(Math.Pow(i3, 2));

    int sum = fSt + sSt + tSt;

    double result = Math.Sqrt(sum);
    return result;
}
*/


// Задача 23

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
do
{
    int conv = Convert.ToInt32(Math.Pow(count, 3));
    count++;
    Console.Write(conv + " ");
}
while (count<=n);

