Converter converter = new Converter();

Console.Write("Вкажіть яку саме валюту бажаєте конвертувати (якщо гривню - 1, євро - 2, долар - 3): ");
string? value = Console.ReadLine();

Console.Write("В яку валюту потрібно конвертувати (якщо в гривню - 1, євро - 2, долар - 3): ");
string? converted = Console.ReadLine();
double result;

#region Converter
if (converted == "1" && value == "1")
{
    Console.Write("Ви бажаєте конвертувати однакові валюти. Змініть одну з валют.");
    return;
}
else if (converted == "2" && value == "1")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.uah = Convert.ToDouble(Console.ReadLine());

    result = converter.uah * 0.0244;
}
else if (converted == "3" && value == "1")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.uah = Convert.ToDouble(Console.ReadLine());

    result = converter.uah * 0.0238;
}
else if (converted == "1" && value == "2")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.eur = Convert.ToDouble(Console.ReadLine());

    result = converter.eur * 40.95;
}
else if (converted == "2" && value == "2")
{
    Console.Write("Ви бажаєте конвертувати однакові валюти. Змініть одну з валют.");
    return;
}
else if (converted == "3" && value == "2")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.eur = Convert.ToDouble(Console.ReadLine());

    result = converter.eur * 0.95;
}
else if (converted == "1" && value == "3")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.usd = Convert.ToDouble(Console.ReadLine());

    result = converter.usd * 42;
}
else if (converted == "2" && value == "3")
{
    Console.Write("Введіть суму, яку потрібно конвертувати: ");
    converter.usd = Convert.ToDouble(Console.ReadLine());

    result = converter.usd * 0.9953;
}
else if (converted == "3" && value == "3")
{
    Console.Write("Ви бажаєте конвертувати однакові валюти. Змініть одну з валют.");
    return;
}
else
{
    Console.WriteLine("Невірно вказанй код валюти.");
    return;
}
#endregion

Console.WriteLine("Конвертована сума: " + result);