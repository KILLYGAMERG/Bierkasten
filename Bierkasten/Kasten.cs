namespace Bierkasten;

public class Kasten{

    public int NumberBottles { get; set; }
    public String KastenType { get; set; }
    public int NumberEmptyBottles { get; set; } = 0;

    public Kasten(int numberBottles, string name)
    {
        this.NumberBottles = numberBottles;
        this.KastenType = name;
    }

    public void TakeBottle() {
        
    }

    public void CreateSmallKasten(int Size)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == 1 && j == 0 && Size == 11)
                {
                    j++;
                }
                if (i * j >= NumberBottles - NumberEmptyBottles)
                {
                    Console.Write("o");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }
    }
    public void CreateKasten(int Size) {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < Size/4; j++)
            {
                if (i * j >= NumberBottles - NumberEmptyBottles)
                {
                    Console.Write("o");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }
    }
}

