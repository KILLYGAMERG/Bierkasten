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

    public bool TakeBottle(int NumberOfBottles)
    {
        
        if (NumberEmptyBottles + NumberOfBottles > NumberBottles) {
            Console.WriteLine("So viele Flaschen gibts leider nicht mehr, es gibt nur noch "+ (NumberBottles-NumberEmptyBottles));
            return false;   
        }
        NumberEmptyBottles = NumberEmptyBottles + NumberOfBottles;
        return true;
    }

    public void CreateSmallKasten(int Size)
    {
        int NumberPlacedBottels = 0;
        Console.Write("-");
        for (int i = 1; i < 6; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                if (i == 1 || i == 5)
                {
                    Console.Write("----");
                }
                else
                {
                    if (i == 3 && j == 1 && Size == 11)
                    {
                        j++;
                    }
                    if (NumberPlacedBottels >= NumberBottles - NumberEmptyBottles)
                    {
                        Console.Write("| o ");
                    }
                    else
                    {
                        Console.Write("| * ");
                    }
                    NumberPlacedBottels++;
                }
                if (j == 4 && (i != 1 && i != 5))
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
    public void CreateKasten(int Size)
    {
        int NumberPlacedBottels = 0;
        Console.Write("-");
        for (int i = 1; i < 7; i++)
        {
            for (int j = 1; j < Size / 4 + 1; j++)
            {
                if (i == 1 || i == 6)
                {
                    Console.Write("----");
                }
                else
                {
                    if (NumberPlacedBottels >= NumberBottles - NumberEmptyBottles)
                    {
                        Console.Write("| o ");
                    }
                    else
                    {
                        Console.Write("| * ");
                    }
                    if (j == Size / 4)
                    {
                        Console.Write("|");
                    }
                    NumberPlacedBottels++;
                }
            }
            if (i == 6)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }

    }
}

