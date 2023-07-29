Console.WriteLine("Write number: ");

try
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Result = {inputNumber + 10}");
}

catch
{
    Console.WriteLine("Incorrect value");
}