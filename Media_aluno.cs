Console.WriteLine("Informe as notas");

decimal n1 = Convert.ToDecimal(Console.ReadLine());
decimal n2 = Convert.ToDecimal(Console.ReadLine());
decimal n3 = Convert.ToDecimal(Console.ReadLine());
    decimal result = (n1 + n2 + n3)/3;

    if(result >= 6)
{
    Console.WriteLine($"sua média é {result.ToString("N2")} parabens! Você passou.");
}
else
{
    Console.WriteLine($"sua média é {result.ToString("N2")} infelizmente você reprovou.");
    if(result <= 4 || result <= 6)
    {
        Console.WriteLine("Informe a nota da prova de recuração.");
        decimal recupercao = Convert.ToDecimal(Console.ReadLine());
        result = (n1 + n2 + n3 + recupercao) / 4;        
        if(result >= 6)
        {
            Console.WriteLine($"sua média é {result.ToString("N2")} parabens! Você passou.");
        }
        else
        {
            Console.WriteLine($"sua média é {result.ToString("N2")} infelizmente você reprovou.");
        }   

    }
}
