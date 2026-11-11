using Helpers;

Console.WriteLine("Welcome to the amazing addition application");
Console.WriteLine();

bool validEntry = false;
int firstNumber = 0;
int secondNumber = 0;

while (!validEntry)
{
    Console.WriteLine("Enter the first number - ");
     
    var number = Addition.ValidateValue(Console.ReadLine());
    if (number == null)
    {
        Console.WriteLine("Invalid number entered");
        continue;
    }

    firstNumber = number.Value;
    validEntry = true;
}

validEntry = false;

while (!validEntry)
{
    Console.WriteLine("Enter the second number - ");
     
    var number = Addition.ValidateValue(Console.ReadLine());
    if (number == null)
    {
        Console.WriteLine("Invalid number entered");
        continue;
    }

    secondNumber = number.Value;
    validEntry = true;
}

Console.WriteLine();
Console.WriteLine($"The amazing total is {firstNumber + secondNumber}");

Console.ReadKey();




