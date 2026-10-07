// 1. Hello C#
Console.WriteLine("=== 1. Hello C# ===");
Console.WriteLine("Hello C#\n");

// 2. Kişisel Bilgiler
Console.WriteLine("=== 2. Student Information ===");
string name = "Sude Ilgın Boynukısa";
string department = "Computer Engineering";
int year = 2026;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Department: {department}");
Console.WriteLine($"Year: {year}\n");

// 3. Güncel Tarih ve Saat
Console.WriteLine("=== 3. Date and Time ===");
Console.WriteLine($"Date and time is: {DateTime.Now:dd.MM.yyyy HH:mm:ss}\n");

// 4. Sıcaklık Dönüşümü
Console.WriteLine("=== 4. Celsius -> Fahrenheit Conversion ===");
Console.Write("Input the Temperature (°C): ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
Console.WriteLine($"{celsius:F1} °C = {fahrenheit:F2} °F");