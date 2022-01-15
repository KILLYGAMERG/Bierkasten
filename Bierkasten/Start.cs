using Bierkasten;

namespace Bierkasten;
public class Start
{
    static void Main() {
       
        Console.WriteLine("Hello, World!");
        Kasten myKasten = new Kasten((int)KastenSize.small , "Cola");
        myKasten.CreateSmallKasten((int)KastenSize.small);

    }
   
}