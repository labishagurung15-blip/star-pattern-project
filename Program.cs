for(int i=0;i<5;i++)
{
    for(int j=0;j<=5;j++)
    {
        Console.Write("*");
    }
        Console.WriteLine("");
}


string? star = "";

for (int i=0; i < 5; i ++)
{
    for (int j=0; j < 5; j++)
    {
        star += "*";
    }
        star +="\n";
}
Console.WriteLine(star);


// Console.WriteLine("no of star rows: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < num + 1; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine("");
// }



Console.WriteLine("no of star rows: ");

int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < num + 1; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (j == 0 || j == i - 1 || i == num)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }

    Console.WriteLine("");
}
