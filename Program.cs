static void tambah (int a, int b)
{
    int c = 0;
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang(int a, int b)
{
    int c = 0;
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void pembagian(int a, int b)
{
    int c = 0;
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

static void perkalian(int a, int b)
{
    int c = 0;
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

tambah(22, 4);
kurang(40, 20);
pembagian(25, 5);
perkalian(10, 10);