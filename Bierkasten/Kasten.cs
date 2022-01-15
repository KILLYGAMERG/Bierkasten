namespace Bierkasten;

public class Kasten
{

    public int NumberBottles { get; set; }
    public String KastenType { get; set; }
    public int NumberEmptyBottles { get; set; } = 0;

    public Kasten(int numberBottles, string name)
    {
        this.NumberBottles = numberBottles;
        this.KastenType = name;
    }

    public void TakeBottle()
    {

    }

    public void CreateSmallKasten(int Size)
    {
        Console.Write("-");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == 0 || i == 4)
                {
                    Console.Write("----");
                }
                else
                {
                    if (i == 1 && j == 0 && Size == 11)
                    {
                        j++;
                    }
                    if (i * j >= NumberBottles - NumberEmptyBottles)
                    {
                        Console.Write("| o ");
                    }
                    else
                    {
                        Console.Write("| * ");
                    }
                }
                if (j == 3 && (i != 0 && i != 4))
                {
                    Console.Write("|");
                }
            }
            if (i == 4)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }

    }
    public void CreateKasten(int Size)
    {
        Console.Write("-");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < Size / 4; j++)
            {
                if (i == 0 || i == 5)
                {
                    Console.Write("----");
                }
                else
                {
                    if (i * j >= NumberBottles - NumberEmptyBottles)
                    {
                        Console.Write("| o ");
                    }
                    else
                    {
                        Console.Write("| * ");
                    }
                }
                if (j == Size/4 -1 && (i != 0 && i != 5))
                {
                    Console.Write("|");
                }
            }
            if (i == 5)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }

    }
}

