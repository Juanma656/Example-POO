using ExamplePOO;

Console.WriteLine("EXAMPLE POO");
Console.WriteLine("===========");

try
{
    Console.WriteLine(new Date(2022, 2, 11));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1998, 11, 45));
    Console.WriteLine(new Date(2013,12, 8));
}
catch (Exception Error)
{
    Console.WriteLine(Error.Message);
}

