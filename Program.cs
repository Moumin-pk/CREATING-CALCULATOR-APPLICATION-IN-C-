using Calculater_in_C_Sharp;

Calculater CalculaterObj = new Calculater();

Console.WriteLine("Enter your First Number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Operater( +, - , / , *)");
string? op = Console.ReadLine();




if(op == "+")
{
    Console.WriteLine($"Sum of {num1} or {num2} is = {CalculaterObj.sum(num1,num2)}");
}
else if (op == "-")
{
    Console.WriteLine($"Minis of {num1} or {num2} is = {CalculaterObj.min(num1,num2)}");
}
else if (op == "/")
{
    Console.WriteLine($"Division of {num1} or {num2} is = {CalculaterObj.Div(num1,num2)}");
}
else if (op == "*")
{
    Console.WriteLine($"Multiplay of {num1} or {num2} is = {CalculaterObj.Mult(num1,num2)}");
}
else if (op == "%")
{
    Console.WriteLine($"Moduls of {num1} or {num2} is = {CalculaterObj.Moduls(num1,num2)}");
}
else
{
    Console.WriteLine("Please Enter Valid Operater");
}



Console.WriteLine(34.40M);