Console.Write("Enter the Celsius temperature: ");
double celcius=double.Parse(Console.ReadLine()!);

double kelvin = celcius + 273.15;
double fahrenheit = (celcius * 9 / 5) + 32;

Console.WriteLine($"Kelvin is: {kelvin:f2}");
Console.WriteLine($"Fahrenheit is: {fahrenheit:f2}");
