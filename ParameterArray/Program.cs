int[] Numbers = new int[3];

Numbers[0] = 300;
Numbers[1] = 200;
Numbers[2] = 78;

ParamsMethod(Numbers);

void ParamsMethod(params int[] Numbers)
{
    Console.WriteLine($"There are {Numbers.Length}");

    foreach (int i in Numbers)
    {
        Console.WriteLine(i);
    }
}
