using Bierkasten;
namespace Bierkasten;

public class AbfrageKasten
{

    public int AbfrageKastenAnzahl()
    {
        Console.WriteLine("Wie viele Kästen möchtest du haben?");
        return Convert.ToInt32(Console.ReadLine());
    }

    public Kasten FrageKastenAb(List<Kasten> MeineKastenListe) {
        Console.WriteLine("Was für ein getränk möchtest du haben?"); 
        string EingegebenerName = Console.ReadLine();
        for (int i = 0; i < MeineKastenListe.Count(); i++) {
            if (EingegebenerName.Equals(MeineKastenListe[i].KastenType) && (MeineKastenListe[i].NumberEmptyBottles < MeineKastenListe[i].NumberBottles)) 
            {
                return MeineKastenListe[i];
            }
        }
        Console.WriteLine("Dieses Getränk Hast du nicht zur Auswahl.");
        Console.WriteLine("Probiere es erneut!");
        FrageKastenAb(MeineKastenListe);
        return MeineKastenListe[0];
    }
    
    public int AbfrageKastenGroeße(int NummerKasten)
    {
        Console.WriteLine("Wie Groß soll der " + (NummerKasten  + 1) + " Kasten sein?");
        Start.ListeAlleMöglichkeiten("KastenSize");
        Console.WriteLine("Schreibe die Nummer rein die du haben willst");
        int Nummer = Convert.ToInt32(Console.ReadLine());
        if (ProgrammSafeInt(Nummer))
        {
            return Nummer;
        }
        else
        {
            Console.WriteLine("Probiere es erneut");
            AbfrageKastenGroeße(NummerKasten);
        }
        return 1;
    }

    public int AbfrageKastenArt(int NummerKasten)
    {
        Console.WriteLine("Was für Getränke soll der " + (NummerKasten + 1) + " Kasten haben");
        Start.ListeAlleMöglichkeiten("KastenTypesList");
        Console.WriteLine("Schreibe die Nummer rein die du haben willst");
        int Nummer = Convert.ToInt32(Console.ReadLine());
        if (ProgrammSafeInt(Nummer))
        {
            return Nummer;
        }
        else
        {
            Console.WriteLine("Probiere es erneut");
            AbfrageKastenArt(NummerKasten);
        }
        return 1;
    }

    public bool ProgrammSafeInt(int Zahl)
    {
        if (Zahl < 1 || Zahl > 4)
        {
            return false;
        }
        return true;
    }
}

