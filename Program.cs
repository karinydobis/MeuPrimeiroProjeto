
try
{
    Console.WriteLine("Digite um valor:");
    int valor = int.Parse(Console.ReadLine());

    Console.WriteLine(valor / 0);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("ERRO AO DIVIDIR POR ZERO!");
}
catch(FormatException ex)
{
    Console.WriteLine($"FORMATO INVÁLIDO!");
}
catch(Exception ex)
{
    Console.WriteLine("VALOR INVÁLIDO" + ex.Message);
}