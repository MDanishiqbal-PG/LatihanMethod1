static void tambah ()
{
    int a = 10, b = 2, c = 0;
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang()
{
    int a = 10, b = 2, c = 0;
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void pembagian()
{
    int a = 10, b = 2, c = 0;
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

static void perkalian()
{
    int a = 10, b = 2, c = 0;
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

tambah();
kurang();
pembagian();
perkalian();