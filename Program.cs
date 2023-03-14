void Q01()
{
    int indice = 13, soma = 0, k = 0;
    
    while (k < indice)
    {
        k++;
        soma += k;
        Console.WriteLine(soma);
    }

    Console.WriteLine(soma);
}

void Q02()
{
    List<int> numeroFibo = new List<int> { 1, 1 };
    int item;

    Console.WriteLine("Insira o valor:");
    int compare = Int32.Parse(Console.ReadLine());

    while (numeroFibo.Count <= 30)
    {
        var numero1 = numeroFibo[numeroFibo.Count - 1];
        var numero2 = numeroFibo[numeroFibo.Count - 2];

        item = numero1 + numero2;
        numeroFibo.Add(item);
    }

    if (numeroFibo.Contains(compare))
        Console.WriteLine("Número pertence a sequencia");
    else
        Console.WriteLine("Não pertence");
}

void Q03()
{
    double menorValor = 0, maiorValor = 0, soma = 0, media = 0;


    List<Dados> diaMes = new List<Dados>()
        {
            new Dados() {Dia = 1, Valor = 22174.1664},
            new Dados() {Dia = 2, Valor = 24537.6698},
            new Dados() {Dia = 3, Valor = 26139.6134 },
            new Dados() {Dia = 4, Valor = 0.0},
            new Dados() {Dia = 5, Valor = 0.0},
            new Dados () { Dia = 6, Valor = 26742.6612 },
            new Dados () { Dia = 7, Valor = 0.0 },
            new Dados () { Dia = 8, Valor = 42889.2258 },
            new Dados () { Dia = 9, Valor = 46251.174 },
            new Dados () { Dia = 10, Valor = 11191.4722 },
            new Dados () { Dia = 11, Valor = 0.0 },
            new Dados () { Dia = 12, Valor = 0.0 },
            new Dados () { Dia = 13, Valor = 3847.4823 },
            new Dados () { Dia = 14, Valor = 373.7838 },
            new Dados () { Dia = 15, Valor = 2659.7563 },
            new Dados () { Dia = 16, Valor = 48924.2448 },
            new Dados () { Dia = 17, Valor = 18419.2614 },
            new Dados () { Dia = 18, Valor = 0.0 },
            new Dados () { Dia = 19, Valor = 0.0 },
            new Dados () { Dia = 20, Valor = 35240.1826 },
            new Dados () { Dia = 21, Valor = 43829.1667 },
            new Dados () { Dia = 22, Valor = 18235.6852 },
            new Dados () { Dia = 23, Valor = 4355.0662 },
            new Dados () { Dia = 24, Valor = 13327.1025 },
            new Dados () { Dia = 25, Valor = 0.0 },
            new Dados () { Dia = 26, Valor = 0.0 },
            new Dados () { Dia = 27, Valor = 25681.8318 },
            new Dados () { Dia = 28, Valor = 1718.1221 },
            new Dados () { Dia = 29, Valor = 13220.495 },
            new Dados () { Dia = 30, Valor = 8414.61 },
        };

    menorValor = diaMes.Select(i => i.Valor).Min();

    maiorValor = diaMes.Select(i => i.Valor).Max();

    soma = diaMes.Sum(i => i.Valor);
    media = diaMes.Average(i => i.Valor);

    Console.WriteLine("menor valor: " + menorValor);
    Console.WriteLine("maior valor: " + maiorValor);
    Console.WriteLine("soma: " + soma);
    Console.WriteLine("media: " + media);

    var menoresDias = diaMes.Where(i => i.Valor == menorValor).Select(i => i.Dia);
    Console.Write("Menores dias: ");
    foreach (int dia in menoresDias)
    {
        Console.Write(dia + " ");
    };
    var maioresDias = diaMes.Where(i => i.Valor == maiorValor).Select(i => i.Dia);
    Console.Write("Maiores dias: ");
    foreach (int dia in maioresDias)
    {
        Console.Write(dia + " ");
    };

}

void Q04()
{
    double sp = 67.83643;
    double rj = 36.67866;
    double mg = 29.22988;
    double es = 27.16548;
    double outro = 19.84953;
    double total = sp + rj + mg + es + outro;

    double percentualSP = (sp / total) * 100;
    double percentualRJ = (rj / total) * 100;
    double percentualMG = (mg / total) * 100;
    double percentualES = (es / total) * 100;
    double percentualOutro = (outro / total) * 100;

    Console.WriteLine($"Percentual de SP {percentualSP} %");
    Console.WriteLine($"Percentual de RJ {percentualRJ} %");
    Console.WriteLine($"Percentual de MG {percentualMG} %");
    Console.WriteLine($"Percentual de ES {percentualES} %");
    Console.WriteLine($"Percentual de Outros Estados {percentualOutro} %");


}

void Q05()
{
    string str = "Reverse";

    char[] chars = str.ToCharArray();

    for (int i = 0; i < str.Length / 2; i++)
    {
        char ch = chars[i];
        chars[i] = chars[str.Length - i - 1];
        chars[str.Length - i - 1] = ch;
    }

    new string(chars);
    Console.WriteLine(chars);
}

Q05();