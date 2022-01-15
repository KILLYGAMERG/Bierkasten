using Bierkasten;

namespace Bierkasten;
public class Start
{
    static void Main() {
       
        Console.WriteLine("Hello, World!");
        Kasten myKasten = new Kasten((int)KastenSize.large , "Cola");
        myKasten.CreateKasten((int)KastenSize.large);

    }
   
}